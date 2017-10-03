<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Doimatkhau.aspx.cs" Inherits="Doimatkhau" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <div class="dangky">

        <table>
            <tr>
                <td colspan="2" class="tieudedangky">ĐỔI MẬT KHẨU</td>
            </tr>
            <tr>
                <td>Mật khẩu cũ</td>
                <td><asp:TextBox ID="txt_matkhaucu" runat="server" Width="250px" Height="25px" TextMode="Password"></asp:TextBox></td>  
            </tr>

             <tr>
                <td>Mật khẩu mới </td>
                <td><asp:TextBox ID="txt_matkhaumoi" runat="server" Width="250px" Height="25px" TextMode="Password"></asp:TextBox></td>
            </tr>

            <tr>
                <td>Nhập lại mật khẩu mới </td>
                <td><asp:TextBox ID="txt_nhaplaimatkhaumoi" runat="server" TextMode="Password" Width="250px" Height="25px"></asp:TextBox></td>
            </tr>

            <tr>
                <td colspan="2" class="button_dangky"> 
                    
            <asp:Button ID="btn_Dangky" runat="server" Text="Cập nhật" OnClick="btn_Dangky_Click" />
                    <asp:Button ID="btn_Huy" runat="server" Text="Hủy" OnClick="btn_Huy_Click"/>
            
        </td>
            </tr>
     <</table>
    </div>
</asp:Content>

