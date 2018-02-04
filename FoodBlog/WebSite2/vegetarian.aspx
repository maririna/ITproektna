<%@ Page Title="Vegetarian" Language="C#" MasterPageFile="SiteMaster.master" AutoEventWireup="true" CodeFile="vegetarian.aspx.cs" Inherits="vegetarian" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Label ID="lblMsg" runat="server" Text="The recipe is already in your favorites" Visible="False"></asp:Label>
    <h4 style="text-align:center; padding:1%; margin-bottom:0"><asp:Label ID="lblRecipeName" runat="server" Text="" Visible="False"></asp:Label></h4>
    <br />
         <div class="table table-striped table-inverse" id="recept"> 
        <asp:GridView ID="gvRecept" runat="server" AutoGenerateColumns="False" CellSpacing="1" 
                      GridLines="None" HorizontalAlign="Center" CssClass="table-responsive-md table-warning" >
            <Columns>
                <asp:BoundField DataField="sostojki" HeaderText="INGREDIENTS" />
                <asp:BoundField DataField="postapka" HeaderText="INSTRUCTIONS" />
            </Columns>
        </asp:GridView>

    </div>
    <br />
    <p style="text-align:center; padding:1%; font-size:1.5em; background-color:rgba(255, 216, 0,0.7)">Vegetarian</p> 
<div class="card-deck" style="margin:6px">
   <div class="card" style="width:300px">
        <img class="card-img-top" src="img/vegan_soup.jpg" alt="Card image">
        <div class="card-body">
           <h4 class="card-title">Rich red curry with roasted vegetables</h4> 
            <p class="card-text">Rich coconut milk and red pepper-based curry with roasted vegetables and cauliflower or brown rice! A hearty, flavorful, 30-minute plant-based meal.</p>
            <asp:LinkButton ID="LinkButton2" runat="server" CssClass="btn btn-warning" OnClick="LinkButton2_Click">Steps</asp:LinkButton>
            <asp:LinkButton runat="server" style="color:dimgray; text-decoration:none" CssClass="fa fa-plus " data-toggle="tooltip" data-placement="top" title="Add to my recipes" OnClick="ib9_Click">Add to my recipes</asp:LinkButton>   
        </div>

    </div>
    <div class="card" style="width:300px">
        <img class="card-img-top" src="img/vegetarian_eggplant.jpg" alt="Card image">
        <div class="card-body">
           <h4 class="card-title">Lentil-stuffed eggplant</h4> 
          <p class="card-text">Stuffed baked eggplant with Moroccan-spiced lentils! Just 9 ingredients, big flavor, plenty of protein and fiber, and the perfect side dish or entrée.</p>
            <asp:LinkButton ID="LinkButton3" runat="server" CssClass="btn btn-warning" OnClick="LinkButton3_Click">Steps</asp:LinkButton>
            <asp:LinkButton runat="server" style="color:dimgray; text-decoration:none" CssClass="fa fa-plus " data-toggle="tooltip" data-placement="top" title="Add to my recipes" OnClick="ib7_Click">Add to my recipes</asp:LinkButton>   
         </div>
    </div>


   <div class="card" style="width:300px">
        <img class="card-img-top" src="img/vegetarian_pumpkin.jpg" alt="Card image">
        <div class="card-body">
           <h4 class="card-title">Roast pumpkin with green charmoula and tahini</h4>
          <p class="card-text">An impressive vegetarian dish featuring roasted pumpkin, vibrant green charmoula and creamy tahini dressing. It's incredibly simple to make but looks stunning on the dinner table.</p>
            <asp:LinkButton ID="LinkButton4" runat="server" CssClass="btn btn-warning" OnClick="LinkButton4_Click">Steps</asp:LinkButton>
            <asp:LinkButton runat="server" style="color:dimgray; text-decoration:none" CssClass="fa fa-plus " data-toggle="tooltip" data-placement="top" title="Add to my recipes" OnClick="ib5_Click">Add to my recipes</asp:LinkButton>   
          </div>
    </div>  
    </div>

    <div class="card-deck" style="margin:6px;">
    <div class="card" style="width:300px">
        <img class="card-img-top" src="img/baked_eggs.jpg" alt="Card image">
        <div class="card-body">
           <h4 class="card-title">Baked eggs with mushrooms, potatoes, spinach and gruyère</h4> <asp:LinkButton type="button" runat="server" class="btn btn-sm" data-toggle="tooltip" data-placement="top" title="Add to my recipes" OnClick="ib4_Click">Add to my recipes</asp:LinkButton>             
          <p class="card-text">Make this baked eggs recipe in just one pan - perfect for lunch, brunch or a meat free Monday supper.</p>
            <asp:LinkButton ID="LinkButton5" runat="server" CssClass="btn btn-warning" OnClick="LinkButton5_Click">Steps</asp:LinkButton>
            <asp:LinkButton runat="server" style="color:dimgray; text-decoration:none" CssClass="fa fa-plus " data-toggle="tooltip" data-placement="top" title="Add to my recipes" OnClick="ib4_Click">Add to my recipes</asp:LinkButton>   
             </div>
    </div>
    <div class="card" style="width:300px">
        <img class="card-img-top" src="img/veggie_burger.jpg" alt="Card image"/>
        <div class="card-body">
         <h4 class="card-title">Sweet potato burgers with chilli, mint and mashed avocado</h4>
         <asp:ImageButton ID="ImageButton3" runat="server" Height="20px" ImageAlign="Left" ImageUrl="img/success.png" Width="20px" OnClick="ib3_Click" />
         <p class="card-text">Slices of halloumi and sweet potato are marinated, grilled and placed in burger buns spread with a generous amount of smashed avocado. That's vegetarian barbecuing done right.</p>
         <asp:LinkButton ID="LinkButton6" runat="server" CssClass="btn btn-warning" OnClick="LinkButton6_Click">Steps</asp:LinkButton>
         <asp:LinkButton runat="server" style="color:dimgray; text-decoration:none" CssClass="fa fa-plus " data-toggle="tooltip" data-placement="top" title="Add to my recipes" OnClick="ib3_Click">Add to my recipes</asp:LinkButton>    
        </div>
    </div>
