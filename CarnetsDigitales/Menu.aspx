<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra.Master" AutoEventWireup="true" CodeBehind="Menu.aspx.cs" Inherits="CarnetsDigitales.Menu" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style7 {
        border-style: none;
        border-color: inherit;
        border-width: medium;
        margin-left: 5%;
        margin-top: 5%;
        text-align: center;
        width: 954px;
        height: 374px;
    }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Contenido" runat="server">
    
    <div class="auto-style7">   
        <asp:Button ID="btnCarnet" class="btnMenu" Text="Carnet" runat="server" />
        <asp:Button onclick="btnConsultas_Click" class="btnMenu" ID="btnConsultas" Text="Consultas" runat="server" />
        <asp:Button ID="btnArbitros" class="btnMenu" Text="Registro Árbitros" runat="server" />
        <asp:Button ID="btnClubes" class="btnMenu" Text="Registro Clubes" runat="server" />
        <asp:Button ID="btnEntrenadores" class="btnMenu" Text="Registro Entrenadores" runat="server" />
        <asp:Button ID="btnEquipos" class="btnMenu" Text="Registro Equipos" runat="server" />
        <asp:Button ID="btnJugadores" class="btnMenu" Text="Registro Jugadores" runat="server" />

    </div>
<%--    <table class="tabla" style="width:600px; text-align:center">
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
       
    </table>   --%>
</asp:Content>
