using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin : System.Web.UI.MasterPage
{
    private string _bodyId;
    public string BodyId
    {
        get { return _bodyId; }
        set { _bodyId = value; }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Session["tendangnhap"] != null)
                txt_tendangnhap.Text = Session["tendangnhap"].ToString();
            else
                Response.Redirect("Default.aspx");
        }
    }

    protected void menu_Click(object sender, EventArgs e)
    {
        
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Session["tendangnhap"] = null;
        Response.Redirect("Default.aspx");
    }
}
