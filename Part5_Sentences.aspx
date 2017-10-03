<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Part5_Sentences.aspx.cs" Inherits="Part5_Sentences" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    
           <div class="background-tieude">
        <div class="tieudenguphap">
        <p>TEST READ</p>
    </div>
    <div class="tieudenguphap">
        <p><asp:Label ID="txt_tieude" runat="server">INCOMPLETE SENTENCES</asp:Label></p>
    </div>
 
 
    </div> 
    
    <br />
    <br />
    <br />
        <div class="tuvung">
        <p>PART 5: INCOMPLETE SENTENCES</p>
     </div>
    <div class="chude">
            <ul>
            <asp:Repeater ID="rpt_dethi" runat="server">
            <ItemTemplate>
                <a href="Part5_Sentences_chitiet.aspx?dethi=<%#Eval("Made") %>"><li><%#Eval("Tende") %></li></a>
            
            </ItemTemplate>
            </asp:Repeater>
             

        </ul>

    </div>
</asp:Content>

