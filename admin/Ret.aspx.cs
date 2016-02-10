using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_Ret : System.Web.UI.Page
{
    ProduktFac objProdukt = new ProduktFac();
    DataTable dt = new DataTable();
    protected void Page_Load(object sender, EventArgs e)
    {
        dt = objProdukt.AlleProdukter();

        foreach (DataRow sub in dt.Rows)
        {
            litResult.Text += "<div class='opret-ret-list'><a href='Ret_ret.aspx?ret=" + sub["fldID"] + "'>" + sub["fldOverskrift"] + "</a></br /></div>";
        }

    }
}