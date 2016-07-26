using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OmnifariusMod.Items.Armor
{
    public class HelmetName : ModItem
    {
        public override bool Autoload(ref string name, ref string texture, IList<EquipType> equips)
        {
            equips.Add(EquipType.Head);
            return true;
        }

        public override void SetDefaults()
        {
            item.name = "Star Helmet";
            item.width = 18;
            item.height = 18;
            item.toolTip = "This is a Star helmet.";
            item.toolTip2 = "8% magic damage.";
            item.value = 10000;
            item.rare = 2;
            item.defense = 8;
        }

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return body.type == mod.ItemType("BreastplateName") && legs.type == mod.ItemType("Leggings");  //put your Breastplate name and Leggings name
        }
        public override void UpdateArmorSet(Player player)
        {
            player.setBonus = "Shine like a Star"; // the armor set bonus
            player.canCarpet = true;
            player.carpet = true;
            player.carpetTime = 300;
            player.findTreasure = true;

        }
        public override void AddRecipes()  //How to craft this item
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Wood, 1);   //you need 1 Wood
            recipe.AddTile(TileID.WorkBenches);   //at work bench
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}