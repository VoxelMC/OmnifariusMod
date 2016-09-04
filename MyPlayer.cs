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
        public bool ConduitArmour;
        int magicHit = 0;
        public bool infernalSet;
        public bool ENSet;

        public override void ResetEffects()
        {
            minionName = false;
            Pet = false;
            infernalSet = false;
            ConduitArmour = false;
            infernalSet = false;
            ENSet = false;
        }
        public override void OnHitNPC(Item item, NPC target, int damage, float knockback, bool crit)
        {
            if (infernalSet == true)
            {
                target.AddBuff(mod.BuffType("SeraphineDebuff"), 300); // Lasts 5 seconds.
            }
        }
        public override void OnHitNPCWithProj(Projectile proj, NPC target, int damage, float knockback, bool crit)
        {
            if (ConduitArmour == true)
            {
                if (proj.magic)
                {
                    magicHit += 1;
                }

                if (magicHit >= 6)
                {
                    Vector2 vel = new Vector2(16, 0).RotatedBy(player.DirectionTo(Main.MouseWorld).ToRotation());
                    Projectile.NewProjectile(player.Center.X, player.Center.Y, vel.X, vel.Y, mod.ProjectileType("MartianBolt"), 40, 0f, Main.myPlayer, 0f, 1f);
                    magicHit = 0;
                    Main.PlaySound(2, (int)player.position.X, (int)player.position.Y, 91);
                }
            }
        }

        //Test Zone
        /*private void ENSet(ref int damage, ref bool crit)
        {
            if (crit)
            {
                damage = (int)(damage * critDmgMult);
            }
        }

        public override void ModifyHitNPC(Item item, NPC target, ref int damage, ref float knockback, ref bool crit)
        {
            ENSet(ref damage, ref crit);
        }

        public override void ModifyHitNPCWithProj(Projectile proj, NPC target, ref int damage, ref float knockback, ref bool crit)
        {
            ENSet(ref damage, ref crit);
        }

        public override void ModifyHitPvp(Item item, Player target, ref int damage, ref bool crit)
        {
            ENSet(ref damage, ref crit);
        }

        public override void ModifyHitPvpWithProj(Projectile proj, Player target, ref int damage, ref bool crit)
        {
            ENSet(ref damage, ref crit);
        }
        */
    }
}