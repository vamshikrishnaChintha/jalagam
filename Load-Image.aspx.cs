using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
public partial class MainForms_ServicesLocalBiz_SportsTaining_LoadLogo : System.Web.UI.Page
{
    DcjalagamDataContext dbJalagam = new DcjalagamDataContext();
   
    protected void Page_Load(object sender, EventArgs e)
    {





        if (Convert.ToString(Request.QueryString["GId"]) != null)
        {

            Response.Buffer = true;
            Response.Charset = "";
            Response.Cache.SetCacheability(HttpCacheability.NoCache);



            {
                var obj = (from objImg in dbJalagam.Photo_Gallery_Image_Dets
                           where objImg.GalleryId == Convert.ToInt16(Request["GId"])
                           select objImg).Take(1);
                Photo_Gallery_Image_Det objI;

                objI = obj.SingleOrDefault();
                if (objI != null)
                {
                    if (Convert.ToString(objI.Photo).Length != 0)
                    {

                        Byte[] bytImage = (Byte[])objI.Photo.ToArray();
                        Response.BinaryWrite(bytImage);
                    }
                }
            }


        }

        if (Convert.ToString(Request.QueryString["PhotoGalleryPhoto"]) != null)
        {

            Response.Buffer = true;
            Response.Charset = "";
            Response.Cache.SetCacheability(HttpCacheability.NoCache);



            {
                var objA = from objImg in dbJalagam.Photo_Gallery_Image_Dets
                           where objImg.PhotoId == Convert.ToInt16(Request["PhotoGalleryPhoto"])
                           select objImg;
                Photo_Gallery_Image_Det objC = objA.FirstOrDefault();
                if (objC != null)
                {
                    if (Convert.ToString(objC.Photo).Length != 0)
                    {

                        Byte[] bytImage = (Byte[])objC.Photo.ToArray();
                        Response.BinaryWrite(bytImage);
                    }
                }
            }
        }


        if (Convert.ToString(Request.QueryString["DisplayPhoto"]) != null)
        {

            Response.Buffer = true;
            Response.Charset = "";
            Response.Cache.SetCacheability(HttpCacheability.NoCache);



            {
                var objA = from objImg in dbJalagam.Product_Masters
                           where objImg.Id == Convert.ToInt16(Request["DisplayPhoto"])
                           select objImg;
                Product_Master objC = objA.FirstOrDefault();
                if (objC != null)
                {
                    if (Convert.ToString(objC.DisplayImage).Length != 0)
                    {

                        Byte[] bytImage = (Byte[])objC.DisplayImage.ToArray();
                        Response.BinaryWrite(bytImage);
                    }
                }
            }


        }



        if (Convert.ToString(Request.QueryString["DisplayPhotoAcc"]) != null)
        {

            Response.Buffer = true;
            Response.Charset = "";
            Response.Cache.SetCacheability(HttpCacheability.NoCache);



            {
                var objA = from objImg in dbJalagam.Accessories_Masters
                           where objImg.Id == Convert.ToInt16(Request["DisplayPhotoAcc"])
                           select objImg;
                Accessories_Master objC = objA.FirstOrDefault();
                if (objC != null)
                {
                    if (Convert.ToString(objC.DisplayImage).Length != 0)
                    {

                        Byte[] bytImage = (Byte[])objC.DisplayImage.ToArray();
                        Response.BinaryWrite(bytImage);
                    }
                }
            }


        }

        // to get all ad images
        //if (Convert.ToString(Request.QueryString["AdId"]) != null)
        //{

        //    Response.Buffer = true;
        //    Response.Charset = "";
        //    Response.Cache.SetCacheability(HttpCacheability.NoCache);



        //    {
        //        var obj = from objImg in dbEmup.UserAdsImagesDets
        //                           where objImg.UserAdId == Convert.ToInt16(Request["AdId"])
        //                           select objImg;
        //        UserAdsImagesDet objI;
        //        objI = obj.SingleOrDefault();
        //        if (objI != null)
        //        {
        //            if (Convert.ToString(objI.Image).Length != 0)
        //            {

        //                Byte[] bytImage = (Byte[])objI.Image.ToArray();
        //                Response.BinaryWrite(bytImage);
        //            }
        //        }
        //    }


        //}





        Response.Flush();
        Response.End();
    }


}