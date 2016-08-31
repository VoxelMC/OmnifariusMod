using System.IO;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.World.Generation;
using Microsoft.Xna.Framework;
using Terraria.GameContent.Generation;

namespace OmnifariusMod
{
    public class OmnifariusWorld : ModWorld
    {
        int digTunnelX = 0;
        int digTunnelY = 0;

        public override void ModifyWorldGenTasks(List<GenPass> tasks, ref float totalWeight)
        {
            int genIndex = tasks.FindIndex(genpass => genpass.Name.Equals("Micro Biomes"));

            /*int iceBiome = tasks.FindIndex(genpass => genpass.Name.Equals("Slush Check"));//IDK what the name is. Might have to change it later.
            tasks[iceBiome] = new PassLegacy("Inferno", delegate (GenerationProgress progress)*/

            tasks.Insert(genIndex + 1, new PassLegacy("The Inferno", delegate (GenerationProgress progress)
            {
                progress.Message = "reking Vax, he was EZPZ";
                progress.Set(0.7f);
                int rand1 = Main.spawnTileX + (Main.rand.Next(300, 550));
                int rand2 = Main.spawnTileY + (Main.rand.Next(-20, 50));
                for (int i = 0; i < Main.rand.Next(70, 76); i++)
                {
                    if (Main.tile[rand1, rand2].type != -1)
                    {
                        // WorldGen.TileRunner(rand1, rand2, Main.rand.Next(8, 10), Main.rand.Next(1, 3), mod.TileType("PetrifiedStoneTile"), true, 0f, 0f, true, true);
                        WorldGen.TileRunner(rand1, rand2, 1.1, Main.rand.Next(1, 3), mod.TileType("BurntSandTile"), false, 0f, 0f, true, true);
                    }
                }
                for (int i = 0; i < 3; i++)
                {
                    int random = Rand(0, 200);
                    int placeVolcanoCheckX = (rand1 + random) + i * 20;
                    int placeVolcanoCheckY = (rand2 + Rand(-50, 50));
                    if (Main.tile[placeVolcanoCheckX, placeVolcanoCheckY].type != -1)
                        MakeVolcano(placeVolcanoCheckX, placeVolcanoCheckY);
                }
                
                for (int i = rand1 - 100; i < rand1 + 500; i++)
                {
                    for (int k = rand2 - 80; k < rand2 + 400; k++)
                    {
                        if (Main.tile[i, k].type != -1)
                        {
                            if (Main.tile[i, k].type == 1 || Main.tile[i, k].type == 25 || Main.tile[i, k].type == 203)
                            {//25 and 203 is corruption/crimson
                                Main.tile[i, k].type = (ushort)mod.TileType("PetrifiedStoneTile");
                            }
                            if (Main.tile[i, k].type == 2)
                            {
                                Main.tile[i, k].type = (ushort)mod.TileType("FlamingGrass");
                            }//397 and 396 is to be removed 
                            if (Main.tile[i, k].type == 53 || Main.tile[i, k].type == 147 || Main.tile[i, k].type == 397 || Main.tile[i, k].type == 396)
                            {
                                Main.tile[i, k].type = (ushort)mod.TileType("BurntSandTile");
                            }
                            if (Main.tile[i, k].type == 161)
                            {
                                Main.tile[i, k].type = (ushort)mod.TileType("FireIce");
                            }
                            if (Main.tile[i, k].type == 162)
                            {
                                WorldGen.KillTile(i, k);
                            }
                            //Main.tile[i, k].wall = mod.TileType("InfernoWall");
                        }
                        Main.tile[i, k].liquid = 0;
                    }
                }
                for (int i = 0; i < Rand(20, 30); i++)
                {
                    LavaPocket(rand1 + Rand(-90, 500), rand2 + Rand(-20, 400), Main.rand.Next(13, 19));
                }
            }));
        }

        public void MakeVolcano(int X, int Y)
        {// WorldGen.TileRunner(Main.spawnTileX + 376, Main.spawnTileY + -15, 6, Main.rand.Next(1, 3), mod.TileType("PetrifiedStoneTile"), true, 0f, 0f, true, true);
            ////digTunnel(float X, float Y, float xDir, float yDir, int Steps, int Size, bool Wet = false)
            WorldGen.TileRunner(X, Y - 10, 9, Main.rand.Next(1, 3), mod.TileType("PetrifiedStoneTile"), true, 0f, 0f, true, true);
            WorldGen.TileRunner(X, Y - 5, 10, Main.rand.Next(1, 3), mod.TileType("PetrifiedStoneTile"), true, 0f, 0f, true, true);
            WorldGen.TileRunner(X, Y, 11, Main.rand.Next(1, 3), mod.TileType("PetrifiedStoneTile"), true, 0f, 0f, true, true);
            WorldGen.TileRunner(X, Y + 5, 12, Main.rand.Next(1, 3), mod.TileType("PetrifiedStoneTile"), true, 0f, 0f, true, true);
            WorldGen.TileRunner(X, Y + 10, 26, Main.rand.Next(1, 3), mod.TileType("PetrifiedStoneTile"), true, 0f, 0f, true, true);
            WorldGen.TileRunner(X, Y + 17, 30, Main.rand.Next(1, 3), mod.TileType("PetrifiedStoneTile"), true, 0f, 0f, true, true);
            WorldGen.TileRunner(X, Y + 24, 36, Main.rand.Next(1, 3), mod.TileType("PetrifiedStoneTile"), true, 0f, 0f, true, true);
            WorldGen.TileRunner(X, Y + 32, 44, Main.rand.Next(1, 3), mod.TileType("PetrifiedStoneTile"), true, 0f, 0f, true, true);
            for (int l = 0; l < 3; l++)
                WorldGen.TileRunner(X, Y + 39 + (l * 8), 52, Main.rand.Next(1, 3), mod.TileType("PetrifiedStoneTile"), true, 0f, 0f, true, true);
            for (int l = 0; l < 6; l++)
                WorldGen.TileRunner(X, Y + 59 + (l * 8), 60, Main.rand.Next(1, 3), mod.TileType("PetrifiedStoneTile"), true, 0f, 0f, true, true);
            for (int i = 0; i < 20; i++)
                WorldGen.digTunnel(X, Y - 10 + (i * 10), 0, 0, 6, 10, false);
        }


        /// <summary>
        /// Adds pockets of lava at the X and Y. Size defaults to 10.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="size"></param>
        public void LavaPocket(int x, int y, int size = 10)
        {
            for (int i = x - 10; i < x + 10; i++)
            {
                for (int k = y - 10; k < y + 10; k++)
                {
                        Main.tile[i, k].liquidType(1);
                        Main.tile[i, k].liquid = 255;
                        WorldGen.SquareTileFrame(i, k, true);
                }
            }
        }

        private int Rand(int Min, int Max)
        {
            return Main.rand.Next(Min, Max);
        }//For OCD. I hate long Main.rands. 
    }
}
