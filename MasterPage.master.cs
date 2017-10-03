using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MasterPage : System.Web.UI.MasterPage
{
    private string _bodyId;
    public string BodyId
    {
        get { return _bodyId; }
        set { _bodyId = value; }
    }
    ketnoi ketnoi = new ketnoi();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
          
            
            dangnhapthanhcong.Visible = false;
            

            if (Session["tendangnhap"] == null)
            {
                dangnhap.Visible = true;
                dangnhapthanhcong.Visible = false;
                dangky.Visible = true;
                dangxuat.Visible = false;
                thanhvien.Visible = false;
            }
            else
            {
                string hoten = "select Hoten from THANHVIEN where Tendangnhap='" + Session["tendangnhap"].ToString() + "'";
                DataTable tb_hoten = ketnoi.getData(hoten);
                txt_hoten.Text = tb_hoten.Rows[0][0].ToString();
                thanhvien.Visible = true;
                int phanquyen = Int32.Parse(Session["phanquyen"].ToString());

                if (phanquyen == 1)
                    dangnhapthanhcong.HRef = "admin_thongke.aspx";
                else
                    dangnhapthanhcong.HRef = "Chinhsua_Dangky.aspx";

                lbl_username.Text = Session["tendangnhap"].ToString();
                dangnhap.Visible = false;
                dangnhapthanhcong.Visible = true;
                dangky.Visible = false;
                dangxuat.Visible = true;
            }

            string sql_diemthi = "select TOP 10 * from BANGDIEM a, THANHVIEN b where a.IDThanhvien = b.IDThanhvien order by Tongdiem DESC";
            rpt_diemthi.DataSource = ketnoi.getData(sql_diemthi);
            rpt_diemthi.DataBind();
        }
       
    }
    protected void btn_dangnhap_Click(object sender, EventArgs e)
    {
       
        string sql = "select * from THANHVIEN where Tendangnhap=N'" + txt_tendangnhap.Text + "' and Matkhau='" + txt_matkhau.Text + "'";
        DataTable dt = ketnoi.getData(sql);
        int row = dt.Rows.Count;


        if (row > 0)
        {
            if (Session["tendangnhap"] == null)
            {

                Session["tendangnhap"] = txt_tendangnhap.Text;
                Session["matkhau"] = txt_matkhau.Text;
                Session["phanquyen"] = dt.Rows[0]["Phanquyen"].ToString();
                lbl_username.Text = Session["tendangnhap"].ToString();
                int phanquyen = Int32.Parse(Session["phanquyen"].ToString());
                if (phanquyen == 1)
                    dangnhapthanhcong.HRef = "admin_thongke.aspx";
                else
                    dangnhapthanhcong.HRef = "Chinhsua_Dangky.aspx";
                thanhvien.Visible = true;
                dangnhap.Visible = false;
                dangnhapthanhcong.Visible = true;
                dangky.Visible = false;
                dangxuat.Visible = true;
            }
            if (luumatkhau.Checked)
            {
                Response.Cookies["tendangnhap"].Value = txt_tendangnhap.Text;
                Response.Cookies["matkhau"].Value = txt_matkhau.Text;
            }
         
        }
        else
        {
        
            Response.Write("<script> alert ('Tên đăng nhập hoặc mật khẩu không hợp lệ!'); </script>");
        }
    
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
    protected void dangxuat_Click(object sender, EventArgs e)
    {
        Session.Clear();

        dangnhap.Visible = true;
        dangnhapthanhcong.Visible = false;
        dangky.Visible = true;
        dangxuat.Visible = false;
        Response.Write("<script>Window.location.href='Default.aspx';</script>");
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
      
        Response.Redirect("Timkiem.aspx?id="+txt_timkiem.Text+"");
    }
}
