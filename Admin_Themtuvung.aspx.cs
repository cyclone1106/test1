using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_Themtuvung : System.Web.UI.Page
{
    ketnoi ketnoi = new ketnoi();
    protected void Page_Load(object sender, EventArgs e)
    {


    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string tuvung = "insert into TUVUNG values('" + txt_tuvung.Text + "','" + txt_tuvung.Text + "','" + txt_phienam.Text + "','" + txt_loaitu.Text + "',N'" + txt_nghia.Text + "',N'" + txt_vidu.Text + "','Vocabulary','" + dr_chude.Text + "')";
        try
        {
            ketnoi.executeQuery(tuvung);
            Response.Write("<script> alert('Thêm từ vựng thành công!'); </script>");
        }
        catch
        {
            Response.Write("<script> alert('Thêm từ vựng không thành công!'); </script>");
        }

    }
}