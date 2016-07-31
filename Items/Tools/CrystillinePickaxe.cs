using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OmnifariusMod.Items.Tools
{
    public class CrystillinePickaxe : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Cristilline Pickaxe";
            item.damage = 25;
            item.melee = true;
            item.width = 2;
            item.height = 14;
            item.useTime = 8;
            item.useAnimation = 25;
            item.useStyle = 1;
            item.knockBack = 6;
            item.value = Item.sellPrice(0, 4, 0, 0);
            item.rare = 8;
            item.useSound = 1;
            item.autoReuse = true;
            item.scale = 0.9f;
            item.pick = 185;
        }
    }
}
