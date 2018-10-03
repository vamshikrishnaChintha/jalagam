<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Branch-Details.aspx.cs" Inherits="Branch_Details" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
    <div>
        <img src="images/jslide-01-inner.jpg" alt="" width="100%" />
    </div>
    <div>
        <div class="txtcenter padding-top padding-bottom ">
            <h3><b>Our Branches</b></h3>
        </div>
        <div class="container">
            <div class="row margin-bottom-20 margin-top padding-bottom-20">
                <div class="col-sm-5 div-border padding">
                    <img src="images/banner-01-new.jpg" width="100%" />
                </div>
                <div class="col-sm-7">
                    <div>
                        <h3><b>
    <asp:Label ID="lblBranchName" runat="server"> </asp:Label>
                            </b>
                            </h3>
                        </div>
                    <div>
    <asp:Label ID="lblAddress" runat="server"> </asp:Label>
                        </div>
                    <div>
                        <i class="fas fa-phone-volume icon-grey"></i>
                        &nbsp;<asp:Label ID="lblContactNumbers" runat="server"> </asp:Label>
                        </div>
                    <div class="margin-top">
                        <i class="far fa-envelope icon-grey "></i> &nbsp;
                        <asp:Label ID="lblEmailId" runat="server"> </asp:Label>
                        </div>
                </div>
            </div>
        </div>
        </div>
</asp:Content>

