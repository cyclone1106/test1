using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_chinhsuanguphap : System.Web.UI.Page
{
    ketnoi ketnoi = new ketnoi();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            string id = Request.QueryString["id"].ToString();
            string sql = "select * from NGUPHAP where IDNguphap='" + id + "'";
            DataTable tb_sql = ketnoi.getData(sql);

            txt_noidung.Text = tb_sql.Rows[0]["Noidung"].ToString();
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    { string id = Request.QueryString["id"].ToString();
    string update = "update NGUPHAP set Noidung =N'"+txt_noidung.Text+"' where IDNguphap='" + id.Trim() + "'";
    try
    {
        ketnoi.executeQuery(update);
        Response.Write("<script>alert('Cập nhật thành công'); window.location.href='Admin-Nguphap.aspx' </script>");
    }
    catch
    {
        Response.Write("<script>alert('Cập nhật không thành công'); </script>");
    }
    }
    protected void FileBrowser1_Load(object sender, EventArgs e)
    {

        FileBrowser1 = new CKFinder.FileBrowser();
        FileBrowser1.BasePath = "/ckfinder/";
        FileBrowser1.SetupCKEditor(txt_noidung);

    }
}