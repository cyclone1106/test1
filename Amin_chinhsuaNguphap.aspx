<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeFile="Amin_chinhsuaNguphap.aspx.cs" Inherits="Amin_chinhsuaNguphap" %>
<%@ Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <div class="themcauhoi">
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
                    <td>Nội dung</td>
                    <td>
                        <CKEditor:CKEditorControl ID="txt_noidung" runat="server" BasePath="~/ckeditor" Height="194px" Width="813px"></CKEditor:CKEditorControl></td>
                </tr>
                  <tr id="giaithich" runat="server">
                    <td>Giải thích</td>
                    <td><CKEditor:CKEditorControl ID="CKEditorControl2" runat="server" BasePath="~/ckeditor" Height="194px" Width="813px"></CKEditor:CKEditorControl></td>
                </tr>
                  <tr id="vidunguphap" runat="server">
                    <td>Ví dụ ngữ pháp</td>
                    <td><CKEditor:CKEditorControl ID="txt_vidu" runat="server" BasePath="~/ckeditor" Height="194px" Width="813px"></CKEditor:CKEditorControl></td>
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

