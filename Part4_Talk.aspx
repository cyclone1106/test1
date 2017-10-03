<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Part4_Talk.aspx.cs" Inherits="Part4_Talk" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

           <div class="background-tieude">
        <div class="tieudenguphap">
        <p>TEST LISTEN</p>
    </div>
    <div class="tieudenguphap">
        <p><asp:Label ID="txt_tieude" runat="server">TALKS</asp:Label></p>
    </div>
 
 
    </div> 
    
    <br />
    <br />
    <br />
        <div class="tuvung">
        <p>PART 4: TALKS</p>
            </div>
       <div class="chude">
            <ul>
            <asp:Repeater ID="rpt_dethi" runat="server">
            <ItemTemplate>
                <a href="Part4_Talk_chitiet.aspx?dethi=<%#Eval("Made") %>"><li><%#Eval("Tende") %></li></a>
            
            </ItemTemplate>
            </asp:Repeater>
             

        </ul>

    </div>
</asp:Content>

