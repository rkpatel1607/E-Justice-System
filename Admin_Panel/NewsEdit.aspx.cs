using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_Panel_NewsEdit : System.Web.UI.Page
{
    DataClassesDataContext dc = new DataClassesDataContext();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (!string.IsNullOrEmpty(Request.QueryString["id"]))
            {
                btnSubmit.Text = "Update";
                var data = (from t in dc.News
                            where t.Nid.Equals(Request.QueryString["id"])
                            select t).ToList();
                if (data.Count == 1)
                {
                    txtntname.Text = data[0].NTitle;
                    txtdate.Text = data[0].NDate.ToString();
                    txtndname.Text = data[0].NDescp;
                    Imgnews.ImageUrl = "~/Img/" + data[0].NImg;
                    Hdfnews.Value = data[0].NImg;
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
        if (!string.IsNullOrEmpty(Request.QueryString["id"]))
        {
            //update
            if (fulnews.HasFile == true)
            {
                fulnews.SaveAs(Server.MapPath("~/Img/") + fulnews.FileName);
                dc.News_Update(int.Parse(Request.QueryString["id"]), txtntname.Text, txtndname.Text, fulnews.FileName, true,System.DateTime.Now.Date);
            }
            else
            {
                dc.News_Update(int.Parse(Request.QueryString["id"]), txtntname.Text, txtndname.Text, Hdfnews .Value , true,System.DateTime.Now.Date);
            }
            Response.Redirect("NewsList.aspx");
        }
        {
            //insert
            if(fulnews .HasFile ==true )
            {
                fulnews .SaveAs (Server .MapPath ("~/Img/") + fulnews .FileName );
            
            }
            dc.News_Insert(txtntname.Text,true,txtndname.Text, fulnews.FileName,System.DateTime.Now.Date);
            Response.Redirect("NewsList.aspx");
        }

    }
}


