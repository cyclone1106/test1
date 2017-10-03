using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_tintuc : System.Web.UI.Page
{
    ketnoi ketnoi = new ketnoi();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            string sql_cauhoi = "select convert(nchar(10),Ngaydang,103) as Ngaydang,* from TINMOI";
            Repeater1.DataSource = ketnoi.getData(sql_cauhoi);
            Repeater1.DataBind();
        }
        }    

    protected void btn_themcauhoi_Click(object sender, EventArgs e)
    {
        Response.Redirect("Admin_themtintuc.aspx");
    }
    
    protected void Repeater1_ItemCommand1(object source, RepeaterCommandEventArgs e)
    {

        if (e.CommandName.ToLower().Equals("sua"))
        {

            string id = Convert.ToString(e.CommandArgument);
            Response.Redirect("Admin_chinhsuatintuc.aspx?id=" + id.Trim() + "");
        }
        if (e.CommandName.ToLower().Equals("xoa"))
        {

            string id = Convert.ToString(e.CommandArgument);
            string del = "delete from TINMOI where IDTinmoi='" + id + "'";
            try
            {
                ketnoi.executeQuery(del);
                Response.Write("<script> alert('Xóa thành công!'); window.location.href='Admin_tintuc.aspx'; </script>");
            }
            catch
            {
                Response.Write("<script> alert('Xóa không thành công!');window.location.href='Admin_tintuc.aspx'; </script>");
            }
        }

    }
}