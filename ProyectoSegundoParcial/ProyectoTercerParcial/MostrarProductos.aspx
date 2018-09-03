<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MostrarProductos.aspx.cs" Inherits="ProyectoTercerParcial.MostrarProductos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
      <asp:GridView ID="gvProductos"  UseAccessibleHeader="true" runat="server" 
    CssClass="table table-hover table-striped" GridLines="None" 
    AutoGenerateColumns="False">
    <Columns>
        <asp:BoundField DataField="idProductos" HeaderText="ID" Visible="true" />
        <asp:BoundField DataField="Nombre" HeaderText="Nombre" />
        <asp:BoundField DataField="Codigo" HeaderText="Codigo" />
        <asp:BoundField DataField="PrecioProveedor" HeaderText="Precio Proveedor" />
        <asp:BoundField DataField="PrecioVenta" HeaderText="Precio Venta" />
        <asp:BoundField DataField="Proveedores_idProveedores" HeaderText="Id Proveedor" />
        <asp:BoundField DataField="Cantidad" HeaderText="Cantidad" />
    </Columns>
    <RowStyle CssClass="cursor-pointer" />
</asp:GridView>
</asp:Content>
