<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Dangky.aspx.cs" Inherits="Dangky" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            height: 35px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <div class="dangky">

        <table>
            <tr>
                <td colspan="2" class="tieudedangky">ĐĂNG KÝ THÀNH VIÊN</td>
            </tr>
            <tr>
                <td>Họ tên: </td>
                <td><asp:TextBox ID="txt_hoten" runat="server" Width="250px" Height="25px"></asp:TextBox></td>  
            </tr>

             <tr>
                <td>Tên đăng nhập: </td>
                <td><asp:TextBox ID="txt_tendangnhap" runat="server" Width="250px" Height="25px"></asp:TextBox></td>
            </tr>

            <tr>
                <td>Mật khẩu: </td>
                <td><asp:TextBox ID="txt_matkhau" runat="server" TextMode="Password" Width="250px" Height="25px"></asp:TextBox></td>
            </tr>

            <tr>
                <td>Nhập lại mật khẩu: </td>
                <td><asp:TextBox ID="txt_nhaplaimatkhau" runat="server" TextMode="Password" Width="250px" Height="25px"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Giới tính:</td>
                <td>
                    <asp:RadioButton ID="rd_nam" runat="server"  GroupName="gioitinh"/>Nam
                    <asp:RadioButton ID="rd_nu" runat="server" GroupName="gioitinh"/>Nữ
                </td>
            </tr>

            <tr>
                <td class="auto-style1">Ngày sinh:</td>
                <td class="auto-style1"><asp:TextBox ID="txt_ngaysinh" runat="server" TextMode="Date" Width="250px" Height="25px"></asp:TextBox></td>
            </tr>
              <tr>
                <td>Nơi sinh:</td>
                <td><asp:TextBox ID="txt_noisinh" runat="server"  Width="250px" Height="25px"></asp:TextBox></td>
            </tr>
               <tr>
                <td>Địa chỉ:</td>
                <td><asp:TextBox ID="txt_diachi" runat="server"  Width="250px" Height="25px"></asp:TextBox></td>
            </tr>
                <tr>
                <td>Nghề nghiệp</td>
                <td>
                    <asp:DropDownList ID="dr_nghenghiep" runat="server">
                        <asp:ListItem>Sinh viên</asp:ListItem>
                        <asp:ListItem>Nhân viên văn phòng</asp:ListItem>
                        <asp:ListItem>Khác</asp:ListItem>
                    </asp:DropDownList>
                    </td>
            </tr>
            <tr>
                <td>Email:</td>
                <td>
                    <asp:TextBox ID="txt_email" runat="server" TextMode="Email" Width="250px" Height="25px"></asp:TextBox>
                   </td>
            </tr>

            <tr>
                <td>Số điện thoại: </td>
                <td><asp:TextBox ID="txt_sodienthoai" runat="server" Width="250px" Height="25px" TextMode="Number"></asp:TextBox></td>
            </tr>
            <tr>
                <td colspan="2" class="button_dangky"> 
                    
            <asp:Button ID="btn_Dangky" runat="server" Text="Đăng ký" OnClick="btn_Dangky_Click" />
                    <asp:Button ID="btn_Huy" runat="server" Text="Hủy"/>
            
        </td>
            </tr>
     <</table>
    </div>
</asp:Content>

