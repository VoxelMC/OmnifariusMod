using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

                                                            //By Al0n37
namespace OmnifariusMod.NPCs
{
    public class NpcName : ModNPC
    {
        public override void SetDefaults()
        {
            npc.name = "Monster";
            npc.displayName = "Monster";
            npc.width = 50;
            npc.height = 40;
            npc.damage = 10;
            npc.defense = 10;
            npc.lifeMax = 200;
            npc.soundHit = 1;
            npc.soundKilled = 13;
            npc.value = 60f;
            npc.knockBackResist = 0.5f;
            npc.aiStyle = 44;
            Main.npcFrameCount[npc.type] = 3; 
            aiType = NPCID.Harpy;  //npc behavior
            animationType = NPCID.Harpy;
        }
        
        public override float CanSpawn(NPCSpawnInfo spawnInfo)
        {
            Tile tile = Main.tile[spawnInfo.spawnTileX, spawnInfo.spawnTileY];
            return spawnInfo.player.ZoneCorrupt ? 0.5f : 0f; 
        }
        public override void FindFrame(int frameHeight)
        {
            npc.frameCounter -= 0.5F; // Determines the animation speed. Higher value = faster animation.
            npc.frameCounter %= Main.npcFrameCount[npc.type];
            int frame = (int)npc.frameCounter;
            npc.frame.Y = frame * frameHeight;

            npc.spriteDirection = npc.direction;
        }
        public override void NPCLoot()  //Npc drop
        {
            if (Main.rand.Next(100) == 0)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("ItemName"), 2); //Item spawn
            }

        }
    }
}