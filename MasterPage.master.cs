using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // Når siden indlæses, tjekker vi først om en cookie allerede eksisterer.
        // Hvis ja, skjules Panelet der informerer om cookies

        if (Request.Cookies["mitwebsiteCookie"] != null)
        {
            // En Cookie eksisterer - skjuler derfor Panelet der viser beskaden om cookies
            pnlCookies.Visible = false;

            // Som en lille service for brugeren, forlænger vi lige cookien med et år.
            // Det gøres nemmest ved at oprette en cookie med samme navn som den gamle cookie:
            HttpCookie cookieAccept = new HttpCookie("mitwebsiteCookie");
            cookieAccept.Values["acceptedCookie"] = "Cookies accepteret";
            cookieAccept.Expires = DateTime.Now.AddDays(1); // Husker valget i et år
            Response.Cookies.Add(cookieAccept);
        }
    }
    protected void lbnAccepterCookies_Click(object sender, EventArgs e)
    {
        // Bruger har klikket på "Accepter cookies"... en cookie oprettes
        HttpCookie cookieAccept = new HttpCookie("mitwebsiteCookie");
        cookieAccept.Values["acceptedCookie"] = "Cookies accepteret";
        cookieAccept.Expires = DateTime.Now.AddDays(1); // Husker valget i et år
        Response.Cookies.Add(cookieAccept);
        //Response.Redirect(Request.RawUrl);
        //System.Threading.Thread.Sleep(5000); // Refresher siden.

        // Nu er cookien oprettet - kan nu skjule Panelet der viser besked om cookies
        pnlCookies.Visible = false;
    }
}
