using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;
using Terraria.ID;
using Terraria.ModLoader;

namespace OmnifariusMod.Items.Weapons
{
	public class CrystillineEdge : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Crystilline Edge"; 
			item.damage = 60; //change later
			item.melee = true; 
			item.width = 30; 
			item.height = 35; 
			item.useTime = 21; 
			item.useAnimation = 21;
			item.useStyle = 1; 
			item.knockBack = 4f; 
			item.value = 100; //change later
			item.rare = 10; //change later
			item.useSound = 1; 
			item.autoReuse = true; 
			item.useTurn = true;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Wood, 5); //change
			recipe.AddTile(TileID.WorkBenches); //change
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

	}
	
}
