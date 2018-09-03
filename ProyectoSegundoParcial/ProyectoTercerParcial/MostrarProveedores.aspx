<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MostrarProveedores.aspx.cs" Inherits="ProyectoTercerParcial.MostrarProveedores" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:GridView ID="gvProveedores"  UseAccessibleHeader="true" runat="server" 
    CssClass="table table-hover table-striped" GridLines="None" 
    AutoGenerateColumns="False">
    <Columns>
        <asp:BoundField DataField="idProveedores" HeaderText="ID" Visible="true" />
        <asp:BoundField DataField="Nombre" HeaderText="Nombre" />
        <asp:BoundField DataField="Direccion" HeaderText="Dirección" />
        <asp:BoundField DataField="Telefono" HeaderText="Telefono" />
    </Columns>
    <RowStyle CssClass="cursor-pointer" />
</asp:GridView>
</asp:Content>
