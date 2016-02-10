using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    ProduktFac objProdukt = new ProduktFac();
    ForsideFac objForside = new ForsideFac();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            DataTable dt = new DataTable();
            dt = objProdukt.RandomProdukt();

            foreach (DataRow produkt in dt.Rows)
            {
                litResult.Text += "<h2 style='text-align: center; font-size: 22px; font-weight: 700; margin-top: 10px;'>" + produkt["fldOverskrift"] + "</h2><br /><a href='Produkt.aspx?produktid=" + produkt["fldID"] + "'><img style='display: block; margin: 0 auto;' src='img/" + produkt["fldBillede"] + "'/></a><br /><h3 style='font-size: 28px; text-align: center; background-color: black; color: white;'>" + produkt["fldPris"] + ",-</h3><br /><br />" + "<p id='forsidetext'>" + produkt["fldTeaser"] + "</p>";
            }

            dt = objForside.SenesteForside();

            foreach (DataRow forside in dt.Rows)
            {
                litForside.Text += "<h2 id='forsidetitel'style='text-align: justify; font-size: 38px; font-weight: 700; margin-left: 30px; margin-top: 10px;'>" + forside["fldOverskrift"] + "</h2><img style='display: block; float='left' ;' src='img_forside/" + forside["fldBillede"] + "'/></a><br /><p id='forsidetext' style='padding: 10px;'>" + forside["fldTekst"] + "</p><br /><br />";
            }
        }
    }
    protected void btnNewsletter_Click(object sender, EventArgs e)
    {
        litNewsletter.Text = "<p style='text-align: justify'>Du er nu tilmeldt nyhedsbrevet!</p>";
    }
}