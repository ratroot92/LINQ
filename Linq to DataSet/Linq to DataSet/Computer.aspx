<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Computer.aspx.cs" Inherits="Linq_to_DataSet.Computer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 120px;
        }
        .auto-style2 {
            width: 284px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="width:100%;">
                <tr>
                    <td class="auto-style1">Serial No:</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="txt_srno" runat="server" Width="150px"></asp:TextBox>
                    </td>
                    <td>
                        <asp:Button ID="btn_save" runat="server" OnClick="btn_save_Click" Text="Insert" Width="75px" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">Company Name:</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="txt_comp" runat="server" Width="150px"></asp:TextBox>
                    </td>
                    <td>
                        <asp:Button ID="btn_update" runat="server" OnClick="btn_update_Click" Text="Update" Width="75px" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">Processor:</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="txt_pros" runat="server" Width="150px"></asp:TextBox>
                    </td>
                    <td>
                        <asp:Button ID="btn_del" runat="server" OnClick="btn_del_Click" Text="Delete" Width="75px" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">RAM:</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="txt_ram" runat="server" Width="150px"></asp:TextBox>
                    </td>
                    <td>
                        <asp:Button ID="btn_srch" runat="server" OnClick="btn_srch_Click" Text="Search" Width="75px" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">Operating System:</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="txt_os" runat="server" Width="150px"></asp:TextBox>
                    </td>
                    <td>
                        <asp:Button ID="btn_rset" runat="server" OnClick="btn_rset_Click" Text="Reset" Width="75px" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">MotherBoard:</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="txt_mobo" runat="server" Width="150px"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">GPU:</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="txt_gpu" runat="server" Width="150px"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">Storage</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="txt_store" runat="server" Width="150px"></asp:TextBox>
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
