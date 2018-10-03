<%@ Page Title="jalagam electric-vehicles" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="home" MetaKeywords="" MetaDescription="" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="Server">

    <link href="css/slick.css" rel="stylesheet" />
    <link href="css/slick-theme.css" rel="stylesheet" />
    <script type="text/javascript" src="js/jQuery-2.2.0.js"></script>
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/owl-carousel/1.3.3/owl.carousel.min.css">
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/owl-carousel/1.3.3/owl.theme.min.css">
    <script type="text/javascript" src="https://code.jquery.com/jquery-1.12.0.min.js"></script>
    <script type="text/javascript" src="https://cdnjs.cloudflare.com/ajax/libs/owl-carousel/1.3.3/owl.carousel.min.js"></script>
    <script src="js/slick.js" type="text/javascript" charset="utf-8"></script>
    <script type="text/javascript">
        $(document).on('ready', function () {
            $('.responsive').slick({
                dots: false,
                infinite: false,
                speed: 300,
                slidesToShow: 4,
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
    </script>
    <script>
        $(document).ready(function () {
            $("#testimonial-slider").owlCarousel({
                items: 3,
                itemsDesktop: [1000, 2],
                itemsDesktopSmall: [979, 2],
                itemsTablet: [768, 1],
                pagination: false,
                navigation: true,
                navigationText: ["", ""],
                autoPlay: true
            });
        });
    </script>
    <style>
        .testimonial {
            margin: 0 20px 20px;
        }

            .testimonial .pic {
                display: inline-block;
                width: 90px;
                height: 90px;
                border-radius: 50%;
                margin: 0 15px 15px 0;
            }

                .testimonial .pic img {
                    width: 100%;
                    height: auto;
                    border-radius: 50%;
                }

            .testimonial .testimonial-profile {
                display: inline-block;
                position: relative;
                top: 15px;
            }

            .testimonial .title {
                display: block;
                font-size: 20px;
                font-weight: 600;
                color: #2f2f2f;
                text-transform: capitalize;
                margin: 0 0 7px 0;
            }

            .testimonial .post {
                display: block;
                font-size: 14px;
                color: #5d7aa7;
            }

            .testimonial .description {
                padding: 20px 22px;
                background: #303086;
                font-size: 15px;
                color: #fff;
                line-height: 25px;
                margin: 0;
                position: relative;
            }

                .testimonial .description:before,
                .testimonial .description:after {
                    content: "";
                    border-width: 18px 0 0 18px;
                    border-style: solid;
                    border-color: #000 transparent transparent;
                    position: absolute;
                    bottom: -18px;
                    left: 0;
                }

                .testimonial .description:after {
                    border-width: 18px 18px 0 0;
                    left: auto;
                    right: 0;
                }

        .owl-theme .owl-controls {
            margin-top: 10px;
            margin-left: 30px;
        }

            .owl-theme .owl-controls .owl-buttons div {
                opacity: 0.8;
                background: #fff;
            }

        .owl-prev:before,
        .owl-next:before {
            content: "\f053";
            font-family: "Font Awesome 5 Free";
            font-weight: 900;
            font-size: 20px;
            color: #1f487e;
        }

        .owl-next:before {
            content: "\f054";
        }

        .slick-slide {
            margin: 5px 0px;
        }

            .slick-slide img {
                width: 100%;
            }

        .slick-prev:before,
        .slick-next:before {
            color: black;
        }


        .slick-slide {
            transition: all ease-in-out .3s;
            opacity: 1;
        }

        .slick-active {
            opacity: 1;
        }

        .slick-current {
            opacity: 1;
        }
    </style>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="Server">
    <div class="banner-top">
        <div class="banner">
            <div id="carouselExampleIndicators" class="carousel slide" data-ride="carousel">
                <ol class="carousel-indicators">
                    <li data-target="#carouselExampleIndicators" data-slide-to="0" class="active"></li>
                    <li data-target="#carouselExampleIndicators" data-slide-to="1"></li>
                    <li data-target="#carouselExampleIndicators" data-slide-to="2"></li>
                    <li data-target="#carouselExampleIndicators" data-slide-to="3"></li>
                </ol>
                <div class="carousel-inner" role="listbox">



                    <div class="carousel-item  active">
                        <img src="images/jslide-8.jpg" width="100%" />
                    </div>
                    <div class="carousel-item ">
                        <img src="images/jslide-9.jpg" width="100%" />
                    </div>
                    <div class="carousel-item  ">
                        <img src="images/jslide-5.jpg" width="100%" />
                    </div>
                    <div class="carousel-item ">
                        <img src="images/jslide-7.jpg" width="100%" />
                    </div>
                    <div class="carousel-item  ">
                        <img src="images/jslide-4.jpg" width="100%" />
                    </div>



                </div>
                <a class="carousel-control-prev" href="#carouselExampleIndicators" role="button" data-slide="prev">
                    <span class="carousel-control-prev-icon" aria-hidden="true"></span>
                    <span class="sr-only">Previous</span>
                </a>
                <a class="carousel-control-next" href="#carouselExampleIndicators" role="button" data-slide="next">
                    <span class="carousel-control-next-icon" aria-hidden="true"></span>
                    <span class="sr-only">Next</span>
                </a>
            </div>

            <div class="banner-bottom">
                
                <div class="container">
                    <div class="row">

                        <div class="col-lg-3 agileits_banner_bottom_left">
                            <div class="agileinfo_banner_bottom_pos">
                                <div class="w3_agileits_banner_bottom_pos_grid">
                                    <%-- <div class="col-xs-3 wthree_banner_bottom_grid_left txtcenter">
                                        <div class="icon-center">
                                            <span class="fas fa-file-invoice" aria-hidden="true"></span>
                                        </div>
                                    </div>--%>
                                    <div class="view view-sixth">
                                        <div class="col-xs-9  margin-top no-registration-bg padding-top">


                                            <div class="mask">
                                                <div class="icon-center">
                                                    <span class="fas fa-file-invoice" aria-hidden="true"></span>
                                                </div>
                                                <h2>NO REGISTRATION</h2>
                                                <div>for low speed electrical vehicles.</div>


                                            </div>
                                            <div class="txtcenter">
                                                <h4>NO REGISTRATION</h4>

                                                <div>for low speed electrical vehicles.</div>
                                            </div>
                                        </div>
                                    </div>
                                    <div class="clearfix"></div>
                                </div>
                            </div>
                        </div>
                        <div class="col-lg-3 agileits_banner_bottom_left">
                            <div class="agileinfo_banner_bottom_pos">
                                <div class="w3_agileits_banner_bottom_pos_grid">
                                    <%--  <div class="col-xs-3 wthree_banner_bottom_grid_left txtcenter">
                                        <div class="icon-center">
                                            <span class="far fa-address-card" aria-hidden="true"></span>
                                        </div>
                                    </div>--%>
                                    <div class="view view-sixth">
                                        <div class="col-xs-9  margin-top no-license-bg padding-top">
                                            <div class="mask">
                                                <div class="icon-center">
                                                    <span class="far fa-address-card" aria-hidden="true"></span>
                                                </div>
                                                <h2>NO LICENSE</h2>
                                                <div>For low speed electrical vehicles.</div>


                                            </div>
                                            <div class="txtcenter">
                                                <h4>NO LICENSE</h4>

                                                <div>For low speed electrical vehicles.</div>
                                            </div>
                                        </div>
                                    </div>
                                    <div class="clearfix"></div>

                                </div>
                            </div>
                        </div>
                        <div class="col-lg-3 agileits_banner_bottom_left">
                            <div class="agileinfo_banner_bottom_pos">
                                <div class="w3_agileits_banner_bottom_pos_grid">
                                    <%-- <div class="col-xs-3 wthree_banner_bottom_grid_left txtcenter">
                                        <div class="icon-center">
                                            
                                            <span class="fas fa-rupee-sign" aria-hidden="true"></span>
                                        </div>
                                    </div>--%>
                                    <div class="view view-sixth">
                                        <div class="col-xs-9  margin-top no-road-tax-bg padding-top">
                                            <div class="mask">
                                                <div class="icon-center">
                                                    <span class="fas fa-rupee-sign" aria-hidden="true"></span>
                                                </div>
                                                <h2>NO ROAD TAX</h2>
                                                <div>For all electrical vehicles.</div>


                                            </div>
                                            <div class="txtcenter">
                                                <h4>NO ROAD TAX</h4>

                                                <div>For all electrical vehicles.</div>
                                            </div>
                                        </div>
                                    </div>
                                    <div class="clearfix"></div>
                                </div>
                            </div>
                        </div>
                        <div class="col-lg-3 agileits_banner_bottom_left">
                            <div class="agileinfo_banner_bottom_pos">
                                <div class="w3_agileits_banner_bottom_pos_grid">
                                    <%--<div class="col-xs-3 wthree_banner_bottom_grid_left txtcenter">
                                        <div class="icon-center">
                                            <span class="fas fa-leaf" aria-hidden="true"></span>
                                        </div>
                                    </div>--%>
                                    <div class="view view-sixth">
                                        <div class="col-xs-9  margin-top no-pollution-bg padding-top">
                                            <div class="mask">
                                                <div class="icon-center">
                                                    <span class="fas fa-leaf" aria-hidden="true"></span>
                                                </div>
                                                <h2>NO POLLUTION</h2>
                                                <div>Eco -Friendly electrical vehicles.</div>


                                            </div>
                                            <div class="txtcenter">
                                                <h4>NO POLLUTION</h4>

                                                <div>Eco -Friendly electrical vehicles.</div>
                                            </div>
                                        </div>
                                    </div>
                                    <div class="clearfix"></div>
                                </div>
                            </div>
                        </div>
                        <div class="clearfix"></div>
                    </div>
                </div>
            </div>


        </div>
    </div>
    <div style="clear: both"></div>
    <div class="testimonials aboutus-bg " id="services">
        <div class="container  py-md-3">
            <div class="teamgrids row margin-top-20 margin-bottom-20 txtcenter">

                <div class="col-md-4   col-xs-12 teamgrid1">
                    <img src="images/no-petrol.jpg" width="200" height="200" class="img-circle" /><br />
                    <h5>NO PETROL</h5>
                    Petrol is not required for electric vehicles.
                    
                </div>
                <div class="col-md-4   col-xs-12 teamgrid1">
                    <img src="images/no-engine-oil.jpg" width="200" height="200" class="img-circle" /><br />
                    <h5>NO ENGINE OIL</h5>

                    Engine Oil is not required for electric vehicles.
                   
                </div>
                <div class="col-md-4   col-xs-12 teamgrid1">
                    <img src="images/low-maintenance.jpg" width="200" height="200" class="img-circle" /><br />
                    <h5>LOW MAINTENANCE</h5>
                    Electric Vehicles have Very Low Maintenance
                   
                </div>
            </div>
            <div class="txtcenter">
                <h2><b>About Us</b></h2>
            </div>
            <div class="w3_testimonials_grids margin-top-20">


                <div class="about-top w3ls-agile row">

                    <div class="col-md-6 come">
                        <div class="about-wel">
                            <h5>Leaders in Electric Vehicles
                            </h5>
                            <div class="margin-top margin-bottom">
                                <h6>WELCOME TO OUR NEW WEBSITE. WE ARE HAPPY TO BE PART OF A LEADING TEAM THAT WILL CREATE, DESIGN, INNOVATE AND EXECUTE CHANGE IN THE AREA OF AFFORDABLE MOBILITY SOLUTIONS. </h6>
                            </div>
                            <div>
                                Ampere Was Incorporated Consciously To Bring About Awareness Of High Dependancy Of Our Country In Fossil Fuels And Propagate Alternate Transport Solutions Using Disruptive Business Models. Ampere’s Team Will Innovate In Every Aspect To Be A Self Reliant Manufacturer To Design Key Components Of An Electric Vehicle.
                                <br />
                                <br />
                                Our Passion Is To Include Best Practises And Evolve Continuously To Meet The Changing Needs Of Our Customers Through The Launch Of Our Intelligent Smart Batteries, Contributing To Environmental Sustainability.
                            </div>

                        </div>
                        <div class="button-styles">
                            <a href="Aboutus.aspx">More Info</a>
                            <%--  <a href="#contact" class="button2-w3l scroll">Contact Us</a>--%>
                        </div>
                    </div>
                    <div class="col-md-6 ser_w3">
                        <img class="img-responsive img-fluid" src="images/banner-01-new.jpg" alt="">
                    </div>
                </div>



            </div>
        </div>
    </div>
    <div class="margin-top">
        <div class="txtcenter margin-bottom ">
            <h3><b>Product Categories</b></h3>
        </div>

        <div class="responsive container slider">

            <asp:Repeater runat="server" ID="gvProducts">
                <HeaderTemplate></HeaderTemplate>
                <ItemTemplate>

                    <div class="col-sm-3 col-xs-12 margin-bottom">
                        <div class="div-border div-slide-hover">
                            <div class="main-slide-div">

                                <div class="view view-tenth">

                                    <%--<asp:Image ID="imgMovieShow" runat="server" onerror="if (this.src != 'images/no-photo.png') this.src = 'images/no-photo.png';" HtmlEncode="false" ImageUrl='<%# "LoadPhoto.aspx?DisplayPhoto=" + Eval("Id")%>' />--%>


                                    <a href='product-<%#Eval("ProductDetail").ToString() %>'>
                                        <asp:Image ID="imgGallery" ALT='<%#Eval("ProductName") %>' runat="server" Width="100%" Height="175" ImageUrl='<%# "Load-Image.aspx?DisplayPhoto=" + Eval("Id")%>' />
                                    </a>


                                    <div class="mask">

                                        <h2>


                                            <a href='product-<%#Eval("ProductDetail").ToString() %>'>
                                                <asp:Label ID="lblaccess" runat="server" Width="20%" Text='<%#Eval("ProductName") %>' CssClass="txtflow" /></a>

                                          <%--  <a href="Product-Detail.aspx?Id=<%#Eval("Id")%>">
                                                <asp:Label ID="lblProduct" runat="server" Width="20%" Text='<%#Eval("ProductName") %>' CssClass="txtflow" /></a>--%>


                                           <%-- <asp:HyperLink ID="HyperLink2" Text='<%#Eval("ProductName") %>' ToolTip='<%# Eval("ProductName") %>' runat="server" CssClass="txtflow div-slide-mask" NavigateUrl='<%# String.Format("Product-Detail.aspx?Id={0}", Eval("Id"))%>'></asp:HyperLink>--%>

                                        </h2>

                                    </div>
                                </div>



                            </div>


                            <div class=" padding product-footer-bg">
                                <div class="product-title">


                                    <a href='product-<%#Eval("ProductDetail").ToString() %>'>
                                        <asp:Label ID="Label2" runat="server" Width="20%" Text='<%#Eval("ProductName") %>' CssClass="txtflow" /></a>


                                  <%--  <a href="Product-Detail.aspx?Id=<%#Eval("Id")%>">
                                        <asp:Label ID="Label1" runat="server" Width="20%" Text='<%#Eval("ProductName") %>' CssClass="txtflow" /></a>--%>


                                   <%-- <asp:HyperLink ID="HyperLink1" Text='<%#Eval("ProductName") %>' ToolTip='<%# Eval("ProductName") %>' runat="server" CssClass="txtflow" NavigateUrl='<%# String.Format("Product-Detail.aspx?Id={0}", Eval("Id"))%>'></asp:HyperLink>--%>
                                </div>
                                <%-- <div class="product-price">
                        <asp:Label ID="Label2" Text='<%#Eval("Price") %>' runat="server"></asp:Label>
                       </div>--%>
                                <div class="product-color">
                                    <asp:Label ID="Label3" Text='<%#Eval("Color") %>' runat="server"></asp:Label>
                                </div>
                            </div>
                        </div>
                    </div>

                </ItemTemplate>
            </asp:Repeater>
        </div>
    </div>
    <%--<div class="margin-top-20 ">
        <div class="txtcenter margin-bottom ">
            <h3>Product Categories</h3>
        </div>
        <div class="responsive container slider">



            <div class="col-sm-3 col-xs-12 margin-bottom">
                <div class="div-border">
                    <img src="images/category-img-01.jpg">
                    <div class="txtcenter product-footer-bg">
                        <b>AMPERE – V48</b><br />
                        <span>32 products</span>
                    </div>
                </div>

            </div>
            <div class="col-sm-3 col-xs-12 margin-bottom">
                <div class="div-border">
                    <img src="images/category-img-02.jpg">
                    <div class="txtcenter product-footer-bg">
                        <b>AMPERE – V60</b><br />
                        <span>32 products</span>
                    </div>
                </div>
            </div>
            <div class="col-sm-3 col-xs-12 margin-bottom">
                <div class="div-border">
                    <img src="images/category-img-03.jpg">
                    <div class="txtcenter product-footer-bg">
                        <b>AMPERE – ANGEL</b><br />
                        <span>32 products</span>
                    </div>
                </div>
            </div>
            <div class="col-sm-3 col-xs-12 margin-bottom">
                <div class="div-border">
                    <img src="images/category-img-01.jpg">
                    <div class="txtcenter product-footer-bg">
                        <b>AMPERE – V48</b><br />
                        <span>32 products</span>
                    </div>
                </div>

            </div>
            <div class="col-sm-3 col-xs-12 margin-bottom">
                <div class="div-border">
                    <img src="images/category-img-02.jpg">
                    <div class="txtcenter product-footer-bg">
                        <b>AMPERE – V60</b><br />
                        <span>32 products</span>
                    </div>
                </div>
            </div>
            <div class="col-sm-3 col-xs-12 margin-bottom">
                <div class="div-border">
                    <img src="images/category-img-03.jpg">
                    <div class="txtcenter product-footer-bg">
                        <b>AMPERE – ANGEL</b><br />
                        <span>32 products</span>
                    </div>
                </div>
            </div>
        </div>
    </div>--%>
    <div class="margin-top-20 ">
        <div class="txtcenter margin-bottom ">
            <h3><b>Customer Comments</b></h3>
        </div>
        <div class="container margin-top-20">
            <div class="row">
                <div class="col-md-12">
                    <div id="testimonial-slider" class="owl-carousel">
                        <div class="testimonial">
                            <div class="pic">
                                <img src="images/organizer-login-bg.png">
                            </div>
                            <div class="testimonial-profile">
                                <h3 class="title">Name</h3>
                                <span class="post">Designation</span>
                            </div>
                            <p class="description">
                                I am using battery operated vehicle V48 for the past 8 months. I feel very easy to drive it and there is no pollution, sound and economical problem. Their service and customer support are excellent. 
- M.R. Subash Rao - Hyderabad
                            </p>
                        </div>
                        <div class="testimonial">
                            <div class="pic">
                                <img src="images/organizer-login-bg.png">
                            </div>
                            <div class="testimonial-profile">
                                <h3 class="title">Name</h3>
                                <span class="post">Designation</span>
                            </div>
                            <p class="description">
                                Two years before I came to know about V60 Vehicle. It looks sturdy and gives me good mileage and cost-saving. It’s very useful vehicle for people who needs cheap and best transportation.
- Dhandapani P A
                            </p>
                        </div>
                        <div class="testimonial">
                            <div class="pic">
                                <img src="images/organizer-login-bg.png">
                            </div>
                            <div class="testimonial-profile">
                                <h3 class="title">Name</h3>
                                <span class="post">Designation</span>
                            </div>
                            <p class="description">
                                Angel cycle is absolutely superb design which is extremely good to ride over long distance without any tiredness. I am using this cycle for past 3 years. Still now I never faced problems like service and support. 
- Arunchalam coimbatore.
                            </p>
                        </div>
                        <div class="testimonial">
                            <div class="pic">
                                <img src="images/organizer-login-bg.png">
                            </div>
                            <div class="testimonial-profile">
                                <h3 class="title">Name</h3>
                                <span class="post">Designation</span>
                            </div>
                            <p class="description">
                                I am using battery operated vehicle V48 for the past 8 months. I feel very easy to drive it and there is no pollution, sound and economical problem. Their service and customer support are excellent.
- M.R. Subash Rao - Hyderabad
                            </p>
                        </div>
                        <div class="testimonial">
                            <div class="pic">
                                <img src="images/organizer-login-bg.png">
                            </div>
                            <div class="testimonial-profile">
                                <h3 class="title">Name</h3>
                                <span class="post">Designation</span>
                            </div>
                            <p class="description">
                                Two years before I came to know about V60 Vehicle. It looks sturdy and gives me good mileage and cost-saving. It’s very useful vehicle for people who needs cheap and best transportation.
- Dhandapani P A
                            </p>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>

