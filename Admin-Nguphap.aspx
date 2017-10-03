<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeFile="Admin-Nguphap.aspx.cs" Inherits="Admin_Nguphap" %>
<%@ Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="dscauhoi">
     <asp:Button ID="btn_themcauhoi" runat="server" Text="Thêm ngữ pháp" OnClick="btn_themcauhoi_Click" Width="150" Height="35" />
        <br />
  <table style="border:1px solid #0094ff; border-collapse:collapse; width:100%">
      <tr>
          <th>Chủ đề</th>
          <th>Nội dung</th>
       
      </tr>
    <asp:Repeater ID="Repeater1" runat="server" OnItemCommand="Repeater1_ItemCommand">
        <ItemTemplate>
          <tr>
              <td style="width:25px"><%#Eval("IDChude") %></td>
              <td style="width:25px"><%#Eval("Noidung") %></td>


              <td style="width:50px">
                    <asp:Button ID="Button1" runat="server" Text="Xóa" CommandName="xoa" CommandArgument='<%#Eval("IDNguphap") %>' OnClientClick='return confirm("Bạn có muốn xóa không?");' /> | 
                  <asp:Button ID="Button2" runat="server" Text="Sửa" CommandName="sua" CommandArgument='<%#Eval("IDNguphap") %>' />
              </td>
          </tr>

            
        </ItemTemplate>
    </asp:Repeater>

  </table>
         </div>
</asp:Content>

