using Terraria.ID;
using Terraria.ModLoader;

namespace OmnifariusMod.Items
{
    public class InfernoChest : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Inferno Chest";        //Chest name
            item.width = 26;
            item.height = 22;
            item.maxStack = 99;
            AddTooltip("This is a modded chest.");   //chest descritpion
            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.useStyle = 1;
            item.consumable = true;
            item.value = 50;    //chest value/price
            item.createTile = mod.TileType("InfenoChestTile");  //here add your Chest name tile
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Chest);          //example of how to add a vanilla Terraria item
            recipe.AddIngredient(null, "ItemName", 10);   //example of how to add your custom item to the ingredient
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}