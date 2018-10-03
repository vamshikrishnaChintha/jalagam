<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Branches-List.aspx.cs" Inherits="Branches_List" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="Server">
    <script src="js/slick.js" type="text/javascript" charset="utf-8"></script>
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
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="Server">
    <asp:UpdatePanel runat="server" ID="updatepanel">
        <ContentTemplate>
    <div>
        <img src="images/jslide-01-inner.jpg" alt="" width="100%" />
    </div>
    <div class="branches-bg">
        <div class="txtcenter padding-top padding-bottom ">
            <h3 style="color:#fff;"><b>Our Branches</b></h3>
        </div>

        <div class="  margin-top-20  ">
            <div class="teamgrids row">
                <div class="col-md-6 txtcenter  col-sm-6 teamgrid1">
                    <span><a href="Branches-List.aspx?S=TS">
                        <img src="images/state-ts-icon.png" /></a></span>
                </div>
                <div class="col-md-6 txtcenter col-sm-6 teamgrid1">
                    <span><a href="Branches-List.aspx?S=AP">
                        <img src="images/state-ap-icon.png"  /></a></span>
                    </div>
                
                </div>


            <div class="container" id="divAP" runat="server">
                <div class="row">


                    <div class="margin padding-bottom-20 ">
                        <div class="div-border box-shadow div-anchor">
                            <div class="txtcenter padding" style="background: #eee;">
                                <img src="images/scooter.png" />
                            </div>
                            <div class="background-white padding" style="height: 150px">
                                <h5>
                                    <b>
                                        <asp:HyperLink runat="server"
                                            NavigateUrl="http://sreevaniautomobiles.com" Target="_blank" Text="Sreevani Automobiles"></asp:HyperLink></b>

                                    <%--<a href="Branch-Details.aspx"><asp:Label ID="Label1" Text='<%#Eval("Name") %>' runat="server"></asp:Label></a>--%>
                                </h5>
                                <div class="txtflow">
                                    <h6>
                                        <asp:Label ID="lblCategory" Text="Kadapa, Andhra Pradesh." runat="server"></asp:Label>
                                    </h6>
                                </div>
                                <div class="txtflow">
                                    <asp:Label ID="Label2" Text="+91 709 354 3013" runat="server"></asp:Label>
                                </div>
                                <div class="txtflow">
                                    <asp:Label ID="Label3" Text="SreevaniAutomobiles@gmail.com" runat="server"></asp:Label>
                                </div>
                            </div>
                        </div>

                    </div>
                </div>
            </div>

        
        <div class="container" id="divTS" runat="server">
            <div class="row">


                <div class="responsive container slider">
                    <asp:Repeater runat="server" ID="gvBranches">
                        <HeaderTemplate></HeaderTemplate>
                        <ItemTemplate>
                            <div class="margin padding-bottom-20 ">
                                <div class="div-border box-shadow div-anchor">
                                    <div class="txtcenter padding" style="background: #eee;">
                                        <img src="images/scooter.png" />
                                    </div>
                                    <div class="background-white padding" style="height: 150px">
                                        <h5>
                                            <b>
                                                <asp:HyperLink runat="server"
                                                    NavigateUrl='<%# String.Format("Branch-Details.aspx?Id={0}", Eval("Id")) %>' Text='<%# Eval("Name", "{0}") %>'></asp:HyperLink></b>

                                            <%--<a href="Branch-Details.aspx"><asp:Label ID="Label1" Text='<%#Eval("Name") %>' runat="server"></asp:Label></a>--%>
                                        </h5>
                                        <div class="txtflow">
                                            <h6>
                                                <asp:Label ID="lblCategory" Text='<%#Eval("Address") %>' runat="server"></asp:Label>
                                            </h6>
                                        </div>
                                        <div class="txtflow">
                                            <asp:Label ID="Label2" Text='<%#Eval("ContactNo") %>' runat="server"></asp:Label>
                                        </div>
                                        <div class="txtflow">
                                            <asp:Label ID="Label3" Text='<%#Eval("EmailId") %>' runat="server"></asp:Label>
                                        </div>
                                    </div>
                                </div>

                            </div>


                        </ItemTemplate>
                    </asp:Repeater>
                </div>
            </div>
        </div>
    </div>
        </div>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>

