using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_Panel_AreaList : System.Web.UI.Page
{
    DataClassesDataContext dc = new DataClassesDataContext();

    protected void Page_Load(object sender, EventArgs e)
    {
       
        var data = (from ta in dc.Areas 
                     join tc in dc.CityZones on ta.Zcid equals tc.Zcid 
                     join tz in dc.Zones on tc.Zid equals tz.Zid
                     join tci in dc.Cities on tc.Cid equals tci.Cid 
                     select new { ta.Aid,ta.Aname, tz.Zname, tci.Cname  }).ToList();

        string str = "<table>";
        str += "<tr><th>Edit</th><th>Delete</th><th>City</th><th>Zone</th><th>Area</th></tr>";
        foreach (var item in data)
        {
            str += "<tr><td><a href=AreaEdit.aspx?id=" + item.Aid + ">Update</a></td><td>Delete</td><td>" + item.Aname + "</td><td>" + item.Zname + "</td><td>" + item.Cname + "</td></tr>";
        }
        str += "</table>";
        display.InnerHtml = str;

    }
    protected void btnaradd_Click(object sender, EventArgs e)
    {
        Response.Redirect("AreaEdit.aspx");
    }
}