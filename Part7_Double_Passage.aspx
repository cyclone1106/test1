<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Part7_Double_Passage.aspx.cs" Inherits="Part7_Double_Passage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

                   <div class="background-tieude">
        <div class="tieudenguphap">
        <p>TEST READ</p>
    </div>
    <div class="tieudenguphap">
        <p><asp:Label ID="txt_tieude" runat="server">DOUBLE PASSAGE</asp:Label></p>
    </div>
 
 
    </div> 
    
    <br />
    <br />
    <br />
        <div class="tuvung">
        <p>PART 7: DOUBLE PASSAGE</p>
    </div>
    <div class="chude">
            <ul>
            <asp:Repeater ID="rpt_dethi" runat="server">
            <ItemTemplate>
                <a href="Part7_Double_Passage_chitiet.aspx?dethi=<%#Eval("Made") %>"><li><%#Eval("Tende") %></li></a>
            
            </ItemTemplate>
            </asp:Repeater>
             

        </ul>

    </div>
</asp:Content>

