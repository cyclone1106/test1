using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Tuvungchitiet : System.Web.UI.Page
{
    ketnoi ketnoi = new ketnoi();
    public int stt=1;
    protected void Page_Load(object sender, EventArgs e)
    {

        string chude = Request.QueryString["chude"].ToString();

        string sql = "select * from TUVUNG a, CHUDE_TUVUNG b where a.IDChude = b.IDChude and b.Tenchude=N'"+chude+"'";
        rpt_tuvung.DataSource = ketnoi.getData(sql);
        rpt_tuvung.DataBind();

        string sql_chude = "select * from CHUDE_TUVUNG where Tenchude=N'" + chude + "'";
        DataTable tb = ketnoi.getData(sql_chude);

        txt_tuvung.Text = tb.Rows[0]["Tenchude"].ToString().ToUpper();
        txt_tieude.Text = tb.Rows[0]["Tenchude"].ToString().ToUpper();
    }
}