<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeFile="Admin_chinhsuaTaikhoan.aspx.cs" Inherits="Admin_chinhsuaTaikhoan" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="themcauhoi" >
    <p>CẬP NHẬT TÀI KHOẢN</p>
        <table class="admin_cauhoi">
             
                  <tr>
                    <td>Tên đăng nhập</td>
                    <td>
                        <asp:TextBox ID="txt_tendangnhap" runat="server" Enabled="false"></asp:TextBox>
                        </td>
                </tr/>
             <tr>
                    <td>Mật khẩu</td>
                    <td>
                        <asp:TextBox ID="txt_matkhau" runat="server"></asp:TextBox>
                        </td>
                </tr/>
            <tr>
                <td>Phân quyền</td>
                <td>
                    <asp:DropDownList ID="dr_phanquyen" runat="server">
                        <asp:ListItem>1</asp:ListItem>
                        <asp:ListItem>2</asp:ListItem>
                    </asp:DropDownList></td>
            </tr>
               <tr>
                   
                <td colspan="2" style="text-align:center">
                       <asp:Button ID="btn_Them" runat="server" Text="Cập nhật" OnClick="bnt_Capnhat_Click" Width="150" Height="50" BackColor="#339933" ForeColor="#ffffff"/>
                    <asp:Button ID="btn_Huy" runat="server" Text="Hủy" OnClick="btn_Huy_Click" Width="150" Height="50" BackColor="#339933" ForeColor="#ffffff" />
                </td>
            </tr>
        </table>
            </div>
</asp:Content>

