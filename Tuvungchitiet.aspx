<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Tuvungchitiet.aspx.cs" Inherits="Tuvungchitiet" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
      
    <div class="background-tieude">
        <div class="tieudetuvung">
        <p>TỪ VỰNG</p>
    </div>
    <div class="tieudetuvung">
        <p><asp:Label ID="txt_tieude" runat="server"></asp:Label></p>
    </div>
        </div>
          <br />

    <div class="tuvungchitiet">
        <table>
            <tr><td colspan="6" class="tuvung">
                <asp:Label ID="txt_tuvung" runat="server" ></asp:Label></td></tr>
            <tr>
                <th>STT</th>
                <th>Từ vựng</th>
                <th>Phiên âm</th>
                <th>Loại từ</th>
                <th>Nghĩa</th>
                <th>Ví dụ</th>
            </tr>
            <asp:Repeater ID="rpt_tuvung" runat="server">
             <ItemTemplate>
            <tr>
                <td><%=stt++ %></td>
                <td><%#Eval("Tentuvung") %></td>
                <td><%#Eval("Phienam") %></td>
                <td style="text-align:center;"><%#Eval("Loaituvung") %></td>
                <td><%#Eval("Nghiatuvung") %></td>
                <td><%#Eval("Vidu") %></td>
            </tr>

             </ItemTemplate>
            </asp:Repeater>

        </table>
 </div>
</asp:Content>

