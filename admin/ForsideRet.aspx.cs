using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_ForsideRet : System.Web.UI.Page
{
    ForsideFac objForside = new ForsideFac();
    DataTable dt = new DataTable();

    protected void Page_Load(object sender, EventArgs e)
    {
        dt = objForside.AlleForsider();

        foreach (DataRow sub in dt.Rows)
        {
            litResult.Text += "<div class='forside-ret-list'><a href='ForsideRet_ret.aspx?ret=" + sub["fldID"] + "'>" + sub["fldOverskrift"] + "</a></br /></div>";
        }


    }
}