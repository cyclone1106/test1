using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Lichsulambai : System.Web.UI.Page
{
    ketnoi ketnoi = new ketnoi();
    protected void Page_Load(object sender, EventArgs e)
    {
        string bangdiem = "select Convert(nchar(10), a.Ngaykiemtra,103) as Ngaykiemtra, * from BANGDIEM a, THANHVIEN b where a.IDThanhvien=b.IDThanhvien and b.Tendangnhap='"+Session["tendangnhap"].ToString()+"'";
        Repeater1.DataSource = ketnoi.getData(bangdiem);
        Repeater1.DataBind();
    }
}