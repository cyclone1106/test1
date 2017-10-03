using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Gioithieu : System.Web.UI.Page
{
    ketnoi ketnoi = new ketnoi();
    protected void Page_Load(object sender, EventArgs e)
    {
        MasterPage master = this.Master as MasterPage;
        master.BodyId = "Toeic";
        string sql = "select * from GIAODIEN where IDGiaodien ='gioithieu'";
        Repeater1.DataSource=ketnoi.getData(sql);
        Repeater1.DataBind();
    }
}