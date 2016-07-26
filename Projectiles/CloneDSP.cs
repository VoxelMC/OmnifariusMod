using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OmnifariusMod.Projectiles
{
    public class CloneDSP : ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.CloneDefaults(ProjectileID.DeathSickle);
            projectile.name = "Death Sickle";
            aiType = ProjectileID.DeathSickle;      

        }

    }
}