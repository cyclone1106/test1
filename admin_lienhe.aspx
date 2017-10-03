<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeFile="admin_lienhe.aspx.cs" Inherits="admin_lienhe" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

 <div class="dscauhoi">

  <table style="border:1px solid #0094ff; border-collapse:collapse; width:100%">
      <tr>
          <th>Mã liên hệ</th>
          <th>Họ tên</th>
          <th >Email</th>

           <th>Nghề nghiệp</th>
          <th>Số điện thoại</th>
          <th>Nội dung</th>
      </tr>
      <asp:Repeater ID="Repeater1" runat="server" OnItemCommand="Repeater1_ItemCommand">
          <ItemTemplate>
<tr>
              <td ><%#Eval("IDlienhe") %></td>
            
               <td style="width:100px"><%#Eval("Hoten") %></td>
              <td style="width:100px"><%#Eval("Email") %></td>
              <td><%#Eval("Nghenghiep") %></td>
         <td><%#Eval("Sodienthoai") %></td>
                 <td style="width:400px"><%#Eval("Noidung") %></td>
              <td >
                  <asp:Button ID="Button1" runat="server" Text="Xóa" CommandName="xoa" CommandArgument='<%#Eval("IDlienhe") %>' OnClientClick='return confirm("Bạn có muốn xóa không?");' /> | 
                 
                  
              </td>
          </tr>
          </ItemTemplate>

      </asp:Repeater>

  </table>

   </div>
     <asp:Repeater ID="rptPages" runat="server">
                <ItemTemplate>
                    <div class="phantrang">
                        <ul>
                            <%# Container.DataItem %>
                        </ul>
                    </div>
                    
                </ItemTemplate>
</asp:Repeater>
</asp:Content>



