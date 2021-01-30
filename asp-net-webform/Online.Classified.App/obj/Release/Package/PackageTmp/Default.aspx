<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Online.Classified.App._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <section id="slider">
        <!--slider-->
        <div class="container">
            <div class="row">
                <div class="col-sm-12">
                    <div id="slider-carousel" class="carousel slide" data-ride="carousel">
                        <ol class="carousel-indicators">
                            <li data-target="#slider-carousel" data-slide-to="0" class="active"></li>
                            <li data-target="#slider-carousel" data-slide-to="1"></li>
                            <li data-target="#slider-carousel" data-slide-to="2"></li>
                        </ol>

                        <div class="carousel-inner">
                            <div class="item active">
                                <div class="col-sm-6">
                                    <h1><span>ARADA</span>-LEJ</h1>
                                    <h2>Take #፩ classifieds site with you</h2>
                                    <p>
                                        See more relevant listings, find what you’re looking for quicker, and more! Buy and sell new or used items whenever you go!
                                    </p>
                                    <a href="/User/Login" class="btn btn-default get">Sign Up</a>
                                </div>
                                <div class="col-sm-6">
                                    <img src="/Content/images/home/girl1.jpg" class="girl img-responsive" alt="" />

                                </div>
                            </div>
                            <div class="item">
                                <div class="col-sm-6">
                                    <h1><span>ARADA</span>-LEJ</h1>
                                    <h2>It's better when you’re a member
                                    </h2>
                                    <p>
                                        See more relevant listings, find what you’re looking for quicker, and more! Buy and sell new or used items whenever you go!
                                    </p>
                                    <a href="/User/Login" class="btn btn-default get">Sign Up</a>
                                </div>
                                <div class="col-sm-6">
                                    <img src="/Content/images/home/girl2.jpg" class="girl img-responsive" alt="" />

                                </div>
                            </div>

                            <div class="item">
                                <div class="col-sm-6">
                                    <h1><span>ARADA</span>-LEJ</h1>
                                    <h2>Take #፩ classifieds site with you</h2>
                                    <p>
                                        See more relevant listings, find what you’re looking for quicker, and more! Buy and sell new or used items whenever you go!
                                    </p>
                                    <a href="/User/Login" class="btn btn-default get">Sign Up</a>
                                </div>
                                <div class="col-sm-6">
                                    <img src="/Content/images/home/girl3.jpg" class="girl img-responsive" alt="" />

                                </div>
                            </div>

                        </div>

                        <a href="#slider-carousel" class="left control-carousel hidden-xs" data-slide="prev">
                            <i class="fa fa-angle-left"></i>
                        </a>
                        <a href="#slider-carousel" class="right control-carousel hidden-xs" data-slide="next">
                            <i class="fa fa-angle-right"></i>
                        </a>
                    </div>

                </div>
            </div>
        </div>
    </section>
    <section>
        <div class="container">
            <div class="row">
                <div class="col-sm-12 padding-right">
                    <div class="features_items">
                        <!--features_items-->
                        <h2 class="title text-center">Recent Houses</h2>
                        <asp:ListView ID="lvRecentHome" EnableTheming="False" runat="server"
                            DataKeyField="Id">
                            <ItemTemplate>

                                <div class="col-sm-3">
                                    <div class="product-image-wrapper">
                                        <div class="single-products">
                                            <div class="productinfo text-center">
                                                <img src=" <%# DataBinder.Eval(Container.DataItem, "PictureUrl") %>" alt="" />
                                                <h2><%# DataBinder.Eval(Container.DataItem, "Price") %></h2>
                                                <p><%# DataBinder.Eval(Container.DataItem, "Title") %></p>
                                                <a href="Detail?Id=<%# DataBinder.Eval(Container.DataItem, "Id") %>" class="btn btn-default add-to-cart">View Detail</a>


                                            </div>

                                        </div>

                                    </div>
                                </div>






                            </ItemTemplate>
                        </asp:ListView>

                    </div>
                    <!--features_items-->
                    <div class="recommended_items">
                        <!--recommended_items-->
                        <h2 class="title text-center">recommended items</h2>

                        <div id="recommended-item-carousel" class="carousel slide" data-ride="carousel">
                            <div class="carousel-inner">


                                <asp:ListView ID="lvRecommended" EnableTheming="False" runat="server"
                                    DataKeyField="Id">
                                    <ItemTemplate>
                                        <div class="item active">
                                            <div class="col-sm-4">
                                                <div class="product-image-wrapper">
                                                    <div class="single-products">
                                                        <div class="productinfo text-center">
                                                            <img src=" <%# DataBinder.Eval(Container.DataItem, "PictureUrl") %>" alt="" />
                                                            <h2><%# DataBinder.Eval(Container.DataItem, "Price") %></h2>
                                                            <p><%# DataBinder.Eval(Container.DataItem, "Title") %></p>
                                                            <a href="Detail?Id= <%# DataBinder.Eval(Container.DataItem, "Id") %>" class="btn btn-default add-to-cart">View Detail</a>
                                                        </div>

                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                    </ItemTemplate>
                                </asp:ListView>





                            </div>
                            <a class="left recommended-item-control" href="#recommended-item-carousel" data-slide="prev">
                                <i class="fa fa-angle-left"></i>
                            </a>
                            <a class="right recommended-item-control" href="#recommended-item-carousel" data-slide="next">
                                <i class="fa fa-angle-right"></i>
                            </a>
                        </div>
                    </div>
                    <!--/recommended_items-->


                    <div class="features_items">
                        <!--features_items-->
                        <h2 class="title text-center">Recent Computers</h2>
                        <asp:ListView ID="lvComputer" EnableTheming="False" runat="server"
                            DataKeyField="Id">
                            <ItemTemplate>

                                <div class="col-sm-3">
                                    <div class="product-image-wrapper">
                                        <div class="single-products">
                                            <div class="productinfo text-center">
                                                <img src=" <%# DataBinder.Eval(Container.DataItem, "PictureUrl") %>" alt="" />
                                                <h2><%# DataBinder.Eval(Container.DataItem, "Price") %></h2>
                                                <p><%# DataBinder.Eval(Container.DataItem, "Title") %></p>
                                                <a href="Detail?Id=<%# DataBinder.Eval(Container.DataItem, "Id") %>" class="btn btn-default add-to-cart">View Detail</a>


                                            </div>

                                        </div>

                                    </div>
                                </div>






                            </ItemTemplate>
                        </asp:ListView>

                    </div>
                    <!--features_items-->
                    <div class="features_items">
                        <!--features_items-->
                        <h2 class="title text-center">Recent Furnitures</h2>

                        <asp:ListView ID="lvFurniture" EnableTheming="False" runat="server"
                            DataKeyField="Id">
                            <ItemTemplate>

                                <div class="col-sm-3">
                                    <div class="product-image-wrapper">
                                        <div class="single-products">
                                            <div class="productinfo text-center">
                                                <img src=" <%# DataBinder.Eval(Container.DataItem, "PictureUrl") %>" alt="" />
                                                <h2><%# DataBinder.Eval(Container.DataItem, "Price") %></h2>
                                                <p><%# DataBinder.Eval(Container.DataItem, "Title") %></p>
                                                <a href="Detail?Id=<%# DataBinder.Eval(Container.DataItem, "Id") %>" class="btn btn-default add-to-cart">View Detail</a>


                                            </div>

                                        </div>

                                    </div>
                                </div>






                            </ItemTemplate>
                        </asp:ListView>
                    </div>
                    <!--features_items-->


                </div>
            </div>
        </div>


    </section>
</asp:Content>
