<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Proveedores.aspx.cs" Inherits="ProyectoTercerParcial.Proveedores" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">
        <h1>100 CP</h1>
        <p class="lead">PROFE NO SE LE OLVIDE PONERME MI 100 :) .</p>
    </div>

    <div class="row">
        <div class="col-md-12">
            <h2>Seleccione la opción que desee</h2>
            <asp:DropDownList runat="server" CssClass="form-control" ID="ddlSeleccionOpcionProveedores" 
                OnSelectedIndexChanged="ddlSeleccionOpcionProveedores_SelectedIndexChanged" AutoPostBack="true">
                <asp:ListItem Text="Seleccione" Value="SELECCIONAR" Selected="true"></asp:ListItem>
                <asp:ListItem Text="Alta de proveedor" Value="ALTA" Selected="false"></asp:ListItem>
                <asp:ListItem Text="Actualiza proveedor" Value="ACTUALIZACION" Selected="false"></asp:ListItem>
                <asp:ListItem Text="Baja de proveedor" Value="BAJA" Selected="false"></asp:ListItem>
                <asp:ListItem Text="Listado de proveedores" Value="LISTADO" Selected="false"></asp:ListItem>
            </asp:DropDownList>
        </div>
    </div>
</asp:Content>
