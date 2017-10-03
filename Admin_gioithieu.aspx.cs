using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_gioithieu : System.Web.UI.Page
{
    ketnoi ketnoi = new ketnoi();
    protected void Page_Load(object sender, EventArgs e)
    {
        Admin master = this.Master as Admin;
        master.BodyId = "Gioithieu";

        if (!IsPostBack) {
            string sql = "select * from GIAODIEN where IDGiaodien='gioithieu'";
            DataTable dt = ketnoi.getData(sql);
            txt_doanvan.Text = dt.Rows[0]["Noidung"].ToString();
        }
    }
    protected void btn_capnhat_Click(object sender, EventArgs e)
    {
        string sql_capnhat = "update GIAODIEN set Noidungrutgon=N'"+txt_rutgon.Text+"', Noidung =N'" + txt_doanvan.Text + "' where IdGiaodien='gioithieu'";
        try
        {
        ketnoi.executeQuery(sql_capnhat);
        Response.Write("<script> alert('Cập nhật thành công!');</script>");
        }
        catch
        {
            Response.Write("<script> alert('Cập nhật không thành công!');</script>");
        }
    }
    protected void FileBrowser1_Load(object sender, EventArgs e)
    {

        FileBrowser1 = new CKFinder.FileBrowser();
        FileBrowser1.BasePath = "/ckfinder/";
        FileBrowser1.SetupCKEditor(txt_doanvan);

    }
}