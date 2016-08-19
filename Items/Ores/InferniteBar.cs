using Terraria.ID;
using Terraria.ModLoader;

namespace OmnifariusMod.Items.Ores
{
    public class InferniteBar : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Infernite Bar";
            item.width = 26;
            item.height = 22;
            item.maxStack = 99;
            AddTooltip("Still emits embers.");
            item.useTurn = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.useStyle = 1;
            item.value = 50;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "InferniteOre", 3);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}