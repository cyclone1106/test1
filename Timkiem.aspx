<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Timkiem.aspx.cs" Inherits="Timkiem" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <div class="tuvungmoi">
                        <p>&nbsp; KẾT QUẢ TÌM KIẾM</p></div>
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
                                     <span class="comment"><%#Eval("Noidungrutgon") %></span>
                                    
                                </div>

                        </div>
                        <hr />
                            </ItemTemplate>
                        </asp:Repeater>
</asp:Content>

