using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;



namespace Web
{
    public partial class Customer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                string Constring = ConfigurationManager.ConnectionStrings["PetDbConnectionString"].ConnectionString;
                LoadBindGridView(Constring);
            }

        }

        private void LoadBindGridView(string constring)
        {
            string catQuery = "fetchCustomer";
            using (SqlConnection cons = new SqlConnection(constring))
            {
                using (SqlDataAdapter ads = new SqlDataAdapter(catQuery, constring))
                {
                    ads.SelectCommand.CommandType = CommandType.StoredProcedure;
                    using (DataTable dt = new DataTable())
                    {
                        ads.Fill(dt);
                        GridView2.DataSource = dt;
                        GridView2.DataBind();
                    }
                }
            }
        }

        protected void clearAll()
        {
            tb_Name.Text = "";
            tb_zipcode.Text = "";
            tb_email.Text = "";
            tb_username.Text = "";
            tb_pwd.Text = "";

        }



        protected void btn_Add_Click(object sender, EventArgs e)
        {
            string ConString = ConfigurationManager.ConnectionStrings["PetDbConnectionString"].ConnectionString;
            string insertQuery = "spInsertCustomer";
            using (SqlConnection connection = new SqlConnection(ConString))
            {
                using (SqlCommand cmd = new SqlCommand(insertQuery))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@name", tb_Name.Text);
                    cmd.Parameters.AddWithValue("@zipcode", tb_zipcode.Text);
                    cmd.Parameters.AddWithValue("@email", tb_email.Text);
                    cmd.Parameters.AddWithValue("@username", tb_username.Text);
                    cmd.Parameters.AddWithValue("@password", tb_pwd.Text);
                    cmd.Connection = connection;
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();
                }
            }
            LoadBindGridView(ConString);
            clearAll();
        }
    }
}