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
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void CreateUserBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("CreateUser.aspx");
        }

        protected void Login_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["derpection"].ConnectionString);
            string username = BrugernavnTxt.Text;
            string password = PasswordTxt.Text;
            try
            {
                /*
                 count returnere alle rækker der matcher et bestemte kriterie. Kriteriet er at Username og Password skal have
                 værdierne @username og @password. Disse bliver kædet sammen med tekstfelterne under sqlparametrene...
                 */
                string sql = "select count(*) from Users where Username = @username and Password = @password";

                SqlCommand commands = new SqlCommand(sql, connection);

                SqlParameter user = new SqlParameter();
                user.ParameterName = "@username";//burde læse op på betydningen af parametername i sammenhæng med value..
                user.Value = username.Trim();
                commands.Parameters.Add(user);

                SqlParameter pass = new SqlParameter();
                pass.ParameterName = "@password";
                pass.Value = password.Trim();
                commands.Parameters.Add(pass);

                connection.Open();

                /*executescalar eksekvere den query der er lagt ind i sqlcommand
                 objektet og returnere første kolonne i første række i resultatetsættet
                 returneret fra ens sql query*/
                int count = (int)commands.ExecuteScalar();
                /*count får via ovenstående kode det id der tilhøre den række der indeholder det specifikke brugernavn og kodeord.
                 Dette Id vil under alle omstændigheder være over 0. Så hvis ens query er eksekveret succesfuldt og brugernavn 
                 og password hænger sammen, så vil count være over 0 og man kan logge ind.*/
                if (count > 0)
                {
                    Session["Giraf"] = username;
                    Response.Redirect("Forum.aspx");
                }
                else
                {
                  //  lblMessage.Text = "Forkert brugernavn eller password.";
                }
            }
            catch (Exception ex)
            {
                // Fejllog
            }
            finally
            {
                if (connection != null) connection.Close();
            }
        }
    }
}