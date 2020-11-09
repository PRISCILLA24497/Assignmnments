using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace FlightAssignmenr
{
	public partial class Flightdetails : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void Button1_Click(object sender, EventArgs e)
		{
			SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
			con.Open();
			var insertQuery = "insert into Flightdetails(FlightId,FlightNumber,FlightName,Source,Destination)values(@FlightId,@FlightNumber,@FlightName,@Source,@Destination)";
			SqlCommand cmd = new SqlCommand(insertQuery, con);



			cmd.Parameters.AddWithValue("@FlightId", TextBox1.Text);
			cmd.Parameters.AddWithValue("@FlightNumber", TextBox2.Text);
			cmd.Parameters.AddWithValue("@FlightName", TextBox3.Text);
			cmd.Parameters.AddWithValue("@Source", TextBox4.Text);
			cmd.Parameters.AddWithValue("@Destination", TextBox5.Text);


			cmd.ExecuteNonQuery();
			Response.Write("Flight Details Added");
			con.Close();


		}
	}
}