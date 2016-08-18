using Terraria.ID;
using Terraria.ModLoader;

namespace OmnifariusMod.Items
{
    public class DarkIron : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Dark Iron";
            item.width = 26;
            item.height = 22;
            item.maxStack = 999;
            AddTooltip("It feels imbued with strange energies.");
            item.useTurn = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.useStyle = 1;
            item.value = 50;
        }
    }
}