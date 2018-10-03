using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_Panel_ZoneList : System.Web.UI.Page
{
    DataClassesDataContext dc = new DataClassesDataContext();

    protected void Page_Load(object sender, EventArgs e)
    {
        var data = (from t in dc.Zones select t).ToList();
        string str = "<table>";
        str += "<tr><th>Edit</th><th>Delete</th><th>Zone</th></tr>";
        foreach (var item in data)
        {
            str += "<tr><td><a href=ZoneEdit.aspx?id=" + item.Zid + ">Update</a></td><td>Delete</td><td>" + item.Zname + "</td></tr>";
        }
        str += "</table>";
        display.InnerHtml = str;
    }
    protected void btnzone_Click(object sender, EventArgs e)
    {
        Response.Redirect("ZoneEdit.aspx");
    }
}