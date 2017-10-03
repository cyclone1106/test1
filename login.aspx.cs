using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class login : System.Web.UI.Page
{
    ketnoi ketnoi = new ketnoi();

    protected void Page_Load(object sender, EventArgs e)
    {
        
    }
    protected void btn_dangnhap_Click(object sender, EventArgs e)
    {
        string sql = "select * from THANHVIEN where Tendangnhap=N'" + txt_tendangnhap.Text + "' and Matkhau='" + GetMD5(txt_matkhau.Text) + "'";
        DataTable dt = ketnoi.getData(sql);
        int row = dt.Rows.Count;


        if (row > 0)
        {
            Session["tendangnhap"] = txt_tendangnhap.Text;
            Session["matkhau"] = txt_matkhau.Text;
            Session["phanquyen"] = dt.Rows[0]["Phanquyen"].ToString();
            if (luumatkhau.Checked)
            {
                Response.Cookies["tendangnhap"].Value = txt_tendangnhap.Text;
                Response.Cookies["matkhau"].Value = txt_matkhau.Text;
            }
            Response.Write("<script> window.location.href='Default.aspx';</script>");
        }
        else
            Response.Write("<script> alert ('Tên đăng nhập hoặc mật khẩu không hợp lệ!'); </script>");
       

        
    }
    private String GetMD5(string txt)
    {
        String str = "";
        Byte[] buffer = System.Text.Encoding.UTF8.GetBytes(txt);
        System.Security.Cryptography.MD5CryptoServiceProvider md5 = new System.Security.Cryptography.MD5CryptoServiceProvider();
        buffer = md5.ComputeHash(buffer);
        foreach (Byte b in buffer)
        {
            str += b.ToString("X2");
        }
        str = str.ToLower();
        return str;
    }
}