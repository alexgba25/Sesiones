<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Productos.Views.Index" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title>Carrito de Compras</title>
</head><body>
    <form id="formAgregarProducto" runat="server" enctype="multipart/form-data">
        <div>
            <label for="txtNombre">Nombre:</label>
            <asp:TextBox ID="txtNombre" runat="server" Required="true"></asp:TextBox>
            <br />

            <label for="txtCantidad">Cantidad:</label>
            <asp:TextBox ID="txtCantidad" runat="server" TextMode="Number" Required="true"></asp:TextBox>
            <br />

            <label for="txtCosto">Costo:</label>
            <asp:TextBox ID="txtCosto" runat="server" TextMode="Number" Required="true"></asp:TextBox>
            <br />

            <label for="fileImagen">Imagen:</label>
            <asp:FileUpload ID="fileImagen" runat="server" />
            <br />

            <asp:Button ID="btnAgregarProducto" runat="server" Text="Agregar Producto" OnClick="btnAgregarProducto_Click"/>
        </div>
    </form>
</body>
</html>