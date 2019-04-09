<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="User.aspx.cs" Inherits="AIP.WebForm8" %>
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
                color: #FFFFFF;
            }
                    .auto-style6 {
                        width: 6px;
                    }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
            <p>
        <br />
        <table class="auto-style1 table table-bordered" style="background-color: #333; border: medium solid #FFFFFF; height: 296px; ">
            <tr>
                <th class="auto-style5" style="border-style:solid;border-color:white;" colspan="9" >
                    <h1 class="auto-style5">User Details</h1></th>
            </tr>
            <tr>
                 <th class="auto-style2" style="border-style:solid;border-color:white;" >
                    <asp:Label ID="Label1" runat="server" Text="Default Status" style="color:#fff"></asp:Label>
                </th>
                <th>
                    <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>
                </th>
            </tr>
            <tr>
                <th class="auto-style2" style="border-style:solid;border-color:white;" >
                    <asp:Label ID="Label9" runat="server" Text="Date of Transaction" style="color:#fff"></asp:Label>
                </th>
                <th class="auto-style4">
                    <asp:Label ID="Label10" runat="server" Text="Amount Transferred " style="color:#fff"></asp:Label>
                </th>
                <th>
                    <asp:Label ID="Label2" runat="server" Text="Transferred From Account" style="color:#fff"></asp:Label>
                </th>
                <th>
                    <asp:Label ID="Label3" runat="server" Text="Transferred To Account" style="color:#fff"></asp:Label>
                </th>
                <th>
                    <asp:Label ID="Label4" runat="server" Text="Transferred From Branch" style="color:#fff"></asp:Label>
                </th>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style4">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
                        <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style4">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style4">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style4">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </p>
</asp:Content>
