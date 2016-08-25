using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace OmnifariusMod.Items.Weapons
{
	public class FieryDraw : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Fiery Draw";
			item.noMelee = true;
			item.ranged = true;
			item.damage = 20;
			item.knockBack = 2.5f;
			item.useTime = 12;
			item.useAnimation = 12;
			item.useStyle = 5;
			item.value = Item.sellPrice(0, 0, 0, 0);
            item.rare = 5;
			item.useSound = 5;
			item.autoReuse = true;
            item.shoot = 10;
			item.shootSpeed = 10f;
			item.scale = 1f;
            item.useAmmo = 1;
		}
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "InferniteBar", 8);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}