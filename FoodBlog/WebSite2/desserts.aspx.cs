using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class desserts : System.Web.UI.Page {

	protected void Page_Load(object sender, EventArgs e) {
		//details.Visible = false;

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
			addLikes(Session["username"].ToString().Trim(), "Mini vegan pumpkin pies");
		}
	}

	protected void ib2_Click(object sender, ImageClickEventArgs e) {
		if (Session["username"] == null) {
			Response.Redirect("login.aspx");
		}
		else {
			addLikes(Session["username"].ToString().Trim(), "Dark chocolate peppermint mousse");
		}

	}

	protected void ib3_Click(object sender, ImageClickEventArgs e) {
		if (Session["username"] == null) {
			Response.Redirect("login.aspx");
		}
		else {
			addLikes(Session["username"].ToString().Trim(), "Gluten-free cinnamon rolls");
		}
	}

	protected void ib4_Click(object sender, ImageClickEventArgs e) {
		if (Session["username"] == null) {
			Response.Redirect("login.aspx");
		}
		else {
			addLikes(Session["username"].ToString().Trim(), "Peanut butter pretzel truffles");
		}
	}

	protected void ib5_Click(object sender, ImageClickEventArgs e) {
		if (Session["username"] == null) {
			Response.Redirect("login.aspx");
		}
		else {
			addLikes(Session["username"].ToString().Trim(), "7-ingredient vegan cheesecake");
		}
	}

	protected void ib6_Click(object sender, ImageClickEventArgs e) {
		if (Session["username"] == null) {
			Response.Redirect("login.aspx");
		}
		else {
			addLikes(Session["username"].ToString().Trim(), "Vegan chocolate cake");
		}
	}

	protected void ib7_Click(object sender, ImageClickEventArgs e) {
		if (Session["username"] == null) {
			Response.Redirect("login.aspx");
		}
		else {
			addLikes(Session["username"].ToString().Trim(), "Bourbon caramel almond butter cups");
		}
	}

	protected void ib8_Click(object sender, ImageClickEventArgs e) {
		if (Session["username"] == null) {
			Response.Redirect("login.aspx");
		}
		else {
			addLikes(Session["username"].ToString().Trim(), "No bake chocolate cheesecake");
		}
	}

	protected void ib9_Click(object sender, ImageClickEventArgs e) {
		if (Session["username"] == null) {
			Response.Redirect("login.aspx");
		}
		else {
			addLikes(Session["username"].ToString().Trim(), "Vegan chocolate lava cake");
		}
	}

	protected void ib6_Click(object sender, EventArgs e) {
		if (Session["username"] == null) {
			Response.Redirect("login.aspx");
		}
		else {
			addLikes(Session["username"].ToString().Trim(), "Vegan chocolate cake");
		}

	}

	protected void ib9_Click(object sender, EventArgs e) {
		if (Session["username"] == null) {
			Response.Redirect("login.aspx");
		}
		else {
			addLikes(Session["username"].ToString().Trim(), "Vegan chocolate lava cake");
		}

	}

	protected void ib7_Click(object sender, EventArgs e) {
		if (Session["username"] == null) {
			Response.Redirect("login.aspx");
		}
		else {
			addLikes(Session["username"].ToString().Trim(), "Bourbon caramel almond butter cups");
		}

	}

	protected void ib5_Click(object sender, EventArgs e) {
		if (Session["username"] == null) {
			Response.Redirect("login.aspx");
		}
		else {
			addLikes(Session["username"].ToString().Trim(), "7-ingredient vegan cheesecake");
		}

	}

	protected void ib4_Click(object sender, EventArgs e) {
		if (Session["username"] == null) {
			Response.Redirect("login.aspx");
		}
		else {
			addLikes(Session["username"].ToString().Trim(), "Peanut butter pretzel truffles");
		}

	}

	protected void ib3_Click(object sender, EventArgs e) {
		if (Session["username"] == null) {
			Response.Redirect("login.aspx");
		}
		else {
			addLikes(Session["username"].ToString().Trim(), "Gluten-free cinnamon rolls");
		}

	}

	protected void ib1_Click(object sender, EventArgs e) {
		if (Session["username"] == null) {
			Response.Redirect("login.aspx");
		}
		else {
			addLikes(Session["username"].ToString().Trim(), "Mini vegan pumpkin pies");
		}

	}

	protected void ib8_Click(object sender, EventArgs e) {
		if (Session["username"] == null) {
			Response.Redirect("login.aspx");
		}
		else {
			addLikes(Session["username"].ToString().Trim(), "No bake chocolate cheesecake");
		}

	}

	protected void ib2_Click(object sender, EventArgs e) {
		if (Session["username"] == null) {
			Response.Redirect("login.aspx");
		}
		else {
			addLikes(Session["username"].ToString().Trim(), "Dark chocolate peppermint mousse");
		}

	}

	protected void LinkButton2_Click(object sender, EventArgs e) {
		fillRecept("Vegan chocolate cake");
		gvRecept.Visible = true;
		lblRecipeName.Text = "Vegan chocolate cake";
		lblRecipeName.Visible = true;
	}

	protected void LinkButton3_Click(object sender, EventArgs e) {
		fillRecept("Vegan chocolate lava cake");
		gvRecept.Visible = true;
		lblRecipeName.Text = "Vegan chocolate lava cake";
		lblRecipeName.Visible = true;
	}

	protected void LinkButton9_Click(object sender, EventArgs e) {
		fillRecept("No bake chocolate cheesecake");
		gvRecept.Visible = true;
		lblRecipeName.Text = "No bake chocolate cheesecake";
		lblRecipeName.Visible = true;
	}

	protected void LinkButton5_Click(object sender, EventArgs e) {
		fillRecept("7-ingredient vegan cheesecake");
		gvRecept.Visible = true;
		lblRecipeName.Text = "7-ingredient vegan cheesecake";
		lblRecipeName.Visible = true;
	}

	protected void LinkButton6_Click(object sender, EventArgs e) {
		fillRecept("Peanut butter pretzel truffles");
		gvRecept.Visible = true;
		lblRecipeName.Text = "Peanut butter pretzel truffles";
		lblRecipeName.Visible = true;
	}

	protected void LinkButton7_Click(object sender, EventArgs e) {
		fillRecept("Gluten-free cinnamon rolls");
		gvRecept.Visible = true;
		lblRecipeName.Text = "Gluten-free cinnamon rolls";
		lblRecipeName.Visible = true;
	}

	protected void LinkButton8_Click(object sender, EventArgs e) {
		fillRecept("Mini vegan pumpkin pies");
		gvRecept.Visible = true;
		lblRecipeName.Text = "Mini vegan pumpkin pies";
		lblRecipeName.Visible = true;
	}

	protected void LinkButton10_Click(object sender, EventArgs e) {
		fillRecept("Dark chocolate peppermint mousse");
		gvRecept.Visible = true;
		lblRecipeName.Text = "Dark chocolate peppermint mousse";
		lblRecipeName.Visible = true;

	}

	protected void LinkButton4_Click(object sender, EventArgs e) {
		fillRecept("Bourbon caramel almond butter cups");
		gvRecept.Visible = true;
		lblRecipeName.Text = "Bourbon caramel almond butter cups";
		lblRecipeName.Visible = true;
	}
}