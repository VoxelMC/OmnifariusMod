using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OmnifariusMod.NPCs
{
    public class NPCTown : ModNPC
    {
        public override bool Autoload(ref string name, ref string texture)
        {
            name = "NPCTown";
            return mod.Properties.Autoload;
        }
        public override void SetDefaults()
        {
            npc.name = "Cool NPC";
            npc.townNPC = true;
            npc.friendly = true;
            npc.width = 18;
            npc.height = 40;
            npc.aiStyle = 7;
            npc.damage = 10;
            npc.defense = 15;
            npc.lifeMax = 250;
            npc.soundHit = 1;
            npc.soundKilled = 1;
            npc.knockBackResist = 0.5f;
            Main.npcFrameCount[npc.type] = 25;            
            animationType = NPCID.Guide;
        }
        public override bool CanTownNPCSpawn(int numTownNPCs, int money)
        {
			
            return false;// this make that he will spawn when a house is available
        }



        public override string TownNPCName()
        {										//NPC names
            switch (WorldGen.genRand.Next(4))
            {
                case 0:
                    return "Blue";
                case 1:
                    return "Blu";
                case 2:
                    return "Azul";
                default:
                    return "Bleu";
            }
        }




        public override string GetChat()
        { 											//npc chat 
          
            switch (Main.rand.Next(3))
            {
                case 0:
                    return "Kappa";
                case 1:
                    return "I'm Blue Da Ba Dee Da Ba Die.";
                default:
                    return "Hello!";
            }
        }

        public override void SetChatButtons(ref string button, ref string button2)
        {
            button = Lang.inter[28];
        }

        public override void OnChatButtonClicked(bool firstButton, ref bool shop)
        {
            if (firstButton)
            {
                shop = true;
            }
        }

        public override void SetupShop(Chest shop, ref int nextSlot)
        {
            shop.item[nextSlot].SetDefaults(mod.ItemType("AxeName")); //items that he sells
            nextSlot++;
			shop.item[nextSlot].SetDefaults(mod.ItemType("YourSword")); 
            nextSlot++;
			shop.item[nextSlot].SetDefaults (ItemID.LunarBar); 
            nextSlot++;
        }

    }
}