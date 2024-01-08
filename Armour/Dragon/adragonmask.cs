using Terraria;
using terraport.Items.Items;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

namespace terraport.Armour.Dragon
{
    [AutoloadEquip(EquipType.Head)]
    public class adragonmask : ModItem
    {
        public static readonly int meleeSpeedAttackBonus = 15;
        public static readonly int critStrikeChanceBonus = 15;

        public static readonly int meleePlusMovementBonus = 21;

        public override LocalizedText Tooltip => base.Tooltip.WithFormatArgs(meleeSpeedAttackBonus, critStrikeChanceBonus);

        public static LocalizedText SetBonusText { get; private set; }

        public override void SetStaticDefaults()
        {
            ArmorIDs.Head.Sets.DrawHatHair[Item.headSlot] = true;
            SetBonusText = this.GetLocalization("SetBonus").WithFormatArgs(meleePlusMovementBonus);
        }

        public override void SetDefaults()
        {
            Item.width = 18;
            Item.height = 18;
            Item.value = Item.sellPrice(gold: 10); // How many coins the item is worth
			Item.rare = ItemRarityID.Pink; // The rarity of the item
			Item.defense = 26; // The amount of defense the item will give when equipped
        }

        public override void UpdateEquip(Player player) {
            player.setBonus = SetBonusText.Value; // This is the setbonus tooltip: "Increases dealt damage by 20%"
			player.GetDamage(DamageClass.Melee) += meleeSpeedAttackBonus / 100f; // Increase dealt damage for all weapon classes by 20%
            player.GetCritChance(DamageClass.Generic) += critStrikeChanceBonus / 100f; // Increase dealt damage for all weapon classes by 20%
            player.GetAttackSpeed(DamageClass.Melee) += meleeSpeedAttackBonus / 100f;
		}

        public override void UpdateArmorSet(Player player) {
			player.setBonus = SetBonusText.Value; // This is the setbonus tooltip: "Increases dealt damage by 20%"
			player.GetAttackSpeed(DamageClass.Melee) += meleePlusMovementBonus / 100f;
            player.moveSpeed += meleePlusMovementBonus / 100f;
		}

        public override bool IsArmorSet(Item head, Item body, Item legs) {
			return body.type == ModContent.ItemType<bdragonbreastplate>() && legs.type == ModContent.ItemType<cdragongreaves>();
		}

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
			recipe.AddRecipeGroup("HallowedMask");
            recipe.AddRecipeGroup("CobaltHelmet");
            recipe.AddRecipeGroup("MythrilHelmet");
            recipe.AddRecipeGroup("AdamantiteHelmet");
			recipe.AddIngredient(ModContent.ItemType<soulofblight>(), 15);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.Register();
        }
    }
}