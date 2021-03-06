using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

namespace AlchemistNPC.Items
{
    public class SpecCraftPoint : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Special Crafting Point");
            Tooltip.SetDefault("You've proven that you can do anything with any material");
            DisplayName.AddTranslation(GameCulture.Russian, "СпецКрафтрвый Поинт");
            Tooltip.AddTranslation(GameCulture.Russian, "Вы доказали, что можете сделать что угодно с любым материалом");
        }

        public override void SetDefaults()
        {

            item.width = 24;
            item.height = 24;
            item.maxStack = 1;
            item.value = 5000000;
            item.rare = 7;
        }

        public override void AddRecipes()
        {
        ModRecipe recipe = new ModRecipe(mod);
        recipe.AddIngredient(ItemID.HoneyDispenser);
		recipe.AddIngredient(ItemID.SteampunkBoiler);
		recipe.AddIngredient(ItemID.FleshCloningVaat);
		recipe.AddIngredient(ItemID.SkyMill);
		recipe.AddIngredient(ItemID.Solidifier);
		recipe.AddIngredient(ItemID.Keg);
		recipe.AddIngredient(ItemID.IceMachine);
		recipe.AddIngredient(ItemID.GlassKiln);
        recipe.AddIngredient(ItemID.LivingLoom);
		recipe.AddIngredient(ItemID.BoneWelder);
		recipe.AddIngredient(ItemID.WaterBucket);
		recipe.AddIngredient(ItemID.LavaBucket);
		recipe.AddIngredient(ItemID.HoneyBucket);
		recipe.AddTile(TileID.CrystalBall);
        recipe.SetResult(this, 1);
        recipe.AddRecipe();
        }
    }
}
