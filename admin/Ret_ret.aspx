<%@ Page Title="" Language="C#" MasterPageFile="~/admin/adminMasterPage.master" AutoEventWireup="true" CodeFile="Ret_ret.aspx.cs" Inherits="admin_Ret_ret" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <div id="admin-opret">
        <div id="admin-opret-produkt-left">

            <p>Overskrift</p>
            <asp:TextBox ID="txtOverskrift" runat="server" placeholder="Overskrift" autofocus CssClass="txtbox-single" />
            <br />
            <p>Teaser</p>
            <asp:TextBox ID="txtTeaser" runat="server" placeholder="Teaser" TextMode="MultiLine" CssClass="txtbox-multi" />
            <br />
            <p>Tekst</p>
            <asp:TextBox ID="txtTekst" runat="server" placeholder="Tekst" TextMode="MultiLine" CssClass="txtbox-multi" />
            <br />
        </div>
        <div id="admin-opret-produkt-right">
            <p>Pris</p>
            <asp:TextBox ID="txtPris" runat="server" placeholder="Pris" CssClass="txtbox-single" />
            <br />
            <p>Kategori</p>
            <asp:DropDownList ID="ddlKat" runat="server" OnSelectedIndexChanged="ddlKat_SelectedIndexChanged" AutoPostBack="true">
                <asp:ListItem Text="Vælg Overkategori" disabled="disabled" Selected="True"></asp:ListItem>
            </asp:DropDownList>
            <br />
            <p>Under kategori:</p>
            <asp:DropDownList ID="ddlUnderkat" runat="server" />
            <br />
            <p>Billede</p>
            <asp:Image ID="imgImage" runat="server" />
            <br />
            <asp:CheckBox ID="chbImg" runat="server" Text="Slet billede" />
            <br />
            <asp:FileUpload ID="fuImage" runat="server" />
            <br />
            <br />
        </div>
        <div id="admin-opretsend">
            <asp:Button ID="btnSend" runat="server" Text="Ret" OnClick="btnSend_Click" CssClass="btnDefault" />
            <br />
            <asp:Literal ID="litResult" runat="server" />
        </div>
    </div>
</asp:Content>

