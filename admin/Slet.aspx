<%@ Page Title="" Language="C#" MasterPageFile="~/admin/adminMasterPage.master" AutoEventWireup="true" CodeFile="Slet.aspx.cs" Inherits="admin_Slet" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="forside-slet">
        <h2>Slet Produkt</h2>
        <h4>Hvilket Produkt vil du slette?</h4>
    </div>
    <asp:Literal ID="litProdukter" runat="server" />

</asp:Content>

