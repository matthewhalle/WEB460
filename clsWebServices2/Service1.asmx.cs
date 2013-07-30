using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;
using System.Data.SqlClient;

namespace clsWebServices2
{
    /// <summary>
    /// Summary description for Service1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Service1 : System.Web.Services.WebService
    {

        [WebMethod]
        public dsAddress FindAddress(string LastName, string Path)
        {

	        // bring in the queryed last name and path of data source
            // Declar variables to use to open and read dataset
            var DS = new dsAddress();
            var sqlConn = new OleDbConnection();
            var sqlDA = new OleDbDataAdapter();
	       
	        // create connection and adapter variables
	        sqlConn = new OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;" + "Data Source=" + Path + "");

	        // query the last name 
	        sqlDA = new OleDbDataAdapter("select * from tblAddressBook where LastName like '" + LastName + "'", sqlConn);
            
	        // set return value of searched query
	        sqlDA.Fill(DS.tblAddressBook);

	        // bring value back to form
	        return DS;

        }

    }
}