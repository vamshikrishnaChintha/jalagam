using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Our_Products : System.Web.UI.Page
{
    DcjalagamDataContext dbJalagam = new DcjalagamDataContext();
    protected void Page_Load(object sender, EventArgs e)
    {

        if(!Page.IsPostBack)
        {
            BindProducts();
        }
    }


    private void BindProducts()
    {

        gvProducts.DataSource = GetProducts();
        gvProducts.DataBind();
    }


    private IQueryable GetProducts()
    {
        var objC = from objV in dbJalagam.Product_Masters
                   where objV.Visible==null

                   orderby objV.Id descending
                   select new
                   {
                       Id = objV.Id,
                       ProductName = objV.ProductName,
                       ProductCode = objV.Prodcut_Code,
                       Price = objV.Price,
                       BatteryType = objV.BatteryType,
                       Color = objV.Color,
                       Description = objV.Description,
                       Tags = objV.Tags,
                       ProductDetail = (objV.ProductName.Replace(" ", "-").Replace(",", "").Replace(":", "").Replace("!", "").Replace("@", "").Replace("#", "").Replace("$", "").Replace("%", "").Replace("^", "").Replace("&", "").Replace("*", "").Replace("(", "").Replace(")", "").Replace("+", "").Replace("=", "").Replace("{", "").Replace("}", "").Replace(";", "").Replace("'", "").Replace("<", "").Replace(">", "").Replace("/", "").Replace("?", "").Replace("|", "")).Trim() + "-" + objV.Id,


                   };

        return objC;
    }
}