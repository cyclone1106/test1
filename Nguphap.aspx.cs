using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Nguphap : System.Web.UI.Page
{
    ketnoi ketnoi = new ketnoi();
    protected void Page_Load(object sender, EventArgs e)
    {
        MasterPage master = this.Master as MasterPage;
        master.BodyId = "grammar";
        string sql = "select * from CHUDE_NGUPHAP";
        rpt_tuvung.DataSource = ketnoi.getData(sql);
        DataBind();
    }
}