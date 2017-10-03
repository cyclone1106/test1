using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Amin_chinhsuaNguphap : System.Web.UI.Page
{
    ketnoi ketnoi = new ketnoi();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            string id = Request.QueryString["id"].ToString();
            string nguphap = "select * from NGUPHAP a, CHUDE_NGUPHAP b where a.IDChude = b.IDChude and IDNguphap='" + id + "'";
            DataTable tb_nguphap = ketnoi.getData(nguphap);
            dr_tennguphap.Text = tb_nguphap.Rows[0]["Tenchude"].ToString();
            txt_noidung.Text = tb_nguphap.Rows[0]["Noidung"].ToString();
        }
    }
    protected void btn_capnhat_Click(object sender, EventArgs e)
    {
        string id = Request.QueryString["id"].ToString();
    string update = "update NGUPHAP set Noidung=N'" + txt_noidung.Text + "' where IDNguphap='" + id + "'";
    try
    {
        ketnoi.executeQuery(update);
        Response.Write("<script>alert('Cập nhật thành công!'); window.location.href='Admin-Nghuphap.aspx'</script>");
    }
    catch {
        Response.Write("<script>alert('Cập nhật không thành công!');</script>");
    }
    }
    protected void btn_huy_Click(object sender, EventArgs e)
    {
        Response.Redirect("Admin-Nguphap.aspx");
    }
}