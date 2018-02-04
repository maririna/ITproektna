<%@ Page Title="Vegan" Language="C#" MasterPageFile="SiteMaster.master" AutoEventWireup="true" CodeFile="vegan.aspx.cs" Inherits="vegan" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
      <asp:Label ID="lblMsg" runat="server" Text="The recipe is already in your favorites" Visible="False"></asp:Label>
    <h4 style="text-align:center; padding:1%; margin-bottom:0"><asp:Label ID="lblRecipeName" runat="server" Text="" Visible="False"></asp:Label></h4>
    <br />


     <div class="table table-striped table-inverse" id="recept"> 
        <asp:GridView ID="gvRecept" runat="server" AutoGenerateColumns="False" CellSpacing="1" 
                      GridLines="None" HorizontalAlign="Center" CssClass="table-responsive-md table-warning">
            <Columns>
                <asp:BoundField DataField="sostojki" HeaderText="INGREDIENTS" />
                <asp:BoundField DataField="postapka" HeaderText="INSTRUCTIONS" />
              
            </Columns>
        </asp:GridView>
    </div>
  <p style="text-align:center; padding:1%; font-size:1.5em; background-color:rgba(255, 216, 0,0.7)">Vegan</p>  
<div class="card-deck" style="margin:6px;">
    <div class="card" style="width:300px">
        <img class="card-img-top" src="img/vege_parmesan.jpg" alt="Card image">
        <div class="card-body">
           <h4 class="card-title">Crispy gluten-free eggplant parmesan</h4>
                     <p class="card-text">Crispy, vegan, gluten-free eggplant parmesan made with 10 simple ingredients! The perfect flavorful, plant-based entrée for Italian night!</p>
            <asp:LinkButton ID="LinkButton1" runat="server" CssClass="btn btn-warning" OnClick="LinkButton1_Click">Steps</asp:LinkButton>
            <asp:LinkButton runat="server" style="color:dimgray; text-decoration:none" CssClass="fa fa-plus " data-toggle="tooltip" data-placement="top" title="Add to my recipes" OnClick="ib1_Click">Add to my recipes</asp:LinkButton>
           </div>
    </div>
   <div class="card" style="width:300px">
        <img class="card-img-top" src="img/vegan_tofu.jpg" alt="Card image">
        <div class="card-body">
           <h4 class="card-title">Almond butter tofu stir-fry</h4> 
          <p class="card-text">Easy, 9-ingredient tofu stir-fry with baked tofu marinated in an almond-tamari sauce. Serve with veggies and rice for a flavorful, plant-based meal!</p>
            <asp:LinkButton ID="LinkButton2" runat="server" CssClass="btn btn-warning" OnClick="LinkButton2_Click">Steps</asp:LinkButton>
           <asp:LinkButton runat="server" style="color:dimgray; text-decoration:none" CssClass="fa fa-plus " data-toggle="tooltip" data-placement="top" title="Add to my recipes" OnClick="ib2_Click">Add to my recipes</asp:LinkButton>

         </div>
    </div>
    <div class="card" style="width:300px">
        <img class="card-img-top" src="img/vegan_wraps.jpg" alt="Card image">
        <div class="card-body">
           <h4 class="card-title">Vegan wraps</h4>
          <p class="card-text">Healthy, hearty, 30-minute Vegan Thanksgiving Wraps with roasted sweet potatoes, crispy chickpeas, and garlic-dill sauce, tucked inside homemade Garlic Herb Flatbreads!</p>
            <asp:LinkButton ID="LinkButton3" runat="server" CssClass="btn btn-warning" OnClick="LinkButton3_Click">Steps</asp:LinkButton>
           <asp:LinkButton runat="server" style="color:dimgray; text-decoration:none" CssClass="fa fa-plus " data-toggle="tooltip" data-placement="top" title="Add to my recipes" OnClick="ib3_Click">Add to my recipes</asp:LinkButton>
         </div>
    </div>
</div>



</asp:Content>

