using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_Ret_ret : System.Web.UI.Page
{
    ProduktFac objProdukt = new ProduktFac();
    KategoriFac objKat = new KategoriFac();
    DataTable dt = new DataTable();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (!string.IsNullOrEmpty(Request.QueryString["ret"]))
            {
                objProdukt._id = Convert.ToInt32(Request.QueryString["ret"]);


                // Find produktet
                dt = objProdukt.ProduktFraID();
                
                if (!IsPostBack)
                {
                    ShowSubject();

                }

                txtOverskrift.Text = dt.Rows[0]["fldOverskrift"].ToString();
                txtTeaser.Text = dt.Rows[0]["fldTeaser"].ToString();
                txtTekst.Text = dt.Rows[0]["fldTekst"].ToString();
                txtPris.Text = dt.Rows[0]["fldPris"].ToString();

                // OVER OG UNDERKATEGORI - indlæs i DDL og marker produktets kategori og kategoriens overkategori
                
                // Indlæs overkategorier (alle) i DDL
                DataTable dt2 = new DataTable();
                dt2 = objKat.HentAlleKategorier();
                foreach (DataRow kategori in dt2.Rows)
                {
                    ListItem li = new ListItem(kategori["fldKategori"].ToString(), kategori["fldKatID"].ToString());
                    ddlKat.Items.Add(li);
                }

                // Find produktets kategoris overkategori
                dt2 = objKat.HentOverkategoriUdFraProdukt(Convert.ToInt32(Request.QueryString["ret"]));
                int overkatid = Convert.ToInt32(dt2.Rows[0]["fldKatID"]);
                
                // Find overkategoriens underkategorier og indlæs i DDL
                dt2 = objKat.HentUnderKategorier(overkatid);
                foreach (DataRow kategori in dt2.Rows)
                {
                    ListItem li = new ListItem(kategori["fldKategori"].ToString(), kategori["fldKatID"].ToString());
                    ddlUnderkat.Items.Add(li);
                }

                // SELECT produktets (underkategoriens) OVERkategori ud fra underkategoriens parent
                ddlKat.SelectedValue = overkatid.ToString();
                // SELECT produktets kategori (= en underkategori)
                ddlUnderkat.SelectedValue = dt.Rows[0]["fldKatID_fk"].ToString();

            }
            else
            {
                Response.Redirect("Ret.aspx");
            }
        }
    }
    protected void btnSend_Click(object sender, EventArgs e)
    {
        objProdukt._id = Convert.ToInt32(Request.QueryString["ret"]);
        dt = objProdukt.ProduktFraID();

        string imagename;

        objProdukt._overskrift = txtOverskrift.Text;
        objProdukt._teaser = txtTeaser.Text;
        objProdukt._tekst = txtTekst.Text;
        objProdukt._pris = txtPris.Text;
        objProdukt._katID = Convert.ToInt32(ddlUnderkat.SelectedValue);



        if ((chbImg.Checked || fuImage.HasFile) && !string.IsNullOrEmpty(dt.Rows[0]["fldBillede"].ToString()))
        {
            IOFunctions.DeleteFile(Server.MapPath("../img/") + dt.Rows[0]["fldBillede"]);
            imagename = ""; // Så img-navn bliver slettet i DB ved slet
        }

        else
        {
            imagename = dt.Rows[0]["fldBillede"].ToString();
        }

        if (fuImage.HasFile)
        {
            imagename = PictureSave.SavePicture(fuImage.PostedFile, "../img/Nyheder/", 580);
        }
        objProdukt._image = imagename;

        int updatedsubjects = objProdukt.RetProdukt();

        if (updatedsubjects > 0)
        {

            litResult.Text = "<h4>Updated!</h4>";
        }
        else
        {
            litResult.Text = "<h4>Failed!</h4>";
        }
    }

    protected void ShowSubject()
    {
        if (!string.IsNullOrEmpty(dt.Rows[0]["fldBillede"].ToString()))
        {
            imgImage.ImageUrl = "../img/" + dt.Rows[0]["fldBillede"].ToString();
            imgImage.Visible = true; // Gør img synligt
            chbImg.Visible = true; // Gør slet-img-checkbox synlig
        }
        else
        {
            // Hvis der ikke er et billede i db...
            imgImage.Visible = false; // Skjul img-container/tomt image
            chbImg.Visible = false; // Skjul slet-img-checkbox
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