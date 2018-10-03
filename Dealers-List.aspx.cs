using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Dealers_List : System.Web.UI.Page
{

    DcjalagamDataContext dbJalagam = new DcjalagamDataContext();
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!Page.IsPostBack)
        {
            BindDealer();
        }
    }

    private void BindDealer()
    {
        gvDealers.DataSource = GetDealers();
        gvDealers.DataBind();
    }


    private IQueryable GetDealers()
    {
        var objC = from objV in dbJalagam.Dealer_Registrations

                   orderby objV.CreatedDate descending
                   select new
                   {
                       Id = objV.Id,
                       DealerName = objV.Dealer_Name,
                       City = objV.City,
                     
                   };
        return objC;
    }

}