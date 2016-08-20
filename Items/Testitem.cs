using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using System;
using System.Collections.Generic;

namespace OmnifariusMod.Items
{
    public class Testitem : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Test Item";
            item.width = 26;
            item.height = 22;
            AddTooltip("This item is used to test mechanics.");
            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.useStyle = 1;
            item.consumable = true;
            item.value = 50;
            item.accessory = true;

        }
        public override void UpdateEquip(Player player)
        {
            player.GetModPlayer<MyPlayer>(mod).ConduitArmour = true; //Enables Conduit Armour effect
        }
    }
}