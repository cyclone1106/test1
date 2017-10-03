using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_Nguphap : System.Web.UI.Page
{
    ketnoi ketnoi = new ketnoi();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            string nguphap = "select * from NGUPHAP";
            Repeater1.DataSource = ketnoi.getData(nguphap);
            Repeater1.DataBind();
        
        }

    }
    protected void btn_themcauhoi_Click(object sender, EventArgs e)
    {
        Response.Redirect("Admin_Themnguphap.aspx");
    }
    protected void Repeater1_ItemCommand(object source, RepeaterCommandEventArgs e)
    {

        if (e.CommandName.ToLower().Equals("sua"))
        {

            string id = Convert.ToString(e.CommandArgument);
            Response.Redirect("Admin_chinhsuaNguphap.aspx?id=" + id.Trim() + "");
        }
        if (e.CommandName.ToLower().Equals("xoa"))
        {

            string id = Convert.ToString(e.CommandArgument);
            string del = "delete from NGUPHAP where IDNguphap='" + id + "'";
            try
            {
                ketnoi.executeQuery(del);
                Response.Write("<script> alert('Xóa thành công!'); window.location.href='Admin_Nguphap.aspx'; </script>");
            }
            catch
            {
                Response.Write("<script> alert('Xóa không thành công!');window.location.href='Admin_Nguphap.aspx'; </script>");
            }
        }

    }
}