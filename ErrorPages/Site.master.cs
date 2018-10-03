using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
using System.IO;
using System.Data;
using System.Net;
using System.Web.Script.Serialization;//
using System.Collections.Specialized;
using Newtonsoft.Json;
using System.Security.Principal;
using System.Globalization;

using System.Web.Services;

using System.Data.SqlClient;

using System.Configuration;
using System.Text;

public partial class SiteMaster : MasterPage
{
    private const string AntiXsrfTokenKey = "__AntiXsrfToken";
    private const string AntiXsrfUserNameKey = "__AntiXsrfUserName";
    private string _antiXsrfTokenValue;
    //PublicMethods clsPublic = new PublicMethods();
    protected void Page_Init(object sender, EventArgs e)
    {
        // The code below helps to protect against XSRF attacks
        var requestCookie = Request.Cookies[AntiXsrfTokenKey];
        Guid requestCookieGuidValue;
        if (requestCookie != null && Guid.TryParse(requestCookie.Value, out requestCookieGuidValue))
        {
            // Use the Anti-XSRF token from the cookie
            _antiXsrfTokenValue = requestCookie.Value;
            Page.ViewStateUserKey = _antiXsrfTokenValue;
        }
        else
        {
            // Generate a new Anti-XSRF token and save to the cookie
            _antiXsrfTokenValue = Guid.NewGuid().ToString("N");
            Page.ViewStateUserKey = _antiXsrfTokenValue;

            var responseCookie = new HttpCookie(AntiXsrfTokenKey)
            {
                HttpOnly = true,
                Value = _antiXsrfTokenValue
            };
            if (FormsAuthentication.RequireSSL && Request.IsSecureConnection)
            {
                responseCookie.Secure = true;
            }
            Response.Cookies.Set(responseCookie);
        }

        Page.PreLoad += master_Page_PreLoad;
    }
    //protected void btnUpdateCity_Click(object sender, EventArgs e)
    //{


    //    Session["loc"] = txtLocation.Text;
    //    lblCity.Text = txtLocation.Text;
    //    Response.Redirect(Request.Url.AbsoluteUri);
    //}

    protected void master_Page_PreLoad(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            // Set Anti-XSRF token
            ViewState[AntiXsrfTokenKey] = Page.ViewStateUserKey;
            ViewState[AntiXsrfUserNameKey] = Context.User.Identity.Name ?? String.Empty;
        }
        else
        {
            // Validate the Anti-XSRF token
            if ((string)ViewState[AntiXsrfTokenKey] != _antiXsrfTokenValue
                || (string)ViewState[AntiXsrfUserNameKey] != (Context.User.Identity.Name ?? String.Empty))
            {
                throw new InvalidOperationException("Validation of Anti-XSRF token failed.");
            }
        }
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
           
        }
    }
  
    protected void Unnamed_LoggingOut(object sender, LoginCancelEventArgs e)
    {
      //  Context.GetOwinContext().Authentication.SignOut();
    }



    //[System.Web.Script.Services.ScriptMethod()]
    //[System.Web.Services.WebMethod]
    //public string[] GetSubCategoryList(string strPrefix)
    //{
    //    //if (intCount == 0)
    //    //{
    //    //    intCount = 10;
    //    //}
    //    DataTable dt = GetRecords(strPrefix);
    //    List<string> items = new List<string>(10);

    //    for (int i = 0; i < dt.Rows.Count; i++)
    //    {
    //        string strName = dt.Rows[i][0].ToString();
    //        items.Add(strName);
    //    }
    //    return items.ToArray();

    //}
    //public DataTable GetRecords(string catname)
    //{
    //    SqlConnection conSql = null;

    //    using (conSql = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
    //    {
    //        using (SqlCommand cmd = conSql.CreateCommand())
    //        {
    //            cmd.CommandType = CommandType.Text;
    //            cmd.CommandText = "select SubCategory  from SubCategoryDet ";
    //            DataSet objDs = new DataSet();
    //            SqlDataAdapter dAdapter = new SqlDataAdapter();
    //            dAdapter.SelectCommand = cmd;
    //            conSql.Open();
    //            dAdapter.Fill(objDs);
    //            conSql.Close();
    //            return objDs.Tables[0];

    //        }

    //    }
    //}

    //public static List<string> GetCompletionList(string prefixText, int count)
    //{
    //    return GetSubCatList(prefixText);

    //}



    //protected void txtSearch_TextChanged(object sender, EventArgs e)
    //{
    //   //GetSubCatList(txtSearch.Text);
    //}

  
}   