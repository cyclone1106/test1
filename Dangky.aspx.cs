using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Dangky : System.Web.UI.Page
{
    ketnoi ketnoi = new ketnoi();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        { }
    }
    protected void btn_Dangky_Click(object sender, EventArgs e)
    {
        string id="select Max(IDThanhvien) from THANHVIEN";
        DataTable tb_id=ketnoi.getData(id);

        int mathanhvien;
        if (tb_id.Rows.Count == 0)
            mathanhvien = 1;
        else
        mathanhvien=Int32.Parse(tb_id.Rows[0][0].ToString());

        string tendangnhap = "select Tendangnhap from TENDANGNHAP where Tendangnhap='"+Session["Tendangnhap"].ToString()+"'";
        DataTable tb_tendangnhap = ketnoi.getData(tendangnhap);
        if (txt_hoten.Text =="")
            Response.Write("<script>alert('Họ tên không được bỏ trống!')</script>");
        else if (txt_tendangnhap.Text == "")
            Response.Write("<script>alert('Tên đăng nhập không được bỏ trống')</script>");
        else if (tb_tendangnhap.Rows.Count > 0)
            Response.Write("<script>alert('Tên đăng nhập đã tồn tại')</script>");
        else if(txt_matkhau.Text=="")
            Response.Write("<script>alert('Mật khẩu không được bỏ trống')</script>");
        else if (txt_matkhau.Text.Trim() != txt_nhaplaimatkhau.Text.Trim())
            Response.Write("<script>alert('Mật khẩu nhập lại không trùng khớp')</script>");
        else
        {
            string gioitinh;
            if (rd_nam.Checked)
                gioitinh = "Nam";
            else
                gioitinh = "Nữ";
            string dangky = "insert into THANHVIEN values('" + (mathanhvien + 1) + "',N'" + txt_hoten.Text + "','" + txt_tendangnhap.Text + "','" +
                txt_matkhau.Text + "',2,'" + txt_ngaysinh.Text + "','" + gioitinh + "',N'" + txt_noisinh.Text + "',N'" + txt_diachi.Text + "','" + txt_sodienthoai.Text + "', '" + txt_email.Text + "',N'" + dr_nghenghiep.Text + "')";
            try
            {
                ketnoi.executeQuery(dangky);
                Response.Write("<script> alert('Đăng ký thành công!'); </script>");
            }
            catch { Response.Write("<script> alert('Đăng ký không thành công!'); </script>"); }
        }
    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}