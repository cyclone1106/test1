<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeFile="Admin_Themtuvung.aspx.cs" Inherits="Admin_Themtuvung" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
      <div class="themcauhoi">
    <p>THÊM CÂU HỎI</p>
        <table class="admin_cauhoi">
            <tr>
                <td>Chủ đề</td>
                <td>
            <asp:DropDownList ID="dr_chude" runat="server" DataSourceID="SqlDataSource1" DataTextField="Tenchude" DataValueField="IDChude"></asp:DropDownList>
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ToeicConnectionString %>" SelectCommand="SELECT * FROM [CHUDE_TUVUNG]"></asp:SqlDataSource>
</td>
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
            <tr>
                <td colspan="2" style="text-align:center">
                    <asp:Button ID="Button1" runat="server" Text="Thêm" OnClick="Button1_Click" Width="150" Height="50" BackColor="#339933" ForeColor="#ffffff"/>
                    <asp:Button ID="Button2" runat="server" Text="Hủy" Width="150" Height="50" BackColor="#339933" ForeColor="#ffffff"/>
                </td>
            </tr>
            </table>
            </div>
</asp:Content>

