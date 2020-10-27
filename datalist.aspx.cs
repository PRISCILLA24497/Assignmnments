using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace cookies
{
	public partial class datalist : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			DataTable table = new DataTable();
			table.Columns.Add("FirstName");
			table.Columns.Add("LastName");
			table.Columns.Add("Designation");
			table.Columns.Add("Location");
			table.Columns.Add("Country");
			table.Rows.Add("Priscilla", "katherine", "Cse", "Visakhapatnam", "India");
			table.Rows.Add("Soumya", "Sree", "Cse", "Visakhapatnam", "India");
			table.Rows.Add("Ramya", "Malla", "Ece", "Visakhapatnam", "India");
			table.Rows.Add("Neelu", "Parapati", "Cse", "Visakhapatnam", "India");
			table.Rows.Add("Sravani", "Mavilapalli", "Cse", "Hyderabad", "India");
			table.Rows.Add("Vastsala", "SJ", "Cse", "Hyderabad", "India");
			table.Rows.Add("Madhuri", "Alli", "Ded", "Delhhi", "India");
			table.Rows.Add("Sushmitha", "Malla", "Ded", "Hyderabad", "India");
			table.Rows.Add("Sindhu", "mahi", "Cse", "Visakhapatnaamm", "India");
			table.Rows.Add("Haritha", "Yelleti", "Cse", "Visakhapatnam", "India");
			datalist1.DataSource = table;
			datalist1.DataBind();

		}
	}
}