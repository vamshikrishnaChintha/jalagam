using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class accessories_List : System.Web.UI.Page
{

    DcjalagamDataContext dbJalagam = new DcjalagamDataContext();
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!Page.IsPostBack)
        {
            Bindaccessories();
        }
    }


    private void Bindaccessories()
    {

        gvacc.DataSource = Getaccessories();
        gvacc.DataBind();
    }


    private IQueryable Getaccessories()
    {
        var objC = from objV in dbJalagam.Accessories_Masters

                   orderby objV.Id descending
                   select new
                   {
                       AId = objV.Id,
                       Title = objV.Accessorie_Name,
                       Pcode = objV.Product_Code,
                       Price = objV.Price,
                       About = objV.About_Product,
                       Description = objV.Description,
                       accessDetail = (objV.Accessorie_Name.Replace(" ", "-").Replace(",", "").Replace(":", "").Replace("!", "").Replace("@", "").Replace("#", "").Replace("$", "").Replace("%", "").Replace("^", "").Replace("&", "").Replace("*", "").Replace("(", "").Replace(")", "").Replace("+", "").Replace("=", "").Replace("{", "").Replace("}", "").Replace(";", "").Replace("'", "").Replace("<", "").Replace(">", "").Replace("/", "").Replace("?", "").Replace("|", "")).Trim() + "-" + objV.Id,


                   };

        return objC;
    }
}