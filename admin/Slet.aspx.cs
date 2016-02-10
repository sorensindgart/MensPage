using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_Slet : System.Web.UI.Page
{
    ProduktFac objProdukt = new ProduktFac();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(Request.QueryString["sletid"]))
        {
            SletProdukt();
        }
        DataTable dt = new DataTable();
        dt = objProdukt.AlleProdukter();

        foreach (DataRow sub in dt.Rows)
        {
            litProdukter.Text += "<div class='opret-slet-list'><a href='Slet.aspx?sletid=" + sub["fldID"] + "' onclick='return confirm (\"Er du sikker på at du vil slette dette produkt?\")'>" + sub["fldOverskrift"] + "</a><br /></div>";
        }

    }

    protected void SletProdukt()
    {
        objProdukt._id = Convert.ToInt32(Request.QueryString["sletid"]);
        objProdukt.SletProdukt(); // from SQL FAC
        Response.Redirect("Slet.aspx");
    }

}