</div>

<div class="card-deck" style="margin:6px;">
    <div class="card" style="width:300px">
        <img class="card-img-top" src="img/tomato_pasta.jpg" alt="Card image">
        <div class="card-body">
           <h4 class="card-title">Cherry tomato and chilli pasta</h4>
          <p class="card-text">This rustic, vegetarian pasta dish is so easy to prepare. It's also the perfect recipe to make in bulk and freeze.</p>
            <asp:LinkButton ID="LinkButton7" runat="server" CssClass="btn btn-warning" OnClick="LinkButton7_Click">Steps</asp:LinkButton>
            <asp:LinkButton runat="server" style="color:dimgray; text-decoration:none" CssClass="fa fa-plus " data-toggle="tooltip" data-placement="top" title="Add to my recipes" OnClick="ib1_Click">Add to my recipes</asp:LinkButton>   
            </div>
    </div>
          <div class="card" style="width:300px">
        <img class="card-img-top" src="img/potatoes.jpg" alt="Card image">
        <div class="card-body">
           <h4 class="card-title">Spicy Spanish potatoes (patatas bravas)</h4>
           <p class="card-text">A perfect Spanish snack – crispy potatoes and a smokey tomato sauce with a garlicky mayonnaise.</p>
           <asp:LinkButton ID="LinkButton8" runat="server" CssClass="btn btn-warning" OnClick="LinkButton8_Click">Steps</asp:LinkButton>
            <asp:LinkButton runat="server" style="color:dimgray; text-decoration:none" CssClass="fa fa-plus " data-toggle="tooltip" data-placement="top" title="Add to my recipes" OnClick="ib8_Click">Add to my recipes</asp:LinkButton>   
             </div>

    </div>
          <div class="card" style="width:300px">
        <img class="card-img-top" src="img/veggie_pizza.jpg" alt="Card image">
        <div class="card-body">
         <h4 class="card-title">Vegetarian pizza</h4>
          <p class="card-text">Vegetarian "sausage" tops off this meaty Mediterranean-inspired vegan pizza recipe with pesto, vegan mozzarella cheese and artichokes. </p>
           <asp:LinkButton ID="LinkButton9" runat="server" CssClass="btn btn-warning" OnClick="LinkButton9_Click">Steps</asp:LinkButton>
           <asp:LinkButton runat="server" style="color:dimgray; text-decoration:none" CssClass="fa fa-plus " data-toggle="tooltip" data-placement="top" title="Add to my recipes" OnClick="ib2_Click">Add to my recipes</asp:LinkButton>   
       </div>
    </div>

    </div>

</asp:Content>

 