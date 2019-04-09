<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="AutoDefaultEdit.aspx.cs" Inherits="AIP.WebForm10" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
      <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
        }
        .auto-style3 {
            width: 108px;
        }
        .auto-style4 {
            width: 213px;
        }
        table th {
    border: 1px solid white;
}
         table td {
    border: 1px solid white;
}
        .auto-style5 {
            font-weight: normal;
        }
        .auto-style6 {
            font-weight: normal;
            color: #FFFFFF;
        }
        </style>

    

    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.2.1/css/bootstrap.min.css" integrity="sha384-GJzZqFGwb1QTTN6wy59ffF1BuGJpLSa9DkKMp0DgiMDm4iYMj70gZWKYbI706tWS" crossorigin="anonymous">


    <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo" crossorigin="anonymous"></script>
<script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.6/umd/popper.min.js" integrity="sha384-wHAiFfRlMFy6i5SRaxvfOCifBUQy1xHdJ/yoi7FRNXMRBu5WHdZYu1hA6ZOblgut" crossorigin="anonymous"></script>
<script src="https://stackpath.bootstrapcdn.com/bootstrap/4.2.1/js/bootstrap.min.js" integrity="sha384-B0UglyR+jN6CkvvICOB2joaf5I4l3gm9GU6Hc1og6Ls7i6U/mkkaduKaBhlAXv9k" crossorigin="anonymous"></script>
    <script type="text/javascript" src="https://ajax.googleapis.com/ajax/libs/jquery/1.8.3/jquery.min.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <p>
        <br />
        <center>
        <table class="auto-style1 table table-bordered table table-hover" style="background-color: #333;margin-left:5%; margin-right:5%; border: medium solid #FFFFFF; height: 296px; width:90% ">
            <tr>
                <th class="auto-style5" style="border-style:solid;border-color:white;" >
                    <h1 class="auto-style6" style="text-align:center"><strong>Auto Default</strong></h1></th>
            </tr>








            <ContentTemplate>
                <div>
            <asp:Repeater ID="Repeater_Auto_Default" runat="server" >
                <HeaderTemplate>
            <tr style="color:white; text-align:center">
                <th class="auto-style2" style="border-style:solid;border-color:white;" >
                    <asp:Label ID="Label9" runat="server" Text="Serial No." style="color:#fff"></asp:Label>
                </th>
                <th class="auto-style4">
                    <asp:Label ID="Label10" runat="server" Text="Borrower Status" style="color:#fff"></asp:Label>
                </th>
                <th>
                    <asp:Label ID="Label2" runat="server" Text="Borrower Name" style="color:#fff"></asp:Label>
                </th>
                <th>
                    <asp:Label ID="Label3" runat="server" Text="Borrower Rating" style="color:#fff"></asp:Label>
                </th>
                <th>
                    <asp:Label ID="Label4" runat="server" Text="Accrual Status" style="color:#fff"></asp:Label>
                </th>
                <th>
                    <asp:Label ID="Label5" runat="server" Text="Number" style="color:#fff"></asp:Label>
                </th>
                <th>
                    <asp:Label ID="Label6" runat="server" Text="Account Number" style="color:#fff"></asp:Label>
                </th>
                <th>
                    <asp:Label ID="Label7" runat="server" Text="Days Past Due" style="color:#fff"></asp:Label>
                </th>
                <th class="auto-style3">x   
                    <asp:Label ID="Label8" runat="server" Text="Comments" style="color:#fff"></asp:Label>
                </th>
            </tr>
                    </HeaderTemplate>
               <ItemTemplate>
            <tr style="color:white; text-align:center">
                <td class="auto-style2"><%# GetRowNo() %></td>
               
                <td class="auto-style4"><asp:DropDownList runat="server"  ID="ddlOptions" AutoPostBack="true" onselectedindexchanged="ddlOptions_SelectedIndexChanged" Width="90%">
                    <asp:ListItem Value="Auto">Auto</asp:ListItem>
                    <asp:ListItem Value="Error">Error</asp:ListItem>
                    <asp:ListItem Value="Auto Weiver">Auto Weiver</asp:ListItem>
                </asp:DropDownList></td>
                <td> <%#Eval("borrower_name")%></td>
                <td> <%#Eval("borrower_rating")%></td>
                <td> <%#Eval("accural_status")%></td>
                <td> <%#Eval("bank_number")%></td>
                <td> <%#Eval("account_number")%></td>
                <td> <%#Eval("days_past_due")%></td>
                <td class="auto-style3"><textbox TextMode="MultiLine"><%#Eval("comments")%></textbox></td>
            </tr>
           </ItemTemplate> 
           </asp:Repeater>
                       
                </div>

                <div style="margin-top: 20px;">
                    <table style="width: 600px; background-color:#fff" class="auto-style1 table table-bordered table table-hover">
                        <tr>
                            <td>
                                <asp:LinkButton ID="lbFirst" runat="server"	OnClick="lbFirst_Click">First</asp:LinkButton>
                            </td>
                            <td>
                                <asp:LinkButton ID="lbPrevious" runat="server" OnClick="lbPrevious_Click">Previous</asp:LinkButton>
                            </td>
                            <td>
                                <asp:LinkButton ID="lbNext" runat="server" OnClick="lbNext_Click">Next</asp:LinkButton>
                            </td>
                            <td>
                                <asp:LinkButton ID="lbLast" runat="server" OnClick="lbLast_Click">Last</asp:LinkButton>
                            </td>
                            <td>
                                <asp:Label ID="lblpage" runat="server" Text=""></asp:Label>
                            </td>
                        </tr>
                    </table>

                </div>
            </ContentTemplate>

            <tr>
                <td class="auto-style7" colspan="6" style="border-right-style: none; border-left-style: none">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    &nbsp;&nbsp;&nbsp;&nbsp; </td>
                <td class="auto-style8" style="border-right-style: none; border-left-style: none">
                    <asp:Button ID="Button2" runat="server" Font-Bold="True" Text="CANCEL" Width="100px" OnClick="Button2_Click" />
                </td>
                <td class="auto-style8" style="border-right-style: none; border-left-style: none"><asp:Button ID="Button1" runat="server" Font-Bold="True" Text="SAVE" Width="100px" OnClick="Button1_Click" />
                </td>
                <td class="auto-style8" style="border-right-style: none; border-left-style: none">
                </td>
            </tr>
        </table>
            </center>
    </p>
   
</asp:Content>
