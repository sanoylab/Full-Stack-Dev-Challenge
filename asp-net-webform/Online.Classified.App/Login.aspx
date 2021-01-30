<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Online.Classified.App.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <section>
    <div class="container">
        <div class="row">
            <div class="col-md-6">
                

                    <div class="form-horizontal">
                        <h4>Login</h4>
                        <hr />
                      
                        <div class="form-group">
                          
                            <div class="col-md-10">
                                Username: <asp:TextBox ID="txtUsername" runat="server" CssClass="form-control" Text="admin"></asp:TextBox>
                               
                            </div>
                        </div>

                        <div class="form-group">
                         
                            <div class="col-md-10">
                                 Password: <asp:TextBox ID="txtPassword" TextMode="Password" Text="admin" runat="server" CssClass="form-control"></asp:TextBox>
                            </div>
                        </div>

                        <div class="form-group">
                            <div class="col-md-offset-2 col-md-10">
                                <asp:Button ID="Button1" runat="server" Text="Login" CssClass="btn btn-default" OnClick="Button1_Click" />
                            </div>
                        </div>
                    </div>
             
            </div>


        </div>
        </div>
    </section>
</asp:Content>
