using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Web.Security;
using System.Security.Principal;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;
using System.Configuration;
using System.Data.SqlClient;


public partial class Add_Photo_Gallery : System.Web.UI.Page
{
    DcjalagamDataContext dbJalagam = new DcjalagamDataContext();
    PublicMethods clsPublic = new PublicMethods();
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!Page.IsPostBack)
        {

        }

    }


    protected void btnSubmit_Click(object sender, EventArgs e)



    {

        try
        {

            Save();
        }
        catch (Exception ex)
        {

            throw ex;
        }
    }
    private void Save()
    {

        Photo_Gallery objK = new Photo_Gallery();

        //  objU.UserEmailId = Context.User.Identity.Name.ToString();
        objK.Caption = Convert.ToString(txtTitle.Text);
        objK.CreatedDate = DateTime.Now;


        dbJalagam.Photo_Galleries.InsertOnSubmit(objK);
        dbJalagam.SubmitChanges();
        UploadPhotoAlbum(Convert.ToInt16(objK.Id));
        clsPublic.ClearControls(Page.Controls);
        lblMsg.Text = "<div><i class='fa fa-check fa-2x'></i>" + "Submitted Successfully" + "</div>";
    }
    
    private void UploadPhotoAlbum(int intPhotolId)
    {
        Photo_Gallery_Image_Det objPhotoAlbum;
        using (var dbEmup = new DcjalagamDataContext())
        {

           


            foreach (HttpPostedFile postedFile in fupPhoto.PostedFiles)
            {
                if (postedFile.ContentLength > 0)
                {
                    objPhotoAlbum = new Photo_Gallery_Image_Det();
                    objPhotoAlbum.GalleryId = Convert.ToInt32(intPhotolId);

                    using (System.IO.BinaryReader reader = new System.IO.BinaryReader(postedFile.InputStream))
                    {
                        objPhotoAlbum.Photo = reader.ReadBytes(postedFile.ContentLength);
                    }
                    // if (LitOperation.Text == "add")

                    dbEmup.Photo_Gallery_Image_Dets.InsertOnSubmit(objPhotoAlbum);
                }
            }
            try
            {
                dbEmup.SubmitChanges();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }


   

}