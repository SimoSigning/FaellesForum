using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FaellesForum
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            /*            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Connection"].ConnectionString);
            string userName = txtBrugernavn.Text;
            string password = txtPassword.Text;

            try
            {
                string sql = "select count(*) from UserLogin where UserName = @username and Password = @password";
                SqlCommand cmd = new SqlCommand(sql, connection);
                SqlParameter user = new SqlParameter();
                user.ParameterName = "@username";
                user.Value = userName.Trim();
                cmd.Parameters.Add(user);

                SqlParameter pass = new SqlParameter();
                pass.ParameterName = "@password";
                pass.Value = password.Trim();
                cmd.Parameters.Add(pass);

                connection.Open();
                
                int count = (int)cmd.ExecuteScalar();
                
                if(count > 0)
                {
                    lblMessage.Text = "Login ok";
                }
                else
                {
                    lblMessage.Text = "Forkert brugernavn eller password.";
                }
            }
            catch(Exception ex)
            {
                //Fejllog
            }
            finally
            {
                //hvis forbindelsen ikke er lukket når vi når finally, så lukkes den.
                if (connection != null) connection.Close();
            }*/
        }

        protected void CreateUserBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("CreateUser.aspx");
        }

        protected void Login_Click(object sender, EventArgs e)
        {
            Response.Redirect("Forum.aspx");
        }
    }
}