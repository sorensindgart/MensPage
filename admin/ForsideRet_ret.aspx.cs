using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_ForsideRet_ret : System.Web.UI.Page
{
    ForsideFac objForside = new ForsideFac();
    DataTable dt = new DataTable();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (!string.IsNullOrEmpty(Request.QueryString["ret"]))
            {
                objForside._id = Convert.ToInt32(Request.QueryString["ret"]);

                dt = objForside.ForsideFraID();
                if (!IsPostBack)
                {
                    ShowSubject();
                }

                txtOverskrift.Text = dt.Rows[0]["fldOverskrift"].ToString();
                txtTekst.Text = dt.Rows[0]["fldTekst"].ToString();
            }
            else
            {
                Response.Redirect("Ret.aspx");
            }
        }

    }
    protected void btnSend_Click(object sender, EventArgs e)
    {
        objForside._id = Convert.ToInt32(Request.QueryString["ret"]);
        dt = objForside.ForsideFraID();

        string imagename;

        objForside._overskrift = txtOverskrift.Text;
        objForside._tekst = txtTekst.Text;

        if ((chbImg.Checked || fuImage.HasFile) && !string.IsNullOrEmpty(dt.Rows[0]["fldBillede"].ToString()))
        {
            IOFunctions.DeleteFile(Server.MapPath("../img_forside/") + dt.Rows[0]["fldBillede"]);
            imagename = ""; // Så img-navn bliver slettet i DB ved slet
        }

        else
        {
            imagename = dt.Rows[0]["fldBillede"].ToString();
        }

        if (fuImage.HasFile)
        {
            imagename = PictureSave.SavePicture(fuImage.PostedFile, "img_forside/", 300);
        }
        objForside._image = imagename;

        int updatedsubjects = objForside.RetForside();

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
            imgImage.ImageUrl = "../img_forside/" + dt.Rows[0]["fldBillede"].ToString();
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

}