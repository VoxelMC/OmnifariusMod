using Terraria.ID;
using Terraria.ModLoader;

namespace OmnifariusMod.Items.Ores
{
    public class PrismuthOre : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Prismuth Ore";
            item.width = 26;
            item.height = 22;
            item.maxStack = 999;
            AddTooltip("It's so prismatic!");
            item.useTurn = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.useStyle = 1;
            item.value = 50;
        }
    }
}