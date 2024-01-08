using Terraria;
using terraport.Items.Items;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;
using System;

namespace terraport.Armour.Titan
{
    [AutoloadEquip(EquipType.Legs)]
    public class ctitanleggings : ModItem
    {
        public static readonly int rangedAttackAndMovementBonus = 10;

        public override LocalizedText Tooltip => base.Tooltip.WithFormatArgs(rangedAttackAndMovementBonus);

        public override void SetDefaults()
        {
            Item.width = 18;
            Item.height = 18;
            Item.value = Item.sellPrice(gold: 20); // How many coins the item is worth
			Item.rare = ItemRarityID.Pink; // The rarity of the item
			Item.defense = 18; // The amount of defense the item will give when equipped
        }

        public override void UpdateEquip(Player player) {
            player.GetModPlayer<plr>().titanLeggings = true;
			player.GetDamage(DamageClass.Ranged) += rangedAttackAndMovementBonus / 100f; // Increase dealt damage for all weapon classes by 20%
            player.moveSpeed += rangedAttackAndMovementBonus / 100f;
		}

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
			recipe.AddRecipeGroup("HallowedGreaves");
            recipe.AddRecipeGroup("CobaltLeggings");
            recipe.AddRecipeGroup("MythrilGreaves");
            recipe.AddRecipeGroup("AdamantiteLeggings");
            recipe.AddIngredient(ItemID.SoulofSight, 15);
			recipe.AddIngredient(ModContent.ItemType<soulofblight>(), 15);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.Register();
        }
    }
}