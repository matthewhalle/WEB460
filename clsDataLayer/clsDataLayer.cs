using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Text;

namespace clsDataLayer
{
    public class clsDataLayer2
    {
        // Note for week4:Create two functions one to display contents of DB and add an address to the DB which then updates to display the updated DB

        public dsAddress GetAllAddresses(string Path)
        {
            // create connection and variables
            dsAddress DS = new dsAddress();
            // state the DB to connect to from the given path from the page
            var sqlConn = new OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;" + "Data Source=" + Path + "");
            // Query the DB to display contents of DB
            var sqlDA = new OleDbDataAdapter("select * from tblAddressBook", sqlConn);
            // Fill data queried to read
            sqlDA.Fill(DS.tblAddressBook);
            // Return the data query to web page
            return DS;
        }
        public void InsertAddress(string Path, string first, string last, string email, string phone)
        {
            //create connection to DB
            var sqlConn = new OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;" + "Data Source=" + Path + "");
            //Open the DB
            sqlConn.Open();
            //open command statement for changes
            var oCommand = new OleDbCommand();
            oCommand.Connection = sqlConn;

            //The statement to query the DB for display on web page
            var stmt = "INSERT INTO tblAddressBook (FirstName, LastName, Email, PhoneNumber) VALUES ( @first, @last, @email, @phone)";
            oCommand.CommandText = stmt;
            // Add each of the values to the DB
            oCommand.Parameters.AddWithValue("@first", first);
            oCommand.Parameters.AddWithValue("@last", last);
            oCommand.Parameters.AddWithValue("@email", email);
            oCommand.Parameters.AddWithValue("@phone", phone);
            // Display results of adding to DB 
            oCommand.ExecuteNonQuery();
            //close the connection 
            sqlConn.Close();

            // I could not get the code from the iLab enviroment so I rewrote and it was able to work


            /*
            // Add comments
            OleDbConnection sqlConn;
            OleDbCommand oCommand;
            string stmt;
            OleDbParameter param = new OleDbParameter();
            //  Add your comments here
            sqlConn = new OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;" + "Data Source=" + Path + "");
            sqlConn.Open();
            oCommand = new OleDbCommand();
            oCommand.Connection = sqlConn;
            stmt = "INSERT INTO tblAddressBook (FirstName, LastName, Email, PhoneNumber) VALUES ( @first, @last, @email, @phone)";
            
            param.ParameterName = "@first";
            param.Value = first;
            oCommand.Parameters.Add(param);
            param = new OleDbParameter();
            param.ParameterName = "@last";
            param.Value = last;
            oCommand.Parameters.Add(param);
            param = new OleDbParameter();
            param.ParameterName = "@email";
            param.Value = email;
            param = new OleDbParameter();
            param.ParameterName = "@phone";
            param.Value = phone;
            oCommand.Parameters.Add(param);
            oCommand.CommandText = stmt;
            oCommand.CommandType = CommandType.Text;
            oCommand.ExecuteNonQuery();
            sqlConn.Close();
            //oCommand.Parameters.Add(param);*/

        }
        // Start of Week 6 iLab
        public dsAddress FindAddress(string Path, int addressId)
        {
            //  state variables to make connection on query DB
            dsAddress DS;
            OleDbConnection sqlConn;
            OleDbDataAdapter sqlDA;
            string sql;
            //  create string for query and open connection
            sqlConn = new OleDbConnection(("PROVIDER=Microsoft.ACE.OLEDB.12.0;" + ("Data Source=" + (Path + ""))));
            sql = ("select * from tblAddressBook WHERE AddressId = " + Convert.ToString(addressId));
            //  set the connection and query that connection
            sqlDA = new OleDbDataAdapter(sql, sqlConn);
            //  fill variable with queried results and return values
            DS = new dsAddress();
            
            sqlDA.Fill(DS.tblAddressBook);
            
            return DS;
        }

