<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeFile="admin_thoigian.aspx.cs" Inherits="admin_thoigian" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
      <div class="dscauhoi">
 <table style="border:1px solid #0094ff; border-collapse:collapse; width:100%">
      <tr>
          <th>IDDongho</th>
          <th>Loại thời gian</th>
          <th>Phút</th>

           <th>Giây</th>
          <th></th>
        
      </tr>
      <asp:Repeater ID="Repeater1" runat="server" OnItemCommand="Repeater1_ItemCommand">
          <ItemTemplate>
<tr>
              <td ><%#Eval("IDDongho") %></td>
            
               <td ><%#Eval("Phan") %></td>
              <td style="width:400px"><%#Eval("Phut") %></td>
              <td><%#Eval("Giay") %></td>
                            <td style="width:100px">
                  <asp:Button ID="Button1" runat="server" Text="Xóa" CommandName="xoa" CommandArgument='<%#Eval("IDDongho") %>' OnClientClick='return confirm("Bạn có muốn xóa không?");' /> | 
                  <asp:Button ID="Button2" runat="server" Text="Sửa" CommandName="sua"  CommandArgument='<%#Eval("IDDongho") %>'/>
                  
              </td>
          </tr>
          </ItemTemplate>

      </asp:Repeater>

  </table>
          </div>
</asp:Content>

