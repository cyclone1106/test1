using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_ChinhsuaTuvung : System.Web.UI.Page
{
    ketnoi ketnoi = new ketnoi();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            string id = Request.QueryString["id"].ToString();
            string tuvung = "select * from TUVUNG a, CHUDE_TUVUNG b where a.IDChude = b.IDChude and IDTuvung='" + id + "'";
            DataTable tb_tuvung = ketnoi.getData(tuvung);
            txt_chude.Text = tb_tuvung.Rows[0]["Tenchude"].ToString();
            txt_tuvung.Text = tb_tuvung.Rows[0]["Tentuvung"].ToString();
            txt_phienam.Text = tb_tuvung.Rows[0]["Phienam"].ToString();
            txt_loaitu.Text = tb_tuvung.Rows[0]["Loaituvung"].ToString();
            txt_nghia.Text = tb_tuvung.Rows[0]["Nghiatuvung"].ToString();
            txt_vidu.Text = tb_tuvung.Rows[0]["Vidu"].ToString();
        }
    }

    protected void btn_capnhat_Click(object sender, EventArgs e)
    {
        string id = Request.QueryString["id"].ToString();
        string update = "update TUVUNG set Tentuvung='"+txt_tuvung.Text+"', Phienam ='"+txt_phienam.Text+"',Loaituvung ='"+txt_loaitu.Text+"',Nghiatuvung=N'"+txt_nghia.Text+"',Vidu='"+txt_vidu.Text+"' where IDTuvung='" + id + "'";
        try
        {
            ketnoi.executeQuery(update);
            Response.Write("<script>alert('Cập nhật thành công!'); window.location.href='Admin-Tuvung.aspx'</script>");
        }
        catch
        {
            Response.Write("<script>alert('Cập nhật không thành công!');</script>");
        }
    }
    protected void btn_huy_Click(object sender, EventArgs e)
    {
        Response.Redirect("AdminTuvung.aspx");
    }
}