using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.Data;
using System.Xml;
using System.Data.SqlClient;
using System.Configuration;
using GoogleMaps;
/// <summary>
/// Summary description for PublicMethods
/// </summary>
public class PublicMethods
{
    public string salti { get; set; }
    public string slong { get; set; }
    public string zipcode { get; set; }
    public string country { get; set; }
    public string region { get; set; }
    public string city { get; set; }
    public string cityCode { get; set; }


    DcjalagamDataContext dbJalagam = new DcjalagamDataContext();
    public PublicMethods()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public void ClearControls(ControlCollection ctrls)
    {
        foreach (Control ctrl in ctrls)
        {
            if (ctrl is TextBox)
                ((TextBox)ctrl).Text = string.Empty;


            ClearControls(ctrl.Controls);
        }
    }
    public void FillDropDownList(IQueryable IqueryName, DropDownList ddlDropDownList)
    {

        ddlDropDownList.Items.Clear();
        ddlDropDownList.Items.Add("Select");
        ddlDropDownList.DataSource = IqueryName;
        ddlDropDownList.DataValueField = "Value";
        ddlDropDownList.DataTextField = "Text";



        ddlDropDownList.DataBind();

    }
    public void FillListBox(IQueryable IqueryName, ListBox lstBox)
    {

        lstBox.Items.Clear();
        lstBox.Items.Add("Select");
        lstBox.DataSource = IqueryName;
        lstBox.DataValueField = "Value";
        lstBox.DataTextField = "Text";



        lstBox.DataBind();

    }
    public void FillCheckBoxList(IQueryable IqueryName, CheckBoxList chkBoxlist)
    {

        chkBoxlist.Items.Clear();

        chkBoxlist.DataSource = IqueryName;
        chkBoxlist.DataValueField = "Value";
        chkBoxlist.DataTextField = "Text";



        chkBoxlist.DataBind();

    }
    public void FillRadioBoxList(IQueryable IqueryName, RadioButtonList rdBoxlist)
    {

        rdBoxlist.Items.Clear();

        rdBoxlist.DataSource = IqueryName;
        rdBoxlist.DataValueField = "Value";
        rdBoxlist.DataTextField = "Text";



        rdBoxlist.DataBind();

    }
   
    //public bool ValidateUser(string userMailId)
    //{


    //    bool exist = dbEmup.UserDets.Any(email => email.EmailId.Equals(userMailId));
    //    return exist;

    //}
    //public bool ValidateBusinessUser(string userMailId)
    //{


    //    var obj = from objP in dbEmup.UserDets
    //              where objP.Role == "Business" && objP.EmailId == userMailId
    //              select objP;
    //    if (obj.Count() > 0)
    //    {
    //        return true;
    //    }
    //    else
    //    {
    //        return false;
    //    }

    //}
    //public bool ValidateEventOrganizer(string userMailId)
    //{


    //    var obj = from objP in dbEmup.Event_Oraganization_Creates
    //              where objP.Email == userMailId
    //              select objP;
    //    if (obj.Count() > 0)
    //    {
    //        return true;
    //    }
    //    else
    //    {

    //        return false;
    //    }

    //}
    //public bool ValidateUser(string userMailId, string strPwd)
    //{
    //    var objPwd = from objP in dbEmup.UserDets
    //                 where objP.Password == strPwd && objP.EmailId == userMailId && objP.Status == "Active"
    //                 select objP;
    //    if (objPwd.Count() > 0)
    //    {
    //        return true;
    //    }
    //    else
    //    {
    //        return false;
    //    }

    //    //bool exist = dbEmup.UserDets.Any(email => email.EmailId.Equals(userMailId));
    //    //return exist;

    //}
    //public bool ValidatePassword(string userMailId, string strPwd)
    //{
    //    var objPwd = from objP in dbEmup.UserDets
    //                 where objP.Password == strPwd && objP.EmailId == userMailId
    //                 select objP;
    //    if (objPwd.Count() > 0)
    //    {
    //        return true;
    //    }
    //    else
    //    {
    //        return false;
    //    }

    //}
    



}