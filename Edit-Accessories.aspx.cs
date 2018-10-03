using GoogleMaps.LocationServices;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Edit_Accessories : System.Web.UI.Page
{
    DcjalagamDataContext dbJalagam = new DcjalagamDataContext();
    PublicMethods clsPublic = new PublicMethods();
    protected void Page_Load(object sender, EventArgs e)
    {

        Page.Form.Attributes.Add("enctype", "multipart/form-data");


        if (!Page.IsPostBack)
        {

            //if (Context.User.Identity.IsAuthenticated == false)
            //{
            //    HttpContext.Current.User = new GenericPrincipal(new GenericIdentity(string.Empty), null);
            //    FormsAuthentication.SignOut();
            //    Session.Abandon();
            //    Response.Redirect("Sign-In.aspx");
            //}
            GetData();
        }
    }

    private void Save()
    {

       // Accessories_Master objK = new Accessories_Master();

        Accessories_Master objK;
        objK = dbJalagam.Accessories_Masters.SingleOrDefault(obj => obj.Id == Convert.ToInt16(Request.QueryString["Id"]));
        objK.Accessorie_Name = Convert.ToString(txtTitle.Text);
        objK.Product_Code = Convert.ToString(txtProductCode.Text);
        objK.Price = Convert.ToString(txtPrice.Text);
        objK.About_Product = Convert.ToString(txtAbout.Text);
        objK.Description = Convert.ToString(txtDesc.Text);

        // objU.CreatedBy = Context.User.Identity.Name.ToString();
        if (fupDisplayImage.HasFile)
        {
            using (System.IO.BinaryReader reader = new System.IO.BinaryReader(fupDisplayImage.PostedFile.InputStream))
            {
                objK.DisplayImage = reader.ReadBytes(fupDisplayImage.PostedFile.ContentLength);
            }
        }
        else
        {
            objK.DisplayImage = null;
        }

        dbJalagam.SubmitChanges();
        SaveAlbum(Convert.ToInt16(objK.Id));
        clsPublic.ClearControls(Page.Controls);

        lblMsg.Text = "<div><i class='fa fa-check fa-2x'></i>" + "Updated Successfully" + "</div>";
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


    private void GetData()
    {
        var objC = from objV in dbJalagam.Accessories_Masters
                   where objV.Id == Convert.ToInt32(Request.QueryString["Id"])
                   select objV;
        Accessories_Master objK = objC.SingleOrDefault();
        
        txtTitle.Text = Convert.ToString(objK.Accessorie_Name);
        txtProductCode.Text = Convert.ToString(objK.Product_Code);
        txtPrice.Text = Convert.ToString(objK.Price);
        txtDesc.Text = Convert.ToString(objK.Description);
        txtAbout.Text = Convert.ToString(objK.About_Product);

    }


    private void SaveAlbum(int MaxGalleryId)
    {
        Logic obj = new Logic();
        string FileName;
        string error;
        string GalleryPath = System.Configuration.ConfigurationManager.AppSettings["GalleryPathAcc"] + MaxGalleryId;
        Directory.CreateDirectory(Server.MapPath(GalleryPath));

        string ThumbnailPath = System.Configuration.ConfigurationManager.AppSettings["ThumbnailPathAcc"] + MaxGalleryId;
        Directory.CreateDirectory(Server.MapPath(ThumbnailPath));

        StringBuilder UploadedFileNames = new StringBuilder();

        HttpFileCollection hfc = Request.Files;
        for (int i = 0; i < hfc.Count; i++)
        {
            HttpPostedFile hpf = hfc[i];
            
                string str = System.IO.Path.GetFileName(hpf.FileName);
                string replacestr = Regex.Replace(str, "[^a-zA-Z0-9_.]+", "");
                //FileName = System.IO.Path.GetFileName(hpf.FileName.Replace(" ", ""));
                FileName = replacestr;
          

            if (hpf.ContentLength > 0)
            {
                if (hpf.ContentLength < 5307200)
                {

                    string Ext = System.IO.Path.GetExtension(hpf.FileName.Replace(" ", ""));
                    if ((Ext == ".png") || (Ext == ".PNG") || (Ext == ".jpg") || (Ext == ".JPG") || (Ext == ".jpeg") || (Ext == ".JPEG") || (Ext == ".bmp") || (Ext == ".gif"))
                    {
                        
                            String UploadedFile = hpf.FileName;
                            int ExtractPos = UploadedFile.LastIndexOf("\\") + 1;

                            //to retrieve only Filename from the complete path
                            String UploadedFileName = UploadedFile.Substring(ExtractPos, UploadedFile.Length - ExtractPos);
                            string SaveAsImage = System.IO.Path.Combine(Server.MapPath(GalleryPath + "/"), Regex.Replace(UploadedFileName, "[^a-zA-Z0-9_.]+", ""));
                            hpf.SaveAs(SaveAsImage);

                            //Create thumbnail for uploaded file and save thumbnail on disk
                            Bitmap Thumbnail = CreateThumbnail(SaveAsImage, 200, 200);
                            string SaveAsThumbnail = System.IO.Path.Combine(Server.MapPath(ThumbnailPath + "/"), Regex.Replace(UploadedFileName, "[^a-zA-Z0-9_.]+", ""));
                            Thumbnail.Save(SaveAsThumbnail);
                       



                    }
                    else
                    {
                        error = "'" + FileName.ToString() + "'" + " Failed :" + "'" + Ext.ToString() + "'" + " Extension not supported... " + "";
                    }
                }
                else
                {
                    error = "'" + FileName.ToString() + "'" + " Failed : " + " file length should not exceed 3MB... " + "";
                }
            }
            else
            {
                error = "'" + FileName.ToString() + "'" + " Failed : " + " File is Empty... " + "";
            }
        }
    }

    public Bitmap CreateThumbnail(string ImagePath, int ThumbnailWidth, int ThumbnailHeight)
    {
        System.Drawing.Bitmap Thumbnail = null;
        try
        {
            Bitmap ImageBMP = new Bitmap(ImagePath);
            ImageFormat loFormat = ImageBMP.RawFormat;

            decimal lengthRatio;
            int ThumbnailNewWidth = 0;
            int ThumbnailNewHeight = 0;
            decimal ThumbnailRatioWidth;
            decimal ThumbnailRatioHeight;
            // If the uploaded image is smaller than a thumbnail size the just return it
            if (ImageBMP.Width <= ThumbnailWidth && ImageBMP.Height <= ThumbnailHeight)
                return ImageBMP;

            // Compute best ratio to scale entire image based on larger dimension.
            if (ImageBMP.Width > ImageBMP.Height)
            {
                ThumbnailRatioWidth = (decimal)ThumbnailWidth / ImageBMP.Width;
                ThumbnailRatioHeight = (decimal)ThumbnailHeight / ImageBMP.Height;
                lengthRatio = Math.Min(ThumbnailRatioWidth, ThumbnailRatioHeight);
                ThumbnailNewWidth = ThumbnailWidth;
                decimal lengthTemp = ImageBMP.Height * lengthRatio;
                ThumbnailNewHeight = (int)lengthTemp;
            }
            else
            {
                ThumbnailRatioWidth = (decimal)ThumbnailWidth / ImageBMP.Width;
                ThumbnailRatioHeight = (decimal)ThumbnailHeight / ImageBMP.Height;
                lengthRatio = Math.Min(ThumbnailRatioWidth, ThumbnailRatioHeight);
                ThumbnailNewHeight = ThumbnailHeight;
                decimal lengthTemp = ImageBMP.Width * lengthRatio;
                ThumbnailNewWidth = (int)lengthTemp;
            }
            Thumbnail = new Bitmap(ThumbnailNewWidth, ThumbnailNewHeight);
            Graphics g = Graphics.FromImage(Thumbnail);
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            g.FillRectangle(Brushes.White, 0, 0, ThumbnailNewWidth, ThumbnailNewHeight);
            g.DrawImage(ImageBMP, 0, 0, ThumbnailNewWidth, ThumbnailNewHeight);

            ImageBMP.Dispose();
        }
        catch
        {
            return null;
        }

        return Thumbnail;
    }
}