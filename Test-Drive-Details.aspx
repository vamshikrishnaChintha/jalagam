<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Test-Drive-Details.aspx.cs" Inherits="Test_Drive_Details" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>


<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="Server">
    <link rel="icon" href="" type="image/x-icon" />
    <link type="text/css" rel="stylesheet" href="font-awesome/css/font-awesome.min.css"
        hreflang="en-us" />
    <link rel="stylesheet" href="css/custom.css" type="text/css" />
    <link rel="stylesheet" href="css/forms.css" type="text/css" />
    <link href="css/style.css" rel='stylesheet' type='text/css' />
    <link href="font-awesome/css/all.css" rel='stylesheet' type='text/css' />
    <script type="text/javascript" src="js/jquery-1-11-1.js"></script>
    <script type="text/javascript" src="js/bootstrap.min.js"></script>

    <link rel="stylesheet" href="css/bootstrap.css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="Server">
    <div class="desc-page">
        <div class=" margin jhkfrm ">
            <h2 class="h-tag padding txtcenter">Test Drive</h2>
            <div class="col-sm-6 login-centered">

                <div class="pane-txt">

                    <h5><b>Name:<asp:Label ID="lblName" runat="server"> </asp:Label></b></h5>
                    <h6>
                        <asp:Label ID="lblAddress" runat="server"> </asp:Label></h6>
                    <div class="row txtcenter">
                        <div class="col-sm-4 col-xs-6">
                            <div class="prod-item-details">Contact</div>
                            <div class=" div-border">

                                <asp:Label ID="lblContactNo" runat="server"> </asp:Label>
                            </div>
                        </div>
                        <div class="col-sm-4 col-xs-6">
                            <div class="prod-item-details">Email</div>
                            <div class=" div-border">

                                <asp:Label ID="lblEmailId" runat="server"> </asp:Label>
                            </div>
                        </div>
                        <div class="col-sm-4 col-xs-6">
                            <div class="prod-item-details">Product Name</div>
                            <div class=" div-border">

                                <asp:Label ID="lblProductCode" runat="server"> </asp:Label>
                            </div>
                        </div>
                    </div>
                    <br />


                </div>
            </div>
        </div>
    </div>



</asp:Content>

