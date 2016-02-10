<%@ Page Title="" Language="C#" MasterPageFile="~/admin/adminMasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="admin_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h2 style="color: white; font-size: 22px; text-align: center; margin-top: 30px;">Hvor vil du lave ændringer?</h2>
    <h2 style="color: white; font-size: 18px; text-align: center; margin-top: 30px;">Seneste produkt tilføjet</h2>

    <div id="seneste_produkt">
        <asp:Literal ID="litResult" runat="server" />
    </div>
</asp:Content>

