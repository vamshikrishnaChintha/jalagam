using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.IO;

public partial class Product_Detail : System.Web.UI.Page
{
    Logic obj = new Logic();
    protected int GalleryId;
    protected string GalleryName;
    DcjalagamDataContext dbJalagam = new DcjalagamDataContext();
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!Page.IsPostBack)
        {


            string strTName = Page.RouteData.Values["ProductDetail"].ToString();
            litPId.Text = strTName.Substring(strTName.LastIndexOf('-') + 1);

            GetData();
            GetGallery(Convert.ToInt32(litPId.Text));
        }
    }

    private void GetData()
    {
        var objC = from objV in dbJalagam.Product_Masters
                   where objV.Id == Convert.ToInt32(litPId.Text)
                   select objV;
        Product_Master objK = objC.SingleOrDefault();


        lblBatteryType.Text = Convert.ToString(objK.BatteryType);
        lblColor.Text = Convert.ToString(objK.Color);
        //lblPrice.Text = Convert.ToString(objK.Price);
        lblDescription.Text = Convert.ToString(objK.Description);
        lblProductCode.Text = Convert.ToString(objK.Prodcut_Code);
        lblProductName.Text = Convert.ToString(objK.ProductName);
        lblTags.Text = Convert.ToString(objK.Tags);
        imgProductImage.ImageUrl = "Load-Image.aspx?DisplayPhoto=" + Convert.ToInt32(litPId.Text);
    }


    private void GetGallery(int id)
    {

        GalleryId = id;
        DataSet dsLoadGallery = obj.fnLoadGallery(GalleryId);
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
        string GalleryPath = System.Configuration.ConfigurationManager.AppSettings["GalleryPath"] + GalleryId;
        string GalleryImagePath;

        string ThumbnailPath = System.Configuration.ConfigurationManager.AppSettings["ThumbnailPath"] + GalleryId;
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
        dlGallery.DataSource = dtLoadGallery;
        dlGallery.DataBind();
    }

}