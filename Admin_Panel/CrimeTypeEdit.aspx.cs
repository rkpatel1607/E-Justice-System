using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_Panel_CrimeTypeEdit : System.Web.UI.Page
{
    DataClassesDataContext dc = new DataClassesDataContext();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (!string.IsNullOrEmpty(Request.QueryString["id"]))
            {
                btnSubmit.Text = "Update";
                var data = (from t in dc.CrimeTypes
                            where t.CrimeTypeId.Equals(Request.QueryString["id"])
                            select t).ToList();
                if( data.Count ==1)
                {
                    txtctname.Text = data[0].CTName;
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
            dc.CrimeType_Update(int.Parse(Request.QueryString["id"]), txtctname.Text,true);
            Response.Redirect("CrimeTypeList.aspx");
        }
        {
            //insert
            dc.CrimeType_Insert(txtctname.Text,true);
            Response.Redirect("CrimeTypeList.aspx");
        }
    }
    
}