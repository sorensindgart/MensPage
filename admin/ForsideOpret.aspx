<%@ Page Title="" Language="C#" MasterPageFile="~/admin/adminMasterPage.master" AutoEventWireup="true" CodeFile="ForsideOpret.aspx.cs" Inherits="admin_ForsideOpret" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div id="content2">
        <asp:TextBox ID="txtOverskrift" runat="server" placeholder="Overskrift" CssClass="txtbox-single" />
        <br />
        <asp:TextBox ID="txtTekst" runat="server" TextMode="MultiLine" placeholder="Tekst" CssClass="txtbox-multi" />
        <br />
        <asp:FileUpload ID="fuImage" runat="server" CssClass="pick-image" />
        <br />
        <asp:Button ID="btnSend" runat="server" Text="Opret" OnClick="btnSend_Click" CssClass="btnDefault" />
        <br />
        <asp:Literal ID="litResult" runat="server" />
    </div>
</asp:Content>

