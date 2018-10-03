using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.IO;

public partial class accessories_Detail : System.Web.UI.Page
{
    Logic obj = new Logic();
    protected int GalleryId;
    protected string GalleryName;
    DcjalagamDataContext dbJalagam = new DcjalagamDataContext();
    protected void Page_Load(object sender, EventArgs e)
    {

        if(!Page.IsPostBack)
        {

            string strTName = Page.RouteData.Values["accessDetail"].ToString();
            litAId.Text = strTName.Substring(strTName.LastIndexOf('-') + 1);


            GetData();
            GetGallery(Convert.ToInt32(litAId.Text));
        }
       
    }

    private void GetData()
    {
        var objC = from objV in dbJalagam.Accessories_Masters
                   where objV.Id == Convert.ToInt32(litAId.Text)
                   select objV;
        Accessories_Master objK = objC.SingleOrDefault();
       

            lbltitle.Text = Convert.ToString(objK.Accessorie_Name);
            lblProductCode.Text = Convert.ToString(objK.Product_Code);
            lblPrice.Text = Convert.ToString(objK.Price);
            lblAboutProduct.Text = Convert.ToString(objK.About_Product);
            lblDescription.Text = Convert.ToString(objK.Description);
            imgAccImage.ImageUrl = "Load-Image.aspx?DisplayPhotoAcc=" + Convert.ToInt32(litAId.Text);

    }



    private void GetGallery(int id)
    {

        GalleryId = id;
        DataSet dsLoadGallery = obj.fnLoadGalleryAcc(GalleryId);
        if (dsLoadGallery.Tables.Count > 0)
        {
            if (dsLoadGallery.Tables[0].Rows.Count > 0)
            {
                GalleryName = dsLoadGallery.Tables["LoadGallery"].Rows[0]["Id"].ToString();

                LoaddlGallery();
            }

        }

    }

    protected void LoaddlGallery()
    {
        string GalleryPath = System.Configuration.ConfigurationManager.AppSettings["GalleryPathAcc"] + GalleryId;
        string GalleryImagePath;

        string ThumbnailPath = System.Configuration.ConfigurationManager.AppSettings["ThumbnailPathAcc"] + GalleryId;
        string ThumbnailImagePath;

        DirectoryInfo dir = new DirectoryInfo(MapPath(GalleryPath));
        FileInfo[] file = dir.GetFiles();
        DataTable dtLoadGallery = new DataTable();
        dtLoadGallery.Columns.Add("GalleryImagePath");
        dtLoadGallery.Columns.Add("ThumbnailImagePath");

        foreach (FileInfo image in file)
        {
            if (image.Extension.ToLower() == ".jpg" || image.Extension.ToLower() == ".jpeg" || image.Extension.ToLower() == ".gif" || image.Extension.ToLower() == ".png" || image.Extension.ToLower() == ".bmp")
            {
                GalleryImagePath = GalleryPath + "\\" + image.Name;
                ThumbnailImagePath = ThumbnailPath + "\\" + image.Name;
                dtLoadGallery.Rows.Add(GalleryImagePath, ThumbnailImagePath);
            }
        }
        rptImage.DataSource = dtLoadGallery;
        rptImage.DataBind();
    }

}