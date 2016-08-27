using System;

using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OmnifariusMod.Buffs
{
    public class SeraphineDebuff : ModBuff
    {
        public override void SetDefaults()
        {
            Main.buffName[Type] = "Seraphine";
            Main.debuff[Type] = true;
        }

        public override void Update(NPC npc, ref int buffIndex)
        {
            if (npc.lifeRegen > 0)
                npc.lifeRegen = 0;
            npc.lifeRegen -= 10;
        }
    }
}
