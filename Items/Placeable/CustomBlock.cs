using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OmnifariusMod.Items.Placeable
{
    public class CustomBlock : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Water Stone";
            item.width = 12;
            item.height = 12;
            item.maxStack = 999;
            AddTooltip("This is water block.");
            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.useStyle = 1;
            item.consumable = true;
            item.createTile = mod.TileType("CustomTileBlock"); //put your CustomBlock Tile name
        }
        public override void AddRecipes()  //How to craft this item
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Wood, 10);   //you need 10 Wood
            recipe.AddTile(TileID.WorkBenches);   //at work bench
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
