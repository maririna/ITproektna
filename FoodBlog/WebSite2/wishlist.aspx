<%@ Page Title="My recipes" Language="C#" MasterPageFile="SiteMaster.master" AutoEventWireup="true" CodeFile="wishlist.aspx.cs" Inherits="wishlist" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
 
    <div>
        <br />
        <div class="table table-striped table-inverse"> 
        <asp:GridView ID="gvWishList" runat="server" AutoGenerateColumns="False" OnRowDeleting="gvWishlist_RowDeleting" CellSpacing="1" 
                      GridLines="None" HorizontalAlign="Center">
            <Columns>
               
                <asp:TemplateField HeaderText="My favorite recipes">
                    <ItemTemplate>
                        <asp:Label ID="lbl1" runat="server" Text='<%# Eval("favRecipe") %>' />
                    </ItemTemplate>
                </asp:TemplateField>

                 <asp:TemplateField HeaderText="">
                    <ItemTemplate>
                        <asp:Button ID="btn1" runat="server" class="btn btn-outline-secondary" CommandName="Delete" Text="Remove recipe" />
                    </ItemTemplate>
                </asp:TemplateField>
                

                
            </Columns>
        </asp:GridView>
    </div>

         
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblError" runat="server"></asp:Label>
        
    
    </div>
   

</asp:Content>

