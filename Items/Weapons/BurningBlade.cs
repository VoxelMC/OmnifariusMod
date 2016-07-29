using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OmnifariusMod-Schmo.Items.Weapons
{
	public class BurningBlade : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "BurningBlade";
			item.damage = 60; //change
			item.useStyle = 1;
			item.useAnimation = 20; //change
			item.useTime = 20; //change
			item.useSound = 1;
			item.value = 10; //change
			item.toolTip = "."; //change
			item.rare = 2; //change
			item.autoReuse = true;
			item.useTurn = true
			item.scale = 1;
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
