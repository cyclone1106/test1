using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_chinhsuatintuc : System.Web.UI.Page
{
    ketnoi ketnoi = new ketnoi();
    public string idhinhanh;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            FileUpload1.Visible = false;
            try
            {
                string id = Request.QueryString["id"].ToString();
                string kinhnghiem = "select  * from TINMOI where IDTinmoi='" + id + "'";
                DataTable tb_kinhnghiem = ketnoi.getData(kinhnghiem);

                txt_tieude.Text = tb_kinhnghiem.Rows[0]["Tieude"].ToString();

                DateTime ngaysinh = DateTime.Parse(tb_kinhnghiem.Rows[0]["Ngaydang"].ToString());
                txt_ngaydang.Text = ngaysinh.ToString("yyyy-MM-dd");
                txt_rutgon.Text = tb_kinhnghiem.Rows[0]["Noidungrutgon"].ToString();
                txt_doanvan.Text = tb_kinhnghiem.Rows[0]["Noidung"].ToString();
                idhinhanh = tb_kinhnghiem.Rows[0]["Hinhanh"].ToString();
            }
            catch { }
        }


    }
    protected void btn_capnhat_Click(object sender, EventArgs e)
    {
        string id = Request.QueryString["id"].ToString();
        if (FileUpload1.Visible == true)
        {
            HttpFileCollection fileCollection = Request.Files;
            for (int i = 0; i < fileCollection.Count; i++)
            {
                HttpPostedFile uploadfile = fileCollection[i];
                string fileName = Path.GetFileName(uploadfile.FileName);
                if (uploadfile.ContentLength > 0)
                {

                    uploadfile.SaveAs(Server.MapPath("~/images/") + fileName);
                    string sql_tinmoi = "update TINMOI set Tieude=N'" + txt_tieude.Text + "',Ngaydang='" + txt_ngaydang.Text + "',Noidungrutgon=N'" + txt_rutgon.Text + "',Noidung=N'" + txt_doanvan.Text + "',Hinhanh='" + fileName + "' where IDTinmoi='" + id + "'";
                    ketnoi.executeQuery(sql_tinmoi);
                    Response.Write("<script> alert('Cập nhật thành công!'); window.location.href='Admin_tintuc.aspx';</script>");
                }
                else
                {
                    Response.Write("<script> alert('Cập nhật không thành công!');</script>");
                }
            }
        }
        else
        {
            string sql_tinmoi = "update TINMOI set Tieude=N'" + txt_tieude.Text + "',Ngaydang='" + txt_ngaydang.Text + "',Noidungrutgon=N'" + txt_rutgon.Text + "',Noidung=N'" + txt_doanvan.Text + "' where IDTinmoi='" + id + "'";
            try
            {
                ketnoi.executeQuery(sql_tinmoi);
                Response.Write("<script> alert('Cập nhật thành công!'); window.location.href='Admin_tintuc.aspx';</script>");
            }
            catch
            {
                Response.Write("<script> alert('Cập nhật không thành công!'); </script>");
            }
        }
    }
    protected void btn_hinhanh_Click(object sender, EventArgs e)
    {
        string id = Request.QueryString["id"].ToString();
        string kinhnghiem = "select  * from TINMOI where IDTinmoi='" + id + "'";
        DataTable tb_kinhnghiem = ketnoi.getData(kinhnghiem);

        txt_tieude.Text = tb_kinhnghiem.Rows[0]["Tieude"].ToString();

        DateTime ngaysinh = DateTime.Parse(tb_kinhnghiem.Rows[0]["Ngaydang"].ToString());
        txt_ngaydang.Text = ngaysinh.ToString("yyyy-MM-dd");
        txt_rutgon.Text = tb_kinhnghiem.Rows[0]["Noidungrutgon"].ToString();
        txt_doanvan.Text = tb_kinhnghiem.Rows[0]["Noidung"].ToString();
        idhinhanh = tb_kinhnghiem.Rows[0]["Hinhanh"].ToString();
        FileUpload1.Visible = true;
    }
    protected void btn_huy_Click(object sender, EventArgs e)
    {
        Response.Redirect("Admin_tintuc.aspx");
    }
    protected void FileBrowser1_Load(object sender, EventArgs e)
    {

        FileBrowser1 = new CKFinder.FileBrowser();
        FileBrowser1.BasePath = "/ckfinder/";
        FileBrowser1.SetupCKEditor(txt_doanvan);

    }
}