<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="dethi880-990_chitiet.aspx.cs" Inherits="dethi880_990_chitiet" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

          <div class="duongke"></div>
    <div class="tieudekiemtra" ><p>ĐỀ THI</p></div>
    <div class="baikiemtra" id="kiemtra" runat="server">
            <div class="cauhoi"><p>ĐỀ thi số 01</p></div>
             <br />

             <div id="start" class="start" runat="server">Chọn phần thi để làm bài!
                <div class="btn_start">
                     <asp:Button ID="bnt_listen" runat="server" OnClick="bnt_listen_Click" OnClientClick="start()" Text="Phần thi Nghe" />
       
                    <asp:Button ID="btn_read" runat="server" OnClick="bnt_read_Click" OnClientClick="start()"  Text="Phần thi Đọc"/>
                 </div>
             </div>
                <asp:Repeater ID="rpt_donghonghe" runat="server">
                    <ItemTemplate>
                        <input id="txt_phut" type="text" value="<%# Eval("Phut") %>" style="border:none; color:transparent"/>
                         <input id="txt_giay" type="text" value="<%# Eval("Giay") %>" style="border:none; color:transparent"/>
                    </ItemTemplate>

                </asp:Repeater>
            <div id="phannghe" runat="server" class="phannghe"> 
                <br />
                     <p style="color:#f00">     Thời gian làm bài là 45 phút.Sau 45 phút hệ thống sẽ tự động nộp bài. Bạn không thể tiếp tục làm bài sau thời gian này. Your Score là số điểm bạn đạt được. Vui lòng đăng ký thành viên trước khi tham gia Bài thi thử để lưu lại kết quả trong Hồ sơ của bạn.
                     </p>
               
                

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
                                     document.getElementById("<%=btn_read.ClientID%>").click();
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
                     <p><strong>   LlSTENING TEST </strong><br />
    

                                    In the Listening test, you will be asked to demonstrate how well you understand spoken English. The entire Listening test will last approximately 45 minutes. There are four parts, and directions are given for each part. You must mark your answers on the separate answer sheet. Do not write your answers in the test book.
                     </p>
                     <p>
                            <strong>PART1</strong> <br />
                             Directions: For each question in this part, you will hear four statements about a picture in your test book. When you hear the statements, you must select the one statement that best describes what you see in the picture. Then find the number of the question on your answer sheet and mark your answer. The statements will not be printed in your test book and will be
                             spoken only one time.
                    </p>
                    <p> Example</p>
                          <img src="Images/example.png" width="450" height="325"  />

                     <p>Statement (C), “ They’re standing near the table,” is the best description of the picture, so you should select answer (C) and mark it on your answer sheet.</p>
                
                <asp:Repeater ID="Repeater1" runat="server">
                    <ItemTemplate>

                   
                    <audio controls="controls" style="width:700px" autoplay="autoplay" aria-autocomplete="none"  aria-readonly="true">

                          <source src="audio/<%#Eval("Tenfile") %>" type="audio/mp3" onclick="false" aria-readonly="true"  />
                     </audio>
                 </ItemTemplate>
                </asp:Repeater>
              
                    
         <asp:Repeater ID="Rpt_nghe_hinhanh" runat="server">
              <ItemTemplate>
                <p><strong> <%#Eval("Phancauhoi") %></strong></p>
              <div class="chitietcauhoi"> 
                          <span><b>Question <%=idnghe++%>.  <%#Eval("Noidung") %></b></span>
                         <br />
                          <br />

                  <div class="chitietcauhoi-hinhanh">
                        <img src="images_listen/<%#Eval("Tenfile") %>" />
                  </div>

                 <div class="dapan">
                
                          <div class="traloi1"><asp:RadioButton ID="RadioButton4" runat="server"  GroupName="dapan'<%=id++ %>'"  /><span >A.<asp:Label ID="A" runat="server"></asp:Label></span></div>
                          <div class="traloi1"><asp:RadioButton ID="RadioButton5" runat="server"  GroupName="dapan'<%=id++ %>'"  /><span >B.<asp:Label ID="B" runat="server"></asp:Label></span></div>
                          <div class="traloi1"><asp:RadioButton ID="RadioButton6" runat="server"  GroupName="dapan'<%=id++ %>'"  /><span >C.<asp:Label ID="C" runat="server"></asp:Label></span></div>
                          <div class="traloi1"><asp:RadioButton ID="RadioButton1" runat="server"  GroupName="dapan'<%=id++ %>'"  /><span >D.<asp:Label ID="D" runat="server"></asp:Label></span></div>
    
                  </div>
               </div>
                </ItemTemplate>
                
           
          </asp:Repeater>
                <p><strong>Listening Part 2</strong></p>
                <asp:Repeater ID="rpt_nghe_cauhoi" runat="server" OnItemDataBound="rpt_nghe_cauhoi_ItemDataBound">
              <ItemTemplate>
                <p> <%#Eval("Phancauhoi") %></p>
              <div class="chitietcauhoi"> 
                          <span><b>Question <%=idnghecauhoi++%>.  <%#Eval("Noidung") %></b></span>
                         <br />
                          <br />

                  <div class="dapan">
                
                          <div class="traloi1"><asp:RadioButton ID="RadioButton4" runat="server"  GroupName="dapan'<%=id++ %>'"  /><span >A.<asp:Label ID="A" runat="server"></asp:Label></span></div>
                          <div class="traloi1"><asp:RadioButton ID="RadioButton5" runat="server"  GroupName="dapan'<%=id++ %>'"  /><span >B.<asp:Label ID="B" runat="server"></asp:Label></span></div>
                          <div class="traloi1"><asp:RadioButton ID="RadioButton6" runat="server"  GroupName="dapan'<%=id++ %>'"  /><span >C.<asp:Label ID="C" runat="server"></asp:Label></span></div>
                 
    
                  </div>
                  
               </div>
                </ItemTemplate>
                
           
          </asp:Repeater>

                 <p><strong>Listening Part 3</strong></p> 
                <p> You will hear some conversations between two people. You will be asked to answer three questions about what the speakers say in each conversation. Select the best response to each question and click on the letter (A), (B), (C), or (D) in the answer space provided. The conversations will not appear on the screen and will be spoken only one time.</p>
                <asp:Repeater ID="rpt_nghehoithoai" runat="server" OnItemDataBound="rpt_nghe_cauhoi_ItemDataBound">
              <ItemTemplate>
               
              <div class="chitietcauhoi"> 
                          <span><b>Question <%=idnghehoithoai++%>.  <%#Eval("Noidung") %></b></span>
                         <br />
                          <br />

                  <div class="dapan">
                
                          <div class="traloi1"><asp:RadioButton ID="RadioButton4" runat="server"  GroupName="dapan'<%=id++ %>'"  /><span >A.<asp:Label ID="A" runat="server"></asp:Label></span></div>
                          <div class="traloi1"><asp:RadioButton ID="RadioButton5" runat="server"  GroupName="dapan'<%=id++ %>'"  /><span >B.<asp:Label ID="B" runat="server"></asp:Label></span></div>
                          <div class="traloi1"><asp:RadioButton ID="RadioButton6" runat="server"  GroupName="dapan'<%=id++ %>'"  /><span >C.<asp:Label ID="C" runat="server"></asp:Label></span></div>
                 
    
                  </div>
                  
               </div>
                </ItemTemplate>
                
           
          </asp:Repeater>

                 <p><strong>Listening Part 4</strong></p> 
                <p> You will hear some talks given by a single speaker. You will be asked to answer three questions about what the speaker says in the talk. Select the best response to each question and click on the letter (A), (B), (C), or (D) in the answer space provided. The talks will not appear on the screen and will be spoken only one time.</p>
                <asp:Repeater ID="rpt_nghedoanvan" runat="server" OnItemDataBound="rpt_nghe_cauhoi_ItemDataBound">
              <ItemTemplate>
               
              <div class="chitietcauhoi"> 
                          <span><b>Question <%=idnghedoanvan++%>.  <%#Eval("Noidung") %></b></span>
                         <br />
                          <br />

                  <div class="dapan">
                
                          <div class="traloi1"><asp:RadioButton ID="RadioButton4" runat="server"  GroupName="dapan'<%=id++ %>'"  /><span >A.<asp:Label ID="A" runat="server"></asp:Label></span></div>
                          <div class="traloi1"><asp:RadioButton ID="RadioButton5" runat="server"  GroupName="dapan'<%=id++ %>'"  /><span >B.<asp:Label ID="B" runat="server"></asp:Label></span></div>
                          <div class="traloi1"><asp:RadioButton ID="RadioButton6" runat="server"  GroupName="dapan'<%=id++ %>'"  /><span >C.<asp:Label ID="C" runat="server"></asp:Label></span></div>
                 
    
                  </div>
                  
               </div>
                </ItemTemplate>
                
           
          </asp:Repeater>


          </div>
       
               
      <!-------------------------------------------------------------PHẦN ĐỌC ------------------------------------>
    
       <div id="phandoc" runat="server" class="phandoc">
        <br />
          <p style="color:#f00">     Thời gian làm bài là 75 phút. Sau 75 phút hệ thống sẽ tự động nộp bài. Bạn không thể tiếp tục làm bài sau thời gian này. Your Score là số điểm bạn đạt được. Vui lòng đăng ký thành viên trước khi tham gia Bài thi thử để lưu lại kết quả trong Hồ sơ của bạn.
                     </p>
           Thời gian còn lại:
             <asp:Repeater ID="rpt_donghodoc" runat="server">
                    <ItemTemplate>
                        <input id="txt_phutdoc" type="text" value="<%# Eval("Phut") %>" style="border:none; color:transparent"/>
                         <input id="txt_giaydoc" type="text" value="<%# Eval("Giay") %>" style="border:none; color:transparent"/>
                    </ItemTemplate>

                </asp:Repeater>
         <div id="dongho1"></div>
                <div id="Div2" class="start" runat="server">
               
                         <script type="text/javascript">




                             function DongHoNguoc1(phut, giay) {
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
                                 document.getElementById("dongho1").innerHTML = dis(mins, secs);
                                 if ((mins == 0) && (secs == 0)) {
                                     document.getElementById("<%=bnt_listen.ClientID%>").click();
                                 }
                                 else {
                                     DongHoNguoc1 = setTimeout("redo('" + dongho1 + "')", 1000);
                                 }

                             }
                             document.addEventListener('DOMContentLoaded', function () {
                                 var phut = document.getElementById("txt_phutdoc").value;
                                 var giay = document.getElementById("txt_giaydoc").value;
                                 document.getElementById("dongho1").innerHTML = window.DongHoNguoc1(phut, giay);
                             }, false);

    </script>

                </div>
                     
                     <p ><strong>Reading Part 5</strong> <br /></p>
                
              <asp:Repeater ID="rpt_phandoc" runat="server">
              <ItemTemplate>
                <p><%#Eval("Phancauhoi") %></p>
              <div class="chitietcauhoi"> 
                          <span><b>Question <%=iddoc++%>.  <%#Eval("Noidung") %></b></span>
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
  

            <p ><strong>Reading Part 6</strong> <br /></p>
           <p>Read the texts that follow. A word or phrase is missing in some of the sentences. Select the best response to each question and click on the letter (A), (B), (C), or (D) in the answer space provided.</p>
                
              <asp:Repeater ID="rpt_docdientu" runat="server">
              <ItemTemplate>
                <p><%#Eval("Phancauhoi") %></p>
              <div class="chitietcauhoi"> 
                          <span><b>Question <%=iddocdientu++%>.  <%#Eval("Noidung") %></b></span>
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
          
            <p ><strong>Reading Part 7</strong> <br /></p>
           <p>In this part you will read a selection of texts, such as magazine and newspaper articles, letters, and advertisements. Each text is followed by several questions. Select the best answer for each question in the answer space provided.</p>
                
              <asp:Repeater ID="rpt_docdoanvan" runat="server">
              <ItemTemplate>
                <p><%#Eval("Phancauhoi") %></p>
              <div class="chitietcauhoi"> 
                          <span><b>Question <%=iddocdoanvan++%>.  <%#Eval("Noidung") %></b></span>
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
     <div id="diemthi" runat="server" style="margin-bottom:100px;">
        <p style="font-size:25px; color:#f00; padding-left:350px; font-weight:bold">KẾT QUẢ</p>
        <br />
         <p style="font-size:23px; font-weight:bold; color:#0026ff">Số điểm phần nghe</p>
      <div style="height:25px; padding-left:<%=tongdiemnghe-8%>%; text-align:center;"><p style="border:1px solid #0026ff; width:50px; border-radius:55px; background:#0026ff; color:#ffffff"><%=sodiemnghe %></p></div>
  
      <div id="Div3" style="width:95%; height:15px; border:1px solid #000; float:left">
         <div style="width:<%=tongdiemnghe%>%; background:linear-gradient(#54a1ff, #44689a); height:15px"></div>
 </div><div style="float:right">495</div>
        <br />

             <p style="font-size:23px; font-weight:bold; color:#0026ff">Số điểm phần đọc</p>
      <div style="height:25px; padding-left:<%=tongdiemdoc-8%>%; text-align:center;"><p style="border:1px solid #0026ff; width:50px; border-radius:55px; background:#0026ff; color:#ffffff"><%=sodiemdoc %></p></div>
    
      <div id="Div4" style="width:95%; height:15px; border:1px solid #000; float:left">
         <div style="width:<%=tongdiemdoc%>%; background:linear-gradient(#54a1ff, #44689a); height:15px"></div>
 </div><div style="float:right">495</div>
        <br />
           <p style="font-size:23px; font-weight:bold; color:#0026ff">Tổng điểm</p>
      <div style="height:25px; padding-left:<%=sodiem-8%>%; text-align:center;"><p style="border:1px solid #0026ff; width:50px; border-radius:55px; background:#0026ff; color:#ffffff"><%=tongdiem%></div>
    
      <div id="thanhdiem" style="width:95%; height:15px; border:1px solid #000; float:left">
         <div style="width:<%=sodiem%>%; background:linear-gradient(#54a1ff, #44689a); height:15px; "></div>
 </div><div style="float:right">990</div>
        <div style="text-align:center">
        <asp:Button ID="Button1" runat="server" Text="Lưu điểm" Width="150" Height="50" BackColor="#73c702" ForeColor="#ffffff" Font-Size="15" Font-Bold="true" OnClick="Button1_Click1"/>
   </div>
         </div>
</asp:Content>

