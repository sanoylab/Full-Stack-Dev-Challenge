<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Classified.aspx.cs" Inherits="Online.Classified.App.Classified1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <section>
        <div class="container">
            <div class="row">
                <h2 class="title text-center">
                    <asp:Label ID="lblTitle" runat="server"></asp:Label></h2>

                <asp:ListView ID="lvClassified" EnableTheming="False" runat="server"
                    DataKeyField="Id">
                    <ItemTemplate>

                        <div class="col-sm-3">
                            <div class="product-image-wrapper" style="border: 1px solid #F0F0E9;">
                                <div class="single-products">
                                    <div class="productinfo text-center">
                                        <img src=" <%# DataBinder.Eval(Container.DataItem, "PictureUrl") %>" alt="" />
                                        <a href="/detail?Id=<%# DataBinder.Eval(Container.DataItem, "Id") %>">
                                            <h2><%# DataBinder.Eval(Container.DataItem, "Price") %></h2>
                                            <p><%# DataBinder.Eval(Container.DataItem, "Title") %></p>
                                            <a href="Detail?Id=<%# DataBinder.Eval(Container.DataItem, "Id") %>" class="btn btn-default add-to-cart">View Detail</a>

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
