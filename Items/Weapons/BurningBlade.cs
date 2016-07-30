using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OmnifariusMod.Items.Weapons
{
	public class BurningBlade : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Burning Blade";
			item.damage = 17;
            item.height = 7;
            item.width = 1;
			item.useStyle = 1;
			item.useAnimation = 19;
			item.useTime = 19;
			item.useSound = 1;
			item.value = 10; //change
			item.rare = 6;
            item.useTurn = true;
			item.scale = 0.8f;
			item.melee = true;
			item.knockBack = 3f; //change
		}

		/*public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient();
			recipe.AddTile();
			recipe.SetResult(this);
			recipe.AddRecipe();
		}*/
	}
}
