<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Part6_Text_Completion_chitiet.aspx.cs" Inherits="Part6_Incomplete_Sentence_chitiet" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

      <div class="background-tieude">
        <div class="tieudenguphap">
        <p>TEST LISTEN</p>
    </div>
    <div class="tieudenguphap">
        <p><asp:Label ID="txt_tieude" runat="server">TEXT COMPLETION</asp:Label></p>
    </div>
         <div class="tieudenguphap">
        <p><asp:Label ID="txt_dethi" runat="server"></asp:Label></p>
    </div>
 
    </div>  
    <br />
   <br />
    <br />
                <div id="phannghe" runat="server" class="phannghe"> 
                <div class="baikiemtra">

                     <asp:Repeater ID="rpt_dongho" runat="server">
                    <ItemTemplate>
                        <input id="txt_phut" type="text" value="<%# Eval("Phut") %>" style="border:none; color:transparent"/>
                         <input id="txt_giay" type="text" value="<%# Eval("Giay") %>" style="border:none; color:transparent"/>
                    </ItemTemplate>

                </asp:Repeater>
            <div class="cauhoi"><p><asp:Label ID="txt_dethi2" runat="server"></asp:Label></p></div>
                   
                <input id="txt_phut" type="text" value="55" style="border:none; color:transparent"/>
                <div id="dongho"></div>
                
                <div id="Div1" class="start" runat="server">
                   
                         <script type="text/javascript">




                             function DongHoNguoc(phut, giay) {

                                 mins = phut;
                                 secs = giay;
                                 redo();
                             }



                             function dis(mins, secs) {
                                 var disp;
                                 if (mins <= 9) {
                                     disp = " 0";
                                 } else {
                                     disp = " ";
                                 }
                                 disp += mins + ":";
                                 if (secs <= 9) {
                                     disp += "0" + secs;
                                 } else {
                                     disp += secs;
                                 }
                                 return (disp);
                             }

                             function redo() {
                                 secs--;
                                 if (secs == -1) {
                                     secs = 59;
                                     mins--;
                                 }
                                 document.getElementById("dongho").innerHTML = dis(mins, secs);
                                 if ((mins == 0) && (secs == 0)) {

                                 }
                                 else {
                                     DongHoNguoc = setTimeout("redo('" + dongho + "')", 1000);
                                 }

                             }
                             document.addEventListener('DOMContentLoaded', function () {

                                 var phut = document.getElementById("txt_phut").value;
                                 var giay = document.getElementById("txt_giay").value;
                                 document.getElementById("dongho").innerHTML = window.DongHoNguoc(phut, giay);
                             }, false);

    </script>

                </div>
                   

                   
                
                
              
                    
         <asp:Repeater ID="Rpt_nghe" runat="server">
              <ItemTemplate>
                <p> <%#Eval("Phancauhoi") %></p>
              <div class="chitietcauhoi"> 
                          <span><b>Question <%=idnghe++%>.  <%#Eval("Noidung") %></b></span>
                         <br />
                          <br />

             
                 <div class="dapan">
                
                          <div class="traloi1"><asp:RadioButton ID="RadioButton4" runat="server"  GroupName="dapan'<%=id++ %>'"  /><span >A.<asp:Label ID="A" runat="server"></asp:Label></span></div>
                          <div class="traloi1"><asp:RadioButton ID="RadioButton5" runat="server"  GroupName="dapan'<%=id++ %>'"  /><span >B.<asp:Label ID="B" runat="server"></asp:Label></span></div>
                          <div class="traloi1"><asp:RadioButton ID="RadioButton6" runat="server"  GroupName="dapan'<%=id++ %>'"  /><span >C.<asp:Label ID="C" runat="server"></asp:Label></span></div>
                          <div class="traloi1"><asp:RadioButton ID="RadioButton1" runat="server"  GroupName="dapan'<%=id++ %>'"  /><span >D.<asp:Label ID="D" runat="server"></asp:Label></span></div>
    
                  </div>
               </div>
                </ItemTemplate>
                
           
          </asp:Repeater>
               </div>
          </div>
    <div class="nopbai">
      
    <asp:Button ID="btn_Nopbai" runat="server" Text="Nộp bài" OnClick="Button1_Click" /> 
    </div>
</asp:Content>

