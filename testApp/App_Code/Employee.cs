using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Web.Configuration;
using System.Data;
using System.Data.SqlClient;


/// <summary>
/// Summary description for Employee
/// </summary>
public class Employee
{
    private string STRCONN = WebConfigurationManager.ConnectionStrings["STRCONN"].ConnectionString.ToString();
    private string strSql;
    private SqlConnection conn;
    private SqlCommand cmd;
    private SqlDataAdapter adp;
    DataTable dt;

    //
    // TODO: Add constructor logic here
    //
	public Employee()
	{
    }

    

    //select data
    public DataTable GetEmployee()
    {
        using(conn = new SqlConnection(STRCONN))
        {
            //build the sql query
            strSql = "SELECT * FROM EMPLOYEE";
            
            //build the command obj
            cmd = new SqlCommand();
            cmd.Connection = conn; //pass the connection obj
            cmd.CommandText = strSql; //pass the sql query string
            cmd.CommandType = CommandType.Text; //specify that you're passing a string not a stored procedure
            //cmd.Parameters.AddWithValue("@keyword", keyword); //pass parameters

            adp = new SqlDataAdapter();
            adp.SelectCommand = cmd;

            dt = new DataTable();

            conn.Open();
            adp.Fill(dt);
            conn.Close();

            return dt;
        }
    }

    //add data

    //edit data

    //delete data
}