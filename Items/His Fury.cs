using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OmnifariusMod.Items
{
	public class HisFury : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "His Fury";
			item.damage = 40; //change
			item.toolTip = ".."; //change
			item.useStyle = 1;
			item.useAnimation = 20; //change
			item.useTime = 20; //change
			item.useSound = 1;
			item.knockBack = 4f;
			item.autoReuse = true;
			item.axe = 100; //change
			item.melee = true;
		}

		/*public override void AddRecipe()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient();
			recipe.AddTile();
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}