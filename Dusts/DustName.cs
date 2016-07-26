using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace OmnifariusMod.Dusts
{
    public class DustName : ModDust
    {
        public override void OnSpawn(Dust dust)
        {
            dust.color = new Color(200, 10, 25);  
            dust.alpha = 1;
            dust.scale = 1.13f;
            dust.velocity *= 1.4f;
            dust.noGravity = true;
            dust.noLight = false;
        }

        public override bool Update(Dust dust)
        {
            dust.position += dust.velocity;
            dust.rotation += dust.velocity.X * 0.15f;
            dust.scale *= 0.99f;                    
            float light = 0.35f * dust.scale;
            Lighting.AddLight(dust.position, light, light, light);
            if (dust.scale < 0.5f)
            {
                dust.active = false;
            }
            return false;
        }
    }
}