<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="dethi0-300.aspx.cs" Inherits="dethicap1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
        <div class="tuvung">
        <p>ĐỀ THI CẤP ĐỘ 0 - 300 </p>
    </div>
    <div class="chude">
        <ul>
             <asp:Repeater ID="rpt_dethi" runat="server">
            <ItemTemplate>
             <a href="dethi0-300_chitiet.aspx?dethi=<%#Eval("Made") %>"><li><%#Eval("Tende") %></li></a>
       </ItemTemplate>
            </asp:Repeater>

        </ul>

    </div>
   
</asp:Content>

