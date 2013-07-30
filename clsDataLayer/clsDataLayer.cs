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
        // Create two functions one to display contents of DB and add an address to the DB which then updates to display the updated DB

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



    }

}
