

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Oracle.DataAccess.Client;
using System.Data;


public partial class Default2 : System.Web.UI.Page
{
    //creating TNS entries   
    string oradb = "Data Source=(DESCRIPTION =" +
    "(ADDRESS = (PROTOCOL = TCP)(HOST = your_host_name)(PORT = 1521))" +
    "(CONNECT_DATA =" +
      "(SERVER = DEDICATED)" +
      "(SERVICE_NAME = XE)));" +
      "User Id=your_user_id;Password=*******;";
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btn_fetch_Click(object sender, EventArgs e)
    {
        OracleConnection con = new OracleConnection(oradb);
        OracleCommand cmd = new OracleCommand();
        cmd.CommandText = "select * from student";
        cmd.Connection = con;
        con.Open();
        OracleDataReader dr = cmd.ExecuteReader();
        if (dr.HasRows)
        {
            Response.Write("<table border='1'>");
            Response.Write("<tr><th>Name</th><th>Roll No</th></tr>");
            while (dr.Read())
            {

                Response.Write("<tr>");
                Response.Write("<td>" + dr["name"].ToString() + "</td>");
                Response.Write("<td>" + dr["roll_no"].ToString() + "</td>");
                Response.Write("</tr>");
            }
            Response.Write("</table>");
        }
        else
        {
            Response.Write("No Data In DataBase");
        }
        con.Close();
    }
}

