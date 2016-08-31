using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System.Collections.Generic;
using Terraria.World.Generation;
using Terraria.GameContent.Generation;

namespace OmnifariusMod.Tiles
{
	public class FlamingGrass : ModTile
	{
		public override void SetDefaults()
		{
			Main.tileSolid[Type] = true;
			Main.tileMergeDirt[Type] = true;
			Main.tileLighted[Type] = true;
			AddMapEntry(new Color(250, 100, 100));

            Main.tileMerge[Type][mod.TileType("FlamingGrass")] = true;
            Main.tileMerge[Type][mod.TileType("FlamingGrass")] = true;
            //Main.tileBlockLight[Type] = true;
            Main.tileLighted[Type] = true;
            //drop = ItemID.MudBlock;
		}
    }
}