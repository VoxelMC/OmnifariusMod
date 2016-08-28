using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OmnifariusMod.Items.Weapons
{
    public class TantalumSniper : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Tantalum Sniper Rifle";
            item.damage = 120;
            item.ranged = true;
            item.width = 40;
            item.height = 20;
            item.useTime = 38;
            item.useAnimation = 38;
            item.useStyle = 5;
            item.noMelee = true; 
            item.knockBack = 7;
            item.value = 10000;
            item.rare = 2;
            item.useSound = 40;
            item.autoReuse = true;
            item.shoot = 10; 
            item.shootSpeed = 16f;
            item.useAmmo = ProjectileID.Bullet;
        }

        public override void AddRecipes()
        {
            //tbd
        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            if (type == ProjectileID.Bullet) // or ProjectileID.WoodenArrowFriendly
            {
                type = ProjectileID.BulletHighVelocity; // or ProjectileID.FireArrow;
            }
            return true; // return true to allow tmodloader to call Projectile.NewProjectile as normal
        }
    }
}
           