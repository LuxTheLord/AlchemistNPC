using System.Linq;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Utilities;
using Terraria.Localization;
 
namespace AlchemistNPC.NPCs
{
	[AutoloadHead]
	public class Alchemist : ModNPC
	{
		public static bool baseShop = false;
		public override string Texture
		{
			get
			{
				return "AlchemistNPC/NPCs/Alchemist";
			}
		}

		public override bool Autoload(ref string name)
		{
			name = "Alchemist";
			return mod.Properties.Autoload;
		}
		
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Alchemist");
			DisplayName.AddTranslation(GameCulture.Russian, "Алхимик");
            Main.npcFrameCount[npc.type] = 23;   
			NPCID.Sets.AttackFrameCount[npc.type] = 2;
			NPCID.Sets.DangerDetectRange[npc.type] = 500;
			NPCID.Sets.AttackType[npc.type] = 0;
			NPCID.Sets.AttackTime[npc.type] = 22;
			NPCID.Sets.AttackAverageChance[npc.type] = 30;
			NPCID.Sets.HatOffsetY[npc.type] = -4;
			
		ModTranslation text = mod.CreateTranslation("TremorShop");
		text.SetDefault("Tremor Shop");
		text.AddTranslation(GameCulture.Russian, "Магазин Тремор мода");
		mod.AddTranslation(text);
		text = mod.CreateTranslation("Edward");
		text.SetDefault("Edward");
		text.AddTranslation(GameCulture.Russian, "Эдвард");
		mod.AddTranslation(text);
		text = mod.CreateTranslation("Severus");
		text.SetDefault("Severus");
		text.AddTranslation(GameCulture.Russian, "Северус");
		mod.AddTranslation(text);
		text = mod.CreateTranslation("Horace");
		text.SetDefault("Horace");
		text.AddTranslation(GameCulture.Russian, "Гораций");
		mod.AddTranslation(text);
		text = mod.CreateTranslation("Tilyorn");
		text.SetDefault("Tilyorn");
		text.AddTranslation(GameCulture.Russian, "Тильорн");
		mod.AddTranslation(text);
		text = mod.CreateTranslation("Nicolas");
		text.SetDefault("Nicolas");
		text.AddTranslation(GameCulture.Russian, "Николас");
		mod.AddTranslation(text);
		text = mod.CreateTranslation("Gregg");
		text.SetDefault("Gregg");
		text.AddTranslation(GameCulture.Russian, "Грег");
		mod.AddTranslation(text);
		text = mod.CreateTranslation("EntryA1");
		text.SetDefault("My Healing potions will cure your deepest wounds.");
		text.AddTranslation(GameCulture.Russian, "Мои лечебные зелья излечат твои глубочайшие раны.");
		mod.AddTranslation(text);
		text = mod.CreateTranslation("EntryA2");
		text.SetDefault("My Mana potions will restore your magic power.");
		text.AddTranslation(GameCulture.Russian, "Мои зелья маны восстановят твою магическую силу.");
		mod.AddTranslation(text);
		text = mod.CreateTranslation("EntryA3");
		text.SetDefault("Restoration Potions... don't know if they are good or bad...");
		text.AddTranslation(GameCulture.Russian, "Зелья Восстановления... даже не знаю, хороши они или плохи...");
		mod.AddTranslation(text);
		text = mod.CreateTranslation("EntryA4");
		text.SetDefault("There's a legendary yoyo known as the Sasscade.");
		text.AddTranslation(GameCulture.Russian, "Существует Легендарное Йо-йо, известное как Сасскад.");
		mod.AddTranslation(text);
		text = mod.CreateTranslation("EntryA5");
		text.SetDefault("Strange Brew from Skeleton Merchant smells really terrible but Mana Restoration effect is awesome.");
		text.AddTranslation(GameCulture.Russian, "Странное Варево от Скелета-торговца пахнет просто ужасно, но эффект восстановления маны потрясает.");
		mod.AddTranslation(text);
		text = mod.CreateTranslation("EntryA6");
		text.SetDefault("Hi, *cough*... That definetly wasn't a Teleporation potion.");
		text.AddTranslation(GameCulture.Russian, "Привет, *кашель*... Это определённо было не зелье Телепортации.");
		mod.AddTranslation(text);
		text = mod.CreateTranslation("EntryA7");
		text.SetDefault("Have you seen a Mechanical Skull around?");
		text.AddTranslation(GameCulture.Russian, "Ты не видел Механического Черепа поблизости?");
		mod.AddTranslation(text);
		text = mod.CreateTranslation("EntryA8");
		text.SetDefault("Have you ever heard of Ultra Mushroom? If you find one, I do believe I got some stuff to aid you in boosting that thing.");
		text.AddTranslation(GameCulture.Russian, "Ты слышал об Ультра Грибах? Если ты найдёшь такой, я уверен что я смогу помочь тебе его усилить.");
		mod.AddTranslation(text);
		text = mod.CreateTranslation("EntryA9");
		text.SetDefault("I asked ");
		text.AddTranslation(GameCulture.Russian, "Я попросил у ");
		mod.AddTranslation(text);
		text = mod.CreateTranslation("EntryA10");
		text.SetDefault(" to offer the recipe for the Cactus Extract. He said no, since even an idiot would figure it out.");
		text.AddTranslation(GameCulture.Russian, " рецепт Кактусового Экстракта. Он ответил нет, поскольку даже идиот догадается.");
		mod.AddTranslation(text);
		text = mod.CreateTranslation("EntryA11");
		text.SetDefault("And to think, she's getting the potions and not me... but I can't argue there.");
		text.AddTranslation(GameCulture.Russian, "И только подумать... Она выбрала зелья, а не меня. Хотя я не могу спорить по этому поводу.");
		mod.AddTranslation(text);
		text = mod.CreateTranslation("EntryA12");
		text.SetDefault("What is his name? ");
		text.AddTranslation(GameCulture.Russian, "Как его зовут? ");
		mod.AddTranslation(text);
		text = mod.CreateTranslation("EntryA13");
		text.SetDefault("? So... Teacher's here? Better step up my game!");
		text.AddTranslation(GameCulture.Russian, "? Так... Учитель здесь? Лучше отойди с дороги!");
		mod.AddTranslation(text);
		text = mod.CreateTranslation("EntryA14");
		text.SetDefault("Thank goodness I got those pieces from Skeletron. Want to check it out?");
		text.AddTranslation(GameCulture.Russian, "Слава богу, что я добыл эти кусочки из Скелетрона? Не желаешь посмотреть?");
		mod.AddTranslation(text);
		text = mod.CreateTranslation("EntryA15");
		text.SetDefault("Can you please ask ");
		text.AddTranslation(GameCulture.Russian, "Можешь попросить ");
		mod.AddTranslation(text);
		text = mod.CreateTranslation("EntryA16");
		text.SetDefault(" to stop mocking me? I know my potions can't make you stronger, but at least they aren't as dangerous to drink.");
		text.AddTranslation(GameCulture.Russian, "перестать дразнить меня? Я знаю, что мои зелья не сделают тебя сильнее, но их хотя бы не столь опасно пить.");
		mod.AddTranslation(text);
		text = mod.CreateTranslation("EntryA17");
		text.SetDefault("These goblins are so annoying... Thankfully, they cannot stay here for too long.");
		text.AddTranslation(GameCulture.Russian, "Эти гоблины такие раздражающие... Хорошо, что они не останутся здесь надолго.");
		mod.AddTranslation(text);
		text = mod.CreateTranslation("EntryA18");
		text.SetDefault("You better deal with Pirates as fast, as you can. I can't wait to talk with Captain! Haven't seen him for years!");
		text.AddTranslation(GameCulture.Russian, "Постарайся справиться с Пиратами как можно быстрее. Не могу дождаться, чтобы поговорить с Капитаном! Я не видел его уже много лет!");
		mod.AddTranslation(text);
		text = mod.CreateTranslation("EntryA19");
		text.SetDefault("I hope that you will not let them take into my house, will you?");
		text.AddTranslation(GameCulture.Russian, "Я надеюсь, ты не пустишь их в мой дом, правда?");
		mod.AddTranslation(text);
		text = mod.CreateTranslation("EntryA20");
		text.SetDefault("Maybe you have some better things to do than talk to me right now? It is Blood Moon in the sky!");
		text.AddTranslation(GameCulture.Russian, "Может у тебя найдётся занятие получше, чем говорить со мной сейчас? На небе Кровавая Луна!");
		mod.AddTranslation(text);
		text = mod.CreateTranslation("EntryA21");
		text.SetDefault("...My friend, the best thing to do in this case is not bother me during this time.");
		text.AddTranslation(GameCulture.Russian, "...Мой друг, лучшее, что ты можешь сделать - это не беспокоить меня сейчас.");
		mod.AddTranslation(text);
		text = mod.CreateTranslation("EntryA22");
		text.SetDefault("I have an explosive flask. You do NOT want to know what it taste like.");
		text.AddTranslation(GameCulture.Russian, "У меня есть взрывная колба. Ты точно НЕ хочешь узнать, какова она на вкус.");
		mod.AddTranslation(text);
		text = mod.CreateTranslation("EntryA23");
		text.SetDefault("How can ");
		text.AddTranslation(GameCulture.Russian, "Как ");
		mod.AddTranslation(text);
		text = mod.CreateTranslation("EntryA24");
		text.SetDefault(" stay calm in a time like this? I want to know, NOW.");
		text.AddTranslation(GameCulture.Russian, "может оставаться спокойной в такое время? Я ХОЧУ это узнать.");
		mod.AddTranslation(text);
		}

