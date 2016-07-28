using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OmnifariusMod.Items.Tools
{
    public class CrystillineAxe : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Cristilline Axe";
            item.damage = 98;
            item.melee = true;
            item.width = 10;
            item.height = 50;
            item.toolTip = "Watch out, it's a bit spiky!";
            item.useTime = 36;
            item.useAnimation = 36;
            item.useStyle = 1;
            item.knockBack = 6;
            item.value = Item.sellPrice(0, 4, 0, 0);
            item.rare = 8;
            item.useSound = 1;
            item.autoReuse = true;
            item.scale = 1.2f;
            item.axe = 25;
        }
    }
}