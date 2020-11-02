using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Databoundcontrol
{
	public partial class Student : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
			con.Open();
			SqlCommand cmd = new SqlCommand("select * from Student", con);
			SqlDataReader rd = cmd.ExecuteReader();
			RP1.DataSource = rd;
			RP1.DataBind();
			con.Close();

		}
	}
	}
