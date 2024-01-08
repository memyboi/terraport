using Terraria;
using terraport.Items.Items;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

namespace terraport.Armour.Dragon
{
    [AutoloadEquip(EquipType.Body)]
    public class bdragonbreastplate : ModItem
    {
        //public override LocalizedText Tooltip => base.Tooltip.WithFormatArgs(meleeSpeedBonus, critStrikeChanceBonus);

        public static readonly int meleeSpeedBonus = 5;
        public static readonly int critStrikeChanceBonus = 10;

        public static LocalizedText SetBonusText { get; private set; }

        public override void SetDefaults()
        {
            Item.width = 18;
            Item.height = 18;
            Item.value = Item.sellPrice(gold: 20); // How many coins the item is worth
			Item.rare = ItemRarityID.Pink; // The rarity of the item
			Item.defense = 20; // The amount of defense the item will give when equipped
        }

        public override void UpdateEquip(Player player) {
			player.GetDamage(DamageClass.Melee) += meleeSpeedBonus / 100f; // Increase dealt damage for all weapon classes by 20%
            player.GetCritChance(DamageClass.Generic) += critStrikeChanceBonus / 100f; // Increase dealt damage for all weapon classes by 20%
		}

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
			recipe.AddRecipeGroup("HallowedPlateMail");
            recipe.AddRecipeGroup("CobaltBreastplate");
            recipe.AddRecipeGroup("MythrilChainmail");
            recipe.AddRecipeGroup("AdamantiteBreastplate");
            recipe.AddIngredient(ItemID.SoulofMight, 15);
			recipe.AddIngredient(ModContent.ItemType<soulofblight>(), 15);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.Register();
        }
    }
}