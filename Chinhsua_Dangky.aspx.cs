using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Chinhsua_Dangky : System.Web.UI.Page
{
    ketnoi ketnoi = new ketnoi();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            string dangky = "select * from THANHVIEN where Tendangnhap='" + Session["Tendangnhap"].ToString() + "'";
            DataTable tb_dangky = ketnoi.getData(dangky);
            txt_hoten.Text = tb_dangky.Rows[0]["Hoten"].ToString().Trim();
            string gioitinh = tb_dangky.Rows[0]["Gioitinh"].ToString().Trim();
            if (gioitinh == "Nam")
                rd_nam.Checked = true;
            else
                rd_nu.Checked = true;
            DateTime dt = DateTime.Parse(tb_dangky.Rows[0]["Ngaysinh"].ToString().Trim());
            txt_ngaysinh.Text = dt.ToString("yyyy-MM-dd");
            txt_noisinh.Text = tb_dangky.Rows[0]["Noisinh"].ToString().Trim();
            txt_diachi.Text = tb_dangky.Rows[0]["Diachi"].ToString().Trim();
            txt_sodienthoai.Text = tb_dangky.Rows[0]["Sodienthoai"].ToString().Trim();
            txt_email.Text = tb_dangky.Rows[0]["Email"].ToString().Trim();
            dr_nghenghiep.Text = tb_dangky.Rows[0]["Nghenghiep"].ToString().Trim();

        }
    }
    protected void btn_Dangky_Click(object sender, EventArgs e)
    {
        string gioitinh;
        if (rd_nam.Checked)
            gioitinh = "Nam";
        else
            gioitinh="Nữ";
        string update = "update THANHVIEN set Hoten=N'"+txt_hoten.Text+"',Gioitinh=N'"+gioitinh+"',Ngaysinh='"+txt_ngaysinh.Text+"',Noisinh=N'"+txt_noisinh.Text+"',Diachi=N'"+txt_diachi.Text+"',Nghenghiep=N'"+dr_nghenghiep.Text+"',Email='"+txt_email.Text+"',Sodienthoai='"+txt_sodienthoai.Text+"' where Tendangnhap='"+Session["Tendangnhap"].ToString()+"'";
        try
        {
            ketnoi.executeQuery(update);
            Response.Write("<script>alert('Cập nhật thành công!'), window.location.href='Default.aspx' </script>");
        }
        catch{
         Response.Write("<script>alert('Cập nhật không thành công!'), window.location.href='Default.aspx' </script>");
        }

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("Doimatkhau.aspx");
    }
}