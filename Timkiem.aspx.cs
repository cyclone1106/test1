using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Timkiem : System.Web.UI.Page
{
    ketnoi ketnoi = new ketnoi();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            string id = Request.QueryString["id"].ToString();
            string sql = "select * from TINMOI where Noidung like N'%" + id.Trim() + "%' or Tieude like N'%" +id.Trim()+ "%'";
            rpt_tinmoi.DataSource = ketnoi.getData(sql);
            rpt_tinmoi.DataBind();
        }
        
    }
}