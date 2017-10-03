using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Tinmoichitiet : System.Web.UI.Page
{
    ketnoi ketnoi = new ketnoi();
    protected void Page_Load(object sender, EventArgs e)
    {
        string id = Request.QueryString["id"];
        string sql_kinhnghiem = "select Convert(nchar(10),Ngaydang,103) as Ngaydang, * from TINMOI where IDTinmoi='"+id+"'";
        rpt_noidung.DataSource = ketnoi.getData(sql_kinhnghiem);
        rpt_noidung.DataBind();
    }
}