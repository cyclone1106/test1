<%@ Page Language="C#" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<link href="login.css" rel="stylesheet" />
<body>
    
    <form id="form1" runat="server">
    <div>
            <div class="login">
  <div class="login-triangle"></div>
  
  <h2 class="login-header">Đăng nhập</h2>
		
  <form class="login-container" method="post">

    <p><asp:TextBox ID="txt_tendangnhap" runat="server"  placeholder="Tên đăng nhập"></asp:TextBox></p>
    <p><asp:TextBox ID="txt_matkhau" runat="server"  placeholder="Mật khẩu" TextMode="Password"></asp:TextBox></p>
    <table><tr><td width="50"><asp:CheckBox ID="luumatkhau" runat="server" /></td><td><label>Lưu mật khẩu</label></td>
        <td><a href="Quenmatkhau.aspx" style="text-decoration:none; margin-left: 35px;">Quên mật khẩu ?</a></td>
           </tr></table>
    <p>
        <asp:Button ID="btn_dangnhap" runat="server" Text="Đăng nhập" OnClick="btn_dangnhap_Click" /></p>
  </form>
</div>
    </div>
    </form>
</body>
</html>
