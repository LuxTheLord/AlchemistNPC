using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

namespace AlchemistNPC.Items.Armor
{
	[AutoloadEquip(EquipType.Body)]
	public class TwilightSuit : ModItem
	{
		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("Twilight Suit (O-02-63)");
			DisplayName.AddTranslation(GameCulture.Russian, "Сумеречный Костюм (O-02-63)"); 
			Tooltip.SetDefault("'Efforts of three birds to defeat the beast became one."
				+ "\nIt could stop countless incidents but you’d have to be prepared to step into the Black Forest.'"
				+ "\n[c/FF0000:EGO armor piece]"
				+ "\n+200 maximum HP"
				+ "\n+20% damage reduction"
				+ "\nImmune to most vanilla debuffs");
			Tooltip.AddTranslation(GameCulture.Russian, "Усилия трёх птиц, чтобы одолеть Зверя, став едиными.\nОно способно остановить бесчисленные несчастные случаи.\nНо вам нужно быть готовыми, чтобы войти в Тёмный Лес.\n[c/FF0000:Э.П.О.С часть брони]\n+200 к максимальному здоровью\n+20% к поглощению урона\nИммунитет к большинству немодовых дебаффов");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = 1000000;
			item.rare = 12;
			item.defense = 40;
		}

		public override void UpdateEquip(Player player)
		{
			player.statLifeMax2 += 200;
			player.endurance += 0.2f;
			player.buffImmune[46] = true;
            player.noKnockback = true;
            player.fireWalk = true;
            player.buffImmune[33] = true;
            player.buffImmune[36] = true;
            player.buffImmune[30] = true;
            player.buffImmune[20] = true;
            player.buffImmune[32] = true;
            player.buffImmune[31] = true;
            player.buffImmune[35] = true;
            player.buffImmune[23] = true;
            player.buffImmune[22] = true;
			player.buffImmune[24] = true;
			player.buffImmune[39] = true;
			player.buffImmune[44] = true;
			player.buffImmune[46] = true;
			player.buffImmune[47] = true;
			player.buffImmune[69] = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "JustitiaSuit");
			recipe.AddIngredient(ItemID.AnkhShield);
			recipe.AddIngredient(null, "EmagledFragmentation", 200);
			recipe.AddTile(null, "WingoftheWorld");
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}