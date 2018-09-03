<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Productos.aspx.cs" Inherits="ProyectoTercerParcial.Productos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
   <div class="jumbotron">
        <h1>100 CP</h1>
        <p class="lead">PROFE NO SE LE OLVIDE PONERME MI 100 :) .</p>
       
    </div>

    <div class="row">
        <div class="col-md-12">
            <h2>Seleccione la opción que desee</h2>
            <asp:DropDownList runat="server" CssClass="form-control" ID="ddlSeleccionOpcionProducto" 
                OnSelectedIndexChanged="ddlSeleccionOpcionProducto_SelectedIndexChanged" AutoPostBack="true">
                <asp:ListItem Text="Seleccione" Value="SELECCIONAR" Selected="true"></asp:ListItem>
                <asp:ListItem Text="Alta de producto" Value="ALTA" Selected="false"></asp:ListItem>
                <asp:ListItem Text="Actualiza producto" Value="ACTUALIZACION" Selected="false"></asp:ListItem>
                <asp:ListItem Text="Baja de producto" Value="BAJA" Selected="false"></asp:ListItem>
                <asp:ListItem Text="Listado de productos" Value="LISTADO" Selected="false"></asp:ListItem>
            </asp:DropDownList>
        </div>
    </div>
</asp:Content>
