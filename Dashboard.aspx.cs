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

public partial class Dashboard : System.Web.UI.Page
{
    DcjalagamDataContext dbJalagam = new DcjalagamDataContext();
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!Page.IsPostBack)
        {

            //BindGridaccessories();

            //BindGridBranches();

            //BindGridDealer();

            //BindGridProducts();

            //BindGridTestDriving();
            //BindDealerApproval();
            if (Context.User.Identity.IsAuthenticated == false)

            {
                HttpContext.Current.User = new GenericPrincipal(new GenericIdentity(string.Empty), null);
                FormsAuthentication.SignOut();
                Session.Abandon();

                //  Response.Redirect("Organizer-Login.aspx");
                Response.Redirect("Sign-In.aspx");
            }

            else
            {
                BindGridaccessories();

                BindGridBranches();

                BindGridDealer();

                BindGridProducts();

                BindGridTestDriving();
                BindDealerApproval();

                BindGridPhotoGallery();
                BindGridContactUs();
            }

        }

    }

    #region Accessories

   

    private IQueryable Getaccessories()
    {
        var objC = from objV in dbJalagam.Accessories_Masters

                   orderby objV.Id descending
                   select new
                   {
                       Id = objV.Id,
                       Title = objV.Accessorie_Name,
                       Pcode = objV.Product_Code,
                       Price = objV.Price,
                       About = objV.About_Product,
                       Description = objV.Description,
                       accessDetail = (objV.Accessorie_Name.Replace(" ", "-").Replace(",", "").Replace(":", "").Replace("!", "").Replace("@", "").Replace("#", "").Replace("$", "").Replace("%", "").Replace("^", "").Replace("&", "").Replace("*", "").Replace("(", "").Replace(")", "").Replace("+", "").Replace("=", "").Replace("{", "").Replace("}", "").Replace(";", "").Replace("'", "").Replace("<", "").Replace(">", "").Replace("/", "").Replace("?", "").Replace("|", "")).Trim() + "-" + objV.Id,

                   };

        return objC;
    }



    protected void gvAccessories_RowDeleted(object sender, GridViewDeletedEventArgs e)
    {

    }
    
    protected void gvAccessories_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {

    }

    protected void gvAccessories_RowEditing(object sender, GridViewEditEventArgs e)
    {
        gvAccessories.EditIndex = e.NewEditIndex;
        this.BindGridaccessories();
    }

    protected void gvAccessories_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        try
        {
            int AccId = Convert.ToInt32(gvAccessories.DataKeys[e.RowIndex].Values[0]);


            Accessories_Master objCV = (from c in dbJalagam.Accessories_Masters
                                         where c.Id == AccId
                                        select c).FirstOrDefault();

        
                dbJalagam.Accessories_Masters.DeleteOnSubmit(objCV);


                dbJalagam.SubmitChanges();
           




        }
        catch (Exception ex)
        {
            throw ex;
            //  dbEMUP.Transaction.Rollback();
        }
        finally
        {
            this.BindGridaccessories();
        }
    }
    private void BindGridaccessories()
    {
        gvAccessories.DataSource = Getaccessories();
        gvAccessories.DataBind();
    }

    protected void gvAccessories_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        //if (e.Row.RowType == DataControlRowType.DataRow && e.Row.RowIndex != gvAngels.EditIndex)
        //{
        //    (e.Row.Cells[2].Controls[2] as LinkButton).Attributes["onclick"] = "return confirm('Do you want to delete this row?');";
        //}
    }

    protected void gvAccessories_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {

        gvAccessories.PageIndex = e.NewPageIndex;
        this.BindGridaccessories();

    }

    protected void gvAccessories_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        Response.Redirect("Edit-Accessories.aspx?Id=" + Convert.ToInt32(gvAccessories.DataKeys[e.RowIndex].Values[0]));
    }
    #endregion Accessories





    #region Branches



    private IQueryable GetBranches()
    {
        var objC = from objV in dbJalagam.Branch_Details

                   orderby objV.Branch_Id descending
                   select new
                   {
                       Id = objV.Branch_Id,
                       Title = objV.Branch_Name,
                      

                   };

        return objC;
    }



    protected void gvBranch_RowDeleted(object sender, GridViewDeletedEventArgs e)
    {

    }

    protected void gvBranch_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {

    }

    protected void gvBranch_RowEditing(object sender, GridViewEditEventArgs e)
    {
        gvBranch.EditIndex = e.NewEditIndex;
        this.BindGridBranches();
    }

    protected void gvBranch_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        try
        {
            int BranchId = Convert.ToInt32(gvBranch.DataKeys[e.RowIndex].Values[0]);


            Branch_Detail objCV = (from c in dbJalagam.Branch_Details
                                        where c.Branch_Id == BranchId
                                   select c).FirstOrDefault();


            dbJalagam.Branch_Details.DeleteOnSubmit(objCV);           
            dbJalagam.SubmitChanges();
            
        }
        catch (Exception ex)
        {
            throw ex;
            //  dbEMUP.Transaction.Rollback();
        }
        finally
        {
            this.BindGridBranches();
        }
    }
    private void BindGridBranches()
    {
        gvBranch.DataSource = GetBranches();
        gvBranch.DataBind();
    }

    protected void gvBranch_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        //if (e.Row.RowType == DataControlRowType.DataRow && e.Row.RowIndex != gvAngels.EditIndex)
        //{
        //    (e.Row.Cells[2].Controls[2] as LinkButton).Attributes["onclick"] = "return confirm('Do you want to delete this row?');";
        //}
    }

    protected void gvBranch_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {

        gvBranch.PageIndex = e.NewPageIndex;
        this.BindGridBranches();

    }

    protected void gvBranch_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        Response.Redirect("Edit-Branches.aspx?Id=" + Convert.ToInt32(gvBranch.DataKeys[e.RowIndex].Values[0]));
    }
    #endregion Branches



    #region Dealer



    private IQueryable GetDealer()
    {
        var objC = from objV in dbJalagam.Dealer_Registrations

                   orderby objV.Id descending
                   select new
                   {
                       Id = objV.Id,
                       Title = objV.Dealer_Name,                      
                       Status=objV.Status,


                   };

        return objC;
    }



    protected void gvDealer_RowDeleted(object sender, GridViewDeletedEventArgs e)
    {

    }

    protected void gvDealer_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {

    }

    protected void gvDealer_RowEditing(object sender, GridViewEditEventArgs e)
    {
        gvDealer.EditIndex = e.NewEditIndex;
        this.BindGridDealer();
    }

    protected void gvDealer_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        try
        {
            int DealerId = Convert.ToInt32(gvDealer.DataKeys[e.RowIndex].Values[0]);


            Dealer_Registration objCV = (from c in dbJalagam.Dealer_Registrations
                                   where c.Id == DealerId
                                   select c).FirstOrDefault();


            dbJalagam.Dealer_Registrations.DeleteOnSubmit(objCV);
            dbJalagam.SubmitChanges();

        }
        catch (Exception ex)
        {
            throw ex;
            //  dbEMUP.Transaction.Rollback();
        }
        finally
        {
            this.BindGridDealer();
        }
    }
    private void BindGridDealer()
    {
        gvDealer.DataSource = GetDealer();
        gvDealer.DataBind();
    }

    protected void gvDealer_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        //if (e.Row.RowType == DataControlRowType.DataRow && e.Row.RowIndex != gvAngels.EditIndex)
        //{
        //    (e.Row.Cells[2].Controls[2] as LinkButton).Attributes["onclick"] = "return confirm('Do you want to delete this row?');";
        //}
    }

    protected void gvDealer_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {

        gvDealer.PageIndex = e.NewPageIndex;
        this.BindGridBranches();

    }

    protected void gvDealer_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        Response.Redirect("Edit-Dealer.aspx?Id=" + Convert.ToInt32(gvDealer.DataKeys[e.RowIndex].Values[0]));
    }
    #endregion Dealer




    #region Product



    private IQueryable GetProducts()
    {
        var objC = from objV in dbJalagam.Product_Masters
                   where objV.Visible==null

                   orderby objV.Id descending
                   select new
                   {
                       Id = objV.Id,
                       Title = objV.ProductName,
                       ProductDetail = (objV.ProductName.Replace(" ", "-").Replace(",", "").Replace(":", "").Replace("!", "").Replace("@", "").Replace("#", "").Replace("$", "").Replace("%", "").Replace("^", "").Replace("&", "").Replace("*", "").Replace("(", "").Replace(")", "").Replace("+", "").Replace("=", "").Replace("{", "").Replace("}", "").Replace(";", "").Replace("'", "").Replace("<", "").Replace(">", "").Replace("/", "").Replace("?", "").Replace("|", "")).Trim() + "-" + objV.Id,


                   };

        return objC;
    }



    protected void gvproduct_RowDeleted(object sender, GridViewDeletedEventArgs e)
    {

    }

    protected void gvproduct_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {

    }

    protected void gvproduct_RowEditing(object sender, GridViewEditEventArgs e)
    {
        gvproduct.EditIndex = e.NewEditIndex;
        this.BindGridProducts();
    }

    protected void gvproduct_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        try
        {
            int ProductId = Convert.ToInt32(gvproduct.DataKeys[e.RowIndex].Values[0]);


            Product_Master objK;
            objK = dbJalagam.Product_Masters.SingleOrDefault(obj => obj.Id == ProductId);

            objK.Visible = "No";



            //Product_Master objCV = (from c in dbJalagam.Product_Masters
            //                        where c.Id == ProductId
            //                        select c).FirstOrDefault();

            if (objK != null)
            {
               // dbJalagam.Product_Masters.InsertOnSubmit(objK);
                dbJalagam.SubmitChanges();
            }



        }
        catch (Exception ex)
        {
            throw ex;
            //  dbEMUP.Transaction.Rollback();
        }
        finally
        {
            this.BindGridProducts();
        }
    }
    private void BindGridProducts()
    {
        gvproduct.DataSource = GetProducts();
        gvproduct.DataBind();
    }

    protected void gvproduct_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        //if (e.Row.RowType == DataControlRowType.DataRow && e.Row.RowIndex != gvAngels.EditIndex)
        //{
        //    (e.Row.Cells[2].Controls[2] as LinkButton).Attributes["onclick"] = "return confirm('Do you want to delete this row?');";
        //}
    }

    protected void gvproduct_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {

        gvproduct.PageIndex = e.NewPageIndex;
        this.BindGridProducts();

    }

    protected void gvproduct_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        Response.Redirect("Edit-Product.aspx?Id=" + Convert.ToInt32(gvproduct.DataKeys[e.RowIndex].Values[0]));
    }
    #endregion Product


    #region PhotoGallery



    private IQueryable GetPhotoGallery()
    {
        var objC = from objV in dbJalagam.Photo_Galleries
                  

                   orderby objV.Id descending
                   select new
                   {
                       Id = objV.Id,
                       Title = objV.Caption,


                   };

        return objC;
    }



    protected void gvPhotoGallery_RowDeleted(object sender, GridViewDeletedEventArgs e)
    {

    }

    protected void gvPhotoGallery_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {

    }

    protected void gvPhotoGallery_RowEditing(object sender, GridViewEditEventArgs e)
    {
        gvproduct.EditIndex = e.NewEditIndex;
        this.BindGridPhotoGallery();
    }

    protected void gvPhotoGallery_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        try
        {
            int intGalleryId = Convert.ToInt32(gvPhotoGallery.DataKeys[e.RowIndex].Values[0]);



            var objCV = dbJalagam.Photo_Gallery_Image_Dets.Where(C => C.GalleryId == intGalleryId);


            if (objCV != null)
            {
                dbJalagam.Photo_Gallery_Image_Dets.DeleteAllOnSubmit(objCV);

                dbJalagam.SubmitChanges();

            }

            //Photo_Gallery_Image_Det objCV = (from c in dbJalagam.Photo_Gallery_Image_Dets
            //                        where c.GalleryId == intGalleryId
            //                                 select c).FirstOrDefault();

            //if (objCV != null)
            //{
            //     dbJalagam.Photo_Gallery_Image_Dets.DeleteOnSubmit(objCV);
            //    dbJalagam.SubmitChanges();
            //}


            //  int DealerId = Convert.ToInt32(gvDealer.DataKeys[e.RowIndex].Values[0]);


            Photo_Gallery objCVk = (from c in dbJalagam.Photo_Galleries
                                         where c.Id == intGalleryId
                                          select c).FirstOrDefault();


            dbJalagam.Photo_Galleries.DeleteOnSubmit(objCVk);
            dbJalagam.SubmitChanges();

        }
        catch (Exception ex)
        {
            throw ex;
            //  dbEMUP.Transaction.Rollback();
        }
        finally
        {
            this.BindGridPhotoGallery();
        }
    }
    private void BindGridPhotoGallery()
    {
        gvPhotoGallery.DataSource = GetPhotoGallery();
        gvPhotoGallery.DataBind();
    }

    protected void gvPhotoGallery_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        //if (e.Row.RowType == DataControlRowType.DataRow && e.Row.RowIndex != gvAngels.EditIndex)
        //{
        //    (e.Row.Cells[2].Controls[2] as LinkButton).Attributes["onclick"] = "return confirm('Do you want to delete this row?');";
        //}
    }

    protected void gvPhotoGallery_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {

        gvPhotoGallery.PageIndex = e.NewPageIndex;
        this.BindGridPhotoGallery();

    }

    protected void gvPhotoGallery_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        Response.Redirect("Edit-Photo-Gallery.aspx?Id=" + Convert.ToInt32(gvPhotoGallery.DataKeys[e.RowIndex].Values[0]));
    }
    #endregion Product


    #region Test Drive



    private IQueryable GetTestDriving()
    {
        var objC = from objV in dbJalagam.Test_Driving_Dets

                   orderby objV.Id descending
                   select new
                   {
                       Id = objV.Id,
                       Title = objV.Name,


                   };

        return objC;
    }



    protected void gvTestDriving_RowDeleted(object sender, GridViewDeletedEventArgs e)
    {

    }

    protected void gvTestDriving_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {

    }

    protected void gvTestDriving_RowEditing(object sender, GridViewEditEventArgs e)
    {
        gvTestDriving.EditIndex = e.NewEditIndex;
        this.BindGridTestDriving();
    }

    protected void gvTestDriving_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        try
        {
            int DriveId = Convert.ToInt32(gvTestDriving.DataKeys[e.RowIndex].Values[0]);


            Test_Driving_Det objCV = (from c in dbJalagam.Test_Driving_Dets
                                    where c.Id == DriveId
                                    select c).FirstOrDefault();

            
                dbJalagam.Test_Driving_Dets.DeleteOnSubmit(objCV);
                dbJalagam.SubmitChanges();
            



        }
        catch (Exception ex)
        {
            throw ex;
            //  dbEMUP.Transaction.Rollback();
        }
        finally
        {
            this.BindGridTestDriving();
        }
    }
    private void BindGridTestDriving()
    {
        gvTestDriving.DataSource = GetTestDriving();
        gvTestDriving.DataBind();
    }

    protected void gvTestDriving_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        //if (e.Row.RowType == DataControlRowType.DataRow && e.Row.RowIndex != gvAngels.EditIndex)
        //{
        //    (e.Row.Cells[2].Controls[2] as LinkButton).Attributes["onclick"] = "return confirm('Do you want to delete this row?');";
        //}
    }

    protected void gvTestDriving_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {

        gvTestDriving.PageIndex = e.NewPageIndex;
        this.BindGridTestDriving();

    }

    protected void gvTestDriving_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        Response.Redirect("Edit-Test-Drive.aspx?Id=" + Convert.ToInt32(gvTestDriving.DataKeys[e.RowIndex].Values[0]));
    }
    #endregion Product

    #region ContactUs



    private IQueryable GetContactUs()
    {
        var objC = from objV in dbJalagam.Contact_Us

                   orderby objV.Id descending
                   select new
                   {
                       Id = objV.Id,
                       Name=objV.Name,
                       EmailId = objV.EmailId,
                       ContactNo=objV.ContactNumber,
                       Reason=objV.Description,
                       PostedDate=objV.CreatedDate


                   };

        return objC;
    }




   
    private void BindGridContactUs()
    {
        gvContact.DataSource = GetContactUs();
        gvContact.DataBind();
    }

   
    protected void gvContact_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {

        gvContact.PageIndex = e.NewPageIndex;
        this.BindGridContactUs();

    }


    #endregion ContactUs



    protected void gvDealerApproval_RowDeleted(object sender, GridViewDeletedEventArgs e)
    {

    }

    protected void gvDealerApproval_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        //gvArticle.EditIndex = -1;
        //BindGridViewArticle();
    }

    protected void gvDealerApproval_RowEditing(object sender, GridViewEditEventArgs e)
    {
        gvDealerApproval.EditIndex = e.NewEditIndex;
        this.BindDealerApproval();
    }

    protected void gvDealerApproval_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        //try
        //{
        //    int DId = Convert.ToInt32(gvDealerApproval.DataKeys[e.RowIndex].Values[0]);
        //    //dbEMUP.Connection.Open();
        //    //dbEMUP.Connection.BeginTransaction();

        //    Dealer_Registration objP = (from c in dbJalagam.Dealer_Registrations
        //                    where c.Id == DId
        //                    select c).FirstOrDefault();

        //    dbJalagam.Dealer_Registrations.DeleteOnSubmit(objP);


        //    dbEmup.SubmitChanges();


        //}
        //catch (Exception ex)
        //{
        //    throw ex;
        //    //  dbEMUP.Transaction.Rollback();
        //}
        //finally
        //{
        //    this.BindGridViewArticle();
        //}
    }
    private void BindDealerApproval()
    {
        gvDealerApproval.DataSource = GetDealer();
        gvDealerApproval.DataBind();
    }

    protected void gvDealerApproval_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        //if (e.Row.RowType == DataControlRowType.DataRow && e.Row.RowIndex != gvAngels.EditIndex)
        //{
        //    (e.Row.Cells[2].Controls[2] as LinkButton).Attributes["onclick"] = "return confirm('Do you want to delete this row?');";
        //}
    }

    protected void gvDealerApproval_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {

        gvDealerApproval.PageIndex = e.NewPageIndex;
        this.BindDealerApproval();

    }

    protected void gvDealerApproval_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        try
        {


            int intId = Convert.ToInt32(gvDealerApproval.DataKeys[e.RowIndex].Value.ToString());

            Dealer_Registration objU;
            objU = dbJalagam.Dealer_Registrations.SingleOrDefault(objO => objO.Id == Convert.ToInt16(intId));

            objU.Status = "Approved";
           // objU.ApprovedBy = Context.User.Identity.Name.ToString();

            dbJalagam.SubmitChanges();


        }
        catch (Exception ex)
        {
            throw ex;
        }

        finally
        {

            gvDealerApproval.EditIndex = -1;
            BindDealerApproval();
            //BindGridView();

        }
    }



}