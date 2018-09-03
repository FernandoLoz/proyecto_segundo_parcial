<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ActualizarProducto.aspx.cs" Inherits="ProyectoTercerParcial.ActualizarProducto" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <form>
        <div class="form-group">
            <label for="txtIdProducto">Id Producto</label>
            <asp:TextBox  runat="server" type="text" class="form-control" ID="txtIdProducto" aria-describedby="emailHelp" placeholder="Ingrese el id del producto"/>
        </div>
        <div class="form-group">
            <label for="txtNombreProducto">Nombre</label>
            <asp:TextBox runat="server" type="text" class="form-control" ID="txtNombreProducto" placeholder="Nombre del producto"/>
        </div>
          <div class="form-group">
            <label for="txtCodigo">Codigo</label>
            <asp:TextBox runat="server" type="text" class="form-control" ID="txtCodigo" placeholder="Codigo"/>
        </div>
          <div class="form-group">
            <label for="txtPrecioProveedor">Precio proveedor</label>
            <asp:TextBox runat="server" type="text" class="form-control" ID="txtPrecioProveedor" placeholder="Precio proveedor"/>
        </div>
          <div class="form-group">
            <label for="txtPrecioVenta">Precio venta</label>
            <asp:TextBox runat="server" type="text" class="form-control" ID="txtPrecioVenta" placeholder="Precio venta"/>
        </div>
        <div class="form-group">
            <label for="txtIdProveedor">Dirección</label>
            <asp:TextBox  runat="server" type="text" class="form-control" ID="txtDireccionProveedor" placeholder="Password"/>
        </div>
        <div class="form-group">
            <label for="txtTelefono">Id del proveedor</label>
            <asp:TextBox runat="server" type="text" class="form-control" ID="txtIdProveedor" placeholder="Id del Proveedor"/>
        </div>  
         <div class="form-group">
            <label for="txtCantidad">Cantidad</label>
            <asp:TextBox  runat="server" type="text" class="form-control" ID="txtCantidad" placeholder="Cantidad"/>
        </div>
        <asp:Button runat="server" ID="btnAgregarProducto" OnClick="btnAgregarProducto_Click"  type="submit" class="btn btn-primary" Text="Agregar"></asp:Button>
    </form>
</asp:Content>
