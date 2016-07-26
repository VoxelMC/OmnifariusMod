using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OmnifariusMod.Projectiles
{
    public class PetName : ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.CloneDefaults(ProjectileID.ZephyrFish);
            projectile.name = "Cool Pet";
            aiType = ProjectileID.ZephyrFish;
            Main.projFrames[projectile.type] = 4;
            Main.projPet[projectile.type] = true;
            projectile.light = 1f;
            Lighting.AddLight((int)(projectile.Center.X / 16f), (int)(projectile.Center.Y / 16f), 0.6f, 0.9f, 0.3f);
        }
        public Color GetColor()
        {
            return new Color(255, 2, 2);
        }
        
        public override bool PreAI()
        {
            Player player = Main.player[projectile.owner];
            player.zephyrfish = false;
            return true;
        }

        public override void AI()
        {
            Player player = Main.player[projectile.owner];
            MyPlayer modPlayer = player.GetModPlayer<MyPlayer>(mod);
            if (player.dead)
            {
                modPlayer.Pet = false;
            }
            if (modPlayer.Pet)
            {
                projectile.timeLeft = 2;
            }
        }
    }
}