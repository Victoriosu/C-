<%@ Page Title="" Language="C#" MasterPageFile="~/Page.Master" AutoEventWireup="true" CodeBehind="ListarVehiculos.aspx.cs" Inherits="WebApp.ListarVehiculos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
    <asp:DataGrid runat="server" ID="lista" class="datagrid" ></asp:DataGrid>
    </div>
</asp:Content>
