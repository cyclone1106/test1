using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_Them_Cauhoi : System.Web.UI.Page
{
    ketnoi ketnoi = new ketnoi();
    public int stt;
    public int stt1;
    public int stt2;
    public int stt3;
    public int stt4;
    public int stt5;

    protected void Page_Load(object sender, EventArgs e)
    {
       
        if (!IsPostBack)
        {
            for (int i = 2; i <= 5; i++)
			{
			 dr_soluong.Items.Add(""+i+"");
			}

            for (int i = 1; i <= 100; i++)
            {
                dr_socauhoi.Items.Add("" + i + "");
            }

        for (int i = 1; i <= 10; i++)
        {
            dr_dethi.Items.Add("" + i + "");
        }
            noidung.Visible = true;
            dethi.Visible = false;
            soluongcauhoi.Visible = false;
            causo.Visible = false;
         
            noidungdoanvan.Visible = false;
            id_causo.Visible = true;
            id_caubatdau.Visible = false;
            capdo.Visible = false;
            cauhoi.Visible = false;
            dapanA.Visible = false;
            dapanB.Visible = false;
            dapanC.Visible = false;
            dapanD.Visible = false;
            cauhoi1.Visible = false;
            dapanA1.Visible = false;
            dapanB1.Visible = false;
            dapanC1.Visible = false;
            dapanD1.Visible = false;
            cauhoi2.Visible = false;
            dapanA2.Visible = false;
            dapanB2.Visible = false;
            dapanC2.Visible = false;
            dapanD2.Visible = false;
            cauhoi3.Visible = false;
            dapanA3.Visible = false;
            dapanB3.Visible = false;
            dapanC3.Visible = false;
            dapanD3.Visible = false;
            cauhoi4.Visible = false;
            dapanA4.Visible = false;
            dapanB4.Visible = false;
            dapanC4.Visible = false;
            dapanD4.Visible = false;
            cauhoi5.Visible = false;
            dapanA5.Visible = false;
            dapanB5.Visible = false;
            dapanC5.Visible = false;
            dapanD5.Visible = false;
            fileAnh.Visible = false;
            fileNghe.Visible = false;
          
        }
        
    }
    protected void FileBrowser1_Load(object sender, EventArgs e)
    {

        FileBrowser1 = new CKFinder.FileBrowser();
        FileBrowser1.BasePath = "/ckfinder/";
        FileBrowser1.SetupCKEditor(txt_doanvan);

    }
    protected void dr_Phan_SelectedIndexChanged(object sender, EventArgs e)
    {

     
        if (dr_Phan.Text.Trim() == "Listening")
        {
            btn_Huy.Visible = true;
            btn_Them.Visible = true;
            dr_noidung.Visible = true;
            dethi.Visible = false;
            soluongcauhoi.Visible = false;
            causo.Visible = false;
            id_causo.Visible = false;
            id_caubatdau.Visible = false;
            noidungdoanvan.Visible = false;
            capdo.Visible = false;
            cauhoi1.Visible = false;
            dapanA1.Visible = false;
            dapanB1.Visible = false;
            dapanC1.Visible = false;
            dapanD1.Visible = false;
            cauhoi2.Visible = false;
            dapanA2.Visible = false;
            dapanB2.Visible = false;
            dapanC2.Visible = false;
            dapanD2.Visible = false;
            cauhoi3.Visible = false;
            dapanA3.Visible = false;
            dapanB3.Visible = false;
            dapanC3.Visible = false;
            dapanD3.Visible = false;
            cauhoi4.Visible = false;
            dapanA4.Visible = false;
            dapanB4.Visible = false;
            dapanC4.Visible = false;
            dapanD4.Visible = false;
            cauhoi5.Visible = false;
            dapanA5.Visible = false;
            dapanB5.Visible = false;
            dapanC5.Visible = false;
            dapanD5.Visible = false;
            fileAnh.Visible = false;
            fileNghe.Visible = false;

           
        }

        else if (dr_Phan.Text.Trim() == "Listeningtest")
        {
            btn_Huy.Visible = true;
            btn_Them.Visible = true;
            dr_noidung.Visible = true;
            dethi.Visible = false;
            capdo.Visible = true;
            soluongcauhoi.Visible = false;
            causo.Visible = false;
            id_causo.Visible = false;
            id_caubatdau.Visible = false;
            noidungdoanvan.Visible = false;
            cauhoi1.Visible = false;
            dapanA1.Visible = false;
            dapanB1.Visible = false;
            dapanC1.Visible = false;
            dapanD1.Visible = false;
            cauhoi2.Visible = false;
            dapanA2.Visible = false;
            dapanB2.Visible = false;
            dapanC2.Visible = false;
            dapanD2.Visible = false;
            cauhoi3.Visible = false;
            dapanA3.Visible = false;
            dapanB3.Visible = false;
            dapanC3.Visible = false;
            dapanD3.Visible = false;
            cauhoi4.Visible = false;
            dapanA4.Visible = false;
            dapanB4.Visible = false;
            dapanC4.Visible = false;
            dapanD4.Visible = false;
            cauhoi5.Visible = false;
            dapanA5.Visible = false;
            dapanB5.Visible = false;
            dapanC5.Visible = false;
            dapanD5.Visible = false;
            fileAnh.Visible = false;
            fileNghe.Visible = false;
    

        }
        else if (dr_Phan.Text.Trim() == "Reading")
        {
            btn_Huy.Visible = true;
            btn_Them.Visible = true;
            dr_noidung.Visible = true;
            dethi.Visible = false;
            soluongcauhoi.Visible = false;
            causo.Visible = false;
            id_causo.Visible = false;
            id_caubatdau.Visible = false;
            noidungdoanvan.Visible = false;
            capdo.Visible = false;
            cauhoi1.Visible = false;
            dapanA1.Visible = false;
            dapanB1.Visible = false;
            dapanC1.Visible = false;
            dapanD1.Visible = false;
            cauhoi2.Visible = false;
            dapanA2.Visible = false;
            dapanB2.Visible = false;
            dapanC2.Visible = false;
            dapanD2.Visible = false;
            cauhoi3.Visible = false;
            dapanA3.Visible = false;
            dapanB3.Visible = false;
            dapanC3.Visible = false;
            dapanD3.Visible = false;
            cauhoi4.Visible = false;
            dapanA4.Visible = false;
            dapanB4.Visible = false;
            dapanC4.Visible = false;
            dapanD4.Visible = false;
            cauhoi5.Visible = false;
            dapanA5.Visible = false;
            dapanB5.Visible = false;
            dapanC5.Visible = false;
            dapanD5.Visible = false;
            fileAnh.Visible = false;
            fileNghe.Visible = false;


        }
        else if (dr_Phan.Text.Trim() == "Readingingtest")
        {
            btn_Huy.Visible = true;
            btn_Them.Visible = true;
            dr_noidung.Visible = true;
            capdo.Visible = true;
            dethi.Visible = false;
            soluongcauhoi.Visible = false;
            causo.Visible = false;
            id_causo.Visible = false;
            id_caubatdau.Visible = false;
            noidungdoanvan.Visible = false;
            cauhoi1.Visible = false;
            dapanA1.Visible = false;
            dapanB1.Visible = false;
            dapanC1.Visible = false;
            dapanD1.Visible = false;
            cauhoi2.Visible = false;
            dapanA2.Visible = false;
            dapanB2.Visible = false;
            dapanC2.Visible = false;
            dapanD2.Visible = false;
            cauhoi3.Visible = false;
            dapanA3.Visible = false;
            dapanB3.Visible = false;
            dapanC3.Visible = false;
            dapanD3.Visible = false;
            cauhoi4.Visible = false;
            dapanA4.Visible = false;
            dapanB4.Visible = false;
            dapanC4.Visible = false;
            dapanD4.Visible = false;
            cauhoi5.Visible = false;
            dapanA5.Visible = false;
            dapanB5.Visible = false;
            dapanC5.Visible = false;
            dapanD5.Visible = false;
            fileAnh.Visible = false;
            fileNghe.Visible = false;


        } 
       
    

    }
    protected void dr_noidung_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (dr_noidung.Text.Trim() == "Photographstest")
        {
            for (int i = 1; i <= 10; i++)
            {
                dr_socauhoi.Items.Add("" + i + "");
            }
            for (int i = 11; i <= 200; i++)
            {
                dr_socauhoi.Items.Remove("" + i + "");
            }
            dethi.Visible = true;
            soluongcauhoi.Visible = false;
            causo.Visible = false;
            id_causo.Visible = false;
            id_caubatdau.Visible = false;
            noidungdoanvan.Visible = false;
            cauhoi.Visible = false;
            dapanA.Visible = false;
            dapanB.Visible = false;
            dapanC.Visible = false;
            dapanD.Visible = false;
            cauhoi1.Visible = false;
            dapanA1.Visible = false;
            dapanB1.Visible = false;
            dapanC1.Visible = false;
            dapanD1.Visible = false;
            cauhoi2.Visible = false;
            dapanA2.Visible = false;
            dapanB2.Visible = false;
            dapanC2.Visible = false;
            dapanD2.Visible = false;
            cauhoi3.Visible = false;
            dapanA3.Visible = false;
            dapanB3.Visible = false;
            dapanC3.Visible = false;
            dapanD3.Visible = false;
            cauhoi4.Visible = false;
            dapanA4.Visible = false;
            dapanB4.Visible = false;
            dapanC4.Visible = false;
            dapanD4.Visible = false;
            cauhoi5.Visible = false;
            dapanA5.Visible = false;
            dapanB5.Visible = false;
            dapanC5.Visible = false;
            dapanD5.Visible = false;
            fileAnh.Visible = false;
            fileNghe.Visible = true;


        }
        else if (dr_noidung.Text.Trim() == "Photographs")
        {
          
            dethi.Visible = true;
            soluongcauhoi.Visible = false;
            causo.Visible =false;
            id_causo.Visible = false;
            id_caubatdau.Visible = false;
            noidungdoanvan.Visible = false;
            cauhoi.Visible = false;
            dapanA.Visible = false;
            dapanB.Visible = false;
            dapanC.Visible = false;
            dapanD.Visible = false;
            cauhoi1.Visible = false;
            dapanA1.Visible = false;
            dapanB1.Visible = false;
            dapanC1.Visible = false;
            dapanD1.Visible = false;
            cauhoi2.Visible = false;
            dapanA2.Visible = false;
            dapanB2.Visible = false;
            dapanC2.Visible = false;
            dapanD2.Visible = false;
            cauhoi3.Visible = false;
            dapanA3.Visible = false;
            dapanB3.Visible = false;
            dapanC3.Visible = false;
            dapanD3.Visible = false;
            cauhoi4.Visible = false;
            dapanA4.Visible = false;
            dapanB4.Visible = false;
            dapanC4.Visible = false;
            dapanD4.Visible = false;
            cauhoi5.Visible = false;
            dapanA5.Visible = false;
            dapanB5.Visible = false;
            dapanC5.Visible = false;
            dapanD5.Visible = false;
            fileAnh.Visible = false;
            fileNghe.Visible = true;

        }
        else if (dr_noidung.Text.Trim() == "Questiontest")
        {
            for (int i = 1; i <= 10; i++)
            {
                dr_socauhoi.Items.Remove("" + i + "");
            }
            for (int i = 41; i <= 200; i++)
            {
                dr_socauhoi.Items.Remove("" + i + "");
            }
            for (int i = 11; i <= 40; i++)
            {
                dr_socauhoi.Items.Add("" + i + "");
            }
            dethi.Visible = true;
            soluongcauhoi.Visible = false;
            causo.Visible = false;
            id_causo.Visible = false;
            id_caubatdau.Visible = false;
            noidungdoanvan.Visible = false;

            cauhoi.Visible = false;
            dapanA.Visible = false;
            dapanB.Visible = false;
            dapanC.Visible = false;
            dapanD.Visible = false;
            cauhoi1.Visible = false;
            dapanA1.Visible = false;
            dapanB1.Visible = false;
            dapanC1.Visible = false;
            dapanD1.Visible = false;
            cauhoi2.Visible = false;
            dapanA2.Visible = false;
            dapanB2.Visible = false;
            dapanC2.Visible = false;
            dapanD2.Visible = false;
            cauhoi3.Visible = false;
            dapanA3.Visible = false;
            dapanB3.Visible = false;
            dapanC3.Visible = false;
            dapanD3.Visible = false;
            cauhoi4.Visible = false;
            dapanA4.Visible = false;
            dapanB4.Visible = false;
            dapanC4.Visible = false;
            dapanD4.Visible = false;
            cauhoi5.Visible = false;
            dapanA5.Visible = false;
            dapanB5.Visible = false;
            dapanC5.Visible = false;
            dapanD5.Visible = false;
            fileAnh.Visible = false;
            fileNghe.Visible = true;
        
        }
        else if (dr_noidung.Text.Trim() == "Question")
        {

            dethi.Visible = true;
            soluongcauhoi.Visible = false;
            causo.Visible = false;
            id_causo.Visible = false;
            id_caubatdau.Visible = false;
            noidungdoanvan.Visible = false;
            cauhoi.Visible = false;
            dapanA.Visible = false;
            dapanB.Visible = false;
            dapanC.Visible = false;
            dapanD.Visible=false;
            cauhoi1.Visible = false;
            dapanA1.Visible = false;
            dapanB1.Visible = false;
            dapanC1.Visible = false;
            dapanD1.Visible = false;
            cauhoi2.Visible = false;
            dapanA2.Visible = false;
            dapanB2.Visible = false;
            dapanC2.Visible = false;
            dapanD2.Visible = false;
            cauhoi3.Visible = false;
            dapanA3.Visible = false;
            dapanB3.Visible = false;
            dapanC3.Visible = false;
            dapanD3.Visible = false;
            cauhoi4.Visible = false;
            dapanA4.Visible = false;
            dapanB4.Visible = false;
            dapanC4.Visible = false;
            dapanD4.Visible = false;
            cauhoi5.Visible = false;
            dapanA5.Visible = false;
            dapanB5.Visible = false;
            dapanC5.Visible = false;
            dapanD5.Visible = false;
            fileAnh.Visible = false;
            fileNghe.Visible = true;
         
        }
        else if (dr_noidung.Text.Trim() == "Conversationtest")
        {
            for (int i = 1; i <= 40; i++)
            {
                dr_socauhoi.Items.Remove("" + i + "");
            }
            for (int i = 71; i <= 200; i++)
            {
                dr_socauhoi.Items.Remove("" + i + "");
            }
            for (int i = 41; i <= 70; i++)
            {
                dr_socauhoi.Items.Add("" + i + "");
            }
            dethi.Visible = true;
            soluongcauhoi.Visible = false;
            causo.Visible = false;
            id_causo.Visible = false;
            id_caubatdau.Visible = false;
            noidungdoanvan.Visible = false;
         
            cauhoi.Visible = false;
            dapanA.Visible = false;
            dapanB.Visible = false;
            dapanC.Visible = false;
            dapanD.Visible = false;
            cauhoi1.Visible = false;
            dapanA1.Visible = false;
            dapanB1.Visible = false;
            dapanC1.Visible = false;
            dapanD1.Visible = false;
            cauhoi2.Visible = false;
            dapanA2.Visible = false;
            dapanB2.Visible = false;
            dapanC2.Visible = false;
            dapanD2.Visible = false;
            cauhoi3.Visible = false;
            dapanA3.Visible = false;
            dapanB3.Visible = false;
            dapanC3.Visible = false;
            dapanD3.Visible = false;
            cauhoi4.Visible = false;
            dapanA4.Visible = false;
            dapanB4.Visible = false;
            dapanC4.Visible = false;
            dapanD4.Visible = false;
            cauhoi5.Visible = false;
            dapanA5.Visible = false;
            dapanB5.Visible = false;
            dapanC5.Visible = false;
            dapanD5.Visible = false;
            fileAnh.Visible = false;
            fileNghe.Visible = true;
  
        }
        else if (dr_noidung.Text.Trim() == "Conversation")
        {

            dethi.Visible = true;
            soluongcauhoi.Visible = false;
            causo.Visible = false;
            id_causo.Visible = false;
            id_caubatdau.Visible = false;
            noidungdoanvan.Visible = false;
         
            cauhoi.Visible = false;
            dapanA.Visible = false;
            dapanB.Visible = false;
            dapanC.Visible = false;
            dapanD.Visible = false;
            cauhoi1.Visible = false;
            dapanA1.Visible = false;
            dapanB1.Visible = false;
            dapanC1.Visible = false;
            dapanD1.Visible = false;
            cauhoi2.Visible = false;
            dapanA2.Visible = false;
            dapanB2.Visible = false;
            dapanC2.Visible = false;
            dapanD2.Visible = false;
            cauhoi3.Visible = false;
            dapanA3.Visible = false;
            dapanB3.Visible = false;
            dapanC3.Visible = false;
            dapanD3.Visible = false;
            cauhoi4.Visible = false;
            dapanA4.Visible = false;
            dapanB4.Visible = false;
            dapanC4.Visible = false;
            dapanD4.Visible = false;
            cauhoi5.Visible = false;
            dapanA5.Visible = false;
            dapanB5.Visible = false;
            dapanC5.Visible = false;
            dapanD5.Visible = false;
            fileAnh.Visible = false;
            fileNghe.Visible = true;
      
        }
        else if (dr_noidung.Text.Trim() == "Talktest")
        {
            for (int i = 101; i <= 200; i++)
            {
                dr_socauhoi.Items.Remove("" + i + "");
            }
            for (int i = 71; i <= 100; i++)
            {
                dr_socauhoi.Items.Add("" + i + "");
            }
            for (int i = 1; i <= 70; i++)
            {
                dr_socauhoi.Items.Remove("" + i + "");
            }
            
            dethi.Visible = true;
            soluongcauhoi.Visible = false;
            causo.Visible = false;
            id_causo.Visible = false;
            id_caubatdau.Visible = false;
            noidungdoanvan.Visible = false;
          
            cauhoi.Visible = false;
            dapanA.Visible = false;
            dapanB.Visible = false;
            dapanC.Visible = false;
            dapanD.Visible = false;
            cauhoi1.Visible = false;
            dapanA1.Visible = false;
            dapanB1.Visible = false;
            dapanC1.Visible = false;
            dapanD1.Visible = false;
            cauhoi2.Visible = false;
            dapanA2.Visible = false;
            dapanB2.Visible = false;
            dapanC2.Visible = false;
            dapanD2.Visible = false;
            cauhoi3.Visible = false;
            dapanA3.Visible = false;
            dapanB3.Visible = false;
            dapanC3.Visible = false;
            dapanD3.Visible = false;
            cauhoi4.Visible = false;
            dapanA4.Visible = false;
            dapanB4.Visible = false;
            dapanC4.Visible = false;
            dapanD4.Visible = false;
            cauhoi5.Visible = false;
            dapanA5.Visible = false;
            dapanB5.Visible = false;
            dapanC5.Visible = false;
            dapanD5.Visible = false;
            fileAnh.Visible = false;
            fileNghe.Visible = true;
         
        }
        else if (dr_noidung.Text.Trim() == "Talk")
        {

            dethi.Visible = true;
            soluongcauhoi.Visible = false;
            causo.Visible = false;
            id_causo.Visible = false;
            id_caubatdau.Visible = true;
            noidungdoanvan.Visible = false;

            cauhoi.Visible = false;
            dapanA.Visible = false;
            dapanB.Visible = false;
            dapanC.Visible = false;
            dapanD.Visible = false;
            cauhoi1.Visible = false;
            dapanA1.Visible = false;
            dapanB1.Visible = false;
            dapanC1.Visible = false;
            dapanD1.Visible = false;
            cauhoi2.Visible = false;
            dapanA2.Visible = false;
            dapanB2.Visible = false;
            dapanC2.Visible = false;
            dapanD2.Visible = false;
            cauhoi3.Visible = false;
            dapanA3.Visible = false;
            dapanB3.Visible = false;
            dapanC3.Visible = false;
            dapanD3.Visible = false;
            cauhoi4.Visible = false;
            dapanA4.Visible = false;
            dapanB4.Visible = false;
            dapanC4.Visible = false;
            dapanD4.Visible = false;
            cauhoi5.Visible = false;
            dapanA5.Visible = false;
            dapanB5.Visible = false;
            dapanC5.Visible = false;
            dapanD5.Visible = false;
            fileAnh.Visible = false;
            fileNghe.Visible = true;
       
        }
        else if (dr_noidung.Text.Trim() == "Sentencestest")
        {
          
            for (int i = 1; i <= 100; i++)
            {
                dr_socauhoi.Items.Remove("" + i + "");
            }
            for (int i = 141; i <= 200; i++)
            {
                dr_socauhoi.Items.Remove("" + i + "");
            }
            for (int i = 101; i <= 140; i++)
            {
                dr_socauhoi.Items.Add("" + i + "");
            }
             dethi.Visible = true;
            soluongcauhoi.Visible = false;
            causo.Visible = true;
            id_causo.Visible = true;
            id_caubatdau.Visible = false;
            noidungdoanvan.Visible = false;
            noidungdoanvan.Visible = false;
            cauhoi.Visible = true;
            dapanA.Visible = true;
            dapanB.Visible = true;
            dapanC.Visible = true;
            dapanD.Visible = true;
            cauhoi1.Visible = false;
            dapanA1.Visible = false;
            dapanB1.Visible = false;
            dapanC1.Visible = false;
            dapanD1.Visible = false;
            cauhoi2.Visible = false;
            dapanA2.Visible = false;
            dapanB2.Visible = false;
            dapanC2.Visible = false;
            dapanD2.Visible = false;
            cauhoi3.Visible = false;
            dapanA3.Visible = false;
            dapanB3.Visible = false;
            dapanC3.Visible = false;
            dapanD3.Visible = false;
            cauhoi4.Visible = false;
            dapanA4.Visible = false;
            dapanB4.Visible = false;
            dapanC4.Visible = false;
            dapanD4.Visible = false;
            cauhoi5.Visible = false;
            dapanA5.Visible = false;
            dapanB5.Visible = false;
            dapanC5.Visible = false;
            dapanD5.Visible = false;
            fileAnh.Visible = false;
            fileNghe.Visible = false;
       
        }
        else if (dr_noidung.Text.Trim() == "Sentences")
        {

            dethi.Visible = true;
            soluongcauhoi.Visible = false;
            causo.Visible = true;
            id_causo.Visible = true;
            id_caubatdau.Visible = false;
            noidungdoanvan.Visible = false;
            
            cauhoi.Visible = true;
            dapanA.Visible = true;
            dapanB.Visible = true;
            dapanC.Visible = true;
            dapanD.Visible = true;
            cauhoi1.Visible = false;
            dapanA1.Visible = false;
            dapanB1.Visible = false;
            dapanC1.Visible = false;
            dapanD1.Visible = false;
            cauhoi2.Visible = false;
            dapanA2.Visible = false;
            dapanB2.Visible = false;
            dapanC2.Visible = false;
            dapanD2.Visible = false;
            cauhoi3.Visible = false;
            dapanA3.Visible = false;
            dapanB3.Visible = false;
            dapanC3.Visible = false;
            dapanD3.Visible = false;
            cauhoi4.Visible = false;
            dapanA4.Visible = false;
            dapanB4.Visible = false;
            dapanC4.Visible = false;
            dapanD4.Visible = false;
            cauhoi5.Visible = false;
            dapanA5.Visible = false;
            dapanB5.Visible = false;
            dapanC5.Visible = false;
            dapanD5.Visible = false;
            fileAnh.Visible = false;
            fileNghe.Visible = false;
       
       
        }
        else if (dr_noidung.Text.Trim() == "TextCompletiontest")
        {
            for (int i = 1; i <= 140; i++)
            {
                dr_socauhoi.Items.Remove("" + i + "");
            }
            for (int i = 153; i <= 200; i++)
            {
                dr_socauhoi.Items.Remove("" + i + "");
            }
            for (int i = 141; i <= 152; i++)
            {
                dr_socauhoi.Items.Add("" + i + "");
            }

             dethi.Visible = true;
            soluongcauhoi.Visible = true;
            causo.Visible = false;
            id_causo.Visible = true;
            id_caubatdau.Visible = true;
            noidungdoanvan.Visible = false;
        
            cauhoi.Visible = false;
            dapanA.Visible = false;
            dapanB.Visible = false;
            dapanC.Visible = false;
            dapanD.Visible = false;
            cauhoi1.Visible = false;
            dapanA1.Visible = false;
            dapanB1.Visible = false;
            dapanC1.Visible = false;
            dapanD1.Visible = false;
            cauhoi2.Visible = false;
            dapanA2.Visible = false;
            dapanB2.Visible = false;
            dapanC2.Visible = false;
            dapanD2.Visible = false;
            cauhoi3.Visible = false;
            dapanA3.Visible = false;
            dapanB3.Visible = false;
            dapanC3.Visible = false;
            dapanD3.Visible = false;
            cauhoi4.Visible = false;
            dapanA4.Visible = false;
            dapanB4.Visible = false;
            dapanC4.Visible = false;
            dapanD4.Visible = false;
            cauhoi5.Visible = false;
            dapanA5.Visible = false;
            dapanB5.Visible = false;
            dapanC5.Visible = false;
            dapanD5.Visible = false;
            fileAnh.Visible = false;
            fileNghe.Visible = false;
       

        }
        else if (dr_noidung.Text.Trim() == "TextCompletion")
        {
          
             dethi.Visible = true;
            soluongcauhoi.Visible = true;
            causo.Visible = false;
            id_causo.Visible = true;
            id_caubatdau.Visible = true;
            noidungdoanvan.Visible = false;
           
            cauhoi.Visible = false;
            dapanA.Visible = false;
            dapanB.Visible = false;
            dapanC.Visible = false;
            dapanD.Visible = false;
            cauhoi1.Visible = false;
            dapanA1.Visible = false;
            dapanB1.Visible = false;
            dapanC1.Visible = false;
            dapanD1.Visible = false;
            cauhoi2.Visible = false;
            dapanA2.Visible = false;
            dapanB2.Visible = false;
            dapanC2.Visible = false;
            dapanD2.Visible = false;
            cauhoi3.Visible = false;
            dapanA3.Visible = false;
            dapanB3.Visible = false;
            dapanC3.Visible = false;
            dapanD3.Visible = false;
            cauhoi4.Visible = false;
            dapanA4.Visible = false;
            dapanB4.Visible = false;
            dapanC4.Visible = false;
            dapanD4.Visible = false;
            cauhoi5.Visible = false;
            dapanA5.Visible = false;
            dapanB5.Visible = false;
            dapanC5.Visible = false;
            dapanD5.Visible = false;
            fileAnh.Visible = false;
            fileNghe.Visible = false;
       

        }
        else if (dr_noidung.Text.Trim() == "SinglePassagetest")
        {
          
            for (int i =1; i <= 151; i++)
            {
                dr_socauhoi.Items.Remove("" + i + "");
            }
            for (int i = 153; i <= 170; i++)
            {
                dr_socauhoi.Items.Add("" + i + "");
            }
            dethi.Visible = true;
            soluongcauhoi.Visible = true;
            causo.Visible = false;
            id_causo.Visible = true;
            id_caubatdau.Visible = true;
            noidungdoanvan.Visible = false;
            noidungdoanvan.Visible = false;
            cauhoi.Visible = false;
            dapanA.Visible = false;
            dapanB.Visible = false;
            dapanC.Visible = false;
            dapanD.Visible = false;
            cauhoi1.Visible = false;
            dapanA1.Visible = false;
            dapanB1.Visible = false;
            dapanC1.Visible = false;
            dapanD1.Visible = false;
            cauhoi2.Visible = false;
            dapanA2.Visible = false;
            dapanB2.Visible = false;
            dapanC2.Visible = false;
            dapanD2.Visible = false;
            cauhoi3.Visible = false;
            dapanA3.Visible = false;
            dapanB3.Visible = false;
            dapanC3.Visible = false;
            dapanD3.Visible = false;
            cauhoi4.Visible = false;
            dapanA4.Visible = false;
            dapanB4.Visible = false;
            dapanC4.Visible = false;
            dapanD4.Visible = false;
            cauhoi5.Visible = false;
            dapanA5.Visible = false;
            dapanB5.Visible = false;
            dapanC5.Visible = false;
            dapanD5.Visible = false;
            fileAnh.Visible = false;
            fileNghe.Visible = false;
       
        }
        else if (dr_noidung.Text.Trim() == "SinglePassage")
        {
          

             dethi.Visible = true;
            soluongcauhoi.Visible = true;
            causo.Visible = false;
            id_causo.Visible = true;
            id_caubatdau.Visible = true;
            noidungdoanvan.Visible = false;
            noidungdoanvan.Visible = false;
            cauhoi.Visible = false;
            dapanA.Visible = false;
            dapanB.Visible = false;
            dapanC.Visible = false;
            dapanD.Visible = false;
            cauhoi1.Visible = false;
            dapanA1.Visible = false;
            dapanB1.Visible = false;
            dapanC1.Visible = false;
            dapanD1.Visible = false;
            cauhoi2.Visible = false;
            dapanA2.Visible = false;
            dapanB2.Visible = false;
            dapanC2.Visible = false;
            dapanD2.Visible = false;
            cauhoi3.Visible = false;
            dapanA3.Visible = false;
            dapanB3.Visible = false;
            dapanC3.Visible = false;
            dapanD3.Visible = false;
            cauhoi4.Visible = false;
            dapanA4.Visible = false;
            dapanB4.Visible = false;
            dapanC4.Visible = false;
            dapanD4.Visible = false;
            cauhoi5.Visible = false;
            dapanA5.Visible = false;
            dapanB5.Visible = false;
            dapanC5.Visible = false;
            dapanD5.Visible = false;
            fileAnh.Visible = false;
            fileNghe.Visible = false;
    
        }
        else if (dr_noidung.Text.Trim() == "DoublePassagetest")
        {
          
            for (int i = 1; i <= 173; i++)
            {
                dr_socauhoi.Items.Remove("" + i + "");
            }
            for (int i = 174; i <= 200; i++)
            {
                dr_socauhoi.Items.Add("" + i + "");
            }
            dethi.Visible = true;
            soluongcauhoi.Visible = true;
            causo.Visible = false;
            id_causo.Visible = true;
            id_caubatdau.Visible = true;
            noidungdoanvan.Visible = false;
            noidungdoanvan.Visible = false;
            cauhoi.Visible = false;
            dapanA.Visible = false;
            dapanB.Visible = false;
            dapanC.Visible = false;
            dapanD.Visible = false;
            cauhoi1.Visible = false;
            dapanA1.Visible = false;
            dapanB1.Visible = false;
            dapanC1.Visible = false;
            dapanD1.Visible = false;
            cauhoi2.Visible = false;
            dapanA2.Visible = false;
            dapanB2.Visible = false;
            dapanC2.Visible = false;
            dapanD2.Visible = false;
            cauhoi3.Visible = false;
            dapanA3.Visible = false;
            dapanB3.Visible = false;
            dapanC3.Visible = false;
            dapanD3.Visible = false;
            cauhoi4.Visible = false;
            dapanA4.Visible = false;
            dapanB4.Visible = false;
            dapanC4.Visible = false;
            dapanD4.Visible = false;
            cauhoi5.Visible = false;
            dapanA5.Visible = false;
            dapanB5.Visible = false;
            dapanC5.Visible = false;
            dapanD5.Visible = false;
            fileAnh.Visible = false;
            fileNghe.Visible = false;
       
        }
        else if (dr_noidung.Text.Trim() == "DoublePassage")
        {
          

             dethi.Visible = true;
            soluongcauhoi.Visible = true;
            causo.Visible = false;
            id_causo.Visible = true;
            id_caubatdau.Visible = true;
            noidungdoanvan.Visible = false;
            noidungdoanvan.Visible = false;
            cauhoi.Visible = false;
            dapanA.Visible = false;
            dapanB.Visible = false;
            dapanC.Visible = false;
            dapanD.Visible = false;
            cauhoi1.Visible = false;
            dapanA1.Visible = false;
            dapanB1.Visible = false;
            dapanC1.Visible = false;
            dapanD1.Visible = false;
            cauhoi2.Visible = false;
            dapanA2.Visible = false;
            dapanB2.Visible = false;
            dapanC2.Visible = false;
            dapanD2.Visible = false;
            cauhoi3.Visible = false;
            dapanA3.Visible = false;
            dapanB3.Visible = false;
            dapanC3.Visible = false;
            dapanD3.Visible = false;
            cauhoi4.Visible = false;
            dapanA4.Visible = false;
            dapanB4.Visible = false;
            dapanC4.Visible = false;
            dapanD4.Visible = false;
            cauhoi5.Visible = false;
            dapanA5.Visible = false;
            dapanB5.Visible = false;
            dapanC5.Visible = false;
            dapanD5.Visible = false;
            fileAnh.Visible = false;
            fileNghe.Visible = false;
    
        }
    }
    protected void dr_soluong_SelectedIndexChanged(object sender, EventArgs e)
    {
       
        if (dr_soluong.Text.Trim() == "2")
        {
            stt1 = Int32.Parse(dr_socauhoi.Text);
            stt2 = Int32.Parse(dr_socauhoi.Text) + 1;
            causo.Visible = true;
            id_causo.Visible = false;
            id_caubatdau.Visible = true;
            if (dr_Phan.Text == "Listening" || dr_Phan.Text=="Listeningtest")
                noidungdoanvan.Visible = false;
            else
                noidungdoanvan.Visible = true;
            cauhoi1.Visible = true;
            dapanA1.Visible = true;
            dapanB1.Visible = true;
            dapanC1.Visible = true;
            dapanD1.Visible = true;
            cauhoi2.Visible = true;
            dapanA2.Visible = true;
            dapanB2.Visible = true;
            dapanC2.Visible = true;
            dapanD2.Visible = true;
            cauhoi3.Visible = false;
            dapanA3.Visible = false;
            dapanB3.Visible = false;
            dapanC3.Visible = false;
            dapanD3.Visible = false;
            cauhoi4.Visible = false;
            dapanA4.Visible = false;
            dapanB4.Visible = false;
            dapanC4.Visible = false;
            dapanD4.Visible = false;
            cauhoi5.Visible = false;
            dapanA5.Visible = false;
            dapanB5.Visible = false;
            dapanC5.Visible = false;
            dapanD5.Visible = false;
            fileAnh.Visible = false;
            fileNghe.Visible = false;
        
        }
        else if (dr_soluong.Text.Trim() == "3")
        {
            stt1 = Int32.Parse(dr_socauhoi.Text);
            stt2 = Int32.Parse(dr_socauhoi.Text) + 1;
            stt3 = Int32.Parse(dr_socauhoi.Text) + 2;
            causo.Visible = true;
            id_causo.Visible = false;
            id_caubatdau.Visible = true;
            if (dr_Phan.Text == "Listening" || dr_Phan.Text == "Listeningtest")
                noidungdoanvan.Visible = false;
            else
                noidungdoanvan.Visible = true;
            cauhoi1.Visible = true;
            dapanA1.Visible = true;
            dapanB1.Visible = true;
            dapanC1.Visible = true;
            dapanD1.Visible = true;
            cauhoi2.Visible = true;
            dapanA2.Visible = true;
            dapanB2.Visible = true;
            dapanC2.Visible = true;
            dapanD2.Visible = true;
            cauhoi3.Visible = true;
            dapanA3.Visible = true;
            dapanB3.Visible = true;
            dapanC3.Visible = true;
            dapanD3.Visible = true;
            cauhoi4.Visible = false;
            dapanA4.Visible = false;
            dapanB4.Visible = false;
            dapanC4.Visible = false;
            dapanD4.Visible = false;
            cauhoi5.Visible = false;
            dapanA5.Visible = false;
            dapanB5.Visible = false;
            dapanC5.Visible = false;
            dapanD5.Visible = false;
            fileAnh.Visible = false;
            fileNghe.Visible = false;
          
        }

        else if (dr_soluong.Text.Trim() == "4")
        {
            stt1 = Int32.Parse(dr_socauhoi.Text);
            stt2 = Int32.Parse(dr_socauhoi.Text) + 1;
            stt3 = Int32.Parse(dr_socauhoi.Text) + 2;
            stt4 = Int32.Parse(dr_socauhoi.Text) + 3;
            causo.Visible = true;
            id_causo.Visible = false;
            id_caubatdau.Visible = true;
            if (dr_Phan.Text == "Listening" || dr_Phan.Text == "Listeningtest")
                noidungdoanvan.Visible = false;
            else
                noidungdoanvan.Visible = true;
            cauhoi1.Visible = true;
            dapanA1.Visible = true;
            dapanB1.Visible = true;
            dapanC1.Visible = true;
            dapanD1.Visible = true;
            cauhoi2.Visible = true;
            dapanA2.Visible = true;
            dapanB2.Visible = true;
            dapanC2.Visible = true;
            dapanD2.Visible = true;
            cauhoi3.Visible = true;
            dapanA3.Visible = true;
            dapanB3.Visible = true;
            dapanC3.Visible = true;
            dapanD3.Visible = true;
            cauhoi4.Visible = true;
            dapanA4.Visible = true;
            dapanB4.Visible = true;
            dapanC4.Visible = true;
            dapanD4.Visible = true;
            cauhoi5.Visible = false;
            dapanA5.Visible = false;
            dapanB5.Visible = false;
            dapanC5.Visible = false;
            dapanD5.Visible = false;
            fileAnh.Visible = false;
            fileNghe.Visible = false;
       
        }
        else if (dr_soluong.Text.Trim() == "5")
        {
            stt1 = Int32.Parse(dr_socauhoi.Text);
            stt2 = Int32.Parse(dr_socauhoi.Text) + 1;
            stt3 = Int32.Parse(dr_socauhoi.Text) + 2;
            stt4 = Int32.Parse(dr_socauhoi.Text) + 3;
            stt5 = Int32.Parse(dr_socauhoi.Text) + 4;
            causo.Visible = true;
            id_causo.Visible = false;
            id_caubatdau.Visible = true;
            if (dr_Phan.Text == "Listening" || dr_Phan.Text == "Listeningtest")
                noidungdoanvan.Visible = false;
            else
                noidungdoanvan.Visible = true;
            cauhoi1.Visible = true;
            dapanA1.Visible = true;
            dapanB1.Visible = true;
            dapanC1.Visible = true;
            dapanD1.Visible = true;
            cauhoi2.Visible = true;
            dapanA2.Visible = true;
            dapanB2.Visible = true;
            dapanC2.Visible = true;
            dapanD2.Visible = true;
            cauhoi3.Visible = true;
            dapanA3.Visible = true;
            dapanB3.Visible = true;
            dapanC3.Visible = true;
            dapanD3.Visible = true;
            cauhoi4.Visible = true;
            dapanA4.Visible = true;
            dapanB4.Visible = true;
            dapanC4.Visible = true;
            dapanD4.Visible = true;
            cauhoi5.Visible = true;
            dapanA5.Visible = true;
            dapanB5.Visible = true;
            dapanC5.Visible = true;
            dapanD5.Visible = true;
            fileAnh.Visible = false;
            fileNghe.Visible = false;
         
        }
    }
    protected void dr_socauhoi_SelectedIndexChanged(object sender, EventArgs e)
    {


        stt1 = Int32.Parse(dr_socauhoi.Text);
        stt2 = Int32.Parse(dr_socauhoi.Text) + 1;
        stt3 = Int32.Parse(dr_socauhoi.Text) + 1;
        stt4 = Int32.Parse(dr_socauhoi.Text) + 1;
        stt5 = Int32.Parse(dr_socauhoi.Text) + 1;
      
           
      
    }
    protected void bnt_Them_Click(object sender, EventArgs e)
    {
       
        if (dr_noidung.Text.Trim() == "Photographs")
        {
            string sql_dethi="select * from DETHI where Made='0"+dr_dethi.Text+"_Pho'";
            DataTable tb_dethi = ketnoi.getData(sql_dethi);
            if (tb_dethi.Rows.Count == 0)
            {
                string sql_insert = "insert into DETHI values('0" + dr_dethi.Text + "_Pho',N'Đề 0" + dr_dethi.Text + "',getdate(),NULL,'Photographs')";
                ketnoi.executeQuery(sql_insert);
            }
            else
            {

                if (fileNghe.Visible == true && cauhoi.Visible == false)
                {
                    HttpFileCollection fileCollection = Request.Files;
                    for (int i = 0; i < fileCollection.Count; i++)
                    {
                        HttpPostedFile uploadfile = fileCollection[i];
                        string fileName = Path.GetFileName(uploadfile.FileName);
                        if (uploadfile.ContentLength > 0)
                        {
                            try
                            {
                                string kiemtra = " select * from FILES where IDFile='Nghe_Photo_0" + dr_dethi.Text + "'";
                                DataTable tb_kiemtra = ketnoi.getData(kiemtra);
                                if (tb_kiemtra.Rows.Count > 0)
                                {
                                    Response.Write("<script>alert('File nghe đã tồn tại!'); </script>");
                                    fileNghe.Visible = false;
                                    fileAnh.Visible = true;
                                    causo.Visible = true;
                                    id_causo.Visible = true;
                                    cauhoi.Visible = true;
                                    dapanA.Visible = true;
                                    dapanB.Visible = true;
                                    dapanC.Visible = true;
                                    dapanD.Visible = true;
                                }
                                else
                                {
                                    uploadfile.SaveAs(Server.MapPath("~/audio/") + fileName);
                                    string sql = "insert into FILES values('Nghe_Photo_0" + dr_dethi.Text + "',N'" + fileName + "','" + dr_noidung.Text + "',NULL)";
                                    ketnoi.executeQuery(sql);
                                    Response.Write("<script>alert('Upload file Nghe thành công!'); </script>");
                                    fileNghe.Visible = false;
                                    fileAnh.Visible = true;
                                    causo.Visible = true;
                                    id_causo.Visible = true;
                                    cauhoi.Visible = true;
                                    dapanA.Visible = true;
                                    dapanB.Visible = true;
                                    dapanC.Visible = true;
                                    dapanD.Visible = true;
                                }
                            }
                            catch
                            {
                                Response.Write("<script>alert('Upload file Nghe không thành công!'); </script>");
                            }

                        }
                    }
                }
                else
                {
                    HttpFileCollection fileCollection = Request.Files;
                    for (int i = 0; i < fileCollection.Count; i++)
                    {
                        HttpPostedFile uploadfile = fileCollection[i];
                        string fileName = Path.GetFileName(uploadfile.FileName);
                        if (uploadfile.ContentLength > 0)
                        {

                            string kiemtra = "select * from FILES where IDFile='Photo_0" + dr_dethi.Text + "_0" + dr_socauhoi.Text + "'";
                            DataTable tb_kiemtra = ketnoi.getData(kiemtra);
                            if (tb_kiemtra.Rows.Count > 0)
                            {
                                Response.Write("<script>alert('Câu hỏi này đã tồn tại!'); </script>");

                            }
                            else
                            {
                                uploadfile.SaveAs(Server.MapPath("~/images_listen/") + fileName);
                                string sql = "insert into FILES values('Photo_0" + dr_dethi.Text + "_0" + dr_socauhoi.Text + "',N'" + fileName + "','" + dr_noidung.Text + "','Nghe_Photo_0" + dr_dethi.Text + "')";
                                ketnoi.executeQuery(sql);
                                try
                                {
                                    string sql_cauhoi = "insert into CAUHOI values('" + dr_dethi.Text + "_Pho_" + dr_socauhoi.Text + "','','" + txt_cauhoi.Text + "','" + dr_noidung.Text + "','Photo_0" + dr_dethi.Text + "_0" + dr_socauhoi.Text + "','0" + dr_dethi.Text + "_Pho')";
                                    ketnoi.executeQuery(sql_cauhoi);
                                    string sql_dapanA, sql_dapanB, sql_dapanC, sql_dapanD;
                                    if (rd_TrueA.Checked)
                                    {
                                        sql_dapanA = "insert into DAPAN values('" + dr_dethi.Text + "_Pho_" + dr_socauhoi.Text + "_1',NULL,'True','" + dr_dethi.Text + "_Pho_" + dr_socauhoi.Text + "')";
                                        ketnoi.executeQuery(sql_dapanA);
                                    }
                                    else
                                    {
                                        sql_dapanA = "insert into DAPAN values('" + dr_dethi.Text + "_Pho_" + dr_socauhoi.Text + "_1',NULL,'False','" + dr_dethi.Text + "_Pho_" + dr_socauhoi.Text + "')";
                                        ketnoi.executeQuery(sql_dapanA);
                                    }
                                    if (rd_TrueB.Checked)
                                    {
                                        sql_dapanB = "insert into DAPAN values('" + dr_dethi.Text + "_Pho_" + dr_socauhoi.Text + "_2',NULL,'True','" + dr_dethi.Text + "_Pho_" + dr_socauhoi.Text + "')";
                                        ketnoi.executeQuery(sql_dapanB);
                                    }
                                    else
                                    {
                                        sql_dapanB = "insert into DAPAN values('" + dr_dethi.Text + "_Pho_" + dr_socauhoi.Text + "_2',NULL,'False','" + dr_dethi.Text + "_Pho_" + dr_socauhoi.Text + "')";
                                        ketnoi.executeQuery(sql_dapanB);
                                    }
                                    if (rd_TrueC.Checked)
                                    {
                                        sql_dapanC = "insert into DAPAN values('" + dr_dethi.Text + "_Pho_" + dr_socauhoi.Text + "_3',NULL,'True','" + dr_dethi.Text + "_Pho_" + dr_socauhoi.Text + "')";
                                        ketnoi.executeQuery(sql_dapanC);

                                    }
                                    else
                                    {
                                        sql_dapanC = "insert into DAPAN values('" + dr_dethi.Text + "_Pho_" + dr_socauhoi.Text + "_3',NULL,'False','" + dr_dethi.Text + "_Pho_" + dr_socauhoi.Text + "')";
                                        ketnoi.executeQuery(sql_dapanC);

                                    }
                                    if (rd_TrueD.Checked)
                                    {
                                        sql_dapanD = "insert into DAPAN values('" + dr_dethi.Text + "_Pho_" + dr_socauhoi.Text + "_4',NULL,'True','" + dr_dethi.Text + "_Pho_" + dr_socauhoi.Text + "')";
                                        ketnoi.executeQuery(sql_dapanD);

                                    }
                                    else
                                    {
                                        sql_dapanD = "insert into DAPAN values('" + dr_dethi.Text + "_Pho_" + dr_socauhoi.Text + "_4',NULL,'False','" + dr_dethi.Text + "_Pho_" + dr_socauhoi.Text + "')";
                                        ketnoi.executeQuery(sql_dapanD);

                                    }
                                    Response.Write("<script>alert('Thêm câu hỏi thành công!'); </script>");
                                }
                                catch { Response.Write("<script>alert('Thêm câu hỏi không thành công!'); </script>"); }
                            }

                        }
                    }

                }
            }
        }
        else if (dr_noidung.Text.Trim() == "Photographstest")
        {
             string sql_dethi;
            if (dr_capdo.Text == "Tonghop" || dr_capdo.Text == "0")
           
          sql_dethi = "select * from DETHI where Made='0" + dr_dethi.Text + "'";
                else
                sql_dethi = "select * from DETHI where Made='0" + dr_dethi.Text + "_"+dr_capdo.Text+"'";
            DataTable tb_dethi = ketnoi.getData(sql_dethi);
            if (tb_dethi.Rows.Count == 0)
            { 
                string sql_insert;
            if (dr_capdo.Text == "Tonghop" || dr_capdo.Text == "0")
            {
                sql_insert = "insert into DETHI values('0" + dr_dethi.Text + "',N'Đề 0" + dr_dethi.Text + "',getdate(),NULL,'"+dr_capdo.Text+"')";
            }
            else
            {
                sql_insert = "insert into DETHI values('0" + dr_dethi.Text + "_" + dr_capdo.Text + "',N'Đề 0" + dr_dethi.Text + "',getdate(),NULL,'" + dr_capdo.Text + "')";
            }
                    ketnoi.executeQuery(sql_insert);
            }
            else
            {

                if (fileNghe.Visible == true && cauhoi.Visible == false)
                {
                    HttpFileCollection fileCollection = Request.Files;
                    for (int i = 0; i < fileCollection.Count; i++)
                    {
                        HttpPostedFile uploadfile = fileCollection[i];
                        string fileName = Path.GetFileName(uploadfile.FileName);
                        if (uploadfile.ContentLength > 0)
                        {
                            try
                            {
                                string kiemtra = " select * from FILES where IDFile='Nghe_0" + dr_dethi.Text + "'";
                                DataTable tb_kiemtra = ketnoi.getData(kiemtra);
                                if (tb_kiemtra.Rows.Count > 0)
                                {
                                    Response.Write("<script>alert('File nghe đã tồn tại!'); </script>");
                                    fileNghe.Visible = false;
                                    fileAnh.Visible = true;
                                    causo.Visible = true;
                                    id_causo.Visible = true;
                                    cauhoi.Visible = true;
                                    dapanA.Visible = true;
                                    dapanB.Visible = true;
                                    dapanC.Visible = true;
                                    dapanD.Visible = true;
                                }
                                else
                                {
                                    uploadfile.SaveAs(Server.MapPath("~/audio/") + fileName);
                                    string sql = "insert into FILES values('Nghe_0" + dr_dethi.Text + "',N'" + fileName + "','" + dr_noidung.Text + "',NULL)";
                                    ketnoi.executeQuery(sql);
                                    Response.Write("<script>alert('Upload file Nghe thành công!'); </script>");
                                    fileNghe.Visible = false;
                                    fileAnh.Visible = true;
                                    causo.Visible = true;
                                    id_causo.Visible = true;
                                    cauhoi.Visible = true;
                                    dapanA.Visible = true;
                                    dapanB.Visible = true;
                                    dapanC.Visible = true;
                                    dapanD.Visible = true;
                                }
                            }
                            catch
                            {
                                Response.Write("<script>alert('Upload file Nghe không thành công!'); </script>");
                            }

                        }
                    }
                }
                else
                {
                    HttpFileCollection fileCollection = Request.Files;
                    for (int i = 0; i < fileCollection.Count; i++)
                    {
                        HttpPostedFile uploadfile = fileCollection[i];
                        string fileName = Path.GetFileName(uploadfile.FileName);
                        if (uploadfile.ContentLength > 0)
                        {

                            string kiemtra = "select * from FILES where IDFile='Photo_0" + dr_dethi.Text + "_0" + dr_socauhoi.Text + "'";
                            DataTable tb_kiemtra = ketnoi.getData(kiemtra);
                            if (tb_kiemtra.Rows.Count > 0)
                            {
                                Response.Write("<script>alert('Câu hỏi này đã tồn tại!'); </script>");

                            }
                            else
                            {
                                uploadfile.SaveAs(Server.MapPath("~/images_listen/") + fileName);
                                string sql = "insert into FILES values('Nghe_0" + dr_dethi.Text + "_0" + dr_socauhoi.Text + "',N'" + fileName + "','" + dr_noidung.Text + "','Nghe_0" + dr_dethi.Text + "')";
                                ketnoi.executeQuery(sql);
                                try
                                {
                                    string sql_kiemtra = "select * from CAUHOI where IDCauhoi='" + dr_dethi.Text + "_" + dr_socauhoi.Text + "'";
                                    DataTable tbcauhoi = ketnoi.getData(sql_kiemtra);
                                    if (tbcauhoi.Rows.Count > 0)
                                    {
                                        Response.Write("<script>alert('Câu hỏi này đã tồn tại!'); </script>");

                                    }
                                    else
                                    {


                                        string sql_cauhoi = "insert into CAUHOI values('" + dr_dethi.Text + "_" + dr_socauhoi.Text + "','','" + txt_cauhoi.Text + "','" + dr_noidung.Text + "','Nghe_0" + dr_dethi.Text + "_0" + dr_socauhoi.Text + "','0" + dr_dethi.Text + "')";
                                        ketnoi.executeQuery(sql_cauhoi);
                                        string sql_dapanA, sql_dapanB, sql_dapanC, sql_dapanD;
                                        if (rd_TrueA.Checked)
                                        {
                                            sql_dapanA = "insert into DAPAN values('" + dr_dethi.Text + "_" + dr_socauhoi.Text + "_1',NULL,'True','" + dr_dethi.Text + "_" + dr_socauhoi.Text + "')";
                                            ketnoi.executeQuery(sql_dapanA);
                                        }
                                        else
                                        {
                                            sql_dapanA = "insert into DAPAN values('" + dr_dethi.Text + "_" + dr_socauhoi.Text + "_1',NULL,'False','" + dr_dethi.Text + "_" + dr_socauhoi.Text + "')";
                                            ketnoi.executeQuery(sql_dapanA);
                                        }
                                        if (rd_TrueB.Checked)
                                        {
                                            sql_dapanB = "insert into DAPAN values('" + dr_dethi.Text + "_" + dr_socauhoi.Text + "_2',NULL,'True','" + dr_dethi.Text + "_" + dr_socauhoi.Text + "')";
                                            ketnoi.executeQuery(sql_dapanB);
                                        }
                                        else
                                        {
                                            sql_dapanB = "insert into DAPAN values('" + dr_dethi.Text + "_" + dr_socauhoi.Text + "_2',NULL,'False','" + dr_dethi.Text + "_" + dr_socauhoi.Text + "')";
                                            ketnoi.executeQuery(sql_dapanB);
                                        }
                                        if (rd_TrueC.Checked)
                                        {
                                            sql_dapanC = "insert into DAPAN values('" + dr_dethi.Text + "_" + dr_socauhoi.Text + "_3',NULL,'True','" + dr_dethi.Text + "_" + dr_socauhoi.Text + "')";
                                            ketnoi.executeQuery(sql_dapanC);

                                        }
                                        else
                                        {
                                            sql_dapanC = "insert into DAPAN values('" + dr_dethi.Text + "_" + dr_socauhoi.Text + "_3',NULL,'False','" + dr_dethi.Text + "_" + dr_socauhoi.Text + "')";
                                            ketnoi.executeQuery(sql_dapanC);

                                        }
                                        if (rd_TrueD.Checked)
                                        {
                                            sql_dapanD = "insert into DAPAN values('" + dr_dethi.Text + "_" + dr_socauhoi.Text + "_4',NULL,'True','" + dr_dethi.Text + "_" + dr_socauhoi.Text + "')";
                                            ketnoi.executeQuery(sql_dapanD);

                                        }
                                        else
                                        {
                                            sql_dapanD = "insert into DAPAN values('" + dr_dethi.Text + "_" + dr_socauhoi.Text + "_4',NULL,'False','" + dr_dethi.Text + "_" + dr_socauhoi.Text + "')";
                                            ketnoi.executeQuery(sql_dapanD);

                                        }
                                        Response.Write("<script>alert('Thêm câu hỏi thành công!'); </script>");
                                    }
                                }
                                catch { Response.Write("<script>alert('Thêm câu hỏi không thành công!'); </script>"); }
                            }
                        }
                    }
                }
            }
        }

      
        else if (dr_noidung.Text.Trim() == "Question")
        {
            string sql_dethi="select * from DETHI where Made='0"+dr_dethi.Text+"_Ques'";
            DataTable tb_dethi = ketnoi.getData(sql_dethi);
            if (tb_dethi.Rows.Count == 0)
            {
                string sql_insert = "insert into DETHI values('0" + dr_dethi.Text + "_Ques',N'Đề 0" + dr_dethi.Text + "',getdate(),NULL,'Question')";
                ketnoi.executeQuery(sql_insert);
            }
            else
            {
                if (fileNghe.Visible == true && cauhoi.Visible == false)
                {
                    HttpFileCollection fileCollection = Request.Files;
                    for (int i = 0; i < fileCollection.Count; i++)
                    {
                        HttpPostedFile uploadfile = fileCollection[i];
                        string fileName = Path.GetFileName(uploadfile.FileName);
                        if (uploadfile.ContentLength > 0)
                        {
                            try
                            {
                                string kiemtra = " select * from FILES where IDFile='Nghe_Ques_0" + dr_dethi.Text + "'";
                                DataTable tb_kiemtra = ketnoi.getData(kiemtra);
                                if (tb_kiemtra.Rows.Count > 0)
                                {
                                    Response.Write("<script>alert('File nghe đã tồn tại!'); </script>");
                                    fileNghe.Visible = false;

                                    causo.Visible = true;
                                    id_causo.Visible = true;
                                    cauhoi.Visible = true;
                                    dapanA.Visible = true;
                                    dapanB.Visible = true;
                                    dapanC.Visible = true;

                                }
                                else
                                {
                                    uploadfile.SaveAs(Server.MapPath("~/audio/") + fileName);
                                    string sql = "insert into FILES values('Nghe_Ques_0" + dr_dethi.Text + "',N'" + fileName + "','" + dr_noidung.Text + "',NULL)";
                                    ketnoi.executeQuery(sql);
                                    Response.Write("<script>alert('Upload file Nghe thành công!'); </script>");
                                    fileNghe.Visible = false;

                                    causo.Visible = true;
                                    id_causo.Visible = true;
                                    cauhoi.Visible = true;
                                    dapanA.Visible = true;
                                    dapanB.Visible = true;
                                    dapanC.Visible = true;

                                }
                            }
                            catch
                            {
                                Response.Write("<script>alert('Upload file Nghe không thành công!'); </script>");
                            }

                        }
                    }
                }


                else
                {
                    try
                    {
                        string sql_dethi1 = "select * from DETHI where Made='0" + dr_dethi.Text + "_Ques'";
                        DataTable tb_dethi1 = ketnoi.getData(sql_dethi);
                        if (tb_dethi1.Rows.Count == 0)
                        {
                            string sql_insert = "insert into DETHI values('0" + dr_dethi.Text + "_Ques',N'Đề 0" + dr_dethi.Text + "',getdate(),NULL,'Question')";
                            ketnoi.executeQuery(sql_insert);
                        }
                    }
                    catch { }
                    string sql_kiemtra = "(select * from CAUHOI where IDCauhoi='" + dr_dethi.Text + "_Ques_" + dr_socauhoi.Text + "')";
                    ketnoi.executeQuery(sql_kiemtra);

                    DataTable tb_kiemtra = ketnoi.getData(sql_kiemtra);
                    if (tb_kiemtra.Rows.Count > 0)
                    {
                        Response.Write("<script>alert('Câu hỏi này đã tồn tại!'); </script>");

                    }
                    else
                    {
                        string noidung = "select IDNoidungchitiet from CHITIETNOIDUNG where Tennoidung='Part 2: Question - Response'";
                        DataTable tb_noidung = ketnoi.getData(noidung);
                   

                        string sql_cauhoi = "insert into CAUHOI values('" + dr_dethi.Text + "_Ques_" + dr_socauhoi.Text + "','','" + txt_cauhoi.Text + "','" + dr_noidung.Text + "','Nghe_Ques_0"+dr_dethi.Text+"','0" + dr_dethi.Text + "_Ques')";
                        ketnoi.executeQuery(sql_cauhoi);
                        string sql_dapanA, sql_dapanB, sql_dapanC;
                        if (rd_TrueA.Checked)
                        {
                            sql_dapanA = "insert into DAPAN values('" + dr_dethi.Text + "_Ques_" + dr_socauhoi.Text + "_1',NULL,'True','" + dr_dethi.Text + "_Ques_" + dr_socauhoi.Text + "')";
                            ketnoi.executeQuery(sql_dapanA);
                        }
                        else
                        {
                            sql_dapanA = "insert into DAPAN values('" + dr_dethi.Text + "_Ques_" + dr_socauhoi.Text + "_1',NULL,'False','" + dr_dethi.Text + "_Ques_" + dr_socauhoi.Text + "')";
                            ketnoi.executeQuery(sql_dapanA);
                        }
                        if (rd_TrueB.Checked)
                        {
                            sql_dapanB = "insert into DAPAN values('" + dr_dethi.Text + "_Ques_" + dr_socauhoi.Text + "_2',NULL,'True','" + dr_dethi.Text + "_Ques_" + dr_socauhoi.Text + "')";
                            ketnoi.executeQuery(sql_dapanB);
                        }
                        else
                        {
                            sql_dapanB = "insert into DAPAN values('" + dr_dethi.Text + "_Ques_" + dr_socauhoi.Text + "_2',NULL,'False','" + dr_dethi.Text + "_Ques_" + dr_socauhoi.Text + "')";
                            ketnoi.executeQuery(sql_dapanB);
                        }
                        if (rd_TrueC.Checked)
                        {
                            sql_dapanC = "insert into DAPAN values('" + dr_dethi.Text + "_Ques_" + dr_socauhoi.Text + "_3',NULL,'True','" + dr_dethi.Text + "_Ques_" + dr_socauhoi.Text + "')";
                            ketnoi.executeQuery(sql_dapanC);

                        }
                        else
                        {
                            sql_dapanC = "insert into DAPAN values('" + dr_dethi.Text + "_Ques_" + dr_socauhoi.Text + "_3',NULL,'False','" + dr_dethi.Text + "_Ques_" + dr_socauhoi.Text + "')";
                            ketnoi.executeQuery(sql_dapanC);

                        }

                        Response.Write("<script>alert('Thêm câu hỏi thành công!'); </script>");

                    }
                }


            }

            
         
        }
        else if (dr_noidung.Text.Trim() == "Questiontest")
        {
            string sql_dethi;
            if (dr_capdo.Text == "Tonghop" || dr_capdo.Text == "0")

                sql_dethi = "select * from DETHI where Made='0" + dr_dethi.Text + "'";
            else
                sql_dethi = "select * from DETHI where Made='0" + dr_dethi.Text + "_" + dr_capdo.Text + "'";
            DataTable tb_dethi = ketnoi.getData(sql_dethi);
            if (tb_dethi.Rows.Count == 0)
            {
                string sql_insert;
                if (dr_capdo.Text == "Tonghop" || dr_capdo.Text == "0")
                {
                    sql_insert = "insert into DETHI values('0" + dr_dethi.Text + "',N'Đề 0" + dr_dethi.Text + "',getdate(),NULL,'" + dr_capdo.Text + "')";
                }
                else
                {
                    sql_insert = "insert into DETHI values('0" + dr_dethi.Text + "_" + dr_capdo.Text + "',N'Đề 0" + dr_dethi.Text + "',getdate(),NULL,'" + dr_capdo.Text + "')";
                }
                ketnoi.executeQuery(sql_insert);
            }
            else
            {

                if (fileNghe.Visible == true && cauhoi.Visible == false)
                {
                    HttpFileCollection fileCollection = Request.Files;
                    for (int i = 0; i < fileCollection.Count; i++)
                    {
                        HttpPostedFile uploadfile = fileCollection[i];
                        string fileName = Path.GetFileName(uploadfile.FileName);
                        if (uploadfile.ContentLength > 0)
                        {
                            try
                            {
                                string kiemtra = " select * from FILES where IDFile='Nghe_Photo_0" + dr_dethi.Text + "'";
                                DataTable tb_kiemtra = ketnoi.getData(kiemtra);
                                if (tb_kiemtra.Rows.Count > 0)
                                {
                                    Response.Write("<script>alert('File nghe đã tồn tại!'); </script>");
                                    fileNghe.Visible = false;
                                    fileAnh.Visible = false;
                                    causo.Visible = true;
                                    id_causo.Visible = true;
                                    cauhoi.Visible = true;
                                    dapanA.Visible = true;
                                    dapanB.Visible = true;
                                    dapanC.Visible = true;
                                    dapanD.Visible = true;
                                }
                                else
                                {
                                    uploadfile.SaveAs(Server.MapPath("~/audio/") + fileName);
                                    string sql = "insert into FILES values('Nghe_Ques_0" + dr_dethi.Text + "',N'" + fileName + "','" + dr_noidung.Text + "',NULL)";
                                    ketnoi.executeQuery(sql);
                                    Response.Write("<script>alert('Upload file Nghe thành công!'); </script>");
                                    fileNghe.Visible = false;
                                    fileAnh.Visible = false;
                                    causo.Visible = true;
                                    id_causo.Visible = true;
                                    cauhoi.Visible = true;
                                    dapanA.Visible = true;
                                    dapanB.Visible = true;
                                    dapanC.Visible = true;
                                    dapanD.Visible = true;
                                }
                            }
                            catch
                            {
                                Response.Write("<script>alert('Upload file Nghe không thành công!'); </script>");
                            }

                        }
                    }
                }
                else
                {

                            string sql_kiemtra = "(select * from CAUHOI where IDCauhoi='"+dr_dethi.Text+"_"+dr_socauhoi.Text+"')";
                            ketnoi.executeQuery(sql_kiemtra);
                        
                            DataTable tb_kiemtra = ketnoi.getData(sql_kiemtra);
                            if (tb_kiemtra.Rows.Count > 0)
                            {
                                Response.Write("<script>alert('Câu hỏi này đã tồn tại!'); </script>");

                            }
                            else
                            {
                               
                                string sql_cauhoi = "insert into CAUHOI values('" + dr_dethi.Text + "_" + dr_socauhoi.Text + "','','" + txt_cauhoi.Text + "','" + dr_noidung.Text + "','Nghe_0" + dr_dethi.Text + "','0" + dr_dethi.Text + "')";
                                ketnoi.executeQuery(sql_cauhoi);
                                string sql_dapanA, sql_dapanB, sql_dapanC, sql_dapanD;
                                if (rd_TrueA.Checked)
                                {
                                    sql_dapanA = "insert into DAPAN values('" + dr_dethi.Text + "_" + dr_socauhoi.Text + "_1','"+txt_A.Text+"','True','" + dr_dethi.Text + "_" + dr_socauhoi.Text + "')";
                                    ketnoi.executeQuery(sql_dapanA);
                                }
                                else
                                {
                                    sql_dapanA = "insert into DAPAN values('" + dr_dethi.Text + "_" + dr_socauhoi.Text + "_1','"+txt_A.Text+"','False','" + dr_dethi.Text + "_" + dr_socauhoi.Text + "')";
                                    ketnoi.executeQuery(sql_dapanA);
                                }
                                if (rd_TrueB.Checked)
                                {
                                    sql_dapanB = "insert into DAPAN values('" + dr_dethi.Text + "_" + dr_socauhoi.Text + "_2','"+txt_B.Text+"','True','" + dr_dethi.Text + "_" + dr_socauhoi.Text + "')";
                                    ketnoi.executeQuery(sql_dapanB);
                                }
                                else
                                {
                                    sql_dapanB = "insert into DAPAN values('" + dr_dethi.Text + "_" + dr_socauhoi.Text + "_2','"+txt_B.Text+"','False','" + dr_dethi.Text + "_" + dr_socauhoi.Text + "')";
                                    ketnoi.executeQuery(sql_dapanB);
                                }
                                if (rd_TrueC.Checked)
                                {
                                    sql_dapanC = "insert into DAPAN values('" + dr_dethi.Text + "_" + dr_socauhoi.Text + "_3','"+txt_C.Text+"','True','" + dr_dethi.Text + "_" + dr_socauhoi.Text + "')";
                                    ketnoi.executeQuery(sql_dapanC);

                                }
                                else
                                {
                                    sql_dapanC = "insert into DAPAN values('" + dr_dethi.Text + "_" + dr_socauhoi.Text + "_3','"+txt_C.Text+"','False','" + dr_dethi.Text + "_" + dr_socauhoi.Text + "')";
                                    ketnoi.executeQuery(sql_dapanC);

                                }
                                if (rd_TrueD.Checked)
                                {
                                    sql_dapanD = "insert into DAPAN values('" + dr_dethi.Text + "_" + dr_socauhoi.Text + "_4','"+txt_D.Text+"','True','" + dr_dethi.Text + "_" + dr_socauhoi.Text + "')";
                                    ketnoi.executeQuery(sql_dapanD);

                                }
                                else
                                {
                                    sql_dapanD = "insert into DAPAN values('" + dr_dethi.Text + "_" + dr_socauhoi.Text + "_4','"+txt_D.Text+"','False','" + dr_dethi.Text + "_" + dr_socauhoi.Text + "')";
                                    ketnoi.executeQuery(sql_dapanD);

                                }
                                Response.Write("<script>alert('Thêm câu hỏi thành công!'); </script>");

                            }
                        
                    
                }
            }
        }
        else if (dr_noidung.Text.Trim() == "Conversation")
        {
            string sql_dethi = "select * from DETHI where Made='0" + dr_dethi.Text + "_Conver'";
            DataTable tb_dethi = ketnoi.getData(sql_dethi);
            if (tb_dethi.Rows.Count == 0)
            {
                string sql_insert = "insert into DETHI values('0" + dr_dethi.Text + "_Conver',N'Đề 0" + dr_dethi.Text + "',getdate(),NULL,'Conversation')";
                ketnoi.executeQuery(sql_insert);
            }
                else if (fileNghe.Visible == true && cauhoi.Visible == false)
                {
                    HttpFileCollection fileCollection = Request.Files;
                    for (int i = 0; i < fileCollection.Count; i++)
                    {
                        HttpPostedFile uploadfile = fileCollection[i];
                        string fileName = Path.GetFileName(uploadfile.FileName);
                        if (uploadfile.ContentLength > 0)
                        {
                            try
                            {
                                string kiemtra = " select * from FILES where IDFile='Nghe_Conver_0" + dr_dethi.Text + "'";
                                DataTable tb_kiemtra = ketnoi.getData(kiemtra);
                                if (tb_kiemtra.Rows.Count > 0)
                                {
                                    Response.Write("<script>alert('File nghe đã tồn tại!'); </script>");
                                    fileNghe.Visible = false;
                                    soluongcauhoi.Visible = true;
                                    causo.Visible = true;
                                    id_caubatdau.Visible = true;
                                    noidungdoanvan.Visible = false;
                                    cauhoi.Visible = false;
                                    dapanA.Visible = false;
                                    dapanB.Visible = false;
                                    dapanC.Visible = false;


                                }
                                else
                                {
                                    uploadfile.SaveAs(Server.MapPath("~/audio/") + fileName);
                                    string sql = "insert into FILES values('Nghe_Conver_0" + dr_dethi.Text + "',N'" + fileName + "','" + dr_noidung.Text + "',NULL)";
                                    ketnoi.executeQuery(sql);
                                    Response.Write("<script>alert('Upload file Nghe thành công!'); </script>");
                                    fileNghe.Visible = false;
                                    noidungdoanvan.Visible = false;
                                    soluongcauhoi.Visible = true;
                                    causo.Visible = true;
                                    id_caubatdau.Visible = true;

                                }
                            }
                            catch
                            {
                                Response.Write("<script>alert('Upload file Nghe không thành công!'); </script>");
                            }

                        }
                    }
                }
            
                else
                {
                    fileNghe.Visible = false;
                    soluongcauhoi.Visible = true;
                    causo.Visible = true;
                    id_caubatdau.Visible = true;
                    noidungdoanvan.Visible = false;



                    try
                    {


                        string sql_dapanA;
                        string sql_dapanB;
                        string sql_dapanC;
                        string sql_dapanD;

                        int soluongcau = Int32.Parse(dr_soluong.Text);
                        int thutucau1 = Int32.Parse(dr_socauhoi.Text);

                        for (int i = 1; i <= soluongcau; i++)
                        {

                            try
                            {
                               
                                string sql_cauhoi;
                                string noidung;
                                if (i == 1)
                                    noidung = txt_doanvan.Text;
                                else
                                    noidung = "";
                                if (i == 1)
                                {
                                    sql_cauhoi = "insert into CAUHOI values('" + dr_dethi.Text + "_Conver_" + thutucau1 + "','" + noidung + "','" + txt_cauhoi1.Text + "','Conversation','Nghe_0" + dr_dethi.Text + "','0" + dr_dethi.Text + "_Conver')";
                                    ketnoi.executeQuery(sql_cauhoi);
                                }
                                else if (i == 2)
                                {
                                    sql_cauhoi = "insert into CAUHOI values('" + dr_dethi.Text + "_Conver_" + thutucau1 + "','','" + txt_cauhoi2.Text + "','Conversation','Nghe_0" + dr_dethi.Text + "','0" + dr_dethi.Text + "_Conver')";
                                    ketnoi.executeQuery(sql_cauhoi);
                                }
                                else if (i == 3)
                                {
                                    sql_cauhoi = "insert into CAUHOI values('" + dr_dethi.Text + "_Conver_" + thutucau1 + "','','" + txt_cauhoi3.Text + "','Conversation','Nghe_0" + dr_dethi.Text + "','0" + dr_dethi.Text + "_Conver')";
                                    ketnoi.executeQuery(sql_cauhoi);
                                }
                                else if (i == 4)
                                {
                                    sql_cauhoi = "insert into CAUHOI values('" + dr_dethi.Text + "_Conver_" + thutucau1 + "','','" + txt_cauhoi4.Text + "','Conversation','Nghe_0" + dr_dethi.Text + "','0" + dr_dethi.Text + "_Conver')";
                                    ketnoi.executeQuery(sql_cauhoi);
                                }
                                else if (i == 5)
                                {
                                    sql_cauhoi = "insert into CAUHOI values('" + dr_dethi.Text + "_Conver_" + thutucau1 + "','','" + txt_cauhoi5.Text + "','Conversation','Nghe_0" + dr_dethi.Text + "','0" + dr_dethi.Text + "_Conver')";
                                    ketnoi.executeQuery(sql_cauhoi);
                                }

                                
                                thutucau1++;
                            }
                            catch
                            {

                            }
                        }
                        int thutucau = Int32.Parse(dr_socauhoi.Text);
                        // dap an 1
                       if (rd_TrueA1.Checked)
                        {
                            sql_dapanA = "insert into DAPAN values('" + dr_dethi.Text + "_Conver_" + thutucau1 + "_1','" + txt_A1.Text + "','True','" + dr_dethi.Text + "_Conver_" + thutucau1 + "')";

                            ketnoi.executeQuery(sql_dapanA);
                        }
                        else
                        {
                            sql_dapanA = "insert into DAPAN values('" + dr_dethi.Text + "_Conver_" + thutucau1 + "_1','" + txt_A1.Text + "','False','" + dr_dethi.Text + "_Conver_" + thutucau1 + "')";
                            ketnoi.executeQuery(sql_dapanA);
                        }
                        if (rd_TrueB1.Checked)
                        {
                            sql_dapanB = "insert into DAPAN values('" + dr_dethi.Text + "_Conver_" + thutucau1 + "_2','" + txt_B1.Text + "','True','" + dr_dethi.Text + "_Conver_" + thutucau1 + "')";
                            ketnoi.executeQuery(sql_dapanB);
                        }
                        else
                        {
                            sql_dapanB = "insert into DAPAN values('" + dr_dethi.Text + "_Conver_" + thutucau1 + "_2','" + txt_B1.Text + "','False','" + dr_dethi.Text + "_Conver_" + thutucau1 + "')";
                            ketnoi.executeQuery(sql_dapanB);
                        }
                        if (rd_TrueC1.Checked)
                        {
                            sql_dapanC = "insert into DAPAN values('" + dr_dethi.Text + "_" + thutucau1 + "_3','" + txt_C1.Text + "','True','" + dr_dethi.Text + "_Conver_" + thutucau1 + "')";
                            ketnoi.executeQuery(sql_dapanC);

                        }
                        else
                        {
                            sql_dapanC = "insert into DAPAN values('" + dr_dethi.Text + "_Conver_" + thutucau1 + "_3','" + txt_C1.Text + "','False','" + dr_dethi.Text + "_Conver_" + thutucau1 + "')";
                            ketnoi.executeQuery(sql_dapanC);

                        }

                        if (rd_TrueD1.Checked)
                        {
                            sql_dapanD = "insert into DAPAN values('" + dr_dethi.Text + "_Conver_" + thutucau1 + "_4','" + txt_D1.Text + "','True','" + dr_dethi.Text + "_Conver_" + thutucau1 + "')";
                            ketnoi.executeQuery(sql_dapanD);
                        }
                        else
                        {
                            sql_dapanD = "insert into DAPAN values('" + dr_dethi.Text + "_Conver_" + thutucau1 + "_4','" + txt_D1.Text + "','False','" + dr_dethi.Text + "_Conver_" + thutucau1 + "')";
                            ketnoi.executeQuery(sql_dapanD);
                        }

                        // dap an 2
                        try
                        {
                            if (rd_TrueA2.Checked)
                            {
                                sql_dapanA = "insert into DAPAN values('" + dr_dethi.Text + "_Conver_" + (thutucau1 + 1) + "_1','" + txt_A2.Text + "','True','" + dr_dethi.Text + "_Conver_" + (thutucau1 + 1) + "')";
                                ketnoi.executeQuery(sql_dapanA);
                            }
                            else
                            {
                                sql_dapanA = "insert into DAPAN values('" + dr_dethi.Text + "_Conver_" + (thutucau1 + 1) + "_1','" + txt_A2.Text + "','False','" + dr_dethi.Text + "_Conver_" + (thutucau1 + 1) + "')";
                                ketnoi.executeQuery(sql_dapanA);
                            }
                            if (rd_TrueB2.Checked)
                            {
                                sql_dapanB = "insert into DAPAN values('" + dr_dethi.Text + "_Conver_" + (thutucau1 + 1) + "_2','" + txt_B2.Text + "','True','" + dr_dethi.Text + "_Conver_" + (thutucau1 + 1) + "')";
                                ketnoi.executeQuery(sql_dapanB);
                            }
                            else
                            {
                                sql_dapanB = "insert into DAPAN values('" + dr_dethi.Text + "_Conver_" + (thutucau1 + 1) + "_2','" + txt_B2.Text + "','False','" + dr_dethi.Text + "_" + (thutucau1 + 1) + "')";
                                ketnoi.executeQuery(sql_dapanB);
                            }
                            if (rd_TrueC2.Checked)
                            {
                                sql_dapanC = "insert into DAPAN values('" + dr_dethi.Text + "_Conver_" + (thutucau1 + 1) + "_3','" + txt_C2.Text + "','True','" + dr_dethi.Text + "_Conver_" + (thutucau1 + 1) + "')";
                                ketnoi.executeQuery(sql_dapanC);

                            }
                            else
                            {
                                sql_dapanC = "insert into DAPAN values('" + dr_dethi.Text + "_Conver_" + (thutucau1 + 1) + "_3','" + txt_C2.Text + "','False','" + dr_dethi.Text + "_Conver_" + (thutucau1 + 1) + "')";
                                ketnoi.executeQuery(sql_dapanC);

                            }

                            if (rd_TrueD2.Checked)
                            {
                                sql_dapanD = "insert into DAPAN values('" + dr_dethi.Text + "_Conver_" + (thutucau1 + 1) + "_4','" + txt_D2.Text + "','True','" + dr_dethi.Text + "_Conver_" + (thutucau1 + 1) + "')";
                                ketnoi.executeQuery(sql_dapanD);
                            }
                            else
                            {
                                sql_dapanD = "insert into DAPAN values('" + dr_dethi.Text + "_Conver_" + (thutucau1 + 1) + "_4','" + txt_D2.Text + "','False','" + dr_dethi.Text + "_Conver_" + (thutucau1 + 1) + "')";
                                ketnoi.executeQuery(sql_dapanD);
                            }
                        }
                        catch { }

                        // dap an 3
                        try
                        {
                            if (rd_TrueA3.Checked)
                            {
                                sql_dapanA = "insert into DAPAN values('" + dr_dethi.Text + "_Conver_" + (thutucau1 + 2) + "_1','" + txt_A3.Text + "','True','" + dr_dethi.Text + "_Conver_" + (thutucau1 + 2) + "')";
                                ketnoi.executeQuery(sql_dapanA);
                            }
                            else
                            {
                                sql_dapanA = "insert into DAPAN values('" + dr_dethi.Text + "_Conver_" + (thutucau1 + 2) + "_1','" + txt_A3.Text + "','False','" + dr_dethi.Text + "_" + (thutucau1 + 2) + "')";
                                ketnoi.executeQuery(sql_dapanA);
                            }
                            if (rd_TrueB3.Checked)
                            {
                                sql_dapanB = "insert into DAPAN values('" + dr_dethi.Text + "_Conver_" + (thutucau1 + 2) + "_2','" + txt_B3.Text + "','True','" + dr_dethi.Text + "_Conver_" + (thutucau1 + 2) + "')";
                                ketnoi.executeQuery(sql_dapanB);
                            }
                            else
                            {
                                sql_dapanB = "insert into DAPAN values('" + dr_dethi.Text + "_Conver_" + (thutucau1 + 2) + "_2','" + txt_B3.Text + "','False','" + dr_dethi.Text + "_Conver_" + (thutucau1 + 2) + "')";
                                ketnoi.executeQuery(sql_dapanB);
                            }
                            if (rd_TrueC3.Checked)
                            {
                                sql_dapanC = "insert into DAPAN values('" + dr_dethi.Text + "_Conver_" + (thutucau1 + 2) + "_3','" + txt_C3.Text + "','True','" + dr_dethi.Text + "_Conver_" + (thutucau1 + 2) + "')";
                                ketnoi.executeQuery(sql_dapanC);

                            }
                            else
                            {
                                sql_dapanC = "insert into DAPAN values('" + dr_dethi.Text + "_Conver_" + (thutucau1 + 2) + "_3','" + txt_C3.Text + "','False','" + dr_dethi.Text + "_Conver_" + (thutucau1 + 2) + "')";
                                ketnoi.executeQuery(sql_dapanC);

                            }

                            if (rd_TrueD3.Checked)
                            {
                                sql_dapanD = "insert into DAPAN values('" + dr_dethi.Text + "_Conver_" + (thutucau1 + 2) + "_4','" + txt_D3.Text + "','True','" + dr_dethi.Text + "_Conver_" + (thutucau1 + 2) + "')";
                                ketnoi.executeQuery(sql_dapanD);
                            }
                            else
                            {
                                sql_dapanD = "insert into DAPAN values('" + dr_dethi.Text + "_Conver_" + (thutucau1 + 2) + "_4','" + txt_D3.Text + "','False','" + dr_dethi.Text + "_Conver_" + (thutucau1 + 2) + "')";
                                ketnoi.executeQuery(sql_dapanD);
                            }
                        }
                        catch { }
                        // dap an 4
                        try
                        {

                            if (rd_TrueA4.Checked)
                            {
                                sql_dapanA = "insert into DAPAN values('" + dr_dethi.Text + "_Conver_" + (thutucau1 + 3) + "_1','" + txt_A4.Text + "','True','" + dr_dethi.Text + "_Conver_" + (thutucau1 + 3) + "')";
                                ketnoi.executeQuery(sql_dapanA);
                            }
                            else
                            {
                                sql_dapanA = "insert into DAPAN values('" + dr_dethi.Text + "_Conver_" + (thutucau1 + 3) + "_1','" + txt_A1.Text + "','False','" + dr_dethi.Text + "_Conver_" + (thutucau1 + 3) + "')";
                                ketnoi.executeQuery(sql_dapanA);
                            }
                            if (rd_TrueB4.Checked)
                            {
                                sql_dapanB = "insert into DAPAN values('" + dr_dethi.Text + "_Conver_" + (thutucau1 + 3) + "_2','" + txt_B4.Text + "','True','" + dr_dethi.Text + "_Conver_" + (thutucau1 + 3) + "')";
                                ketnoi.executeQuery(sql_dapanB);
                            }
                            else
                            {
                                sql_dapanB = "insert into DAPAN values('" + dr_dethi.Text + "_Conver_" + (thutucau1 + 3) + "_2','" + txt_B4.Text + "','False','" + dr_dethi.Text + "_Conver_" + (thutucau1 + 3) + "')";
                                ketnoi.executeQuery(sql_dapanB);
                            }
                            if (rd_TrueC4.Checked)
                            {
                                sql_dapanC = "insert into DAPAN values('" + dr_dethi.Text + "_Conver_" + (thutucau1 + 3) + "_3','" + txt_C4.Text + "','True','" + dr_dethi.Text + "_Conver_" + (thutucau1 + 3) + "')";
                                ketnoi.executeQuery(sql_dapanC);

                            }
                            else
                            {
                                sql_dapanC = "insert into DAPAN values('" + dr_dethi.Text + "_Conver_" + (thutucau1 + 3) + "_3','" + txt_C4.Text + "','False','" + dr_dethi.Text + "_Conver_" + (thutucau1 + 3) + "')";
                                ketnoi.executeQuery(sql_dapanC);

                            }

                            if (rd_TrueD4.Checked)
                            {
                                sql_dapanD = "insert into DAPAN values('" + dr_dethi.Text + "_Conver_" + (thutucau1 + 3) + "_4','" + txt_D4.Text + "','True','" + dr_dethi.Text + "_Conver_" + (thutucau1 + 3) + "')";
                                ketnoi.executeQuery(sql_dapanD);
                            }
                            else
                            {
                                sql_dapanD = "insert into DAPAN values('" + dr_dethi.Text + "_Conver_" + (thutucau1 + 3) + "_4','" + txt_D4.Text + "','False','" + dr_dethi.Text + "_Conver_" + (thutucau1 + 3) + "')";
                                ketnoi.executeQuery(sql_dapanD);
                            }
                        }
                        catch { }
                        // dap an 5
                        try
                        {
                            if (rd_TrueA5.Checked)
                            {
                                sql_dapanA = "insert into DAPAN values('" + dr_dethi.Text + "_Conver_" + (thutucau1 + 4) + "_1','" + txt_A5.Text + "','True','" + dr_dethi.Text + "_Conver_" + (thutucau1 + 4) + "')";
                                ketnoi.executeQuery(sql_dapanA);
                            }
                            else
                            {
                                sql_dapanA = "insert into DAPAN values('" + dr_dethi.Text + "_Conver_" + (thutucau1 + 4) + "_1','" + txt_A5.Text + "','False','" + dr_dethi.Text + "_Conver_" + (thutucau1 + 4) + "')";
                                ketnoi.executeQuery(sql_dapanA);
                            }
                            if (rd_TrueB5.Checked)
                            {
                                sql_dapanB = "insert into DAPAN values('" + dr_dethi.Text + "_Conver_" + (thutucau1 + 4) + "_2','" + txt_B5.Text + "','True','" + dr_dethi.Text + "_Conver_" + (thutucau1 + 4) + "')";
                                ketnoi.executeQuery(sql_dapanB);
                            }
                            else
                            {
                                sql_dapanB = "insert into DAPAN values('" + dr_dethi.Text + "_Conver_" + (thutucau1 + 4) + "_2','" + txt_B5.Text + "','False','" + dr_dethi.Text + "_Conver_" + (thutucau1 + 4) + "')";
                                ketnoi.executeQuery(sql_dapanB);
                            }
                            if (rd_TrueC5.Checked)
                            {
                                sql_dapanC = "insert into DAPAN values('" + dr_dethi.Text + "_Conver_" + (thutucau1 + 4) + "_3','" + txt_C5.Text + "','True','" + dr_dethi.Text + "_Conver_" + (thutucau1 + 4) + "')";
                                ketnoi.executeQuery(sql_dapanC);

                            }
                            else
                            {
                                sql_dapanC = "insert into DAPAN values('" + dr_dethi.Text + "_Conver_" + (thutucau1 + 4) + "_3','" + txt_C5.Text + "','False','" + dr_dethi.Text + "_Conver_" + (thutucau1 + 4) + "')";
                                ketnoi.executeQuery(sql_dapanC);

                            }

                            if (rd_TrueD5.Checked)
                            {
                                sql_dapanD = "insert into DAPAN values('" + dr_dethi.Text + "_Conver_" + (thutucau1 + 4) + "_4','" + txt_D5.Text + "','True','" + dr_dethi.Text + "_Conver_" + (thutucau1 + 4) + "')";
                                ketnoi.executeQuery(sql_dapanD);
                            }
                            else
                            {
                                sql_dapanD = "insert into DAPAN values('" + dr_dethi.Text + "_Conver_" + (thutucau1 + 4) + "_4','" + txt_D5.Text + "','False','" + dr_dethi.Text + "_Conver_" + (thutucau1 + 4) + "')";
                                ketnoi.executeQuery(sql_dapanD);
                            }
                        }
                            catch{}
                          Response.Write("<script>alert('Thêm câu hỏi thành công!'); </script>");
                    
                    }

                    catch
                    {
                          Response.Write("<script>alert('Thêm câu hỏi thành công!'); </script>");
                    
                    }
                }
        
        }
    
        else if (dr_noidung.Text.Trim() == "Conversationtest")
        {
            string sql_dethi;
            if (dr_capdo.Text == "Tonghop" || dr_capdo.Text == "0")

                sql_dethi = "select * from DETHI where Made='0" + dr_dethi.Text + "'";
            else
                sql_dethi = "select * from DETHI where Made='0" + dr_dethi.Text + "_" + dr_capdo.Text + "'";
            DataTable tb_dethi = ketnoi.getData(sql_dethi);
            if (tb_dethi.Rows.Count == 0)
            {
                string sql_insert;
                if (dr_capdo.Text == "Tonghop" || dr_capdo.Text == "0")
                {
                    sql_insert = "insert into DETHI values('0" + dr_dethi.Text + "',N'Đề 0" + dr_dethi.Text + "',getdate(),NULL,'" + dr_capdo.Text + "')";
                }
                else
                {
                    sql_insert = "insert into DETHI values('0" + dr_dethi.Text + "_" + dr_capdo.Text + "',N'Đề 0" + dr_dethi.Text + "',getdate(),NULL,'" + dr_capdo.Text + "')";
                }
                ketnoi.executeQuery(sql_insert);
            }
            else
            {

                if (fileNghe.Visible == true && cauhoi.Visible == false)
                {
                    HttpFileCollection fileCollection = Request.Files;
                    for (int i = 0; i < fileCollection.Count; i++)
                    {
                        HttpPostedFile uploadfile = fileCollection[i];
                        string fileName = Path.GetFileName(uploadfile.FileName);
                        if (uploadfile.ContentLength > 0)
                        {
                            try
                            {
                                string kiemtra = " select * from FILES where IDFile='Nghe_0" + dr_dethi.Text + "'";
                                DataTable tb_kiemtra = ketnoi.getData(kiemtra);
                                if (tb_kiemtra.Rows.Count > 0)
                                {
                                    Response.Write("<script>alert('File nghe đã tồn tại!'); </script>");
                                    fileNghe.Visible = false;
                                    soluongcauhoi.Visible = true;
                                    causo.Visible = true;
                                    id_caubatdau.Visible = true;
                                    noidungdoanvan.Visible = false;
                                    cauhoi.Visible = false;
                                    dapanA.Visible = false;
                                    dapanB.Visible = false;
                                    dapanC.Visible = false;

                                }
                                else
                                {
                                    uploadfile.SaveAs(Server.MapPath("~/audio/") + fileName);
                                    string sql = "insert into FILES values('Nghe_0" + dr_dethi.Text + "',N'" + fileName + "','" + dr_noidung.Text + "',NULL)";
                                    ketnoi.executeQuery(sql);
                                    Response.Write("<script>alert('Upload file Nghe thành công!'); </script>");
                                    fileNghe.Visible = false;
                                    soluongcauhoi.Visible = true;
                                    causo.Visible = true;
                                    id_caubatdau.Visible = true;
                                    noidungdoanvan.Visible = false;
                                    cauhoi.Visible = false;
                                    dapanA.Visible = false;
                                    dapanB.Visible = false;
                                    dapanC.Visible = false;

                                }
                            }
                            catch
                            {
                                Response.Write("<script>alert('Upload file Nghe không thành công!'); </script>");
                            }

                        }
                    }
                }

                else
                {
                    fileNghe.Visible = false;
                    soluongcauhoi.Visible = true;
                    causo.Visible = true;
                    id_caubatdau.Visible = true;
                    noidungdoanvan.Visible = false;

                    try{


                        string sql_dapanA;
                        string sql_dapanB;
                        string sql_dapanC;
                        string sql_dapanD;

                        int soluongcau = Int32.Parse(dr_soluong.Text);
                        int thutucau = Int32.Parse(dr_socauhoi.Text);

                        for (int i = 1; i <= soluongcau; i++)
                        {

                            try
                            {

                                string sql_cauhoi;
                                string noidung;
                                if (i == 1)
                                    noidung = txt_doanvan.Text;
                                else
                                    noidung = "";
                                if (i == 1)
                                {
                                    sql_cauhoi = "insert into CAUHOI values('" + dr_dethi.Text + "_" + thutucau + "','" + noidung + "','" + txt_cauhoi1.Text + "','Conversationtest','Nghe_0" + dr_dethi.Text + "','0" + dr_dethi.Text + "')";
                                    ketnoi.executeQuery(sql_cauhoi);
                                }
                                else if (i == 2)
                                {
                                    sql_cauhoi = "insert into CAUHOI values('" + dr_dethi.Text + "_" + thutucau + "','','" + txt_cauhoi2.Text + "','Conversationtest','Nghe_0" + dr_dethi.Text + "','0" + dr_dethi.Text + "')";
                                    ketnoi.executeQuery(sql_cauhoi);
                                }
                                else if (i == 3)
                                {
                                    sql_cauhoi = "insert into CAUHOI values('" + dr_dethi.Text + "_" + thutucau + "','','" + txt_cauhoi3.Text + "','Conversationtest','Nghe_0" + dr_dethi.Text + "','0" + dr_dethi.Text + "')";
                                    ketnoi.executeQuery(sql_cauhoi);
                                }
                                else if (i == 4)
                                {
                                    sql_cauhoi = "insert into CAUHOI values('" + dr_dethi.Text + "_" + thutucau + "','','" + txt_cauhoi4.Text + "','Conversationtest','Nghe_0" + dr_dethi.Text + "','0" + dr_dethi.Text + "')";
                                    ketnoi.executeQuery(sql_cauhoi);
                                }
                                else if (i == 5)
                                {
                                    sql_cauhoi = "insert into CAUHOI values('" + dr_dethi.Text + "_" + thutucau + "','','" + txt_cauhoi5.Text + "','Conversationtest','Nghe_0" + dr_dethi.Text + "','0" + dr_dethi.Text + "')";
                                    ketnoi.executeQuery(sql_cauhoi);
                                }

                                thutucau++;
                            }
                            catch
                            {
                                Response.Write("<script> alert('Câu hỏi: " + dr_dethi.Text + "_" + thutucau + " đã tồn tại') </script>");
                               
                            }
                        }
                       int thutucau1 = Int32.Parse(dr_socauhoi.Text);
                        // dap an 1
                        if (rd_TrueA1.Checked)
                        {
                            sql_dapanA = "insert into DAPAN values('" + dr_dethi.Text + "_" + thutucau1 + "_1','" + txt_A1.Text + "','True','" + dr_dethi.Text + "_" + thutucau1 + "')";

                            ketnoi.executeQuery(sql_dapanA);
                        }
                        else
                        {
                            sql_dapanA = "insert into DAPAN values('" + dr_dethi.Text + "_" + thutucau1 + "_1','" + txt_A1.Text + "','False','" + dr_dethi.Text + "_" + thutucau1 + "')";
                            ketnoi.executeQuery(sql_dapanA);
                        }
                        if (rd_TrueB1.Checked)
                        {
                            sql_dapanB = "insert into DAPAN values('" + dr_dethi.Text + "_" + thutucau1 + "_2','" + txt_B1.Text + "','True','" + dr_dethi.Text + "_" + thutucau1 + "')";
                            ketnoi.executeQuery(sql_dapanB);
                        }
                        else
                        {
                            sql_dapanB = "insert into DAPAN values('" + dr_dethi.Text + "_" + thutucau1 + "_2','" + txt_B1.Text + "','False','" + dr_dethi.Text + "_" + thutucau1 + "')";
                            ketnoi.executeQuery(sql_dapanB);
                        }
                        if (rd_TrueC1.Checked)
                        {
                            sql_dapanC = "insert into DAPAN values('" + dr_dethi.Text + "_" + thutucau1 + "_3','" + txt_C1.Text + "','True','" + dr_dethi.Text + "_" + thutucau1 + "')";
                            ketnoi.executeQuery(sql_dapanC);

                        }
                        else
                        {
                            sql_dapanC = "insert into DAPAN values('" + dr_dethi.Text + "_" + thutucau1 + "_3','" + txt_C1.Text + "','False','" + dr_dethi.Text + "_" + thutucau1 + "')";
                            ketnoi.executeQuery(sql_dapanC);

                        }

                        if (rd_TrueD1.Checked)
                        {
                            sql_dapanD = "insert into DAPAN values('" + dr_dethi.Text + "_" + thutucau1 + "_4','" + txt_D1.Text + "','True','" + dr_dethi.Text + "_" + thutucau1 + "')";
                            ketnoi.executeQuery(sql_dapanD);
                        }
                        else
                        {
                            sql_dapanD = "insert into DAPAN values('" + dr_dethi.Text + "_" + thutucau1 + "_4','" + txt_D1.Text + "','False','" + dr_dethi.Text + "_" + thutucau1 + "')";
                            ketnoi.executeQuery(sql_dapanD);
                        }

                        // dap an 2
                        try
                        {
                            if (rd_TrueA2.Checked)
                            {
                                sql_dapanA = "insert into DAPAN values('" + dr_dethi.Text + "_" + (thutucau1 + 1) + "_1','" + txt_A2.Text + "','True','" + dr_dethi.Text + "_" + (thutucau1 + 1) + "')";
                                ketnoi.executeQuery(sql_dapanA);
                            }
                            else
                            {
                                sql_dapanA = "insert into DAPAN values('" + dr_dethi.Text + "_" + (thutucau1 + 1) + "_1','" + txt_A2.Text + "','False','" + dr_dethi.Text + "_" + (thutucau1 + 1) + "')";
                                ketnoi.executeQuery(sql_dapanA);
                            }
                            if (rd_TrueB2.Checked)
                            {
                                sql_dapanB = "insert into DAPAN values('" + dr_dethi.Text + "_" + (thutucau1 + 1) + "_2','" + txt_B2.Text + "','True','" + dr_dethi.Text + "_" + (thutucau1 + 1) + "')";
                                ketnoi.executeQuery(sql_dapanB);
                            }
                            else
                            {
                                sql_dapanB = "insert into DAPAN values('" + dr_dethi.Text + "_" + (thutucau1 + 1) + "_2','" + txt_B2.Text + "','False','" + dr_dethi.Text + "_" + (thutucau1 + 1) + "')";
                                ketnoi.executeQuery(sql_dapanB);
                            }
                            if (rd_TrueC2.Checked)
                            {
                                sql_dapanC = "insert into DAPAN values('" + dr_dethi.Text + "_" + (thutucau1 + 1) + "_3','" + txt_C2.Text + "','True','" + dr_dethi.Text + "_" + (thutucau1 + 1) + "')";
                                ketnoi.executeQuery(sql_dapanC);

                            }
                            else
                            {
                                sql_dapanC = "insert into DAPAN values('" + dr_dethi.Text + "_" + (thutucau1 + 1) + "_3','" + txt_C2.Text + "','False','" + dr_dethi.Text + "_" + (thutucau1 + 1) + "')";
                                ketnoi.executeQuery(sql_dapanC);

                            }

                            if (rd_TrueD2.Checked)
                            {
                                sql_dapanD = "insert into DAPAN values('" + dr_dethi.Text + "_" + (thutucau1 + 1) + "_4','" + txt_D2.Text + "','True','" + dr_dethi.Text + "_" + (thutucau1 + 1) + "')";
                                ketnoi.executeQuery(sql_dapanD);
                            }
                            else
                            {
                                sql_dapanD = "insert into DAPAN values('" + dr_dethi.Text + "_" + (thutucau1 + 1) + "_4','" + txt_D2.Text + "','False','" + dr_dethi.Text + "_" + (thutucau1 + 1) + "')";
                                ketnoi.executeQuery(sql_dapanD);
                            }
                        }
                        catch { }

                        // dap an 3
                        try
                        {
                            if (rd_TrueA3.Checked)
                            {
                                sql_dapanA = "insert into DAPAN values('" + dr_dethi.Text + "_" + (thutucau1 + 2) + "_1','" + txt_A3.Text + "','True','" + dr_dethi.Text + "_" + (thutucau1 + 2) + "')";
                                ketnoi.executeQuery(sql_dapanA);
                            }
                            else
                            {
                                sql_dapanA = "insert into DAPAN values('" + dr_dethi.Text + "_" + (thutucau1 + 2) + "_1','" + txt_A3.Text + "','False','" + dr_dethi.Text + "_" + (thutucau1 + 2) + "')";
                                ketnoi.executeQuery(sql_dapanA);
                            }
                            if (rd_TrueB3.Checked)
                            {
                                sql_dapanB = "insert into DAPAN values('" + dr_dethi.Text + "_" + (thutucau1 + 2) + "_2','" + txt_B3.Text + "','True','" + dr_dethi.Text + "_" + (thutucau1 + 2) + "')";
                                ketnoi.executeQuery(sql_dapanB);
                            }
                            else
                            {
                                sql_dapanB = "insert into DAPAN values('" + dr_dethi.Text + "_" + (thutucau1 + 2) + "_2','" + txt_B3.Text + "','False','" + dr_dethi.Text + "_" + (thutucau1 + 2) + "')";
                                ketnoi.executeQuery(sql_dapanB);
                            }
                            if (rd_TrueC3.Checked)
                            {
                                sql_dapanC = "insert into DAPAN values('" + dr_dethi.Text + "_" + (thutucau1 + 2) + "_3','" + txt_C3.Text + "','True','" + dr_dethi.Text + "_" + (thutucau1 + 2) + "')";
                                ketnoi.executeQuery(sql_dapanC);

                            }
                            else
                            {
                                sql_dapanC = "insert into DAPAN values('" + dr_dethi.Text + "_" + (thutucau1 + 2) + "_3','" + txt_C3.Text + "','False','" + dr_dethi.Text + "_" + (thutucau1 + 2) + "')";
                                ketnoi.executeQuery(sql_dapanC);

                            }

                            if (rd_TrueD3.Checked)
                            {
                                sql_dapanD = "insert into DAPAN values('" + dr_dethi.Text + "_" + (thutucau1 + 2) + "_4','" + txt_D3.Text + "','True','" + dr_dethi.Text + "_" + (thutucau1 + 2) + "')";
                                ketnoi.executeQuery(sql_dapanD);
                            }
                            else
                            {
                                sql_dapanD = "insert into DAPAN values('" + dr_dethi.Text + "_" + (thutucau1 + 2) + "_4','" + txt_D3.Text + "','False','" + dr_dethi.Text + "_" + (thutucau1 + 2) + "')";
                                ketnoi.executeQuery(sql_dapanD);
                            }
                        }
                        catch { }
                        // dap an 4
                        try
                        {

                            if (rd_TrueA4.Checked)
                            {
                                sql_dapanA = "insert into DAPAN values('" + dr_dethi.Text + "_" + (thutucau1 + 3) + "_1','" + txt_A4.Text + "','True','" + dr_dethi.Text + "_" + (thutucau1 + 3) + "')";
                                ketnoi.executeQuery(sql_dapanA);
                            }
                            else
                            {
                                sql_dapanA = "insert into DAPAN values('" + dr_dethi.Text + "_" + (thutucau1 + 3) + "_1','" + txt_A1.Text + "','False','" + dr_dethi.Text + "_" + (thutucau1 + 3) + "')";
                                ketnoi.executeQuery(sql_dapanA);
                            }
                            if (rd_TrueB4.Checked)
                            {
                                sql_dapanB = "insert into DAPAN values('" + dr_dethi.Text + "_" + (thutucau1 + 3) + "_2','" + txt_B4.Text + "','True','" + dr_dethi.Text + "_" + (thutucau1 + 3) + "')";
                                ketnoi.executeQuery(sql_dapanB);
                            }
                            else
                            {
                                sql_dapanB = "insert into DAPAN values('" + dr_dethi.Text + "_" + (thutucau1 + 3) + "_2','" + txt_B4.Text + "','False','" + dr_dethi.Text + "_" + (thutucau1 + 3) + "')";
                                ketnoi.executeQuery(sql_dapanB);
                            }
                            if (rd_TrueC4.Checked)
                            {
                                sql_dapanC = "insert into DAPAN values('" + dr_dethi.Text + "_" + (thutucau1 + 3) + "_3','" + txt_C4.Text + "','True','" + dr_dethi.Text + "_" + (thutucau1 + 3) + "')";
                                ketnoi.executeQuery(sql_dapanC);

                            }
                            else
                            {
                                sql_dapanC = "insert into DAPAN values('" + dr_dethi.Text + "_" + (thutucau1 + 3) + "_3','" + txt_C4.Text + "','False','" + dr_dethi.Text + "_" + (thutucau1 + 3) + "')";
                                ketnoi.executeQuery(sql_dapanC);

                            }

                            if (rd_TrueD4.Checked)
                            {
                                sql_dapanD = "insert into DAPAN values('" + dr_dethi.Text + "_" + (thutucau1 + 3) + "_4','" + txt_D4.Text + "','True','" + dr_dethi.Text + "_" + (thutucau1 + 3) + "')";
                                ketnoi.executeQuery(sql_dapanD);
                            }
                            else
                            {
                                sql_dapanD = "insert into DAPAN values('" + dr_dethi.Text + "_" + (thutucau1 + 3) + "_4','" + txt_D4.Text + "','False','" + dr_dethi.Text + "_" + (thutucau1 + 3) + "')";
                                ketnoi.executeQuery(sql_dapanD);
                            }
                        }
                        catch { }
                        // dap an 5
                        try
                        {
                            if (rd_TrueA5.Checked)
                            {
                                sql_dapanA = "insert into DAPAN values('" + dr_dethi.Text + "_" + (thutucau1 + 4) + "_1','" + txt_A5.Text + "','True','" + dr_dethi.Text + "_" + (thutucau1 + 4) + "')";
                                ketnoi.executeQuery(sql_dapanA);
                            }
                            else
                            {
                                sql_dapanA = "insert into DAPAN values('" + dr_dethi.Text + "_" + (thutucau1 + 4) + "_1','" + txt_A5.Text + "','False','" + dr_dethi.Text + "_" + (thutucau1 + 4) + "')";
                                ketnoi.executeQuery(sql_dapanA);
                            }
                            if (rd_TrueB5.Checked)
                            {
                                sql_dapanB = "insert into DAPAN values('" + dr_dethi.Text + "_" + (thutucau1 + 4) + "_2','" + txt_B5.Text + "','True','" + dr_dethi.Text + "_" + (thutucau1 + 4) + "')";
                                ketnoi.executeQuery(sql_dapanB);
                            }
                            else
                            {
                                sql_dapanB = "insert into DAPAN values('" + dr_dethi.Text + "_" + (thutucau1 + 4) + "_2','" + txt_B5.Text + "','False','" + dr_dethi.Text + "_" + (thutucau1 + 4) + "')";
                                ketnoi.executeQuery(sql_dapanB);
                            }
                            if (rd_TrueC5.Checked)
                            {
                                sql_dapanC = "insert into DAPAN values('" + dr_dethi.Text + "_" + (thutucau1 + 4) + "_3','" + txt_C5.Text + "','True','" + dr_dethi.Text + "_" + (thutucau1 + 4) + "')";
                                ketnoi.executeQuery(sql_dapanC);

                            }
                            else
                            {
                                sql_dapanC = "insert into DAPAN values('" + dr_dethi.Text + "_" + (thutucau1 + 4) + "_3','" + txt_C5.Text + "','False','" + dr_dethi.Text + "_" + (thutucau1 + 4) + "')";
                                ketnoi.executeQuery(sql_dapanC);

                            }

                            if (rd_TrueD5.Checked)
                            {
                                sql_dapanD = "insert into DAPAN values('" + dr_dethi.Text + "_" + (thutucau1 + 4) + "_4','" + txt_D5.Text + "','True','" + dr_dethi.Text + "_" + (thutucau1 + 4) + "')";
                                ketnoi.executeQuery(sql_dapanD);
                            }
                            else
                            {
                                sql_dapanD = "insert into DAPAN values('" + dr_dethi.Text + "_" + (thutucau1 + 4) + "_4','" + txt_D5.Text + "','False','" + dr_dethi.Text + "_" + (thutucau1 + 4) + "')";
                                ketnoi.executeQuery(sql_dapanD);
                            }
                        }
                        catch { }
                        Response.Write("<script>alert('Thêm câu hỏi thành công!'); </script>");
                        
                        
                    }
                    catch
                    {
                        Response.Write("<script>alert('Thêm câu hỏi thành công!'); </script>");
                    }
                
                    }
                }
            }
        

        else if (dr_noidung.Text.Trim() == "Talk")
        {
            string sql_dethi = "select * from DETHI where Made='0" + dr_dethi.Text + "_Talk'";
            DataTable tb_dethi = ketnoi.getData(sql_dethi);
            if (tb_dethi.Rows.Count == 0)
            {
                string sql_insert = "insert into DETHI values('0" + dr_dethi.Text + "_Talk',N'Đề 0" + dr_dethi.Text + "',getdate(),NULL,'Conversation')";
                ketnoi.executeQuery(sql_insert);
            }
            else if (fileNghe.Visible == true && cauhoi.Visible == false)
            {
                HttpFileCollection fileCollection = Request.Files;
                for (int i = 0; i < fileCollection.Count; i++)
                {
                    HttpPostedFile uploadfile = fileCollection[i];
                    string fileName = Path.GetFileName(uploadfile.FileName);
                    if (uploadfile.ContentLength > 0)
                    {
                        try
                        {
                            string kiemtra = " select * from FILES where IDFile='Nghe_Talk_0" + dr_dethi.Text + "'";
                            DataTable tb_kiemtra = ketnoi.getData(kiemtra);
                            if (tb_kiemtra.Rows.Count > 0)
                            {
                                Response.Write("<script>alert('File nghe đã tồn tại!'); </script>");
                                fileNghe.Visible = false;
                                soluongcauhoi.Visible = true;
                                causo.Visible = true;
                                id_caubatdau.Visible = true;
                                noidungdoanvan.Visible = false;
                                cauhoi.Visible = false;
                                dapanA.Visible = false;
                                dapanB.Visible = false;
                                dapanC.Visible = false;


                            }
                            else
                            {
                                uploadfile.SaveAs(Server.MapPath("~/audio/") + fileName);
                                string sql = "insert into FILES values('Nghe_Talk_0" + dr_dethi.Text + "',N'" + fileName + "','" + dr_noidung.Text + "',NULL)";
                                ketnoi.executeQuery(sql);
                                Response.Write("<script>alert('Upload file Nghe thành công!'); </script>");
                                fileNghe.Visible = false;
                                noidungdoanvan.Visible = false;
                                soluongcauhoi.Visible = true;
                                causo.Visible = true;
                                id_caubatdau.Visible = true;

                            }
                        }
                        catch
                        {
                            Response.Write("<script>alert('Upload file Nghe không thành công!'); </script>");
                        }

                    }
                }
            }

            else
            {
                fileNghe.Visible = false;
                soluongcauhoi.Visible = true;
                causo.Visible = true;
                id_caubatdau.Visible = true;
                noidungdoanvan.Visible = false;



                    string sql_dapanA;
                    string sql_dapanB;
                    string sql_dapanC;
                    string sql_dapanD;

                    int soluongcau = Int32.Parse(dr_soluong.Text);
                    int thutucau1 = Int32.Parse(dr_socauhoi.Text);

                    for (int i = 1; i <= soluongcau; i++)
                    {

                        try
                        {
                            string sql_cauhoi;
                            string noidung;
                            if (i == 1)
                                noidung = txt_doanvan.Text;
                            else
                                noidung = "";
                            if (i == 1)
                            {
                                sql_cauhoi = "insert into CAUHOI values('" + dr_dethi.Text + "_Talk_" + thutucau1 + "','" + noidung + "','" + txt_cauhoi1.Text + "','Talk','Nghe_0" + dr_dethi.Text + "','0" + dr_dethi.Text + "_Talk')";
                                ketnoi.executeQuery(sql_cauhoi);
                            }
                            else if (i == 2)
                            {
                                sql_cauhoi = "insert into CAUHOI values('" + dr_dethi.Text + "_Talk_" + thutucau1 + "','','" + txt_cauhoi2.Text + "','Talk','Nghe_0" + dr_dethi.Text + "','0" + dr_dethi.Text + "_Talk')";
                                ketnoi.executeQuery(sql_cauhoi);
                            }
                            else if (i == 3)
                            {
                                sql_cauhoi = "insert into CAUHOI values('" + dr_dethi.Text + "_Talk_" + thutucau1 + "','','" + txt_cauhoi3.Text + "','Talk','Nghe_0" + dr_dethi.Text + "','0" + dr_dethi.Text + "_Talk')";
                                ketnoi.executeQuery(sql_cauhoi);
                            }
                            else if (i == 4)
                            {
                                sql_cauhoi = "insert into CAUHOI values('" + dr_dethi.Text + "_Talk_" + thutucau1 + "','','" + txt_cauhoi4.Text + "',Talk','Nghe_0" + dr_dethi.Text + "','0" + dr_dethi.Text + "_Talk')";
                                ketnoi.executeQuery(sql_cauhoi);
                            }
                            else if (i == 5)
                            {
                                sql_cauhoi = "insert into CAUHOI values('" + dr_dethi.Text + "_Talk_" + thutucau1 + "','','" + txt_cauhoi5.Text + "','Talk','Nghe_0" + dr_dethi.Text + "','0" + dr_dethi.Text + "_Talk')";
                                ketnoi.executeQuery(sql_cauhoi);
                            }


                            thutucau1++;
                        }
                        catch
                        {
                            Response.Write("<script> alert('Câu hỏi: " + dr_dethi.Text + "_Talk_" + thutucau1 + " đã tồn tại') </script>");
                            break;
                        }
                    }
                   int thutucau = Int32.Parse(dr_socauhoi.Text);
                    // dap an 1
                    if (rd_TrueA1.Checked)
                    {
                        sql_dapanA = "insert into DAPAN values('" + dr_dethi.Text + "_Talk_" + thutucau + "_1','"+txt_A1.Text+"','True','" + dr_dethi.Text + "_Talk_" + thutucau + "')";
                        ketnoi.executeQuery(sql_dapanA);
                    }
                    else
                    {
                        sql_dapanA = "insert into DAPAN values('" + dr_dethi.Text + "_Talk_" + thutucau + "_1','" + txt_A1.Text + "','False','" + dr_dethi.Text + "_Talk_" + thutucau + "')";
                        ketnoi.executeQuery(sql_dapanA);
                    }
                    if (rd_TrueB1.Checked)
                    {
                        sql_dapanB = "insert into DAPAN values('" + dr_dethi.Text + "_Talk_" + thutucau + "_2','" + txt_B1.Text + "','True','" + dr_dethi.Text + "_Talk_" + thutucau + "')";
                        ketnoi.executeQuery(sql_dapanB);
                    }
                    else
                    {
                        sql_dapanB = "insert into DAPAN values('" + dr_dethi.Text + "_Talk_" + thutucau + "_2','" + txt_B1.Text + "','False','" + dr_dethi.Text + "_Talk_" + thutucau + "')";
                        ketnoi.executeQuery(sql_dapanB);
                    }
                    if (rd_TrueC1.Checked)
                    {
                        sql_dapanC = "insert into DAPAN values('" + dr_dethi.Text + "_Talk_" + thutucau + "_3','" + txt_C1.Text + "','True','" + dr_dethi.Text + "_Talk_" + thutucau + "')";
                        ketnoi.executeQuery(sql_dapanC);

                    }
                    else
                    {
                        sql_dapanC = "insert into DAPAN values('" + dr_dethi.Text + "_Talk_" + thutucau + "_3','" + txt_C1.Text + "','False','" + dr_dethi.Text + "_Talk_" + thutucau + "')";
                        ketnoi.executeQuery(sql_dapanC);

                    }

                    if (rd_TrueD1.Checked)
                    {
                        sql_dapanD = "insert into DAPAN values('" + dr_dethi.Text + "_Talk_" + thutucau + "_4','" + txt_D1.Text + "','True','" + dr_dethi.Text + "_Talk_" + thutucau + "')";
                        ketnoi.executeQuery(sql_dapanD);
                    }
                    else
                    {
                        sql_dapanD = "insert into DAPAN values('" + dr_dethi.Text + "_Talk_" + thutucau + "_4','" + txt_D1.Text + "','False','" + dr_dethi.Text + "_Talk_" + thutucau + "')";
                        ketnoi.executeQuery(sql_dapanD);
                    }

                    // dap an 2

                    if (rd_TrueA2.Checked)
                    {
                        sql_dapanA = "insert into DAPAN values('" + dr_dethi.Text + "_Talk_" + (thutucau + 1) + "_1','" + txt_A2.Text + "','True','" + dr_dethi.Text + "_Talk_" + (thutucau + 1) + "')";
                        ketnoi.executeQuery(sql_dapanA);
                    }
                    else
                    {
                        sql_dapanA = "insert into DAPAN values('" + dr_dethi.Text + "_Talk_" + (thutucau + 1) + "_1','" + txt_A2.Text + "','False','" + dr_dethi.Text + "_Talk_" + (thutucau + 1) + "')";
                        ketnoi.executeQuery(sql_dapanA);
                    }
                    if (rd_TrueB2.Checked)
                    {
                        sql_dapanB = "insert into DAPAN values('" + dr_dethi.Text + "_Talk_" + (thutucau + 1) + "_2','" + txt_B2.Text + "','True','" + dr_dethi.Text + "_Talk_" + (thutucau + 1) + "')";
                        ketnoi.executeQuery(sql_dapanB);
                    }
                    else
                    {
                        sql_dapanB = "insert into DAPAN values('" + dr_dethi.Text + "_Talk_" + (thutucau + 1) + "_2','" + txt_B2.Text + "','False','" + dr_dethi.Text + "_Talk_" + (thutucau + 1) + "')";
                        ketnoi.executeQuery(sql_dapanB);
                    }
                    if (rd_TrueC2.Checked)
                    {
                        sql_dapanC = "insert into DAPAN values('" + dr_dethi.Text + "_Talk_" + (thutucau + 1) + "_3','" + txt_C2.Text + "','True','" + dr_dethi.Text + "_Talk_" + (thutucau + 1) + "')";
                        ketnoi.executeQuery(sql_dapanC);

                    }
                    else
                    {
                        sql_dapanC = "insert into DAPAN values('" + dr_dethi.Text + "_Talk_" + (thutucau + 1) + "_3','" + txt_C2.Text + "','False','" + dr_dethi.Text + "_Talk_" + (thutucau + 1) + "')";
                        ketnoi.executeQuery(sql_dapanC);

                    }

                    if (rd_TrueD2.Checked)
                    {
                        sql_dapanD = "insert into DAPAN values('" + dr_dethi.Text + "_Talk_" + (thutucau + 1) + "_4','" + txt_D2.Text + "','True','" + dr_dethi.Text + "_Talk_" + (thutucau + 1) + "')";
                        ketnoi.executeQuery(sql_dapanD);
                    }
                    else
                    {
                        sql_dapanD = "insert into DAPAN values('" + dr_dethi.Text + "_Talk_" + (thutucau + 1) + "_4','" + txt_C2.Text + "','False','" + dr_dethi.Text + "_Talk_" + (thutucau + 1) + "')";
                        ketnoi.executeQuery(sql_dapanD);
                    }

                    // dap an 3

                    if (rd_TrueA3.Checked)
                    {
                        sql_dapanA = "insert into DAPAN values('" + dr_dethi.Text + "_Talk_" + (thutucau + 2) + "_1','" + txt_A3.Text + "','True','" + dr_dethi.Text + "_Talk_" + (thutucau + 2) + "')";
                        ketnoi.executeQuery(sql_dapanA);
                    }
                    else
                    {
                        sql_dapanA = "insert into DAPAN values('" + dr_dethi.Text + "_Talk_" + (thutucau + 2) + "_1','" + txt_A3.Text + "','False','" + dr_dethi.Text + "_Talk_" + (thutucau + 2) + "')";
                        ketnoi.executeQuery(sql_dapanA);
                    }
                    if (rd_TrueB3.Checked)
                    {
                        sql_dapanB = "insert into DAPAN values('" + dr_dethi.Text + "_Talk_" + (thutucau + 2) + "_2''" + txt_B3.Text + "','True','" + dr_dethi.Text + "_Talk_" + (thutucau + 2) + "')";
                        ketnoi.executeQuery(sql_dapanB);
                    }
                    else
                    {
                        sql_dapanB = "insert into DAPAN values('" + dr_dethi.Text + "_Talk_" + (thutucau + 2) + "_2','" + txt_B3.Text + "','False','" + dr_dethi.Text + "_Talk_" + (thutucau + 2) + "')";
                        ketnoi.executeQuery(sql_dapanB);
                    }
                    if (rd_TrueC3.Checked)
                    {
                        sql_dapanC = "insert into DAPAN values('" + dr_dethi.Text + "_Talk_" + (thutucau + 2) + "_3','" + txt_C3.Text + "','True','" + dr_dethi.Text + "_Talk_" + (thutucau + 2) + "')";
                        ketnoi.executeQuery(sql_dapanC);

                    }
                    else
                    {
                        sql_dapanC = "insert into DAPAN values('" + dr_dethi.Text + "_Talk_" + (thutucau + 2) + "_3','" + txt_C3.Text + "','False','" + dr_dethi.Text + "_Talk_" + (thutucau + 2) + "')";
                        ketnoi.executeQuery(sql_dapanC);

                    }

                    if (rd_TrueD3.Checked)
                    {
                        sql_dapanD = "insert into DAPAN values('" + dr_dethi.Text + "_Talk_" + (thutucau + 2) + "_4','" + txt_D3.Text + "','True','" + dr_dethi.Text + "_Talk_" + (thutucau + 2) + "')";
                        ketnoi.executeQuery(sql_dapanD);
                    }
                    else
                    {
                        sql_dapanD = "insert into DAPAN values('" + dr_dethi.Text + "_Talk_" + (thutucau + 2) + "_4','" + txt_D3.Text + "','False','" + dr_dethi.Text + "_Talk_" + (thutucau + 2) + "')";
                        ketnoi.executeQuery(sql_dapanD);
                    }

                    // dap an 4

                    if (rd_TrueA4.Checked)
                    {
                        sql_dapanA = "insert into DAPAN values('" + dr_dethi.Text + "_Talk_" + (thutucau + 3) + "_1','" + txt_A4.Text + "','True','" + dr_dethi.Text + "_Talk_" + (thutucau + 3) + "')";
                        ketnoi.executeQuery(sql_dapanA);
                    }
                    else
                    {
                        sql_dapanA = "insert into DAPAN values('" + dr_dethi.Text + "_Talk_" + (thutucau + 3) + "_1','" + txt_A4.Text + "','False','" + dr_dethi.Text + "_Talk_" + (thutucau + 3) + "')";
                        ketnoi.executeQuery(sql_dapanA);
                    }
                    if (rd_TrueB4.Checked)
                    {
                        sql_dapanB = "insert into DAPAN values('" + dr_dethi.Text + "_Talk_" + (thutucau + 3) + "_2','" + txt_B4.Text + "','True','" + dr_dethi.Text + "_Talk_" + (thutucau + 3) + "')";
                        ketnoi.executeQuery(sql_dapanB);
                    }
                    else
                    {
                        sql_dapanB = "insert into DAPAN values('" + dr_dethi.Text + "_Talk_" + (thutucau + 3) + "_2','" + txt_B4.Text + "','False','" + dr_dethi.Text + "_Talk_" + (thutucau + 3) + "')";
                        ketnoi.executeQuery(sql_dapanB);
                    }
                    if (rd_TrueC4.Checked)
                    {
                        sql_dapanC = "insert into DAPAN values('" + dr_dethi.Text + "_Talk_" + (thutucau + 3) + "_3','" + txt_C4.Text + "','True','" + dr_dethi.Text + "_Talk_" + (thutucau + 3) + "')";
                        ketnoi.executeQuery(sql_dapanC);

                    }
                    else
                    {
                        sql_dapanC = "insert into DAPAN values('" + dr_dethi.Text + "_Talk_" + (thutucau + 3) + "_3','" + txt_C4.Text + "','False','" + dr_dethi.Text + "_Talk_" + (thutucau + 3) + "')";
                        ketnoi.executeQuery(sql_dapanC);

                    }

                    if (rd_TrueD4.Checked)
                    {
                        sql_dapanD = "insert into DAPAN values('" + dr_dethi.Text + "_Talk_" + (thutucau + 3) + "_4','" + txt_D4.Text + "','True','" + dr_dethi.Text + "_Talk_" + (thutucau + 3) + "')";
                        ketnoi.executeQuery(sql_dapanD);
                    }
                    else
                    {
                        sql_dapanD = "insert into DAPAN values('" + dr_dethi.Text + "_Talk_" + (thutucau + 3) + "_4','" + txt_D4.Text + "','False','" + dr_dethi.Text + "_Talk_" + (thutucau + 3) + "')";
                        ketnoi.executeQuery(sql_dapanD);
                    }

                    // dap an 5

                    if (rd_TrueA5.Checked)
                    {
                        sql_dapanA = "insert into DAPAN values('" + dr_dethi.Text + "_Talk_" + (thutucau + 4) + "_1','" + txt_A5.Text + "','True','" + dr_dethi.Text + "_Talk_" + (thutucau + 4) + "')";
                        ketnoi.executeQuery(sql_dapanA);
                    }
                    else
                    {
                        sql_dapanA = "insert into DAPAN values('" + dr_dethi.Text + "_Talk_" + (thutucau + 4) + "_1','" + txt_A5.Text + "','False','" + dr_dethi.Text + "_Talk_" + (thutucau + 4) + "')";
                        ketnoi.executeQuery(sql_dapanA);
                    }
                    if (rd_TrueB5.Checked)
                    {
                        sql_dapanB = "insert into DAPAN values('" + dr_dethi.Text + "_Talk_" + (thutucau + 4) + "_2','" + txt_B5.Text + "','True','" + dr_dethi.Text + "_Talk_" + (thutucau + 4) + "')";
                        ketnoi.executeQuery(sql_dapanB);
                    }
                    else
                    {
                        sql_dapanB = "insert into DAPAN values('" + dr_dethi.Text + "_Talk_" + (thutucau + 4) + "_2','" + txt_B5.Text + "','False','" + dr_dethi.Text + "_Talk_" + (thutucau + 4) + "')";
                        ketnoi.executeQuery(sql_dapanB);
                    }
                    if (rd_TrueC5.Checked)
                    {
                        sql_dapanC = "insert into DAPAN values('" + dr_dethi.Text + "_Talk_" + (thutucau + 4) + "_3','" + txt_C5.Text + "','True','" + dr_dethi.Text + "_Talk_" + (thutucau + 4) + "')";
                        ketnoi.executeQuery(sql_dapanC);

                    }
                    else
                    {
                        sql_dapanC = "insert into DAPAN values('" + dr_dethi.Text + "_Talk_" + (thutucau + 4) + "_3','" + txt_C5.Text + "','False','" + dr_dethi.Text + "_Talk_" + (thutucau + 4) + "')";
                        ketnoi.executeQuery(sql_dapanC);

                    }

                    if (rd_TrueD5.Checked)
                    {
                        sql_dapanD = "insert into DAPAN values('" + dr_dethi.Text + "_Talk_" + (thutucau + 4) + "_4','" + txt_D5.Text + "','True','" + dr_dethi.Text + "_Talk_" + (thutucau + 4) + "')";
                        ketnoi.executeQuery(sql_dapanD);
                    }
                    else
                    {
                        sql_dapanD = "insert into DAPAN values('" + dr_dethi.Text + "_Talk_" + (thutucau + 4) + "_4','" + txt_D5.Text + "','False','" + dr_dethi.Text + "_Talk_" + (thutucau + 4) + "')";
                        ketnoi.executeQuery(sql_dapanD);
                    }

                    Response.Write("<script>alert('Thêm câu hỏi thành công!'); </script>");
               
            }
        }
        else if (dr_noidung.Text.Trim() == "Talktest")
        {
            string sql_dethi;
            if (dr_capdo.Text == "Tonghop" || dr_capdo.Text == "0")

                sql_dethi = "select * from DETHI where Made='0" + dr_dethi.Text + "'";
            else
                sql_dethi = "select * from DETHI where Made='0" + dr_dethi.Text + "_" + dr_capdo.Text + "'";
            DataTable tb_dethi = ketnoi.getData(sql_dethi);
            if (tb_dethi.Rows.Count == 0)
            {
                string sql_insert;
                if (dr_capdo.Text == "Tonghop" || dr_capdo.Text == "0")
                {
                    sql_insert = "insert into DETHI values('0" + dr_dethi.Text + "',N'Đề 0" + dr_dethi.Text + "',getdate(),NULL,'" + dr_capdo.Text + "')";
                }
                else
                {
                    sql_insert = "insert into DETHI values('0" + dr_dethi.Text + "_" + dr_capdo.Text + "',N'Đề 0" + dr_dethi.Text + "',getdate(),NULL,'" + dr_capdo.Text + "')";
                }
                ketnoi.executeQuery(sql_insert);
            }
            else
            {

                if (fileNghe.Visible == true && cauhoi.Visible == false)
                {
                    HttpFileCollection fileCollection = Request.Files;
                    for (int i = 0; i < fileCollection.Count; i++)
                    {
                        HttpPostedFile uploadfile = fileCollection[i];
                        string fileName = Path.GetFileName(uploadfile.FileName);
                        if (uploadfile.ContentLength > 0)
                        {
                            try
                            {
                                string kiemtra = " select * from FILES where IDFile='Nghe_0" + dr_dethi.Text + "'";
                                DataTable tb_kiemtra = ketnoi.getData(kiemtra);
                                if (tb_kiemtra.Rows.Count > 0)
                                {
                                    Response.Write("<script>alert('File nghe đã tồn tại!'); </script>");
                                    fileNghe.Visible = false;
                                    soluongcauhoi.Visible = true;
                                    causo.Visible = true;
                                    id_caubatdau.Visible = true;
                                    noidungdoanvan.Visible = false;
                                    cauhoi.Visible = false;
                                    dapanA.Visible = false;
                                    dapanB.Visible = false;
                                    dapanC.Visible = false;

                                }
                                else
                                {
                                    uploadfile.SaveAs(Server.MapPath("~/audio/") + fileName);
                                    string sql = "insert into FILES values('Nghe_0" + dr_dethi.Text + "',N'" + fileName + "','" + dr_noidung.Text + "',NULL)";
                                    ketnoi.executeQuery(sql);
                                    Response.Write("<script>alert('Upload file Nghe thành công!'); </script>");
                                    fileNghe.Visible = false;
                                    soluongcauhoi.Visible = true;
                                    causo.Visible = true;
                                    id_caubatdau.Visible = true;
                                    noidungdoanvan.Visible = false;
                                    cauhoi.Visible = false;
                                    dapanA.Visible = false;
                                    dapanB.Visible = false;
                                    dapanC.Visible = false;

                                }
                            }
                            catch
                            {
                                Response.Write("<script>alert('Upload file Nghe không thành công!'); </script>");
                            }

                        }
                    }
                }

                else
                {
                    fileNghe.Visible = false;
                    soluongcauhoi.Visible = true;
                    causo.Visible = true;
                    id_caubatdau.Visible = true;
                    noidungdoanvan.Visible = false;


                    try
                    {


                        string sql_dapanA;
                        string sql_dapanB;
                        string sql_dapanC;
                        string sql_dapanD;

                        int soluongcau = Int32.Parse(dr_soluong.Text);
                        int thutucau = Int32.Parse(dr_socauhoi.Text);

                        for (int i = 1; i <= soluongcau; i++)
                        {

                            try
                            {
                                string sql_cauhoi;
                                string noidung;
                                if (i == 1)
                                    noidung = txt_doanvan.Text;
                                else
                                    noidung = "";
                                if (i == 1)
                                {
                                    sql_cauhoi = "insert into CAUHOI values('" + dr_dethi.Text + "_" + thutucau + "','" + noidung + "','" + txt_cauhoi1.Text + "','Talktest','Nghe_0" + dr_dethi.Text + "','0" + dr_dethi.Text + "')";
                                    ketnoi.executeQuery(sql_cauhoi);
                                }
                                else if (i == 2)
                                {
                                    sql_cauhoi = "insert into CAUHOI values('" + dr_dethi.Text + "_" + thutucau + "','','" + txt_cauhoi2.Text + "','Talktest','Nghe_0" + dr_dethi.Text + "','0" + dr_dethi.Text + "')";
                                    ketnoi.executeQuery(sql_cauhoi);
                                }
                                else if (i == 3)
                                {
                                    sql_cauhoi = "insert into CAUHOI values('" + dr_dethi.Text + "_" + thutucau + "','','" + txt_cauhoi3.Text + "','Talktest','Nghe_0" + dr_dethi.Text + "','0" + dr_dethi.Text + "')";
                                    ketnoi.executeQuery(sql_cauhoi);
                                }
                                else if (i == 4)
                                {
                                    sql_cauhoi = "insert into CAUHOI values('" + dr_dethi.Text + "_" + thutucau + "','','" + txt_cauhoi4.Text + "','Talktest','Nghe_0" + dr_dethi.Text + "','0" + dr_dethi.Text + "')";
                                    ketnoi.executeQuery(sql_cauhoi);
                                }
                                else if (i == 5)
                                {
                                    sql_cauhoi = "insert into CAUHOI values('" + dr_dethi.Text + "_" + thutucau + "','','" + txt_cauhoi5.Text + "','Talktest','Nghe_0" + dr_dethi.Text + "','0" + dr_dethi.Text + "')";
                                    ketnoi.executeQuery(sql_cauhoi);
                                }

                                thutucau++;
                            }
                            catch
                            {
                                Response.Write("<script> alert('Câu hỏi: " + dr_dethi.Text + "_" + thutucau + " đã tồn tại') </script>");
                                break;
                            }
                        }
                       int thutucau1 = Int32.Parse(dr_socauhoi.Text);
                        // dap an 1
                         if (rd_TrueA1.Checked)
                        {
                            sql_dapanA = "insert into DAPAN values('" + dr_dethi.Text + "_Conver_" + thutucau1 + "_1','" + txt_A1.Text + "','True','" + dr_dethi.Text + "_" + thutucau1 + "')";

                            ketnoi.executeQuery(sql_dapanA);
                        }
                        else
                        {
                            sql_dapanA = "insert into DAPAN values('" + dr_dethi.Text + "_Conver_" + thutucau1 + "_1','" + txt_A1.Text + "','False','" + dr_dethi.Text + "_" + thutucau1 + "')";
                            ketnoi.executeQuery(sql_dapanA);
                        }
                        if (rd_TrueB1.Checked)
                        {
                            sql_dapanB = "insert into DAPAN values('" + dr_dethi.Text + "_" + thutucau1 + "_2','" + txt_B1.Text + "','True','" + dr_dethi.Text + "_" + thutucau1 + "')";
                            ketnoi.executeQuery(sql_dapanB);
                        }
                        else
                        {
                            sql_dapanB = "insert into DAPAN values('" + dr_dethi.Text + "_" + thutucau1 + "_2','" + txt_B1.Text + "','False','" + dr_dethi.Text + "_" + thutucau1 + "')";
                            ketnoi.executeQuery(sql_dapanB);
                        }
                        if (rd_TrueC1.Checked)
                        {
                            sql_dapanC = "insert into DAPAN values('" + dr_dethi.Text + "_" + thutucau1 + "_3','" + txt_C1.Text + "','True','" + dr_dethi.Text + "_" + thutucau1 + "')";
                            ketnoi.executeQuery(sql_dapanC);

                        }
                        else
                        {
                            sql_dapanC = "insert into DAPAN values('" + dr_dethi.Text + "_" + thutucau1 + "_3','" + txt_C1.Text + "','False','" + dr_dethi.Text + "_" + thutucau1 + "')";
                            ketnoi.executeQuery(sql_dapanC);

                        }

                        if (rd_TrueD1.Checked)
                        {
                            sql_dapanD = "insert into DAPAN values('" + dr_dethi.Text + "_" + thutucau1 + "_4','" + txt_D1.Text + "','True','" + dr_dethi.Text + "_" + thutucau1 + "')";
                            ketnoi.executeQuery(sql_dapanD);
                        }
                        else
                        {
                            sql_dapanD = "insert into DAPAN values('" + dr_dethi.Text + "_" + thutucau1 + "_4','" + txt_D1.Text + "','False','" + dr_dethi.Text + "_" + thutucau1 + "')";
                            ketnoi.executeQuery(sql_dapanD);
                        }

                        // dap an 2
                        try
                        {
                            if (rd_TrueA2.Checked)
                            {
                                sql_dapanA = "insert into DAPAN values('" + dr_dethi.Text + "_" + (thutucau1 + 1) + "_1','" + txt_A2.Text + "','True','" + dr_dethi.Text + "_" + (thutucau1 + 1) + "')";
                                ketnoi.executeQuery(sql_dapanA);
                            }
                            else
                            {
                                sql_dapanA = "insert into DAPAN values('" + dr_dethi.Text + "_" + (thutucau1 + 1) + "_1','" + txt_A2.Text + "','False','" + dr_dethi.Text + "_" + (thutucau1 + 1) + "')";
                                ketnoi.executeQuery(sql_dapanA);
                            }
                            if (rd_TrueB2.Checked)
                            {
                                sql_dapanB = "insert into DAPAN values('" + dr_dethi.Text + "_" + (thutucau1 + 1) + "_2','" + txt_B2.Text + "','True','" + dr_dethi.Text + "_" + (thutucau1 + 1) + "')";
                                ketnoi.executeQuery(sql_dapanB);
                            }
                            else
                            {
                                sql_dapanB = "insert into DAPAN values('" + dr_dethi.Text + "_" + (thutucau1 + 1) + "_2','" + txt_B2.Text + "','False','" + dr_dethi.Text + "_" + (thutucau1 + 1) + "')";
                                ketnoi.executeQuery(sql_dapanB);
                            }
                            if (rd_TrueC2.Checked)
                            {
                                sql_dapanC = "insert into DAPAN values('" + dr_dethi.Text + "_" + (thutucau1 + 1) + "_3','" + txt_C2.Text + "','True','" + dr_dethi.Text + "_" + (thutucau1 + 1) + "')";
                                ketnoi.executeQuery(sql_dapanC);

                            }
                            else
                            {
                                sql_dapanC = "insert into DAPAN values('" + dr_dethi.Text + "_" + (thutucau1 + 1) + "_3','" + txt_C2.Text + "','False','" + dr_dethi.Text + "_" + (thutucau1 + 1) + "')";
                                ketnoi.executeQuery(sql_dapanC);

                            }

                            if (rd_TrueD2.Checked)
                            {
                                sql_dapanD = "insert into DAPAN values('" + dr_dethi.Text + "_" + (thutucau1 + 1) + "_4','" + txt_D2.Text + "','True','" + dr_dethi.Text + "_" + (thutucau1 + 1) + "')";
                                ketnoi.executeQuery(sql_dapanD);
                            }
                            else
                            {
                                sql_dapanD = "insert into DAPAN values('" + dr_dethi.Text + "_" + (thutucau1 + 1) + "_4','" + txt_D2.Text + "','False','" + dr_dethi.Text + "_" + (thutucau1 + 1) + "')";
                                ketnoi.executeQuery(sql_dapanD);
                            }
                        }
                        catch { }

                        // dap an 3
                        try
                        {
                            if (rd_TrueA3.Checked)
                            {
                                sql_dapanA = "insert into DAPAN values('" + dr_dethi.Text + "_" + (thutucau1 + 2) + "_1','" + txt_A3.Text + "','True','" + dr_dethi.Text + "_" + (thutucau1 + 2) + "')";
                                ketnoi.executeQuery(sql_dapanA);
                            }
                            else
                            {
                                sql_dapanA = "insert into DAPAN values('" + dr_dethi.Text + "_" + (thutucau1 + 2) + "_1','" + txt_A3.Text + "','False','" + dr_dethi.Text + "_" + (thutucau1 + 2) + "')";
                                ketnoi.executeQuery(sql_dapanA);
                            }
                            if (rd_TrueB3.Checked)
                            {
                                sql_dapanB = "insert into DAPAN values('" + dr_dethi.Text + "_" + (thutucau1 + 2) + "_2','" + txt_B3.Text + "','True','" + dr_dethi.Text + "_" + (thutucau1 + 2) + "')";
                                ketnoi.executeQuery(sql_dapanB);
                            }
                            else
                            {
                                sql_dapanB = "insert into DAPAN values('" + dr_dethi.Text + "_" + (thutucau1 + 2) + "_2','" + txt_B3.Text + "','False','" + dr_dethi.Text + "_" + (thutucau1 + 2) + "')";
                                ketnoi.executeQuery(sql_dapanB);
                            }
                            if (rd_TrueC3.Checked)
                            {
                                sql_dapanC = "insert into DAPAN values('" + dr_dethi.Text + "_" + (thutucau1 + 2) + "_3','" + txt_C3.Text + "','True','" + dr_dethi.Text + "_" + (thutucau1 + 2) + "')";
                                ketnoi.executeQuery(sql_dapanC);

                            }
                            else
                            {
                                sql_dapanC = "insert into DAPAN values('" + dr_dethi.Text + "_" + (thutucau1 + 2) + "_3','" + txt_C3.Text + "','False','" + dr_dethi.Text + "_" + (thutucau1 + 2) + "')";
                                ketnoi.executeQuery(sql_dapanC);

                            }

                            if (rd_TrueD3.Checked)
                            {
                                sql_dapanD = "insert into DAPAN values('" + dr_dethi.Text + "_" + (thutucau1 + 2) + "_4','" + txt_D3.Text + "','True','" + dr_dethi.Text + "_" + (thutucau1 + 2) + "')";
                                ketnoi.executeQuery(sql_dapanD);
                            }
                            else
                            {
                                sql_dapanD = "insert into DAPAN values('" + dr_dethi.Text + "_" + (thutucau1 + 2) + "_4','" + txt_D3.Text + "','False','" + dr_dethi.Text + "_" + (thutucau1 + 2) + "')";
                                ketnoi.executeQuery(sql_dapanD);
                            }
                        }
                        catch { }
                        // dap an 4
                        try
                        {

                            if (rd_TrueA4.Checked)
                            {
                                sql_dapanA = "insert into DAPAN values('" + dr_dethi.Text + "_" + (thutucau1 + 3) + "_1','" + txt_A4.Text + "','True','" + dr_dethi.Text + "_" + (thutucau1 + 3) + "')";
                                ketnoi.executeQuery(sql_dapanA);
                            }
                            else
                            {
                                sql_dapanA = "insert into DAPAN values('" + dr_dethi.Text + "_" + (thutucau1 + 3) + "_1','" + txt_A1.Text + "','False','" + dr_dethi.Text + "_" + (thutucau1 + 3) + "')";
                                ketnoi.executeQuery(sql_dapanA);
                            }
                            if (rd_TrueB4.Checked)
                            {
                                sql_dapanB = "insert into DAPAN values('" + dr_dethi.Text + "_" + (thutucau1 + 3) + "_2','" + txt_B4.Text + "','True','" + dr_dethi.Text + "_" + (thutucau1 + 3) + "')";
                                ketnoi.executeQuery(sql_dapanB);
                            }
                            else
                            {
                                sql_dapanB = "insert into DAPAN values('" + dr_dethi.Text + "_" + (thutucau1 + 3) + "_2','" + txt_B4.Text + "','False','" + dr_dethi.Text + "_" + (thutucau1 + 3) + "')";
                                ketnoi.executeQuery(sql_dapanB);
                            }
                            if (rd_TrueC4.Checked)
                            {
                                sql_dapanC = "insert into DAPAN values('" + dr_dethi.Text + "_" + (thutucau1 + 3) + "_3','" + txt_C4.Text + "','True','" + dr_dethi.Text + "_" + (thutucau1 + 3) + "')";
                                ketnoi.executeQuery(sql_dapanC);

                            }
                            else
                            {
                                sql_dapanC = "insert into DAPAN values('" + dr_dethi.Text + "_" + (thutucau1 + 3) + "_3','" + txt_C4.Text + "','False','" + dr_dethi.Text + "_" + (thutucau1 + 3) + "')";
                                ketnoi.executeQuery(sql_dapanC);

                            }

                            if (rd_TrueD4.Checked)
                            {
                                sql_dapanD = "insert into DAPAN values('" + dr_dethi.Text + "_" + (thutucau1 + 3) + "_4','" + txt_D4.Text + "','True','" + dr_dethi.Text + "_" + (thutucau1 + 3) + "')";
                                ketnoi.executeQuery(sql_dapanD);
                            }
                            else
                            {
                                sql_dapanD = "insert into DAPAN values('" + dr_dethi.Text + "_" + (thutucau1 + 3) + "_4','" + txt_D4.Text + "','False','" + dr_dethi.Text + "_" + (thutucau1 + 3) + "')";
                                ketnoi.executeQuery(sql_dapanD);
                            }
                        }
                        catch { }
                        // dap an 5
                        try
                        {
                            if (rd_TrueA5.Checked)
                            {
                                sql_dapanA = "insert into DAPAN values('" + dr_dethi.Text + "_" + (thutucau1 + 4) + "_1','" + txt_A5.Text + "','True','" + dr_dethi.Text + "_" + (thutucau1 + 4) + "')";
                                ketnoi.executeQuery(sql_dapanA);
                            }
                            else
                            {
                                sql_dapanA = "insert into DAPAN values('" + dr_dethi.Text + "_" + (thutucau1 + 4) + "_1','" + txt_A5.Text + "','False','" + dr_dethi.Text + "_" + (thutucau1 + 4) + "')";
                                ketnoi.executeQuery(sql_dapanA);
                            }
                            if (rd_TrueB5.Checked)
                            {
                                sql_dapanB = "insert into DAPAN values('" + dr_dethi.Text + "_" + (thutucau1 + 4) + "_2','" + txt_B5.Text + "','True','" + dr_dethi.Text + "_" + (thutucau1 + 4) + "')";
                                ketnoi.executeQuery(sql_dapanB);
                            }
                            else
                            {
                                sql_dapanB = "insert into DAPAN values('" + dr_dethi.Text + "_" + (thutucau1 + 4) + "_2','" + txt_B5.Text + "','False','" + dr_dethi.Text + "_" + (thutucau1 + 4) + "')";
                                ketnoi.executeQuery(sql_dapanB);
                            }
                            if (rd_TrueC5.Checked)
                            {
                                sql_dapanC = "insert into DAPAN values('" + dr_dethi.Text + "_" + (thutucau1 + 4) + "_3','" + txt_C5.Text + "','True','" + dr_dethi.Text + "_" + (thutucau1 + 4) + "')";
                                ketnoi.executeQuery(sql_dapanC);

                            }
                            else
                            {
                                sql_dapanC = "insert into DAPAN values('" + dr_dethi.Text + "_" + (thutucau1 + 4) + "_3','" + txt_C5.Text + "','False','" + dr_dethi.Text + "_" + (thutucau1 + 4) + "')";
                                ketnoi.executeQuery(sql_dapanC);

                            }

                            if (rd_TrueD5.Checked)
                            {
                                sql_dapanD = "insert into DAPAN values('" + dr_dethi.Text + "_" + (thutucau1 + 4) + "_4','" + txt_D5.Text + "','True','" + dr_dethi.Text + "_" + (thutucau1 + 4) + "')";
                                ketnoi.executeQuery(sql_dapanD);
                            }
                            else
                            {
                                sql_dapanD = "insert into DAPAN values('" + dr_dethi.Text + "_" + (thutucau1 + 4) + "_4','" + txt_D5.Text + "','False','" + dr_dethi.Text + "_" + (thutucau1 + 4) + "')";
                                ketnoi.executeQuery(sql_dapanD);
                            }
                        }
                        catch { }
                        Response.Write("<script>alert('Thêm câu hỏi thành công!'); </script>");
                    }
                    catch
                    {
                        Response.Write("<script>alert('Thêm câu hỏi  thành công!'); </script>");
                    }
                }
            }
        }
     
        else if (dr_noidung.Text.Trim() == "Sentences")
        {
            fileNghe.Visible = false;
            fileAnh.Visible = false;
            causo.Visible = true;
            id_causo.Visible = true;
            cauhoi.Visible = true;
            dapanA.Visible = true;
            dapanB.Visible = true;
            dapanC.Visible = true;
            dapanD.Visible = true;
            string sql_dethi = "select * from DETHI where Made='0" + dr_dethi.Text + "_Sen'";
            DataTable tb_dethi = ketnoi.getData(sql_dethi);
            if (tb_dethi.Rows.Count == 0)
            {
                string sql_insert = "insert into DETHI values('0" + dr_dethi.Text + "_Sen',N'Đề 0" + dr_dethi.Text + "',getdate(),NULL,'Sentences')";
                ketnoi.executeQuery(sql_insert);
            }
                            string sql_kiemtra = "(select * from CAUHOI where IDCauhoi='" + dr_dethi.Text + "_Sen_" + dr_socauhoi.Text + "')";
                            ketnoi.executeQuery(sql_kiemtra);

                            DataTable tb_kiemtra = ketnoi.getData(sql_kiemtra);
                            if (tb_kiemtra.Rows.Count > 0)
                            {
                                Response.Write("<script>alert('Câu hỏi này đã tồn tại!'); </script>");

                            }
                            else
                            {
                               
                                string sql_cauhoi = "insert into CAUHOI values('" + dr_dethi.Text + "_Sen_" + dr_socauhoi.Text + "','','" + txt_cauhoi.Text + "','" + dr_noidung.Text + "','Nghe_0" + dr_dethi.Text + "','0" + dr_dethi.Text + "_Sen')";
                                ketnoi.executeQuery(sql_cauhoi);
                                string sql_dapanA, sql_dapanB, sql_dapanC, sql_dapanD;
                                if (rd_TrueA.Checked)
                                {
                                    sql_dapanA = "insert into DAPAN values('" + dr_dethi.Text + "_Sen_" + dr_socauhoi.Text + "_1','" + txt_A.Text + "','True','" + dr_dethi.Text + "_Sen_" + dr_socauhoi.Text + "')";
                                    ketnoi.executeQuery(sql_dapanA);
                                }
                                else
                                {
                                    sql_dapanA = "insert into DAPAN values('" + dr_dethi.Text + "_Sen_" + dr_socauhoi.Text + "_1','" + txt_A.Text + "','False','" + dr_dethi.Text + "_Sen_" + dr_socauhoi.Text + "')";
                                    ketnoi.executeQuery(sql_dapanA);
                                }
                                if (rd_TrueB.Checked)
                                {
                                    sql_dapanB = "insert into DAPAN values('" + dr_dethi.Text + "_Sen_" + dr_socauhoi.Text + "_2','" + txt_B.Text + "','True','" + dr_dethi.Text + "_Sen_" + dr_socauhoi.Text + "')";
                                    ketnoi.executeQuery(sql_dapanB);
                                }
                                else
                                {
                                    sql_dapanB = "insert into DAPAN values('" + dr_dethi.Text + "_Sen_" + dr_socauhoi.Text + "_2','" + txt_B.Text + "','False','" + dr_dethi.Text + "_Sen_" + dr_socauhoi.Text + "')";
                                    ketnoi.executeQuery(sql_dapanB);
                                }
                                if (rd_TrueC.Checked)
                                {
                                    sql_dapanC = "insert into DAPAN values('" + dr_dethi.Text + "_Sen_" + dr_socauhoi.Text + "_3','" + txt_C.Text + "','True','" + dr_dethi.Text + "_Sen_" + dr_socauhoi.Text + "')";
                                    ketnoi.executeQuery(sql_dapanC);

                                }
                                else
                                {
                                    sql_dapanC = "insert into DAPAN values('" + dr_dethi.Text + "_Sen_" + dr_socauhoi.Text + "_3','" + txt_C.Text + "','False','" + dr_dethi.Text + "_Sen_" + dr_socauhoi.Text + "')";
                                    ketnoi.executeQuery(sql_dapanC);

                                }
                                if (rd_TrueD.Checked)
                                {
                                    sql_dapanD = "insert into DAPAN values('" + dr_dethi.Text + "_Sen_" + dr_socauhoi.Text + "_4','" + txt_D.Text + "','True','" + dr_dethi.Text + "_Sen_" + dr_socauhoi.Text + "')";
                                    ketnoi.executeQuery(sql_dapanD);

                                }
                                else
                                {
                                    sql_dapanD = "insert into DAPAN values('" + dr_dethi.Text + "_Sen_" + dr_socauhoi.Text + "_4','"+txt_D.Text+"','False','" + dr_dethi.Text + "_Sen_" + dr_socauhoi.Text + "')";
                                    ketnoi.executeQuery(sql_dapanD);

                                }
                                Response.Write("<script>alert('Thêm câu hỏi thành công!'); </script>");

                            }
                        }
                   

        else if (dr_noidung.Text.Trim() == "Sentencestest")
        {
            fileNghe.Visible = false;
            fileAnh.Visible = false;
            causo.Visible = true;
            id_causo.Visible = true;
            cauhoi.Visible = true;
            dapanA.Visible = true;
            dapanB.Visible = true;
            dapanC.Visible = true;
            dapanD.Visible = true;
            string sql_dethi;
            if (dr_capdo.Text == "Tonghop" || dr_capdo.Text == "0")

                sql_dethi = "select * from DETHI where Made='0" + dr_dethi.Text + "'";
            else
                sql_dethi = "select * from DETHI where Made='0" + dr_dethi.Text + "_" + dr_capdo.Text + "'";
            DataTable tb_dethi = ketnoi.getData(sql_dethi);
            if (tb_dethi.Rows.Count == 0)
            {
                string sql_insert;
                if (dr_capdo.Text == "Tonghop" || dr_capdo.Text == "0")
                {
                    sql_insert = "insert into DETHI values('0" + dr_dethi.Text + "',N'Đề 0" + dr_dethi.Text + "',getdate(),NULL,'Dethi')";
                }
                else
                {
                    sql_insert = "insert into DETHI values('0" + dr_dethi.Text + "_" + dr_capdo.Text + "',N'Đề 0" + dr_dethi.Text + "',getdate(),NULL,'Dethi')";
                }
                ketnoi.executeQuery(sql_insert);
            }
            string sql_kiemtra = "(select * from CAUHOI where IDCauhoi='" + dr_dethi.Text + "_" + dr_socauhoi.Text + "')";
            ketnoi.executeQuery(sql_kiemtra);

            DataTable tb_kiemtra = ketnoi.getData(sql_kiemtra);
            if (tb_kiemtra.Rows.Count > 0)
            {
                Response.Write("<script>alert('Câu hỏi này đã tồn tại!'); </script>");

            }
                            else
                            {
                               
                                string sql_cauhoi = "insert into CAUHOI values('" + dr_dethi.Text + "_" + dr_socauhoi.Text + "','','" + txt_cauhoi.Text + "','" + dr_noidung.Text + "',NULL,'0" + dr_dethi.Text + "')";
                                ketnoi.executeQuery(sql_cauhoi);
                                string sql_dapanA, sql_dapanB, sql_dapanC, sql_dapanD;
                                if (rd_TrueA.Checked)
                                {
                                    sql_dapanA = "insert into DAPAN values('" + dr_dethi.Text + "_" + dr_socauhoi.Text + "_1','" + txt_A.Text + "','True','" + dr_dethi.Text + "_" + dr_socauhoi.Text + "')";
                                    ketnoi.executeQuery(sql_dapanA);
                                }
                                else
                                {
                                    sql_dapanA = "insert into DAPAN values('" + dr_dethi.Text + "_" + dr_socauhoi.Text + "_1','" + txt_A.Text + "','False','" + dr_dethi.Text + "_" + dr_socauhoi.Text + "')";
                                    ketnoi.executeQuery(sql_dapanA);
                                }
                                if (rd_TrueB.Checked)
                                {
                                    sql_dapanB = "insert into DAPAN values('" + dr_dethi.Text + "_" + dr_socauhoi.Text + "_2','" + txt_B.Text + "','True','" + dr_dethi.Text + "_" + dr_socauhoi.Text + "')";
                                    ketnoi.executeQuery(sql_dapanB);
                                }
                                else
                                {
                                    sql_dapanB = "insert into DAPAN values('" + dr_dethi.Text + "_" + dr_socauhoi.Text + "_2','" + txt_B.Text + "','False','" + dr_dethi.Text + "_" + dr_socauhoi.Text + "')";
                                    ketnoi.executeQuery(sql_dapanB);
                                }
                                if (rd_TrueC.Checked)
                                {
                                    sql_dapanC = "insert into DAPAN values('" + dr_dethi.Text + "_" + dr_socauhoi.Text + "_3','" + txt_C.Text + "','True','" + dr_dethi.Text + "_" + dr_socauhoi.Text + "')";
                                    ketnoi.executeQuery(sql_dapanC);

                                }
                                else
                                {
                                    sql_dapanC = "insert into DAPAN values('" + dr_dethi.Text + "_" + dr_socauhoi.Text + "_3','" + txt_C.Text + "','False','" + dr_dethi.Text + "_" + dr_socauhoi.Text + "')";
                                    ketnoi.executeQuery(sql_dapanC);

                                }
                                if (rd_TrueD.Checked)
                                {
                                    sql_dapanD = "insert into DAPAN values('" + dr_dethi.Text + "_" + dr_socauhoi.Text + "_4','" + txt_D.Text + "','True','" + dr_dethi.Text + "_" + dr_socauhoi.Text + "')";
                                    ketnoi.executeQuery(sql_dapanD);

                                }
                                else
                                {
                                    sql_dapanD = "insert into DAPAN values('" + dr_dethi.Text + "_" + dr_socauhoi.Text + "_4','" + txt_D.Text + "','False','" + dr_dethi.Text + "_" + dr_socauhoi.Text + "')";
                                    ketnoi.executeQuery(sql_dapanD);

                                }
                                Response.Write("<script>alert('Thêm câu hỏi thành công!'); </script>");

                            }
                        
                        }
    
        
        else if (dr_noidung.Text.Trim() == "TextCompletion")
        {
            fileNghe.Visible = false;
            soluongcauhoi.Visible = true;
            causo.Visible = true;
            id_caubatdau.Visible = true;
            noidungdoanvan.Visible = true;
            cauhoi.Visible = false;
            dapanA.Visible = false;
            dapanB.Visible = false;
            dapanC.Visible = false;


            try
            {



                string sql_dapanA;
                string sql_dapanB;
                string sql_dapanC;
                string sql_dapanD;
               

                int soluongcau = Int32.Parse(dr_soluong.Text);
                int thutucau = Int32.Parse(dr_socauhoi.Text);
                string sql_dethi = "select * from DETHI where Made='0" + dr_dethi.Text + "_Com'";
                DataTable tb_dethi = ketnoi.getData(sql_dethi);
                if (tb_dethi.Rows.Count == 0)
                {
                    string sql_insert = "insert into DETHI values('0" + dr_dethi.Text + "_Com',N'Đề 0" + dr_dethi.Text + "',getdate(),NULL,'TextCompletion')";
                    ketnoi.executeQuery(sql_insert);
                }
                for (int i = 1; i <= soluongcau; i++)
                {

                   
                        string sql_cauhoi;
                        string noidung;
                        if (i == 1)
                            noidung = txt_doanvan.Text;
                        else
                            noidung = "";
                        if (i == 1)
                        {
                            sql_cauhoi = "insert into CAUHOI values('" + dr_dethi.Text + "_Com_" + thutucau + "','" + noidung + "','" + txt_cauhoi1.Text + "','TextCompletion',NULL,'0" + dr_dethi.Text + "_Com')";
                            ketnoi.executeQuery(sql_cauhoi);
                        }
                        else if (i == 2)
                        {
                            sql_cauhoi = "insert into CAUHOI values('" + dr_dethi.Text + "_Com_" + thutucau + "','','" + txt_cauhoi2.Text + "','TextCompletion',NULL,'0" + dr_dethi.Text + "_Com')";
                            ketnoi.executeQuery(sql_cauhoi);
                        }
                        else if (i == 3)
                        {
                            sql_cauhoi = "insert into CAUHOI values('" + dr_dethi.Text + "_Com_" + thutucau + "','','" + txt_cauhoi3.Text + "','TextCompletion',NULL,'0" + dr_dethi.Text + "_Com')";
                            ketnoi.executeQuery(sql_cauhoi);
                        }
                        else if (i == 4)
                        {
                            sql_cauhoi = "insert into CAUHOI values('" + dr_dethi.Text + "_Com_" + thutucau + "','','" + txt_cauhoi4.Text + "','TextCompletion',NULL,'0" + dr_dethi.Text + "_Com')";
                            ketnoi.executeQuery(sql_cauhoi);
                        }
                        else if (i == 5)
                        {
                            sql_cauhoi = "insert into CAUHOI values('" + dr_dethi.Text + "_Com_" + thutucau + "','','" + txt_cauhoi5.Text + "','TextCompletion',NULL,'0" + dr_dethi.Text + "_Com')";
                            ketnoi.executeQuery(sql_cauhoi);
                        }

                        thutucau++;
                   
                }
                       
                         //dap an 1
                        int thutucau1 = Int32.Parse(dr_socauhoi.Text);
                        if (rd_TrueA1.Checked)
                        {
                            sql_dapanA = "insert into DAPAN values('" + dr_dethi.Text + "_Com_" + thutucau1 + "_1','" + txt_A1.Text + "','True','" + dr_dethi.Text + "_Com_" + thutucau1 + "')";

                            ketnoi.executeQuery(sql_dapanA);
                        }
                        else
                        {
                            sql_dapanA = "insert into DAPAN values('" + dr_dethi.Text + "_Com_" + thutucau1 + "_1','" + txt_A1.Text + "','False','" + dr_dethi.Text + "_Com_" + thutucau1 + "')";
                            ketnoi.executeQuery(sql_dapanA);
                        }
                        if (rd_TrueB1.Checked)
                        {
                            sql_dapanB = "insert into DAPAN values('" + dr_dethi.Text + "_Com_" + thutucau1 + "_2','" + txt_B1.Text + "','True','" + dr_dethi.Text + "_Com_" + thutucau1 + "')";
                            ketnoi.executeQuery(sql_dapanB);
                        }
                        else
                        {
                            sql_dapanB = "insert into DAPAN values('" + dr_dethi.Text + "_Com_" + thutucau1 + "_2','" + txt_B1.Text + "','False','" + dr_dethi.Text + "_Com_" + thutucau1 + "')";
                            ketnoi.executeQuery(sql_dapanB);
                        }
                        if (rd_TrueC1.Checked)
                        {
                            sql_dapanC = "insert into DAPAN values('" + dr_dethi.Text + "_Com_" + thutucau1 + "_3','" + txt_C1.Text + "','True','" + dr_dethi.Text + "_Com_" + thutucau1 + "')";
                            ketnoi.executeQuery(sql_dapanC);

                        }
                        else
                        {
                            sql_dapanC = "insert into DAPAN values('" + dr_dethi.Text + "_Com_" + thutucau1 + "_3','" + txt_C1.Text + "','False','" + dr_dethi.Text + "_Com_" + thutucau1 + "')";
                            ketnoi.executeQuery(sql_dapanC);

                        }

                        if (rd_TrueD1.Checked)
                        {
                            sql_dapanD = "insert into DAPAN values('" + dr_dethi.Text + "_Com_" + thutucau1 + "_4','" + txt_D1.Text + "','True','" + dr_dethi.Text + "_Com_" + thutucau1 + "')";
                            ketnoi.executeQuery(sql_dapanD);
                        }
                        else
                        {
                            sql_dapanD = "insert into DAPAN values('" + dr_dethi.Text + "_Com_" + thutucau1 + "_4','" + txt_D1.Text + "','False','" + dr_dethi.Text + "_Com_" + thutucau1 + "')";
                            ketnoi.executeQuery(sql_dapanD);
                        }

                        // dap an 2
                        try
                        {
                            if (rd_TrueA2.Checked)
                            {
                                sql_dapanA = "insert into DAPAN values('" + dr_dethi.Text + "_Com_" + (thutucau1 + 1) + "_1','" + txt_A2.Text + "','True','" + dr_dethi.Text + "_Com_" + (thutucau1 + 1) + "')";
                                ketnoi.executeQuery(sql_dapanA);
                            }
                            else
                            {
                                sql_dapanA = "insert into DAPAN values('" + dr_dethi.Text + "_Com_" + (thutucau1 + 1) + "_1','" + txt_A2.Text + "','False','" + dr_dethi.Text + "_Com_" + (thutucau1 + 1) + "')";
                                ketnoi.executeQuery(sql_dapanA);
                            }
                            if (rd_TrueB2.Checked)
                            {
                                sql_dapanB = "insert into DAPAN values('" + dr_dethi.Text + "_Com_" + (thutucau1 + 1) + "_2','" + txt_B2.Text + "','True','" + dr_dethi.Text + "_Com_" + (thutucau1 + 1) + "')";
                                ketnoi.executeQuery(sql_dapanB);
                            }
                            else
                            {
                                sql_dapanB = "insert into DAPAN values('" + dr_dethi.Text + "_Com_" + (thutucau1 + 1) + "_2','" + txt_B2.Text + "','False','" + dr_dethi.Text + "_Com_" + (thutucau1 + 1) + "')";
                                ketnoi.executeQuery(sql_dapanB);
                            }
                            if (rd_TrueC2.Checked)
                            {
                                sql_dapanC = "insert into DAPAN values('" + dr_dethi.Text + "_Com_" + (thutucau1 + 1) + "_3','" + txt_C2.Text + "','True','" + dr_dethi.Text + "_Com_" + (thutucau1 + 1) + "')";
                                ketnoi.executeQuery(sql_dapanC);

                            }
                            else
                            {
                                sql_dapanC = "insert into DAPAN values('" + dr_dethi.Text + "_Com_" + (thutucau1 + 1) + "_3','" + txt_C2.Text + "','False','" + dr_dethi.Text + "_Com_" + (thutucau1 + 1) + "')";
                                ketnoi.executeQuery(sql_dapanC);

                            }

                            if (rd_TrueD2.Checked)
                            {
                                sql_dapanD = "insert into DAPAN values('" + dr_dethi.Text + "_Com_" + (thutucau1 + 1) + "_4','" + txt_D2.Text + "','True','" + dr_dethi.Text + "_Com_" + (thutucau1 + 1) + "')";
                                ketnoi.executeQuery(sql_dapanD);
                            }
                            else
                            {
                                sql_dapanD = "insert into DAPAN values('" + dr_dethi.Text + "_Com_" + (thutucau1 + 1) + "_4','" + txt_D2.Text + "','False','" + dr_dethi.Text + "_Com_" + (thutucau1 + 1) + "')";
                                ketnoi.executeQuery(sql_dapanD);
                            }
                        }
                        catch { }

                        // dap an 3
                        try
                        {
                            if (rd_TrueA3.Checked)
                            {
                                sql_dapanA = "insert into DAPAN values('" + dr_dethi.Text + "_Com_" + (thutucau1 + 2) + "_1','" + txt_A3.Text + "','True','" + dr_dethi.Text + "_Com_" + (thutucau1 + 2) + "')";
                                ketnoi.executeQuery(sql_dapanA);
                            }
                            else
                            {
                                sql_dapanA = "insert into DAPAN values('" + dr_dethi.Text + "_Com_" + (thutucau1 + 2) + "_1','" + txt_A3.Text + "','False','" + dr_dethi.Text + "_Com_" + (thutucau1 + 2) + "')";
                                ketnoi.executeQuery(sql_dapanA);
                            }
                            if (rd_TrueB3.Checked)
                            {
                                sql_dapanB = "insert into DAPAN values('" + dr_dethi.Text + "_Com_" + (thutucau1 + 2) + "_2','" + txt_B3.Text + "','True','" + dr_dethi.Text + "_Com_" + (thutucau1 + 2) + "')";
                                ketnoi.executeQuery(sql_dapanB);
                            }
                            else
                            {
                                sql_dapanB = "insert into DAPAN values('" + dr_dethi.Text + "_Com_" + (thutucau1 + 2) + "_2','" + txt_B3.Text + "','False','" + dr_dethi.Text + "_Com_" + (thutucau1 + 2) + "')";
                                ketnoi.executeQuery(sql_dapanB);
                            }
                            if (rd_TrueC3.Checked)
                            {
                                sql_dapanC = "insert into DAPAN values('" + dr_dethi.Text + "_Com_" + (thutucau1 + 2) + "_3','" + txt_C3.Text + "','True','" + dr_dethi.Text + "_Com_" + (thutucau1 + 2) + "')";
                                ketnoi.executeQuery(sql_dapanC);

                            }
                            else
                            {
                                sql_dapanC = "insert into DAPAN values('" + dr_dethi.Text + "_Com_" + (thutucau1 + 2) + "_3','" + txt_C3.Text + "','False','" + dr_dethi.Text + "_Com_" + (thutucau1 + 2) + "')";
                                ketnoi.executeQuery(sql_dapanC);

                            }

                            if (rd_TrueD3.Checked)
                            {
                                sql_dapanD = "insert into DAPAN values('" + dr_dethi.Text + "_Com_" + (thutucau1 + 2) + "_4','" + txt_D3.Text + "','True','" + dr_dethi.Text + "_Com_" + (thutucau1 + 2) + "')";
                                ketnoi.executeQuery(sql_dapanD);
                            }
                            else
                            {
                                sql_dapanD = "insert into DAPAN values('" + dr_dethi.Text + "_Com_" + (thutucau1 + 2) + "_4','" + txt_D3.Text + "','False','" + dr_dethi.Text + "_Com_" + (thutucau1 + 2) + "')";
                                ketnoi.executeQuery(sql_dapanD);
                            }
                        }
                        catch { }
                        // dap an 4
                        try
                        {

                            if (rd_TrueA4.Checked)
                            {
                                sql_dapanA = "insert into DAPAN values('" + dr_dethi.Text + "_Com_" + (thutucau1 + 3) + "_1','" + txt_A4.Text + "','True','" + dr_dethi.Text + "_Com_" + (thutucau1 + 3) + "')";
                                ketnoi.executeQuery(sql_dapanA);
                            }
                            else
                            {
                                sql_dapanA = "insert into DAPAN values('" + dr_dethi.Text + "_Com_" + (thutucau1 + 3) + "_1','" + txt_A1.Text + "','False','" + dr_dethi.Text + "_Com_" + (thutucau1 + 3) + "')";
                                ketnoi.executeQuery(sql_dapanA);
                            }
                            if (rd_TrueB4.Checked)
                            {
                                sql_dapanB = "insert into DAPAN values('" + dr_dethi.Text + "_Com_" + (thutucau1 + 3) + "_2','" + txt_B4.Text + "','True','" + dr_dethi.Text + "_Com_" + (thutucau1 + 3) + "')";
                                ketnoi.executeQuery(sql_dapanB);
                            }
                            else
                            {
                                sql_dapanB = "insert into DAPAN values('" + dr_dethi.Text + "_Com_" + (thutucau1 + 3) + "_2','" + txt_B4.Text + "','False','" + dr_dethi.Text + "_Com_" + (thutucau1 + 3) + "')";
                                ketnoi.executeQuery(sql_dapanB);
                            }
                            if (rd_TrueC4.Checked)
                            {
                                sql_dapanC = "insert into DAPAN values('" + dr_dethi.Text + "_Com_" + (thutucau1 + 3) + "_3','" + txt_C4.Text + "','True','" + dr_dethi.Text + "_Com_" + (thutucau1 + 3) + "')";
                                ketnoi.executeQuery(sql_dapanC);

                            }
                            else
                            {
                                sql_dapanC = "insert into DAPAN values('" + dr_dethi.Text + "_Com_" + (thutucau1 + 3) + "_3','" + txt_C4.Text + "','False','" + dr_dethi.Text + "_Com_" + (thutucau1 + 3) + "')";
                                ketnoi.executeQuery(sql_dapanC);

                            }

                            if (rd_TrueD4.Checked)
                            {
                                sql_dapanD = "insert into DAPAN values('" + dr_dethi.Text + "_Com_" + (thutucau1 + 3) + "_4','" + txt_D4.Text + "','True','" + dr_dethi.Text + "_Com_" + (thutucau1 + 3) + "')";
                                ketnoi.executeQuery(sql_dapanD);
                            }
                            else
                            {
                                sql_dapanD = "insert into DAPAN values('" + dr_dethi.Text + "_Com_" + (thutucau1 + 3) + "_4','" + txt_D4.Text + "','False','" + dr_dethi.Text + "_Com_" + (thutucau1 + 3) + "')";
                                ketnoi.executeQuery(sql_dapanD);
                            }
                        }
                        catch { }
                        // dap an 5
                        try
                        {
                            if (rd_TrueA5.Checked)
                            {
                                sql_dapanA = "insert into DAPAN values('" + dr_dethi.Text + "_Com_" + (thutucau1 + 4) + "_1','" + txt_A5.Text + "','True','" + dr_dethi.Text + "_Com_" + (thutucau1 + 4) + "')";
                                ketnoi.executeQuery(sql_dapanA);
                            }
                            else
                            {
                                sql_dapanA = "insert into DAPAN values('" + dr_dethi.Text + "_Com_" + (thutucau1 + 4) + "_1','" + txt_A5.Text + "','False','" + dr_dethi.Text + "_Com_" + (thutucau1 + 4) + "')";
                                ketnoi.executeQuery(sql_dapanA);
                            }
                            if (rd_TrueB5.Checked)
                            {
                                sql_dapanB = "insert into DAPAN values('" + dr_dethi.Text + "_Com_" + (thutucau1 + 4) + "_2','" + txt_B5.Text + "','True','" + dr_dethi.Text + "_Com_" + (thutucau1 + 4) + "')";
                                ketnoi.executeQuery(sql_dapanB);
                            }
                            else
                            {
                                sql_dapanB = "insert into DAPAN values('" + dr_dethi.Text + "_Com_" + (thutucau1 + 4) + "_2','" + txt_B5.Text + "','False','" + dr_dethi.Text + "_Com_" + (thutucau1 + 4) + "')";
                                ketnoi.executeQuery(sql_dapanB);
                            }
                            if (rd_TrueC5.Checked)
                            {
                                sql_dapanC = "insert into DAPAN values('" + dr_dethi.Text + "_Com_" + (thutucau1 + 4) + "_3','" + txt_C5.Text + "','True','" + dr_dethi.Text + "_Com_" + (thutucau1 + 4) + "')";
                                ketnoi.executeQuery(sql_dapanC);

                            }
                            else
                            {
                                sql_dapanC = "insert into DAPAN values('" + dr_dethi.Text + "_Com_" + (thutucau1 + 4) + "_3','" + txt_C5.Text + "','False','" + dr_dethi.Text + "_Com_" + (thutucau1 + 4) + "')";
                                ketnoi.executeQuery(sql_dapanC);

                            }

                            if (rd_TrueD5.Checked)
                            {
                                sql_dapanD = "insert into DAPAN values('" + dr_dethi.Text + "_Com_" + (thutucau1 + 4) + "_4','" + txt_D5.Text + "','True','" + dr_dethi.Text + "_Com_" + (thutucau1 + 4) + "')";
                                ketnoi.executeQuery(sql_dapanD);
                            }
                            else
                            {
                                sql_dapanD = "insert into DAPAN values('" + dr_dethi.Text + "_Com_" + (thutucau1 + 4) + "_4','" + txt_D5.Text + "','False','" + dr_dethi.Text + "_Com_" + (thutucau1 + 4) + "')";
                                ketnoi.executeQuery(sql_dapanD);
                            }

                        }
                        catch { }
                        Response.Write("<script>alert('Thêm câu hỏi thành công!'); </script>");
                    }
                    catch
                    {
                        Response.Write("<script>alert('Thêm câu hỏi không thành công!'); </script>");
                    }
        }
        
    
    
            
        
        else if (dr_noidung.Text.Trim() == "TextCompletiontest")
        {
                 fileNghe.Visible = false;
                    soluongcauhoi.Visible = true;
                    causo.Visible = true;
                    id_caubatdau.Visible = true;
                    noidungdoanvan.Visible = true;

                    string sql_dethi;
                    if (dr_capdo.Text == "Tonghop" || dr_capdo.Text == "0")

                        sql_dethi = "select * from DETHI where Made='0" + dr_dethi.Text + "'";
                    else
                        sql_dethi = "select * from DETHI where Made='0" + dr_dethi.Text + "_" + dr_capdo.Text + "'";
                    DataTable tb_dethi = ketnoi.getData(sql_dethi);
                    if (tb_dethi.Rows.Count == 0)
                    {
                        string sql_insert;
                        if (dr_capdo.Text == "Tonghop" || dr_capdo.Text == "0")
                        {
                            sql_insert = "insert into DETHI values('0" + dr_dethi.Text + "',N'Đề 0" + dr_dethi.Text + "',getdate(),NULL,'" + dr_capdo.Text + "')";
                        }
                        else
                        {
                            sql_insert = "insert into DETHI values('0" + dr_dethi.Text + "_" + dr_capdo.Text + "',N'Đề 0" + dr_dethi.Text + "',getdate(),NULL,'" + dr_capdo.Text + "')";
                        }
                        ketnoi.executeQuery(sql_insert);
                    }
                    try
                    {


                        string sql_dapanA;
                        string sql_dapanB;
                        string sql_dapanC;
                        string sql_dapanD;

                        int soluongcau = Int32.Parse(dr_soluong.Text);
                        int thutucau = Int32.Parse(dr_socauhoi.Text);
                        for (int i = 1; i <= soluongcau; i++)
                        {

                            try
                            {
                                string sql_cauhoi;
                                string noidung;
                                if (i == 1)
                                    noidung = txt_doanvan.Text;
                                else
                                    noidung = "";
                                if (i == 1)
                                {
                                    sql_cauhoi = "insert into CAUHOI values('" + dr_dethi.Text + "_" + thutucau + "','" + noidung + "','" + txt_cauhoi1.Text + "','TextCompletiontest',NULL,'0" + dr_dethi.Text + "')";
                                    ketnoi.executeQuery(sql_cauhoi);
                                }
                                else if (i == 2)
                                {
                                    sql_cauhoi = "insert into CAUHOI values('" + dr_dethi.Text + "_" + thutucau + "','','" + txt_cauhoi2.Text + "','TextCompletiontest',NULL,'0" + dr_dethi.Text + "')";
                                    ketnoi.executeQuery(sql_cauhoi);
                                }
                                else if (i == 3)
                                {
                                    sql_cauhoi = "insert into CAUHOI values('" + dr_dethi.Text + "_" + thutucau + "','','" + txt_cauhoi3.Text + "','TextCompletiontest',NULL,'0" + dr_dethi.Text + "')";
                                    ketnoi.executeQuery(sql_cauhoi);
                                }
                                else if (i == 4)
                                {
                                    sql_cauhoi = "insert into CAUHOI values('" + dr_dethi.Text + "_" + thutucau + "','','" + txt_cauhoi4.Text + "','TextCompletiontest',NULL,'0" + dr_dethi.Text + "')";
                                    ketnoi.executeQuery(sql_cauhoi);
                                }
                                else if (i == 5)
                                {
                                    sql_cauhoi = "insert into CAUHOI values('" + dr_dethi.Text + "_" + thutucau + "','','" + txt_cauhoi5.Text + "','TextCompletiontest',NULL,'0" + dr_dethi.Text + "')";
                                    ketnoi.executeQuery(sql_cauhoi);
                                }

                                thutucau++;
                            }
                            catch
                            {
                                Response.Write("<script> alert('Câu hỏi: " + dr_dethi.Text + "_" + thutucau + " đã tồn tại') </script>");
                                break;
                            }
                        }
                           //dap an 1
                        int thutucau1 = Int32.Parse(dr_socauhoi.Text);
                        if (rd_TrueA1.Checked)
                        {
                            sql_dapanA = "insert into DAPAN values('" + dr_dethi.Text + "_Conver_" + thutucau1 + "_1','" + txt_A1.Text + "','True','" + dr_dethi.Text + "_" + thutucau1 + "')";

                            ketnoi.executeQuery(sql_dapanA);
                        }
                        else
                        {
                            sql_dapanA = "insert into DAPAN values('" + dr_dethi.Text + "_Conver_" + thutucau1 + "_1','" + txt_A1.Text + "','False','" + dr_dethi.Text + "_" + thutucau1 + "')";
                            ketnoi.executeQuery(sql_dapanA);
                        }
                        if (rd_TrueB1.Checked)
                        {
                            sql_dapanB = "insert into DAPAN values('" + dr_dethi.Text + "_" + thutucau1 + "_2','" + txt_B1.Text + "','True','" + dr_dethi.Text + "_" + thutucau1 + "')";
                            ketnoi.executeQuery(sql_dapanB);
                        }
                        else
                        {
                            sql_dapanB = "insert into DAPAN values('" + dr_dethi.Text + "_" + thutucau1 + "_2','" + txt_B1.Text + "','False','" + dr_dethi.Text + "_" + thutucau1 + "')";
                            ketnoi.executeQuery(sql_dapanB);
                        }
                        if (rd_TrueC1.Checked)
                        {
                            sql_dapanC = "insert into DAPAN values('" + dr_dethi.Text + "_" + thutucau1 + "_3','" + txt_C1.Text + "','True','" + dr_dethi.Text + "_" + thutucau1 + "')";
                            ketnoi.executeQuery(sql_dapanC);

                        }
                        else
                        {
                            sql_dapanC = "insert into DAPAN values('" + dr_dethi.Text + "_" + thutucau1 + "_3','" + txt_C1.Text + "','False','" + dr_dethi.Text + "_" + thutucau1 + "')";
                            ketnoi.executeQuery(sql_dapanC);

                        }

                        if (rd_TrueD1.Checked)
                        {
                            sql_dapanD = "insert into DAPAN values('" + dr_dethi.Text + "_" + thutucau1 + "_4','" + txt_D1.Text + "','True','" + dr_dethi.Text + "_" + thutucau1 + "')";
                            ketnoi.executeQuery(sql_dapanD);
                        }
                        else
                        {
                            sql_dapanD = "insert into DAPAN values('" + dr_dethi.Text + "_" + thutucau1 + "_4','" + txt_D1.Text + "','False','" + dr_dethi.Text + "_" + thutucau1 + "')";
                            ketnoi.executeQuery(sql_dapanD);
                        }

                        // dap an 2
                        try
                        {
                            if (rd_TrueA2.Checked)
                            {
                                sql_dapanA = "insert into DAPAN values('" + dr_dethi.Text + "_" + (thutucau1 + 1) + "_1','" + txt_A2.Text + "','True','" + dr_dethi.Text + "_" + (thutucau1 + 1) + "')";
                                ketnoi.executeQuery(sql_dapanA);
                            }
                            else
                            {
                                sql_dapanA = "insert into DAPAN values('" + dr_dethi.Text + "_" + (thutucau1 + 1) + "_1','" + txt_A2.Text + "','False','" + dr_dethi.Text + "_" + (thutucau1 + 1) + "')";
                                ketnoi.executeQuery(sql_dapanA);
                            }
                            if (rd_TrueB2.Checked)
                            {
                                sql_dapanB = "insert into DAPAN values('" + dr_dethi.Text + "_" + (thutucau1 + 1) + "_2','" + txt_B2.Text + "','True','" + dr_dethi.Text + "_" + (thutucau1 + 1) + "')";
                                ketnoi.executeQuery(sql_dapanB);
                            }
                            else
                            {
                                sql_dapanB = "insert into DAPAN values('" + dr_dethi.Text + "_" + (thutucau1 + 1) + "_2','" + txt_B2.Text + "','False','" + dr_dethi.Text + "_" + (thutucau1 + 1) + "')";
                                ketnoi.executeQuery(sql_dapanB);
                            }
                            if (rd_TrueC2.Checked)
                            {
                                sql_dapanC = "insert into DAPAN values('" + dr_dethi.Text + "_" + (thutucau1 + 1) + "_3','" + txt_C2.Text + "','True','" + dr_dethi.Text + "_" + (thutucau1 + 1) + "')";
                                ketnoi.executeQuery(sql_dapanC);

                            }
                            else
                            {
                                sql_dapanC = "insert into DAPAN values('" + dr_dethi.Text + "_" + (thutucau1 + 1) + "_3','" + txt_C2.Text + "','False','" + dr_dethi.Text + "_" + (thutucau1 + 1) + "')";
                                ketnoi.executeQuery(sql_dapanC);

                            }

                            if (rd_TrueD2.Checked)
                            {
                                sql_dapanD = "insert into DAPAN values('" + dr_dethi.Text + "_" + (thutucau1 + 1) + "_4','" + txt_D2.Text + "','True','" + dr_dethi.Text + "_" + (thutucau1 + 1) + "')";
                                ketnoi.executeQuery(sql_dapanD);
                            }
                            else
                            {
                                sql_dapanD = "insert into DAPAN values('" + dr_dethi.Text + "_" + (thutucau1 + 1) + "_4','" + txt_D2.Text + "','False','" + dr_dethi.Text + "_" + (thutucau1 + 1) + "')";
                                ketnoi.executeQuery(sql_dapanD);
                            }
                        }
                        catch { }

                        // dap an 3
                        try
                        {
                            if (rd_TrueA3.Checked)
                            {
                                sql_dapanA = "insert into DAPAN values('" + dr_dethi.Text + "_" + (thutucau1 + 2) + "_1','" + txt_A3.Text + "','True','" + dr_dethi.Text + "_" + (thutucau1 + 2) + "')";
                                ketnoi.executeQuery(sql_dapanA);
                            }
                            else
                            {
                                sql_dapanA = "insert into DAPAN values('" + dr_dethi.Text + "_" + (thutucau1 + 2) + "_1','" + txt_A3.Text + "','False','" + dr_dethi.Text + "_" + (thutucau1 + 2) + "')";
                                ketnoi.executeQuery(sql_dapanA);
                            }
                            if (rd_TrueB3.Checked)
                            {
                                sql_dapanB = "insert into DAPAN values('" + dr_dethi.Text + "_" + (thutucau1 + 2) + "_2','" + txt_B3.Text + "','True','" + dr_dethi.Text + "_" + (thutucau1 + 2) + "')";
                                ketnoi.executeQuery(sql_dapanB);
                            }
                            else
                            {
                                sql_dapanB = "insert into DAPAN values('" + dr_dethi.Text + "_" + (thutucau1 + 2) + "_2','" + txt_B3.Text + "','False','" + dr_dethi.Text + "_" + (thutucau1 + 2) + "')";
                                ketnoi.executeQuery(sql_dapanB);
                            }
                            if (rd_TrueC3.Checked)
                            {
                                sql_dapanC = "insert into DAPAN values('" + dr_dethi.Text + "_" + (thutucau1 + 2) + "_3','" + txt_C3.Text + "','True','" + dr_dethi.Text + "_" + (thutucau1 + 2) + "')";
                                ketnoi.executeQuery(sql_dapanC);

                            }
                            else
                            {
                                sql_dapanC = "insert into DAPAN values('" + dr_dethi.Text + "_" + (thutucau1 + 2) + "_3','" + txt_C3.Text + "','False','" + dr_dethi.Text + "_" + (thutucau1 + 2) + "')";
                                ketnoi.executeQuery(sql_dapanC);

                            }

                            if (rd_TrueD3.Checked)
                            {
                                sql_dapanD = "insert into DAPAN values('" + dr_dethi.Text + "_" + (thutucau1 + 2) + "_4','" + txt_D3.Text + "','True','" + dr_dethi.Text + "_" + (thutucau1 + 2) + "')";
                                ketnoi.executeQuery(sql_dapanD);
                            }
                            else
                            {
                                sql_dapanD = "insert into DAPAN values('" + dr_dethi.Text + "_" + (thutucau1 + 2) + "_4','" + txt_D3.Text + "','False','" + dr_dethi.Text + "_" + (thutucau1 + 2) + "')";
                                ketnoi.executeQuery(sql_dapanD);
                            }
                        }
                        catch { }
                        // dap an 4
                        try
                        {

                            if (rd_TrueA4.Checked)
                            {
                                sql_dapanA = "insert into DAPAN values('" + dr_dethi.Text + "_" + (thutucau1 + 3) + "_1','" + txt_A4.Text + "','True','" + dr_dethi.Text + "_" + (thutucau1 + 3) + "')";
                                ketnoi.executeQuery(sql_dapanA);
                            }
                            else
                            {
                                sql_dapanA = "insert into DAPAN values('" + dr_dethi.Text + "_" + (thutucau1 + 3) + "_1','" + txt_A1.Text + "','False','" + dr_dethi.Text + "_" + (thutucau1 + 3) + "')";
                                ketnoi.executeQuery(sql_dapanA);
                            }
                            if (rd_TrueB4.Checked)
                            {
                                sql_dapanB = "insert into DAPAN values('" + dr_dethi.Text + "_" + (thutucau1 + 3) + "_2','" + txt_B4.Text + "','True','" + dr_dethi.Text + "_" + (thutucau1 + 3) + "')";
                                ketnoi.executeQuery(sql_dapanB);
                            }
                            else
                            {
                                sql_dapanB = "insert into DAPAN values('" + dr_dethi.Text + "_" + (thutucau1 + 3) + "_2','" + txt_B4.Text + "','False','" + dr_dethi.Text + "_" + (thutucau1 + 3) + "')";
                                ketnoi.executeQuery(sql_dapanB);
                            }
                            if (rd_TrueC4.Checked)
                            {
                                sql_dapanC = "insert into DAPAN values('" + dr_dethi.Text + "_" + (thutucau1 + 3) + "_3','" + txt_C4.Text + "','True','" + dr_dethi.Text + "_" + (thutucau1 + 3) + "')";
                                ketnoi.executeQuery(sql_dapanC);

                            }
                            else
                            {
                                sql_dapanC = "insert into DAPAN values('" + dr_dethi.Text + "_" + (thutucau1 + 3) + "_3','" + txt_C4.Text + "','False','" + dr_dethi.Text + "_" + (thutucau1 + 3) + "')";
                                ketnoi.executeQuery(sql_dapanC);

                            }

                            if (rd_TrueD4.Checked)
                            {
                                sql_dapanD = "insert into DAPAN values('" + dr_dethi.Text + "_" + (thutucau1 + 3) + "_4','" + txt_D4.Text + "','True','" + dr_dethi.Text + "_" + (thutucau1 + 3) + "')";
                                ketnoi.executeQuery(sql_dapanD);
                            }
                            else
                            {
                                sql_dapanD = "insert into DAPAN values('" + dr_dethi.Text + "_" + (thutucau1 + 3) + "_4','" + txt_D4.Text + "','False','" + dr_dethi.Text + "_" + (thutucau1 + 3) + "')";
                                ketnoi.executeQuery(sql_dapanD);
                            }
                        }
                        catch { }
                        // dap an 5
                        try
                        {
                            if (rd_TrueA5.Checked)
                            {
                                sql_dapanA = "insert into DAPAN values('" + dr_dethi.Text + "_" + (thutucau1 + 4) + "_1','" + txt_A5.Text + "','True','" + dr_dethi.Text + "_" + (thutucau1 + 4) + "')";
                                ketnoi.executeQuery(sql_dapanA);
                            }
                            else
                            {
                                sql_dapanA = "insert into DAPAN values('" + dr_dethi.Text + "_" + (thutucau1 + 4) + "_1','" + txt_A5.Text + "','False','" + dr_dethi.Text + "_" + (thutucau1 + 4) + "')";
                                ketnoi.executeQuery(sql_dapanA);
                            }
                            if (rd_TrueB5.Checked)
                            {
                                sql_dapanB = "insert into DAPAN values('" + dr_dethi.Text + "_" + (thutucau1 + 4) + "_2','" + txt_B5.Text + "','True','" + dr_dethi.Text + "_" + (thutucau1 + 4) + "')";
                                ketnoi.executeQuery(sql_dapanB);
                            }
                            else
                            {
                                sql_dapanB = "insert into DAPAN values('" + dr_dethi.Text + "_" + (thutucau1 + 4) + "_2','" + txt_B5.Text + "','False','" + dr_dethi.Text + "_" + (thutucau1 + 4) + "')";
                                ketnoi.executeQuery(sql_dapanB);
                            }
                            if (rd_TrueC5.Checked)
                            {
                                sql_dapanC = "insert into DAPAN values('" + dr_dethi.Text + "_" + (thutucau1 + 4) + "_3','" + txt_C5.Text + "','True','" + dr_dethi.Text + "_" + (thutucau1 + 4) + "')";
                                ketnoi.executeQuery(sql_dapanC);

                            }
                            else
                            {
                                sql_dapanC = "insert into DAPAN values('" + dr_dethi.Text + "_" + (thutucau1 + 4) + "_3','" + txt_C5.Text + "','False','" + dr_dethi.Text + "_" + (thutucau1 + 4) + "')";
                                ketnoi.executeQuery(sql_dapanC);

                            }

                            if (rd_TrueD5.Checked)
                            {
                                sql_dapanD = "insert into DAPAN values('" + dr_dethi.Text + "_" + (thutucau1 + 4) + "_4','" + txt_D5.Text + "','True','" + dr_dethi.Text + "_" + (thutucau1 + 4) + "')";
                                ketnoi.executeQuery(sql_dapanD);
                            }
                            else
                            {
                                sql_dapanD = "insert into DAPAN values('" + dr_dethi.Text + "_" + (thutucau1 + 4) + "_4','" + txt_D5.Text + "','False','" + dr_dethi.Text + "_" + (thutucau1 + 4) + "')";
                                ketnoi.executeQuery(sql_dapanD);
                            }

                        }
                        catch { }

                        Response.Write("<script>alert('Thêm câu hỏi thành công!'); </script>");
                    }
                    catch
                    {
                        Response.Write("<script>alert('Thêm câu hỏi không thành công!'); </script>");
                    }
                
            
        }
        else if (dr_noidung.Text.Trim() == "SinglePassage")
        {
                fileNghe.Visible = false;
                    soluongcauhoi.Visible = true;
                    causo.Visible = true;
                    id_caubatdau.Visible = true;
                    noidungdoanvan.Visible = true;
                    string sql_dethi = "select * from DETHI where Made='0" + dr_dethi.Text + "_Single'";
                    DataTable tb_dethi = ketnoi.getData(sql_dethi);
                    if (tb_dethi.Rows.Count == 0)
                    {
                        string sql_insert = "insert into DETHI values('0" + dr_dethi.Text + "_Single',N'Đề 0" + dr_dethi.Text + "',getdate(),NULL,'SinglePassage')";
                        ketnoi.executeQuery(sql_insert);
                    }

                    try
                    {


                        string sql_dapanA;
                        string sql_dapanB;
                        string sql_dapanC;
                        string sql_dapanD;

                        int soluongcau = Int32.Parse(dr_soluong.Text);
                        int thutucau = Int32.Parse(dr_socauhoi.Text);

                        for (int i = 1; i <= soluongcau; i++)
                        {

                            try
                            {
                                string sql_cauhoi;
                                string noidung;
                                if (i == 1)
                                    noidung = txt_doanvan.Text;
                                else
                                    noidung = "";
                                if (i == 1)
                                {
                                    sql_cauhoi = "insert into CAUHOI values('" + dr_dethi.Text + "_Single_" + thutucau + "','" + noidung + "','" + txt_cauhoi1.Text + "','SinglePassage',NULL,'0" + dr_dethi.Text + "_Single')";
                                    ketnoi.executeQuery(sql_cauhoi);
                                }
                                else if (i == 2)
                                {
                                    sql_cauhoi = "insert into CAUHOI values('" + dr_dethi.Text + "_Single_" + thutucau + "','','" + txt_cauhoi2.Text + "','SinglePassage',NULL,'0" + dr_dethi.Text + "_Single')";
                                    ketnoi.executeQuery(sql_cauhoi);
                                }
                                else if (i == 3)
                                {
                                    sql_cauhoi = "insert into CAUHOI values('" + dr_dethi.Text + "_Single_" + thutucau + "','','" + txt_cauhoi3.Text + "','SinglePassage',NULL,'0" + dr_dethi.Text + "_Single')";
                                    ketnoi.executeQuery(sql_cauhoi);
                                }
                                else if (i == 4)
                                {
                                    sql_cauhoi = "insert into CAUHOI values('" + dr_dethi.Text + "_Single_" + thutucau + "','','" + txt_cauhoi4.Text + "','SinglePassage',NULL,'0" + dr_dethi.Text + "_Single')";
                                    ketnoi.executeQuery(sql_cauhoi);
                                }
                                else if (i == 5)
                                {
                                    sql_cauhoi = "insert into CAUHOI values('" + dr_dethi.Text + "_Single_" + thutucau + "','','" + txt_cauhoi5.Text + "','SinglePassage',NULL,'0" + dr_dethi.Text + "_Single')";
                                    ketnoi.executeQuery(sql_cauhoi);
                                }

                                thutucau++;
                            }
                            catch
                            {
                                Response.Write("<script> alert('Câu hỏi: " + dr_dethi.Text + "_Single_" + thutucau + " đã tồn tại') </script>");
                                break;
                            }
                        }
                         int thutucau1 = Int32.Parse(dr_socauhoi.Text);
                        if (rd_TrueA1.Checked)
                        {
                            sql_dapanA = "insert into DAPAN values('" + dr_dethi.Text + "_Single_" + thutucau1 + "_1','" + txt_A1.Text + "','True','" + dr_dethi.Text + "_Single_" + thutucau1 + "')";

                            ketnoi.executeQuery(sql_dapanA);
                        }
                        else
                        {
                            sql_dapanA = "insert into DAPAN values('" + dr_dethi.Text + "_Single_" + thutucau1 + "_1','" + txt_A1.Text + "','False','" + dr_dethi.Text + "_Single_" + thutucau1 + "')";
                            ketnoi.executeQuery(sql_dapanA);
                        }
                        if (rd_TrueB1.Checked)
                        {
                            sql_dapanB = "insert into DAPAN values('" + dr_dethi.Text + "_Single_" + thutucau1 + "_2','" + txt_B1.Text + "','True','" + dr_dethi.Text + "_Single_" + thutucau1 + "')";
                            ketnoi.executeQuery(sql_dapanB);
                        }
                        else
                        {
                            sql_dapanB = "insert into DAPAN values('" + dr_dethi.Text + "_Single_" + thutucau1 + "_2','" + txt_B1.Text + "','False','" + dr_dethi.Text + "_Single_" + thutucau1 + "')";
                            ketnoi.executeQuery(sql_dapanB);
                        }
                        if (rd_TrueC1.Checked)
                        {
                            sql_dapanC = "insert into DAPAN values('" + dr_dethi.Text + "_Single_" + thutucau1 + "_3','" + txt_C1.Text + "','True','" + dr_dethi.Text + "_Single_" + thutucau1 + "')";
                            ketnoi.executeQuery(sql_dapanC);

                        }
                        else
                        {
                            sql_dapanC = "insert into DAPAN values('" + dr_dethi.Text + "_Single_" + thutucau1 + "_3','" + txt_C1.Text + "','False','" + dr_dethi.Text + "_Single_" + thutucau1 + "')";
                            ketnoi.executeQuery(sql_dapanC);

                        }

                        if (rd_TrueD1.Checked)
                        {
                            sql_dapanD = "insert into DAPAN values('" + dr_dethi.Text + "_Single_" + thutucau1 + "_4','" + txt_D1.Text + "','True','" + dr_dethi.Text + "_Single_" + thutucau1 + "')";
                            ketnoi.executeQuery(sql_dapanD);
                        }
                        else
                        {
                            sql_dapanD = "insert into DAPAN values('" + dr_dethi.Text + "_Single_" + thutucau1 + "_4','" + txt_D1.Text + "','False','" + dr_dethi.Text + "_Single_" + thutucau1 + "')";
                            ketnoi.executeQuery(sql_dapanD);
                        }

                        // dap an 2
                        try
                        {
                            if (rd_TrueA2.Checked)
                            {
                                sql_dapanA = "insert into DAPAN values('" + dr_dethi.Text + "_Single_" + (thutucau1 + 1) + "_1','" + txt_A2.Text + "','True','" + dr_dethi.Text + "_Single_" + (thutucau1 + 1) + "')";
                                ketnoi.executeQuery(sql_dapanA);
                            }
                            else
                            {
                                sql_dapanA = "insert into DAPAN values('" + dr_dethi.Text + "_Single_" + (thutucau1 + 1) + "_1','" + txt_A2.Text + "','False','" + dr_dethi.Text + "_Single_" + (thutucau1 + 1) + "')";
                                ketnoi.executeQuery(sql_dapanA);
                            }
                            if (rd_TrueB2.Checked)
                            {
                                sql_dapanB = "insert into DAPAN values('" + dr_dethi.Text + "_Single_" + (thutucau1 + 1) + "_2','" + txt_B2.Text + "','True','" + dr_dethi.Text + "_Single_" + (thutucau1 + 1) + "')";
                                ketnoi.executeQuery(sql_dapanB);
                            }
                            else
                            {
                                sql_dapanB = "insert into DAPAN values('" + dr_dethi.Text + "_Single_" + (thutucau1 + 1) + "_2','" + txt_B2.Text + "','False','" + dr_dethi.Text + "_Single_" + (thutucau1 + 1) + "')";
                                ketnoi.executeQuery(sql_dapanB);
                            }
                            if (rd_TrueC2.Checked)
                            {
                                sql_dapanC = "insert into DAPAN values('" + dr_dethi.Text + "_Single_" + (thutucau1 + 1) + "_3','" + txt_C2.Text + "','True','" + dr_dethi.Text + "_Single_" + (thutucau1 + 1) + "')";
                                ketnoi.executeQuery(sql_dapanC);

                            }
                            else
                            {
                                sql_dapanC = "insert into DAPAN values('" + dr_dethi.Text + "_Single_" + (thutucau1 + 1) + "_3','" + txt_C2.Text + "','False','" + dr_dethi.Text + "_Single_" + (thutucau1 + 1) + "')";
                                ketnoi.executeQuery(sql_dapanC);

                            }

                            if (rd_TrueD2.Checked)
                            {
                                sql_dapanD = "insert into DAPAN values('" + dr_dethi.Text + "_Single_" + (thutucau1 + 1) + "_4','" + txt_D2.Text + "','True','" + dr_dethi.Text + "_Single_" + (thutucau1 + 1) + "')";
                                ketnoi.executeQuery(sql_dapanD);
                            }
                            else
                            {
                                sql_dapanD = "insert into DAPAN values('" + dr_dethi.Text + "_Single_" + (thutucau1 + 1) + "_4','" + txt_D2.Text + "','False','" + dr_dethi.Text + "_Single_" + (thutucau1 + 1) + "')";
                                ketnoi.executeQuery(sql_dapanD);
                            }
                        }
                        catch { }

                        // dap an 3
                        try
                        {
                            if (rd_TrueA3.Checked)
                            {
                                sql_dapanA = "insert into DAPAN values('" + dr_dethi.Text + "_Single_" + (thutucau1 + 2) + "_1','" + txt_A3.Text + "','True','" + dr_dethi.Text + "_Single_" + (thutucau1 + 2) + "')";
                                ketnoi.executeQuery(sql_dapanA);
                            }
                            else
                            {
                                sql_dapanA = "insert into DAPAN values('" + dr_dethi.Text + "_Single_" + (thutucau1 + 2) + "_1','" + txt_A3.Text + "','False','" + dr_dethi.Text + "_Single_" + (thutucau1 + 2) + "')";
                                ketnoi.executeQuery(sql_dapanA);
                            }
                            if (rd_TrueB3.Checked)
                            {
                                sql_dapanB = "insert into DAPAN values('" + dr_dethi.Text + "_Single_" + (thutucau1 + 2) + "_2','" + txt_B3.Text + "','True','" + dr_dethi.Text + "_Single_" + (thutucau1 + 2) + "')";
                                ketnoi.executeQuery(sql_dapanB);
                            }
                            else
                            {
                                sql_dapanB = "insert into DAPAN values('" + dr_dethi.Text + "_Single_" + (thutucau1 + 2) + "_2','" + txt_B3.Text + "','False','" + dr_dethi.Text + "_Single_" + (thutucau1 + 2) + "')";
                                ketnoi.executeQuery(sql_dapanB);
                            }
                            if (rd_TrueC3.Checked)
                            {
                                sql_dapanC = "insert into DAPAN values('" + dr_dethi.Text + "_Single_" + (thutucau1 + 2) + "_3','" + txt_C3.Text + "','True','" + dr_dethi.Text + "_Single_" + (thutucau1 + 2) + "')";
                                ketnoi.executeQuery(sql_dapanC);

                            }
                            else
                            {
                                sql_dapanC = "insert into DAPAN values('" + dr_dethi.Text + "_Single_" + (thutucau1 + 2) + "_3','" + txt_C3.Text + "','False','" + dr_dethi.Text + "_Single_" + (thutucau1 + 2) + "')";
                                ketnoi.executeQuery(sql_dapanC);

                            }

                            if (rd_TrueD3.Checked)
                            {
                                sql_dapanD = "insert into DAPAN values('" + dr_dethi.Text + "_Single_" + (thutucau1 + 2) + "_4','" + txt_D3.Text + "','True','" + dr_dethi.Text + "_Single_" + (thutucau1 + 2) + "')";
                                ketnoi.executeQuery(sql_dapanD);
                            }
                            else
                            {
                                sql_dapanD = "insert into DAPAN values('" + dr_dethi.Text + "_Single_" + (thutucau1 + 2) + "_4','" + txt_D3.Text + "','False','" + dr_dethi.Text + "_Single_" + (thutucau1 + 2) + "')";
                                ketnoi.executeQuery(sql_dapanD);
                            }
                        }
                        catch { }
                        // dap an 4
                        try
                        {

                            if (rd_TrueA4.Checked)
                            {
                                sql_dapanA = "insert into DAPAN values('" + dr_dethi.Text + "_Single_" + (thutucau1 + 3) + "_1','" + txt_A4.Text + "','True','" + dr_dethi.Text + "_Single_" + (thutucau1 + 3) + "')";
                                ketnoi.executeQuery(sql_dapanA);
                            }
                            else
                            {
                                sql_dapanA = "insert into DAPAN values('" + dr_dethi.Text + "_Single_" + (thutucau1 + 3) + "_1','" + txt_A1.Text + "','False','" + dr_dethi.Text + "_Single_" + (thutucau1 + 3) + "')";
                                ketnoi.executeQuery(sql_dapanA);
                            }
                            if (rd_TrueB4.Checked)
                            {
                                sql_dapanB = "insert into DAPAN values('" + dr_dethi.Text + "_Single_" + (thutucau1 + 3) + "_2','" + txt_B4.Text + "','True','" + dr_dethi.Text + "_Single_" + (thutucau1 + 3) + "')";
                                ketnoi.executeQuery(sql_dapanB);
                            }
                            else
                            {
                                sql_dapanB = "insert into DAPAN values('" + dr_dethi.Text + "_Single_" + (thutucau1 + 3) + "_2','" + txt_B4.Text + "','False','" + dr_dethi.Text + "_Single_" + (thutucau1 + 3) + "')";
                                ketnoi.executeQuery(sql_dapanB);
                            }
                            if (rd_TrueC4.Checked)
                            {
                                sql_dapanC = "insert into DAPAN values('" + dr_dethi.Text + "_Single_" + (thutucau1 + 3) + "_3','" + txt_C4.Text + "','True','" + dr_dethi.Text + "_Single_" + (thutucau1 + 3) + "')";
                                ketnoi.executeQuery(sql_dapanC);

                            }
                            else
                            {
                                sql_dapanC = "insert into DAPAN values('" + dr_dethi.Text + "_Single_" + (thutucau1 + 3) + "_3','" + txt_C4.Text + "','False','" + dr_dethi.Text + "_Single_" + (thutucau1 + 3) + "')";
                                ketnoi.executeQuery(sql_dapanC);

                            }

                            if (rd_TrueD4.Checked)
                            {
                                sql_dapanD = "insert into DAPAN values('" + dr_dethi.Text + "_Single_" + (thutucau1 + 3) + "_4','" + txt_D4.Text + "','True','" + dr_dethi.Text + "_Single_" + (thutucau1 + 3) + "')";
                                ketnoi.executeQuery(sql_dapanD);
                            }
                            else
                            {
                                sql_dapanD = "insert into DAPAN values('" + dr_dethi.Text + "_Single_" + (thutucau1 + 3) + "_4','" + txt_D4.Text + "','False','" + dr_dethi.Text + "_Single_" + (thutucau1 + 3) + "')";
                                ketnoi.executeQuery(sql_dapanD);
                            }
                        }
                        catch { }
                        // dap an 5
                        try
                        {
                            if (rd_TrueA5.Checked)
                            {
                                sql_dapanA = "insert into DAPAN values('" + dr_dethi.Text + "_Single_" + (thutucau1 + 4) + "_1','" + txt_A5.Text + "','True','" + dr_dethi.Text + "_Single_" + (thutucau1 + 4) + "')";
                                ketnoi.executeQuery(sql_dapanA);
                            }
                            else
                            {
                                sql_dapanA = "insert into DAPAN values('" + dr_dethi.Text + "_Single_" + (thutucau1 + 4) + "_1','" + txt_A5.Text + "','False','" + dr_dethi.Text + "_Single_" + (thutucau1 + 4) + "')";
                                ketnoi.executeQuery(sql_dapanA);
                            }
                            if (rd_TrueB5.Checked)
                            {
                                sql_dapanB = "insert into DAPAN values('" + dr_dethi.Text + "_Single_" + (thutucau1 + 4) + "_2','" + txt_B5.Text + "','True','" + dr_dethi.Text + "_Single_" + (thutucau1 + 4) + "')";
                                ketnoi.executeQuery(sql_dapanB);
                            }
                            else
                            {
                                sql_dapanB = "insert into DAPAN values('" + dr_dethi.Text + "_Single_" + (thutucau1 + 4) + "_2','" + txt_B5.Text + "','False','" + dr_dethi.Text + "_Single_" + (thutucau1 + 4) + "')";
                                ketnoi.executeQuery(sql_dapanB);
                            }
                            if (rd_TrueC5.Checked)
                            {
                                sql_dapanC = "insert into DAPAN values('" + dr_dethi.Text + "_Single_" + (thutucau1 + 4) + "_3','" + txt_C5.Text + "','True','" + dr_dethi.Text + "_Single_" + (thutucau1 + 4) + "')";
                                ketnoi.executeQuery(sql_dapanC);

                            }
                            else
                            {
                                sql_dapanC = "insert into DAPAN values('" + dr_dethi.Text + "_Single_" + (thutucau1 + 4) + "_3','" + txt_C5.Text + "','False','" + dr_dethi.Text + "_Single_" + (thutucau1 + 4) + "')";
                                ketnoi.executeQuery(sql_dapanC);

                            }

                            if (rd_TrueD5.Checked)
                            {
                                sql_dapanD = "insert into DAPAN values('" + dr_dethi.Text + "_Single_" + (thutucau1 + 4) + "_4','" + txt_D5.Text + "','True','" + dr_dethi.Text + "_Single_" + (thutucau1 + 4) + "')";
                                ketnoi.executeQuery(sql_dapanD);
                            }
                            else
                            {
                                sql_dapanD = "insert into DAPAN values('" + dr_dethi.Text + "_Single_" + (thutucau1 + 4) + "_4','" + txt_D5.Text + "','False','" + dr_dethi.Text + "_Single_" + (thutucau1 + 4) + "')";
                                ketnoi.executeQuery(sql_dapanD);
                            }

                        }
                        catch { }

                        Response.Write("<script>alert('Thêm câu hỏi thành công!'); </script>");
                    }
                    catch
                    {
                        Response.Write("<script>alert('Thêm câu hỏi không thành công!'); </script>");
                    }
            
        }

        else if (dr_noidung.Text.Trim() == "SinglePassagetest")
        {
                 fileNghe.Visible = false;
                    soluongcauhoi.Visible = true;
                    causo.Visible = true;
                    id_caubatdau.Visible = true;
                    noidungdoanvan.Visible = true;

                    string sql_dethi;
                    if (dr_capdo.Text == "Tonghop" || dr_capdo.Text == "0")

                        sql_dethi = "select * from DETHI where Made='0" + dr_dethi.Text + "'";
                    else
                        sql_dethi = "select * from DETHI where Made='0" + dr_dethi.Text + "_" + dr_capdo.Text + "'";
                    DataTable tb_dethi = ketnoi.getData(sql_dethi);
                    if (tb_dethi.Rows.Count == 0)
                    {
                        string sql_insert;
                        if (dr_capdo.Text == "Tonghop" || dr_capdo.Text == "0")
                        {
                            sql_insert = "insert into DETHI values('0" + dr_dethi.Text + "',N'Đề 0" + dr_dethi.Text + "',getdate(),NULL,'" + dr_capdo.Text + "')";
                        }
                        else
                        {
                            sql_insert = "insert into DETHI values('0" + dr_dethi.Text + "_" + dr_capdo.Text + "',N'Đề 0" + dr_dethi.Text + "',getdate(),NULL,'" + dr_capdo.Text + "')";
                        }
                        ketnoi.executeQuery(sql_insert);
                    }
            try
                    {


                        string sql_dapanA;
                        string sql_dapanB;
                        string sql_dapanC;
                        string sql_dapanD;

                        int soluongcau = Int32.Parse(dr_soluong.Text);
                        int thutucau = Int32.Parse(dr_socauhoi.Text);

                        for (int i = 1; i <= soluongcau; i++)
                        {
                      try
                            {
                                string sql_cauhoi;
                                string noidung;
                                if (i == 1)
                                    noidung = txt_doanvan.Text;
                                else
                                    noidung = "";
                                if (i == 1)
                                {
                                    sql_cauhoi = "insert into CAUHOI values('" + dr_dethi.Text + "_" + thutucau + "','" + noidung + "','" + txt_cauhoi1.Text + "','SinglePassagetest',NULL,'0" + dr_dethi.Text + "')";
                                    ketnoi.executeQuery(sql_cauhoi);
                                }
                                else if (i == 2)
                                {
                                    sql_cauhoi = "insert into CAUHOI values('" + dr_dethi.Text + "_" + thutucau + "','','" + txt_cauhoi2.Text + "','SinglePassagetest',NULL,'0" + dr_dethi.Text + "')";
                                    ketnoi.executeQuery(sql_cauhoi);
                                }
                                else if (i == 3)
                                {
                                    sql_cauhoi = "insert into CAUHOI values('" + dr_dethi.Text + "_" + thutucau + "','','" + txt_cauhoi3.Text + "','SinglePassagetest',NULL,'0" + dr_dethi.Text + "')";
                                    ketnoi.executeQuery(sql_cauhoi);
                                }
                                else if (i == 4)
                                {
                                    sql_cauhoi = "insert into CAUHOI values('" + dr_dethi.Text + "_" + thutucau + "','','" + txt_cauhoi4.Text + "','SinglePassagetest',NULL,'0" + dr_dethi.Text + "')";
                                    ketnoi.executeQuery(sql_cauhoi);
                                }
                                else if (i == 5)
                                {
                                    sql_cauhoi = "insert into CAUHOI values('" + dr_dethi.Text + "_" + thutucau + "','','" + txt_cauhoi5.Text + "','SinglePassagetest',NULL,'0" + dr_dethi.Text + "')";
                                    ketnoi.executeQuery(sql_cauhoi);
                                }

                                thutucau++;
                            }
                            catch
                            {
                                Response.Write("<script> alert('Câu hỏi: " + dr_dethi.Text + "_" + thutucau + " đã tồn tại') </script>");
                                break;
                            }
                        }
                        int thutucau1 = Int32.Parse(dr_socauhoi.Text);
                        if (rd_TrueA1.Checked)
                        {
                            sql_dapanA = "insert into DAPAN values('" + dr_dethi.Text + "_" + thutucau1 + "_1','" + txt_A1.Text + "','True','" + dr_dethi.Text + "_" + thutucau1 + "')";

                            ketnoi.executeQuery(sql_dapanA);
                        }
                        else
                        {
                            sql_dapanA = "insert into DAPAN values('" + dr_dethi.Text + "_" + thutucau1 + "_1','" + txt_A1.Text + "','False','" + dr_dethi.Text + "_" + thutucau1 + "')";
                            ketnoi.executeQuery(sql_dapanA);
                        }
                        if (rd_TrueB1.Checked)
                        {
                            sql_dapanB = "insert into DAPAN values('" + dr_dethi.Text + "_" + thutucau1 + "_2','" + txt_B1.Text + "','True','" + dr_dethi.Text + "_" + thutucau1 + "')";
                            ketnoi.executeQuery(sql_dapanB);
                        }
                        else
                        {
                            sql_dapanB = "insert into DAPAN values('" + dr_dethi.Text + "_" + thutucau1 + "_2','" + txt_B1.Text + "','False','" + dr_dethi.Text + "_" + thutucau1 + "')";
                            ketnoi.executeQuery(sql_dapanB);
                        }
                        if (rd_TrueC1.Checked)
                        {
                            sql_dapanC = "insert into DAPAN values('" + dr_dethi.Text + "_" + thutucau1 + "_3','" + txt_C1.Text + "','True','" + dr_dethi.Text + "_" + thutucau1 + "')";
                            ketnoi.executeQuery(sql_dapanC);

                        }
                        else
                        {
                            sql_dapanC = "insert into DAPAN values('" + dr_dethi.Text + "_" + thutucau1 + "_3','" + txt_C1.Text + "','False','" + dr_dethi.Text + "_" + thutucau1 + "')";
                            ketnoi.executeQuery(sql_dapanC);

                        }

                        if (rd_TrueD1.Checked)
                        {
                            sql_dapanD = "insert into DAPAN values('" + dr_dethi.Text + "_" + thutucau1 + "_4','" + txt_D1.Text + "','True','" + dr_dethi.Text + "_" + thutucau1 + "')";
                            ketnoi.executeQuery(sql_dapanD);
                        }
                        else
                        {
                            sql_dapanD = "insert into DAPAN values('" + dr_dethi.Text + "_" + thutucau1 + "_4','" + txt_D1.Text + "','False','" + dr_dethi.Text + "_" + thutucau1 + "')";
                            ketnoi.executeQuery(sql_dapanD);
                        }

                        // dap an 2
                        try
                        {
                            if (rd_TrueA2.Checked)
                            {
                                sql_dapanA = "insert into DAPAN values('" + dr_dethi.Text + "_" + (thutucau1 + 1) + "_1','" + txt_A2.Text + "','True','" + dr_dethi.Text + "_" + (thutucau1 + 1) + "')";
                                ketnoi.executeQuery(sql_dapanA);
                            }
                            else
                            {
                                sql_dapanA = "insert into DAPAN values('" + dr_dethi.Text + "_" + (thutucau1 + 1) + "_1','" + txt_A2.Text + "','False','" + dr_dethi.Text + "_" + (thutucau1 + 1) + "')";
                                ketnoi.executeQuery(sql_dapanA);
                            }
                            if (rd_TrueB2.Checked)
                            {
                                sql_dapanB = "insert into DAPAN values('" + dr_dethi.Text + "_" + (thutucau1 + 1) + "_2','" + txt_B2.Text + "','True','" + dr_dethi.Text + "_" + (thutucau1 + 1) + "')";
                                ketnoi.executeQuery(sql_dapanB);
                            }
                            else
                            {
                                sql_dapanB = "insert into DAPAN values('" + dr_dethi.Text + "_" + (thutucau1 + 1) + "_2','" + txt_B2.Text + "','False','" + dr_dethi.Text + "_" + (thutucau1 + 1) + "')";
                                ketnoi.executeQuery(sql_dapanB);
                            }
                            if (rd_TrueC2.Checked)
                            {
                                sql_dapanC = "insert into DAPAN values('" + dr_dethi.Text + "_" + (thutucau1 + 1) + "_3','" + txt_C2.Text + "','True','" + dr_dethi.Text + "_" + (thutucau1 + 1) + "')";
                                ketnoi.executeQuery(sql_dapanC);

                            }
                            else
                            {
                                sql_dapanC = "insert into DAPAN values('" + dr_dethi.Text + "_" + (thutucau1 + 1) + "_3','" + txt_C2.Text + "','False','" + dr_dethi.Text + "_" + (thutucau1 + 1) + "')";
                                ketnoi.executeQuery(sql_dapanC);

                            }

                            if (rd_TrueD2.Checked)
                            {
                                sql_dapanD = "insert into DAPAN values('" + dr_dethi.Text + "_" + (thutucau1 + 1) + "_4','" + txt_D2.Text + "','True','" + dr_dethi.Text + "_" + (thutucau1 + 1) + "')";
                                ketnoi.executeQuery(sql_dapanD);
                            }
                            else
                            {
                                sql_dapanD = "insert into DAPAN values('" + dr_dethi.Text + "_" + (thutucau1 + 1) + "_4','" + txt_D2.Text + "','False','" + dr_dethi.Text + "_" + (thutucau1 + 1) + "')";
                                ketnoi.executeQuery(sql_dapanD);
                            }
                        }
                        catch { }

                        // dap an 3
                        try
                        {
                            if (rd_TrueA3.Checked)
                            {
                                sql_dapanA = "insert into DAPAN values('" + dr_dethi.Text + "_" + (thutucau1 + 2) + "_1','" + txt_A3.Text + "','True','" + dr_dethi.Text + "_" + (thutucau1 + 2) + "')";
                                ketnoi.executeQuery(sql_dapanA);
                            }
                            else
                            {
                                sql_dapanA = "insert into DAPAN values('" + dr_dethi.Text + "_" + (thutucau1 + 2) + "_1','" + txt_A3.Text + "','False','" + dr_dethi.Text + "_" + (thutucau1 + 2) + "')";
                                ketnoi.executeQuery(sql_dapanA);
                            }
                            if (rd_TrueB3.Checked)
                            {
                                sql_dapanB = "insert into DAPAN values('" + dr_dethi.Text + "_" + (thutucau1 + 2) + "_2','" + txt_B3.Text + "','True','" + dr_dethi.Text + "_" + (thutucau1 + 2) + "')";
                                ketnoi.executeQuery(sql_dapanB);
                            }
                            else
                            {
                                sql_dapanB = "insert into DAPAN values('" + dr_dethi.Text + "_" + (thutucau1 + 2) + "_2','" + txt_B3.Text + "','False','" + dr_dethi.Text + "_" + (thutucau1 + 2) + "')";
                                ketnoi.executeQuery(sql_dapanB);
                            }
                            if (rd_TrueC3.Checked)
                            {
                                sql_dapanC = "insert into DAPAN values('" + dr_dethi.Text + "_" + (thutucau1 + 2) + "_3','" + txt_C3.Text + "','True','" + dr_dethi.Text + "_" + (thutucau1 + 2) + "')";
                                ketnoi.executeQuery(sql_dapanC);

                            }
                            else
                            {
                                sql_dapanC = "insert into DAPAN values('" + dr_dethi.Text + "_" + (thutucau1 + 2) + "_3','" + txt_C3.Text + "','False','" + dr_dethi.Text + "_" + (thutucau1 + 2) + "')";
                                ketnoi.executeQuery(sql_dapanC);

                            }

                            if (rd_TrueD3.Checked)
                            {
                                sql_dapanD = "insert into DAPAN values('" + dr_dethi.Text + "_" + (thutucau1 + 2) + "_4','" + txt_D3.Text + "','True','" + dr_dethi.Text + "_" + (thutucau1 + 2) + "')";
                                ketnoi.executeQuery(sql_dapanD);
                            }
                            else
                            {
                                sql_dapanD = "insert into DAPAN values('" + dr_dethi.Text + "_" + (thutucau1 + 2) + "_4','" + txt_D3.Text + "','False','" + dr_dethi.Text + "_" + (thutucau1 + 2) + "')";
                                ketnoi.executeQuery(sql_dapanD);
                            }
                        }
                        catch { }
                        // dap an 4
                        try
                        {

                            if (rd_TrueA4.Checked)
                            {
                                sql_dapanA = "insert into DAPAN values('" + dr_dethi.Text + "_" + (thutucau1 + 3) + "_1','" + txt_A4.Text + "','True','" + dr_dethi.Text + "_" + (thutucau1 + 3) + "')";
                                ketnoi.executeQuery(sql_dapanA);
                            }
                            else
                            {
                                sql_dapanA = "insert into DAPAN values('" + dr_dethi.Text + "_" + (thutucau1 + 3) + "_1','" + txt_A1.Text + "','False','" + dr_dethi.Text + "_" + (thutucau1 + 3) + "')";
                                ketnoi.executeQuery(sql_dapanA);
                            }
                            if (rd_TrueB4.Checked)
                            {
                                sql_dapanB = "insert into DAPAN values('" + dr_dethi.Text + "_" + (thutucau1 + 3) + "_2','" + txt_B4.Text + "','True','" + dr_dethi.Text + "_" + (thutucau1 + 3) + "')";
                                ketnoi.executeQuery(sql_dapanB);
                            }
                            else
                            {
                                sql_dapanB = "insert into DAPAN values('" + dr_dethi.Text + "_" + (thutucau1 + 3) + "_2','" + txt_B4.Text + "','False','" + dr_dethi.Text + "_" + (thutucau1 + 3) + "')";
                                ketnoi.executeQuery(sql_dapanB);
                            }
                            if (rd_TrueC4.Checked)
                            {
                                sql_dapanC = "insert into DAPAN values('" + dr_dethi.Text + "_" + (thutucau1 + 3) + "_3','" + txt_C4.Text + "','True','" + dr_dethi.Text + "_" + (thutucau1 + 3) + "')";
                                ketnoi.executeQuery(sql_dapanC);

                            }
                            else
                            {
                                sql_dapanC = "insert into DAPAN values('" + dr_dethi.Text + "_" + (thutucau1 + 3) + "_3','" + txt_C4.Text + "','False','" + dr_dethi.Text + "_" + (thutucau1 + 3) + "')";
                                ketnoi.executeQuery(sql_dapanC);

                            }

                            if (rd_TrueD4.Checked)
                            {
                                sql_dapanD = "insert into DAPAN values('" + dr_dethi.Text + "_" + (thutucau1 + 3) + "_4','" + txt_D4.Text + "','True','" + dr_dethi.Text + "_" + (thutucau1 + 3) + "')";
                                ketnoi.executeQuery(sql_dapanD);
                            }
                            else
                            {
                                sql_dapanD = "insert into DAPAN values('" + dr_dethi.Text + "_" + (thutucau1 + 3) + "_4','" + txt_D4.Text + "','False','" + dr_dethi.Text + "_" + (thutucau1 + 3) + "')";
                                ketnoi.executeQuery(sql_dapanD);
                            }
                        }
                        catch { }
                        // dap an 5
                        try
                        {
                            if (rd_TrueA5.Checked)
                            {
                                sql_dapanA = "insert into DAPAN values('" + dr_dethi.Text + "_" + (thutucau1 + 4) + "_1','" + txt_A5.Text + "','True','" + dr_dethi.Text + "_" + (thutucau1 + 4) + "')";
                                ketnoi.executeQuery(sql_dapanA);
                            }
                            else
                            {
                                sql_dapanA = "insert into DAPAN values('" + dr_dethi.Text + "_" + (thutucau1 + 4) + "_1','" + txt_A5.Text + "','False','" + dr_dethi.Text + "_" + (thutucau1 + 4) + "')";
                                ketnoi.executeQuery(sql_dapanA);
                            }
                            if (rd_TrueB5.Checked)
                            {
                                sql_dapanB = "insert into DAPAN values('" + dr_dethi.Text + "_" + (thutucau1 + 4) + "_2','" + txt_B5.Text + "','True','" + dr_dethi.Text + "_" + (thutucau1 + 4) + "')";
                                ketnoi.executeQuery(sql_dapanB);
                            }
                            else
                            {
                                sql_dapanB = "insert into DAPAN values('" + dr_dethi.Text + "_" + (thutucau1 + 4) + "_2','" + txt_B5.Text + "','False','" + dr_dethi.Text + "_" + (thutucau1 + 4) + "')";
                                ketnoi.executeQuery(sql_dapanB);
                            }
                            if (rd_TrueC5.Checked)
                            {
                                sql_dapanC = "insert into DAPAN values('" + dr_dethi.Text + "_" + (thutucau1 + 4) + "_3','" + txt_C5.Text + "','True','" + dr_dethi.Text + "_" + (thutucau1 + 4) + "')";
                                ketnoi.executeQuery(sql_dapanC);

                            }
                            else
                            {
                                sql_dapanC = "insert into DAPAN values('" + dr_dethi.Text + "_" + (thutucau1 + 4) + "_3','" + txt_C5.Text + "','False','" + dr_dethi.Text + "_" + (thutucau1 + 4) + "')";
                                ketnoi.executeQuery(sql_dapanC);

                            }

                            if (rd_TrueD5.Checked)
                            {
                                sql_dapanD = "insert into DAPAN values('" + dr_dethi.Text + "_" + (thutucau1 + 4) + "_4','" + txt_D5.Text + "','True','" + dr_dethi.Text + "_" + (thutucau1 + 4) + "')";
                                ketnoi.executeQuery(sql_dapanD);
                            }
                            else
                            {
                                sql_dapanD = "insert into DAPAN values('" + dr_dethi.Text + "_" + (thutucau1 + 4) + "_4','" + txt_D5.Text + "','False','" + dr_dethi.Text + "_" + (thutucau1 + 4) + "')";
                                ketnoi.executeQuery(sql_dapanD);
                            }

                        }
                        catch { }

                        Response.Write("<script>alert('Thêm câu hỏi thành công!'); </script>");
                    }
            catch
            {
                Response.Write("<script>alert('Thêm câu hỏi không thành công!'); </script>");
            }
                
                
            
        }
        else if (dr_noidung.Text.Trim() == "DoublePassage")
        {
            fileNghe.Visible = false;
            soluongcauhoi.Visible = true;
            causo.Visible = true;
            id_caubatdau.Visible = true;
            noidungdoanvan.Visible = true;
            string sql_dethi = "select * from DETHI where Made='0" + dr_dethi.Text + "_Double'";
            DataTable tb_dethi = ketnoi.getData(sql_dethi);
            if (tb_dethi.Rows.Count == 0)
            {
                string sql_insert = "insert into DETHI values('0" + dr_dethi.Text + "_Double',N'Đề 0" + dr_dethi.Text + "',getdate(),NULL,'DoublePassage')";
                ketnoi.executeQuery(sql_insert);
            }

            try
            {


                string sql_dapanA;
                string sql_dapanB;
                string sql_dapanC;
                string sql_dapanD;

                int soluongcau = Int32.Parse(dr_soluong.Text);
                int thutucau = Int32.Parse(dr_socauhoi.Text);

                for (int i = 1; i <= soluongcau; i++)
                {

                    try
                    {
                        string sql_cauhoi;
                        string noidung;
                        if (i == 1)
                            noidung = txt_doanvan.Text;
                        else
                            noidung = "";
                        if (i == 1)
                        {
                            sql_cauhoi = "insert into CAUHOI values('" + dr_dethi.Text + "_Double_" + thutucau + "','" + noidung + "','" + txt_cauhoi1.Text + "','DoublePassage',NULL,'0" + dr_dethi.Text + "_Double')";
                            ketnoi.executeQuery(sql_cauhoi);
                        }
                        else if (i == 2)
                        {
                            sql_cauhoi = "insert into CAUHOI values('" + dr_dethi.Text + "_Double_" + thutucau + "','','" + txt_cauhoi2.Text + "','DoublePassage',NULL,'0" + dr_dethi.Text + "_Double')";
                            ketnoi.executeQuery(sql_cauhoi);
                        }
                        else if (i == 3)
                        {
                            sql_cauhoi = "insert into CAUHOI values('" + dr_dethi.Text + "_Double_" + thutucau + "','','" + txt_cauhoi3.Text + "','DoublePassage',NULL,'0" + dr_dethi.Text + "_Double')";
                            ketnoi.executeQuery(sql_cauhoi);
                        }
                        else if (i == 4)
                        {
                            sql_cauhoi = "insert into CAUHOI values('" + dr_dethi.Text + "_Double_" + thutucau + "','','" + txt_cauhoi4.Text + "','DoublePassage',NULL,'0" + dr_dethi.Text + "_Double')";
                            ketnoi.executeQuery(sql_cauhoi);
                        }
                        else if (i == 5)
                        {
                            sql_cauhoi = "insert into CAUHOI values('" + dr_dethi.Text + "_Double_" + thutucau + "','','" + txt_cauhoi5.Text + "','DoublePassage',NULL,'0" + dr_dethi.Text + "')";
                            ketnoi.executeQuery(sql_cauhoi);
                        }

                        thutucau++;
                    }
                    catch
                    {
                        Response.Write("<script> alert('Câu hỏi: " + dr_dethi.Text + "_Double_" + thutucau + " đã tồn tại') </script>");
                        break;
                    }
                }
                int thutucau1 = Int32.Parse(dr_socauhoi.Text);
                if (rd_TrueA1.Checked)
                {
                    sql_dapanA = "insert into DAPAN values('" + dr_dethi.Text + "_Double_" + thutucau1 + "_1','" + txt_A1.Text + "','True','" + dr_dethi.Text + "_Double_" + thutucau1 + "')";

                    ketnoi.executeQuery(sql_dapanA);
                }
                else
                {
                    sql_dapanA = "insert into DAPAN values('" + dr_dethi.Text + "_Double_" + thutucau1 + "_1','" + txt_A1.Text + "','False','" + dr_dethi.Text + "_Double_" + thutucau1 + "')";
                    ketnoi.executeQuery(sql_dapanA);
                }
                if (rd_TrueB1.Checked)
                {
                    sql_dapanB = "insert into DAPAN values('" + dr_dethi.Text + "_Double_" + thutucau1 + "_2','" + txt_B1.Text + "','True','" + dr_dethi.Text + "_Double_" + thutucau1 + "')";
                    ketnoi.executeQuery(sql_dapanB);
                }
                else
                {
                    sql_dapanB = "insert into DAPAN values('" + dr_dethi.Text + "_Double_" + thutucau1 + "_2','" + txt_B1.Text + "','False','" + dr_dethi.Text + "_Double_" + thutucau1 + "')";
                    ketnoi.executeQuery(sql_dapanB);
                }
                if (rd_TrueC1.Checked)
                {
                    sql_dapanC = "insert into DAPAN values('" + dr_dethi.Text + "_Double_" + thutucau1 + "_3','" + txt_C1.Text + "','True','" + dr_dethi.Text + "_Double_" + thutucau1 + "')";
                    ketnoi.executeQuery(sql_dapanC);

                }
                else
                {
                    sql_dapanC = "insert into DAPAN values('" + dr_dethi.Text + "_Double_" + thutucau1 + "_3','" + txt_C1.Text + "','False','" + dr_dethi.Text + "_Double_" + thutucau1 + "')";
                    ketnoi.executeQuery(sql_dapanC);

                }

                if (rd_TrueD1.Checked)
                {
                    sql_dapanD = "insert into DAPAN values('" + dr_dethi.Text + "_Double_" + thutucau1 + "_4','" + txt_D1.Text + "','True','" + dr_dethi.Text + "_Double_" + thutucau1 + "')";
                    ketnoi.executeQuery(sql_dapanD);
                }
                else
                {
                    sql_dapanD = "insert into DAPAN values('" + dr_dethi.Text + "_Double_" + thutucau1 + "_4','" + txt_D1.Text + "','False','" + dr_dethi.Text + "_Double_" + thutucau1 + "')";
                    ketnoi.executeQuery(sql_dapanD);
                }

                // dap an 2
                try
                {
                    if (rd_TrueA2.Checked)
                    {
                        sql_dapanA = "insert into DAPAN values('" + dr_dethi.Text + "_Double_" + (thutucau1 + 1) + "_1','" + txt_A2.Text + "','True','" + dr_dethi.Text + "_Double_" + (thutucau1 + 1) + "')";
                        ketnoi.executeQuery(sql_dapanA);
                    }
                    else
                    {
                        sql_dapanA = "insert into DAPAN values('" + dr_dethi.Text + "_Double_" + (thutucau1 + 1) + "_1','" + txt_A2.Text + "','False','" + dr_dethi.Text + "_Double_" + (thutucau1 + 1) + "')";
                        ketnoi.executeQuery(sql_dapanA);
                    }
                    if (rd_TrueB2.Checked)
                    {
                        sql_dapanB = "insert into DAPAN values('" + dr_dethi.Text + "_Double_" + (thutucau1 + 1) + "_2','" + txt_B2.Text + "','True','" + dr_dethi.Text + "_Double_" + (thutucau1 + 1) + "')";
                        ketnoi.executeQuery(sql_dapanB);
                    }
                    else
                    {
                        sql_dapanB = "insert into DAPAN values('" + dr_dethi.Text + "_Double_" + (thutucau1 + 1) + "_2','" + txt_B2.Text + "','False','" + dr_dethi.Text + "_Double_" + (thutucau1 + 1) + "')";
                        ketnoi.executeQuery(sql_dapanB);
                    }
                    if (rd_TrueC2.Checked)
                    {
                        sql_dapanC = "insert into DAPAN values('" + dr_dethi.Text + "_Double_" + (thutucau1 + 1) + "_3','" + txt_C2.Text + "','True','" + dr_dethi.Text + "_Double_" + (thutucau1 + 1) + "')";
                        ketnoi.executeQuery(sql_dapanC);

                    }
                    else
                    {
                        sql_dapanC = "insert into DAPAN values('" + dr_dethi.Text + "_Double_" + (thutucau1 + 1) + "_3','" + txt_C2.Text + "','False','" + dr_dethi.Text + "_Double_" + (thutucau1 + 1) + "')";
                        ketnoi.executeQuery(sql_dapanC);

                    }

                    if (rd_TrueD2.Checked)
                    {
                        sql_dapanD = "insert into DAPAN values('" + dr_dethi.Text + "_Double_" + (thutucau1 + 1) + "_4','" + txt_D2.Text + "','True','" + dr_dethi.Text + "_Double_" + (thutucau1 + 1) + "')";
                        ketnoi.executeQuery(sql_dapanD);
                    }
                    else
                    {
                        sql_dapanD = "insert into DAPAN values('" + dr_dethi.Text + "_Double_" + (thutucau1 + 1) + "_4','" + txt_D2.Text + "','False','" + dr_dethi.Text + "_Double_" + (thutucau1 + 1) + "')";
                        ketnoi.executeQuery(sql_dapanD);
                    }
                }
                catch { }

                // dap an 3
                try
                {
                    if (rd_TrueA3.Checked)
                    {
                        sql_dapanA = "insert into DAPAN values('" + dr_dethi.Text + "_Double_" + (thutucau1 + 2) + "_1','" + txt_A3.Text + "','True','" + dr_dethi.Text + "_Double_" + (thutucau1 + 2) + "')";
                        ketnoi.executeQuery(sql_dapanA);
                    }
                    else
                    {
                        sql_dapanA = "insert into DAPAN values('" + dr_dethi.Text + "_Double_" + (thutucau1 + 2) + "_1','" + txt_A3.Text + "','False','" + dr_dethi.Text + "_Double_" + (thutucau1 + 2) + "')";
                        ketnoi.executeQuery(sql_dapanA);
                    }
                    if (rd_TrueB3.Checked)
                    {
                        sql_dapanB = "insert into DAPAN values('" + dr_dethi.Text + "_Double_" + (thutucau1 + 2) + "_2','" + txt_B3.Text + "','True','" + dr_dethi.Text + "_Double_" + (thutucau1 + 2) + "')";
                        ketnoi.executeQuery(sql_dapanB);
                    }
                    else
                    {
                        sql_dapanB = "insert into DAPAN values('" + dr_dethi.Text + "_Double_" + (thutucau1 + 2) + "_2','" + txt_B3.Text + "','False','" + dr_dethi.Text + "_Double_" + (thutucau1 + 2) + "')";
                        ketnoi.executeQuery(sql_dapanB);
                    }
                    if (rd_TrueC3.Checked)
                    {
                        sql_dapanC = "insert into DAPAN values('" + dr_dethi.Text + "_Double_" + (thutucau1 + 2) + "_3','" + txt_C3.Text + "','True','" + dr_dethi.Text + "_Double_" + (thutucau1 + 2) + "')";
                        ketnoi.executeQuery(sql_dapanC);

                    }
                    else
                    {
                        sql_dapanC = "insert into DAPAN values('" + dr_dethi.Text + "_Double_" + (thutucau1 + 2) + "_3','" + txt_C3.Text + "','False','" + dr_dethi.Text + "_Double_" + (thutucau1 + 2) + "')";
                        ketnoi.executeQuery(sql_dapanC);

                    }

                    if (rd_TrueD3.Checked)
                    {
                        sql_dapanD = "insert into DAPAN values('" + dr_dethi.Text + "_Double_" + (thutucau1 + 2) + "_4','" + txt_D3.Text + "','True','" + dr_dethi.Text + "_Double_" + (thutucau1 + 2) + "')";
                        ketnoi.executeQuery(sql_dapanD);
                    }
                    else
                    {
                        sql_dapanD = "insert into DAPAN values('" + dr_dethi.Text + "_Double_" + (thutucau1 + 2) + "_4','" + txt_D3.Text + "','False','" + dr_dethi.Text + "_Double_" + (thutucau1 + 2) + "')";
                        ketnoi.executeQuery(sql_dapanD);
                    }
                }
                catch { }
                // dap an 4
                try
                {

                    if (rd_TrueA4.Checked)
                    {
                        sql_dapanA = "insert into DAPAN values('" + dr_dethi.Text + "_Double_" + (thutucau1 + 3) + "_1','" + txt_A4.Text + "','True','" + dr_dethi.Text + "_Double_" + (thutucau1 + 3) + "')";
                        ketnoi.executeQuery(sql_dapanA);
                    }
                    else
                    {
                        sql_dapanA = "insert into DAPAN values('" + dr_dethi.Text + "_Double_" + (thutucau1 + 3) + "_1','" + txt_A1.Text + "','False','" + dr_dethi.Text + "_Double_" + (thutucau1 + 3) + "')";
                        ketnoi.executeQuery(sql_dapanA);
                    }
                    if (rd_TrueB4.Checked)
                    {
                        sql_dapanB = "insert into DAPAN values('" + dr_dethi.Text + "_Double_" + (thutucau1 + 3) + "_2','" + txt_B4.Text + "','True','" + dr_dethi.Text + "_Double_" + (thutucau1 + 3) + "')";
                        ketnoi.executeQuery(sql_dapanB);
                    }
                    else
                    {
                        sql_dapanB = "insert into DAPAN values('" + dr_dethi.Text + "_Double_" + (thutucau1 + 3) + "_2','" + txt_B4.Text + "','False','" + dr_dethi.Text + "_Double_" + (thutucau1 + 3) + "')";
                        ketnoi.executeQuery(sql_dapanB);
                    }
                    if (rd_TrueC4.Checked)
                    {
                        sql_dapanC = "insert into DAPAN values('" + dr_dethi.Text + "_Double_" + (thutucau1 + 3) + "_3','" + txt_C4.Text + "','True','" + dr_dethi.Text + "_Double_" + (thutucau1 + 3) + "')";
                        ketnoi.executeQuery(sql_dapanC);

                    }
                    else
                    {
                        sql_dapanC = "insert into DAPAN values('" + dr_dethi.Text + "_Double_" + (thutucau1 + 3) + "_3','" + txt_C4.Text + "','False','" + dr_dethi.Text + "_Double_" + (thutucau1 + 3) + "')";
                        ketnoi.executeQuery(sql_dapanC);

                    }

                    if (rd_TrueD4.Checked)
                    {
                        sql_dapanD = "insert into DAPAN values('" + dr_dethi.Text + "_Double_" + (thutucau1 + 3) + "_4','" + txt_D4.Text + "','True','" + dr_dethi.Text + "_Double_" + (thutucau1 + 3) + "')";
                        ketnoi.executeQuery(sql_dapanD);
                    }
                    else
                    {
                        sql_dapanD = "insert into DAPAN values('" + dr_dethi.Text + "_Double_" + (thutucau1 + 3) + "_4','" + txt_D4.Text + "','False','" + dr_dethi.Text + "_Double_" + (thutucau1 + 3) + "')";
                        ketnoi.executeQuery(sql_dapanD);
                    }
                }
                catch { }
                // dap an 5
                try
                {
                    if (rd_TrueA5.Checked)
                    {
                        sql_dapanA = "insert into DAPAN values('" + dr_dethi.Text + "_Double_" + (thutucau1 + 4) + "_1','" + txt_A5.Text + "','True','" + dr_dethi.Text + "_Double_" + (thutucau1 + 4) + "')";
                        ketnoi.executeQuery(sql_dapanA);
                    }
                    else
                    {
                        sql_dapanA = "insert into DAPAN values('" + dr_dethi.Text + "_Double_" + (thutucau1 + 4) + "_1','" + txt_A5.Text + "','False','" + dr_dethi.Text + "_Double_" + (thutucau1 + 4) + "')";
                        ketnoi.executeQuery(sql_dapanA);
                    }
                    if (rd_TrueB5.Checked)
                    {
                        sql_dapanB = "insert into DAPAN values('" + dr_dethi.Text + "_Double_" + (thutucau1 + 4) + "_2','" + txt_B5.Text + "','True','" + dr_dethi.Text + "_Double_" + (thutucau1 + 4) + "')";
                        ketnoi.executeQuery(sql_dapanB);
                    }
                    else
                    {
                        sql_dapanB = "insert into DAPAN values('" + dr_dethi.Text + "_Double_" + (thutucau1 + 4) + "_2','" + txt_B5.Text + "','False','" + dr_dethi.Text + "_Double_" + (thutucau1 + 4) + "')";
                        ketnoi.executeQuery(sql_dapanB);
                    }
                    if (rd_TrueC5.Checked)
                    {
                        sql_dapanC = "insert into DAPAN values('" + dr_dethi.Text + "_Double_" + (thutucau1 + 4) + "_3','" + txt_C5.Text + "','True','" + dr_dethi.Text + "_Double_" + (thutucau1 + 4) + "')";
                        ketnoi.executeQuery(sql_dapanC);

                    }
                    else
                    {
                        sql_dapanC = "insert into DAPAN values('" + dr_dethi.Text + "_Double_" + (thutucau1 + 4) + "_3','" + txt_C5.Text + "','False','" + dr_dethi.Text + "_Double_" + (thutucau1 + 4) + "')";
                        ketnoi.executeQuery(sql_dapanC);

                    }

                    if (rd_TrueD5.Checked)
                    {
                        sql_dapanD = "insert into DAPAN values('" + dr_dethi.Text + "_Double_" + (thutucau1 + 4) + "_4','" + txt_D5.Text + "','True','" + dr_dethi.Text + "_Double_" + (thutucau1 + 4) + "')";
                        ketnoi.executeQuery(sql_dapanD);
                    }
                    else
                    {
                        sql_dapanD = "insert into DAPAN values('" + dr_dethi.Text + "_Double_" + (thutucau1 + 4) + "_4','" + txt_D5.Text + "','False','" + dr_dethi.Text + "_Double_" + (thutucau1 + 4) + "')";
                        ketnoi.executeQuery(sql_dapanD);
                    }

                }
                catch { }

                Response.Write("<script>alert('Thêm câu hỏi thành công!'); </script>");
            }
            catch
            {
                Response.Write("<script>alert('Thêm câu hỏi không thành công!'); </script>");
            }
                
                
        }
        else if (dr_noidung.Text.Trim() == "DoublePassagetest")
        {
            fileNghe.Visible = false;
            soluongcauhoi.Visible = true;
            causo.Visible = true;
            id_caubatdau.Visible = true;
            noidungdoanvan.Visible = true;
       
            string sql_dethi;
            if (dr_capdo.Text == "Tonghop" || dr_capdo.Text == "0")

                sql_dethi = "select * from DETHI where Made='0" + dr_dethi.Text + "'";
            else
                sql_dethi = "select * from DETHI where Made='0" + dr_dethi.Text + "_" + dr_capdo.Text + "'";
            DataTable tb_dethi = ketnoi.getData(sql_dethi);
            if (tb_dethi.Rows.Count == 0)
            {
                string sql_insert;
                if (dr_capdo.Text == "Tonghop" || dr_capdo.Text == "0")
                {
                    sql_insert = "insert into DETHI values('0" + dr_dethi.Text + "',N'Đề 0" + dr_dethi.Text + "',getdate(),NULL,'" + dr_capdo.Text + "')";
                }
                else
                {
                    sql_insert = "insert into DETHI values('0" + dr_dethi.Text + "_" + dr_capdo.Text + "',N'Đề 0" + dr_dethi.Text + "',getdate(),NULL,'" + dr_capdo.Text + "')";
                }
                ketnoi.executeQuery(sql_insert);
            }
            try
            {


                string sql_dapanA;
                string sql_dapanB;
                string sql_dapanC;
                string sql_dapanD;

                int soluongcau = Int32.Parse(dr_soluong.Text);
                int thutucau = Int32.Parse(dr_socauhoi.Text);

                for (int i = 1; i <= soluongcau; i++)
                {
                    try
                    {
                        string sql_cauhoi;
                        string noidung;
                        if (i == 1)
                            noidung = txt_doanvan.Text;
                        else
                            noidung = "";
                        if (i == 1)
                        {
                            sql_cauhoi = "insert into CAUHOI values('" + dr_dethi.Text + "_" + thutucau + "','" + noidung + "','" + txt_cauhoi1.Text + "','DoublePassagetest',NULL,'0" + dr_dethi.Text + "')";
                            ketnoi.executeQuery(sql_cauhoi);
                        }
                        else if (i == 2)
                        {
                            sql_cauhoi = "insert into CAUHOI values('" + dr_dethi.Text + "_" + thutucau + "','','" + txt_cauhoi2.Text + "','DoublePassagetest',NULL,'0" + dr_dethi.Text + "')";
                            ketnoi.executeQuery(sql_cauhoi);
                        }
                        else if (i == 3)
                        {
                            sql_cauhoi = "insert into CAUHOI values('" + dr_dethi.Text + "_" + thutucau + "','','" + txt_cauhoi3.Text + "','DoublePassagetest',NULL,'0" + dr_dethi.Text + "')";
                            ketnoi.executeQuery(sql_cauhoi);
                        }
                        else if (i == 4)
                        {
                            sql_cauhoi = "insert into CAUHOI values('" + dr_dethi.Text + "_" + thutucau + "','','" + txt_cauhoi4.Text + "','DoublePassagetest',NULL,'0" + dr_dethi.Text + "')";
                            ketnoi.executeQuery(sql_cauhoi);
                        }
                        else if (i == 5)
                        {
                            sql_cauhoi = "insert into CAUHOI values('" + dr_dethi.Text + "_" + thutucau + "','','" + txt_cauhoi5.Text + "','DoublePassage',NULL,'0" + dr_dethi.Text + "')";
                            ketnoi.executeQuery(sql_cauhoi);
                        }

                        thutucau++;
                    }
                    catch
                    {
                        Response.Write("<script> alert('Câu hỏi: " + dr_dethi.Text + "_" + thutucau + " đã tồn tại') </script>");
                        break;
                    }
                }
                int thutucau1 = Int32.Parse(dr_socauhoi.Text);
                if (rd_TrueA1.Checked)
                {
                    sql_dapanA = "insert into DAPAN values('" + dr_dethi.Text + "_Conver_" + thutucau1 + "_1','" + txt_A1.Text + "','True','" + dr_dethi.Text + "_" + thutucau1 + "')";

                    ketnoi.executeQuery(sql_dapanA);
                }
                else
                {
                    sql_dapanA = "insert into DAPAN values('" + dr_dethi.Text + "_Conver_" + thutucau1 + "_1','" + txt_A1.Text + "','False','" + dr_dethi.Text + "_" + thutucau1 + "')";
                    ketnoi.executeQuery(sql_dapanA);
                }
                if (rd_TrueB1.Checked)
                {
                    sql_dapanB = "insert into DAPAN values('" + dr_dethi.Text + "_" + thutucau1 + "_2','" + txt_B1.Text + "','True','" + dr_dethi.Text + "_" + thutucau1 + "')";
                    ketnoi.executeQuery(sql_dapanB);
                }
                else
                {
                    sql_dapanB = "insert into DAPAN values('" + dr_dethi.Text + "_" + thutucau1 + "_2','" + txt_B1.Text + "','False','" + dr_dethi.Text + "_" + thutucau1 + "')";
                    ketnoi.executeQuery(sql_dapanB);
                }
                if (rd_TrueC1.Checked)
                {
                    sql_dapanC = "insert into DAPAN values('" + dr_dethi.Text + "_" + thutucau1 + "_3','" + txt_C1.Text + "','True','" + dr_dethi.Text + "_" + thutucau1 + "')";
                    ketnoi.executeQuery(sql_dapanC);

                }
                else
                {
                    sql_dapanC = "insert into DAPAN values('" + dr_dethi.Text + "_" + thutucau1 + "_3','" + txt_C1.Text + "','False','" + dr_dethi.Text + "_" + thutucau1 + "')";
                    ketnoi.executeQuery(sql_dapanC);

                }

                if (rd_TrueD1.Checked)
                {
                    sql_dapanD = "insert into DAPAN values('" + dr_dethi.Text + "_" + thutucau1 + "_4','" + txt_D1.Text + "','True','" + dr_dethi.Text + "_" + thutucau1 + "')";
                    ketnoi.executeQuery(sql_dapanD);
                }
                else
                {
                    sql_dapanD = "insert into DAPAN values('" + dr_dethi.Text + "_" + thutucau1 + "_4','" + txt_D1.Text + "','False','" + dr_dethi.Text + "_" + thutucau1 + "')";
                    ketnoi.executeQuery(sql_dapanD);
                }

                // dap an 2
                try
                {
                    if (rd_TrueA2.Checked)
                    {
                        sql_dapanA = "insert into DAPAN values('" + dr_dethi.Text + "_" + (thutucau1 + 1) + "_1','" + txt_A2.Text + "','True','" + dr_dethi.Text + "_" + (thutucau1 + 1) + "')";
                        ketnoi.executeQuery(sql_dapanA);
                    }
                    else
                    {
                        sql_dapanA = "insert into DAPAN values('" + dr_dethi.Text + "_" + (thutucau1 + 1) + "_1','" + txt_A2.Text + "','False','" + dr_dethi.Text + "_" + (thutucau1 + 1) + "')";
                        ketnoi.executeQuery(sql_dapanA);
                    }
                    if (rd_TrueB2.Checked)
                    {
                        sql_dapanB = "insert into DAPAN values('" + dr_dethi.Text + "_" + (thutucau1 + 1) + "_2','" + txt_B2.Text + "','True','" + dr_dethi.Text + "_" + (thutucau1 + 1) + "')";
                        ketnoi.executeQuery(sql_dapanB);
                    }
                    else
                    {
                        sql_dapanB = "insert into DAPAN values('" + dr_dethi.Text + "_" + (thutucau1 + 1) + "_2','" + txt_B2.Text + "','False','" + dr_dethi.Text + "_" + (thutucau1 + 1) + "')";
                        ketnoi.executeQuery(sql_dapanB);
                    }
                    if (rd_TrueC2.Checked)
                    {
                        sql_dapanC = "insert into DAPAN values('" + dr_dethi.Text + "_" + (thutucau1 + 1) + "_3','" + txt_C2.Text + "','True','" + dr_dethi.Text + "_" + (thutucau1 + 1) + "')";
                        ketnoi.executeQuery(sql_dapanC);

                    }
                    else
                    {
                        sql_dapanC = "insert into DAPAN values('" + dr_dethi.Text + "_" + (thutucau1 + 1) + "_3','" + txt_C2.Text + "','False','" + dr_dethi.Text + "_" + (thutucau1 + 1) + "')";
                        ketnoi.executeQuery(sql_dapanC);

                    }

                    if (rd_TrueD2.Checked)
                    {
                        sql_dapanD = "insert into DAPAN values('" + dr_dethi.Text + "_" + (thutucau1 + 1) + "_4','" + txt_D2.Text + "','True','" + dr_dethi.Text + "_" + (thutucau1 + 1) + "')";
                        ketnoi.executeQuery(sql_dapanD);
                    }
                    else
                    {
                        sql_dapanD = "insert into DAPAN values('" + dr_dethi.Text + "_" + (thutucau1 + 1) + "_4','" + txt_D2.Text + "','False','" + dr_dethi.Text + "_" + (thutucau1 + 1) + "')";
                        ketnoi.executeQuery(sql_dapanD);
                    }
                }
                catch { }

                // dap an 3
                try
                {
                    if (rd_TrueA3.Checked)
                    {
                        sql_dapanA = "insert into DAPAN values('" + dr_dethi.Text + "_" + (thutucau1 + 2) + "_1','" + txt_A3.Text + "','True','" + dr_dethi.Text + "_" + (thutucau1 + 2) + "')";
                        ketnoi.executeQuery(sql_dapanA);
                    }
                    else
                    {
                        sql_dapanA = "insert into DAPAN values('" + dr_dethi.Text + "_" + (thutucau1 + 2) + "_1','" + txt_A3.Text + "','False','" + dr_dethi.Text + "_" + (thutucau1 + 2) + "')";
                        ketnoi.executeQuery(sql_dapanA);
                    }
                    if (rd_TrueB3.Checked)
                    {
                        sql_dapanB = "insert into DAPAN values('" + dr_dethi.Text + "_" + (thutucau1 + 2) + "_2','" + txt_B3.Text + "','True','" + dr_dethi.Text + "_" + (thutucau1 + 2) + "')";
                        ketnoi.executeQuery(sql_dapanB);
                    }
                    else
                    {
                        sql_dapanB = "insert into DAPAN values('" + dr_dethi.Text + "_" + (thutucau1 + 2) + "_2','" + txt_B3.Text + "','False','" + dr_dethi.Text + "_" + (thutucau1 + 2) + "')";
                        ketnoi.executeQuery(sql_dapanB);
                    }
                    if (rd_TrueC3.Checked)
                    {
                        sql_dapanC = "insert into DAPAN values('" + dr_dethi.Text + "_" + (thutucau1 + 2) + "_3','" + txt_C3.Text + "','True','" + dr_dethi.Text + "_" + (thutucau1 + 2) + "')";
                        ketnoi.executeQuery(sql_dapanC);

                    }
                    else
                    {
                        sql_dapanC = "insert into DAPAN values('" + dr_dethi.Text + "_" + (thutucau1 + 2) + "_3','" + txt_C3.Text + "','False','" + dr_dethi.Text + "_" + (thutucau1 + 2) + "')";
                        ketnoi.executeQuery(sql_dapanC);

                    }

                    if (rd_TrueD3.Checked)
                    {
                        sql_dapanD = "insert into DAPAN values('" + dr_dethi.Text + "_" + (thutucau1 + 2) + "_4','" + txt_D3.Text + "','True','" + dr_dethi.Text + "_" + (thutucau1 + 2) + "')";
                        ketnoi.executeQuery(sql_dapanD);
                    }
                    else
                    {
                        sql_dapanD = "insert into DAPAN values('" + dr_dethi.Text + "_" + (thutucau1 + 2) + "_4','" + txt_D3.Text + "','False','" + dr_dethi.Text + "_" + (thutucau1 + 2) + "')";
                        ketnoi.executeQuery(sql_dapanD);
                    }
                }
                catch { }
                // dap an 4
                try
                {

                    if (rd_TrueA4.Checked)
                    {
                        sql_dapanA = "insert into DAPAN values('" + dr_dethi.Text + "_" + (thutucau1 + 3) + "_1','" + txt_A4.Text + "','True','" + dr_dethi.Text + "_" + (thutucau1 + 3) + "')";
                        ketnoi.executeQuery(sql_dapanA);
                    }
                    else
                    {
                        sql_dapanA = "insert into DAPAN values('" + dr_dethi.Text + "_" + (thutucau1 + 3) + "_1','" + txt_A1.Text + "','False','" + dr_dethi.Text + "_" + (thutucau1 + 3) + "')";
                        ketnoi.executeQuery(sql_dapanA);
                    }
                    if (rd_TrueB4.Checked)
                    {
                        sql_dapanB = "insert into DAPAN values('" + dr_dethi.Text + "_" + (thutucau1 + 3) + "_2','" + txt_B4.Text + "','True','" + dr_dethi.Text + "_" + (thutucau1 + 3) + "')";
                        ketnoi.executeQuery(sql_dapanB);
                    }
                    else
                    {
                        sql_dapanB = "insert into DAPAN values('" + dr_dethi.Text + "_" + (thutucau1 + 3) + "_2','" + txt_B4.Text + "','False','" + dr_dethi.Text + "_" + (thutucau1 + 3) + "')";
                        ketnoi.executeQuery(sql_dapanB);
                    }
                    if (rd_TrueC4.Checked)
                    {
                        sql_dapanC = "insert into DAPAN values('" + dr_dethi.Text + "_" + (thutucau1 + 3) + "_3','" + txt_C4.Text + "','True','" + dr_dethi.Text + "_" + (thutucau1 + 3) + "')";
                        ketnoi.executeQuery(sql_dapanC);

                    }
                    else
                    {
                        sql_dapanC = "insert into DAPAN values('" + dr_dethi.Text + "_" + (thutucau1 + 3) + "_3','" + txt_C4.Text + "','False','" + dr_dethi.Text + "_" + (thutucau1 + 3) + "')";
                        ketnoi.executeQuery(sql_dapanC);

                    }

                    if (rd_TrueD4.Checked)
                    {
                        sql_dapanD = "insert into DAPAN values('" + dr_dethi.Text + "_" + (thutucau1 + 3) + "_4','" + txt_D4.Text + "','True','" + dr_dethi.Text + "_" + (thutucau1 + 3) + "')";
                        ketnoi.executeQuery(sql_dapanD);
                    }
                    else
                    {
                        sql_dapanD = "insert into DAPAN values('" + dr_dethi.Text + "_" + (thutucau1 + 3) + "_4','" + txt_D4.Text + "','False','" + dr_dethi.Text + "_" + (thutucau1 + 3) + "')";
                        ketnoi.executeQuery(sql_dapanD);
                    }
                }
                catch { }
                // dap an 5
                try
                {
                    if (rd_TrueA5.Checked)
                    {
                        sql_dapanA = "insert into DAPAN values('" + dr_dethi.Text + "_" + (thutucau1 + 4) + "_1','" + txt_A5.Text + "','True','" + dr_dethi.Text + "_" + (thutucau1 + 4) + "')";
                        ketnoi.executeQuery(sql_dapanA);
                    }
                    else
                    {
                        sql_dapanA = "insert into DAPAN values('" + dr_dethi.Text + "_" + (thutucau1 + 4) + "_1','" + txt_A5.Text + "','False','" + dr_dethi.Text + "_" + (thutucau1 + 4) + "')";
                        ketnoi.executeQuery(sql_dapanA);
                    }
                    if (rd_TrueB5.Checked)
                    {
                        sql_dapanB = "insert into DAPAN values('" + dr_dethi.Text + "_" + (thutucau1 + 4) + "_2','" + txt_B5.Text + "','True','" + dr_dethi.Text + "_" + (thutucau1 + 4) + "')";
                        ketnoi.executeQuery(sql_dapanB);
                    }
                    else
                    {
                        sql_dapanB = "insert into DAPAN values('" + dr_dethi.Text + "_" + (thutucau1 + 4) + "_2','" + txt_B5.Text + "','False','" + dr_dethi.Text + "_" + (thutucau1 + 4) + "')";
                        ketnoi.executeQuery(sql_dapanB);
                    }
                    if (rd_TrueC5.Checked)
                    {
                        sql_dapanC = "insert into DAPAN values('" + dr_dethi.Text + "_" + (thutucau1 + 4) + "_3','" + txt_C5.Text + "','True','" + dr_dethi.Text + "_" + (thutucau1 + 4) + "')";
                        ketnoi.executeQuery(sql_dapanC);

                    }
                    else
                    {
                        sql_dapanC = "insert into DAPAN values('" + dr_dethi.Text + "_" + (thutucau1 + 4) + "_3','" + txt_C5.Text + "','False','" + dr_dethi.Text + "_" + (thutucau1 + 4) + "')";
                        ketnoi.executeQuery(sql_dapanC);

                    }

                    if (rd_TrueD5.Checked)
                    {
                        sql_dapanD = "insert into DAPAN values('" + dr_dethi.Text + "_" + (thutucau1 + 4) + "_4','" + txt_D5.Text + "','True','" + dr_dethi.Text + "_" + (thutucau1 + 4) + "')";
                        ketnoi.executeQuery(sql_dapanD);
                    }
                    else
                    {
                        sql_dapanD = "insert into DAPAN values('" + dr_dethi.Text + "_" + (thutucau1 + 4) + "_4','" + txt_D5.Text + "','False','" + dr_dethi.Text + "_" + (thutucau1 + 4) + "')";
                        ketnoi.executeQuery(sql_dapanD);
                    }

                }
                catch { }

                Response.Write("<script>alert('Thêm câu hỏi thành công!'); </script>");
            }
            catch
            {
                Response.Write("<script>alert('Thêm câu hỏi không thành công!'); </script>");
            }
                
        }
        }
    
        



    
    protected void btn_Huy_Click(object sender, EventArgs e)
    {

    }
}