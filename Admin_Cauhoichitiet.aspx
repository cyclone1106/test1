<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeFile="Admin_Cauhoichitiet.aspx.cs" Inherits="Admin_Cauhoichitiet" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
        <div class="dscauhoi">
  
  <table style="border:1px solid #0094ff; border-collapse:collapse; width:100%">
      <tr>
          <th>Mã Câu hỏi</th>
          <th>Phần thi</th>
          <th>Đoạn văn</th>
          <th>Nội dung câu hỏi</th>
          <th>Nội dung đáp án</th>
           <th>Kết quả </th>
          <th></th>
      </tr>
      <asp:Repeater ID="Repeater1" runat="server" OnItemCommand="Repeater1_ItemCommand1">
          <ItemTemplate>
<tr>
              <td style="width:25px"><%#Eval("IDCauhoi") %></td>
               <td style="width:50px"><%#Eval("IDNoidung") %></td>
              <td style="width:150px"><%#Eval("Phancauhoi") %></td>
              <td style="width:120px"><%#Eval("Noidung") %></td>
              <td style="width:25px"><%#Eval("NDDA") %></td>
              <td style="width:25px"><%#Eval("DA") %></td>
              <td style="width:50px">
                  <asp:Button ID="Button1" runat="server" Text="Xóa" CommandName="xoa" CommandArgument='<%#Eval("IDCauhoi") %>' OnClientClick='return confirm("Bạn có muốn xóa không?");' /> | 
                  <asp:Button ID="Button2" runat="server" Text="Sửa" CommandName="sua"  CommandArgument='<%#Eval("IDCauhoi") %>'/>
              </td>
          </tr>
          </ItemTemplate>

      </asp:Repeater>
      
  </table><asp:Button ID="Button3" runat="server" Text="Quay lại" Width="150" Height="30" OnClick="Button3_Click"  />
   </div>
</asp:Content>

