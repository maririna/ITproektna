using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI.WebControls;
//using System.Data;
using System.Data.SqlClient;

/// <summary>
/// Summary description for WishlistWebService
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class WishlistWebService : System.Web.Services.WebService
{

    public WishlistWebService()
    {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }

    [WebMethod(Description = "This method fills a gridview with informations stored in a DB.")]
    public DataTable Get(string username)
    {
        string constr = ConfigurationManager.ConnectionStrings["myConnection"].ConnectionString;
        using (SqlConnection con = new SqlConnection(constr))
        {
            SqlCommand cmd=new SqlCommand("SELECT favRecipe FROM Wishes WHERE username=@username");
            cmd.Parameters.AddWithValue("@username", username);
           
                using (SqlDataAdapter sda = new SqlDataAdapter())
                {
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    using (DataTable dt = new DataTable())
                    {
                        dt.TableName = "Wishes";
                        sda.Fill(dt);
                        return dt;
                    }
                }
            
        }
    }
    
}
