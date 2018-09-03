<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AgregarProveedor.aspx.cs" Inherits="ProyectoTercerParcial.AgregarProveedor" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <form>
        <div class="form-group">
            <label for="txtIdProveedor">Id Proveedor</label>
            <asp:TextBox  runat="server" type="text" class="form-control" ID="txtIdProveedor" aria-describedby="emailHelp" placeholder="Ingrese el id del proveedor"/>
        </div>
        <div class="form-group">
            <label for="txtNombreProveedor">Nombre</label>
            <asp:TextBox runat="server" type="text" class="form-control" ID="txtNombreProveedor" placeholder="Nombre del proveedor"/>
        </div>
        <div class="form-group">
            <label for="txtDireccionProveedor">Dirección</label>
            <asp:TextBox  runat="server" type="text" class="form-control" ID="txtDireccionProveedor" placeholder="Password"/>
        </div>
        <div class="form-group">
            <label for="txtTelefono">Telefono</label>
            <asp:TextBox runat="server" type="text" class="form-control" ID="txtTelefono" placeholder="Telefono del proveedor"/>
        </div>
        <asp:Button runat="server" ID="btnAgregarProveedor" OnClick="btnAgregarProveedor_Click" type="submit" class="btn btn-primary" Text="Agregar"></asp:Button>
    </form>
</asp:Content>
