using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_Panel_AreaEdit : System.Web.UI.Page
{
    DataClassesDataContext dc = new DataClassesDataContext();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            var datac = (from t in dc.Cities select t).ToList();
            ddlCity.DataSource = datac;
            ddlCity.DataTextField = "Cname";
            ddlCity.DataValueField = "Cid";
            ddlCity.DataBind();

            if (!string.IsNullOrEmpty(Request.QueryString["id"]))
            {
                btnarsbmt.Text = "Update";
                var data = (from t in dc.Areas
                            where t.Aid.Equals(Request.QueryString["id"])
                            select t).ToList();
                if (data.Count == 1)
                {
                    txtareaname.Text = data[0].Aname;
                    ddlZone.SelectedValue = data[0].Zcid.ToString ();
                }
            }
            else
            {
                btnarsbmt.Text = "Insert";
            }
        }

    }
    protected void btnarsbmt_Click(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(Request.QueryString["id"]))
        {
            //update
            dc.Area_Update(int.Parse(Request.QueryString["id"]),txtareaname.Text,int.Parse (ddlZone .SelectedValue ), true);
            Response.Redirect("AreaList.aspx");
        }
        {
            //insert
            dc.Area_Insert(txtareaname.Text,int.Parse (ddlZone .SelectedValue ), true);
            Response.Redirect("AreaList.aspx");






        }

    }
    protected void ddlCity_SelectedIndexChanged(object sender, EventArgs e)
    {
        var datac = (from tc in dc.CityZones
                     join tz in dc.Zones on tc.Zid equals tz.Zid
                     where tc.Cid.Equals(int.Parse(ddlCity.SelectedValue))
                     select new { tz.Zname, tc.Zcid }).ToList();
        ddlZone .DataSource = datac;
        ddlZone.DataTextField = "Zname";
        ddlZone.DataValueField = "Zcid";
        ddlZone.DataBind();
    }
}