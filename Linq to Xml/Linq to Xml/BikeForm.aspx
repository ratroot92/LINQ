<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BikeForm.aspx.cs" Inherits="Linq_to_Xml.BikeForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 301px;
        }
        .auto-style2 {
            width: 363px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="width:100%;">
                <tr>
                    <td class="auto-style1">Bike Registration No:</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="txt_regno" runat="server" Width="150px"></asp:TextBox>
                    </td>
                    <td>
                        <asp:Button ID="btn_save" runat="server" OnClick="txt_save_Click" Text="Insert" Width="75px" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">Name:</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="txt_name" runat="server" Width="150px"></asp:TextBox>
                    </td>
                    <td>
                        <asp:Button ID="btn_update" runat="server" OnClick="btn_update_Click" Text="Update" Width="75px" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">Engine No:</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="txt_eng" runat="server" Width="150px"></asp:TextBox>
                    </td>
                    <td>
                        <asp:Button ID="btn_del" runat="server" OnClick="btn_del_Click" Text="Delete" Width="75px" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">Chasis No:</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="txt_chasis" runat="server" Width="150px"></asp:TextBox>
                    </td>
                    <td>
                        <asp:Button ID="btn_srch" runat="server" OnClick="btn_srch_Click" Text="Search" Width="75px" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">Owner:</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="txt_owner" runat="server" Width="150px"></asp:TextBox>
                    </td>
                    <td>
                        <asp:Button ID="btn_reset" runat="server" Text="Reset" Width="75px" OnClick="btn_reset_Click" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">Company:</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="txt_comp" runat="server" Width="150px"></asp:TextBox>
                    </td>
                    <td>
                        <asp:Button ID="btn_all" runat="server" OnClick="btn_all_Click" Text="View" Width="75px" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">Sales Center:</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="txt_scenter" runat="server" Width="150px"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
    </form>
</body>
</html>
