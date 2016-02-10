using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_Opret : System.Web.UI.Page
{
    ProduktFac objProdukt = new ProduktFac();
    KategoriFac objKat = new KategoriFac();
    DataTable dt = new DataTable();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            dt = objKat.HentAlleKategorier();

            foreach (DataRow kategori in dt.Rows)
            {
                ListItem li = new ListItem(kategori["fldKategori"].ToString(), kategori["fldKatID"].ToString());
                ddlKat.Items.Add(li);
            }
        }
    }

    protected void btnSend_Click1(object sender, EventArgs e)
    {
        string imagename = "test.jpg";

        if (fuImage.HasFile)
        {
            imagename = PictureSave.SavePicture(fuImage.PostedFile, "img/", 300);
        }

        objProdukt._image = imagename;
        objProdukt._overskrift = txtOverskrift.Text;
        objProdukt._teaser = txtTeaser.Text;
        objProdukt._tekst = txtTekst.Text;
        objProdukt._pris = txtPris.Text;
        objProdukt._katID = Convert.ToInt32(ddlUnderkat.SelectedValue);

        int addedsubject = objProdukt.OpretProdukt();

        if (addedsubject > 0)
        {
            txtOverskrift.Text = "";
            txtTeaser.Text = "";
            txtTekst.Text = "";
            txtPris.Text = "";

            litResult.Text = "<h4>Subject submitted!";
        }
        else
        {
            litResult.Text = "<h4>Error!";
        }
    }
    protected void ddlKat_SelectedIndexChanged(object sender, EventArgs e)
    {
        int valgt_kategori = Convert.ToInt32(ddlKat.SelectedValue);
        dt = objKat.HentUnderKategorier(valgt_kategori);
        ddlUnderkat.Items.Clear();

        foreach (DataRow kategori in dt.Rows)
        {
            ListItem li = new ListItem(kategori["fldKategori"].ToString(), kategori["fldKatID"].ToString());
            ddlUnderkat.Items.Add(li);
        }
    }
}