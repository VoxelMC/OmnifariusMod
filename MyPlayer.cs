using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace OmnifariusMod
{
    public class MyPlayer : ModPlayer
    {
        private const int saveVersion = 0;
        public bool minionName = false;
        public bool Pet = false;
        public static bool hasProjectile;
        public bool ConduitArmour = false;

        public override void ResetEffects()
        {
            minionName = false;
            Pet = false;
        }
        public override void OnHitAnything(float x, float y, Entity victim)
        {
            if (ConduitArmour == true)
            {
                int magicHit = 0;
                magicHit += 1;

                if (magicHit >= 5)
                {
                    Projectile.NewProjectile(player.Center, velocity.X, velocity.Y, ProjectileID.HeatRay, 80, projectile.owner, 0, 0f);
                    magicHit = 0;
                }
            }
            return false;
        }
    }
}