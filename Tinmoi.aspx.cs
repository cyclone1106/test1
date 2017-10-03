using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Tinmoi : System.Web.UI.Page
{
    ketnoi ketnoi = new ketnoi();
    protected void Page_Load(object sender, EventArgs e)
    {
        MasterPage master = this.Master as MasterPage;
        master.BodyId = "Tinmoi";
        try
        {
            string sql_tinmoi = "select  convert(nchar(10),Ngaydang,103) as Ngaydang, * from TINMOI order by convert(nchar(10),Ngaydang,103) DESC";
            rpt_tinmoi.DataSource = ketnoi.getData(sql_tinmoi);
            rpt_tinmoi.DataBind();
        }
        catch { }
    }
}