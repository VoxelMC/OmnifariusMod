using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;
using Terraria.ID;
using Terraria.ModLoader;
//Make sure your item file is the same name as your .png file!
namespace TArmory.Items.Weapons // <------------------------------<
{                                                              //^^^
    public class Inserthere : ModItem //Remember to change the Namespace and Class before building your mod.
    {
        public override void SetDefaults()
        {
            item.name = ""; //Name of the weapon
            item.damage = 1; //How much base damage does the weapon have?
            item.melee = true; //Is the item Melee? ---v
            item.magic = true; //Is the item Magic? ------------> true/false
            item.ranged = true; //Is the item Ranged? ---^
            item.width = 1; //Hitbox X
            item.height = 1; //Hitbox Y
            item.toolTip = "Aint this a purdy tooltip"; //Displays a tooltip
            item.useTime = 20; //Cooldown for using the weapon
            item.useAnimation = 20; //How long the use animation lasts
            item.useStyle = 1; //How the weapon is used ingame
            item.knockBack = 1; //Knockback value
            item.value = Item.sellPrice(0, 0, 0, 0);
            item.rare = 1; //Color of item name
            item.useSound = 1; //Plays specified sound when used
            item.autoReuse = true; //Autoswing, true/false
            item.scale = 1f; //Size
            item.shoot = mod.ProjectileType("ProjectileName"); //Shoots a projectile from your mod
            item.shootSpeed = 8; //Speed of the projectile
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Obsidian, 1); //Adds a vanilla item to the crafting recipe and identifies how many
            recipe.AddIngredient(null, "ObsidianBar", 1); //Adds a modded item to the crafting recipe and identifies how many
            recipe.AddTile(TileID.Furnaces); //What workstation the item is crafted at
            recipe.SetResult(this, 1); //What is the result of this recipe, and how many
            recipe.AddRecipe();
        }
    }
}
//##########################################################################################
//# Made by VoxelMC, check out my mod!                                                     #
//# Find it here: http://forums.terraria.org/index.php?threads/terrarian-armory.46188/     #
//##########################################################################################