using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class dethi0_300_chitiet : System.Web.UI.Page
{
    ketnoi ketnoi = new ketnoi();
    public int idnghe = 1;
    public int idnghecauhoi = 11;
    public int idnghehoithoai = 41;
    public int idnghedoanvan = 71;

    public int iddoc = 101;
    public int iddocdientu = 141;
    public int iddocdoanvan = 153;

    public int diemnghehinhanh = 0;
    public int diemnghecauhoi = 0;
    public int diemnghehoithoai = 0;
    public int diemnghedoanvan = 0;


    public int diemdoccauhoi = 0;
    public int diemdocdientu = 0;
    public int diemndocdoanvan = 0;
    public int socaudungdoc = 0;
    public int socaudungnghe = 0;
    public int Tongdiem = 0;

    public double stt;
    public double sodiem;
    public double sodiemnghe;
    public double sodiemdoc;

    public double tongdiemdoc;
    public double tongdiemnghe;
    public double tongdiem;
    public string filenghe;

    public int Tongthoigian;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            string id = Request.QueryString["dethi"];
            try
            {
                sodiemdoc = Double.Parse(Session["diemdoc"].ToString());
                sodiemnghe = Double.Parse(Session["diemnghe"].ToString());
                tongdiem = Double.Parse(Session["diemdoc"] + Session["diemnghe"].ToString());
                sodiem = ((Double.Parse(Session["diemdoc"].ToString()) + Double.Parse(Session["diemnghe"].ToString())) * 0.1) + 1;
                tongdiemdoc = (Double.Parse(Session["diemdoc"].ToString()) * 0.2) + 1;
                tongdiemnghe = (Double.Parse(Session["diemnghe"].ToString()) * 0.2) + 1;
            }
            catch { }
            try
            {

                string sql_filenghe = "select * from FILES where IDFile='Nghe_" + id + "'";
                Repeater1.DataSource = ketnoi.getData(sql_filenghe);
                Repeater1.DataBind();
      

            }
            catch { }

            diemthi.Visible = false;


            string sql_Phutnghe = "select * from DONGHO where IDDongho='02'";
            rpt_donghonghe.DataSource = ketnoi.getData(sql_Phutnghe);
            rpt_donghonghe.DataBind();

            string sql_Phutdoc = "select * from DONGHO where IDDongho='01'";
            rpt_donghodoc.DataSource = ketnoi.getData(sql_Phutdoc);
            rpt_donghodoc.DataBind();

            phandoc.Visible = false;
            phannghe.Visible = false;
            btn_Nopbai.Visible = false;
            string sql_mathoigian = "select IDThoigian from THOIGIAN Order by IDThoigian DESC";
            DataTable tb_mathoigian = ketnoi.getData(sql_mathoigian);
            if (tb_mathoigian.Rows.Count < 1)
                stt = 1;
            else
                stt = Int32.Parse(tb_mathoigian.Rows[0][0].ToString()) + 1;


            string thoigian = "insert into Thoigian(IDThoigian) values('" + stt + "')";
            ketnoi.executeQuery(thoigian);


            //Phần nghe
            string sql_hinhanh = "select A.IDCauhoi,C.IDNoidungchitiet, A.Phancauhoi, RTRIM(B.Tenfile)as Tenfile,A.Noidung from CAUHOI A, FILES B, CHITIETNOIDUNG C where A.IDNoidung='Photographstest' and C.IDNoidungchitiet=A.IDNoidung and A.IDFile=B.IDFile and Made='" + id + "' order by A.IDCauhoi ASC";
            Rpt_nghe_hinhanh.DataSource = ketnoi.getData(sql_hinhanh);
            Rpt_nghe_hinhanh.DataBind();

            for (int i = 0; i < Rpt_nghe_hinhanh.Items.Count; i++)
            {
                Label a = (Label)Rpt_nghe_hinhanh.Items[i].FindControl("A");
                Label b = (Label)Rpt_nghe_hinhanh.Items[i].FindControl("B");
                Label c = (Label)Rpt_nghe_hinhanh.Items[i].FindControl("C");
                Label d = (Label)Rpt_nghe_hinhanh.Items[i].FindControl("D");
                string sql = "select * from DAPAN where IDCauhoi ='1_" + (i + 1) + "'";
                DataTable tb = ketnoi.getData(sql);
                a.Text = tb.Rows[0]["NDDA"].ToString();
                b.Text = tb.Rows[1]["NDDA"].ToString();
                c.Text = tb.Rows[2]["NDDA"].ToString();
                d.Text = tb.Rows[3]["NDDA"].ToString();
            }

            string sql_cauhoi = "select C.IDNoidungchitiet, A.Phancauhoi, RTRIM(B.Tenfile)as Tenfile,A.Noidung from CAUHOI A, FILES B, CHITIETNOIDUNG C where A.IDNoidung='Questiontest' and C.IDNoidungchitiet=A.IDNoidung and A.IDFile=B.IDFile and Made='" + id + "' order by A.IDCauhoi ASC";
            rpt_nghe_cauhoi.DataSource = ketnoi.getData(sql_cauhoi);
            rpt_nghe_cauhoi.DataBind();
            for (int i = 0; i < rpt_nghe_cauhoi.Items.Count; i++)
            {


                Label a = (Label)rpt_nghe_cauhoi.Items[i].FindControl("A");
                Label b = (Label)rpt_nghe_cauhoi.Items[i].FindControl("B");
                Label c = (Label)rpt_nghe_cauhoi.Items[i].FindControl("C");
                string sql = "select * from DAPAN where IDCauhoi ='1_" + (11 + i) + "'";
                DataTable tb = ketnoi.getData(sql);
                a.Text = tb.Rows[0]["NDDA"].ToString();
                b.Text = tb.Rows[1]["NDDA"].ToString();
                c.Text = tb.Rows[2]["NDDA"].ToString();
            }


            string sql_hoithoai = "select C.IDNoidungchitiet, A.Phancauhoi, RTRIM(B.Tenfile)as Tenfile,A.Noidung from CAUHOI A, FILES B, CHITIETNOIDUNG C where A.IDNoidung='Conversationtest' and C.IDNoidungchitiet=A.IDNoidung and A.IDFile=B.IDFile and Made='" + id + "' order by A.IDCauhoi ASC";
            rpt_nghehoithoai.DataSource = ketnoi.getData(sql_hoithoai);
            rpt_nghehoithoai.DataBind();
            for (int i = 0; i < rpt_nghehoithoai.Items.Count; i++)
            {


                Label a = (Label)rpt_nghehoithoai.Items[i].FindControl("A");
                Label b = (Label)rpt_nghehoithoai.Items[i].FindControl("B");
                Label c = (Label)rpt_nghehoithoai.Items[i].FindControl("C");
                Label d = (Label)rpt_nghehoithoai.Items[i].FindControl("D");
                string sql = "select * from DAPAN where IDCauhoi ='1_" + (41 + i) + "'";
                DataTable tb = ketnoi.getData(sql);
                a.Text = tb.Rows[0]["NDDA"].ToString();
                b.Text = tb.Rows[1]["NDDA"].ToString();
                c.Text = tb.Rows[2]["NDDA"].ToString();
            }

            string sql_doanvan = "select C.IDNoidungchitiet, A.Phancauhoi, RTRIM(B.Tenfile)as Tenfile,A.Noidung from CAUHOI A, FILES B, CHITIETNOIDUNG C where A.IDNoidung='Talktest' and C.IDNoidungchitiet=A.IDNoidung and A.IDFile=B.IDFile and Made='" + id + "' order by A.IDCauhoi ASC";
            rpt_nghedoanvan.DataSource = ketnoi.getData(sql_doanvan);
            rpt_nghedoanvan.DataBind();
            for (int i = 0; i < rpt_nghedoanvan.Items.Count; i++)
            {


                Label a = (Label)rpt_nghedoanvan.Items[i].FindControl("A");
                Label b = (Label)rpt_nghedoanvan.Items[i].FindControl("B");
                Label c = (Label)rpt_nghedoanvan.Items[i].FindControl("C");
                Label d = (Label)rpt_nghedoanvan.Items[i].FindControl("D");
                string sql = "select * from DAPAN where IDCauhoi ='1_" + (71 + i) + "'";
                DataTable tb = ketnoi.getData(sql);
                a.Text = tb.Rows[0]["NDDA"].ToString();
                b.Text = tb.Rows[1]["NDDA"].ToString();
                c.Text = tb.Rows[2]["NDDA"].ToString();
            }
            //Phần đọc

            string sql_doc = "select * from CAUHOI where IDNoidung='Sentencestest' and Made='" + id + "'";
            rpt_phandoc.DataSource = ketnoi.getData(sql_doc);
            rpt_phandoc.DataBind();
            for (int i = 0; i < rpt_phandoc.Items.Count; i++)
            {
                Label a = (Label)rpt_phandoc.Items[i].FindControl("A");
                Label b = (Label)rpt_phandoc.Items[i].FindControl("B");
                Label c = (Label)rpt_phandoc.Items[i].FindControl("C");
                Label d = (Label)rpt_phandoc.Items[i].FindControl("D");
                string sql = "select * from DAPAN where IDCauhoi ='1_" + (101 + i) + "'";
                DataTable tb = ketnoi.getData(sql);
                a.Text = tb.Rows[0]["NDDA"].ToString();
                b.Text = tb.Rows[1]["NDDA"].ToString();
                c.Text = tb.Rows[2]["NDDA"].ToString();
                d.Text = tb.Rows[3]["NDDA"].ToString();
            }
            string sql_docdientu = "select * from CAUHOI where IDNoidung='TextCompletiontest' and Made='" + id + "'";
            rpt_docdientu.DataSource = ketnoi.getData(sql_docdientu);
            rpt_docdientu.DataBind();
            for (int i = 0; i < rpt_docdientu.Items.Count; i++)
            {
                Label a = (Label)rpt_docdientu.Items[i].FindControl("A");
                Label b = (Label)rpt_docdientu.Items[i].FindControl("B");
                Label c = (Label)rpt_docdientu.Items[i].FindControl("C");
                Label d = (Label)rpt_docdientu.Items[i].FindControl("D");
                try
                {
                    string sql = "select * from DAPAN where IDCauhoi ='1_14" + (i + 1) + "'";
                    DataTable tb = ketnoi.getData(sql);
                    a.Text = tb.Rows[0]["NDDA"].ToString();
                    b.Text = tb.Rows[1]["NDDA"].ToString();
                    c.Text = tb.Rows[2]["NDDA"].ToString();
                    d.Text = tb.Rows[3]["NDDA"].ToString();
                }
                catch { }
            }

            string sql_docdoanvan = "select * from CAUHOI where IDNoidung='SinglePassagetest' and Made='" + id + "'";
            rpt_docdoanvan.DataSource = ketnoi.getData(sql_docdoanvan);
            rpt_docdoanvan.DataBind();
            for (int i = 0; i < rpt_docdoanvan.Items.Count; i++)
            {
                Label a = (Label)rpt_docdoanvan.Items[i].FindControl("A");
                Label b = (Label)rpt_docdoanvan.Items[i].FindControl("B");
                Label c = (Label)rpt_docdoanvan.Items[i].FindControl("C");
                Label d = (Label)rpt_docdoanvan.Items[i].FindControl("D");
                try
                {
                    string sql = "select * from DAPAN where IDCauhoi ='1_" + (153 + i) + "' and Made='" + id + "'";
                    DataTable tb = ketnoi.getData(sql);
                    a.Text = tb.Rows[0]["NDDA"].ToString();
                    b.Text = tb.Rows[1]["NDDA"].ToString();
                    c.Text = tb.Rows[2]["NDDA"].ToString();
                    d.Text = tb.Rows[3]["NDDA"].ToString();
                }
                catch { }
            }
            string sql_docdoanvan1 = "select * from CAUHOI where IDNoidung='DoublePassagetest' and Made='" + id + "'";
            rpt_docdoanvan.DataSource = ketnoi.getData(sql_docdoanvan1);
            rpt_docdoanvan.DataBind();
            for (int i = 0; i < rpt_docdoanvan.Items.Count; i++)
            {
                Label a = (Label)rpt_docdoanvan.Items[i].FindControl("A");
                Label b = (Label)rpt_docdoanvan.Items[i].FindControl("B");
                Label c = (Label)rpt_docdoanvan.Items[i].FindControl("C");
                Label d = (Label)rpt_docdoanvan.Items[i].FindControl("D");
                try
                {
                    string sql = "select * from DAPAN where IDCauhoi ='1_" + (153 + i) + "' and Made='" + id + "'";
                    DataTable tb = ketnoi.getData(sql);
                    a.Text = tb.Rows[0]["NDDA"].ToString();
                    b.Text = tb.Rows[1]["NDDA"].ToString();
                    c.Text = tb.Rows[2]["NDDA"].ToString();
                    d.Text = tb.Rows[3]["NDDA"].ToString();
                }
                catch { }
            }

        }
    }

    protected void bnt_read_Click(object sender, EventArgs e)
    {

        phandoc.Visible = true;
        phannghe.Visible = false;
        if (btn_read.BackColor == Color.Silver)
        {
            phannghe.Visible = false;
            phandoc.Visible = false;
            bnt_listen.BackColor = Color.Silver;
            Response.Write("<script>alert('Hết giờ làm bài')</script>");
            Button1_Click(btn_Nopbai, EventArgs.Empty);
            btn_Nopbai.Visible = false;
        }
        else
        {
            if (bnt_listen.BackColor == Color.Red)
                bnt_listen.BackColor = Color.Silver;


            btn_Nopbai.Visible = true;
            this.btn_read.BackColor = Color.Red;

            string sql_mathoigian = "select IDThoigian from THOIGIAN Order by IDThoigian DESC";
            DataTable tb_mathoigian = ketnoi.getData(sql_mathoigian);

            string sql_update = "update THOIGIAN set batdaudoc=GETDATE(), ketthucnghe=GETDATE() where IDThoigian='" + tb_mathoigian.Rows[0][0].ToString() + "'";
            ketnoi.executeQuery(sql_update);

        }


    }
    protected void bnt_listen_Click(object sender, EventArgs e)
    {

        phandoc.Visible = false;
        phannghe.Visible = true;
        if (bnt_listen.BackColor == Color.Silver)
        {
            phannghe.Visible = false;
            phandoc.Visible = false;
            btn_read.BackColor = Color.Silver;
            Response.Write("<script>alert('Hết giờ làm bài')</script>");
            Button1_Click(btn_Nopbai, EventArgs.Empty);
            btn_Nopbai.Visible = false;
        }
        else
        {
            if (btn_read.BackColor == Color.Red)

                btn_read.BackColor = Color.Silver;

            btn_Nopbai.Visible = true;
            this.bnt_listen.BackColor = Color.Red;

            string sql_mathoigian = "select IDThoigian from THOIGIAN Order by IDThoigian DESC";
            DataTable tb_mathoigian = ketnoi.getData(sql_mathoigian);
            string sql_update = "update THOIGIAN set batdaunghe=GETDATE(), ketthucdoc=GETDATE()  where IDThoigian='" + tb_mathoigian.Rows[0][0].ToString() + "'";
            ketnoi.executeQuery(sql_update);

        }
    }


    protected void Button1_Click(object sender, EventArgs e)
    {
        string id = Request.QueryString["dethi"];
        string sql_mathoigian = "select IDThoigian from THOIGIAN Order by IDThoigian DESC";
        DataTable tb_mathoigian = ketnoi.getData(sql_mathoigian);


        if (btn_read.Visible == true)
        {

            string sql_update = "update THOIGIAN set ketthucdoc=GETDATE(), Tongthoigiannghe=DATEDIFF(MI,batdaunghe,ketthucnghe), Tongthoigiandoc=DATEDIFF(MI, batdaudoc, ketthucdoc) where IDThoigian='" + tb_mathoigian.Rows[0][0].ToString() + "'";
            ketnoi.executeQuery(sql_update);
        }
        else
        {
            string sql_update = "update THOIGIAN set ketthucnghe=GETDATE(),  Tongthoigiannghe=DATEDIFF(MI,batdaunghe,ketthucnghe), Tongthoigiandoc=DATEDIFF(MI, batdaudoc, ketthucdoc) where IDThoigian='" + tb_mathoigian.Rows[0][0].ToString() + "'";
            ketnoi.executeQuery(sql_update);
        }

        // Điểm phần nghe
        for (int i = 0; i < Rpt_nghe_hinhanh.Items.Count; i++)
        {
            RadioButton A = (RadioButton)Rpt_nghe_hinhanh.Items[i].FindControl("RadioButton4");
            RadioButton B = (RadioButton)Rpt_nghe_hinhanh.Items[i].FindControl("RadioButton5");
            RadioButton C = (RadioButton)Rpt_nghe_hinhanh.Items[i].FindControl("RadioButton6");
            RadioButton D = (RadioButton)Rpt_nghe_hinhanh.Items[i].FindControl("RadioButton1");
            string sql = "select b.NDDA, b.DA from CAUHOI a, DAPAN b where a.IDCauhoi=b.IDCauhoi and b.IDCauhoi='1_" + (i + 1) + "' and Made='" + id + "'";
            DataTable tb = ketnoi.getData(sql);

            if (tb.Rows[0]["DA"].ToString().Trim() == "True" && A.Checked == true)
            {

                socaudungnghe++;
            }
            else if (tb.Rows[1]["DA"].ToString().Trim() == "True" && B.Checked == true)
            {

                socaudungnghe++;
            }
            else if (tb.Rows[2]["DA"].ToString().Trim() == "True" && C.Checked == true)
            {

                socaudungnghe++;
            }
            else if (tb.Rows[3]["DA"].ToString().Trim() == "True" && D.Checked == true)
            {

                socaudungnghe++;
            }

        }
        for (int i = 0; i < rpt_nghe_cauhoi.Items.Count; i++)
        {
            RadioButton A = (RadioButton)rpt_nghe_cauhoi.Items[i].FindControl("RadioButton4");
            RadioButton B = (RadioButton)rpt_nghe_cauhoi.Items[i].FindControl("RadioButton5");
            RadioButton C = (RadioButton)rpt_nghe_cauhoi.Items[i].FindControl("RadioButton6");

            string sql = "select b.NDDA, b.DA from CAUHOI a, DAPAN b where a.IDCauhoi=b.IDCauhoi and b.IDCauhoi='1_" + (11 + 1) + "' and Made='" + id + "'";
            DataTable tb = ketnoi.getData(sql);

            if (tb.Rows[0]["DA"].ToString().Trim() == "True" && A.Checked == true)
            {

                socaudungnghe++;
            }
            else if (tb.Rows[1]["DA"].ToString().Trim() == "True" && B.Checked == true)
            {

                socaudungnghe++;
            }
            else if (tb.Rows[2]["DA"].ToString().Trim() == "True" && C.Checked == true)
            {

                socaudungnghe++;
            }


        }
        for (int i = 0; i < rpt_nghehoithoai.Items.Count; i++)
        {
            RadioButton A = (RadioButton)rpt_nghehoithoai.Items[i].FindControl("RadioButton4");
            RadioButton B = (RadioButton)rpt_nghehoithoai.Items[i].FindControl("RadioButton5");
            RadioButton C = (RadioButton)rpt_nghehoithoai.Items[i].FindControl("RadioButton6");
            RadioButton D = (RadioButton)rpt_nghehoithoai.Items[i].FindControl("RadioButton1");
            string sql = "select b.NDDA, b.DA from CAUHOI a, DAPAN b where a.IDCauhoi=b.IDCauhoi and b.IDCauhoi='1_" + (41 + 1) + "' and Made='" + id + "'";
            DataTable tb = ketnoi.getData(sql);

            if (tb.Rows[0]["DA"].ToString().Trim() == "True" && A.Checked == true)
            {

                socaudungnghe++;
            }
            else if (tb.Rows[1]["DA"].ToString().Trim() == "True" && B.Checked == true)
            {

                socaudungnghe++;
            }
            else if (tb.Rows[2]["DA"].ToString().Trim() == "True" && C.Checked == true)
            {

                socaudungnghe++;
            }
            else if (tb.Rows[3]["DA"].ToString().Trim() == "True" && D.Checked == true)
            {

                socaudungnghe++;
            }

        }
        for (int i = 0; i < rpt_nghedoanvan.Items.Count; i++)
        {
            RadioButton A = (RadioButton)rpt_nghedoanvan.Items[i].FindControl("RadioButton4");
            RadioButton B = (RadioButton)rpt_nghedoanvan.Items[i].FindControl("RadioButton5");
            RadioButton C = (RadioButton)rpt_nghedoanvan.Items[i].FindControl("RadioButton6");
            RadioButton D = (RadioButton)rpt_nghedoanvan.Items[i].FindControl("RadioButton1");
            string sql = "select b.NDDA, b.DA from CAUHOI a, DAPAN b where a.IDCauhoi=b.IDCauhoi and b.IDCauhoi='1_" + (71 + 1) + "'and Made='" + id + "'";
            DataTable tb = ketnoi.getData(sql);

            if (tb.Rows[0]["DA"].ToString().Trim() == "True" && A.Checked == true)
            {

                socaudungnghe++;
            }
            else if (tb.Rows[1]["DA"].ToString().Trim() == "True" && B.Checked == true)
            {

                socaudungnghe++;
            }
            else if (tb.Rows[2]["DA"].ToString().Trim() == "True" && C.Checked == true)
            {

                socaudungnghe++;
            }
            else if (tb.Rows[3]["DA"].ToString().Trim() == "True" && D.Checked == true)
            {

                socaudungnghe++;
            }
        }

        // Điểm phần đọc
        for (int i = 0; i < rpt_phandoc.Items.Count; i++)
        {
            RadioButton A = (RadioButton)rpt_phandoc.Items[i].FindControl("RadioButton4");
            RadioButton B = (RadioButton)rpt_phandoc.Items[i].FindControl("RadioButton5");
            RadioButton C = (RadioButton)rpt_phandoc.Items[i].FindControl("RadioButton6");
            RadioButton D = (RadioButton)rpt_phandoc.Items[i].FindControl("RadioButton1");
            string sql = "select b.NDDA, b.DA from CAUHOI a, DAPAN b where a.IDCauhoi=b.IDCauhoi and b.IDCauhoi='1_" + (101 + i) + "'and Made='" + id + "'";
            DataTable tb = ketnoi.getData(sql);

            if (tb.Rows[0]["DA"].ToString().Trim() == "True" && A.Checked == true)
            {

                socaudungdoc++;
            }
            else if (tb.Rows[1]["DA"].ToString().Trim() == "True" && B.Checked == true)
            {

                socaudungdoc++;
            }
            else if (tb.Rows[2]["DA"].ToString().Trim() == "True" && C.Checked == true)
            {

                socaudungdoc++;
            }
            else if (tb.Rows[3]["DA"].ToString().Trim() == "True" && D.Checked == true)
            {

                socaudungdoc++;
            }

        }

        for (int i = 0; i < rpt_docdientu.Items.Count; i++)
        {
            RadioButton A = (RadioButton)rpt_docdientu.Items[i].FindControl("RadioButton4");
            RadioButton B = (RadioButton)rpt_docdientu.Items[i].FindControl("RadioButton5");
            RadioButton C = (RadioButton)rpt_docdientu.Items[i].FindControl("RadioButton6");
            RadioButton D = (RadioButton)rpt_docdientu.Items[i].FindControl("RadioButton1");
            string sql = "select b.NDDA, b.DA from CAUHOI a, DAPAN b where a.IDCauhoi=b.IDCauhoi and b.IDCauhoi='1_" + (141 + i) + "'and Made='" + id + "'";
            DataTable tb = ketnoi.getData(sql);

            if (tb.Rows[0]["DA"].ToString().Trim() == "True" && A.Checked == true)
            {

                socaudungdoc++;
            }
            else if (tb.Rows[1]["DA"].ToString().Trim() == "True" && B.Checked == true)
            {

                socaudungdoc++;
            }
            else if (tb.Rows[2]["DA"].ToString().Trim() == "True" && C.Checked == true)
            {

                socaudungdoc++;
            }
            else if (tb.Rows[3]["DA"].ToString().Trim() == "True" && D.Checked == true)
            {

                socaudungdoc++;
            }


        }
        for (int i = 0; i < rpt_docdoanvan.Items.Count; i++)
        {
            RadioButton A = (RadioButton)rpt_docdoanvan.Items[i].FindControl("RadioButton4");
            RadioButton B = (RadioButton)rpt_docdoanvan.Items[i].FindControl("RadioButton5");
            RadioButton C = (RadioButton)rpt_docdoanvan.Items[i].FindControl("RadioButton6");
            RadioButton D = (RadioButton)rpt_docdoanvan.Items[i].FindControl("RadioButton1");
            string sql = "select b.NDDA, b.DA from CAUHOI a, DAPAN b where a.IDCauhoi=b.IDCauhoi and b.IDCauhoi='1_" + (153 + i) + "'and Made='" + id + "'";
            DataTable tb = ketnoi.getData(sql);

            if (tb.Rows[0]["DA"].ToString().Trim() == "True" && A.Checked == true)
            {

                socaudungdoc++;
            }
            else if (tb.Rows[1]["DA"].ToString().Trim() == "True" && B.Checked == true)
            {

                socaudungdoc++;
            }
            else if (tb.Rows[2]["DA"].ToString().Trim() == "True" && C.Checked == true)
            {

                socaudungdoc++;
            }
            else if (tb.Rows[3]["DA"].ToString().Trim() == "True" && D.Checked == true)
            {

                socaudungdoc++;
            }


        }

        string diemdoc = "select Sodiem from DIEMDOC where IDCaudung=60";
        DataTable tb_diemdoc = ketnoi.getData(diemdoc);

        string diemnghe = "select Sodiem from DIEMNGHE where IDCaudung=36";
        DataTable tb_diemnghe = ketnoi.getData(diemnghe);
        string tongthoigian = "select Tongthoigian from THOIGIAN where IDThoigian='" + tb_mathoigian.Rows[0][0].ToString() + "'";
        DataTable tb_tongthoigian = ketnoi.getData(tongthoigian);
        if (tb_tongthoigian.Rows[0]["Tongthoigian"].ToString() == "")
            Tongthoigian = 0;
        else
            Tongthoigian = Int32.Parse(tb_tongthoigian.Rows[0]["Tongthoigian"].ToString());
        Response.Write("<script> alert('Bạn đã đúng: + Phần nghe: " + socaudungnghe + " - " + tb_diemnghe.Rows[0][0] + " Phần đọc: " + socaudungdoc + " - " + tb_diemdoc.Rows[0][0] + " - Tổng điểm của bạn là: " + (Int32.Parse(tb_diemdoc.Rows[0][0].ToString()) + Int32.Parse(tb_diemnghe.Rows[0][0].ToString())) + "  điểm - Thời gian làm bài: " + Tongthoigian + " Phút') </script>");
        phandoc.Visible = false;
        phannghe.Visible = false;
        btn_read.Visible = false;
        bnt_listen.Visible = false;
        btn_Nopbai.Visible = false;
        diemthi.Visible = true;
        kiemtra.Visible = false;

        sodiemdoc = Int32.Parse(tb_diemdoc.Rows[0][0].ToString());
        sodiemnghe = Int32.Parse(tb_diemnghe.Rows[0][0].ToString());
        tongdiem = sodiemdoc + sodiemnghe;
        sodiem = ((sodiemdoc + sodiemnghe) * 0.1) + 1;
        tongdiemdoc = (Int32.Parse(tb_diemdoc.Rows[0][0].ToString()) * 0.2) + 1;
        tongdiemnghe = (Int32.Parse(tb_diemnghe.Rows[0][0].ToString()) * 0.2) + 1;

        Session["diemnghe"] = Int32.Parse(tb_diemnghe.Rows[0][0].ToString());
        Session["diemdoc"] = Int32.Parse(tb_diemdoc.Rows[0][0].ToString());
        Session["tongdiem"] = sodiemdoc + sodiemnghe;
    }

    protected void rpt_nghe_cauhoi_ItemDataBound(object sender, RepeaterItemEventArgs e)
    {

    }

    protected void Button1_Click1(object sender, EventArgs e)
    {
        string made = Request.QueryString["dethi"].ToString();
        int id;
        string IDDiemthi = "select Max(IDDiemthi) as Id from BANGDIEM";
        DataTable Tb_diemthi = ketnoi.getData(IDDiemthi);
        if (Tb_diemthi.Rows.Count == 0)
            id = 1;
        else
            id = Int32.Parse(Tb_diemthi.Rows[0][0].ToString()) + 1;
        if (Session["tendangnhap"] == null)
        {
            Response.Write("<script> alert('Vui lòng đăng nhập để được lưu điểm!'); </script>");
            sodiemdoc = Double.Parse(Session["diemdoc"].ToString());
            sodiemnghe = Double.Parse(Session["diemnghe"].ToString());
            tongdiem = (Double.Parse(Session["diemdoc"].ToString()) + Double.Parse(Session["diemnghe"].ToString()));
            sodiem = ((Double.Parse(Session["diemdoc"].ToString()) + Double.Parse(Session["diemnghe"].ToString())) * 0.1) + 1;
            tongdiemdoc = (Double.Parse(Session["diemdoc"].ToString()) * 0.2) + 1;
            tongdiemnghe = (Double.Parse(Session["diemnghe"].ToString()) * 0.2) + 1;
        }
        else
        {
            string thanhvien = "select IDThanhvien from THANHVIEN where Tendangnhap='" + Session["tendangnhap"].ToString() + "'";
            DataTable tb_thanhvien = ketnoi.getData(thanhvien);
            if (Tongthoigian == null)
                Tongthoigian = 0;
            string insert = "insert into BANGDIEM(IDDiemthi, IDThanhvien,Made, Ngaykiemtra, Diemnghe, Diemdoc, Thoigianlambai) values('" + id + "','" + tb_thanhvien.Rows[0][0].ToString() + "','" + made + "',getdate()," + Session["diemnghe"] + "," + Session["diemdoc"] + "," + Tongthoigian + ")";
            try
            {
                ketnoi.executeQuery(insert);
                Response.Write("<script> alert('Lưu điểm thành công!'); </script>");
                sodiemdoc = Double.Parse(Session["diemdoc"].ToString());
                sodiemnghe = Double.Parse(Session["diemnghe"].ToString());
                tongdiem = Double.Parse(Session["diemdoc"] + Session["diemnghe"].ToString());
                sodiem = ((Double.Parse(Session["diemdoc"].ToString()) + Double.Parse(Session["diemnghe"].ToString())) * 0.1) + 1;
                tongdiemdoc = (Double.Parse(Session["diemdoc"].ToString()) * 0.2) + 1;
                tongdiemnghe = (Double.Parse(Session["diemnghe"].ToString()) * 0.2) + 1;
            }
            catch
            {
                Response.Write("<script> alert('Lưu điểm không thành công!'); </script>");

            }
        }
    }
}