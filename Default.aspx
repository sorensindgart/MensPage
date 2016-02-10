<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
        <div id="forside">
            <div id="forside-newproduct">
                <asp:Literal ID="litResult" runat="server" />
            </div>

            <div id="forside-tekst">
                <asp:Literal ID="litForside" runat="server" />
            </div>
        </div>

        <div id="newsletter">
            <h3>Nyhedsbrev</h3>
            <br />
            <p id="forsidetext">Tilmeld dig The Architects elektroniske nyhedsbrev! <br /><br /> Så bliver du hver måned orienteret om de bedste tilbud fra The Architect!</p>
            <br />
            <br />
            <asp:TextBox ID="txtNewsletter" runat="server" placeholder="Indsæt e-mail" CssClass="txtbox-single-tilmeld" />
            <br />
            <asp:Literal ID="litNewsletter" runat="server" />
            <br />
            <asp:Button ID="btnNewsletter" runat="server" Text="Tilmeld" CssClass="btnTilmeld" OnClick="btnNewsletter_Click" />
        </div>

        <a href="#"><div id="catelog"></div></a>
</asp:Content>