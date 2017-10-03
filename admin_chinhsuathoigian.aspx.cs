using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_chinhsuathoigian : System.Web.UI.Page
{
    ketnoi ketnoi = new ketnoi();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            string id= Request.QueryString["id"];
            string sql = "select * from DONGHO where IdDongho='" + id + "'";
            DataTable tb_dongho = ketnoi.getData(sql);
            txt_loai.Text = tb_dongho.Rows[0]["Phan"].ToString();
            txt_phut.Text = tb_dongho.Rows[0]["Phut"].ToString();
            txt_giay.Text = tb_dongho.Rows[0]["Giay"].ToString();
        }
    }
    protected void btn_capnhat_Click(object sender, EventArgs e)
    {
        string id= Request.QueryString["id"];
        string update = "update DONGHO set Phut ="+txt_phut.Text+", Giay="+txt_giay.Text+" where IdDongho='"+id+"'";
        try {
            ketnoi.executeQuery(update);
            Response.Write("<script> alert('Cập nhật thành công!'); window.location.href='admin_thoigian.aspx' </script>");
        }
        catch {
            Response.Write("<script> alert('Cập nhật không thành công!'); window.location.href='admin_thoigian.aspx' </script>");
        }
    }
    protected void btn_huy_Click(object sender, EventArgs e)
    {
        Response.Redirect("admin_thoigian.aspx");
    }
}