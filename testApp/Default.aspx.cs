using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : Page
{
    Employee emp;

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
        emp = new Employee();
        gvSample.DataSource = emp.GetEmployee(txtSearch.Text);
        gvSample.DataBind();
    }
}