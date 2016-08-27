using System;

using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OmnifariusMod.Items.Armor
{
    public class InfernalBreastplate : ModItem
    {
        public override bool Autoload(ref string name, ref string texture, System.Collections.Generic.IList<EquipType> equips)
        {
            equips.Add(EquipType.Body);
            return true;
        }

        public override void SetDefaults()
        {
            item.name = "Infernal Breastplate";
            item.width = 20; item.height = 12;
            item.toolTip = "???";
        }

        public override void AddRecipes()
        {
            // ???
        }
    }
}
