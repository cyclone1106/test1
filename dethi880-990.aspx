<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="dethi880-990.aspx.cs" Inherits="dethi880_990" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
            <div class="tuvung">
        <p>ĐỀ THI CẤP ĐỘ 880-990 </p>
    </div>
    <div class="chude">
        <ul>
             <asp:Repeater ID="rpt_dethi" runat="server">
            <ItemTemplate>
             <a href="dethi880-990_chitiet.aspx?dethi=<%#Eval("Made") %>"><li><%#Eval("Tende") %></li></a>
       </ItemTemplate>
            </asp:Repeater>

        </ul>
    </div>
</asp:Content>

