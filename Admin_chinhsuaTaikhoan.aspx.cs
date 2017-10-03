using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_chinhsuaTaikhoan : System.Web.UI.Page
{
    ketnoi ketnoi= new ketnoi();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            string id = Request.QueryString["id"];
            string sql = "select * from THANHVIEN where Tendangnhap='" + id + "'";
            DataTable dt = ketnoi.getData(sql);
            txt_tendangnhap.Text = dt.Rows[0]["Tendangnhap"].ToString();
            txt_matkhau.Text = dt.Rows[0]["Matkhau"].ToString();
            dr_phanquyen.Text = dt.Rows[0]["Phanquyen"].ToString();
        }
    }
    protected void bnt_Capnhat_Click(object sender, EventArgs e)
    {
        string sql = "update THANHVIEN set Matkhau='" + txt_matkhau.Text + "', Phanquyen=" + dr_phanquyen.Text + " where Tendangnhap='" + txt_tendangnhap.Text + "'";
        try
        {
            ketnoi.executeQuery(sql);
            Response.Write("<script> alert('Cập nhật thành công!'); window.location.href='Admin_Taikhoan.aspx' </script>");
        }
        catch {
            Response.Write("<script> alert('Cập nhật không thành công!'); </script>");
        }
    }
    protected void btn_Huy_Click(object sender, EventArgs e)
    {

    }
}