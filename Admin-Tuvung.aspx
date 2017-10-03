<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeFile="Admin-Tuvung.aspx.cs" Inherits="Admin_Tuvung" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
       <div class="dscauhoi">
     <asp:Button ID="btn_themcauhoi" runat="server" Text="Thêm Từ vụng" OnClick="btn_themcauhoi_Click" Width="150" Height="35" />
        <br />
  <table style="border:1px solid #0094ff; border-collapse:collapse; width:100%">
      <tr>
       <th>STT</th>
          <th>Chủ đề</th>
                <th>Từ vựng</th>
                <th>Phiên âm</th>
                <th>Loại từ</th>
                <th>Nghĩa</th>
                <th>Ví dụ</th>
                <th></th>
       
      </tr>
     <asp:Repeater ID="rpt_tuvung" runat="server" OnItemCommand="rpt_tuvung_ItemCommand">
             <ItemTemplate>
            <tr>
                <td><%=stt++ %></td>
                 <td><%#Eval("Tenchude") %></td>
                <td><%#Eval("Tentuvung") %></td>
                <td><%#Eval("Phienam") %></td>
                <td style="text-align:center;"><%#Eval("Loaituvung") %></td>
                <td><%#Eval("Nghiatuvung") %></td>
                <td><%#Eval("Vidu") %></td>
            <td>
                    <asp:Button ID="Button1" runat="server" Text="Xóa" CommandName="xoa" CommandArgument='<%#Eval("IDTuvung") %>' OnClientClick='return confirm("Bạn có muốn xóa không?");' /> | 
                  <asp:Button ID="Button2" runat="server" Text="Sửa" CommandName="sua" CommandArgument='<%#Eval("IDTuvung") %>' />
              </td>
          </tr>

            
        </ItemTemplate>
    </asp:Repeater>

  </table>
         </div>
</asp:Content>

