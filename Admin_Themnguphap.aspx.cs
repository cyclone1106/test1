using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_Themnguphap : System.Web.UI.Page
{
    ketnoi ketnoi = new ketnoi();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        double id;
        string sql ="select MAX(IDNguphap) from NGUPHAP";
        DataTable tb_id=ketnoi.getData(sql);
        if (tb_id.Rows[0][0].ToString() == "")
            id=1;
        else
            id = Int32.Parse(tb_id.Rows[0][0].ToString()) + 1;
        string insert="insert into NGUPHAP values('"+id+"',N'"+txt_noidung.Text+"','','','"+dr_tennguphap.Text+"','Grammar')";
        try
        {
            ketnoi.executeQuery(insert);
            Response.Write("<script>alert('Thêm mới thành công'); window.location.href='Admin-Nguphap.aspx' </script>");
        }
         catch {
             Response.Write("<script>alert('Thêm mới không thành công'); </script>");
        }
    }
    protected void FileBrowser1_Load(object sender, EventArgs e)
    {

        FileBrowser1 = new CKFinder.FileBrowser();
        FileBrowser1.BasePath = "/ckfinder/";
        FileBrowser1.SetupCKEditor(txt_noidung);

    }
}