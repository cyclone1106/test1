<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeFile="Admin_Taikhoan.aspx.cs" Inherits="Admin_Taikhoan" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
      <div class="dscauhoi">
               <div class="themcauhoi" >

   <p>THÔNG TIN TÀI KHOẢN</p>
                   </div>
  <table style="border:1px solid #0094ff; border-collapse:collapse; width:100%">
      <tr>
          <th>Họ tên</th>
          <th>Tên đăng nhập</th>
          <th>Mật khẩu</th>
          <th>Phân quyền</th>
        
          <th></th>
      </tr>
    <asp:Repeater ID="Repeater1" runat="server" OnItemCommand="Repeater1_ItemCommand">
        <ItemTemplate>
          <tr>
              <td style="width:150px"><%#Eval("Hoten") %></td>
              <td style="width:50px"><%#Eval("Tendangnhap") %></td>
               <td style="width:100px"><%#Eval("Matkhau") %></td>
              <td style="width:50px"><%#Eval("Phanquyen") %></td>

              <td style="width:50px">
                  <asp:Button ID="Button1" runat="server" Text="Xóa" CommandName="xoa" CommandArgument='<%#Eval("Tendangnhap") %>' OnClientClick='return confirm("Bạn có muốn xóa không?");' /> | 
                  <asp:Button ID="Button2" runat="server" Text="Sửa" CommandName="sua" CommandArgument='<%#Eval("Tendangnhap") %>' />
              </td>
          </tr>

            
        </ItemTemplate>
    </asp:Repeater>

  </table>
            </div>
</asp:Content>

