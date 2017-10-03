<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Gioithieu.aspx.cs" Inherits="Gioithieu" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
          
        <asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>
                <%#Eval("Noidung") %>

           </ItemTemplate>

        </asp:Repeater>

</asp:Content>