        public void UpdateAddress(string Path, int AddressId, string first, string last, string phone, string email)
        {
            //  same as previous method
            OleDbConnection sqlConn;
            OleDbCommand oCommand;
            string stmt;
            OleDbParameter param;
            // now change text boxe values to DB
            sqlConn = new OleDbConnection(("PROVIDER=Microsoft.ACE.OLEDB.12.0;" + ("Data Source="+ (Path + ""))));
            sqlConn.Open();
            oCommand = new OleDbCommand();
            oCommand.Connection = sqlConn;
            stmt = ("UPDATE tblAddressBook SET FirstName = @first, LastName = @last, Email = @email, PhoneNumber =@phone" + " WHERE(tblAddressBook.AddressId = @id)");
            param = new OleDbParameter();
            param.ParameterName = "@first";
            param.Value = first;
            oCommand.Parameters.Add(param);
            param = new OleDbParameter();
            param.ParameterName = "@last";
            param.Value = last;
            oCommand.Parameters.Add(param);
            param = new OleDbParameter();
            param.ParameterName = "@email";
            param.Value = email;
            oCommand.Parameters.Add(param);
            param = new OleDbParameter();
            param.ParameterName = "@phone";
            param.Value = phone;
            oCommand.Parameters.Add(param);
            param = new OleDbParameter();
            param.ParameterName = "@id";
            param.Value = AddressId;
            oCommand.Parameters.Add(param);
            oCommand.CommandText = stmt;
            oCommand.CommandType = CommandType.Text;
            oCommand.ExecuteNonQuery();
            sqlConn.Close();
        }

        public static bool GetUser(string path, string userId, string password)
        {
            try
            {
                
                OleDbConnection dbConn = new OleDbConnection();
                string strConnection = ("PROVIDER=Microsoft.ACE.OLEDB.12.0;" + ("Data Source=" + path));
                dbConn.ConnectionString = strConnection;
                dbConn.Open();
                OleDbCommand dbCmd = new OleDbCommand();
                dbCmd.Connection = dbConn;
                string strSQL = "SELECT * FROM tblUsers WHERE UserID= @UserID AND Password= @Password AND Access=TRUE";
                dbCmd.CommandText = strSQL;
                dbCmd.Parameters.AddWithValue("@UserID", userId);
                dbCmd.Parameters.AddWithValue("@Password", password);
                object result = dbCmd.ExecuteScalar();
                if (result != null)
                {
                    return true;
                }
                dbConn.Close();
                return false;
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static bool LockAccount(string path, string userId)
        {
            try
            {
            OleDbConnection dbConn = new OleDbConnection();
            string strConnection = ("PROVIDER=Microsoft.ACE.OLEDB.12.0;" + ("Data Source=" + path));
            dbConn.ConnectionString = strConnection;
            dbConn.Open();
            OleDbCommand dbCmd = new OleDbCommand();
            dbCmd.Connection = dbConn;
            string updateSql = ("UPDATE tblUsers SET Access = False WHERE UserID = @UserID");
            dbCmd.CommandText = updateSql;
            dbCmd.Parameters.AddWithValue("@UserID", userId);
            object result = dbCmd.ExecuteScalar();
            if (result != null)
            {
                dbConn.Close();
                return true;
            }
            dbConn.Close();
            return false;
            
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static int LoginAttempts(string path, string userId)
        {
            try
            {
                OleDbConnection dbConn = new OleDbConnection();
                string strConnection = ("PROVIDER=Microsoft.ACE.OLEDB.12.0;" + ("Data Source=" + path));
                dbConn.ConnectionString = strConnection;
                dbConn.Open();
                OleDbCommand dbCmd = new OleDbCommand();
                object returnValue;
                string updateSql = "UPDATE tblUsers SET tblUsers.LoginAttempts = LoginAttempts+1 WHERE tblUsers.UserID = @UserID";
                dbCmd.CommandText = updateSql;
                dbCmd.Parameters.AddWithValue("@UserID", userId);
                System.Threading.Thread.Sleep(1000);
                dbCmd.CommandText = "SELECT LoginAttempts FROM tblUsers WHERE UserID= @UserID";
                dbCmd.Parameters.AddWithValue("@UserID", userId);
                dbCmd.CommandType = CommandType.Text;
                dbCmd.Connection = dbConn;
                returnValue = dbCmd.ExecuteScalar();

                dbConn.Close();
                return Convert.ToInt16(returnValue);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }

}
