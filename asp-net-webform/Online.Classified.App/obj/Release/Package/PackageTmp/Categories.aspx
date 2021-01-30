<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Categories.aspx.cs" Inherits="Online.Classified.App.Classified" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <section>
        <div class="container">
            <div class="row">
                <h2 class="title text-center">Categories</h2>

                <asp:ListView ID="lvCategories" EnableTheming="False" runat="server"
                    DataKeyField="Id">
                    <ItemTemplate>

                        <div class="col-sm-3">
                    <div class="product-image-wrapper" style="border: 1px solid #F0F0E9;">
                        <div class="single-products">
                            <div class="productinfo text-center">
                                 <img src=" <%# DataBinder.Eval(Container.DataItem, "CategoryImage") %>" alt="" />
                                <a href="/Classified?Id=<%# DataBinder.Eval(Container.DataItem, "Id") %>&name=<%# DataBinder.Eval(Container.DataItem, "Name") %>">
                                    <h2> <%# DataBinder.Eval(Container.DataItem, "Name") %></h2>

                                   
                                </a>
                            </div>

                        </div>

                    </div>
                </div>



                        
                    </ItemTemplate>
                </asp:ListView>












            </div>
        </div>


    </section>




</asp:Content>
