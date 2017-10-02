<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebApp.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<link href="css/stylesheet.css" rel="stylesheet" type="text/css" />
<link href="css/bootstrap.css" rel="stylesheet" type="text/css" />
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body style="background: url('/imgs/Back.jpg'); background-size: cover; background-repeat: no-repeat;" >


                <div class = "container">
	                <div class="wrapper">
		                <form runat="server" method="post" name="Login_Form" class="form-signin">       
		                    <h3 class="form-signin-heading">Bienvenido!, porfavor ingresa.</h3>
			                  <hr class="colorgraph" /><br />
			  
                                <asp:TextBox class="form-control" ID="txtUsername" runat="server"></asp:TextBox>
                                <asp:TextBox class="form-control" ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
			        
			                  <asp:button class="btn btn-lg btn-primary btn-block"  runat="server" type="Submit" Text="Ingresar" href="" OnClick="Unnamed1_Click"/>  	
                            	
		                </form>			
	                </div>
                </div>

</body>
</html>
