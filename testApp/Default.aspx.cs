using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : Page
{
    Employee_Helper emp;

    protected void Page_Load(object sender, EventArgs e)
    {
        if(!Page.IsPostBack)
        {
            bindGridview();
        }
    }

    protected void btnSearch_Click(object sender, EventArgs e)
    {
        bindGridview();
    }

    protected void bindGridview()
    {
        emp = new Employee_Helper();
        gvSample.DataSource = emp.GetEmployee();
        gvSample.DataBind();
    }
    protected void EmployeeDataSource_Selecting(object sender, LinqDataSourceSelectEventArgs e)
    {
       
    }
    protected void gvSample_Sorting(object sender, GridViewSortEventArgs e)
    {

    }
}