using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class login : System.Web.UI.Page {
	protected void Page_Load(object sender, EventArgs e) {
		if (!Page.IsPostBack) {
			lblUsernameR.Visible = false;
			lblPasswordR.Visible = false;
			lblIncorrect.Visible = false;
			Session.Abandon();
		}
	}

	protected void proceedToHome_Click(object sender, EventArgs e) {
		string username = txtUsername.Text;
		string password = txtPassword.Text;

		if (username.Trim() == "") {
			lblUsernameR.Visible = true;
		}
		else if (password.Trim() == "") {
			lblPasswordR.Visible = true;
		}
		else {
			lblUsernameR.Visible = false;
			lblPasswordR.Visible = false;

			string databasePassword = "";

			SqlConnection connection = new SqlConnection();
			connection.ConnectionString = ConfigurationManager.ConnectionStrings["myConnection"].ConnectionString;

			SqlCommand cmd = new SqlCommand();
			cmd.Connection = connection;
			cmd.CommandText = "SELECT * FROM Users WHERE username=@username";
			cmd.Parameters.AddWithValue("@username", username);

			try {
				connection.Open();
				SqlDataReader reader = cmd.ExecuteReader();
				if (reader.Read()) {
					databasePassword = reader["password"].ToString().Trim();
				}

				if (databasePassword.Equals(password)) {
					//  Session["name"] = reader["name"].ToString().Trim();
					Session["username"] = reader["username"].ToString().Trim();
					connection.Close();
					Response.Redirect("wishlist.aspx");
				}
				else {
					lblIncorrect.Visible = true;
				}

			}
			catch (Exception err) {
				lblMsg.Text = err.Message;
			}
			finally {
				connection.Close();
			}
		}
	}


	protected void LinkButton1_Click(object sender, EventArgs e) {
		Response.Redirect("register.aspx");
	}
}



