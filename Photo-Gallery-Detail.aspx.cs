using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Photo_Gallery_Detail : System.Web.UI.Page
{
    DcjalagamDataContext dbJalagam = new DcjalagamDataContext();
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!Page.IsPostBack)
        {
            GetData();
            GetPhotoGalleryAlbum();
        }

    }

    private void GetData()
    {

        var objG = from objA in dbJalagam.Photo_Galleries
                   where objA.Id == Convert.ToInt32(Request.QueryString["Id"])
                   select objA;
        Photo_Gallery objD = objG.SingleOrDefault();
        if (objD != null)
        {

            lblCaption.Text = Convert.ToString(objD.Caption);
          
        }
       
    }

    private void GetPhotoGalleryAlbum()
    {
       
        rptImage.DataSource = GetAdImages(Convert.ToInt16(Request.QueryString["Id"]));
        rptImage.DataBind();

    }

    public IQueryable GetAdImages(int intId)
    {

        var objL = from objI in dbJalagam.Photo_Gallery_Image_Dets
                   where objI.GalleryId == intId
                   orderby objI.PhotoId ascending
                   select new
                   {
                       ImageId = objI.PhotoId,
                       
                   };

        return objL;
    }
}