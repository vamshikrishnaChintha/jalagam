<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Product-Detail.aspx.cs" Inherits="Product_Detail" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="Server">
    <script src="js/jquery-1.8.js" type="text/javascript"> </script>
    <script src="js/jquery.colorbox.js" type="text/javascript"></script>
    <link rel="stylesheet" href="css/colorbox.css" />
    <link rel="stylesheet" href="css/lightbox.min.css" />
    <script type="text/javascript">
        $(document).ready(function () {
            //Examples of how to assign the ColorBox event to elements
            $(".group1").colorbox({ rel: 'group1', transition: "fade", slideshow: "true" });
        });
    </script>
<%--    <script src="js/slick.js" type="text/javascript" charset="utf-8"></script>
    <link href="css/slick.css" rel="stylesheet" />
    <link href="css/slick-theme.css" rel="stylesheet" />
    <script type="text/javascript" src="js/jQuery-2.2.0.js"></script>
    <script src="js/slick.js" type="text/javascript" charset="utf-8"></script>
    <script type="text/javascript">
        $(document).on('ready', function () {
            $('.responsive').slick({
                dots: false,
                infinite: false,
                speed: 300,
                slidesToShow: 3,
                slidesToScroll: 1,
                infinite: true,
                responsive: [
                  {
                      breakpoint: 1024,
                      settings: {
                          slidesToShow: 3,
                          slidesToScroll: 3,
                          infinite: true,
                          dots: true
                      }
                  },
                  {
                      breakpoint: 600,
                      settings: {
                          slidesToShow: 2,
                          slidesToScroll: 2
                      }
                  },
                  {
                      breakpoint: 480,
                      settings: {
                          slidesToShow: 1,
                          slidesToScroll: 1
                      }
                  }
                  // You can unslick at a given breakpoint now by adding:
                  // settings: "unslick"
                  // instead of a settings object
                ]
            });

        });
    </script>--%>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="Server">
    <div>
        <img src="images/jslide-01-inner.jpg" alt="" width="100%" />
    </div>
    <div class="container margin-top-20">
        <div class="row">
            <asp:Literal ID="litPId" Visible="false" runat="server"></asp:Literal>
            <div class="col-sm-6">
                <div class="div-border margin padding">
                    <asp:Image ID="imgProductImage" onerror="if (this.src != '../images/no-photo.png') this.src = '../images/no-photo.png';" Height="350" Width="100%" runat="server" CssClass="inner-banner" />
                </div>
                <div class=" container ">
                    <div class="teamgrids row">
                       
                    <asp:Repeater ID="dlGallery" runat="server">
                        <ItemTemplate>
                            <div class="col-md-3  col-sm-6 teamgrid1 no-padding">
                            
                            <div class="margin padding-bottom-20 ">
                                <div class="div-border box-shadow div-anchor">
                                    <a id="htmla" href='<%#Eval("GalleryImagePath") %>' runat="server" class="example-image-link" data-lightbox="example-set">
                                        <asp:Image ID="imgGvAdPhoto" runat="server" Width="100%" Height="80" class="example-image "
                                            ImageUrl='<%#Eval("ThumbnailImagePath") %>' onerror="if (this.src != 'images/no-photo.png') this.src = 'images/no-photo.png';" />
                                    </a>

                                </div>
                            </div>
                    </div>               
                        </ItemTemplate>
                    </asp:Repeater>
                </div>
                    
                </div>
            </div>
            <div class="col-sm-6">
                <div>
                    <h2><b>
                        <asp:Label ID="lblProductName" runat="server"> </asp:Label>
                    </b>
                    </h2>
                </div>

                <div class="row txtcenter margin-top">


                    <div class="col-sm-4 col-xs-6">
                        <div class="prod-item-details">Code</div>
                        <div class=" div-border">

                            <asp:Label ID="lblProductCode" runat="server"> </asp:Label>
                        </div>
                    </div>
                    <%--<div class="col-sm-4 col-xs-6">
                        <div class=" prod-item-details">Price</div>
                        <div class="div-border">
                            <asp:Label ID="lblPrice" runat="server"> </asp:Label>
                        </div>
                    </div>--%>
                    <div class="col-sm-4 col-xs-6">
                        <div class=" prod-item-details">Color</div>
                        <div class="div-border">
                            <asp:Label ID="lblColor" runat="server"> </asp:Label>
                        </div>
                    </div>
                    <div class="col-sm-12 col-xs-6 margin-top">
                        <div style="text-align: left" class="prod-detail-icon">
                            <b><i class="fas fa-car-battery"></i>&nbsp;Battery Type</b>:
            <asp:Label ID="lblBatteryType" runat="server"> </asp:Label>
                        </div>

                    </div>

                </div>
                <div class="margin-top-20 ">
                    <span>Tags <i class="fas fa-tag"></i></span>
                    <div class="prod-tags">
                        <asp:Label ID="lblTags" runat="server"> </asp:Label>
                    </div>
                </div>


            </div>
            <div class="col-sm-12 margin-bottom-20">
                <div>
                    <h5><b>Product Descriptioin</b></h5>
                </div>
                <div class="margin-top div-border padding">
                    <asp:Label ID="lblDescription" runat="server"> </asp:Label>
                </div>
    </div>

    </div>
        </div>
    <script type="text/javascript" src="js/lightbox-plus-jquery.min.js"></script>
</asp:Content>

