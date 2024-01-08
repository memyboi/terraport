using Terraria;
using terraport.Items.Items;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

namespace terraport.Armour.Dragon
{
    [AutoloadEquip(EquipType.Legs)]
    public class cdragongreaves : ModItem
    {
        //public override LocalizedText Tooltip => base.Tooltip.WithFormatArgs(meleeSpeedBonus, critStrikeChanceBonus);

        public static readonly int meleeSpeedBonus = 2;
        public static readonly int movementSpeedBonus = 12;

        public static LocalizedText SetBonusText { get; private set; }

        public override void SetDefaults()
        {
            Item.width = 18;
            Item.height = 18;
            Item.value = Item.sellPrice(gold: 15); // How many coins the item is worth
			Item.rare = ItemRarityID.Pink; // The rarity of the item
			Item.defense = 14; // The amount of defense the item will give when equipped
        }

        public override void UpdateEquip(Player player) {
            player.GetAttackSpeed(DamageClass.Melee) += meleeSpeedBonus / 100f;
            player.moveSpeed += movementSpeedBonus / 100f;
		}

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
			recipe.AddRecipeGroup("HallowedGreaves");
            recipe.AddRecipeGroup("CobaltLeggings");
            recipe.AddRecipeGroup("MythrilGreaves");
            recipe.AddRecipeGroup("AdamantiteLeggings");
            recipe.AddIngredient(ItemID.SoulofMight, 15);
			recipe.AddIngredient(ModContent.ItemType<soulofblight>(), 15);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.Register();
        }
    }
}