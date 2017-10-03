<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="DeThiTongHop.aspx.cs" Inherits="DeThiTongHop" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit.HTMLEditor" TagPrefix="cc1" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server" >

        <div class="tuvung">
        <p>ĐỀ THI</p>
    </div>
    <div class="chude">
       <ul>
             <asp:Repeater ID="rpt_dethi" runat="server">
            <ItemTemplate>
             <a href="chitietdethi.aspx?dethi=<%#Eval("Made") %>"><li><%#Eval("Tende") %></li></a>
       </ItemTemplate>
            </asp:Repeater>

        </ul>

    </div>
</asp:Content>

