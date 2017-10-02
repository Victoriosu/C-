<%@ Page Title="" Language="C#" MasterPageFile="~/Page.Master" AutoEventWireup="true" CodeBehind="Eliminar.aspx.cs" Inherits="WebApp.Eliminar" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">

    <asp:Label ID="Label1" runat="server" Text="Id Vehiculo a eliminar:"></asp:Label>
    <asp:TextBox ID="txtCodigo" runat="server"  CssClass="input:text"></asp:TextBox>
    <asp:Button ID="btnEliminar" runat="server" OnClick="btnEliminar_Click" Text="Eliminar!" CssClass="btn"/>
    <br />
    <asp:Label ID="lblExito" runat="server"></asp:Label>
    <p>Lista actual de elementos</p>
        <asp:DataGrid runat="server" ID="lista" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" ForeColor="Black" GridLines="Vertical">
            <AlternatingItemStyle BackColor="#CCCCCC" />
            <FooterStyle BackColor="#CCCCCC" />
            <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
            <SelectedItemStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
        </asp:DataGrid>
    </div>

</asp:Content>
