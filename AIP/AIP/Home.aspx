<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="AIP.WebForm5" %>
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
                <div class="inner" style="background:#212529; min-width:100%; height:90%">
                     <h1 style="text-align:center">Auto Identification Process</h1>
                    <br />
                    <br />
                    <br />
                    <p style="text-align:justify">AIP is a system used for enabling AIP Admin to view a list of defaulters for a bank i.e. users
                         who have borrowed money from the bank but failed to repay it in their specified duration
                         of time. The bank wants to maintain this list so that they can easily identify the defaulters
                         list and can take proper measures to get back their loan.</p>
                    <p style="text-align:justify">There are three types of defaulters identified with the bank depending on the individuals
                         Accrual Status or Borrowing Rating. The types of defaulters are Auto Weaver, Validate Error and Auto</p>
                    <p style="text-align:justify">The following are the few important modules in the system</p>
                    <p style="text-align:left"> a.) AIP Admin and Business User Registration</p>
                    <p style="text-align:left" > b.) Auto Defaults</p>
                    <p style="text-align:left"> c.) Manual Defaults</p>
                    <p style="text-align:left"> d.) Displaying Updated Results</p>
                    <p style="text-align:left"> e.) Re Defaults</p>
                     <br />
           
                    </div>
                </center>
            </div>
            

            











		
	</body>
</html>


</asp:Content>
