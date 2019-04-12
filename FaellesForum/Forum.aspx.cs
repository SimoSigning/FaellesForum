using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;
using System.IO;
using System.Data.SqlClient;
using System.Configuration;

namespace FaellesForum
{
    public partial class Forum : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            brugernavnlabel.Text = Session["Giraf"].ToString();
        }
        protected void Save_Click(object sender, EventArgs e)
        {
            var time = DateTime.Now;
            string timeStr = time.ToString();
            Label2.Text = timeStr;
            string girafstring = Session["Giraf"].ToString();
            SqlConnection newconnection = new SqlConnection(ConfigurationManager.ConnectionStrings["derpection"].ConnectionString);
            string Besked = BeskedBox.Text;
            string sql01 = "INSERT INTO Messages(BrugerID) SELECT Id FROM Users WHERE Username = '" + girafstring + "';";
            string sql02 = "UPDATE Messages SET Besked = '"+ Besked +"', Dato = '"+ timeStr +"' WHERE Id IN (SELECT TOP 1 Id FROM Messages ORDER BY Id DESC)";
            SqlCommand hmm01 = new SqlCommand(sql01, newconnection);
            SqlCommand hmm02 = new SqlCommand(sql02, newconnection);
            newconnection.Open();
            hmm01.ExecuteNonQuery();
            hmm02.ExecuteNonQuery();
            newconnection.Close();
            BeskedBox.Text = "";
        }
        protected void Reset_Click(object sender, EventArgs e)
        {
            BeskedBox.Text = "";
        }
        protected void Delete_Click(object sender, EventArgs e)
        {
            SqlConnection newconnection = new SqlConnection(ConfigurationManager.ConnectionStrings["derpection"].ConnectionString);
            string deletequery = "DELETE FROM Messages";
            SqlCommand deletecmd = new SqlCommand(deletequery, newconnection);
            newconnection.Open();
            deletecmd.ExecuteNonQuery();
            newconnection.Close();
            MessageList.Items.Clear();
        }
        protected void Read_Click(object sender, EventArgs e)
        {
            MessageList.Items.Clear();
            SqlConnection newconnection = new SqlConnection(ConfigurationManager.ConnectionStrings["derpection"].ConnectionString);
            string viewquery = "SELECT Messages.Besked, Messages.Dato, Users.Username FROM Messages INNER JOIN Users ON Messages.BrugerId = Users.Id;";
            SqlCommand viewcmd = new SqlCommand(viewquery, newconnection);
            newconnection.Open();
            SqlDataReader reader = viewcmd.ExecuteReader();
            while (reader.Read())
            {
                MessageList.Items.Add(reader["Username"].ToString());
                MessageList.Items.Add(reader["Besked"].ToString());
                MessageList.Items.Add(reader["Dato"].ToString());
            }
            newconnection.Close();
        }

        protected void Logout_Click(object sender, EventArgs e)
        {
            Response.Redirect("login.aspx");
        }

    }
}