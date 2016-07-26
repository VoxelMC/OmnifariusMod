using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OmnifariusMod.Projectiles
{
    public class CrystalStormProjectile : ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.name = "CrystalTempestProjectile";
            projectile.width = 16;
            projectile.height = 16;
            projectile.friendly = true;
            projectile.magic = true;
            projectile.aiStyle = 21;
            projectile.penetrate = -1;
            projectile.timeLeft = 60;
            projectile.light = 0.3f;
            Main.projFrames[mod.ProjectileType("CrystalStormProjectile")] = 8;
            projectile.scale = 1.2f;
        }
        public override void AI()
        {
            projectile.velocity.Y += projectile.ai[0];
            if (Main.rand.Next(3) == 0)
            {
                projectile.rotation = (float)Math.Atan2(projectile.velocity.Y, projectile.velocity.X) + 1.57f;
            }
            {
                Dust.NewDust(projectile.position + projectile.velocity, projectile.width, projectile.height, 219, projectile.velocity.X * 0.5f, projectile.velocity.Y * 0.5f);
            }
        }
        public override void Kill(int timeLeft)
        {
            Main.PlaySound(2, (int)projectile.position.X, (int)projectile.position.Y, 10);
            Dust.NewDust(projectile.position + projectile.velocity, projectile.width, projectile.height, 219, projectile.velocity.X * 0.5f, projectile.velocity.Y * 0.5f);
        }
    }
}