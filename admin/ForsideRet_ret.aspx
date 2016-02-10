<%@ Page Title="" Language="C#" MasterPageFile="~/admin/adminMasterPage.master" AutoEventWireup="true" CodeFile="ForsideRet_ret.aspx.cs" Inherits="admin_ForsideRet_ret" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <div id="content2">
        <asp:TextBox ID="txtOverskrift" runat="server" placeholder="Overskrift" CssClass="txtbox-single" />
        <br />
        <asp:TextBox ID="txtTekst" runat="server" TextMode="MultiLine" placeholder="Tekst" CssClass="txtbox-multi" />
        <br />
        <asp:Image ID="imgImage" runat="server" />
        <br />
        <asp:CheckBox ID="chbImg" runat="server" Text="Slet billede" CssClass="pick-image" />
        <br />
        <asp:FileUpload ID="fuImage" runat="server" CssClass="pick-image" />
        <br />
        <asp:Button ID="btnSend" runat="server" Text="Ret" OnClick="btnSend_Click" CssClass="btnDefault" />
        <br />
        <asp:Literal ID="litResult" runat="server" />
    </div>
</asp:Content>

