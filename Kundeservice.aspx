<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Kundeservice.aspx.cs" Inherits="Kundeservice" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <div id="kundeservice">
        <ul>
            <li><a href="Kobsbetingelser.aspx"><h3 class="betingelser">Købsbetingelser</h3><i class="fa fa-credit-card fa-4x"></i></a></li>
            <li><a href="Cookies.aspx"><h3 class="betingelser">Cookies</h3><i class="fa fa-info fa-4x"></i></a></li>
            <li><a href="Kontakt.aspx"><h3 class="betingelser">Kontakt</h3><i class="fa fa-phone fa-4x"></i></a></li>
        </ul>
    </div>
</asp:Content>

