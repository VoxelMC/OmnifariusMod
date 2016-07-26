using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ModLoader;

namespace OmnifariusMod.Items.Weapons
{
    public class CrystalTempest : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Crystal Tempest";
            item.damage = 60;
            item.magic = true;
            item.mana = 3;
            item.width = 28;
            item.height = 32;
            item.useTime = 4;
            item.useAnimation = 8;
            item.useStyle = 5;
            item.noMelee = true; //so the item's animation doesn't do damage
            item.knockBack = 5;
            item.value = 10000;
            item.rare = 4;
            item.useSound = 9;
            item.autoReuse = true;
            item.shoot = mod.ProjectileType("CrystalStormProjectile");
            item.shootSpeed = 16f;
        }
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            Projectile.NewProjectile(Main.rand.Next(-40, 40), player.Center.Y - 650 + Main.rand.Next(-50, 50), 0, 20, mod.ProjectileType("CrystalStormProjectile"), damage, knockBack, player.whoAmI);
            Projectile.NewProjectile(Main.rand.Next(-40, 40), player.Center.Y - 650 + Main.rand.Next(-50, 50), 0, 20, mod.ProjectileType("CrystalStormProjectile"), damage, knockBack, player.whoAmI);
            Projectile.NewProjectile(Main.rand.Next(-40, 40), player.Center.Y - 650 + Main.rand.Next(-50, 50), 0, 20, mod.ProjectileType("CrystalStormProjectile"), damage, knockBack, player.whoAmI);
            Projectile.NewProjectile(Main.rand.Next(-40, 40), player.Center.Y - 650 + Main.rand.Next(-50, 50), 0, 20, mod.ProjectileType("CrystalStormProjectile"), damage, knockBack, player.whoAmI);
            return true;
        }
    }
}