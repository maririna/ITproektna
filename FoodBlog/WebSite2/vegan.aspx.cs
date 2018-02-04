using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class vegan : System.Web.UI.Page {
	protected void Page_Load(object sender, EventArgs e) {
		// details.Visible = false;
		gvRecept.Visible = false;

	}

	public void addToWishes(string username, string favRecipe) {
		SqlConnection connection = new SqlConnection();
		connection.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["myConnection"].ConnectionString;

		SqlCommand cmd = new SqlCommand();
		cmd.Connection = connection;
		cmd.CommandText = "INSERT INTO Wishes (username, favRecipe) VALUES (@username, @favRecipe)";
		cmd.Parameters.AddWithValue("@username", username);
		cmd.Parameters.AddWithValue("@favRecipe", favRecipe);

		try {
			lblMsg.Visible = false;
			connection.Open();
			cmd.ExecuteNonQuery();
		}
		catch (Exception err) {
			lblMsg.Visible = true;
		}
		finally {
			connection.Close();
		}

	}

	protected void ib1_Click(object sender, ImageClickEventArgs e) {
		if (Session["username"] == null) {
			Response.Redirect("login.aspx");
		}
		else {
			addToWishes(Session["username"].ToString().Trim(), "Crispy gluten-free eggplant parmesan");
		}
	}

	protected void ib2_Click(object sender, ImageClickEventArgs e) {
		if (Session["username"] == null) {
			Response.Redirect("login.aspx");
		}
		else {
			addToWishes(Session["username"].ToString().Trim(), "Almond butter tofu stir-fry");
		}
	}

	protected void ib3_Click(object sender, ImageClickEventArgs e) {
		if (Session["username"] == null) {
			Response.Redirect("login.aspx");
		}
		else {
			addToWishes(Session["username"].ToString().Trim(), "Vegan wraps");
		}
	}

	protected void LinkButton1_Click(object sender, EventArgs e) {

		fillRecept("Crispy gluten-free eggplant parmesan");
		gvRecept.Visible = true;
		lblRecipeName.Text = "Crispy gluten-free eggplant parmesan";
		lblRecipeName.Visible = true;
	}

	private void fillRecept(string ime) {
		SqlConnection connection = new SqlConnection();
		connection.ConnectionString = ConfigurationManager.ConnectionStrings["myConnection"].ConnectionString;
		SqlCommand cmd = new SqlCommand();
		cmd.Connection = connection;
		cmd.CommandText = "SELECT sostojki,postapka FROM Recepti WHERE ime=@ime";
		cmd.Parameters.AddWithValue("@ime", ime);
		SqlDataAdapter adapter = new SqlDataAdapter(cmd);
		DataSet ds = new DataSet();
		try {
			connection.Open();
			adapter.Fill(ds, "Recepti");
			gvRecept.DataSource = ds;
			gvRecept.DataBind();
		}
		catch (Exception err) {
			//lblError.Text = err.Message;
		}
		finally {
			connection.Close();
		}
	}

	protected void LinkButton2_Click(object sender, EventArgs e) {
		fillRecept("Almond butter tofu stir-fry");
		gvRecept.Visible = true;
		lblRecipeName.Text = "Almond butter tofu stir-fry";
		lblRecipeName.Visible = true;
	}

	protected void LinkButton3_Click(object sender, EventArgs e) {
		fillRecept("Vegan wraps");
		gvRecept.Visible = true;
		lblRecipeName.Text = "Vegan wraps";
		lblRecipeName.Visible = true;
	}

	protected void ib3_Click(object sender, EventArgs e) {
		if (Session["username"] == null) {
			Response.Redirect("login.aspx");
		}
		else {
			addToWishes(Session["username"].ToString().Trim(), "Vegan wraps");
		}

	}

	protected void ib2_Click(object sender, EventArgs e) {
		if (Session["username"] == null) {
			Response.Redirect("login.aspx");
		}
		else {
			addToWishes(Session["username"].ToString().Trim(), "Almond butter tofu stir-fry");
		}

	}

	protected void ib1_Click(object sender, EventArgs e) {
		if (Session["username"] == null) {
			Response.Redirect("login.aspx");
		}
		else {
			addToWishes(Session["username"].ToString().Trim(), "Crispy gluten-free eggplant parmesan");
		}

	}
}