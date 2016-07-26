using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OmnifariusMod.Items.Weapons
{  
    public class MinionS : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Minion Summon Staff";
            item.damage = 14;
            item.summon = true;
            item.mana = 10;
            item.width = 26;
            item.height = 28;
            item.toolTip = "Summons a minion to fight for you.";
            item.useTime = 26;
            item.useAnimation = 26;
            item.useStyle = 1;
            item.noMelee = true;
            item.knockBack = 3;
            item.value = Item.buyPrice(0, 30, 0, 0);
            item.rare = 11;
            item.useSound = 44;
            item.shoot = mod.ProjectileType("MinionName");
            item.shootSpeed = 7f;
            item.buffTime = 3600;
            item.buffType = mod.BuffType("MinionBuff"); 
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.DirtBlock, 1);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}