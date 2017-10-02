<%@ Page Title="" Language="C#" MasterPageFile="~/Page.Master" AutoEventWireup="true" CodeBehind="EditarVehiculo.aspx.cs" Inherits="WebApp.EditarVehiculo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
    <p>
        <br />
    </p>
        <table class="table">
            <tr>
                <td class="auto-style1">Id a buscar:</td>
                <td class="auto-style2"><asp:TextBox runat="server" ID="txtBuscar" TextMode="Number"></asp:TextBox>
                </td>
            </tr>

            <tr>
                <td class="auto-style1">Año:</td>
                <td class="auto-style2"><asp:DropDownList runat="server" ID="ddlAnio"></asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">Precio:</td>
                <td class="auto-style2"><asp:TextBox runat="server" ID="txtPrecio" TextMode="Number"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtPrecio" ErrorMessage="Debe ingresar un Precio"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">Color:</td>
                <td class="auto-style2"><asp:DropDownList runat="server" ID="ddlColor"></asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">Tipo:</td>
                <td class="auto-style2"><asp:DropDownList runat="server" ID="ddlTipo"></asp:DropDownList>
                </td>
            </tr>
        </table>
    <br />
    <p>
        <asp:Button ID="BtnBuscar" runat="server" OnClick="BtnBuscar_Click" Text="Buscar" CssClass="btn" />
        <asp:Button ID="BtnModificar" runat="server" OnClick="BtnModificar_Click" Text="Modificar" CssClass="btn" />
    </p>
    <p>
        &nbsp;</p>
    <p>
        <asp:Label ID="lblEncontrado" runat="server" Text="Label"></asp:Label>
    </p>
    </div>
</asp:Content>
