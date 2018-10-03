<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Photo-Gallery-Detail.aspx.cs" Inherits="Photo_Gallery_Detail" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
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
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
    <div>
        <img src="images/jslide-01-inner.jpg" alt="" width="100%" />
    </div>

    <div class="txtcenter padding-top padding-bottom ">
        <h3><b>Photo Gallery</b></h3>
    </div>
    <asp:Literal ID="litPhotoId" runat="server" Visible="false" />

  

    <div class="container margin-top">
        <h4>
            <asp:Label ID="lblCaption" runat="server"></asp:Label>
        </h4>
        <div class="teamgrids row">
    <asp:Repeater ID="rptImage" runat="server">
        <ItemTemplate>
            <div class="col-md-3  col-sm-12 teamgrid1">
                <div class="div-border margin txtcenter box-shadow">
            <div>
                <a id="htmla" href='<%# "Load-Image.aspx?PhotoGalleryPhoto=" + Eval("ImageId")%>' runat="server" class="example-image-link" data-lightbox="example-set">
                    <asp:Image ID="imgGvAdPhoto" runat="server" Width="100%" Height="150" class="example-image "
                        ImageUrl='<%# "Load-Image.aspx?PhotoGalleryPhoto=" + Eval("ImageId")%>' onerror="if (this.src != 'images/no-photo.png') this.src = 'images/no-photo.png';" />
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
    <script type="text/javascript" src="js/lightbox-plus-jquery.min.js"></script>
        
</asp:Content>

