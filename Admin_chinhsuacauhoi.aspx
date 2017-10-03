<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeFile="Admin_chinhsuacauhoi.aspx.cs" Inherits="Admin_chinhsuacauhoi" %>
 <%@ Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor" %>
<%@ Register Namespace="CKFinder" Assembly="CKFinder" TagPrefix="CKFinder" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="themcauhoi" >
    <p>CẬP NHẬT CÂU HỎI</p>
   
        <table class="admin_cauhoi" style="margin-top:-400px">
           <%-- <tr>
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
            </tr>--%>
               <CKFinder:FileBrowser ID="FileBrowser1"   Width="0" runat="server" OnLoad="FileBrowser1_Load"></CKFinder:FileBrowser>           
             <tr id="noidungdoanvan" runat="server">
                <td> Nội dung đoạn văn:</td>
                <td colspan="2"><CKEditor:CKEditorControl ID="txt_doanvan" runat="server" BasePath="~/ckeditor" Height="194px" Width="813px"></CKEditor:CKEditorControl>   

                </td>
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
            
            <tr>
                <td colspan="2"  class="button">
                    <asp:Button ID="btn_Them" runat="server" Text="Cập nhật" OnClick="bnt_Capnhat_Click" />
                    <asp:Button ID="btn_Huy" runat="server" Text="Hủy" OnClick="btn_Huy_Click" />
                </td>
                
           
                 </tr>
          
                
        </table>
            

            
            
            
                   
            

           
</asp:Content>

