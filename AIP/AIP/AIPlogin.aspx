<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="AIPlogin.aspx.cs" Inherits="AIP.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <html>
	<head>
		<meta charset="utf-8">
		<title>RegistrationForm</title>
		<meta name="viewport" content="width=device-width, initial-scale=1.0">

        <!-- Adding bootrap-->
        <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.2.1/css/bootstrap.min.css">


		<!-- MATERIAL DESIGN ICONIC FONT -->
		<link rel="stylesheet" href="fonts/material-design-iconic-font/css/material-design-iconic-font.min.css">

		
		<!-- STYLE CSS -->
		<link rel="stylesheet" href="css/style.css">
        
        <%--scripts--%>
  <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
  <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.6/umd/popper.min.js"></script>
  <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.2.1/js/bootstrap.min.js"></script>


        <style>

            .form-control {
                color:white;
            }

        </style>
	</head>

	<body>


        <br />

        <div class="container" style="filter:alpha(opacity=50); opacity:0.9;">
           
            
                <div class="inner" style="background:#212529;">
                     <h1 style="text-align:center">LOGIN</h1>
                    <br />
                    <br />
                    <br />

            <label class="form-group">
            <asp:TextBox ID="TextBox_Id" class="form-control" runat="server" placeholder="Enter id" style="border-bottom-color:white;" required></asp:TextBox>
                <br />
                <br />
                <asp:TextBox ID="TextBox_Password" class="form-control" placeholder="Enter password" TextMode="Password" runat="server" style="border-bottom-color:white" required></asp:TextBox>
                <br />
                <br />
                <br />
                <asp:RadioButtonList ID="RadioButtonList1" class="form-check" RepeatDirection="Horizontal"  runat="server" style="position:absolute; margin-left:33%;">
                   
                      <asp:ListItem>Admin &nbsp;&nbsp;&nbsp;</asp:ListItem>
                  
                      <asp:ListItem>User</asp:ListItem>
                     
                </asp:RadioButtonList>
                <center>
                    <br />
                    <br />
                            
                <asp:Button ID="Button1" class="btn btn-primary" runat="server" Text="Login"  style="border-color:white; background-color:#11abb0 ;border:solid;" onMouseOver="this.style.background='#145252'" onMouseOut="this.style.background='#11abb0'" OnClick="Button1_Click"/>
                     </center>
					</label>
                    </div>
            </div>
            

            











		
	</body>
</html>

</asp:Content>
