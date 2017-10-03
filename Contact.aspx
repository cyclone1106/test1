<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Contact.aspx.cs" Inherits="Contact" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
 
     <div class="cauhoi"><p>THÔNG TIN LIÊN HỆ</p></div>
    <br />

    <div class="contact">

        <table>
            <tr>
                <td>Họ tên</td>
                <td><asp:TextBox ID="txt_hoten" runat="server" Width="400" Height="25"></asp:TextBox> </td>
            </tr>

            <tr>
                <td>Điện thoại</td>
                <td><asp:TextBox ID="txt_sodienthoai" runat="server" Width="400" Height="25"></asp:TextBox> </td>
            </tr>

            <tr>
                <td>Email</td>
                <td><asp:TextBox ID="txt_email" runat="server" Width="400" Height="25"></asp:TextBox> </td>
            </tr>

            <tr>
                <td>Nghề nghiệp</td>
                <td><asp:TextBox ID="txt_nghenghiep" runat="server" Width="400" Height="25"></asp:TextBox> </td>
            </tr>


             <tr>
                <td>Nội dụng</td>
                <td><asp:TextBox ID="txt_noidung" runat="server" TextMode="MultiLine" Width="400" Height="150"></asp:TextBox> </td>
            </tr>
            <tr>
                <td colspan="2" style="text-align:center">
                    <asp:Button ID="Button1" runat="server" Text="Gửi" Width="100" Height="30" OnClick="Button1_Click" /></td>
               
            </tr>
        </table>
    </div>
</asp:Content>

