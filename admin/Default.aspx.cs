using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_Default : System.Web.UI.Page
{
    ProduktFac objProdukt = new ProduktFac();
    protected void Page_Init(object sender, EventArgs e)
    {
        DataTable dt = new DataTable();
        dt = objProdukt.SenesteProdukt();

        foreach (DataRow produkt in dt.Rows)
        {
            litResult.Text += "<a target='_blank' href='../Produkt.aspx?produktid=" + produkt["fldID"] + "'><img src='../img/" + produkt["fldBillede"] + "'/></a><br /><h2>" + produkt["fldOverskrift"] + "</h2><br />";
        }
    }

    protected void Page_Load(object sender, EventArgs e)
    {

    }
}