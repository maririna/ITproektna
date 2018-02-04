using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class wishlist : System.Web.UI.Page {
	protected void Page_Load(object sender, EventArgs e) {
		if (!Page.IsPostBack) {

			bindGrid();

		}
	}
	CRUD_Service.WishlistWebService service = new CRUD_Service.WishlistWebService();
	
	private void bindGrid() {
		if (Session["username"] != null) {
			gvWishList.DataSource = service.Get(Session["username"].ToString().Trim());
			gvWishList.DataBind();
		}
	
	}

	private void Compose() {
		//compose.Visible = true;
	}


	protected void gvWishlist_SelectedIndexChanged(object sender, EventArgs e) {

	}


	protected void gvWishlist_RowDeleting(object sender, GridViewDeleteEventArgs e) {
		Label l1 = gvWishList.Rows[e.RowIndex].FindControl("lbl1") as Label;
		SqlConnection connection = new SqlConnection();
		connection.ConnectionString = ConfigurationManager.ConnectionStrings["myConnection"].ConnectionString;
		connection.Open();
		SqlCommand cmd = new SqlCommand();
		cmd.Connection = connection;
		cmd.CommandText = "DELETE FROM Wishes WHERE username=@username and favRecipe=@favRecipe";
		cmd.Parameters.AddWithValue("@username", Session["username"].ToString().Trim());
		cmd.Parameters.AddWithValue("@favRecipe", l1.Text);
		cmd.ExecuteNonQuery();
		gvWishList.DataSource = service.Get(Session["username"].ToString().Trim());
		gvWishList.DataBind();
		connection.Close();
	}

	protected void btnCompose_Click(object sender, EventArgs e) {
		Response.Redirect("vegan.aspx");
	}
}