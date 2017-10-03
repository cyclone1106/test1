using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_Taikhoan : System.Web.UI.Page
{
    ketnoi ketnoi = new ketnoi();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            string sql = " select * from THANHVIEN";
            Repeater1.DataSource = ketnoi.getData(sql);
            Repeater1.DataBind();
        }
    }
    protected void Repeater1_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        if (e.CommandName.ToLower().Equals("sua"))
        {
            
                string id = Convert.ToString(e.CommandArgument);
                Response.Redirect("Admin_chinhsuaTaikhoan.aspx?id=" + id.Trim() + "");
            
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