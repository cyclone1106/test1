<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeFile="Admin_tintuc.aspx.cs" Inherits="Admin_tintuc" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <div class="dscauhoi">
             <div class="themcauhoi">
    <p>QUẢN LÝ TIN TỨC</p></div>
     <asp:Button ID="btn_themcauhoi" runat="server" Text="Thêm tin tức" OnClick="btn_themcauhoi_Click" Width="180" Height="45" />
        <br />
  <table style="border:1px solid #0094ff; border-collapse:collapse; width:100%">
      <tr>
          <th>Mã tin tức</th>
          <th>Tiêu đề</th>
          <th>Ngày đăng</th>
          <th>Nội dung</th>
        
          <th></th>
      </tr>
    <asp:Repeater ID="Repeater1" runat="server" OnItemCommand="Repeater1_ItemCommand1">
        <ItemTemplate>
          <tr>
              <td style="width:25px"><%#Eval("IDTinmoi") %></td>
              <td style="width:25px"><%#Eval("Tieude") %></td>
               <td style="width:50px"><%#Eval("Ngaydang") %></td>
              <td style="width:350px" class="comment"><%#Eval("Noidungrutgon") %></td>

              <td style="width:50px">
                    <asp:Button ID="Button1" runat="server" Text="Xóa" CommandName="xoa" CommandArgument='<%#Eval("IDTinmoi") %>' OnClientClick='return confirm("Bạn có muốn xóa không?");' /> | 
                  <asp:Button ID="Button2" runat="server" Text="Sửa" CommandName="sua" CommandArgument='<%#Eval("IDTinmoi") %>' />
              </td>
          </tr>

            
        </ItemTemplate>
    </asp:Repeater>

  </table>
         </div>
<script type="text/javascript" src="http://code.jquery.com/jquery-latest.js"></script>
<script type="text/javascript" src="js/JavaScript2.js"></script>

<script type="text/javascript">
    $(".comment").shorten({
        "showChars": 500,
        "moreText": "Xem thêm",
        "lessText": "Rút gọn",
    });
    </script>
</asp:Content>

