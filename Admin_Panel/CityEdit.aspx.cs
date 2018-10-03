using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_Panel_CityEdit : System.Web.UI.Page
{
    DataClassesDataContext dc = new DataClassesDataContext();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (!string.IsNullOrEmpty(Request.QueryString["id"]))
            {
                btnSubmit.Text = "Update";
                var data = (from t in dc.Cities
                            where t.Cid.Equals(Request.QueryString["id"])
                            select t).ToList();
                if( data.Count ==1)
                {
                    txtCName.Text = data[0].Cname;
                }
            }
            else
            {
                btnSubmit.Text = "Insert";
            }
        }
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        if(!string .IsNullOrEmpty (Request.QueryString ["id"]))
        {
            //update
            dc.City_Update(int.Parse(Request.QueryString["id"]), txtCName.Text,true);
            Response.Redirect("CityList.aspx");
        }
        {
            //insert
            dc.City_Insert(txtCName.Text,true);
            Response.Redirect("CityList.aspx");
        }
    }
}