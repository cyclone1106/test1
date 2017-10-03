<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Kinhnghiem.aspx.cs" Inherits="Kinhnghiem" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     
    <div class="tuvungmoi">
                        <p>&nbsp; EXPERIENCES</p></div>
                        <div class="tieude"> </div>
                        <asp:Repeater ID="rpt_tinmoi" runat="server">
                            <ItemTemplate>
                        <div class="noidung-tuvungmoi">
                                <div class="tuvungmoi-hinhanh">
                                    <img src='Images/<%#Eval("Hinhanh") %>'  />
                                </div>
                                <div class="tuvungmoi-noidung"><a href='Kinhnghiemchitiet.aspx?id=<%#Eval("IDKinhnghiem") %>'><%#Eval("Tieude") %></a>
                                    <br />
                                    <span><b style="color:#ff6a00; font-size:20px">Ngày đăng:</b> <%#Eval("Ngaydang") %></span><br />
                                     
                                    <br />
                                     <span class="comment"><%#Eval("Noidungrutgon") %></span>
                                    
                                </div>

                        </div>
                        <hr />
                            </ItemTemplate>
                        </asp:Repeater>
        


<script type="text/javascript" src="http://code.jquery.com/jquery-latest.js"></script>
<script type="text/javascript" src="js/jquery.shorten.1.0.js"></script>

<script type="text/javascript">
    $(".comment").shorten({
        "showChars": 200,
        "moreText": ".",

    });
    </script>
                
</asp:Content>

