using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_Panel_CriminalList : System.Web.UI.Page
{
    DataClassesDataContext dc = new DataClassesDataContext();

    protected void Page_Load(object sender, EventArgs e)
    {

        var data = (from ta in dc.Criminals
                    join tc in dc.Crimes on ta.CrimeId equals tc.CrimeId
                    join tz in dc.Users on ta.Uid equals tz.Uid
                    join ty in dc.CrimeTypes on ta.CrimeTypeID equals ty.CrimeTypeId
                    select new { ta.Criminalid,tc.CrimeId, tc.Crimedetails, tc.DOC, tz.Uemailid,ty.CTName }).ToList();

        string str = "<table>";
        str += "<tr><th>Edit</th><th>Delete</th><th>Criminal</th><th>Crime Id</th><th>Crime type</th><th>Crime Details</th><th>Date of Crime</th><th>Person Id</th></tr>";
        foreach (var item in data)
        {
            str += "<tr><td><a href=CriminalEdit.aspx?id=" + item.Criminalid + ">Update</a></td><td>Delete</td><td>" + item.CrimeId + "</td><td>" + item.CTName + "</td><td>" + item.Crimedetails + "</td><td>" + item.DOC + "</td><td>" + item.Uemailid + "</td></tr>";
        }
        str += "</table>";
        display.InnerHtml = str;


    }
    protected void btnaradd_Click(object sender, EventArgs e)
    {
        Response.Redirect("CriminalEdit.aspx");
    }
}