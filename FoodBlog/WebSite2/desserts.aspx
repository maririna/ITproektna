<%@ Page Title="Desserts" Language="C#" MasterPageFile="SiteMaster.master" AutoEventWireup="true" CodeFile="desserts.aspx.cs" Inherits="desserts" %>
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
      <br />
    <p style="text-align:center; padding:1%; font-size:1.5em; background-color:rgba(255, 216, 0,0.7)">Desserts</p>
<div class="card-deck" style="margin:6px">
   <div class="card" style="width:300px">
        <img class="card-img-top" src="img/vegan_choco_cake.jpg" alt="Card image">
        <div class="card-body">
           <h4 class="card-title">Vegan chocolate cake</h4>
               <p class="card-text">1-bowl vegan chocolate cake made in less than 1 hour with simple ingredients. A 2-layer buttercream-frosted cake that's moist, fluffy, and rich with chocolate flavor.</p>
            <asp:LinkButton ID="LinkButton2" runat="server" CssClass="btn btn-warning" OnClick="LinkButton2_Click">See steps</asp:LinkButton>
            <asp:LinkButton runat="server" style="color:dimgray; text-decoration:none" CssClass="fa fa-plus " data-toggle="tooltip" data-placement="top" title="Add to my recipes" OnClick="ib6_Click">Add to my recipes</asp:LinkButton>
           </div>
    </div>

   
             <div class="card" style="width:300px">
        <img class="card-img-top" src="img/no_bake_cake.jpg" alt="Card image">
        <div class="card-body">
           <h4 class="card-title">No bake chocolate cheesecake</h4>
             
          <p class="card-text">Thick, custard-like vegan chocolate cheesecakes with a date-walnut cocoa crust. Just 10 ingredients required and entirely vegan and gluten free. Perfect topped with coconut chipped cream and fresh fruit.</p>
           <asp:LinkButton ID="LinkButton9" runat="server" CssClass="btn btn-warning" OnClick="LinkButton9_Click">Steps</asp:LinkButton>
            <asp:LinkButton runat="server" style="color:dimgray; text-decoration:none" CssClass="fa fa-plus " data-toggle="tooltip" data-placement="top" title="Add to my recipes" OnClick="ib8_Click">Add to my recipes</asp:LinkButton>
             </div>
    </div>


   <div class="card" style="width:300px">
        <img class="card-img-top" src="img/vegan_cheesecake.jpg" alt="Card image">
        <div class="card-body">
           <h4 class="card-title">7-ingredient vegan cheesecake</h4>
 
          <p class="card-text">7-ingredient vegan, gluten-free cheesecakes that are creamy, slightly tart, perfectly sweet, and 100% irresistible. Better than real cheesecake and the perfect healthy, simple dessert to feed a crowd (or just you).</p>
            <asp:LinkButton ID="LinkButton5" runat="server" CssClass="btn btn-warning" OnClick="LinkButton5_Click">Steps</asp:LinkButton>
            <asp:LinkButton runat="server" style="color:dimgray; text-decoration:none" CssClass="fa fa-plus " data-toggle="tooltip" data-placement="top" title="Add to my recipes" OnClick="ib5_Click">Add to my recipes</asp:LinkButton>
            
          </div>
    </div>  
    </div>
    <div class="card-deck" style="margin:6px;">
    <div class="card" style="width:300px">
        <img class="card-img-top" src="img/pretzel_truffles.jpg" alt="Card image">
        <div class="card-body">
           <h4 class="card-title">Peanut butter pretzel truffles</h4>
            
          <p class="card-text">Vegan peanut butter pretzel truffles dipped in semisweet chocolate and topped with even more crushed pretzels. The perfect simple, healthier dessert.</p>
            <asp:LinkButton ID="LinkButton6" runat="server" CssClass="btn btn-warning" OnClick="LinkButton6_Click">Steps</asp:LinkButton>
            <asp:LinkButton runat="server" style="color:dimgray; text-decoration:none" CssClass="fa fa-plus " data-toggle="tooltip" data-placement="top" title="Add to my recipes" OnClick="ib4_Click">Add to my recipes</asp:LinkButton>
             </div>
    </div>
    <div class="card" style="width:300px">
        <img class="card-img-top" src="img/cinamon_rolls.jpg" alt="Card image">
        <div class="card-body">
           <h4 class="card-title">Gluten-free cinnamon rolls</h4>
          <p class="card-text">Amazing fluffy and tender vegan, gluten-free cinnamon rolls! Just 10 ingredients and simple methods required for these insanely flavorful and delicious rolls!</p>
           <asp:LinkButton ID="LinkButton7" runat="server" CssClass="btn btn-warning" OnClick="LinkButton7_Click">Steps</asp:LinkButton>
            <asp:LinkButton runat="server" style="color:dimgray; text-decoration:none" CssClass="fa fa-plus " data-toggle="tooltip" data-placement="top" title="Add to my recipes" OnClick="ib3_Click">Add to my recipes</asp:LinkButton>
             </div>
    </div>
