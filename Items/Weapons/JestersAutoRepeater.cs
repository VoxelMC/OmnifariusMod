using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace OmnifariusMod.Items.Weapons
{
    public class JestersAutoRepeater : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Jester's Auto-Repeater";
            item.noMelee = true;
            item.ranged = true;
            item.damage = 30;
            item.knockBack = 2.5f;
            item.useTime = 9;
            item.useAnimation = 36;
            item.useStyle = 5;
            item.value = Item.sellPrice(0, 0, 0, 0);
            item.rare = 5;
            item.useSound = 5;
            item.autoReuse = true;
            item.shoot = ProjectileID.JestersArrow;
            item.shootSpeed = 10f;
            item.scale = 1f;
            item.useAmmo = 1;
            item.toolTip = "25% chance to not cosume ammo";
            item.toolTip2 = "Turns Wooden Arrows into Jester's Arrows";
        }
        public override bool Shoot(Player player, ref Microsoft.Xna.Framework.Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            if (type == ProjectileID.WoodenArrowFriendly) // or ProjectileID.WoodenArrowFriendly
            {
                type = ProjectileID.JestersArrow;
            }
            return true;
        }
        public override bool ConsumeAmmo(Player player)
        {
            return Main.rand.NextFloat() > .25f;
        }
    }
}