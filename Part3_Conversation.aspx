<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Part3_Conversation.aspx.cs" Inherits="Part3_Conversation" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
            <div class="background-tieude">
        <div class="tieudenguphap">
        <p>TEST LISTEN</p>
    </div>
    <div class="tieudenguphap">
        <p><asp:Label ID="txt_tieude" runat="server">CONVERSATIONS</asp:Label></p>
    </div>
 
 
    </div> 
    
    <br />
    <br />
    <br />
        <div class="tuvung">
        <p>PART 3: CONVERSATIONS</p>
    </div>
    <div class="chude">
      <ul>
            <asp:Repeater ID="rpt_dethi" runat="server">
            <ItemTemplate>
                <a href="Part3_Conversation_chitiet.aspx?dethi=<%#Eval("Made") %>"><li><%#Eval("Tende") %></li></a>
            
            </ItemTemplate>
            </asp:Repeater>
             

        </ul>

    </div>
</asp:Content>

