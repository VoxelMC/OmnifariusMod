using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace OmnifariusMod.Items.Weapons
{
    public class DaedalusStaff : ModItem
    {
        public override void SetDefaults()
        {
            base.SetDefaults();
            item.name = "Daedalus Staff";
            item.useStyle = 5;
            item.useTime = 18;
            item.useAnimation = 18;
            item.magic = true;
            item.mana = 6;
            item.damage = 46;
            item.shoot = mod.ProjectileType("MagicArrow");
            item.width = 64;
            item.height = 64;
            item.scale = 1f;
            item.noMelee = true;
            item.autoReuse = true;
            item.shootSpeed = 6f;
            Item.staff[item.type] = true;
            item.rare = 6;
        }
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            Vector2 mouse = new Vector2(Main.mouseX, Main.mouseY) + Main.screenPosition;
            Projectile.NewProjectile(mouse.X + Main.rand.Next(-40, 40), player.Center.Y - 650 + Main.rand.Next(-50, 50), 0, 20, mod.ProjectileType("MagicArrow"), damage, knockBack, player.whoAmI);
            Projectile.NewProjectile(mouse.X + Main.rand.Next(-40, 40), player.Center.Y - 650 + Main.rand.Next(-50, 50), 0, 20, mod.ProjectileType("MagicArrow"), damage, knockBack, player.whoAmI);
            Projectile.NewProjectile(mouse.X + Main.rand.Next(-40, 40), player.Center.Y - 650 + Main.rand.Next(-50, 50), 0, 20, mod.ProjectileType("MagicArrow"), damage, knockBack, player.whoAmI);
            Projectile.NewProjectile(mouse.X + Main.rand.Next(-40, 40), player.Center.Y - 650 + Main.rand.Next(-50, 50), 0, 20, mod.ProjectileType("MagicArrow"), damage, knockBack, player.whoAmI);
            return false;
        }
    }
}