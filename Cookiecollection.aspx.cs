using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace cookies
{
	public partial class Cookiecollection : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			Response.Cookies["computer"].Expires = DateTime.Now.AddDays(-1);

		}

		protected void button1_Click(object sender, EventArgs e)
		{
			label2.Text = "please select  your choice ";
			//Adding cookies
			if (checkbox1.Checked)
				Response.Cookies["computer"]["iphone"] = "you have checked for iphone and cookie triggered";
			if (checkbox2.Checked)
				Response.Cookies["computer"]["samsung"] = "you have checked for samsung and cookie triggered";
			if (checkbox3.Checked)
				Response.Cookies["computer"]["oppo"] = "you have checked for oppo and cookie triggered";
			if (checkbox4.Checked)
				Response.Cookies["computer"]["realme"] = "you have checked for realme and cookie triggered";
			if (checkbox5.Checked)
				Response.Cookies["computer"]["nokia"] = "you have checked for nokia and cookie triggered";
			if (checkbox6.Checked)
				Response.Cookies["computer"]["lenovo"] = "you have checked for lenovo and cookie triggered";
			if (checkbox7.Checked)
				Response.Cookies["computer"]["motorola"] = "you have checked for motorola and cookie triggered";
			if (checkbox8.Checked)
				Response.Cookies["computer"]["mi"] = "you have checked for mi and cookie triggered";
			if (checkbox9.Checked)
				Response.Cookies["computer"]["lyf"] = "you have checked for lyf and cookie triggered";
			if (checkbox10.Checked)
				Response.Cookies["computer"]["nazro"] = "you have checked for nazro and cookie triggered";
			//fetching code
			if (Request.Cookies["computer"].Values.ToString() != null)
			{
				if (Request.Cookies["computer"]["iphone"] != null)
					label2.Text = label2.Text + Response.Cookies["computer"]["iphone"] + " " + " ";
				if (Request.Cookies["computer"]["samsung"] != null)
					label2.Text = label2.Text + Response.Cookies["computer"]["samsung"] + " " + " ";
				if (Request.Cookies["computer"]["oppo"] != null)
					label2.Text = label2.Text + Response.Cookies["computer"]["oppo"] + " " + " ";
				if (Request.Cookies["computer"]["realme"] != null)
					label2.Text = label2.Text + Response.Cookies["computer"]["realme"] + " " + " ";
				if (Request.Cookies["computer"]["nokia"] != null)
					label2.Text = label2.Text + Response.Cookies["computer"]["nokia"] + " " + " ";
				if (Request.Cookies["computer"]["lenovo"] != null)
					label2.Text = label2.Text + Response.Cookies["computer"]["lenovo"] + " " + " ";
				if (Request.Cookies["computer"]["motorola"] != null)
					label2.Text = label2.Text + Response.Cookies["computer"]["mmotorrola"] + " " + " ";
				if (Request.Cookies["computer"]["mi"] != null)
					label2.Text = label2.Text + Response.Cookies["computer"]["mi"] + " " + " ";
				if (Request.Cookies["computer"]["lyf"] != null)
					label2.Text = label2.Text + Response.Cookies["computer"]["lyf"] + " " + " ";
				if (Request.Cookies["computer"]["nazro"] != null)
					label2.Text = label2.Text + Response.Cookies["computer"]["nazro"] + " " + " ";
			}
			else
			{
				label2.Text = "please select your choice";
				Response.Cookies["computer"].Expires = DateTime.Now.AddDays(-1);
			}
		}

		protected void checkbox1_CheckedChanged(object sender, EventArgs e)
		{

		}
	}
}