using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WEB_460.Week5
{
    public partial class frmEmployees : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {

                if (!Page.IsPostBack)
                {
                    GetAllEmployees();
                }
                else
                {
                    DataSet employeeSet = null;

                    //rebind the GridView object with the cached copy of the dataset

                    employeeSet = Session["EmployeesDataset"] as DataSet;

                    gvEmployees.DataSource = employeeSet;

                    gvEmployees.DataBind();

                }


            }
            catch (Exception ex)
            {
                lblStatus.Text = "Error has happened. " + ex.Message;

            }

        }
        public void GetAllEmployees()
        {
            DataSet myEmployeeSet = new DataSet();

            //read the xml file to the dataset object

            myEmployeeSet.ReadXml(Server.MapPath("employees.xml"));

            gvEmployees.DataSource = myEmployeeSet;

            gvEmployees.DataBind();

            //keep the dataset in the Session object to insure its persistence between postbacks so it is used to

            //refresh the ViewGrid between postbacks

            Session.Add("EmployeesDataset", myEmployeeSet);

        }
        public void AddEmployee(string name, string age, string gender, string salary)
        {
            DataSet EmployeeSet = default(DataSet);

            DataRow NewEmployeeRow = default(DataRow);

            //get the employees dataset from the cach, and add the new employee to it

            EmployeeSet = Session["EmployeesDataset"] as DataSet;
            

            NewEmployeeRow = EmployeeSet.Tables[0].NewRow();
            // add new row to the dataset's table

            //assign the fields to the columns of the newly created row

            NewEmployeeRow[0] = name;

            NewEmployeeRow[1] = age;

            NewEmployeeRow[2] = gender;

            NewEmployeeRow[3] = salary;

            EmployeeSet.Tables[0].Rows.Add(NewEmployeeRow);
            //add it

            EmployeeSet.WriteXml(Server.MapPath("employees.xml"));

            //rebind the ViewGrid to view the newly added employee record

            gvEmployees.DataSource = EmployeeSet;

            gvEmployees.DataBind();

        }

        protected void btnAddEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                AddEmployee(txtName.Text, txtAge.Text, DropGender.SelectedValue, txtSalary.Text);


            }
            catch (Exception ex)
            {
                lblStatus.Text = "Error has happened. " + ex.Message;

            }
        }


    }
}