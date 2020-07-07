<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Customer.aspx.cs" Inherits="WebApplication1.Customer1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 201px;
        }
        .auto-style2 {
            width: 255px;
        }
        .auto-style3 {
            margin-top: 0px;
        }
        .auto-style4 {
            width: 201px;
            height: 15px;
        }
        .auto-style5 {
            width: 255px;
            height: 15px;
        }
        .auto-style6 {
            height: 15px;
        }
        .auto-style7 {
            height: 269px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" class="auto-style7">
        <div>
            <table style="width:100%;">
                <tr>
                    <td class="auto-style4">Customer ID:</td>
                    <td class="auto-style5">
                        <asp:TextBox ID="txt_id" runat="server" Width="150px"></asp:TextBox>
                    </td>
                    <td class="auto-style6">
                        <asp:Button ID="btn_save" runat="server" OnClick="btn_save_Click" Text="Insert" Width="75px" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">Customer Name:</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="txt_name" runat="server" CssClass="auto-style3" Width="150px"></asp:TextBox>
                    </td>
                    <td>
                        <asp:Button ID="btn_update" runat="server" OnClick="btn_update_Click" Text="Update" Width="75px" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">Customer Address:</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="txt_adres" runat="server" Width="150px"></asp:TextBox>
                    </td>
                    <td>
                        <asp:Button ID="btn_del" runat="server" OnClick="btn_del_Click" Text="Delete" Width="75px" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">Customer Phone:</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="txt_phone" runat="server" Width="150px"></asp:TextBox>
                    </td>
                    <td>
                        <asp:Button ID="btn_reset" runat="server" Text="Reset" Width="75px" OnClick="btn_reset_Click" />
                    </td>
                </tr>
            </table>
        </div>
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
    </form>
</body>
</html>
