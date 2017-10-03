<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeFile="Admin_Themnguphap.aspx.cs" Inherits="Admin_Themnguphap" %>
<%@ Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor" %>
<%@ Register Namespace="CKFinder" Assembly="CKFinder" TagPrefix="CKFinder" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
      <CKFinder:FileBrowser ID="FileBrowser1"   Width="0" runat="server" OnLoad="FileBrowser1_Load"></CKFinder:FileBrowser>           
       <div class="themcauhoi" style="margin-top:-400px;">
    <p>THÊM NGỮ PHÁP</p>
        <table class="admin_cauhoi">
                <tr id="tennguphap" runat="server">
                    <td>Tên ngữ pháp</td>
                    <td>
                        <asp:DropDownList ID="dr_tennguphap" runat="server" DataSourceID="SqlDataSource1" DataTextField="Tenchude" DataValueField="IDChude"></asp:DropDownList>
                        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ToeicConnectionString %>" SelectCommand="SELECT * FROM [CHUDE_NGUPHAP] ORDER BY [Tenchude]"></asp:SqlDataSource>
                    </td>
                </tr>
                  <tr id="cautruc" runat="server">
                    <td>Cấu trúc ngữ pháp</td>
                    <td>
                        <CKEditor:CKEditorControl ID="txt_noidung" runat="server" BasePath="~/ckeditor" Height="194px" Width="813px"></CKEditor:CKEditorControl></td>
                </tr>
                
               <tr>
                <td colspan="2" style="text-align:center">
                    <asp:Button ID="Button1" runat="server" Text="Thêm" OnClick="Button1_Click"  Width="150" Height="50" BackColor="#339933" ForeColor="#ffffff" />
                    <asp:Button ID="Button2" runat="server" Text="Hủy"  Width="150" Height="50" BackColor="#339933" ForeColor="#ffffff"/>
                </td>
            </tr>
        </table>
            </div>
</asp:Content>

