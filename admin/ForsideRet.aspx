<%@ Page Title="" Language="C#" MasterPageFile="~/admin/adminMasterPage.master" AutoEventWireup="true" CodeFile="ForsideRet.aspx.cs" Inherits="admin_ForsideRet" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <div class="forside-ret">
        <h2>Ret Forside</h2>
        <h4>Vælg forside du vil rette</h4>
    </div>
        <br />
        <br />
        <asp:Literal ID="litResult" runat="server" />
</asp:Content>

