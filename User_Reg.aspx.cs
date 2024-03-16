using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using Microsoft.Ajax.Utilities;


namespace WebApplication1
{
    public partial class User_Reg : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["mysqlcon"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Btn_Add_Click(object sender, EventArgs e)
        {
            string str = "insert into user_reg values(@eid,@pwd)";
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.Parameters.AddWithValue("@eid", txtemail.Text);
            cmd.Parameters.AddWithValue("@pwd", txtpwd.Text);
            if (con.State == System.Data.ConnectionState.Closed)
                con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        protected void Btn_Find_Click(object sender, EventArgs e)
        {
            string str = "select * from user_reg where email=@eid";
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.Parameters.AddWithValue("@eid", txtemail.Text);
            SqlDataReader dr;
            if (con.State == System.Data.ConnectionState.Closed)
                con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {

                txtpwd.Text = dr["password"].ToString();
            }
                dr.Close();
                con.Close();
            }
        
        protected void BtnUpdate_Click(object sender, EventArgs e)
        {
            string str = "update user_reg set password=@pwd where email=@eid";
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.Parameters.AddWithValue("@eid", txtemail.Text);
            cmd.Parameters.AddWithValue("@pwd", txtpwd.Text);
            if (con.State == System.Data.ConnectionState.Closed)
                con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        protected void Btn_Del_Click(object sender, EventArgs e)
        {
            string str = "delete user_reg where email=@eid";
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.Parameters.AddWithValue("@eid", txtemail.Text);
           
            if (con.State == System.Data.ConnectionState.Closed)
                con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            txtemail.Text = "";
            txtpwd.Text = "";
        }
    }
}