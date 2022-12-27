<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra.Master" AutoEventWireup="true" CodeBehind="Menu.aspx.cs" Inherits="CarnetsDigitales.Menu" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 249px;
        }
        .auto-style3 {
            width: 249px;
            height: 32px;
        }
        .auto-style4 {
            width: 433px;
        }
        .auto-style5 {
            width: 433px;
            height: 32px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Contenido" runat="server">
    
    <table class="tabla" style="width:600px; text-align:center">
        <tr style="column-width:100px;">
            <td ><asp:Button ID="btnCarnets" class="btnMenu" Text="Carnets" runat="server" /></td>
            <td ><asp:Button onclick="btnConsultas_Click" class="btnMenu" ID="btnConsultas" Text="Consultas" runat="server" /></td>
        </tr>
         <tr">
            <td > <asp:Button ID="btnArbitros" class="btnMenu" Text="Registro Árbitros" runat="server" /></td>
            <td ><asp:Button ID="btnClubes" class="btnMenu" Text="Registro Clubes" runat="server" /></td>
        </tr>
        <tr>
            <td ><asp:Button ID="btnEntrenadores" class="btnMenu" Text="Registro Entrenadores" runat="server" /></td>
            <td ><asp:Button ID="btnEquioos" class="btnMenu" Text="Registro Equipos" runat="server" /></td>
        </tr>
         <tr>
            <td ><asp:Button ID="btnJugadores" class="btnMenu" Text="Registro Jugadores" runat="server" /></td>            
        </tr>
       
    </table>   
</asp:Content>
