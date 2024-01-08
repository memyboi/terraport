using Terraria;
using terraport.Items.Items;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

namespace terraport.Armour.Titan
{
    [AutoloadEquip(EquipType.Head)]
    public class atitanhelmet : ModItem
    {
        public static readonly int rangedAttackBonus = 15;
        public static readonly int critStrikeChanceBonus = 10;
        public static readonly int notConsumeAmmoChance = 5;

        public static readonly int notConsumeAmmoChanceSetBonus = 28;

        public override LocalizedText Tooltip => base.Tooltip.WithFormatArgs(rangedAttackBonus, critStrikeChanceBonus, notConsumeAmmoChance);

        public static LocalizedText SetBonusText { get; private set; }

        public override void SetStaticDefaults()
        {
            ArmorIDs.Head.Sets.DrawHatHair[Item.headSlot] = true;
            SetBonusText = this.GetLocalization("SetBonus").WithFormatArgs(notConsumeAmmoChanceSetBonus);
        }

        public override void SetDefaults()
        {
            Item.width = 18;
            Item.height = 18;
            Item.value = Item.sellPrice(gold: 10); // How many coins the item is worth
			Item.rare = ItemRarityID.Pink; // The rarity of the item
			Item.defense = 14; // The amount of defense the item will give when equipped
        }

        public override void UpdateEquip(Player player) {
            player.GetModPlayer<plr>().titanHelmet = true;
            player.setBonus = SetBonusText.Value; // This is the setbonus tooltip: "Increases dealt damage by 20%"
			player.GetDamage(DamageClass.Ranged) += rangedAttackBonus / 100f; // Increase dealt damage for all weapon classes by 20%
            player.GetCritChance(DamageClass.Ranged) += critStrikeChanceBonus / 100f; // Increase dealt damage for all weapon classes by 20%
		}

        public override void UpdateArmorSet(Player player) {
			player.setBonus = SetBonusText.Value; // This is the setbonus tooltip: "Increases dealt damage by 20%"
		}

        public override bool IsArmorSet(Item head, Item body, Item legs) {
			return body.type == ModContent.ItemType<btitanmail>() && legs.type == ModContent.ItemType<ctitanleggings>();
		}

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
			recipe.AddRecipeGroup("HallowedHelmet");
            recipe.AddRecipeGroup("CobaltMask");
            recipe.AddRecipeGroup("MythrilHat");
            recipe.AddRecipeGroup("AdamantiteMask");
			recipe.AddIngredient(ModContent.ItemType<soulofblight>(), 15);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.Register();
        }
    }
}