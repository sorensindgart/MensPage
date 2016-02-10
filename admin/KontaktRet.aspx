<%@ Page Title="" Language="C#" MasterPageFile="~/admin/adminMasterPage.master" AutoEventWireup="true" CodeFile="KontaktRet.aspx.cs" Inherits="admin_KontaktRet" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div id="content2">
        <asp:TextBox ID="txtAdresse" runat="server" CssClass="txtbox-single" />
        <br />
        <asp:TextBox ID="txtPostnummer" runat="server" CssClass="txtbox-single" />
        <br />
        <asp:TextBox ID="txtBy" runat="server" CssClass="txtbox-single" />
        <br />
        <asp:TextBox ID="txtEmail" runat="server" CssClass="txtbox-single" />
        <br />
        <asp:Button ID="btnSend" runat="server" Text="Update" OnClick="btnSend_Click" CssClass="btnDefault" />
        <br />
        <asp:Literal ID="litResult" runat="server" />
    </div>
</asp:Content>

