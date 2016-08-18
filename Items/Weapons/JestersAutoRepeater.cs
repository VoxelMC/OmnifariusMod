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
            item.useTime = 12;
            item.useAnimation = 12;
            item.useStyle = 5;
            item.value = Item.sellPrice(0, 0, 0, 0);
            item.rare = 5;
            item.useSound = 5;
            item.autoReuse = true;
            item.shoot = ProjectileID.JestersArrow;
            item.shootSpeed = 10f;
            item.scale = 1f;
            item.useAmmo = 1;
        }
        public override bool Shoot(Player player, ref Microsoft.Xna.Framework.Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            float spread = 11.75f * 0.0174f;
            float baseSpeed = (float)Math.Sqrt(speedX * speedX + speedY * speedY);
            double startAngle = Math.Atan2(speedX, speedY) - spread / 2;
            double deltaAngle = spread / 3f;
            double offsetAngle;
            int i;
            for (i = 0; i < 3; i++)
            {
                offsetAngle = startAngle + deltaAngle * 2;
                Terraria.Projectile.NewProjectile(position.X, position.Y, baseSpeed * (float)Math.Sin(offsetAngle), baseSpeed * (float)Math.Cos(offsetAngle), ProjectileID.JestersArrow, damage, knockBack, item.owner);
            }
            for (i = 0; i < 4; i++)
            {
                offsetAngle = startAngle + deltaAngle * 2.5f;
                Terraria.Projectile.NewProjectile(position.X, position.Y, baseSpeed * (float)Math.Sin(offsetAngle), baseSpeed * (float)Math.Cos(offsetAngle), ProjectileID.JestersArrow, damage, knockBack, item.owner);
            }
            for (i = 0; i < 5; i++)
            {
                offsetAngle = startAngle + deltaAngle / 2;
                Terraria.Projectile.NewProjectile(position.X, position.Y, baseSpeed * (float)Math.Sin(offsetAngle), baseSpeed * (float)Math.Cos(offsetAngle), ProjectileID.JestersArrow, damage, knockBack, item.owner);
            }
            for (i = 0; i < 6; i++)
            {
                offsetAngle = startAngle + deltaAngle / 2.5f;
                Terraria.Projectile.NewProjectile(position.X, position.Y, baseSpeed * (float)Math.Sin(offsetAngle), baseSpeed * (float)Math.Cos(offsetAngle), ProjectileID.JestersArrow, damage, knockBack, item.owner);
            }
            return false;
        }
    }
}