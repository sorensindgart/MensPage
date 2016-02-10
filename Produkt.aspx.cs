using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Produkt : System.Web.UI.Page
{
    ProduktFac objProdukt = new ProduktFac();
    DataTable dt = new DataTable();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (!string.IsNullOrEmpty(Request.QueryString["produktid"]))
            {
                objProdukt._id = Convert.ToInt32(Request.QueryString["produktid"]);

                DataTable dt = new DataTable();
                dt = objProdukt.ProduktFraID();

                foreach (DataRow produkt in dt.Rows)
                {
                    litResult.Text += "<div id='produkt-page'><div class='produkt-image'><img src='img/" + produkt["fldBillede"] + "'/></div><br /><h2 class='produkt-overskrift'>" + produkt["fldOverskrift"] + "</h2><br /><p class='produkt-pris'>" + produkt["fldPris"] + "kr</p><br /><p class='produkt-tekst'>" + produkt["fldTekst"] + "<br /></p><br /></div>";
                }

            }
            else
            {
                Response.Redirect("Default.aspx");
            }
        }

    }
}