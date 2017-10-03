<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="kiemtra.aspx.cs" Inherits="kiemtra" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server" >
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
         
    
        
    <br />
    <div class="duongke"></div>
    <div class="tieudekiemtra"><p>KIỂM TRA NGỮ PHÁP</p></div>
    <div class="baikiemtra">
    <div class="cauhoi toeic_title_part" ><p>Bài kiểm tra số 1</p></div>
    <br />

    
    <div id="start" class="start" runat="server">Bạn đã sẵn sàng? Hãy bấm vào nút start bên dưới để bắt đầu làm bài. Chúc các bạn đạt điểm số thật cao!
        <asp:Button ID="bnt_start" runat="server" OnClick="bnt_start_Click"/>
      


    </div>
    
    
    <div id="cauhoi" class="noidungcauhoi" runat="server" >  
          <div>
        
            
  
      
        </div>

        
        <div id="Donghodemnguoc">
        
        </div>
        
          <p><b><i>Chọn câu trả lời đúng nhất điền vào chỗ trống.</i></b></p>
    <p>--------------------------------------------------------------------------------------------------------------------</p>
            <div id="question1"  runat="server" class="chitietcauhoi">
    <p>Question 1: Mr. Smith is .......... English teacher.</p>
 
        <div class="traloi"><asp:RadioButton ID="RadioButton13" runat="server"  GroupName="dapan"  /><span >A. our</span></div>
<div class="traloi"><asp:RadioButton ID="RadioButton14" runat="server"  GroupName="dapan"  /><span >B. us</span></div><br />
    <div class="traloi"><asp:RadioButton ID="RadioButton15" runat="server"  GroupName="dapan"/><span >C. we</span></div>
   <div class="traloi"> <asp:RadioButton ID="RadioButton16" runat="server"  GroupName="dapan"/><span>D. you</span></div><br />
   
 <br /><br /><hr />
            </div>
         <div id="question2"  runat="server" class="chitietcauhoi">
      <p>Question 2: As a teenager, George spent summers abroad ……… the business.</p>
              <div class="traloi"><asp:RadioButton ID="RadioButton1" runat="server"  GroupName="dapan"  /><span>A. our</span></div>
 <div class="traloi"><asp:RadioButton ID="RadioButton2" runat="server"  GroupName="dapan"  /><span >B. us</span></div><br />
   <div class="traloi"><asp:RadioButton ID="RadioButton3" runat="server"  GroupName="dapan"/><span >C. we</span></div>
   <div class="traloi"><asp:RadioButton ID="RadioButton4" runat="server"  GroupName="dapan"/><span >D. you</span></div><br />
    <br /><br /><hr />
</div>

          <div id="question3"  runat="server" class="chitietcauhoi">
      <p>Question 3:The sun ......... in the east, and sets in the west.</p>
  <div class="traloi"><asp:RadioButton ID="RadioButton5" runat="server"  GroupName="dapan3"  /><span >A. rise</span></div>
<div class="traloi"><asp:RadioButton ID="RadioButton6" runat="server"  GroupName="dapan3"  /><span >B. rises</span></div> <br />
    <div class="traloi"><asp:RadioButton ID="RadioButton7" runat="server"  GroupName="dapan3"/><span >C. rose</span></div> 
    <div class="traloi"><asp:RadioButton ID="RadioButton8" runat="server"  GroupName="dapan3"/><span >D. rosen</span></div><br />
   <br /><br /><hr />
              </div>
        
          <div id="question4"  runat="server" class="chitietcauhoi">
      <p>Question 4: We were early enough .......... good seats.</p>
   
    <div class="traloi"><asp:RadioButton ID="RadioButton9" runat="server"  GroupName="dapan4"  /><span >A. to get</span></div>
<div class="traloi"><asp:RadioButton ID="RadioButton10" runat="server"  GroupName="dapan4"  /><span >B. get</span></div> <br />
    <div class="traloi"><asp:RadioButton ID="RadioButton11" runat="server"  GroupName="dapan4"/><span >C. getting</span> </div>
    <div class="traloi"><asp:RadioButton ID="RadioButton12" runat="server"  GroupName="dapan4"/><span >D. got</span></div><br />
<br /><br /><hr />
              </div>
        
          <div id="question5"  runat="server" class="chitietcauhoi" >
      <p>Question 5: I don't think I'll go .......... now. It's too cold.</p>
   
     <div class="traloi"><asp:RadioButton ID="RadioButton17" runat="server"  GroupName="dapan5"  /><span >A. outdoors</span></div>
<div class="traloi"><asp:RadioButton ID="RadioButton18" runat="server"  GroupName="dapan5"  /><span >B. inside</span></div> <br />
    <div class="traloi"><asp:RadioButton ID="RadioButton19" runat="server"  GroupName="dapan5"/><span >C. outside </span> </div>
    <div class="traloi"><asp:RadioButton ID="RadioButton20" runat="server"  GroupName="dapan5"/><span >D. A&C</span></div><br />
  <br /><br /><hr />
              </div>
      
          <div id="question6"  runat="server" class="chitietcauhoi">

      <p>Question 6: She speaks English ...........</p>
   
      <div class="traloi"><asp:RadioButton ID="RadioButton21" runat="server"  GroupName="dapan6"  /><span >A. fluent</span> </div>
<div class="traloi"><asp:RadioButton ID="RadioButton22" runat="server"  GroupName="dapan6"  /><span >B. fluently</span></div> <br />
    <div class="traloi"><asp:RadioButton ID="RadioButton23" runat="server"  GroupName="dapan6"/><span >C. easy</span></div>
   <div class="traloi"> <asp:RadioButton ID="RadioButton24" runat="server"  GroupName="dapan6"/><span >D. good</span></div><br />
  <br /><br /><hr />
</div>
     

        
   
        
          <div id="question7" runat="server" class="chitietcauhoi">

      <p>Question 7: She speaks English ...........</p>
      <div class="traloi"><asp:RadioButton ID="RadioButton25" runat="server"  GroupName="dapan6"  /><span >A. fluent</span></div>
<div class="traloi"><asp:RadioButton ID="RadioButton26" runat="server"  GroupName="dapan6"  /><span >B. fluently</span></div> <br />
   <div class="traloi"> <asp:RadioButton ID="RadioButton27" runat="server"  GroupName="dapan6"/><span >C. easy</span></div>
    <div class="traloi"><asp:RadioButton ID="RadioButton28" runat="server"  GroupName="dapan6"/><span >D. good</span></div><br />
 <br /><br /><hr />
</div>
        

        <div class="button">
       <asp:Button ID="btn_next" runat="server" Text="Next &raquo;" OnClick="btn_next_Click" />
    </div>
       <div class="button2">
       <asp:Button ID="btn_back" runat="server" Text="&laquo; Back" OnClick="btn_back_Click" />
    </div>
        <div class="nopbai">
       <asp:Button ID="btn_nopbai" runat="server" Text="Nộp bài" OnClick="btn_nopbai_Click" />
    
</div>  
         
    
    </div>
        
    
    </div>
</asp:Content>

