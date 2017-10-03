<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Lichsulambai.aspx.cs" Inherits="Lichsulambai" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
      <div class="dscauhoi">
    <table style="border:1px solid #0094ff; border-collapse:collapse; width:100%">
      <tr>
          <th>Mã đề</th>
          <th>Ngày kiểm tra</th>
          <th>Điểm nghe</th>

           <th>Điểm đọc</th>
          <th>Tổng điểm</th>
          <th>Thời gian làm bài</th>
      </tr>
      <asp:Repeater ID="Repeater1" runat="server">
          <ItemTemplate>
<tr>
              <td ><%#Eval("Made") %></td>
            
               <td ><%#Eval("Ngaykiemtra") %></td>
       <td ><%#Eval("Diemnghe") %></td>
       <td ><%#Eval("Diemdoc") %></td>
       <td ><%#Eval("Tongdiem") %></td>
       <td ><%#Eval("Thoigianlambai") %></td>
     
             
          </tr>
          </ItemTemplate>

      </asp:Repeater>

  </table>
          </div>
</asp:Content>

