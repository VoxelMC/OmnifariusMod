using System;

using Microsoft.Xna.Framework;

using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Graphics.Shaders;

namespace OmnifariusMod.Tests
{
    public class ENHelmet : ModItem
    {
        public override bool Autoload(ref string name, ref string texture, System.Collections.Generic.IList<EquipType> equips)
        {
            equips.Add(EquipType.Head);
            return true;
        }

        public override void SetDefaults()
        {
            item.name = "EN Helmet";
            item.width = 20; item.height = 12;
            item.toolTip = "???";
            item.scale = 0.7f;
        }

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return body.type == mod.ItemType("ENBreastplate") && legs.type == mod.ItemType("ENLeggings");
        }
        public override void UpdateArmorSet(Player player)
        {
            //Dust Effects
            /*if (Math.Abs(player.velocity.X) + Math.Abs(player.velocity.Y) > 1f && !player.rocketFrame)
            {
                for (int i = 0; i < 2; ++i)
                {
                    Dust newDust = Main.dust[Dust.NewDust(new Vector2(player.position.X - player.velocity.X * 2f, player.position.Y - 2f - player.velocity.Y * 2f), player.width, player.height, 6, 0f, 0f, 100, default(Color), 2f)];
                    newDust.noGravity = true;
                    newDust.noLight = true;
                    newDust.velocity.X = newDust.velocity.X - player.velocity.X * 0.5f;
                    newDust.velocity.Y = newDust.velocity.Y - player.velocity.Y * 0.5f;
                    newDust.shader = GameShaders.Armor.GetSecondaryShader(player.ArmorSetDye(), player);
                }
            }*/
            player.AddBuff(mod.BuffType("ENBuff"), -1, true);
            player.GetModPlayer<MyPlayer>(mod).ENSet = true;
        }

        public override void AddRecipes()
        {
            // ???
        }
        public override void UpdateEquip(Player player)
        {
            player.meleeSpeed += 0.12f;
            player.thrownDamage += 0.12f;
        }
    }
}
