<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" MaintainScrollPositionOnPostback="true" AutoEventWireup="true" CodeFile="Admin_Cauhoi.aspx.cs" Inherits="Admin_Cauhoi" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="dscauhoi">
  
        <br />
                Chọn nội dung cần lọc dữ liệu: <asp:DropDownList ID="dr_noidung" runat="server" DataSourceID="SqlDataSource1" DataTextField="IDNoidungchitiet" DataValueField="IDNoidungchitiet"></asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ToeicConnectionString %>" SelectCommand="SELECT * FROM [CHITIETNOIDUNG] WHERE (([IDNoidungchitiet] &lt;&gt; @IDNoidungchitiet) AND ([IDNoidungchitiet] &lt;&gt; @IDNoidungchitiet2) AND ([IDNoidungchitiet] &lt;&gt; @IDNoidungchitiet3) AND ([IDNoidungchitiet] &lt;&gt; @IDNoidungchitiet4) AND ([IDNoidungchitiet] &lt;&gt; @IDNoidungchitiet5) AND ([IDNoidungchitiet] &lt;&gt; @IDNoidungchitiet6))">
            <SelectParameters>
                <asp:Parameter DefaultValue="1" Name="IDNoidungchitiet" Type="String" />
                <asp:Parameter DefaultValue="2" Name="IDNoidungchitiet2" Type="String" />
                <asp:Parameter DefaultValue="3" Name="IDNoidungchitiet3" Type="String" />
                <asp:Parameter DefaultValue="4" Name="IDNoidungchitiet4" Type="String" />
                <asp:Parameter DefaultValue="5" Name="IDNoidungchitiet5" Type="String" />
                <asp:Parameter DefaultValue="0" Name="IDNoidungchitiet6" Type="String" />
            </SelectParameters>
        </asp:SqlDataSource>
       
     <asp:Button ID="btn_timkiem" runat="server" Text="Tìm kiếm" Width="150" Height="35" OnClick="Button4_Click" />   <asp:Button ID="btn_themcauhoi" runat="server" Text="Thêm câu hỏi" OnClick="btn_themcauhoi_Click" Width="150" Height="35" />
  <table style="border:1px solid #0094ff; border-collapse:collapse; width:100%">
      <tr>
          <th>Mã Câu hỏi</th>
          <th>Phần thi</th>
          <th>Đoạn văn</th>

           <th>Nội dung </th>
          <th>chi tiết câu hỏi</th>
          <th>Chức năng</th>
      </tr>
      <asp:Repeater ID="Repeater1" runat="server" OnItemCommand="Repeater1_ItemCommand1">
          <ItemTemplate>
<tr>
              <td ><%#Eval("IDCauhoi") %></td>
            
               <td ><%#Eval("IDNoidung") %></td>
              <td style="width:400px"><%#Eval("Phancauhoi") %></td>
              <td><%#Eval("Noidung") %></td>
                <td style="width:50px">
                    <asp:Button ID="Button3" runat="server" Text="Xem" CommandName="xem"  CommandArgument='<%#Eval("IDCauhoi") %>'/>
                   </td> 
              <td style="width:100px">
                  <asp:Button ID="Button1" runat="server" Text="Xóa" CommandName="xoa" CommandArgument='<%#Eval("IDCauhoi") %>' OnClientClick='return confirm("Bạn có muốn xóa không?");' /> | 
                  <asp:Button ID="Button2" runat="server" Text="Sửa" CommandName="sua"  CommandArgument='<%#Eval("IDCauhoi") %>'/>
                  
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

