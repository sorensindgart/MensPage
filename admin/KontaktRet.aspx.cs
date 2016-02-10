using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_KontaktRet : System.Web.UI.Page
{
    KontaktFac objKontakt = new KontaktFac();
    DataTable dt = new DataTable();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
                dt = objKontakt.Kontakt();

                txtAdresse.Text = dt.Rows[0]["fldAdresse"].ToString();
                txtPostnummer.Text = dt.Rows[0]["fldPostnummer"].ToString();
                txtBy.Text = dt.Rows[0]["fldBy"].ToString();
                txtEmail.Text = dt.Rows[0]["fldEmail"].ToString();
        }

    }
    protected void btnSend_Click(object sender, EventArgs e)
    {
        objKontakt._adresse = txtAdresse.Text;
        objKontakt._postnummer = txtPostnummer.Text;
        objKontakt._by = txtBy.Text;
        objKontakt._email = txtEmail.Text;

        int updatedsubjects = objKontakt.RetKontakt();

        if (updatedsubjects > 0)
        {

            litResult.Text = "<h4>Updated!</h4>";
        }
        else
        {
            litResult.Text = "<h4>Failed!</h4>";
        }

    }
}