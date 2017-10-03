using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_Cauhoichitiet : System.Web.UI.Page
{
    ketnoi ketnoi = new ketnoi();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            string id = Request.QueryString["macauhoi"].ToString();
            string sql_cauhoi = "select * from CAUHOI a, DAPAN b where a.IDCauhoi =b.IDCauhoi and b.IDCauhoi='" + id + "'";
            Repeater1.DataSource = ketnoi.getData(sql_cauhoi);
            Repeater1.DataBind();
        }
    }
    protected void btn_themcauhoi_Click(object sender, EventArgs e)
    {
        Response.Redirect("Admin_Them_Cauhoi.aspx");

    }
    protected void Repeater1_ItemCommand(object source, RepeaterCommandEventArgs e)
    {

    }
    protected void Repeater1_ItemCommand1(object source, RepeaterCommandEventArgs e)
    {
        if (e.CommandName.ToLower().Equals("sua"))
        {

            string id = Convert.ToString(e.CommandArgument);
            Response.Redirect("Admin_chinhsuacauhoi.aspx?macauhoi=" + id + "");
        }
        if (e.CommandName.ToLower().Equals("xoa"))
        {

            string id = Convert.ToString(e.CommandArgument);
            string del = "delete from CAUHOI where IDCauhoi='" + id + "'";
            try
            {
                ketnoi.executeQuery(del);
                Response.Write("<script> alert('Xóa thành công!'); window.location.href='Admin_Cauhoi.aspx'; </script>");
            }
            catch
            {
                Response.Write("<script> alert('Xóa không thành công!');window.location.href='Admin_Cauhoi.aspx'; </script>");
            }
        }

    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        Response.Redirect("Admin_Cauhoi.aspx");
    }
}