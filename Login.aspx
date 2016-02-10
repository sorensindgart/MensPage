<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <div id="content2">
        <asp:TextBox ID="txtUser" runat="server" autofocus placeholder="Username" CssClass="txtbox-single" />
        <br />
        <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" placeholder="Password" CssClass="txtbox-single" />
        <br />
        <asp:Button ID="btnSend" runat="server" Text="Login" OnClick="btnSend_Click" CssClass="btnDefault" />
        <br />
        <asp:Literal ID="litResult" runat="server" />
    </div>
</asp:Content>

