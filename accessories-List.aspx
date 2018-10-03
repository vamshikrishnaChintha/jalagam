<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="accessories-List.aspx.cs" Inherits="accessories_List" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
    <div>
        <img src="images/jslide-02-inner.jpg" alt="" width="100%" />
    </div>

    <div class="txtcenter padding-top padding-bottom ">
        <h3><b>Accessories</b></h3>
    </div>
    <div class="container margin-top-20">
        <div class="teamgrids row">
    <asp:Repeater runat="server" ID="gvacc">
        <HeaderTemplate></HeaderTemplate>
        <ItemTemplate>
            <div class="col-md-3  col-sm-12 teamgrid1 padding-bottom-20">
                <div class="div-border padding  box-shadow ">

                       
                        <div>
                            <a href='jalagam-accessories-<%#Eval("accessDetail").ToString() %>'>
                                <asp:Image ID="imgGallery" ALT='<%#Eval("Title") %>' runat="server" Height="150px" Width="100%" ImageUrl='<%# "Load-Image.aspx?DisplayPhotoAcc=" + Eval("AId")%>' />


                              

                                <%--<a href="accessories-Detail.aspx?Id=<%#Eval("AId")%>">
                                <asp:Image ID="imgGallery" ALT='<%#Eval("Title") %>' runat="server" Height="100px" Width="100%" ImageUrl='<%#"Uploads/AccessoriesGallery/Thumbnails/"+Eval("AId")+"/" + Eval("AId") + ".jpg"%>' />--%>
                            </a>

                        </div>
                        
                    <div class="margin-top">
                        <h6><b>
                       <%--  <asp:HyperLink ID="HyperLink1" Width="20%" Text='<%#Eval("Title") %>' ToolTip='<%# Eval("Title") %>' runat="server" Style="color: #db0f31!important" CssClass="txtflow" NavigateUrl='<%# String.Format("accessories-Detail.aspx?Id={0}", Eval("AId"))%>'></asp:HyperLink></b>--%>


                            <a href='jalagam-accessories-<%#Eval("accessDetail").ToString() %>'>
                                <asp:Label ID="lblaccess" runat="server" Width="20%" Text='<%#Eval("Title") %>' Style="color: #db0f31!important" CssClass="txtflow" /></a>

                            </b>
                        </h6>
                        </div>
                        
                        Product Code: <asp:Label ID="Label1" Text='<%#Eval("Pcode") %>' runat="server"></asp:Label>
                        <br />
                      <%--  Price: <asp:Label ID="lblCategory" Text='<%#Eval("Price") %>' runat="server"></asp:Label>--%>
                       
                    <div class="margin-top">
                        <a href='jalagam-accessories-<%#Eval("accessDetail").ToString() %>' class="more-btn" style="color: #fff!important;">Read more</a>
                    </div>
                    </div>



                </div>
           

        </ItemTemplate>
    </asp:Repeater>
            </div>
        </div>

</asp:Content>

