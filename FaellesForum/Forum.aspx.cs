using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;
using System.IO;

namespace FaellesForum
{
    public partial class Forum : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Save_Click(object sender, EventArgs e)
        {
            StreamWriter writer = new StreamWriter("C:\\Messages.txt", true);
            writer.WriteLine(BeskedBox.Text);
            writer.Close();
            BeskedBox.Text = "";
        }

        protected void Reset_Click(object sender, EventArgs e)
        {

        }

        protected void Delete_Click(object sender, EventArgs e)
        {

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