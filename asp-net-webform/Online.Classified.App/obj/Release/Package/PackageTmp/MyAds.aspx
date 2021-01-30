<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MyAds.aspx.cs" Inherits="Online.Classified.App.MyAds" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <section>
        <div class="container">
            <div class="row">
                <h2 class="title text-center">My Ads</h2>
            </div>
            <div class="row">
                <asp:Button ID="btnPostAd" runat="server" Text="Post Ad" CssClass="addBtn btn btn-success" />


            </div>
            <div class="row">&nbsp;</div>
            <div class="row">

                <asp:GridView BorderStyle="None" CssClass="table table-striped table-hover" runat="server" ID="gvAds" ShowHeader="true" AutoGenerateColumns="false" AllowPaging="true" AllowSorting="true" Font-Size="Smaller"
                    DataKeyNames="Id" OnPageIndexChanging="gvAds_PageIndexChanging">
                    <EmptyDataTemplate>
                        You currently have no interactions
                    </EmptyDataTemplate>
                    <Columns>
                        <%--                 <asp:TemplateField HeaderText="Delete" ItemStyle-HorizontalAlign="Center">
                            <ItemTemplate>
                                <asp:CheckBox ID="chkDel" runat="server" />
                            </ItemTemplate>
                        </asp:TemplateField>--%>
                        
                        <asp:TemplateField>
                            <ItemTemplate>
                                <asp:HiddenField ID="Id" runat="server" Value='<%#Eval("Id") %>' />
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Title">
                            <ItemTemplate>
                                <asp:Label ID="lblTitle" runat="server" Text='<%# Eval("Title") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Description">
                            <ItemTemplate>
                                <asp:Label ID="lblDescription" runat="server" Text='<%# Eval("Description") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Picture URL">
                            <ItemTemplate>
                                <asp:Label ID="lblPictureUrl" runat="server" Text='<%# Eval("PictureUrl") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Location">
                            <ItemTemplate>
                                <asp:Label ID="lblLocation" runat="server" Text='<%# Eval("Location") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>

                        <asp:TemplateField HeaderText="Price">
                            <ItemTemplate>
                                <asp:Label ID="lblPrice" runat="server" Text='<%# Eval("Price") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Is Recommended">
                            <ItemTemplate>
                                <asp:Label ID="lblIsRecommended" runat="server" Text='<%# Eval("IsRecommended") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>

                        <asp:TemplateField HeaderText="Telephone">
                            <ItemTemplate>
                                <asp:Label ID="lblPhoneNumber" runat="server" Text='<%# Eval("PhoneNumber") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="View / Edit">
                            <ItemTemplate>
                                <asp:LinkButton ID="lnkEdit" CssClass="trigger_popup_fricc updateBtn ads btn section1" runat="server" Text='Edit'></asp:LinkButton>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>




            </div>
        </div>
    </section>
    <!-- Modal -->
    <div class="modal fade" id="modalMyAds" tabindex="-1" role="dialog" aria-labelledby="myModalLabel">
        <div class="modal-dialog" role="document">
            <div class="modal-content">
                <div class="modal-header section1">
                    <button type="button" class="close" data-dismiss="modal" aria-label="Close"><span aria-hidden="true">&times;</span></button>
                    <h4 class="modal-title" id="myModalLabel"><strong>Add/Update Classified</strong></h4>
                </div>
                <div class="modal-body">
                    <table width="100%">
                         <tr>
                                                                    <td>
                                                                        <asp:HiddenField runat="server" ID="hfId" Value="" />
                                                                    </td>
                                                                </tr>
                        <tr>
                            <td>Category: </td></tr><tr>
                            <td> <asp:DropDownList ID="ddlCategory" CssClass="form-control" runat="server"></asp:DropDownList></td>
                        </tr>
                        <tr>
                            <td>Title: </td></tr><tr>
                            <td>
                                <asp:TextBox ID="txtTitle" CssClass="form-control" runat="server"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td>PictureUrl: </td></tr><tr>
                            <td>
                                <asp:TextBox ID="txtPictureUrl" CssClass="form-control" runat="server"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td>Description: </td></tr><tr>
                            <td>
                                <asp:TextBox ID="txtDescription" TextMode="MultiLine" CssClass="form-control" runat="server"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td>Location: </td></tr><tr>
                            <td>
                                <asp:TextBox ID="txtLocation" CssClass="form-control" runat="server"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td>Price: </td></tr><tr>
                            <td>
                                <asp:TextBox ID="txtPrice" CssClass="form-control" runat="server"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td>PhoneNumber: </td></tr><tr>
                            <td>
                                <asp:TextBox ID="txtPhoneNumber" CssClass="form-control" runat="server"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td>IsRecommended: </td></tr><tr>
                            <td>
                                <asp:DropDownList ID="ddlIsRecommended" CssClass="form-control" runat="server">
                                    <asp:ListItem Value="true">Yes</asp:ListItem>
                                    <asp:ListItem Value="false">No</asp:ListItem>
                                </asp:DropDownList></td>
                        </tr>
                    </table>
                </div>
                <div class="modal-footer">
                    <button type="button" class="btn btn-default" data-dismiss="modal">Close</button>

                    <asp:Button runat="server" ID="btnSaveIndicator" CssClass="btn section1" Text="Save Indicator" ForeColor="white" />

                </div>
            </div>
        </div>
    </div>
    <script>
        $(document).ready(function () {
            $(window).load(function () {
                $(".trigger_popup_fricc").click(function () {
                    if ($(this).hasClass("ads"))
                        $('#modalMyAds').modal('show');
                   

                    return false;
                });

            });
            $(".addBtn").click(function (e) {
                $('#modalMyAds').modal('show');


                return false;
            });
            $(".updateBtn").click(function (e) {

                $("#<% =ddlCategory.ClientID%>").val(0);
                $("#<% =ddlIsRecommended.ClientID%>").val(0);

                $("#<% =hfId.ClientID%>").val("");
                $("#<% =hfId.ClientID%>").val($(this).closest('tr').find("input[type=hidden][id*=Id]").val());

                $("#<% =txtTitle.ClientID%>").val($(this).closest('tr').find("span[id*=lblTitle]").text());
                $("#<% =txtPictureUrl.ClientID%>").val($(this).closest('tr').find("span[id*=lblPictureUrl]").text());
                $("#<% =txtDescription.ClientID%>").val($(this).closest('tr').find("span[id*=lblDescription]").text());
                $("#<% =txtLocation.ClientID%>").val($(this).closest('tr').find("span[id*=lblLocation]").text());
                $("#<% =txtPrice.ClientID%>").val($(this).closest('tr').find("span[id*=lblPrice]").text());
                $("#<% =txtPhoneNumber.ClientID%>").val($(this).closest('tr').find("span[id*=lblPhoneNumber]").text());

                var recommend = $(this).closest('tr').find("span[id*=lblIsRecommended]").text();
                if (recommend == "True")
                    var recommendVal = "Yes";
                else
                    var recommendVal = "No";
                $("#<% =ddlIsRecommended.ClientID%>").val(recommendVal);


                return false;

            })
        })

    </script>

</asp:Content>
