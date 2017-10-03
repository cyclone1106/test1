using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default2 : System.Web.UI.Page
{
    ketnoi ketnoi = new ketnoi();
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {
            string sql = "update CAUHOI set Phancauhoi=N'" + txt_doanvan.Text + "' where IDCauhoi='1_Conver_98'";
            ketnoi.executeQuery(sql);
            Response.Write("<script>alert('thanh cong') </script>");
        }
        catch {

            Response.Write("<script>alert('ko thanh cong') </script>");
        }
    }
}