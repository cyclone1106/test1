using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Part6_Incomplete_Sentence : System.Web.UI.Page
{
    ketnoi ketnoi = new ketnoi();
    protected void Page_Load(object sender, EventArgs e)
    {
        MasterPage master = this.Master as MasterPage;
        master.BodyId = "text";

        string sql = "select * from DETHI where Loaide='TextCompletion'";
        rpt_dethi.DataSource = ketnoi.getData(sql);
        rpt_dethi.DataBind();
    }
}