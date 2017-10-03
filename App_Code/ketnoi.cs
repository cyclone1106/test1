using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data;
using Microsoft.SqlServer.Server;
using System.Data;
/// <summary>
/// Summary description for ketnoi
/// </summary>
public class ketnoi
{
	SqlConnection con;
    SqlDataAdapter da;
    DataSet ds;
    SqlCommand cmd;
    public void connect()
    {
        if(con == null)
        {
            con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Toeic;Integrated Security=True");
        }
        if(con.State == ConnectionState.Closed)
        {
            con.Open();
        }
    }
    public void disconnect()
    {
        if(con != null && con.State == ConnectionState.Open)
        {
            con.Close();
        }
    }
    public DataSet getDataSet(String sql)
    {
        connect();
        da = new SqlDataAdapter(sql, con);
        ds = new DataSet();
        da.Fill(ds);
        con.Close();
        return ds;
    }
    public DataTable getData(String sql)
    {
        connect();
        da = new SqlDataAdapter(sql, con);
        ds = new DataSet();
        da.Fill(ds);
        con.Close();
        return ds.Tables[0];
    }
    public void executeQuery(String sql)
    {
        connect();
        cmd = new SqlCommand();
        cmd.Connection = con;
        cmd.CommandText = sql;
        cmd.CommandType = CommandType.Text;
        cmd.ExecuteNonQuery();
        disconnect();
    }
	
}