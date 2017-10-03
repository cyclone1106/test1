using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Contact : System.Web.UI.Page
{
    ketnoi ketnoi = new ketnoi();
    protected void Page_Load(object sender, EventArgs e)
    {
        MasterPage master = this.Master as MasterPage;
        master.BodyId = "Contact";
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string maxid="select MAX(IDlienhe) from LIENHE";
        DataTable tb_max =ketnoi.getData(maxid);
        int id;
        if(tb_max.Rows[0][0].ToString()=="")
            id=1;
        else
            id=Int32.Parse(tb_max.Rows[0][0].ToString())+1;
        string lienhe = "insert into LIENHE values('" + id + "',N'" + txt_hoten.Text + "','" + txt_email.Text + "',N'" + txt_nghenghiep.Text + "','" + txt_sodienthoai.Text + "',N'" + txt_noidung.Text + "')";
        try
        {
            ketnoi.executeQuery(lienhe);
            Response.Write("<script> alert('Gửi thành công!');</script>");
        }
        catch {
            Response.Write("<script> alert('Gửi không thành công!');</script>");
        }
    }
}