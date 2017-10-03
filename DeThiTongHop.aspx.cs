using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DeThiTongHop : System.Web.UI.Page
{
    ketnoi ketnoi = new ketnoi();
    protected void Page_Load(object sender, EventArgs e)
    {
        MasterPage master = this.Master as MasterPage;
        master.BodyId = "baitest";
        string sql = "select * from DETHI where Loaide='Dethi'";
        rpt_dethi.DataSource = ketnoi.getData(sql);
        rpt_dethi.DataBind();
    }

   
 
}