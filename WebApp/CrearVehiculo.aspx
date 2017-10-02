<%@ Page Title="" Language="C#" MasterPageFile="~/Page.Master" AutoEventWireup="true" CodeBehind="CrearVehiculo.aspx.cs" Inherits="WebApp.CrearVehiculo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 55px;
        }
        .auto-style2 {
            width: 378px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container" runat="server">
    <p>
        <br />
    </p>
<form id="form1" runat="server">
        <asp:Table runat="server">
            <asp:TableRow runat="server">
                <asp:TableCell runat="server" CssClass="auto-style1">Año:</asp:TableCell>
                <asp:TableCell runat="server" CssClass="auto-style2"><asp:DropDownList runat="server" ID="ddlAnio"></asp:DropDownList>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell CssClass="auto-style1">Precio:</asp:TableCell>
                <asp:TableCell CssClass="auto-style2"><asp:TextBox runat="server" ID="txtPrecio" TextMode="Number"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtPrecio" ErrorMessage="Debe ingresar un Precio"></asp:RequiredFieldValidator>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell CssClass="auto-style1">Color:</asp:TableCell>
                <asp:TableCell CssClass="auto-style2"><asp:DropDownList runat="server" ID="ddlColor"></asp:DropDownList>
            </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell CssClass="auto-style1">Tipo:</asp:TableCell>
                <asp:TableCell CssClass="auto-style2"><asp:DropDownList runat="server" ID="ddlTipo"></asp:DropDownList></asp:TableCell>
                
            </asp:TableRow>
        </asp:Table>
    <br />
    <p>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Agregar" CssClass="btn" />
    </p>
</form>
    <p>
        &nbsp;</p>
    <p>
        <asp:Label ID="lblCantidad" runat="server"></asp:Label>
    </p>
    </div>

</asp:Content>
