<%@ Application Language="C#" %>
<%@ Import Namespace="System.Web.Routing" %>
<script RunAt="server">

     void Application_Start(object sender, EventArgs e) 
    {
        // Code that runs on application startup
        RegisterRoutes(RouteTable.Routes);

    }


    static void RegisterRoutes(RouteCollection routes)
    {
         routes.Add(new Route("{resource}.axd/{*pathInfo}", new StopRoutingHandler()));
        routes.MapPageRoute("", "electric-vehicles", "~/Default.aspx");
         routes.MapPageRoute("", "electric-vehicles-accessories", "~/accessories-List.aspx");
         routes.MapPageRoute("", "electric-vehicles-Products", "~/Our-Products.aspx");
         routes.MapPageRoute("", "jalagam-Motors-Branches", "~/Branches-List.aspx");
      

        #region(Dynamic User Friendly URL's)
        routes.MapPageRoute("accessories", "jalagam-accessories-{accessDetail}", "~/accessories-Detail.aspx");
         routes.MapPageRoute("Product", "Product-{ProductDetail}", "~/Product-Detail.aspx");
        
       
        #endregion
    }
    protected void Application_PreRequestHandlerExecute(Object sender, EventArgs e)
    {
        // only apply session cookie persistence to requests requiring session information

        #region session cookie 
        if (Context.Handler is IRequiresSessionState || Context.Handler is IReadOnlySessionState)
        {
            /// Ensure ASP.NET Session Cookies are accessible throughout the subdomains.
            if (Request.Cookies["ASP.NET_SessionId"] != null && Session != null && Session.SessionID != null)
            {
                Response.Cookies["ASP.NET_SessionId"].Value = Session.SessionID;
                Response.Cookies["ASP.NET_SessionId"].Domain = ".jhalak.com"; // the full stop prefix denotes all sub domains
                Response.Cookies["ASP.NET_SessionId"].Path = "/"; //default session cookie path root          
            }
        }
        #endregion
    }
    void Application_Error(object sender, EventArgs e)
    {
        // Code that runs when an unhandled error occurs

        // Get the exception object.
        Exception exc = Server.GetLastError();

        // Handle HTTP errors
        if (exc.GetType() == typeof(HttpException))
        {
            // The Complete Error Handling Example generates
            // some errors using URLs with "NoCatch" in them;
            // ignore these here to simulate what would happen
            // if a global.asax handler were not implemented.
            if (exc.Message.Contains("NoCatch") || exc.Message.Contains("maxUrlLength"))
                return;

            //Redirect HTTP errors to HttpError page
            Server.Transfer("~/errorpages/error-400-Bad-Request.aspx");
        }
        
        // Clear the error from the server
        Server.ClearError();
    }
</script>
