using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    ketnoi ketnoi = new ketnoi();
    protected void Page_Load(object sender, EventArgs e)
    {
        MasterPage master = this.Master as MasterPage;
        master.BodyId = "Home";

        try
        {
            string sql_gioithieu = "select * from GIAODIEN where IDGiaodien='gioithieu'";
            rpt_Gioithieu.DataSource = ketnoi.getData(sql_gioithieu);
            rpt_Gioithieu.DataBind();

            string sql_tinmoi = "select TOP 3 convert(nchar(10),Ngaydang,103) as Ngaydang,* from TINMOI order by convert(nchar(10),Ngaydang,103) DESC";
            rpt_tinmoi.DataSource = ketnoi.getData(sql_tinmoi);
            rpt_tinmoi.DataBind();

            string sql_kinhnghiem = "select TOP 3 convert(nchar(10),Ngaydang,103) as Ngaydang,* from KINHNGHIEM order by convert(nchar(10),Ngaydang,103) DESC";
            rpt_kinhnghiem.DataSource = ketnoi.getData(sql_kinhnghiem);
            rpt_kinhnghiem.DataBind();
        }
        catch { }
    }
}