<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Photo-Gallery-List.aspx.cs" Inherits="Photo_Gallery_List" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="Server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="Server">
    <div>
        <img src="images/jslide-01-inner.jpg" alt="" width="100%" />
    </div>
    
        <div class="txtcenter padding-top padding-bottom ">
            <h3><b>Photo Gallery</b></h3>
        </div>
    
    <div class="container margin-top-20">
        <div class="teamgrids row">

            
    <asp:Repeater runat="server" ID="gvPhotoGallery">
        <HeaderTemplate></HeaderTemplate>

        <ItemTemplate>

            <div class="col-md-4  col-sm-12 teamgrid1 padding-bottom-20">
                <div class="div-border padding txtcenter box-shadow">
                    <div >
                        <asp:Image ID="imgFunnyChamber" runat="server" onerror="if (this.src != 'images/no-photo.png') this.src = 'images/no-photo.png';" Height="200" Width="300" HtmlEncode="false" ImageUrl='<%# "Load-Image.aspx?GId=" + Eval("Id")%>' />
                    </div>

                    <div >


                        <asp:HyperLink runat="server"
                            NavigateUrl='<%# String.Format("Photo-Gallery-Detail.aspx?Id={0}", Eval("Id")) %>' Text='<%# Eval("Title", "{0}") %>'></asp:HyperLink>
                    </div>




                </div>
           </div>


        </ItemTemplate>

    </asp:Repeater>

    </div>
            </div>
       
</asp:Content>

