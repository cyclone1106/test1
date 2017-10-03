<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeFile="Admin_ChinhsuaTuvung.aspx.cs" Inherits="Admin_ChinhsuaTuvung" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
        <div class="themcauhoi">
    <p>CẬP NHẬT TỪ VỰNG</p>
        <table class="admin_cauhoi">
            <tr>
                <td>Chủ đề</td>
                <td>
                    <asp:TextBox ID="txt_chude" runat="server"></asp:TextBox></td>
            </tr>
      <tr id="tu" runat="server">
                 <td>Từ</td>
                 <td><asp:TextBox ID="txt_tuvung" runat="server"  TextMode="MultiLine"  Width="810" Height="45"></asp:TextBox></td>
             </tr>
             <tr id="phienam" runat="server">
                 <td>Phiên âm</td>
                 <td><asp:TextBox ID="txt_phienam" runat="server"  TextMode="MultiLine"  Width="810" Height="45"></asp:TextBox></td>
             </tr>
             <tr id="loaitu" runat="server">
                 <td>Loại từ</td>
                 <td><asp:TextBox ID="txt_loaitu" runat="server"  TextMode="MultiLine"  Width="810" Height="45"></asp:TextBox></td>
             </tr>
             <tr id="nghia" runat="server" >
                 <td>Nghĩa</td>
                 <td><asp:TextBox ID="txt_nghia" runat="server"  TextMode="MultiLine"  Width="810" Height="45"></asp:TextBox></td>
             </tr>
             <tr id="vidu" runat="server">
                 <td>Ví dụ</td>
                 <td><asp:TextBox ID="txt_vidu" runat="server"  TextMode="MultiLine"  Width="810" Height="45"></asp:TextBox></td>
             </tr>
          
              <tr style="text-align:center;">
            <td colspan="3" >
            <asp:Button ID="btn_capnhat" runat="server" Text="Cập nhật" OnClick="btn_capnhat_Click"  Width="150" Height="50" BackColor="#339933" ForeColor="#ffffff" />
                <asp:Button ID="Button1" runat="server" Text="Hủy" OnClick="btn_huy_Click"  Width="150" Height="50" BackColor="#339933" ForeColor="#ffffff" />
            </td>
          </tr>
            </table>
            </div>
</asp:Content>

