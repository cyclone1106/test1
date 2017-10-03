<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeFile="Admin_Them_Cauhoi.aspx.cs" Inherits="Admin_Them_Cauhoi" %>
 <%@ Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor" %>
<%@ Register Namespace="CKFinder" Assembly="CKFinder" TagPrefix="CKFinder" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
   
    <CKFinder:FileBrowser ID="FileBrowser1"   Width="0" runat="server" OnLoad="FileBrowser1_Load"></CKFinder:FileBrowser>           
 
    <div class="themcauhoi" style="margin-top:-400px">
    <p>THÊM CÂU HỎI</p>
        <table class="admin_cauhoi">
            <tr>
                <td>Phần</td>
                <td colspan="2">
                    <asp:DropDownList ID="dr_Phan" runat="server" AutoPostBack="True" DataSourceID="SqlDataSource1" DataTextField="TenNoidung" DataValueField="IDNoidung" OnSelectedIndexChanged="dr_Phan_SelectedIndexChanged" Width="200" Height="25">
                        <asp:ListItem>----Chọn phần---</asp:ListItem>
                    </asp:DropDownList>
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ToeicConnectionString %>" SelectCommand="SELECT * FROM [NOIDUNG] WHERE (([IDNoidung] &lt;&gt; @IDNoidung) AND ([IDNoidung] &lt;&gt; @IDNoidung2))">
                        <SelectParameters>
                            <asp:Parameter DefaultValue="Grammar" Name="IDNoidung" Type="String" />
                            <asp:Parameter DefaultValue="Vocabulary" Name="IDNoidung2" Type="String" />
                        </SelectParameters>
                    </asp:SqlDataSource>
                </td>
            </tr>
             <tr id="capdo" runat="server">
                 <td>Cấp độ: </td>
                 <td colspan="2">
                     <asp:DropDownList ID="dr_capdo" runat="server"  Height="25px" DataSourceID="SqlDataSource2" DataTextField="IDCap" DataValueField="IDCap"></asp:DropDownList>
                     <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:ToeicConnectionString %>" SelectCommand="SELECT * FROM [CAPDO]"></asp:SqlDataSource>
                 </td>
             </tr>
            <tr id="noidung" runat="server">
                <td>Nội dung:</td>
                <td colspan="2"> <asp:DropDownList ID="dr_noidung" runat="server" DataSourceID="Noidungcauhoi" DataTextField="Tennoidung" DataValueField="IDNoidungchitiet" AutoPostBack="True" Width="200px"  Height="25" OnSelectedIndexChanged="dr_noidung_SelectedIndexChanged"></asp:DropDownList>
                    <asp:SqlDataSource ID="Noidungcauhoi" runat="server" ConnectionString="<%$ ConnectionStrings:ToeicConnectionString %>" SelectCommand="SELECT * FROM [CHITIETNOIDUNG] WHERE ([IDNoidung] = @IDNoidung) ORDER BY [Tennoidung]">
                        <SelectParameters>
                            <asp:ControlParameter ControlID="dr_Phan" Name="IDNoidung" PropertyName="SelectedValue" Type="String" />
                        </SelectParameters>
                    </asp:SqlDataSource>
                </td>
            </tr>
            <tr id="dethi" runat="server">
                 <td>Đề thi: </td>
                 <td colspan="2">
                     <asp:DropDownList ID="dr_dethi" runat="server"  Height="25"></asp:DropDownList></td>
             </tr>
             <tr id="fileNghe" runat="server">
                 <td>File nghe:</td>
                 <td colspan="2">
                     <asp:FileUpload ID="FileUpload2" runat="server" /></td>
             </tr>
            <tr id="soluongcauhoi" runat="server">
                <td> Số lượng câu hỏi:</td>
                <td colspan="2"><asp:DropDownList ID="dr_soluong" runat="server" AutoPostBack="True" Width="105" Height="25" OnSelectedIndexChanged="dr_soluong_SelectedIndexChanged"></asp:DropDownList></td>
            </tr>
             <tr id="causo" runat="server">
                <td id="id_causo" runat="server">Câu số:</td>
                  <td id="id_caubatdau" runat="server">Bắt đầu từ câu:</td>
                <td colspan="2"><asp:DropDownList ID="dr_socauhoi" runat="server" AutoPostBack="True" Width="105" Height="25" OnSelectedIndexChanged="dr_socauhoi_SelectedIndexChanged"></asp:DropDownList></td>
            </tr>
             <tr id="noidungdoanvan" runat="server">
                <td> Nội dung đoạn văn:</td>
                <td colspan="2"><CKEditor:CKEditorControl ID="txt_doanvan" runat="server" BasePath="~/ckeditor" Height="194px" Width="813px"></CKEditor:CKEditorControl>   

                </td>
            </tr>
            <tr id="fileAnh" runat="server">
                 <td>File ảnh:</td>
                 <td colspan="2">
                     <asp:FileUpload ID="FileUpload1" runat="server" /></td>

             </tr>
             <tr id="cauhoi" runat="server">
                 <td>Nội dung câu hỏi: </td>
                 <td colspan="2"><asp:TextBox ID="txt_cauhoi" runat="server" TextMode="MultiLine" Width="810" Height="45"></asp:TextBox></td>
             </tr>
             <tr id="dapanA" runat="server">
                 <td> Đáp án A:</td>
                 <td colspan="2"><asp:TextBox ID="txt_A" runat="server"  TextMode="MultiLine"  Width="810" Height="45"></asp:TextBox>
                     </td>
                 
                 <td>
                     True <asp:RadioButton ID="rd_TrueA" runat="server" GroupName="dapan" Checked="true"/>
                      False <asp:RadioButton ID="rd_FalseA" runat="server"  GroupName="dapan" />
                 </td>
             </tr>
             <tr id="dapanB" runat="server">
                 <td>Đáp án B:</td>
                 <td colspan="2">
                     <asp:TextBox ID="txt_B" runat="server"  TextMode="MultiLine"  Width="810" Height="45"></asp:TextBox></td>
                  <td>
                     True <asp:RadioButton ID="rd_TrueB" runat="server" GroupName="dapan1" Checked="true"/>
                      False <asp:RadioButton ID="rd_FalseB" runat="server"  GroupName="dapan1" />
                 </td>
             </tr>
             <tr id="dapanC" runat="server">
                 <td>Đáp án C:</td>
                 <td colspan="2">
                     <asp:TextBox ID="txt_C" runat="server"  TextMode="MultiLine"  Width="810" Height="45"></asp:TextBox></td>
               <td>
                     True <asp:RadioButton ID="rd_TrueC" runat="server" GroupName="dapan2" Checked="true"/>
                      False <asp:RadioButton ID="rd_FalseC" runat="server"  GroupName="dapan2" />
                 </td>
                  </tr>
            <tr id="dapanD" runat="server">
                 <td>Đáp án D:</td>
                 <td colspan="2">
                     <asp:TextBox ID="txt_D" runat="server"  TextMode="MultiLine"  Width="810" Height="45"></asp:TextBox></td>
                <td>
                     True <asp:RadioButton ID="rd_TrueD" runat="server" GroupName="dapan3" Checked="true"/>
                      False <asp:RadioButton ID="rd_FalseD" runat="server"  GroupName="dapan3" />
                 </td>
             </tr>
            <!--Câu 1-->
             <tr id="cauhoi1" runat="server">
                 <td>Nội dung câu hỏi - Câu số: <%=stt1 %></td>
                 <td colspan="2"><asp:TextBox ID="txt_cauhoi1" runat="server" TextMode="MultiLine" Width="810" Height="45"></asp:TextBox></td>
             
             </tr>
             <tr id="dapanA1" runat="server">
                 <td> Đáp án A:</td>
                 <td colspan="2"><asp:TextBox ID="txt_A1" runat="server"  TextMode="MultiLine"  Width="810" Height="45"></asp:TextBox>
                     </td>
            <td>
                     True <asp:RadioButton ID="rd_TrueA1" runat="server" GroupName="dapan4" Checked="true"/>
                      False <asp:RadioButton ID="rd_FalseA1" runat="server"  GroupName="dapan4" />
                 </td>
                  </tr>
             <tr id="dapanB1" runat="server">
                 <td>Đáp án B:</td>
                 <td colspan="2">
                     <asp:TextBox ID="txt_B1" runat="server"  TextMode="MultiLine"  Width="810" Height="45"></asp:TextBox></td>
             <td>
                     True <asp:RadioButton ID="rd_TrueB1" runat="server" GroupName="dapan5" Checked="true"/>
                      False <asp:RadioButton ID="rd_Falseb1" runat="server"  GroupName="dapan5" />
                 </td>
             </tr>
             <tr id="dapanC1" runat="server">
                 <td>Đáp án C:</td>
                 <td colspan="2">
                     <asp:TextBox ID="txt_C1" runat="server"  TextMode="MultiLine"  Width="810" Height="45"></asp:TextBox></td>
             <td>
                     True <asp:RadioButton ID="rd_TrueC1" runat="server" GroupName="dapan6" Checked="true"/>
                      False <asp:RadioButton ID="rd_FalseC1" runat="server"  GroupName="dapan6" />
                 </td>
             </tr>
            <tr id="dapanD1" runat="server">
                 <td>Đáp án D:</td>
                 <td colspan="2">
                     <asp:TextBox ID="txt_D1" runat="server"  TextMode="MultiLine"  Width="810" Height="45"></asp:TextBox></td>
             <td>
                     True <asp:RadioButton ID="rd_TrueD1" runat="server" GroupName="dapan7" Checked="true"/>
                      False <asp:RadioButton ID="rd_FalseD1" runat="server"  GroupName="dapan7" />
                 </td> 
            </tr>
            <!--Câu 2-->
             <tr id="cauhoi2" runat="server">
                 <td>Nội dung câu hỏi - Câu số: <%=stt2 %></td>
                 <td colspan="2"><asp:TextBox ID="txt_cauhoi2" runat="server" TextMode="MultiLine" Width="810" Height="45"></asp:TextBox></td>
          
             </tr>
             <tr id="dapanA2" runat="server">
                 <td> Đáp án A:</td>
                 <td colspan="2"><asp:TextBox ID="txt_A2" runat="server"  TextMode="MultiLine"  Width="810" Height="45"></asp:TextBox>
                     </td>
            <td>
                     True <asp:RadioButton ID="rd_TrueA2" runat="server" GroupName="dapan8" Checked="true"/>
                      False <asp:RadioButton ID="rd_FalseA2" runat="server"  GroupName="dapan8" />
                 </td>
                  </tr>
             <tr id="dapanB2" runat="server">
                 <td>Đáp án B:</td>
                 <td colspan="2">
                     <asp:TextBox ID="txt_B2" runat="server"  TextMode="MultiLine"  Width="810" Height="45"></asp:TextBox></td>
             <td>
                     True <asp:RadioButton ID="rd_TrueB2" runat="server" GroupName="dapan9" Checked="true"/>
                      False <asp:RadioButton ID="rd_FalseB2" runat="server"  GroupName="dapan9" />
                 </td>
             </tr>
             <tr id="dapanC2" runat="server">
                 <td>Đáp án C:</td>
                 <td colspan="2">
                     <asp:TextBox ID="txt_C2" runat="server"  TextMode="MultiLine"  Width="810" Height="45"></asp:TextBox></td>
             <td>
                     True <asp:RadioButton ID="rd_TrueC2" runat="server" GroupName="dapan10" Checked="true"/>
                      False <asp:RadioButton ID="rd_FalseC2" runat="server"  GroupName="dapan10" />
                 </td>
             </tr>
            <tr id="dapanD2" runat="server">
                 <td>Đáp án D:</td>
                 <td colspan="2">
                     <asp:TextBox ID="txt_D2" runat="server"  TextMode="MultiLine"  Width="810" Height="45"></asp:TextBox></td>
            <td>
                     True <asp:RadioButton ID="rd_TrueD2" runat="server" GroupName="dapan11" Checked="true"/>
                      False <asp:RadioButton ID="rd_FalseD2" runat="server"  GroupName="dapan11" />
                 </td>
                 </tr>
            <!--Câu 3-->
             <tr id="cauhoi3" runat="server">
                 <td>Nội dung câu hỏi - Câu số: <%=stt3 %></td>
                 <td colspan="2"><asp:TextBox ID="txt_cauhoi3" runat="server" TextMode="MultiLine" Width="810" Height="45"></asp:TextBox></td>
            
                  </tr>
             <tr id="dapanA3" runat="server">
                 <td> Đáp án A:</td>
                 <td colspan="2"><asp:TextBox ID="txt_A3" runat="server"  TextMode="MultiLine"  Width="810" Height="45"></asp:TextBox>
                     </td>
            <td>
                     True <asp:RadioButton ID="rd_TrueA3" runat="server" GroupName="dapan12" Checked="true"/>
                      False <asp:RadioButton ID="rd_FalseA3" runat="server"  GroupName="dapan12" />
                 </td>
                  </tr>
             <tr id="dapanB3" runat="server">
                 <td>Đáp án B:</td>
                 <td colspan="2">
                     <asp:TextBox ID="txt_B3" runat="server"  TextMode="MultiLine"  Width="810" Height="45"></asp:TextBox></td>
             <td>
                     True <asp:RadioButton ID="rd_TrueB3" runat="server" GroupName="dapan13" Checked="true"/>
                      False <asp:RadioButton ID="rd_FalseB3" runat="server"  GroupName="dapan13" />
                 </td>
             </tr>
             <tr id="dapanC3" runat="server">
                 <td>Đáp án C:</td>
                 <td colspan="2">
                     <asp:TextBox ID="txt_C3" runat="server"  TextMode="MultiLine"  Width="810" Height="45"></asp:TextBox></td>
            <td>
                     True <asp:RadioButton ID="rd_TrueC3" runat="server" GroupName="dapan14" Checked="true"/>
                      False <asp:RadioButton ID="rd_FalseC3" runat="server"  GroupName="dapan14" />
                 </td>
                  </tr>
            <tr id="dapanD3" runat="server">
                 <td>Đáp án D:</td>
                 <td colspan="2">
                     <asp:TextBox ID="txt_D3" runat="server"  TextMode="MultiLine"  Width="810" Height="45"></asp:TextBox></td>
            <td>
                     True <asp:RadioButton ID="rd_TrueD3" runat="server" GroupName="dapan15" Checked="true"/>
                      False <asp:RadioButton ID="rd_FalseD3" runat="server"  GroupName="dapan15" />
                 </td> 
            </tr>

             <!--Câu 4-->
             <tr id="cauhoi4" runat="server">
                 <td>Nội dung câu hỏi - Câu số: <%=stt4 %></td>
                 <td colspan="2"><asp:TextBox ID="txt_cauhoi4" runat="server" TextMode="MultiLine" Width="810" Height="45"></asp:TextBox></td>
            
             </tr>
             <tr id="dapanA4" runat="server">
                 <td> Đáp án A:</td>
                 <td colspan="2"><asp:TextBox ID="txt_A4" runat="server"  TextMode="MultiLine"  Width="810" Height="45"></asp:TextBox>
                     </td>
             <td>
                     True <asp:RadioButton ID="rd_TrueA4" runat="server" GroupName="dapan16" Checked="true"/>
                      False <asp:RadioButton ID="rd_FalseA4" runat="server"  GroupName="dapan16" />
                 </td>
             </tr>
             <tr id="dapanB4" runat="server">
                 <td>Đáp án B:</td>
                 <td colspan="2">
                     <asp:TextBox ID="txt_B4" runat="server"  TextMode="MultiLine"  Width="810" Height="45"></asp:TextBox></td>
            <td>
                     True <asp:RadioButton ID="rd_TrueB4" runat="server" GroupName="dapan17" Checked="true"/>
                      False <asp:RadioButton ID="rd_FalseB4" runat="server"  GroupName="dapan17" />
                 </td>
                  </tr>
             <tr id="dapanC4" runat="server">
                 <td>Đáp án C:</td>
                 <td colspan="2">
                     <asp:TextBox ID="txt_C4" runat="server"  TextMode="MultiLine"  Width="810" Height="45"></asp:TextBox></td>
            <td>
                     True <asp:RadioButton ID="rd_TrueC4" runat="server" GroupName="dapan18" Checked="true"/>
                      False <asp:RadioButton ID="rd_FalseC4" runat="server"  GroupName="dapan18" />
                 </td>
                  </tr>
            <tr id="dapanD4" runat="server">
                 <td>Đáp án D:</td>
                 <td colspan="2">
                     <asp:TextBox ID="txt_D4" runat="server"  TextMode="MultiLine"  Width="810" Height="45"></asp:TextBox></td>
            <td>
                     True <asp:RadioButton ID="rd_TrueD4" runat="server" GroupName="dapan19" Checked="true"/>
                      False <asp:RadioButton ID="rd_FalseD4" runat="server"  GroupName="dapan19" />
                 </td>
                 </tr>

             <!--Câu 5-->
             <tr id="cauhoi5" runat="server">
                 <td>Nội dung câu hỏi - Câu số: <%=stt5 %></td>
          <td colspan="2"><asp:TextBox ID="txt_cauhoi5" runat="server" TextMode="MultiLine" Width="810" Height="45"></asp:TextBox></td>
             </tr>
             <tr id="dapanA5" runat="server">
                 <td> Đáp án A:</td>
                 <td colspan="2"><asp:TextBox ID="txt_A5" runat="server"  TextMode="MultiLine"  Width="810" Height="45"></asp:TextBox>
                     </td>
             <td>
                     True <asp:RadioButton ID="rd_TrueA5" runat="server" GroupName="dapan20" Checked="true"/>
                      False <asp:RadioButton ID="rd_FalseA5" runat="server"  GroupName="dapan20" />
                 </td>
             </tr>
             <tr id="dapanB5" runat="server">
                 <td>Đáp án B:</td>
                 <td colspan="2">
                     <asp:TextBox ID="txt_B5" runat="server"  TextMode="MultiLine"  Width="810" Height="45"></asp:TextBox></td>
             <td>
                     True <asp:RadioButton ID="rd_TrueB5" runat="server" GroupName="dapan21" Checked="true"/>
                      False <asp:RadioButton ID="rd_FalseB5" runat="server"  GroupName="dapan21" />
                 </td>
             </tr>
             <tr id="dapanC5" runat="server">
                 <td>Đáp án C:</td>
                 <td colspan="2">
                     <asp:TextBox ID="txt_C5" runat="server"  TextMode="MultiLine"  Width="810" Height="45"></asp:TextBox></td>
             <td>
                     True <asp:RadioButton ID="rd_TrueC5" runat="server" GroupName="dapan22" Checked="true"/>
                      False <asp:RadioButton ID="rd_FalseC5" runat="server"  GroupName="dapan22" />
                 </td>
             </tr>
            <tr id="dapanD5" runat="server">
                 <td>Đáp án D:</td>
                 <td colspan="2">
                     <asp:TextBox ID="txt_D5" runat="server"  TextMode="MultiLine"  Width="810" Height="45"></asp:TextBox></td>
            <td>
                     True <asp:RadioButton ID="rd_TrueD5" runat="server" GroupName="dapan23" Checked="true"/>
                      False <asp:RadioButton ID="rd_FalseD5" runat="server"  GroupName="dapan23" />
                 </td> 
            </tr>
            <tr>
                <td colspan="2"  class="button">
                    <asp:Button ID="btn_Them" runat="server" Text="Thêm" OnClick="bnt_Them_Click" />
                    <asp:Button ID="btn_Huy" runat="server" Text="Hủy" OnClick="btn_Huy_Click" />
                </td>
                
           
                 </tr>
          
                
        </table>
            

            
            
            
                   
            

           
            
        
          
         
            
    </div>
</asp:Content>

