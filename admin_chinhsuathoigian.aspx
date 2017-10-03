<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeFile="admin_chinhsuathoigian.aspx.cs" Inherits="admin_chinhsuathoigian" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="themcauhoi">
    <p>THÊM CÂU HỎI</p>
        <table class="admin_cauhoi">
            <tr>
                <td>Loại thời gian</td>
                <td>
                    <asp:Label ID="txt_loai" runat="server" Text="Label"></asp:Label></td>
                </tr>
            <tr>
                <td>Phút</td>
                <td>
                    <asp:TextBox ID="txt_phut" runat="server"></asp:TextBox></td>
            </tr>
              <tr>
                <td>Giây</td>
                <td>
                    <asp:TextBox ID="txt_giay" runat="server"></asp:TextBox></td>
            </tr>
              <tr>
                <td colspan="2">
                    <asp:Button ID="btn_capnhat" runat="server" Text="Cập nhật" OnClick="btn_capnhat_Click" Width="150" Height="50" BackColor="#339933" ForeColor="#ffffff" />
                    <asp:Button ID="btn_huy" runat="server" Text="Hủy" OnClick="btn_huy_Click" Width="150" Height="50" BackColor="#339933" ForeColor="#ffffff"/>
                </td>
            </tr>
            </table>

    </div>
</asp:Content>

