using Terraria.ID;
using Terraria.ModLoader;

namespace OmnifariusMod.Items
{
    public class InfernoChest : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Test Item";
            item.width = 26;
            item.height = 22;
            item.maxStack = 99;
            AddTooltip("This item is used to test mechanics.");
            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.useStyle = 1;
            item.consumable = true;
            item.value = 50;


        }
        public override void UpdateEquip(Player player)
        {
            player.GetModPlayer<CrystalPlayer>(mod).ConduitArmour = true; //Enables Conduit Armour effect
        }
    }
}