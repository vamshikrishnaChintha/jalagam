<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="accessories-Detail.aspx.cs" Inherits="accessories_Detail" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit.HTMLEditor" TagPrefix="cc1" %>

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
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="Server">
    <asp:Literal ID="litAId" runat="server" Visible="false" />

    <%-- <asp:DataList ID="dlGallery" runat="server" RepeatColumns="4" RepeatDirection="Horizontal"
        Width="100%">
        <ItemTemplate>
            <table border="1">
                <tr>
                    <td>
                        <a href='<%#Eval("GalleryImagePath") %>' class='group1' rel='group1' title='<%= GalleryName %>'>
                            <img src='<%#Eval("ThumbnailImagePath") %>' alt='' />
                        </a>
                    </td>
                </tr>
                <br />
            </table>
        </ItemTemplate>
    </asp:DataList>--%>
    <div>
        <img src="images/jslide-02-inner.jpg" alt="" width="100%" />
    </div>
    <div class="container margin-top-20">
        <div class="row">
            <div class="col-sm-6">
                <div class="div-border margin padding">
                    <asp:Image ID="imgAccImage" onerror="if (this.src != '../images/no-photo.png') this.src = '../images/no-photo.png';" Height="350" Width="100%" runat="server" CssClass="inner-banner" />
                </div>
                <div class=" container ">
                    <div class="teamgrids row">
                <asp:Repeater ID="rptImage" runat="server">
                    <ItemTemplate>
                        <div class="col-md-3  col-sm-6 teamgrid1 no-padding">

                            <div class="margin padding-bottom-20 ">
                                <div class="div-border box-shadow div-anchor">
                            <a id="htmla" href='<%#Eval("GalleryImagePath") %>' runat="server" class="example-image-link" data-lightbox="example-set">
                                <asp:Image ID="imgGvAdPhoto" runat="server" Width="100%" Height="80" class="example-image"
                                    ImageUrl='<%#Eval("ThumbnailImagePath") %>' onerror="if (this.src != 'images/no-photo.png') this.src = 'images/no-photo.png';" />
                            </a>
                            <%-- <asp:Label ID="lbl" runat="server" Text='<%# Eval("ImageId")%>' Visible="false"></asp:Label>
                                <a id="htmla" href='<%# "LoadPhoto.aspx?PhotoGalleryPhoto=" + Eval("ImageId")%>' runat="server" class="example-image-link" data-lightbox="example-set">
                                  
                                    <asp:Image ID="img" runat="server"
                                        ImageUrl='<%# "LoadPhoto.aspx?PhotoGalleryPhoto=" + Eval("ImageId")%>' class="example-image margin" Height="200" Width="100%" onerror="if (this.src != 'images/no-photo.png') this.src = 'images/no-photo.png';" />
                                </a>--%>
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
                <asp:Label ID="lbltitle" runat="server"> </asp:Label>
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
                      <div class="col-sm-4 col-xs-6">
                        <div class=" prod-item-details">Price</div>
                        <div class="div-border">
                <asp:Label ID="lblPrice" runat="server"> </asp:Label>
                            </div>
                          </div>
                    
                
            </div>
                <div class="row margin-top-20">
                    <div class="col-sm-12">
                    <div>
                        <h6><b>About Accessory</b></h6>
                    </div>
                    <div class="margin-top div-border padding">
                        <asp:Label ID="lblAboutProduct" runat="server"> </asp:Label>
                    </div>
                </div>
                    </div>
       </div>

                <div class="col-sm-12 margin-bottom-20">
                    <div>
                        <h5><b>Accessory Descriptioin</b></h5>
                    </div>
                    <div class="margin-top div-border padding">
                        <asp:Label ID="lblDescription" runat="server"> </asp:Label>
                    </div>
                </div>
                
            </div>
        </div>
    <script type="text/javascript" src="js/lightbox-plus-jquery.min.js"></script>
</asp:Content>

