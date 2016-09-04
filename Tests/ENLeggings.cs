using System;

using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OmnifariusMod.Tests
{
    public class ENLeggings : ModItem
    {
        public override bool Autoload(ref string name, ref string texture, System.Collections.Generic.IList<EquipType> equips)
        {
            equips.Add(EquipType.Legs);
            return true;
        }

        public override void SetDefaults()
        {
            item.name = "EN Leggings";
            item.width = 20; item.height = 12;
            item.toolTip = "???";
        }

        public override void AddRecipes()
        {
            // ???
        }
        public override void UpdateEquip(Player player)
        {
            player.moveSpeed += 0.10f;
        }
    }
}
