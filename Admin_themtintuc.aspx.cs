using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_themtintuc : System.Web.UI.Page
{
    ketnoi ketnoi = new ketnoi();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btn_capnhat_Click(object sender, EventArgs e)
    {
        int id;
        string sql = "select Max(IDTinmoi) from TINMOI";
        DataTable tb_id = ketnoi.getData(sql);
        try
        {
            id = Int32.Parse(tb_id.Rows[0][0].ToString());
        }
        catch {
            id = 0;
        }
       
        HttpFileCollection fileCollection = Request.Files;
        for (int i = 0; i < fileCollection.Count; i++)
        {
            HttpPostedFile uploadfile = fileCollection[i];
            string fileName = Path.GetFileName(uploadfile.FileName);
            if (uploadfile.ContentLength > 0)
            {

                uploadfile.SaveAs(Server.MapPath("~/images/") + fileName);
                string sql_tinmoi = "insert into TINMOI values('0" +(id+1) + "',N'" + txt_tieude.Text+ "','" +txt_ngaydang.Text + "',N'"+txt_rutgon.Text+"',N'"+txt_doanvan.Text+"','"+fileName+"')";
                ketnoi.executeQuery(sql_tinmoi);
                Response.Write("<script> alert('Thêm mới thành công!'); window.location.href='Admin_tintuc.aspx';</script>");
            }
            else{
            Response.Write("<script> alert('Thêm mới không thành công!'); window.location.href='Admin_tintuc.aspx';</script>");
            }
        }
    }
    protected void FileBrowser1_Load(object sender, EventArgs e)
    {

        FileBrowser1 = new CKFinder.FileBrowser();
        FileBrowser1.BasePath = "/ckfinder/";
        FileBrowser1.SetupCKEditor(txt_doanvan);

    }
}