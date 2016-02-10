using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_ForsideSlet : System.Web.UI.Page
{
    ForsideFac objForside = new ForsideFac();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(Request.QueryString["sletid"]))
        {
            SletForside();
        }
        DataTable dt = new DataTable();
        dt = objForside.AlleForsider();

        foreach (DataRow sub in dt.Rows)
        {
            litForside.Text += "<div class='forside-slet-list'><a href='ForsideSlet.aspx?sletid=" + sub["fldID"] + "' onclick='return confirm (\"Er du sikker på at du vil slette denne forside?\")'>" + sub["fldOverskrift"] + "</a><br /><br /></div>";
        }

    }

    protected void SletForside()
    {
        objForside._id = Convert.ToInt32(Request.QueryString["sletid"]);
        objForside.SletForside(); // from SQL FAC
        Response.Redirect("ForsideSlet.aspx");
    }

}