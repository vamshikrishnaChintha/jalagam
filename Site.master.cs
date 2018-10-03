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
using System.Xml;

using System.Web.Services;

using System.Data.SqlClient;

using System.Configuration;
using System.Text;
using System.Xml.Linq;
using System.Windows.Forms;
using GoogleMaps.LocationServices;
public partial class SiteMaster : MasterPage
{


  //  PublicMethods clsPublic = new PublicMethods();
    DcjalagamDataContext dbEmup = new DcjalagamDataContext();
    public string Banner1 { get; set; }
    public string Banner2 { get; set; }
    public string Banner3 { get; set; }
    public string Banner4 { get; set; }
    public string Banner5 { get; set; }
    string strState;
    string urlDynamic = "";
    protected void Page_Load(object sender, EventArgs e)
    {


        if (!Page.IsPostBack)
        {
            

        }
    }



}