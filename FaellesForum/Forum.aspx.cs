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

        }

        protected void Save_Click(object sender, EventArgs e)
        {
            /*   StreamWriter writer = new StreamWriter("C:\\Messages.txt", true);
               writer.WriteLine(BeskedBox.Text);
               writer.Close();
               BeskedBox.Text = "";*/
            SqlConnection newconnection = new SqlConnection(ConfigurationManager.ConnectionStrings["derpection"].ConnectionString);
            string Besked = BeskedBox.Text;
            string Brugernavn = NavnBox.Text;
            string sql01 = "SELECT Id from Users where UserName = " + "'" + Brugernavn +"'";
            string sql02 = "INSERT INTO Messages (Besked, BrugerID) VALUES('" + Besked + "')";
            SqlCommand hmm01 = new SqlCommand(sql01, newconnection);
            SqlCommand hmm02 = new SqlCommand(sql02, newconnection);
            SqlParameter user = new SqlParameter();
            user.ParameterName = "@username";
            hmm01.Parameters.Add(user);

            newconnection.Open();
            hmm01.ExecuteNonQuery();
            newconnection.Close();

            

        }

        protected void Reset_Click(object sender, EventArgs e)
        {
            NavnBox.Text = "";
            EmailBox.Text = "";
            BeskedBox.Text = "";
            AdresseBox.Text = "";
            MobilBox.Text = "";
        }

        protected void Delete_Click(object sender, EventArgs e)
        {
            StreamWriter writer = new StreamWriter("C:\\Messages.txt");
            writer.Flush();
            writer.Close();
            BeskedBox.Text = "";
        }

        protected void Read_Click(object sender, EventArgs e)
        {
            MessageList.Items.Clear();
            StreamReader reader = new StreamReader("C:\\Messages.txt");
            string read = reader.ReadLine();
            while (read != null)
            {
                MessageList.Items.Add(read);
                read = reader.ReadLine();
            }
            reader.Close();
        }

        protected void Logout_Click(object sender, EventArgs e)
        {

        }
    }
}