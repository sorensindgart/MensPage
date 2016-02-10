using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Produkter : System.Web.UI.Page
{
    ProduktFac objProdukt = new ProduktFac();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            DataTable dt = new DataTable();
            dt = objProdukt.AlleProdukter();

            foreach (DataRow produkt in dt.Rows)
            {
                litResult.Text += "<div id='produkt-page'><div class='produkt-image'><a href='Produkt.aspx?produktid=" + produkt["fldID"] + "'><img src='img/" + produkt["fldBillede"] + "'/></div><br /><h2 class='produkt-overskrift'>" + produkt["fldOverskrift"] + "</h2><br /><p class='produkt-pris'>" + produkt["fldPris"] + "kr</p><br /><p class='produkt-tekst'>" + produkt["fldTeaser"] + "<br /></p><br /></div>";
            }
        }
    }
}