<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EliminarProducto.aspx.cs" Inherits="ProyectoTercerParcial.EliminarProducto" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
        <form>
        <div class="form-group">
            <label for="txtIdProducto">Numero Producto</label>
            <asp:TextBox  runat="server" type="text" class="form-control" ID="txtIdProducto" aria-describedby="emailHelp" placeholder="Ingrese el id del producto"/>
        </div>
        <asp:Button runat="server" ID="btnEliminarProducto" OnClick="btnEliminarProducto_Click" type="submit" class="btn btn-primary" Text="Eliminar"></asp:Button>
    </form>
</asp:Content>
