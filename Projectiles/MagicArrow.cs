using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using System;
using System.IO;

namespace OmnifariusMod.Projectiles
{
    public class MagicArrow : ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.penetrate = 1;
            projectile.width = 24;
            projectile.height = 26;
            projectile.friendly = true;
            projectile.light = 1.5f;
            projectile.tileCollide = false;
            projectile.timeLeft = 90;
        }
        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
        {
            projectile.Kill();
            for (int k = 0; k < 5; k++)
            {
                Dust.NewDust(projectile.position + projectile.velocity, projectile.width, projectile.height, 15, projectile.oldVelocity.X * 0.5f, projectile.oldVelocity.Y * 0.5f);
            }
        }
        public override bool OnTileCollide(Vector2 oldVelocity)
        {
            projectile.penetrate--;
            projectile.Kill();
            if (projectile.penetrate == 1)
            {
                Main.PlaySound(2, (int)projectile.position.X, (int)projectile.position.Y, 10);
                Dust.NewDust(projectile.position + projectile.velocity, projectile.width, projectile.height, 15);
                Dust.NewDust(projectile.position + projectile.velocity, projectile.width, projectile.height, 15);
                Dust.NewDust(projectile.position + projectile.velocity, projectile.width, projectile.height, 15);
                projectile.Kill();
            }
            else
            {
                projectile.ai[0] += 0.1f;
                if (projectile.velocity.X != oldVelocity.X)
                {
                    projectile.velocity.X = -oldVelocity.X;
                }
                if (projectile.velocity.Y != oldVelocity.Y)
                {
                    projectile.velocity.Y = -oldVelocity.Y;
                }
                projectile.velocity *= 0.75f;
                Main.PlaySound(2, (int)projectile.position.X, (int)projectile.position.Y, 10);
                Dust.NewDust(projectile.position + projectile.velocity, projectile.width, projectile.height, 15);
                Dust.NewDust(projectile.position + projectile.velocity, projectile.width, projectile.height, 15);
                Dust.NewDust(projectile.position + projectile.velocity, projectile.width, projectile.height, 15);
            }
            return false;
        }
        public override void PostAI()
        {
            base.PostAI();
            if (projectile.timeLeft <= 60)
            {
                projectile.tileCollide = true;
            }
        }
    }
}