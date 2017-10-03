using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Doimatkhau : System.Web.UI.Page
{
    ketnoi ketnoi = new ketnoi();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btn_Dangky_Click(object sender, EventArgs e)
    {
        string kiemtra = "select * from THANHVIEN where Tendangnhap='" + Session["tendangnhap"] + "' and Matkhau='" + txt_matkhaucu.Text + "'";
        DataTable tb_kiemtra = ketnoi.getData(kiemtra);
        if (tb_kiemtra.Rows.Count > 0)
        {
            if (txt_matkhaumoi.Text.Trim() != txt_nhaplaimatkhaumoi.Text.Trim())
                Response.Write("<script> alert('Mật khẩu không trùng khớp!')</script>");
            else
            {
                string sql = "update THANHVIEN set Matkhau='" + txt_matkhaumoi.Text + "' where Tendangnhap='" + Session["tendangnhap"].ToString() + "'";
                try
                {
                    ketnoi.executeQuery(sql);
                    Response.Write("<script> alert('Mật khẩu đã được thay đổi!'), window.location.href='Default.aspx'; </script>");
                }
                catch
                {
                    Response.Write("<script> alert('Mật khẩu thay đổi không thành công!')</script>");
                }
            }
        }
        else
            Response.Write("<script> alert('Mật khẩu không chính xác!')</script>");
    
    }
    protected void btn_Huy_Click(object sender, EventArgs e)
    {
        Response.Redirect("Default.aspx");
    }
}