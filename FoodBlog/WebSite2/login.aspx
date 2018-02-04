<%@ Page Title="" Language="C#" MasterPageFile="SiteMaster.master" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="login" %>
<%@ MasterType  virtualPath="SiteMaster.master"%>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="container">    
   
        <div style="position: absolute; top: 25%;left: 50%;transform: translate(-50%, -50%); margin-top:50px; max-width:600px" class="mainbox col-md-6 col-md-offset-3 col-sm-8 col-sm-offset-2">                    
            <div class="card" >
                    <div class="card-header">
                        <div class="card-title">Log In</div>
                     </div>     

                    <div style="padding-top:30px" class="card-body" >               
                            <div style="margin-bottom: 25px" class="input-group">
                                        <span class="input-group-addon"><i class="fa fa-user-circle-o fa-fw" aria-hidden="true"></i></span>
                                        <asp:TextBox ID="txtUsername" runat="server" placeholder="username"  CssClass="form-control"></asp:TextBox>  
                                           <br /> 
                                           <asp:Label ID="lblUsernameR" runat="server" Text="Enter username!" CssClass="alert alert-danger" Visible="False"></asp:Label>
                                                                           
                                    </div>
                                
                            <div style="margin-bottom: 25px" class="input-group">
                                        <span class="input-group-addon"><i class="fa fa-lock fa-fw" aria-hidden="true"></i></span>
                                         <asp:TextBox ID="txtPassword" runat="server" placeholder="password"  CssClass="form-control" TextMode="Password"></asp:TextBox> 
                                             <br />
                                             <asp:Label ID="lblPasswordR" runat="server" Text="Enter password!" CssClass="alert alert-danger" Visible="False"></asp:Label>
                                    </div>
                                    
                             <br />
                             <asp:Label ID="lblIncorrect" runat="server" Text="Credentials are not correct!" CssClass="alert alert-danger" Visible="False"></asp:Label>
                           
                                <div style="margin-top:10px" class="form-group">
                                    
                                    <!-- Button -->
                                    <div class="col-sm-12 controls">
                                    <asp:LinkButton runat="server" ID="proceedToHome"  onclick="proceedToHome_Click" CssClass="btn btn-warning">
                                        <strong>Log in</strong>
                                </asp:LinkButton>
                               
                         &nbsp; &nbsp; <asp:Label ID="lblMsg" runat="server" Text=""  Visible="True"></asp:Label>Not a member yet? <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click" CssClass="text-muted">Create account here</asp:LinkButton>
                             </div>
                                </div>
                                    </div>                     
                    </div>  
        </div>
    </div>
</asp:Content>