		public override void SetDefaults()
		{
			npc.townNPC = true;
            npc.friendly = true;
            npc.width = 18;
            npc.height = 40;
            npc.aiStyle = 7;
            npc.damage = 10;
            npc.defense = 100;
            npc.lifeMax = 250;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath1;
            npc.knockBackResist = 0.5f;
			animationType = NPCID.Clothier;
		}
		
public override bool CanTownNPCSpawn(int numTownNPCs, int money)
		{
			if (NPC.downedBoss1)
			{
			return true;
			}
			return false;
		}
 
        public override string TownNPCName()
        {                                       //NPC names
            string Edward = Language.GetTextValue("Mods.AlchemistNPC.Edward");
			string Severus = Language.GetTextValue("Mods.AlchemistNPC.Severus");
			string Horace = Language.GetTextValue("Mods.AlchemistNPC.Horace");
			string Tilyorn = Language.GetTextValue("Mods.AlchemistNPC.Tilyorn");
			string Nicolas = Language.GetTextValue("Mods.AlchemistNPC.Nicolas");
			string Gregg = Language.GetTextValue("Mods.AlchemistNPC.Gregg");
			switch (WorldGen.genRand.Next(6))
            {
                case 0:
                    return Edward;
                case 1:
                    return Severus;
                case 2:
                    return Horace;
                case 3:
                    return Tilyorn;
				case 4:
                    return Nicolas;
                default:
                    return Gregg;
            }
        }
 
