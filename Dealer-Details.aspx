<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Dealer-Details.aspx.cs" Inherits="Dealer_Details" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit.HTMLEditor" TagPrefix="cc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
    <link rel="icon" href="" type="image/x-icon" />
    <link type="text/css" rel="stylesheet" href="font-awesome/css/font-awesome.min.css"
        hreflang="en-us" />
    <link rel="stylesheet" href="css/custom.css" type="text/css" />
    <link rel="stylesheet" href="css/forms.css" type="text/css" />
    <link href="css/style.css" rel='stylesheet' type='text/css' />
    <link href="font-awesome/css/all.css" rel='stylesheet' type='text/css'/>
    <script type="text/javascript" src="js/jquery-1-11-1.js"></script>
    <script type="text/javascript" src="js/bootstrap.min.js"></script>

    <link rel="stylesheet" href="css/bootstrap.css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
    <div>
        <img src="images/jslide-01-inner.jpg" alt="" width="100%" />
    </div>
    <div class="desc-page">
        <div class=" margin jhkfrm">
            <h2 class="h-tag padding txtcenter">Dealer Details</h2>
            <div class="col-sm-6 login-centered">

                <div class="pane-txt">
                    <h5 style="margin:0px"><b>Name:
                        <asp:Label ID="lblDealerName" runat="server"> </asp:Label></b></h5>
<h6 style="margin:0px;">Age: <asp:Label ID="lblAge" runat="server"> </asp:Label></h6>
                    <h6 style="margin:0px">Qualification:
                         <asp:Label ID="lblQualification" runat="server"> </asp:Label></h6>
                    <div class="row txtcenter margin-top-20">
                       
                       
                        <div class="col-sm-4 col-xs-6">
                            <div class="prod-item-details">Email</div>
                            <div class=" div-border">

                                <asp:Label ID="lblEMailId" runat="server"> </asp:Label>
                            </div>
                        </div>
                        <div class="col-sm-4 col-xs-6">
                            <div class="prod-item-details">Contact No</div>
                            <div class=" div-border">

                                <asp:Label ID="lblContactNo" runat="server"> </asp:Label>
                            </div>
                        </div>
                        <div class="col-sm-4 col-xs-6">
                            <div class="prod-item-details">City</div>
                            <div class=" div-border">

                                <asp:Label ID="lblCity" runat="server"> </asp:Label>
                            </div>
                        </div>
                    </div>
   
   <div class="row margin-top txtcenter">
       
       
   </div>
   <div class="row margin-top txtcenter">
       <div class="col-sm-4 col-xs-6">
           <div class="prod-item-details">Current Business</div>
           <div class=" div-border">

               <asp:Label ID="lblCurrentBusiness" runat="server"> </asp:Label>
           </div>
       </div>
       <div class="col-sm-4 col-xs-6">
           <div class="prod-item-details">Firm Name</div>
           <div class=" div-border">  
               <asp:Label ID="lblFirmName" runat="server"> </asp:Label>
           </div>
       </div>
       <div class="col-sm-4 col-xs-6">
           <div class="prod-item-details">Constitution</div>
           <div class=" div-border">
               <asp:Label ID="lblConsitution" runat="server"> </asp:Label>
           </div>
       </div>
   </div>
   
   
    
 
  
                    </div>
                </div>
            </div>
        </div>
  

</asp:Content>

