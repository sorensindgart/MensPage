using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_ForsideOpret : System.Web.UI.Page
{
    ForsideFac objForside = new ForsideFac();
    DataTable dt = new DataTable();

    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnSend_Click(object sender, EventArgs e)
    {
        string imagename = "test.jpg";

        if (fuImage.HasFile)
        {
            imagename = PictureSave.SavePicture(fuImage.PostedFile, "img_forside/", 300);
        }

        objForside._image = imagename;
        objForside._overskrift = txtOverskrift.Text;
        objForside._tekst = txtTekst.Text;

        int addedsubject = objForside.OpretForside();

        if (addedsubject > 0)
        {
            txtOverskrift.Text = "";
            txtTekst.Text = "";

            litResult.Text = "<h4>Forside submitted!";
        }
        else
        {
            litResult.Text = "<h4>Error!";
        }
    }
}