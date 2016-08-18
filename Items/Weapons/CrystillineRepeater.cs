using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace OmnifariusMod.Items.Weapons
{
	public class CrystillineRepeater : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Crystilline Repeater";
			item.noMelee = true;
			item.ranged = true;
			item.damage = 42;
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
	}
}