<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeFile="admin_thongke.aspx.cs" Inherits="admin_thongke" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <div class="dscauhoi">
             <div class="themcauhoi">
    <p>THỐNG KÊ</p></div>
  <table style="border:1px solid #0094ff; border-collapse:collapse; width:50%">
      <tr>
          <th>Nội dung</th>
            <th>Số lượng chủ đề</th>
          <th>Số lượng câu hỏi </th>
        

      </tr>
    <asp:Repeater ID="Repeater1" runat="server" OnItemCommand="Repeater1_ItemCommand">
        <ItemTemplate>
          <tr>
              <td style="text-align:center"><%#Eval("IDNoidung") %></td>
              <td style="text-align:center">
                  <asp:Label ID="txt_soluong" runat="server" ></asp:Label></td>
              <td style="text-align:center"><%#Eval("soluong") %></td>

          </tr>

            
        </ItemTemplate>
    </asp:Repeater>

  <tr>
    <asp:Repeater ID="rpt_tintuc" runat="server">
        <ItemTemplate> 
              <td style="text-align:center">Tin tức</td>
            <td style="text-align:center"></td>
              <td style="text-align:center"><%#Eval("soluong") %></td>
        </ItemTemplate>
    </asp:Repeater>
</tr>
      <tr>
    <asp:Repeater ID="rpt_kinhnghiem" runat="server">
        <ItemTemplate> 
              <td style="text-align:center" >Kinh nghiệm</td>
            <td style="text-align:center"></td>
              <td style="text-align:center"><%#Eval("soluong") %></td>
        </ItemTemplate>
    </asp:Repeater>
</tr>

       <tr>
    <asp:Repeater ID="rpt_tuvung" runat="server">
        <ItemTemplate> 
              <td style="text-align:center">Từ vựng</td>
            <td style="text-align:center"></td>
              <td style="text-align:center"><%#Eval("soluong") %></td>
        </ItemTemplate>
    </asp:Repeater>
</tr>

            <tr>
    <asp:Repeater ID="rpt_nguphap" runat="server">
        <ItemTemplate> 
              <td style="text-align:center">Ngữ pháp</td>
            <td style="text-align:center"></td>
              <td style="text-align:center"><%#Eval("soluong") %></td>
        </ItemTemplate>
    </asp:Repeater>
</tr>
  </table>
         </div>
</asp:Content>

