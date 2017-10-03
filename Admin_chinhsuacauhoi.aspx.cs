using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_chinhsuacauhoi : System.Web.UI.Page
{
    ketnoi ketnoi = new ketnoi();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        { 
            
            string id=Request.QueryString["macauhoi"].ToString();
           
            string sql_cauhoi ="select * from CAUHOI a, DAPAN b where  a.IDCauhoi=b.IDCauhoi and a.IDCauhoi ='"+id+"'";
            DataTable tb_cauhoi = ketnoi.getData(sql_cauhoi);
          
            txt_doanvan.Text = tb_cauhoi.Rows[0]["Phancauhoi"].ToString();
            txt_cauhoi.Text = tb_cauhoi.Rows[0]["Noidung"].ToString();
            txt_A.Text = tb_cauhoi.Rows[0]["NDDA"].ToString();
            txt_B.Text = tb_cauhoi.Rows[1]["NDDA"].ToString();
            txt_C.Text = tb_cauhoi.Rows[2]["NDDA"].ToString();
           
            string A, B, C, D;
            A= tb_cauhoi.Rows[0]["DA"].ToString();
            B = tb_cauhoi.Rows[1]["DA"].ToString();
            C= tb_cauhoi.Rows[2]["DA"].ToString();
            if (tb_cauhoi.Rows[0]["IDNoidung"].ToString().Trim() == "Question" || tb_cauhoi.Rows[0]["IDNoidung"].ToString().Trim() == "Questiontest")
            {
                dapanD.Visible = false;
            }
            else
            { 
                txt_D.Text = tb_cauhoi.Rows[3]["NDDA"].ToString();
                D = tb_cauhoi.Rows[3]["DA"].ToString();
                if (D.Trim() == "True")
                rd_TrueD.Checked = true;
            }
            
                rd_FalseD.Checked = true;
            
            if (A.Trim() == "True")
                rd_TrueA.Checked = true;
            else
                rd_FalseA.Checked = true;

            if (B.Trim() == "True")
                rd_TrueB.Checked = true;
            else
                rd_FalseB.Checked = true;

            if (C.Trim() == "True")
                rd_TrueC.Checked = true;
            else
                rd_FalseC.Checked = true;
            
        }
    }

    protected void btn_Huy_Click(object sender, EventArgs e)
    {

    }
    protected void bnt_Capnhat_Click(object sender, EventArgs e)
    {
        string id = Request.QueryString["macauhoi"].ToString();
        string sql_update = "update CAUHOI set Phancauhoi=N'" + txt_doanvan.Text + "', Noidung=N'" + txt_cauhoi.Text + "' where IDCauhoi='" + id + "'";
        string dapanA, dapanB, dapanC, dapanD;
        if (rd_TrueA.Checked)
            dapanA = "True";
        else
            dapanA = "False";
        if (rd_TrueB.Checked)
            dapanB = "True";
        else
            dapanB = "False";

        if (rd_TrueC.Checked)
            dapanC = "True";
        else
            dapanC = "False";

        if (rd_TrueD.Checked)
            dapanD = "True";
        else
            dapanD = "False";
        if (txt_D.Visible == false)
        {
            string A = "update DAPAN set NDDA='" + txt_A.Text + "', DA='" + dapanA + "' where IDDA='" + id + "_1'";
            string B = "update DAPAN set NDDA='" + txt_B.Text + "', DA='" + dapanB + "' where IDDA='" + id + "_2'";
            string C = "update DAPAN set NDDA='" + txt_C.Text + "', DA='" + dapanC + "' where IDDA='" + id + "_3'";
            try
            {
                ketnoi.executeQuery(sql_update);
                ketnoi.executeQuery(A);
                ketnoi.executeQuery(B);
                ketnoi.executeQuery(C);


                Response.Write("<script>alert('Cập nhật thành công!'); window.location.href='Admin_Cauhoi.aspx' </script>");
            }
            catch
            {
                Response.Write("<script>alert('Cập nhật không thành công!') </script>");
            }


        }
        else
        {
            string A = "update DAPAN set NDDA='" + txt_A.Text + "', DA='" + dapanA + "' where IDDA='" + id + "_1'";
            string B = "update DAPAN set NDDA='" + txt_B.Text + "', DA='" + dapanB + "' where IDDA='" + id + "_2'";
            string C = "update DAPAN set NDDA='" + txt_C.Text + "', DA='" + dapanC + "' where IDDA='" + id + "_3'";
            string D = "update DAPAN set NDDA='" + txt_D.Text + "', DA='" + dapanD + "' where IDDA='" + id + "_4'";
            try
            {
                ketnoi.executeQuery(sql_update);
                ketnoi.executeQuery(A);
                ketnoi.executeQuery(B);
                ketnoi.executeQuery(C);
                ketnoi.executeQuery(D);

                Response.Write("<script>alert('Cập nhật thành công!'); window.location.href='Admin_Cauhoi.aspx' </script>");
            }
            catch
            {
                Response.Write("<script>alert('Cập nhật không thành công!') </script>");
            }
        }
    }
    protected void FileBrowser1_Load(object sender, EventArgs e)
    {

        FileBrowser1 = new CKFinder.FileBrowser();
        FileBrowser1.BasePath = "/ckfinder/";
        FileBrowser1.SetupCKEditor(txt_doanvan);

    }
}