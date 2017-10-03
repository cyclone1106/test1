<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <div class="tuvungmoi">
                        <p>&nbsp; INTRODUCE</p></div>
                        <div class="tieude"> </div>
                        <asp:Repeater ID="rpt_Gioithieu" runat="server">
                            <ItemTemplate>
                       <p  style="color:#808080; font-style:italic; padding-left:5px;text-align:justify"><%#Eval("Noidungrutgon") %></p>
                            </ItemTemplate>
                        </asp:Repeater>
    <a href="Gioithieu.aspx">...Xem thêm</a>
    <br />
    <br />
                    <div class="tuvungmoi">
                        <p>&nbsp; NEWS</p></div>
                        <div class="tieude"> </div>
                        <asp:Repeater ID="rpt_tinmoi" runat="server">
                            <ItemTemplate>
                             
                              <div class="noidung-tuvungmoi">
                                <div class="tuvungmoi-hinhanh">
                                    <img src='Images/<%#Eval("Hinhanh") %>'  />
                                </div>
                                <div class="tuvungmoi-noidung">
                                  
                                     <a href='Tinmoichitiet.aspx?id=<%#Eval("IDTinmoi") %>'><%#Eval("Tieude") %></a>
                                    <br />
                                     <span><b style="color:#ff6a00; font-size:20px">Ngày đăng:</b> <%#Eval("Ngaydang") %></span><br />
                                 <br />
                                     <p style="color:#808080; font-style:italic; padding-left:5px;text-align:justify"><%#Eval("Noidungrutgon") %></p>
                                    
                              
                                    
                                </div>

                        </div>
                        <hr />
                            </ItemTemplate>
                        </asp:Repeater>
    <br />
     <div class="tuvungmoi">
                        <p>&nbsp; EXPERIENCES</p></div>
                        <div class="tieude"> </div>
       <asp:Repeater ID="rpt_kinhnghiem" runat="server">
                            <ItemTemplate>
                        <div class="noidung-tuvungmoi">
                                <div class="tuvungmoi-hinhanh">
                                    <img src='Images/<%#Eval("Hinhanh") %>'  />
                                </div>
                                <div class="tuvungmoi-noidung">
                                   
                                     <a href='Tinmoichitiet.aspx?id=<%#Eval("IDKinhnghiem") %>'><%#Eval("Tieude") %></a>
                                    <br />
                                    <span><b style="color:#ff6a00; font-size:20px">Ngày đăng:</b> <%#Eval("Ngaydang") %></span><br />
                                 <br />
                                     <p style="color:#808080; font-style:italic; padding-left:5px;text-align:justify"><%#Eval("Noidungrutgon") %></p>
                                    
                                </div>

                        </div>
                        <hr />
                            </ItemTemplate>
                        </asp:Repeater>

</asp:Content>

