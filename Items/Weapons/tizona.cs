using Microsoft.Xna.Framework;
using terraport.Items.Items;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace terraport.Items.Weapons
{
	public class tizona : ModItem
	{
        // The Display Name and Tooltip of this item can be edited in the Localization/en-US_Mods.terraport.hjson file.

		public override void SetDefaults()
		{
			Item.damage = 55;
			Item.DamageType = DamageClass.Melee;
			Item.width = 48;
			Item.height = 48;
			Item.useTime = 25;
			Item.useAnimation = 20;
			Item.useStyle = ItemUseStyleID.Swing;
			Item.maxStack = 1;
			Item.knockBack = 5;
			Item.crit = 4;
			Item.value = Item.sellPrice(gold: 6);
			Item.rare = ItemRarityID.Pink;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
		}

		public override void OnHitNPC(Player player, NPC target, NPC.HitInfo hit, int damageDone) {
			target.AddBuff(BuffID.Bleeding, 600);
		}

		public override void MeleeEffects(Player player, Rectangle hitbox)
		{
			int dust = Dust.NewDust(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, DustID.Torch, 0f, 0f, 150, default, 3f); //55, 174, 6
			Main.dust[dust].noGravity = true;
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.Excalibur, 1);
			recipe.AddRecipeGroup("AdamantiteBar", 15);
			recipe.AddIngredient(ModContent.ItemType<soulofblight>(), 15);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.Register();
		}
	}
}
