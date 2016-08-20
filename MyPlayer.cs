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
        int magicHit = 0;

        public override void ResetEffects()
        {
            minionName = false;
            Pet = false;
        }
        public override void OnHitAnything(float x, float y, Entity victim)
        {
            if (ConduitArmour == true)
            {
                magicHit += 1;

                if (magicHit >= 6)
                {
                    Vector2 vel = new Vector2(5, 0).RotatedBy(player.DirectionTo(Main.MouseWorld).ToRotation());
                    Projectile.NewProjectile(player.Center.X, player.Center.Y, vel.X, vel.Y, mod.ProjectileType("MagicArrow"), 23, 0f, Main.myPlayer, 0f, 1f);
                    magicHit = 0;
                }
            }
        }
    }
}