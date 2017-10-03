using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Nguphapchitiet : System.Web.UI.Page
{
    ketnoi ketnoi = new ketnoi();
    protected void Page_Load(object sender, EventArgs e)
    {
        string id = Request.QueryString["chude"].ToString();
        string sql = "select  * from CHUDE_NGUPHAP where IDChude=N'" + id.Trim() + "'";
        DataTable tb = ketnoi.getData(sql);
        txt_tieude.Text = tb.Rows[0]["Tenchude"].ToString().ToUpper();
        txt_tieude2.Text = tb.Rows[0]["Tenchude"].ToString().ToUpper();
        string nguphap = "select * from NGUPHAP where IDChude='" + tb.Rows[0]["IDChude"].ToString() + "'";
        Repeater1.DataSource = ketnoi.getData(nguphap);
        Repeater1.DataBind();
    }
}