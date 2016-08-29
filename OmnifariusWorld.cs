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
                progress.Message = "Fire-ifying the world\n\n\n";
                progress.Set(0.7f);
                int rand1 = Main.spawnTileX + (Main.rand.Next(220, 550));
                int rand2 = Main.spawnTileY + (Main.rand.Next(-20, 50));
                for (int i = 0; i < Main.rand.Next(70, 76); i++)
                {
                    if (Main.tile[rand1, rand2].type != -1)
                    {
                        WorldGen.TileRunner(rand1, rand2, Main.rand.Next(8, 10), Main.rand.Next(1, 3), mod.TileType("PetrifiedStoneTile"), false, 0f, 0f, true, true);
                    }
                }
                for (int i = 0; i < 3; i++)
                {
                    MakeVolcano(rand1 + Main.rand.Next(-100, 100), rand2);
                }
                /**/
                for (int i = rand1; i < rand1 + 200; i++)
                {
                    for (int k = rand2; k < rand2 + 200; k++)
                    {
                        if (Main.tile[i, k].type != -1)
                        {
                            if (Main.tile[i, k].type == 1)
                            {
                                Main.tile[i, k].type = (ushort)mod.TileType("PetrifiedStoneTile");
                            }
                            if (Main.tile[i, k].type == 2)
                            {
                                Main.tile[i, k].type = (ushort)mod.TileType("FlamingGrass");
                            }
                            if (Main.tile[i, k].type == 53)
                            {
                                Main.tile[i, k].type = (ushort)mod.TileType("BurntSand");
                            }
                        }
                    }
                }
            }));
        }

        public void MakeVolcano(int X, int Y)
        {// WorldGen.TileRunner(Main.spawnTileX + 376, Main.spawnTileY + -15, 6, Main.rand.Next(1, 3), mod.TileType("PetrifiedStoneTile"), true, 0f, 0f, true, true);
            WorldGen.TileRunner(X, Y - 10, 6, Main.rand.Next(1, 3), mod.TileType("PetrifiedStoneTile"), true, 0f, 0f, true, true);
            WorldGen.TileRunner(X, Y - 5, 8, Main.rand.Next(1, 3), mod.TileType("PetrifiedStoneTile"), true, 0f, 0f, true, true);
            WorldGen.TileRunner(X, Y, 10, Main.rand.Next(1, 3), mod.TileType("PetrifiedStoneTile"), true, 0f, 0f, true, true);
            WorldGen.TileRunner(X, Y + 5, 12, Main.rand.Next(1, 3), mod.TileType("PetrifiedStoneTile"), true, 0f, 0f, true, true);
            WorldGen.TileRunner(X, Y + 10, 26, Main.rand.Next(1, 3), mod.TileType("PetrifiedStoneTile"), true, 0f, 0f, true, true);
            WorldGen.TileRunner(X, Y + 15, 30, Main.rand.Next(1, 3), mod.TileType("PetrifiedStoneTile"), true, 0f, 0f, true, true);
            WorldGen.TileRunner(X, Y + 20, 36, Main.rand.Next(1, 3), mod.TileType("PetrifiedStoneTile"), true, 0f, 0f, true, true);
            WorldGen.TileRunner(X, Y + 25, 44, Main.rand.Next(1, 3), mod.TileType("PetrifiedStoneTile"), true, 0f, 0f, true, true);
            WorldGen.TileRunner(X, Y + 30, 52, Main.rand.Next(1, 3), mod.TileType("PetrifiedStoneTile"), true, 0f, 0f, true, true);

            WorldGen.digTunnel(X, Y, 0, 10, 5, 2, false);

        }
    }
}
