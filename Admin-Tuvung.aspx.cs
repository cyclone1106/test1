using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_Tuvung : System.Web.UI.Page
{
    ketnoi ketnoi = new ketnoi();
    public int stt = 1;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            string sql = "select * from TUVUNG a, CHUDE_TUVUNG b where a.IDChude = b.IDChude";
            rpt_tuvung.DataSource = ketnoi.getData(sql);
            rpt_tuvung.DataBind();
        }

    }


    protected void btn_themcauhoi_Click(object sender, EventArgs e)
    {
        Response.Redirect("Admin_Themtuvung.aspx");
    }
    protected void rpt_tuvung_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        if (e.CommandName.ToLower().Equals("sua"))
        {

            string id = Convert.ToString(e.CommandArgument);
            Response.Redirect("Admin_ChinhsuaTuvung.aspx?id=" + id.Trim() + "");
        }
        if (e.CommandName.ToLower().Equals("xoa"))
        {

            string id = Convert.ToString(e.CommandArgument);
            string del = "delete from TUVUNG where IDTuvung='" + id + "'";
            try
            {
                ketnoi.executeQuery(del);
                Response.Write("<script> alert('Xóa thành công!'); window.location.href='Admin_Tuvung.aspx'; </script>");
            }
            catch
            {
                Response.Write("<script> alert('Xóa không thành công!');window.location.href='Admin_Tuvung.aspx'; </script>");
            }
        }

    }
}