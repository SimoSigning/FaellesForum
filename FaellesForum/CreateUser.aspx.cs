using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace FaellesForum
{
    public partial class CreateUser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Create_Click(object sender, EventArgs e)
        {
            SqlConnection newconnection = new SqlConnection(ConfigurationManager.ConnectionStrings["derpection"].ConnectionString);
            string createbruger = BrugernavnTxt.Text;
            string createpass = PasswordTxt.Text;
            string sql = "insert into Users values('" + createbruger + "', '" + createpass + "')";
            SqlCommand hmm = new SqlCommand(sql, newconnection);
            newconnection.Open();
            hmm.ExecuteNonQuery();
            newconnection.Close();
        }
    }
}