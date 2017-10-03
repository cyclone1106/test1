<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Nguphapchitiet.aspx.cs" Inherits="Nguphapchitiet" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <%-- <div class="duongke-nguphap2"></div>--%>
    <div class="background-tieude">
        <div class="tieudenguphap">
        <p>NGỮ PHÁP</p>
    </div>
    <div class="tieudenguphap">
        <p><asp:Label ID="txt_tieude" runat="server"></asp:Label></p>
    </div>
  
    </div>  
    <%--<div class="duongke-nguphap"></div>--%>
    <span style="font-size:25px; color:#06177e; font-weight:bold; text-align:center; margin-left:250px;"><asp:Label ID="txt_tieude2" runat="server"></asp:Label></span>

    <br />
    <br />
    <br />
        <asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>
                <%#Eval("Noidung") %>
            </ItemTemplate>
        </asp:Repeater>
 
</asp:Content>

