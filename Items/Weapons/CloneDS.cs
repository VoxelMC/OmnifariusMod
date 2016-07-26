using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OmnifariusMod.Items.Weapons
{
    public class CloneDS : ModItem
    {
        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.DeathSickle);
            item.name = "Better Death Sickle";
            item.shootSpeed *= 1.75f;
            item.shoot = mod.ProjectileType("CloneDSP");
            item.damage *= 2;
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