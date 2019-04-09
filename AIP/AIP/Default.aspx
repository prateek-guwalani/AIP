<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="AIP.WebForm4" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <html>
	<head>
		<meta charset="utf-8">
		<title>Home</title>
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
	</head>

	<body>


        <br />

        <div class="container" style="filter:alpha(opacity=50); opacity:0.9; ">
           
            <center>
                <div class="inner" style="background:#212529; min-width:50%; height:90%">
                    <asp:Button ID="Button4" runat="server" Text="Auto Defaulters" style="background:#212529" Height="100px" Width="400px" OnClick="Button4_Click"/>
                    <br />
                    <br />
                    <br />
                    <asp:Button ID="Button2" runat="server" Text="Manual Defaulters" style="background:#212529" Height="100px" Width="400px" OnClick="Button2_Click1" />
                    <br />
                    <br />
                    <br />
                    <asp:Button ID="Button3" runat="server" Text="Re Defaulters" style="background:#212529" Height="100px" Width="400px" OnClick="Button3_Click" />
           
                    </div>
                </center>
            </div>
            

            











		
	</body>
</html>


</asp:Content>
