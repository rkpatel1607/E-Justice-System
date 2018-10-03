using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_Panel_ZoneEdit : System.Web.UI.Page
{
    DataClassesDataContext dc = new DataClassesDataContext();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (!string.IsNullOrEmpty(Request.QueryString["id"]))
            {
                btnzsbmt.Text = "Update";
                var data = (from t in dc.Cities
                            where t.Cid.Equals(Request.QueryString["id"])
                            select t).ToList();
                if (data.Count == 1)
                {
                    txtzName.Text = data[0].Cname;
                }
            }
            else
            {
                btnzsbmt.Text = "Insert";
            }
        }
    }
    protected void btnzsbmt_Click(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(Request.QueryString["id"]))
        {
            //update
            dc.Zone_Update(int.Parse(Request.QueryString["id"]), txtzName.Text, true);
            Response.Redirect("ZoneList.aspx");
        }
        {
            //insert
            dc.Zone_Insert(txtzName.Text, true);
            Response.Redirect("ZoneList.aspx");
        }
    }
}