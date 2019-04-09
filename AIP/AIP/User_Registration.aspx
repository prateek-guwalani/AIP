<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="User_Registration.aspx.cs" Inherits="AIP.WebForm9" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

        <!DOCTYPE html>
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
                     <h1 style="text-align:center">USER REGISTRATION</h1>
                    <br />
                    <br />
                    <br />

            <label class="form-group">
            <asp:TextBox ID="TextBox2" class="form-control" runat="server" placeholder="Enter First Name" style="border-bottom-color:white;"></asp:TextBox>
                <br />
            <asp:TextBox ID="TextBox3" class="form-control" runat="server" placeholder="Enter Last Name" style="border-bottom-color:white;"></asp:TextBox>


                <br />
               
                <asp:TextBox ID="TextBox1" class="form-control" placeholder="Enter password" TextMode="Password" runat="server" style="border-bottom-color:white"></asp:TextBox>
                <br />
                
                 <asp:TextBox ID="TextBox4" class="form-control" runat="server" placeholder="Enter Age" style="border-bottom-color:white;"></asp:TextBox>

                <br />

                <asp:DropDownList ID="DropDownList1" class="form-control" style="border-bottom-color:white;" runat="server">
                    <asp:ListItem>Select Gender</asp:ListItem>
                    <asp:ListItem>Male</asp:ListItem>
                    <asp:ListItem>Female</asp:ListItem>
                     </asp:DropDownList>

                
                <center>
                    <br />
                    
                    <asp:TextBox ID="TextBox5" class="form-control" runat="server" placeholder="Enter Contact Number" style="border-bottom-color:white;"></asp:TextBox>
                    <br />
                    <asp:TextBox ID="TextBox6" class="form-control" runat="server" placeholder="Enter Email" style="border-bottom-color:white;"></asp:TextBox>
                    <br />
                    <asp:TextBox ID="TextBox7" class="form-control" runat="server" placeholder="Enter Address" style="border-bottom-color:white;"></asp:TextBox>
                    <br />
                    
                    <asp:DropDownList ID="DropDownList3" class="form-control" style="border-bottom-color:white;" runat="server">
                           <asp:ListItem>Select Country</asp:ListItem>
                     </asp:DropDownList>
                    <br />
                       <asp:DropDownList ID="DropDownList2" class="form-control" style="border-bottom-color:white;" runat="server">
                           <asp:ListItem>Select City</asp:ListItem>
                     </asp:DropDownList>
                    <br />
                    <asp:TextBox ID="TextBox8" class="form-control" runat="server" placeholder="Enter Zipcode" style="border-bottom-color:white;"></asp:TextBox>
                    <br />
                    <asp:TextBox ID="TextBox9" class="form-control" runat="server" placeholder="Enter Account Number" style="border-bottom-color:white;"></asp:TextBox>

                          <br />
                    <br />
                    <br />
                <asp:Button ID="Button1" class="btn btn-primary" runat="server" Text="Submit"  style="border-color:white; background-color:#11abb0 ;border:solid;" onMouseOver="this.style.background='#145252'" onMouseOut="this.style.background='#11abb0'"/>
                    &nbsp;&nbsp;&nbsp;<asp:Button ID="Button2" class="btn btn-primary" runat="server" Text="Reset"  style="border-color:white; background-color:#11abb0 ;border:solid;" onMouseOver="this.style.background='#145252'" onMouseOut="this.style.background='#11abb0'"/>
                </center>
					</label>
                    </div>
            </div>
            

            











		
	</body>
</html>


</asp:Content>
