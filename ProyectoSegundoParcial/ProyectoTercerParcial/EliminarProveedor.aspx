<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EliminarProveedor.aspx.cs" Inherits="ProyectoTercerParcial.EliminarProveedor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
       <form>
        <div class="form-group">
            <label for="txtIdProveedor">Numero Proveedor</label>
            <asp:TextBox  runat="server" type="text" class="form-control" ID="txtIdProveedor" aria-describedby="emailHelp" placeholder="Ingrese el id del proveedor"/>
        </div>
        <asp:Button runat="server" ID="btnEliminarProveedor" OnClick="btnEliminarProveedor_Click" type="submit" class="btn btn-primary" Text="Agregar"></asp:Button>
    </form>
</asp:Content>
