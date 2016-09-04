using System;

using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework.Graphics;

namespace OmnifariusMod.Buffs
{
    public class ENBuff : ModBuff
    {
        public override void SetDefaults()
        {
            Main.buffName[Type] = "Seraphine";
            Main.debuff[Type] = true;
            Main.buffTip[Type] = "Increases Melee Speed and Throwing Velocity by 50%";
        }

        public override void Update(Player player, ref int buffIndex)
        {
            base.Update(player, ref buffIndex);
            player.meleeSpeed += 0.50f;
            player.thrownVelocity += 0.50f;
        }
    }
}
