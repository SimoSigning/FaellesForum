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
            Label1.Text = Session["Giraf"].ToString();
        }

        protected void Save_Click(object sender, EventArgs e)
        {
            SqlConnection newconnection = new SqlConnection(ConfigurationManager.ConnectionStrings["derpection"].ConnectionString);
            string Besked = BeskedBox.Text;
            //her skal jeg indsætte flere felter i messages som kan hentes frem under read_click (gjorde jeg muligvis fra skolen af)
            string sql01 = "INSERT INTO Messages(BrugerID, Username) SELECT Id, Username FROM Users WHERE Username = 'simonhylleberg';";
            string sql02 = "UPDATE Messages SET Besked = '"+ Besked +"' WHERE Id IN (SELECT TOP 1 Id FROM Messages ORDER BY Id DESC)";
            SqlCommand hmm01 = new SqlCommand(sql01, newconnection);
            SqlCommand hmm02 = new SqlCommand(sql02, newconnection);
            newconnection.Open();
            hmm01.ExecuteNonQuery();
            hmm02.ExecuteNonQuery();
            newconnection.Close();
        }

        protected void Reset_Click(object sender, EventArgs e)
        {
            BeskedBox.Text = "";
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