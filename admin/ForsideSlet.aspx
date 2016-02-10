<%@ Page Title="" Language="C#" MasterPageFile="~/admin/adminMasterPage.master" AutoEventWireup="true" CodeFile="ForsideSlet.aspx.cs" Inherits="admin_ForsideSlet" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="forside-slet">
        <h2>Slet Forside</h2>
        <h4>Hvilke Forside vil du slette?</h4>
    </div>
    <asp:Literal ID="litForside" runat="server" />

</asp:Content>