</div>
<div class="card-deck" style="margin:6px;">
    <div class="card" style="width:300px">
        <img class="card-img-top" src="img/pumpkin_pies.jpg" alt="Card image">
        <div class="card-body">
           <h4 class="card-title">Mini vegan pumpkin pies</h4>
          <p class="card-text">Easy, 10-ingredient mini vegan pumpkin pies with coconut oil crust! Naturally sweetened, simple to make, and so flaky and delicious! The perfect dessert for fall, especially Thanksgiving.
          </p>
           
            <asp:LinkButton ID="LinkButton8" runat="server" CssClass="btn btn-warning" OnClick="LinkButton8_Click">Steps</asp:LinkButton>
            <asp:LinkButton runat="server" style="color:dimgray; text-decoration:none" CssClass="fa fa-plus " data-toggle="tooltip" data-placement="top" title="Add to my recipes" OnClick="ib1_Click">Add to my recipes</asp:LinkButton>
            </div>
    </div>

     <div class="card" style="width:300px">
        <img class="card-img-top" src="img/bourbon_caramel.jpg" alt="Card image">
        <div class="card-body">
           <h4 class="card-title">Bourbon caramel almond butter cups</h4> 
          <p class="card-text">7 Ingredient from scratch Bourbon Almond Butter Cups. Decadent, sweet, satisfying and surprisingly simple.</p>
            <asp:LinkButton ID="LinkButton4" runat="server" CssClass="btn btn-warning" OnClick="LinkButton4_Click">Steps</asp:LinkButton>
            <asp:LinkButton runat="server" style="color:dimgray; text-decoration:none" CssClass="fa fa-plus " data-toggle="tooltip" data-placement="top" title="Add to my recipes" OnClick="ib7_Click">Add to my recipes</asp:LinkButton>
           
         </div>
    </div>
          <div class="card" style="width:300px">
        <img class="card-img-top" src="img/choco_mouse.jpg" alt="Card image">
        <div class="card-body">
           <h4 class="card-title">Dark chocolate peppermint mousse</h4> 
          <p class="card-text">Amazing vegan dark chocolate mousse infused with real mint. Fluffy, rich, intensely satisfying, and the perfect healthier dessert for mint chocolate lovers.</p>
          <asp:LinkButton ID="LinkButton10" runat="server" CssClass="btn btn-warning" OnClick="LinkButton10_Click">Steps</asp:LinkButton>
          <asp:LinkButton runat="server" style="color:dimgray; text-decoration:none" CssClass="fa fa-plus " data-toggle="tooltip" data-placement="top" title="Add to my recipes" OnClick="ib2_Click">Add to my recipes</asp:LinkButton>
              </div>
    </div>

    </div>

</asp:Content>