		public override void TownNPCAttackStrength(ref int damage, ref float knockback)
		{
			if (!Main.hardMode)
			{
			damage = 10;
			}
			if (!NPC.downedMoonlord && Main.hardMode)
			{
			damage = 25;
			}
			if (NPC.downedMoonlord)
			{
			damage = 100;
			}
			knockback = 8f;
		}

		public override void TownNPCAttackCooldown(ref int cooldown, ref int randExtraCooldown)
		{
			cooldown = 15;
			randExtraCooldown = 5;
		}

		public override void TownNPCAttackProj(ref int projType, ref int attackDelay)
		{
			if (NPC.downedMoonlord)
			{
			projType = mod.ProjectileType("CorrosiveFlask");
			}
			else
			{
			projType = ProjectileID.ToxicFlask;
			}
			attackDelay = 1;
		}

		public override void TownNPCAttackProjSpeed(ref float multiplier, ref float gravityCorrection, ref float randomOffset)
		{
			multiplier = 12f;
			randomOffset = 2f;
		}
 
 
        public override string GetChat()
        {                                           //npc chat
         string EntryA1 = Language.GetTextValue("Mods.AlchemistNPC.EntryA1");
		 string EntryA2 = Language.GetTextValue("Mods.AlchemistNPC.EntryA2");
		 string EntryA3 = Language.GetTextValue("Mods.AlchemistNPC.EntryA3");
		 string EntryA4 = Language.GetTextValue("Mods.AlchemistNPC.EntryA4");
		 string EntryA5 = Language.GetTextValue("Mods.AlchemistNPC.EntryA5");
		 string EntryA6 = Language.GetTextValue("Mods.AlchemistNPC.EntryA6");
		 string EntryA7 = Language.GetTextValue("Mods.AlchemistNPC.EntryA7");
		 string EntryA8 = Language.GetTextValue("Mods.AlchemistNPC.EntryA8");
		 string EntryA9 = Language.GetTextValue("Mods.AlchemistNPC.EntryA9");
		 string EntryA10 = Language.GetTextValue("Mods.AlchemistNPC.EntryA10");
		 string EntryA11 = Language.GetTextValue("Mods.AlchemistNPC.EntryA11");
		 string EntryA12 = Language.GetTextValue("Mods.AlchemistNPC.EntryA12");
		 string EntryA13 = Language.GetTextValue("Mods.AlchemistNPC.EntryA13");
		 string EntryA14 = Language.GetTextValue("Mods.AlchemistNPC.EntryA14");
		 string EntryA15 = Language.GetTextValue("Mods.AlchemistNPC.EntryA15");
		 string EntryA16 = Language.GetTextValue("Mods.AlchemistNPC.EntryA16");
		 string EntryA17 = Language.GetTextValue("Mods.AlchemistNPC.EntryA17");
		 string EntryA18 = Language.GetTextValue("Mods.AlchemistNPC.EntryA18");
		 string EntryA19 = Language.GetTextValue("Mods.AlchemistNPC.EntryA19");
		 string EntryA20 = Language.GetTextValue("Mods.AlchemistNPC.EntryA20");
		 string EntryA21 = Language.GetTextValue("Mods.AlchemistNPC.EntryA21");
		 string EntryA22 = Language.GetTextValue("Mods.AlchemistNPC.EntryA22");
		 string EntryA23 = Language.GetTextValue("Mods.AlchemistNPC.EntryA23");
		 string EntryA24 = Language.GetTextValue("Mods.AlchemistNPC.EntryA24");
		 int Brewer = NPC.FindFirstNPC(mod.NPCType("Brewer"));
		 int partyGirl = NPC.FindFirstNPC(NPCID.PartyGirl);
			if (Main.bloodMoon && partyGirl >= 0 && Main.rand.Next(4) == 0)
			{
			return EntryA23 + Main.npc[partyGirl].GivenName + EntryA24;
			}
			if (Main.bloodMoon)
			{
				switch (Main.rand.Next(3))
				{
				case 0:
				return EntryA20;
				case 1:
				return EntryA21;
				case 2:
				return EntryA22;
				}
			}
			if (Main.invasionType == 1)
			{
				return EntryA17;
			}
			if (Main.invasionType == 3)
			{
				return EntryA18;
			}
			if (Main.invasionType == 4)
			{
				return EntryA19;
			}
			if (Brewer >= 0 && Main.rand.Next(5) == 0)
			{
				return EntryA15 + Main.npc[Brewer].GivenName + EntryA16;
			}
			if (ModLoader.GetLoadedMods().Contains("Tremor"))
			{
				int Alch = NPC.FindFirstNPC(ModLoader.GetMod("Tremor").NPCType("Alchemist"));
				if (Alch >= 0 && Main.rand.Next(4) == 0)
				{
				return EntryA12 + Main.npc[Alch].GivenName + EntryA13;
				}
			}
			if (ModLoader.GetLoadedMods().Contains("Tremor"))
			{
				if (NPC.downedBoss3 && Main.rand.Next(6) == 0)
				{
				return EntryA14;
				}
			}
			if (ModLoader.GetLoadedMods().Contains("ThoriumMod"))
			{
				int DA = NPC.FindFirstNPC(ModLoader.GetMod("ThoriumMod").NPCType("DesertTraveler"));
				if (DA >= 0 && Main.rand.Next(7) == 0)
				{
				return EntryA9 + Main.npc[DA].GivenName +  EntryA10;
				}
			}
			if (ModLoader.GetLoadedMods().Contains("ThoriumMod"))
			{
				int DA = NPC.FindFirstNPC(ModLoader.GetMod("ThoriumMod").NPCType("DesertTraveler"));
				if (DA >= 0 && Brewer >=0 && Main.rand.Next(8) == 0)
				{
				return EntryA11;
				}
			}
			if (ModLoader.GetLoadedMods().Contains("Peculiarity") && Main.rand.Next(5) == 0)
			{
			return EntryA8;
			}
            switch (Main.rand.Next(7))
            {
                case 0:                                     
				return EntryA1;
                case 1:
				return EntryA2;
                case 2:                                                      
				return EntryA3;
                case 3:
				return EntryA4;
                case 4:                                     
				return EntryA5;
                case 5:
				return EntryA6;
                default:
				return EntryA7;
            }
        }
 
