<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeFile="Admin_gioithieu.aspx.cs" Inherits="Admin_gioithieu" %>
<%@ Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor" %>
<%@ Register Namespace="CKFinder" Assembly="CKFinder" TagPrefix="CKFinder" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <CKFinder:FileBrowser ID="FileBrowser1"   Width="0" runat="server" OnLoad="FileBrowser1_Load"></CKFinder:FileBrowser>           
     <div class="themcauhoi" style="margin-top:-400px">
    <p>CẬP NHẬT GIỚI THIỆU</p>
    <table>
        <tr>
            <td>Nội dung rút gọn</td>
             <td>
                 <asp:TextBox ID="txt_rutgon" runat="server" Height="50px" Width="813px"></asp:TextBox></td>
           

        </tr> 
        <tr>
        <td>Nội dung</td>
        <td><CKEditor:CKEditorControl ID="txt_doanvan" runat="server" BasePath="~/ckeditor" Height="194px" Width="813px"></CKEditor:CKEditorControl></td>
       </tr>
         <tr>
            <td style="text-align:center">
            <asp:Button ID="btn_capnhat" runat="server" Text="Cập nhật" OnClick="btn_capnhat_Click"  Width="150" Height="50" BackColor="#339933" ForeColor="#ffffff" />

            </td>
        </tr>
    </table>
         </div>
</asp:Content>

