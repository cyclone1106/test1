<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" MaintainScrollPositionOnPostback="true" CodeFile="Admin_Chinhsuakinhnghiem.aspx.cs" Inherits="Admin_Chinhsuakinhnghiem" %>
 <%@ Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor" %>
<%@ Register Namespace="CKFinder" Assembly="CKFinder" TagPrefix="CKFinder" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            height: 39px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
      <CKFinder:FileBrowser ID="FileBrowser1"   Width="0" runat="server" OnLoad="FileBrowser1_Load"></CKFinder:FileBrowser>           
    <div class="themcauhoi">
    <p>CẬP NHẬT KINH NGHIỆM</p>
        <table class="admin_cauhoi">
            <tr>
                <td class="auto-style1">Tiêu đề</td>
                <td colspan="2" class="auto-style1"><asp:TextBox ID="txt_tieude" runat="server" Width="800px" Height="30px"></asp:TextBox></td>
            </tr>
              <tr>
                <td>Ngày đăng</td>
                <td colspan="2"><asp:TextBox ID="txt_ngaydang" runat="server" TextMode="Date"></asp:TextBox></td>
            </tr>
             <tr>
                <td>Ảnh tiêu đề</td>
                 <td style="width:170px"><img id="hinhanh" src='images/<%=idhinhanh %>' width="150" height="100" /></td>
                     <td><asp:Button ID="btn_hinhanh" CssClass="btn_hinhanh" runat="server" Text="Thay đổi hình ảnh" OnClick="btn_hinhanh_Click" Width="150px" Height="50px" BackColor="#339933" ForeColor="#ffffff"/><asp:FileUpload ID="FileUpload1" runat="server" /></td>
                 
           
                

            </tr>
               <tr>
                <td>Nội dung rút gọn</td>
                <td colspan="2"><asp:TextBox ID="txt_rutgon" runat="server" Width="800px" Height="30px"></asp:TextBox></td>
            </tr>
              <tr>
                <td>Nội dung</td>
                <td colspan="2"> <CKEditor:CKEditorControl ID="txt_doanvan" runat="server" BasePath="~/ckeditor" Height="689px" Width="902px"></CKEditor:CKEditorControl>  </td>
            </tr>
           
              <tr style="text-align:center;">
            <td colspan="3" >
            <asp:Button ID="btn_capnhat" runat="server" Text="Cập nhật" OnClick="btn_capnhat_Click"  Width="150" Height="50" BackColor="#339933" ForeColor="#ffffff" />
                <asp:Button ID="Button1" runat="server" Text="Hủy" OnClick="btn_huy_Click"  Width="150" Height="50" BackColor="#339933" ForeColor="#ffffff" />
            </td>
        </tr>

        </table>
    </div>
    
</asp:Content>

