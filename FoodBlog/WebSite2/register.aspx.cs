using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class register : System.Web.UI.Page {
	protected void Page_Load(object sender, EventArgs e) {
		if (!Page.IsPostBack) {
			//lblRequired.Visible = false;
			//lblMsg.Text = "";
			//lblMsg.Visible = false;
		}
	}

	protected void btnRegister_Click(object sender, EventArgs e) {
		if (txtUsername.Text.Trim() != "" && txtEmail.Text.Trim() != "" && txtPassword1.Text.Trim() != "") {
			//lblRequired.Visible = false;
			SqlConnection connection = new SqlConnection();
			connection.ConnectionString = ConfigurationManager.ConnectionStrings["myConnection"].ConnectionString;

			SqlCommand cmd = new SqlCommand();

			cmd.Connection = connection;
			cmd.CommandText = "INSERT INTO Users (username,email,password) VALUES (@username, @email, @password)";
			cmd.Parameters.AddWithValue("@username", txtUsername.Text);
			cmd.Parameters.AddWithValue("@email", txtEmail.Text);
			cmd.Parameters.AddWithValue("@password", txtPassword1.Text);
			Session["username"] = txtUsername.Text;
			try {
				connection.Open();
				cmd.ExecuteNonQuery();
	
				Response.Redirect("wishlist.aspx");
			}
			catch (Exception err) {
				lblMsg.Text = err.Message;

			}
			finally {
				connection.Close();
			}

		}
	}
}