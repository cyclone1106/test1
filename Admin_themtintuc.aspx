<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeFile="Admin_themtintuc.aspx.cs" Inherits="Admin_themtintuc" %>
 <%@ Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor" %>
<%@ Register Namespace="CKFinder" Assembly="CKFinder" TagPrefix="CKFinder" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <CKFinder:FileBrowser ID="FileBrowser1"   Width="0" runat="server" OnLoad="FileBrowser1_Load"></CKFinder:FileBrowser>           
    <div class="themcauhoi" style="margin-top:-400px">
    <p>THÊM TIN TỨC</p>
        <table class="admin_cauhoi">
            <tr>
                <td>Tiêu đề</td>
                <td><asp:TextBox ID="txt_tieude" runat="server" Width="800px" Height="30px"></asp:TextBox></td>
            </tr>
              <tr>
                <td>Ngày đăng</td>
                <td><asp:TextBox ID="txt_ngaydang" runat="server" TextMode="Date"></asp:TextBox></td>
            </tr>
             <tr>
                <td>Ảnh tiêu đề</td>
                <td><asp:FileUpload ID="FileUpload1" runat="server" /></td>
                

            </tr>
               <tr>
                <td>Nội dung rút gọn</td>
                <td><asp:TextBox ID="txt_rutgon" runat="server" Width="800px" Height="30px"></asp:TextBox></td>
            </tr>
              <tr>
                <td>Nội dung</td>
                <td> <CKEditor:CKEditorControl ID="txt_doanvan" runat="server" BasePath="~/ckeditor" Height="194px" Width="813px"></CKEditor:CKEditorControl>  </td>
            </tr>
           
              <tr style="text-align:center;">
            <td colspan="2" >
            <asp:Button ID="btn_capnhat" runat="server" Text="Thêm tin tức" OnClick="btn_capnhat_Click"  Width="150" Height="50" BackColor="#339933" ForeColor="#ffffff" />

            </td>
        </tr>

        </table>
    </div>
    
   
</asp:Content>

