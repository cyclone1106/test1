using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_Cauhoi : System.Web.UI.Page
{
    ketnoi ketnoi = new ketnoi();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            //string sql_cauhoi = "select * from CAUHOI a, DETHI c where a.Made=c.Made";
            //Repeater1.DataSource = ketnoi.getData(sql_cauhoi);
            //Repeater1.DataBind();
             double sobaihienthi = 15;
            int strang;
            if (Request.QueryString["trang"] == null)
            {
                strang = 1;
            }
            else
            {
                strang = Convert.ToInt32(Request.QueryString["trang"].ToString());
            }
           string sqltonghang = "select * from CAUHOI a, DETHI c where a.Made=c.Made";
            DataTable dt = ketnoi.getData(sqltonghang);
            double tongsotin = dt.Rows.Count;
            double sotrang = System.Math.Ceiling((tongsotin / sobaihienthi));
            double sobaibatdau = (strang - 1) * sobaihienthi + 1;
            double sobaihientiep = (strang * sobaihienthi);
            ArrayList pages = new ArrayList();
            if (sotrang > 1)
            {
                // Đầu trang
                if (Convert.ToInt32(Request.QueryString["trang"]) > 3)
                {
                    pages.Add(("<li><a href='Admin_Cauhoi.aspx?trang=1'> Trang Đầu </a></li>").ToString());
                    pages.Add(("<li><a href='Admin_Cauhoi.aspx?trang=" + (Convert.ToInt32(Request.QueryString["trang"]) - 1) + "'> Trước </a></li>").ToString());
                }
                // Giới hạn số trang hiển thị = 9
                if (sotrang > 5)
                {
                    if (Convert.ToInt32(Request.QueryString["trang"]) > (sotrang / 2))
                    {
                        if (Convert.ToInt32(Request.QueryString["trang"]) < (sotrang - 1))
                        {
                            for (int i = Convert.ToInt32(Request.QueryString["trang"]) - 2; i <= sotrang; i++)
                            {
                                if (i <= Convert.ToInt32(Request.QueryString["trang"]) +2)
                                {
                                    if (Request.QueryString["trang"] == i.ToString())
                                    {
                                        pages.Add(("<li ><a href='Admin_Caihoi.aspx?trang=" + i + "' class='active' style='color: #fff; background:#337ab7'>" + i + "</a></li>").ToString());
                                    }
                                    else
                                    {
                                        pages.Add(("<li><a href='Admin_Cauhoi.aspx?trang=" + i + "'>" + i + "</a></li>").ToString());
                                    }
                                }
                            }
                        }
                        // ######################
                        if (Convert.ToInt32(Request.QueryString["trang"]) >= (sotrang - 1))
                        {
                            for (int i = Convert.ToInt32(Request.QueryString["trang"]) - 4; i <= sotrang; i++)
                            {
                                if (Request.QueryString["trang"] == i.ToString())
                                {
                                    pages.Add(("<li ><a href='Admin_Cauhoi.aspx?trang=" + i + "' class='active' style='color: #fff; background:#337ab7'>" + i + "</a></li>").ToString());
                                }
                                else
                                {
                                    pages.Add(("<li><a href='Admin_Cauhoi.aspx?trang=" + i + "'>" + i + "</a></li>").ToString());
                                }
                            }
                        }
                    }
                    else
                    {
                        if (Convert.ToInt32(Request.QueryString["trang"]) > 3)
                        {
                            for (int i = Convert.ToInt32(Request.QueryString["trang"]) - 2; i <= sotrang; i++)
                            {
                                if (i <= Convert.ToInt32(Request.QueryString["trang"]) + 2)
                                {
                                    if (Request.QueryString["trang"] == i.ToString())
                                    {
                                        pages.Add(("<li ><a href='Admin_Cauhoi.aspx?trang=" + i + "' class='active' style='color: #fff; background:#337ab7'>" + i + "</a></li>").ToString());
                                    }
                                    else
                                    {
                                        pages.Add(("<li><a href='Admin_Cauhoi.aspx?trang=" + i + "'>" + i + "</a></li>").ToString());
                                    }
                                }
                            }
                        }
                        else
                        {
                            for (int i = 1; i <= 5; i++)
                            {
                                if (Request.QueryString["trang"] == i.ToString())
                                {
                                    pages.Add(("<li ><a href='Admin_Cauhoi.aspx?trang=" + i + "' class='active' style='color: #fff; background:#337ab7'>" + i + "</a></li>").ToString());
                                }
                                else
                                {
                                    pages.Add(("<li><a href='Admin_Cauhoi.aspx?trang=" + i + "'>" + i + "</a></li>").ToString());
                                }
                            }
                        }
                    }
                }
                else
                {
                    for (int i = 1; i <= sotrang; i++)
                    {
                        if (Request.QueryString["trang"] == i.ToString())
                        {
                            pages.Add(("<li ><a href='Admin_Cauhoi.aspx?trang=" + i + "' class='active' style='color: #fff; background:#337ab7'>" + i + "</a></li>").ToString());
                        }
                        else
                        {
                            pages.Add(("<li><a href='Admin_Cauhoi.aspx?trang=" + i + "'>" + i + "</a></li>").ToString());
                        }
                    }
                }
                // Cuối trang
                if (Convert.ToInt32(Request.QueryString["trang"]) < (sotrang - 4))
                {
                    pages.Add(("<li><a href='Admin_Cauhoi.aspx?trang=" + (Convert.ToInt32(Request.QueryString["trang"]) + 1) + "'> Tiếp </a></li>").ToString());
                    pages.Add(("<li><a href='Admin_Cauhoi.aspx?trang=" + sotrang + "'> Cuối Trang </a></li>").ToString());
                }
            }
            rptPages.DataSource = pages;
            rptPages.DataBind();
            string sql = "select * from (select ROW_NUMBER() OVER(ORDER BY IDCauhoi ASC) as RowNum,  * from CAUHOI) A where RowNum BETWEEN " + sobaibatdau + " AND " + sobaihientiep + "";
            Repeater1.DataSource = ketnoi.getData(sql);
            Repeater1.DataBind();
        }
        
    }
    protected void btn_themcauhoi_Click(object sender, EventArgs e)
    {
        Response.Redirect("Admin_Them_Cauhoi.aspx");
      
    }
    protected void Repeater1_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
      
    }
    protected void Repeater1_ItemCommand1(object source, RepeaterCommandEventArgs e)
    {
        if (e.CommandName.ToLower().Equals("xem"))
        {

            string id = Convert.ToString(e.CommandArgument);
            Response.Redirect("Admin_Cauhoichitiet.aspx?macauhoi=" + id + "");
        }
        if (e.CommandName.ToLower().Equals("sua"))
        {

            string id = Convert.ToString(e.CommandArgument);
            Response.Redirect("Admin_chinhsuacauhoi.aspx?macauhoi="+id+"");
        }
        if (e.CommandName.ToLower().Equals("xoa"))
        {

            string id = Convert.ToString(e.CommandArgument);
            string del = "delete from CAUHOI where IDCauhoi='" + id + "'";
            try
            {
                ketnoi.executeQuery(del);
                Response.Write("<script> alert('Xóa thành công!'); window.location.href='Admin_Cauhoi.aspx'; </script>");
            }
            catch
            {
                Response.Write("<script> alert('Xóa không thành công!');window.location.href='Admin_Cauhoi.aspx'; </script>");
            }
        }

    }
    protected void Button4_Click(object sender, EventArgs e)
    {
            double sobaihienthi = 15;
            int strang;
            if (Request.QueryString["trang"] == null)
            {
                strang = 1;
            }
            else
            {
                strang = Convert.ToInt32(Request.QueryString["trang"].ToString());
            }
           string sqltonghang = "select * from CAUHOI a, DETHI c where a.Made=c.Made and a.IDNoidung='"+dr_noidung.Text+"'";
            DataTable dt = ketnoi.getData(sqltonghang);
            double tongsotin = dt.Rows.Count;
            double sotrang = System.Math.Ceiling((tongsotin / sobaihienthi));
            double sobaibatdau = (strang - 1) * sobaihienthi + 1;
            double sobaihientiep = (strang * sobaihienthi);
            ArrayList pages = new ArrayList();
            if (sotrang > 1)
            {
                // Đầu trang
                if (Convert.ToInt32(Request.QueryString["trang"]) > 3)
                {
                    pages.Add(("<li><a href='Admin_Cauhoi.aspx?trang=1'> Trang Đầu </a></li>").ToString());
                    pages.Add(("<li><a href='Admin_Cauhoi.aspx?trang=" + (Convert.ToInt32(Request.QueryString["trang"]) - 1) + "'> Trước </a></li>").ToString());
                }
                // Giới hạn số trang hiển thị = 9
                if (sotrang > 5)
                {
                    if (Convert.ToInt32(Request.QueryString["trang"]) > (sotrang / 2))
                    {
                        if (Convert.ToInt32(Request.QueryString["trang"]) < (sotrang - 1))
                        {
                            for (int i = Convert.ToInt32(Request.QueryString["trang"]) - 2; i <= sotrang; i++)
                            {
                                if (i <= Convert.ToInt32(Request.QueryString["trang"]) +2)
                                {
                                    if (Request.QueryString["trang"] == i.ToString())
                                    {
                                        pages.Add(("<li ><a href='Admin_Caihoi.aspx?trang=" + i + "' class='active' style='color: #fff; background:#337ab7'>" + i + "</a></li>").ToString());
                                    }
                                    else
                                    {
                                        pages.Add(("<li><a href='Admin_Cauhoi.aspx?trang=" + i + "'>" + i + "</a></li>").ToString());
                                    }
                                }
                            }
                        }
                        // ######################
                        if (Convert.ToInt32(Request.QueryString["trang"]) >= (sotrang - 1))
                        {
                            for (int i = Convert.ToInt32(Request.QueryString["trang"]) - 4; i <= sotrang; i++)
                            {
                                if (Request.QueryString["trang"] == i.ToString())
                                {
                                    pages.Add(("<li ><a href='Admin_Cauhoi.aspx?trang=" + i + "' class='active' style='color: #fff; background:#337ab7'>" + i + "</a></li>").ToString());
                                }
                                else
                                {
                                    pages.Add(("<li><a href='Admin_Cauhoi.aspx?trang=" + i + "'>" + i + "</a></li>").ToString());
                                }
                            }
                        }
                    }
                    else
                    {
                        if (Convert.ToInt32(Request.QueryString["trang"]) > 3)
                        {
                            for (int i = Convert.ToInt32(Request.QueryString["trang"]) - 2; i <= sotrang; i++)
                            {
                                if (i <= Convert.ToInt32(Request.QueryString["trang"]) + 2)
                                {
                                    if (Request.QueryString["trang"] == i.ToString())
                                    {
                                        pages.Add(("<li ><a href='Admin_Cauhoi.aspx?trang=" + i + "' class='active' style='color: #fff; background:#337ab7'>" + i + "</a></li>").ToString());
                                    }
                                    else
                                    {
                                        pages.Add(("<li><a href='Admin_Cauhoi.aspx?trang=" + i + "'>" + i + "</a></li>").ToString());
                                    }
                                }
                            }
                        }
                        else
                        {
                            for (int i = 1; i <= 5; i++)
                            {
                                if (Request.QueryString["trang"] == i.ToString())
                                {
                                    pages.Add(("<li ><a href='Admin_Cauhoi.aspx?trang=" + i + "' class='active' style='color: #fff; background:#337ab7'>" + i + "</a></li>").ToString());
                                }
                                else
                                {
                                    pages.Add(("<li><a href='Admin_Cauhoi.aspx?trang=" + i + "'>" + i + "</a></li>").ToString());
                                }
                            }
                        }
                    }
                }
                else
                {
                    for (int i = 1; i <= sotrang; i++)
                    {
                        if (Request.QueryString["trang"] == i.ToString())
                        {
                            pages.Add(("<li ><a href='Admin_Cauhoi.aspx?trang=" + i + "' class='active' style='color: #fff; background:#337ab7'>" + i + "</a></li>").ToString());
                        }
                        else
                        {
                            pages.Add(("<li><a href='Admin_Cauhoi.aspx?trang=" + i + "'>" + i + "</a></li>").ToString());
                        }
                    }
                }
                // Cuối trang
                if (Convert.ToInt32(Request.QueryString["trang"]) < (sotrang - 4))
                {
                    pages.Add(("<li><a href='Admin_Cauhoi.aspx?trang=" + (Convert.ToInt32(Request.QueryString["trang"]) + 1) + "'> Tiếp </a></li>").ToString());
                    pages.Add(("<li><a href='Admin_Cauhoi.aspx?trang=" + sotrang + "'> Cuối Trang </a></li>").ToString());
                }
            }
            rptPages.DataSource = pages;
            rptPages.DataBind();
            string sql = "select * from (select ROW_NUMBER() OVER(ORDER BY IDCauhoi ASC) as RowNum, * from CAUHOI where IDNoidung='"+dr_noidung.Text.Trim()+"') A where RowNum BETWEEN " + sobaibatdau + " AND " + sobaihientiep + "";
            Repeater1.DataSource = ketnoi.getData(sql);
            Repeater1.DataBind();
        
    }
  
}