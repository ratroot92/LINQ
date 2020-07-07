<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CarForm.aspx.cs" Inherits="Linq_to_Jason.CarForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 143px;
        }
        .auto-style2 {
            width: 202px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="width:100%;">
                <tr>
                    <td class="auto-style1">Car Registration No:</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="txt_rno" runat="server" Width="150px"></asp:TextBox>
                    </td>
                    <td>
                        <asp:Button ID="btn_save" runat="server" OnClick="btn_save_Click" Text="Insert" Width="75px" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">Car Name:</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="txt_name" runat="server" Width="150px"></asp:TextBox>
                    </td>
                    <td>
                        <asp:Button ID="btn_update" runat="server" Text="Update" Width="75px" OnClick="btn_update_Click" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">Engine No:</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="txt_eng" runat="server" Width="150px"></asp:TextBox>
                    </td>
                    <td>
                        <asp:Button ID="btn_del" runat="server" Text="Delete" Width="75px" OnClick="btn_del_Click" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">Chasis No:</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="txt_chasis" runat="server" Width="150px"></asp:TextBox>
                    </td>
                    <td>
                        <asp:Button ID="btn_srch" runat="server" Text="Search" Width="75px" OnClick="btn_srch_Click" />
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
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">Sales Center:</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="txt_sale" runat="server" Width="150px"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
        <asp:TextBox ID="txt_main" runat="server" Height="154px" Width="1456px"></asp:TextBox>
        <asp:Button ID="btn_file" runat="server" Text="Save In File" OnClick="btn_file_Click" />
    </form>
</body>
</html>
