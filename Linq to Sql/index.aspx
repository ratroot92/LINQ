<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Linq_to_Sql.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 240px;
        }
        .auto-style2 {
            width: 267px;
        }
        .auto-style3 {
            width: 240px;
            height: 28px;
        }
        .auto-style4 {
            width: 267px;
            height: 28px;
        }
        .auto-style5 {
            height: 28px;
        }
        .auto-style6 {
            width: 100%;
            height: 93px;
            margin-bottom: 24px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="margin-left: 0px; " class="auto-style6">
                <tr>
                    <td class="auto-style1">Emp ID</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="txt_id" runat="server" Width="150px"></asp:TextBox>
                    </td>
                    <td>
                        <asp:Button ID="btn_save" runat="server" Text="Insert" Width="75px" OnClick="btn_save_Click" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">Emp Name</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="txt_name" runat="server" Width="150px"></asp:TextBox>
                    </td>
                    <td>
                        <asp:Button ID="btn_update" runat="server" Text="Update" Width="75px" OnClick="btn_update_Click" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">Emp City</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="txt_city" runat="server" Width="150px"></asp:TextBox>
                    </td>
                    <td>
                        <asp:Button ID="btn_del" runat="server" Text="Delete" Width="75px" OnClick="btn_del_Click" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">Emp Designation</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="txt_desg" runat="server" Width="150px"></asp:TextBox>
                    </td>
                    <td>
                        <asp:Button ID="btn_srch" runat="server" Text="Search" Width="75px" OnClick="btn_srch_Click" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">Emp Phone</td>
                    <td class="auto-style4">
                        <asp:TextBox ID="txt_phone" runat="server" Width="150px"></asp:TextBox>
                    </td>
                    <td class="auto-style5">
                        <asp:Button ID="btn_all" runat="server" Text="View All" Width="75px" OnClick="btn_all_Click" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="txt_reset" runat="server" OnClick="txt_reset_Click" Text="Reset" Width="75px" />
                    </td>
                </tr>
            </table>
        </div>
        
                <asp:GridView ID="GridView1" runat="server"></asp:GridView>
    </form>
</body>
</html>
