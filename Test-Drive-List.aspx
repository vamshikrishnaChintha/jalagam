<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Test-Drive-List.aspx.cs" Inherits="Test__Drive_List" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">


    <div class="head-color">
        <h5><b>Test Drives List</b></h5>
    </div>


   

    <asp:Repeater runat="server" ID="gvTestDrive">
        <HeaderTemplate></HeaderTemplate>
        <ItemTemplate>
            <div class="col-sm-3 col-xs-12 padding-bottom-20 ">
                <div class="div-border box-shadow div-anchor">
                    
                    <div class="background-white padding" style="height: 150px">
                        <h5>


                            <b>
                             

                            <asp:HyperLink runat="server"
                                NavigateUrl='<%# String.Format("Test-Drive-Details.aspx?Id={0}", Eval("Id")) %>' Text='<%# Eval("Title", "{0}") %>'></asp:HyperLink>
                            </b>
                          
                        </h5>

                        </br>
                        <asp:Label ID="Label3" Text='<%#Eval("ContactNo") %>' runat="server"></asp:Label>
                        </br>
                        <asp:Label ID="Label1" Text='<%#Eval("Address") %>' runat="server"></asp:Label>
                        
                    </div>
                </div>



            </div>


        </ItemTemplate>
    </asp:Repeater>

</asp:Content>

