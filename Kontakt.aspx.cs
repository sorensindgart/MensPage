using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Kontakt : System.Web.UI.Page
{
    KontaktFac objKontakt = new KontaktFac();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            DataTable dt = new DataTable();
            dt = objKontakt.Kontakt();

            foreach (DataRow info in dt.Rows)
            {
                litResult.Text += "<h1 id='kontakttitel'>Kontakt</h1>";
                litResult.Text += "<div id='content_kontakt'>";
                litResult.Text += "<h2 class='betingelser'>Adresse:</h2>" + "</br>" + "<p class='plaintext'>" + info["fldAdresse"] +"</p>" + "<br />";
                litResult.Text += "<h2 class='betingelser'>Postnummer:</h2>" + "</br>" + "<p class='plaintext'>" + info["fldPostnummer"] + "</p>" + "<br />";
                litResult.Text += "<h2 class='betingelser'>By:</h2>" + "</br>" + "<p class='plaintext'>" + info["fldBy"] + "</p>"+ "<br />";
                litResult.Text += "<h2 class='betingelser'>Email:</h2>" + "</br>" + "<a href='mailto:contact@menswear.dk'>" + "<p class='plaintext'>" + info["fldEmail"] + "</a><br /><br />";
                
            
            }

            dt = objKontakt.Abningstider();

            litResult.Text += "<h2 class='betingelser'>Åbningstider:</h2> <br /><br />";
            
            foreach (DataRow info in dt.Rows)
            {
                litResult.Text += "<p class='plaintext'>" + "<strong>" + info["fldDag"] + "</strong>"+ ": " + info["fldAbningstid"] + "-" + info["fldLukketid"] + "</p>" + "<br />";
            }
            litResult.Text += "<iframe src='https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d2222.1806473503566!2d10.204552816041744!3d56.15398116844618!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x464c3f9183214fd3%3A0x8e599866a011c18b!2s%C3%98stergade+26%2C+8000+Aarhus+C!5e0!3m2!1sda!2sdk!4v1447018738625' width='650' height='580' frameborder='0' style='border:0' allowfullscreen></iframe>";
            litResult.Text += "</div>";
        }
    }
}