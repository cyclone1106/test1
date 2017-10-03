<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Nguphap.aspx.cs" Inherits="Nguphap" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

      <div class="tuvung">
        <p>NGỮ PHÁP</p>
    </div>
    <div class="chude">
        <ul>
            <asp:Repeater ID="rpt_tuvung" runat="server">
                <ItemTemplate>
                    <a href="Nguphapchitiet.aspx?chude=<%#Eval("IDChude") %>"><li><%#Eval("Tenchude") %></li></a>
                </ItemTemplate>
            </asp:Repeater>
             

        </ul>

    </div>

</asp:Content>

