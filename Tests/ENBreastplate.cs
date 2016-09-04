using System;

using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OmnifariusMod.Tests
{
    public class ENBreastplate : ModItem
    {
        public override bool Autoload(ref string name, ref string texture, System.Collections.Generic.IList<EquipType> equips)
        {
            equips.Add(EquipType.Body);
            return true;
        }

        public override void SetDefaults()
        {
            item.name = "EN Breastplate";
            item.width = 20; item.height = 12;
            item.toolTip = "???";
            item.defense = 21;
        }

        public override void AddRecipes()
        {
            // ???
        }
        public override void UpdateEquip(Player player)
        {
            player.meleeDamage += 0.26f;
            player.thrownDamage += 0.26f;
        }
    }
}
