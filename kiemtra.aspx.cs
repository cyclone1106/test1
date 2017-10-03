using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class kiemtra : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        MasterPage master = this.Master as MasterPage;
        master.BodyId = "test";
        if (!IsPostBack)
        {
           
            cauhoi.Visible = false;
            start.Visible = true;
            bnt_start.Visible = true;

            
        }
       
        
    }
    protected void btn_next_Click(object sender, EventArgs e)
    {Response.Write("sfdfds");
       
            Response.Write("<script> alert('Bạn đã chọn không đúng!')</script>");
        Page.MaintainScrollPositionOnPostBack = true;
            question1.Visible = false;
            question2.Visible = false;
            question3.Visible = false;
            question4.Visible = false;
            question5.Visible = false;
            question6.Visible = true;
            question7.Visible = true;
            start.Visible = false;
            btn_back.Visible = true;
            if (question7.Visible == true)
            {

                btn_next.Visible = false;
            }
        
        
    }
    protected void btn_back_Click(object sender, EventArgs e)
    {
        
            question1.Visible = true;
            question2.Visible = true;
            question3.Visible = true;
            question4.Visible = true;
            question5.Visible = true;
            question6.Visible = false;
            question7.Visible = false;
            start.Visible = false;
            if (question1.Visible == true)
            {
                btn_back.Visible = false;
                btn_next.Visible = true;
            }
        
    }
    protected void bnt_start_Click(object sender, EventArgs e)
    {
        btn_back.Visible = false;
        cauhoi.Visible = true;
        question1.Visible = true;
        question2.Visible = true;
        question3.Visible = true;
        question4.Visible = true;
        question5.Visible = true;
        question6.Visible = false;
        question7.Visible = false;
        start.Visible = false;
    }


    protected void btn_nopbai_Click(object sender, EventArgs e)
    {
       if(RadioButton14.Checked)
              Response.Write("<script>alert('Bạn đã chọn đúng!')</script>");  
       else
           Response.Write("<script>alert('Bạn đã chọn không đúng!')</script>");  
        
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        
        
    }
}
