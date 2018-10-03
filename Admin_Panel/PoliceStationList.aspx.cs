using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_Panel_PoliceStationList : System.Web.UI.Page
{
    DataClassesDataContext dc = new DataClassesDataContext();

    protected void Page_Load(object sender, EventArgs e)
    {

        var data = (from ta in dc.PoliceStations
                    join tc in dc.Areas on ta.Aid equals tc.Aid
                    join td in dc.CityZones on tc.Zcid equals td.Zcid
                    join ts in dc.Zones on td.Zid equals ts.Zid
                    join tci in dc.Cities on td.Cid equals tci.Cid
                    select new { ta.Psid, ts.Zname, tci.Cname, tc.Aname, ta.PTitle, ta.PContactNo, ta.PEmail, ta.PersonContact }).ToList();

        string str = "<table>";
        str += "<tr><th>Edit</th><th>Delete</th><th>Police Station</th><th>City</th><th>Zone</th><th>Area</th><th>Name</th><th>Contact No</th><th>Email</th><th>Incharge Contact</th></tr>";
        foreach (var item in data)
        {
            str += "<tr><td><a href=PliceStationEdit.aspx?id=" + item.Psid + ">Update</a></td><td>Delete</td><td>" + item.Cname + "</td><td>" + item.Zname + "</td><td>" + item.Aname + "</td><td>" + item.PTitle + "</td><td>" + item.PContactNo + "</td><td>" + item.PEmail + "</td><td>" + item.PersonContact + "</td></tr>";
        }
        str += "</table>";
        display.InnerHtml = str;


    }
    protected void btnaradd_Click(object sender, EventArgs e)
    {
        Response.Redirect("PoliceStationEdit.aspx");
    }
}