using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OmnifariusMod.Projectiles
{
    public class MartianBolt : ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.name = "Martian Bolt";
            projectile.width = 14;
            projectile.height = 38;
            projectile.friendly = true;
            projectile.magic = true;
            projectile.penetrate = 1;
            projectile.timeLeft = 600;
            Main.projFrames[projectile.type] = 2;
        }

        public override void AI()
        {
            projectile.velocity.Y += projectile.ai[0];
            {
                projectile.rotation = (float)Math.Atan2(projectile.velocity.Y, projectile.velocity.X) + 1.57f;
            }
            if (projectile.velocity.X > 0)
            {
                projectile.frame = 0;
            }
            else
            {
                projectile.frame = 1;
            }
        }


        public override bool OnTileCollide(Vector2 oldVelocity)
        {
            projectile.Kill();
            Main.PlaySound(2, (int)projectile.position.X, (int)projectile.position.Y, 91);
            return false;
        }


        public override void Kill(int timeLeft)
        {
            Main.PlaySound(2, (int)projectile.position.X, (int)projectile.position.Y, 91);
        }

        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
        {   
            target.AddBuff(BuffID.Electrified, 180);
        }
    }
}