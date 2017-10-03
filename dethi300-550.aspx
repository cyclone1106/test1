<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="dethi300-550.aspx.cs" Inherits="dethi300_550" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
        <div class="tuvung">
        <p>ĐỀ THI CẤP ĐỘ 300 - 550</p>
    </div>
    <div class="chude">
        <ul>
             <asp:Repeater ID="rpt_dethi" runat="server">
            <ItemTemplate>
             <a href="dethi300-550_chitiet.aspx?dethi=<%#Eval("Made") %>"><li><%#Eval("Tende") %></li></a>
       </ItemTemplate>
            </asp:Repeater>

        </ul>

    </div>
</asp:Content>

