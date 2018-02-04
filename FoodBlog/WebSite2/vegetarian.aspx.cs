using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class vegetarian : System.Web.UI.Page {
	protected void Page_Load(object sender, EventArgs e) {

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

	public void addLikes(string username, string favRecipe) {
		SqlConnection connection = new SqlConnection();
		connection.ConnectionString = ConfigurationManager.ConnectionStrings["myConnection"].ConnectionString;

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
			addLikes(Session["username"].ToString().Trim(), "Cherry tomato and chilli pasta");
		}
	}

	protected void ib2_Click(object sender, ImageClickEventArgs e) {
		if (Session["username"] == null) {
			Response.Redirect("login.aspx");
		}
		else {
			addLikes(Session["username"].ToString().Trim(), "Vegetarian pizza");
		}

	}

	protected void ib3_Click(object sender, ImageClickEventArgs e) {
		if (Session["username"] == null) {
			Response.Redirect("login.aspx");
		}
		else {
			addLikes(Session["username"].ToString().Trim(), "Sweet potato burgers with chilli, mint and mashed avocado");
		}
	}

	protected void ib4_Click(object sender, ImageClickEventArgs e) {
		if (Session["username"] == null) {
			Response.Redirect("login.aspx");
		}
		else {
			addLikes(Session["username"].ToString().Trim(), "Baked eggs with mushrooms, potatoes, spinach and gruyère");
		}
	}

	protected void ib5_Click(object sender, ImageClickEventArgs e) {
		if (Session["username"] == null) {
			Response.Redirect("login.aspx");
		}
		else {
			addLikes(Session["username"].ToString().Trim(), "Roast pumpkin with green charmoula and tahini");
		}
	}

	protected void ib6_Click(object sender, ImageClickEventArgs e) {
		if (Session["username"] == null) {
			Response.Redirect("login.aspx");
		}
		else {
			addLikes(Session["username"].ToString().Trim(), "Hearty Vegetarian Chili");
		}
	}

	protected void ib7_Click(object sender, ImageClickEventArgs e) {
		if (Session["username"] == null) {
			Response.Redirect("login.aspx");
		}
		else {
			addLikes(Session["username"].ToString().Trim(), "Lentil-stuffed eggplant");
		}
	}

	protected void ib8_Click(object sender, ImageClickEventArgs e) {
		if (Session["username"] == null) {
			Response.Redirect("login.aspx");
		}
		else {
			addLikes(Session["username"].ToString().Trim(), "Spicy Spanish potatoes (patatas bravas)");
		}
	}

	protected void ib9_Click(object sender, ImageClickEventArgs e) {
		if (Session["username"] == null) {
			Response.Redirect("login.aspx");
		}
		else {
			addLikes(Session["username"].ToString().Trim(), "Rich red curry with roasted vegetables");
		}
	}

	protected void ib6_Click(object sender, EventArgs e) {
		if (Session["username"] == null) {
			Response.Redirect("login.aspx");
		}
		else {
			addLikes(Session["username"].ToString().Trim(), "Hearty Vegetarian Chili");
		}
	}

	protected void ib9_Click(object sender, EventArgs e) {
		if (Session["username"] == null) {
			Response.Redirect("login.aspx");
		}
		else {
			addLikes(Session["username"].ToString().Trim(), "Rich red curry with roasted vegetables");
		}

	}

	protected void ib7_Click(object sender, EventArgs e) {
		if (Session["username"] == null) {
			Response.Redirect("login.aspx");
		}
		else {
			addLikes(Session["username"].ToString().Trim(), "Lentil-stuffed eggplant");
		}

	}

	protected void ib5_Click(object sender, EventArgs e) {
		if (Session["username"] == null) {
			Response.Redirect("login.aspx");
		}
		else {
			addLikes(Session["username"].ToString().Trim(), "Roast pumpkin with green charmoula and tahini");
		}

	}

	protected void ib4_Click(object sender, EventArgs e) {
		if (Session["username"] == null) {
			Response.Redirect("login.aspx");
		}
		else {
			addLikes(Session["username"].ToString().Trim(), "Baked eggs with mushrooms, potatoes, spinach and gruyère");
		}

	}

	protected void ib3_Click(object sender, EventArgs e) {
		if (Session["username"] == null) {
			Response.Redirect("login.aspx");
		}
		else {
			addLikes(Session["username"].ToString().Trim(), "Sweet potato burgers with chilli, mint and mashed avocado");
		}

	}

	protected void ib1_Click(object sender, EventArgs e) {
		if (Session["username"] == null) {
			Response.Redirect("login.aspx");
		}
		else {
			addLikes(Session["username"].ToString().Trim(), "Cherry tomato and chilli pasta");
		}

	}

	protected void ib8_Click(object sender, EventArgs e) {
		if (Session["username"] == null) {
			Response.Redirect("login.aspx");
		}
		else {
			addLikes(Session["username"].ToString().Trim(), "Spicy Spanish potatoes (patatas bravas)");
		}


	}

	protected void ib2_Click(object sender, EventArgs e) {
		if (Session["username"] == null) {
			Response.Redirect("login.aspx");
		}
		else {
			addLikes(Session["username"].ToString().Trim(), "Hearty Vegetarian Chili");
		}
		addLikes(Session["username"].ToString().Trim(), "Vegetarian pizza");

	}

	protected void LinkButton1_Click(object sender, EventArgs e) {
		fillRecept("Hearty Vegetarian Chili");
		gvRecept.Visible = true;
		lblRecipeName.Text = "Hearty Vegetarian Chili";
		lblRecipeName.Visible = true;
	}
	
	protected void LinkButton2_Click(object sender, EventArgs e) {
		fillRecept("Rich red curry with roasted vegetables");
		gvRecept.Visible = true;
		lblRecipeName.Text = "Rich red curry with roasted vegetables";
		lblRecipeName.Visible = true;
	}

	protected void LinkButton3_Click(object sender, EventArgs e) {
		fillRecept("Lentil-stuffed eggplant");
		gvRecept.Visible = true;
		lblRecipeName.Text = "Lentil-stuffed eggplant";
		lblRecipeName.Visible = true;
	}

	protected void LinkButton4_Click(object sender, EventArgs e) {
		fillRecept("Roast pumpkin with green charmoula and tahini");
		gvRecept.Visible = true;
		lblRecipeName.Text = "Roast pumpkin with green charmoula and tahini";
		lblRecipeName.Visible = true;
	}

	protected void LinkButton5_Click(object sender, EventArgs e) {
		fillRecept("Baked eggs with mushrooms, potatoes, spinach and gruyère");
		gvRecept.Visible = true;
		lblRecipeName.Text = "Baked eggs with mushrooms, potatoes, spinach and gruyère";
		lblRecipeName.Visible = true;
	}

	protected void LinkButton6_Click(object sender, EventArgs e) {
		fillRecept("Sweet potato burgers with chilli, mint and mashed avocado");
		gvRecept.Visible = true;
		lblRecipeName.Text = "Sweet potato burgers with chilli, mint and mashed avocado";
		lblRecipeName.Visible = true;
	}

	protected void LinkButton7_Click(object sender, EventArgs e) {
		fillRecept("Cherry tomato and chilli pasta");
		gvRecept.Visible = true;
		lblRecipeName.Text = "Cherry tomato and chilli pasta";
		lblRecipeName.Visible = true;
	}

	protected void LinkButton8_Click(object sender, EventArgs e) {
		fillRecept("Spicy Spanish potatoes (patatas bravas)");
		gvRecept.Visible = true;
		lblRecipeName.Text = "Spicy Spanish potatoes (patatas bravas)";
		lblRecipeName.Visible = true;
	}

	protected void LinkButton9_Click(object sender, EventArgs e) {
		fillRecept("Vegetarian pizza");
		gvRecept.Visible = true;
		lblRecipeName.Text = "Vegetarian pizza";
		lblRecipeName.Visible = true;
	}
}