        public override void SetChatButtons(ref string button, ref string button2)
        {
			string TremorShop = Language.GetTextValue("Mods.AlchemistNPC.TremorShop");
            button = Lang.inter[28].Value;
			if (ModLoader.GetLoadedMods().Contains("Tremor"))
			{
			button2 = TremorShop;
			}
        }
 
        public override void OnChatButtonClicked(bool firstButton, ref bool shop)
		{
		baseShop = firstButton;
		shop = true;
		}
 
        public override void SetupShop(Chest shop, ref int nextSlot)
        {
		if (baseShop){
shop.item[nextSlot].SetDefaults (ItemID.LesserHealingPotion);
			shop.item[nextSlot].shopCustomPrice = 1000;
            nextSlot++;
if (NPC.downedBoss2)
{
shop.item[nextSlot].SetDefaults (ItemID.HealingPotion);
			shop.item[nextSlot].shopCustomPrice = 5000;
            nextSlot++;
}
if (Main.hardMode)
{
shop.item[nextSlot].SetDefaults (ItemID.GreaterHealingPotion);
			shop.item[nextSlot].shopCustomPrice = 10000;
            nextSlot++;
}
if (NPC.downedMoonlord)
{
shop.item[nextSlot].SetDefaults (ItemID.SuperHealingPotion);
			shop.item[nextSlot].shopCustomPrice = 25000;
            nextSlot++;
}
shop.item[nextSlot].SetDefaults (ItemID.LesserManaPotion);
			shop.item[nextSlot].shopCustomPrice = 500;
            nextSlot++;
if (NPC.downedBoss2)
{
shop.item[nextSlot].SetDefaults (ItemID.ManaPotion);
			shop.item[nextSlot].shopCustomPrice = 1000;
            nextSlot++;
}
if (Main.hardMode)
{
shop.item[nextSlot].SetDefaults (ItemID.GreaterManaPotion);
			shop.item[nextSlot].shopCustomPrice = 5000;
            nextSlot++;		
}
if (Main.hardMode && NPC.downedMechBoss1 && (NPC.downedMechBoss2 && NPC.downedMechBoss3))
{
shop.item[nextSlot].SetDefaults (ItemID.SuperManaPotion);
			shop.item[nextSlot].shopCustomPrice = 10000;
            nextSlot++;	
}
if (NPC.downedBoss1)
{
shop.item[nextSlot].SetDefaults (ItemID.LesserRestorationPotion);
			shop.item[nextSlot].shopCustomPrice = 3500;
            nextSlot++;
}
if (NPC.downedBoss2)
{
shop.item[nextSlot].SetDefaults (ItemID.RestorationPotion);
			shop.item[nextSlot].shopCustomPrice = 7500;
            nextSlot++;
shop.item[nextSlot].SetDefaults (ItemID.StrangeBrew);
			shop.item[nextSlot].shopCustomPrice = 10000;
            nextSlot++;
}
shop.item[nextSlot].SetDefaults (ItemID.RecallPotion);
shop.item[nextSlot].shopCustomPrice = 5000;
            nextSlot++;
shop.item[nextSlot].SetDefaults (ItemID.WormholePotion);
shop.item[nextSlot].shopCustomPrice = 5000;
            nextSlot++;
shop.item[nextSlot].SetDefaults (ItemID.InvisibilityPotion);
			shop.item[nextSlot].shopCustomPrice = 5000;
            nextSlot++;
if (Main.hardMode)
{
shop.item[nextSlot].SetDefaults (ItemID.TeleportationPotion);
			shop.item[nextSlot].shopCustomPrice = 7500;
            nextSlot++;	
}
shop.item[nextSlot].SetDefaults (ItemID.GenderChangePotion);
			shop.item[nextSlot].shopCustomPrice = 10000;
            nextSlot++;			
if (ModLoader.GetLoadedMods().Contains("imkSushisMod"))
			{
				shop.item[nextSlot].SetDefaults(ModLoader.GetMod("imkSushisMod").ItemType("BaseSummoningPotion"));
				shop.item[nextSlot].shopCustomPrice = 2500;
				nextSlot++;
				shop.item[nextSlot].SetDefaults(ModLoader.GetMod("imkSushisMod").ItemType("AnglerAmnesiaPotion"));
				shop.item[nextSlot].shopCustomPrice = 10000;
				nextSlot++;
				shop.item[nextSlot].SetDefaults(ModLoader.GetMod("imkSushisMod").ItemType("MeteoritePotion"));
				shop.item[nextSlot].shopCustomPrice = 50000;
				nextSlot++;
				shop.item[nextSlot].SetDefaults(ModLoader.GetMod("imkSushisMod").ItemType("ResurrectionPotion"));
				shop.item[nextSlot].shopCustomPrice = 25000;
				nextSlot++;
			}		
shop.item[nextSlot].SetDefaults (ItemID.Bottle);
			shop.item[nextSlot].shopCustomPrice = 100;
            nextSlot++;
shop.item[nextSlot].SetDefaults (ItemID.BottledWater);
			shop.item[nextSlot].shopCustomPrice = 500;
            nextSlot++;
shop.item[nextSlot].SetDefaults (ItemID.Mushroom);
			shop.item[nextSlot].shopCustomPrice = 500;
            nextSlot++;			
shop.item[nextSlot].SetDefaults (ItemID.GlowingMushroom);
			shop.item[nextSlot].shopCustomPrice = 1000;
            nextSlot++;
			if (NPC.downedBoss2)
{
shop.item[nextSlot].SetDefaults (ItemID.VileMushroom);
			shop.item[nextSlot].shopCustomPrice = 1000;
            nextSlot++;
shop.item[nextSlot].SetDefaults (ItemID.ViciousMushroom);
			shop.item[nextSlot].shopCustomPrice = 1000;
            nextSlot++;
shop.item[nextSlot].SetDefaults (ItemID.FallenStar);
            nextSlot++;
}
shop.item[nextSlot].SetDefaults (ItemID.Gel);
			shop.item[nextSlot].shopCustomPrice = 100;
            nextSlot++;
			if (NPC.downedBoss2)
{
shop.item[nextSlot].SetDefaults (ItemID.PinkGel);
			shop.item[nextSlot].shopCustomPrice = 1000;
            nextSlot++;
}
if (ModLoader.GetLoadedMods().Contains("ThoriumMod"))
	{
if (NPC.downedBoss2)
		{
		shop.item[nextSlot].SetDefaults(ModLoader.GetMod("ThoriumMod").ItemType("WaterChestnut"));
		shop.item[nextSlot].shopCustomPrice = 3500;
		nextSlot++;
		}
	if (NPC.downedBoss3)
		{
		shop.item[nextSlot].SetDefaults(ModLoader.GetMod("ThoriumMod").ItemType("Jelly"));
		shop.item[nextSlot].shopCustomPrice = 7500;
		nextSlot++;
		}
	}
if (Main.hardMode)
				{
				shop.item[nextSlot].SetDefaults (ItemID.PixieDust);
				shop.item[nextSlot].shopCustomPrice = 5000;
				nextSlot++;
				shop.item[nextSlot].SetDefaults (ItemID.CrystalShard);
				shop.item[nextSlot].shopCustomPrice = 7500;
				nextSlot++;
				shop.item[nextSlot].SetDefaults (ItemID.UnicornHorn);
				shop.item[nextSlot].shopCustomPrice = 15000;
				nextSlot++;
				shop.item[nextSlot].SetDefaults (ItemID.CursedFlame);
				shop.item[nextSlot].shopCustomPrice = 7500;
				nextSlot++;
				shop.item[nextSlot].SetDefaults (ItemID.Ichor);
				shop.item[nextSlot].shopCustomPrice = 7500;
				nextSlot++;
				}	
{
			for (int k = 0; k < 255; k++)
			{
				Player player = Main.player[k];
				if (player.active)
				{
					for (int j = 0; j < player.inventory.Length; j++)
					{
						if (player.inventory[j].type == mod.ItemType("OtherworldlyAmulet"))
						{
			shop.item[nextSlot].SetDefaults (ModLoader.GetMod("AlchemistNPC").ItemType("EmagledFragmentation"));
			shop.item[nextSlot].shopCustomPrice = 80000;
            nextSlot++;
						}
					}
				}
			}

}
		}
		else{
			if (ModLoader.GetLoadedMods().Contains("Tremor"))
			{
				shop.item[nextSlot].SetDefaults(ModLoader.GetMod("Tremor").ItemType("BasicFlask"));
				nextSlot++;
				shop.item[nextSlot].SetDefaults(ModLoader.GetMod("Tremor").ItemType("FrostLiquidFlask"));
				nextSlot++;
				shop.item[nextSlot].SetDefaults(ModLoader.GetMod("Tremor").ItemType("LesserHealingFlack"));
				nextSlot++;
				if (Main.hardMode)
				{
				shop.item[nextSlot].SetDefaults(ModLoader.GetMod("Tremor").ItemType("BigHealingFlack"));
				nextSlot++;
				}
				shop.item[nextSlot].SetDefaults(ModLoader.GetMod("Tremor").ItemType("LesserManaFlask"));
				nextSlot++;
				if (Main.hardMode)
				{
				shop.item[nextSlot].SetDefaults(ModLoader.GetMod("Tremor").ItemType("BigManaFlask"));
				nextSlot++;
				}
				if (NPC.downedMoonlord)
				{
				shop.item[nextSlot].SetDefaults(ModLoader.GetMod("Tremor").ItemType("SuperManaFlask"));
				nextSlot++;
				}
				shop.item[nextSlot].SetDefaults(ModLoader.GetMod("Tremor").ItemType("LesserPoisonFlask"));
				nextSlot++;
				if (Main.hardMode)
				{
				shop.item[nextSlot].SetDefaults(ModLoader.GetMod("Tremor").ItemType("BigPoisonFlask"));
				nextSlot++;
				}
				shop.item[nextSlot].SetDefaults(ModLoader.GetMod("Tremor").ItemType("BoomFlask"));
				nextSlot++;
				if (Main.hardMode)
				{
				shop.item[nextSlot].SetDefaults(ModLoader.GetMod("Tremor").ItemType("ExtendedBoomFlask"));
				nextSlot++;
				}
				shop.item[nextSlot].SetDefaults(ModLoader.GetMod("Tremor").ItemType("FreezeFlask"));
				nextSlot++;
				if (Main.hardMode)
				{
				shop.item[nextSlot].SetDefaults(ModLoader.GetMod("Tremor").ItemType("ExtendedFreezeFlask"));
				nextSlot++;
				}
				if (NPC.downedBoss3)
				{
				shop.item[nextSlot].SetDefaults(ModLoader.GetMod("Tremor").ItemType("GoldFlask"));
				nextSlot++;
				}
				shop.item[nextSlot].SetDefaults(ModLoader.GetMod("Tremor").ItemType("BurningFlask"));
				nextSlot++;
				if (Main.hardMode)
				{
				shop.item[nextSlot].SetDefaults(ModLoader.GetMod("Tremor").ItemType("ExtendedBurningFlask"));
				nextSlot++;
				shop.item[nextSlot].SetDefaults(ModLoader.GetMod("Tremor").ItemType("HealthSupportFlask"));
				nextSlot++;
				shop.item[nextSlot].SetDefaults(ModLoader.GetMod("Tremor").ItemType("ManaSupportFlask"));
				nextSlot++;
				shop.item[nextSlot].SetDefaults(ModLoader.GetMod("Tremor").ItemType("LesserVenomFlask"));
				nextSlot++;
				shop.item[nextSlot].SetDefaults(ModLoader.GetMod("Tremor").ItemType("BigVenomFlask"));
				nextSlot++;
				shop.item[nextSlot].SetDefaults(ModLoader.GetMod("Tremor").ItemType("CrystalFlask"));
				shop.item[nextSlot].shopCustomPrice = 150;
				nextSlot++;
				if (NPC.downedPlantBoss)
		{
			shop.item[nextSlot].SetDefaults(ModLoader.GetMod("Tremor").ItemType("PhantomFlask"));
				nextSlot++;
			shop.item[nextSlot].SetDefaults(ModLoader.GetMod("Tremor").ItemType("PlagueFlask"));
				nextSlot++;
			shop.item[nextSlot].SetDefaults(ModLoader.GetMod("Tremor").ItemType("SparkingFlask"));
				nextSlot++;
		}
		if (NPC.downedMoonlord)
				{
	shop.item[nextSlot].SetDefaults(ModLoader.GetMod("Tremor").ItemType("MoonDustFlask"));
	shop.item[nextSlot].shopCustomPrice = 250;
				nextSlot++;
	shop.item[nextSlot].SetDefaults(ModLoader.GetMod("Tremor").ItemType("ClusterFlask"));
	shop.item[nextSlot].shopCustomPrice = 300;
				nextSlot++;
				}
				}
			if (NPC.downedBoss3)
		{
				shop.item[nextSlot].SetDefaults(ModLoader.GetMod("Tremor").ItemType("Gloomstone"));
				shop.item[nextSlot].shopCustomPrice = 100;
				nextSlot++;
				shop.item[nextSlot].SetDefaults(ModLoader.GetMod("Tremor").ItemType("UntreatedFlesh"));
				shop.item[nextSlot].shopCustomPrice = 100;
				nextSlot++;
				shop.item[nextSlot].SetDefaults(ModLoader.GetMod("Tremor").ItemType("LightBulb"));
				shop.item[nextSlot].shopCustomPrice = 500;
				nextSlot++;
				shop.item[nextSlot].SetDefaults(ModLoader.GetMod("Tremor").ItemType("AtisBlood"));
				shop.item[nextSlot].shopCustomPrice = 2500;
				nextSlot++;
				shop.item[nextSlot].SetDefaults(ModLoader.GetMod("Tremor").ItemType("TearsofDeath"));
				shop.item[nextSlot].shopCustomPrice = 2500;
				nextSlot++;
				shop.item[nextSlot].SetDefaults(ModLoader.GetMod("Tremor").ItemType("TornPapyrus"));
				shop.item[nextSlot].shopCustomPrice = 5000;
				nextSlot++;
				shop.item[nextSlot].SetDefaults(ModLoader.GetMod("Tremor").ItemType("PhantomSoul"));
				shop.item[nextSlot].shopCustomPrice = 5000;
				nextSlot++;
				shop.item[nextSlot].SetDefaults(ModLoader.GetMod("Tremor").ItemType("TheRib"));
				shop.item[nextSlot].shopCustomPrice = 7500;
				nextSlot++;
		}	
			}
		}
		}
	}
}