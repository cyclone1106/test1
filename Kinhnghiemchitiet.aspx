<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Kinhnghiemchitiet.aspx.cs" Inherits="Kinhnghiemchitiet" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
   

                        <p><b style="color:#808080; font-size:23px; font-weight:bolder; ">&nbsp; EXPERIENCES</b></p>
        

  <asp:Repeater ID="rpt_noidung" runat="server">
        <ItemTemplate>

                   <div class="noidung-tuvungmoi1">
                                <div class="tuvungmoi-noidung1">
                                    
                                     <a href='Tinmoichitiet.aspx?id=<%#Eval("IDKinhnghiem") %>'><%#Eval("Tieude") %></a>
                                    <hr />
                                     <span><b style="color:#ff6a00; font-size:20px">Ngày đăng:</b> <%#Eval("Ngaydang") %></span><br />
                                    <br />
                                  <span style="text-align:justify"><%#Eval("Noidung") %>  </span>
                                </div>
 
                        </div>

        </ItemTemplate>
    </asp:Repeater>
  
</asp:Content>

