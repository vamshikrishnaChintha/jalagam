using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Photo_Gallery_List : System.Web.UI.Page
{
    DcjalagamDataContext dbJalagam = new DcjalagamDataContext();
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!Page.IsPostBack)
        {
            BindPhotoGallery();
        }
    }

    private void BindPhotoGallery()
    {
        gvPhotoGallery.DataSource = GetPhotoGallery();
        gvPhotoGallery.DataBind();
    }


    private IQueryable GetPhotoGallery()
    {
        var objC = from objV in dbJalagam.Photo_Galleries

                   orderby objV.CreatedDate descending
                   select new
                   {
                       Id = objV.Id,
                       Title = objV.Caption,
                     

                   };
        return objC;
    }
}