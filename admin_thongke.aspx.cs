using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_thongke : System.Web.UI.Page
{
    ketnoi ketnoi = new ketnoi();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            string sql_noidung = "select COUNT(b.IDCauhoi) as soluong, c.IDNoidung from CHITIETNOIDUNG a, CAUHOI b, NOIDUNG c where a.IDNoidungchitiet=b.IDNoidung and a.IDNoidung=c.IDNoidung group by c.IDNoidung";
            Repeater1.DataSource = ketnoi.getData(sql_noidung);
            Repeater1.DataBind();

            string sql_tintuc = "select COUNT(IDTinmoi) as soluong from TINMOI";
            rpt_tintuc.DataSource = ketnoi.getData(sql_tintuc);
            rpt_tintuc.DataBind();

            string sql_kinhnghiem = "select COUNT(IDKinhnghiem) as soluong from KINHNGHIEM";
            rpt_kinhnghiem.DataSource = ketnoi.getData(sql_kinhnghiem);
            rpt_kinhnghiem.DataBind();

            string sql_tuvung = "select COUNT(IDTuvung) as soluong from TUVUNG";
            rpt_tuvung.DataSource = ketnoi.getData(sql_tuvung);
            rpt_tuvung.DataBind();

            string sql_nguphap = "select COUNT(IDNguphap) as soluong from NGUPHAP";
            rpt_nguphap.DataSource = ketnoi.getData(sql_nguphap);
            rpt_nguphap.DataBind();
            for(int i=0; i<Repeater1.Items.Count; i++)
        {
        Label lb = (Label)Repeater1.Items[i].FindControl("txt_soluong");
        string sql = "select  COUNT(a.IDNoidungchitiet) as soluong2, c.IDNoidung from CHITIETNOIDUNG a, NOIDUNG c where a.IDNoidung=c.IDNoidung group by c.IDNoidung";
        DataTable tb_sql = ketnoi.getData(sql);

        lb.Text = tb_sql.Rows[i]["soluong2"].ToString() ;
        }
        }
    }
    protected void btn_themcauhoi_Click(object sender, EventArgs e)
    {

    }
    protected void Repeater1_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        
    }
}