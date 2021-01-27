<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Detail.aspx.cs" Inherits="Online.Classified.App.Detail" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <section>
    <div class="container">
        <div class="row">
   <asp:ListView ID="lvClassified" EnableTheming="False" runat="server"
                    DataKeyField="Id">
                    <ItemTemplate>

                        <div class="col-sm-12 padding-right">
                <div class="product-details">
                    <!--product-details-->

                    <div class="col-sm-8">
                        <div class="product-information">
                            <!--/product-information-->

                            <span><span><%# DataBinder.Eval(Container.DataItem, "Title") %></span></span>
                        <div class="view-product">
                                <img src="<%# DataBinder.Eval(Container.DataItem, "PictureUrl") %>" alt="" />
                                <h3>ZOOM</h3>
                            </div>
                            <p>&nbsp;</p>
                            <p><%# DataBinder.Eval(Container.DataItem, "Description") %></p>
                            <img src="images/product-details/rating.png" alt="" />
                            <span>
                                <span><%# DataBinder.Eval(Container.DataItem, "Price") %></span>

                            </span>


                            <a href=""><img src="images/product-details/share.png" class="share img-responsive" alt="" /></a>
                        </div><!--/product-information-->
                    </div>
                    <div class="col-sm-4">
                        <div class="product-information">
                            <p><i class="fa fa-map-marker" aria-hidden="true"></i> <%# DataBinder.Eval(Container.DataItem, "Location") %></p>
                            <p>&nbsp;</p>
                            <button style="width: 100%;" class="btn btn-lg btn-success"><i class="fa fa-phone" aria-hidden="true"></i> <%# DataBinder.Eval(Container.DataItem, "PhoneNumber") %></button>
                            <p>&nbsp;</p>
                            <p class="small text-center">To deter and identify potential fraud, spam or suspicious behaviour, we reserve the right to monitor conversations. By sending the message you agree to our Terms of Use and Privacy Policy.</p>
                        </div>


                    </div>
                </div><!--/product-details-->

                

            </div>
                    </ItemTemplate>
                </asp:ListView>



            
        </div>
    </div>



    


</section>
</asp:Content>
