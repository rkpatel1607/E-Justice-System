using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_Panel_CrimeList : System.Web.UI.Page
{
    DataClassesDataContext dc = new DataClassesDataContext();

    protected void Page_Load(object sender, EventArgs e)
    {

        var data = (from ta in dc.Crimes
                    join tc in dc.Areas on ta.Aid equals tc.Aid
                    join td in dc.CityZones on tc.Zcid equals td.Zcid
                    join ts in dc.Zones on td.Zid equals ts.Zid
                    join tci in dc.Cities on td.Cid equals tci.Cid
                    join tz in dc.Users on ta.Uid equals tz.Uid
                    join ty in dc.CrimeTypes on ta.CrimeTypeId equals ty.CrimeTypeId
                    select new {ta.CrimeId,tc.Aname,ts.Zname,tci.Cname, tz.Uemailid,ty.CTName,ta.Priority,ta.DOC,ta.DOU,ta.Crimedetails,ta.Detail}).ToList();

                   
        string str = "<table>";
        str += "<tr><th>Edit</th><th>Delete</th><th>Crime</th><th>City</th><th>Zone</th><th>Area</th><th>Person ID</th><th>Crime Type</th><th>Crime Details</th><th>Priority</th><th>Date of Crime</th><th>Date of Update</th><th>Investigation Details</th></tr>";
        foreach (var item in data)
        {
            str += "<tr><td><a href=CrimeEdit.aspx?id=" + item.CrimeId + ">Update</a></td><td>Delete</td><td>" + item.Cname + "</td><td>" + item.Zname + "</td><td>" + item.Aname + "</td><td>" + item.Uemailid + "</td><td>" + item.CTName + "</td><td>" + item.Crimedetails + "</td><td>" + item.Priority + "</td><td>" + item.DOC + "</td><td>" + item.DOU + "</td><td>" + item.Detail + "</td></tr>";
        }
        str += "</table>";
        display.InnerHtml = str;

    }
    protected void btnaradd_Click(object sender, EventArgs e)
    {
        Response.Redirect("AreaEdit.aspx");
    }
}