using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlchemistNPC.Projectiles
{
	public class MB : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Magic Bullet");     //The English name of the projectile
		}

		public override void SetDefaults()
		{
			projectile.CloneDefaults(ProjectileID.MoonlordBullet);
			projectile.tileCollide = false;
			aiType = ProjectileID.MoonlordBullet;
		}
		
		public override void AI()
		{
		Lighting.AddLight(projectile.Center, ((255 - projectile.alpha) * 0.9f) / 255f, ((255 - projectile.alpha) * 0.1f) / 255f, ((255 - projectile.alpha) * 0.3f) / 255f);
		}
	}
}