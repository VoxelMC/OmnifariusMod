using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OmnifariusMod.Items.Placeable
{
    public class BurntSand : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Burnt Sand";
            item.width = 12;
            item.height = 12;
            item.maxStack = 999;
            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.useStyle = 1;
            item.consumable = true;
            item.createTile = mod.TileType("BurntSandTile"); //put your CustomBlock Tile name
        }
    }
}
