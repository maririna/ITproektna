<%@ Page Title="Register" Language="C#" MasterPageFile="SiteMaster.master" AutoEventWireup="true" CodeFile="register.aspx.cs" Inherits="register" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="container">    

 <div style="position: absolute; text-align:center; top: 25%;left: 50%;transform: translate(-50%, -50%); margin-top:70px; max-width:600px" class="mainbox col-md-6 col-md-offset-3 col-sm-8 col-sm-offset-2">
 <div class="card">
     <div class="card-header">
     <div class="card-title">Create account</div>
     </div> 
     <div style="padding-top:30px" class="card-body" >
    
    <div class="form-row" >
      <label>Username</label>
     <asp:TextBox ID="txtUsername" runat="server" CssClass="form-control" placeholder="Username" MaxLength="20" CausesValidation="True" CssStyle="width:100%" ></asp:TextBox>
     <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtUsername" ErrorMessage="Username is a required field."></asp:RequiredFieldValidator>
    </div>

    <div class="form-row">
    <label>E-mail</label>
      <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control" placeholder="Email" MaxLength="30" CausesValidation="True" ></asp:TextBox>
       <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtEmail" ErrorMessage="You must enter a valid email." ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
       
   </div>

    <div class="form-row">
      <label>Password</label>
         <asp:TextBox ID="txtPassword1" runat="server" CssClass="form-control" placeholder="Password" MaxLength="30" CausesValidation="True" TextMode="Password"></asp:TextBox><br/>
        <asp:TextBox ID="txtPassword2" runat="server" CssClass="form-control" placeholder="Reenter your password" MaxLength="30" CausesValidation="True" TextMode="Password"></asp:TextBox>   
        <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txtPassword1" ControlToValidate="txtPassword2" ErrorMessage="The two passwords don't match."></asp:CompareValidator>
    </div>
    <asp:LinkButton ID="btnRegister" runat="server" CssClass="btn btn-warning" OnClick="btnRegister_Click">Create</asp:LinkButton>
       <asp:Label ID="lblMsg" runat="server"></asp:Label>
    
</div>
</div>
</div>
</div>
</asp:Content>

