using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Part4_Talk_chitiet : System.Web.UI.Page
{

    ketnoi ketnoi = new ketnoi();
    public int idnghe = 1;
    public string filenghe;
    protected void Page_Load(object sender, EventArgs e)
    {
       
        if (!IsPostBack)
        {
            string id = Request.QueryString["dethi"].ToString();
            string sql_dethi = "select Tende from DETHI where Made='" + id + "'";
            DataTable tb_dethi = ketnoi.getData(sql_dethi);
            txt_dethi.Text = tb_dethi.Rows[0][0].ToString().ToUpper();
            txt_dethi2.Text = tb_dethi.Rows[0][0].ToString().ToUpper();

            string sql_Phutnghe = "select * from DONGHO where IDDongho='03'";
            rpt_dongho.DataSource = ketnoi.getData(sql_Phutnghe);
            rpt_dongho.DataBind();

            string sql_hinhanh = "select A.IDCauhoi,C.IDNoidung, A.Phancauhoi, RTRIM(B.Tenfile)as Tenfile,A.Noidung from CAUHOI A, FILES B, CHITIETNOIDUNG C where A.IDNoidung='Talk' and C.IDNoidungchitiet=A.IDNoidung and A.IDFile=B.IDFile and A.Made='"+id+"' order by A.IDCauhoi ASC";
            Rpt_nghe.DataSource = ketnoi.getData(sql_hinhanh);
            Rpt_nghe.DataBind();

              for (int i = 0; i < Rpt_nghe.Items.Count; i++)
            {
                Label a = (Label)Rpt_nghe.Items[i].FindControl("A");
                Label b = (Label)Rpt_nghe.Items[i].FindControl("B");
                Label c = (Label)Rpt_nghe.Items[i].FindControl("C");
                Label d = (Label)Rpt_nghe.Items[i].FindControl("D");
                try
                {
                    string sql = "select * from DAPAN where IDCauhoi ='1_Talk_" + (i + 1) + "'";
                    DataTable tb = ketnoi.getData(sql);
                    a.Text = tb.Rows[0]["NDDA"].ToString();
                    b.Text = tb.Rows[1]["NDDA"].ToString();
                    c.Text = tb.Rows[2]["NDDA"].ToString();
                    d.Text = tb.Rows[3]["NDDA"].ToString();
                }
                catch { }
            }
            try
            {
                DataTable tb_filenghe = ketnoi.getData(sql_hinhanh);
                filenghe = tb_filenghe.Rows[0]["Tenfile"].ToString();
            }
            catch { }
        }
        }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string id = Request.QueryString["dethi"];

        int socaudung = 0;
        for (int i = 0; i < Rpt_nghe.Items.Count; i++)
        {
            string sql_dapan = "select * from CAUHOI where IDNoidung='Talk'";
            DataTable tb_dapan = ketnoi.getData(sql_dapan);
            RadioButton A = (RadioButton)Rpt_nghe.Items[i].FindControl("RadioButton4");
            RadioButton B = (RadioButton)Rpt_nghe.Items[i].FindControl("RadioButton5");
            RadioButton C = (RadioButton)Rpt_nghe.Items[i].FindControl("RadioButton6");
            RadioButton D = (RadioButton)Rpt_nghe.Items[i].FindControl("RadioButton1");
            string sql = "select b.NDDA, b.DA from CAUHOI a, DAPAN b where a.IDCauhoi=b.IDCauhoi and b.IDCauhoi='" + tb_dapan.Rows[i]["IDCauhoi"].ToString() + "'";
            DataTable tb = ketnoi.getData(sql);

            if (tb.Rows[0]["DA"].ToString().Trim() == "True" && A.Checked == true)
            {
                socaudung++;
            }
            else if (tb.Rows[1]["DA"].ToString().Trim() == "True" && B.Checked == true)
            {

                socaudung++;
            }
            else if (tb.Rows[2]["DA"].ToString().Trim() == "True" && C.Checked == true)
            {

                socaudung++;
            }
            else if (tb.Rows[3]["DA"].ToString().Trim() == "True" && D.Checked == true)
            {

                socaudung++;
            }


        }


        Response.Write("<script> alert('Bạn đã đúng: " + socaudung + "') </script>");
    }
}
