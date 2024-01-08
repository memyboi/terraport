using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace terraport
{
    public class terraportRecipeGroups : ModSystem
    {
        // The Terraria.Localization using directive (using Terraria.Localization;) is required for Language methods.
		public override void AddRecipeGroups()
		{
			//get ready for a lot of copy pasting

			//Cobalt Head
			RecipeGroup cobaltMaskGroup = new RecipeGroup(() => $"{Lang.GetItemNameValue(ItemID.CobaltMask)} or {Lang.GetItemNameValue(ItemID.PalladiumHelmet)}", ItemID.CobaltMask, ItemID.PalladiumHelmet);
			RecipeGroup.RegisterGroup(nameof(ItemID.CobaltMask), cobaltMaskGroup);

			RecipeGroup cobaltHelmetGroup = new RecipeGroup(() => $"{Lang.GetItemNameValue(ItemID.CobaltHelmet)} or {Lang.GetItemNameValue(ItemID.PalladiumMask)}", ItemID.CobaltHelmet, ItemID.PalladiumMask);
			RecipeGroup.RegisterGroup(nameof(ItemID.CobaltHelmet), cobaltHelmetGroup);

			RecipeGroup cobaltHatGroup = new RecipeGroup(() => $"{Lang.GetItemNameValue(ItemID.CobaltHat)} or {Lang.GetItemNameValue(ItemID.PalladiumHeadgear)}", ItemID.CobaltHat, ItemID.PalladiumHeadgear);
			RecipeGroup.RegisterGroup(nameof(ItemID.CobaltHat), cobaltHatGroup);

			//Cobalt Other
			RecipeGroup cobaltBreastplateGroup = new RecipeGroup(() => $"{Lang.GetItemNameValue(ItemID.CobaltBreastplate)} or {Lang.GetItemNameValue(ItemID.PalladiumBreastplate)}", ItemID.CobaltBreastplate, ItemID.PalladiumBreastplate);
			RecipeGroup.RegisterGroup(nameof(ItemID.CobaltBreastplate), cobaltBreastplateGroup);

			RecipeGroup cobaltLeggingsGroup = new RecipeGroup(() => $"{Lang.GetItemNameValue(ItemID.CobaltLeggings)} or {Lang.GetItemNameValue(ItemID.PalladiumLeggings)}", ItemID.CobaltLeggings, ItemID.PalladiumLeggings);
			RecipeGroup.RegisterGroup(nameof(ItemID.CobaltLeggings), cobaltLeggingsGroup);


			//Mythril Head
			RecipeGroup mythrilHelmetGroup = new RecipeGroup(() => $"{Lang.GetItemNameValue(ItemID.MythrilHelmet)} or {Lang.GetItemNameValue(ItemID.OrichalcumMask)}", ItemID.MythrilHelmet, ItemID.OrichalcumMask);
			RecipeGroup.RegisterGroup(nameof(ItemID.MythrilHelmet), mythrilHelmetGroup);

			RecipeGroup mythrilHatGroup = new RecipeGroup(() => $"{Lang.GetItemNameValue(ItemID.MythrilHat)} or {Lang.GetItemNameValue(ItemID.OrichalcumHelmet)}", ItemID.MythrilHat, ItemID.OrichalcumHelmet);
			RecipeGroup.RegisterGroup(nameof(ItemID.MythrilHat), mythrilHatGroup);

			RecipeGroup mythrilHoodGroup = new RecipeGroup(() => $"{Lang.GetItemNameValue(ItemID.MythrilHood)} or {Lang.GetItemNameValue(ItemID.OrichalcumHeadgear)}", ItemID.MythrilHood, ItemID.OrichalcumHeadgear);
			RecipeGroup.RegisterGroup(nameof(ItemID.MythrilHood), mythrilHoodGroup);

			//Mythril Other
			RecipeGroup mythrilChainmailGroup = new RecipeGroup(() => $"{Lang.GetItemNameValue(ItemID.MythrilChainmail)} or {Lang.GetItemNameValue(ItemID.OrichalcumBreastplate)}", ItemID.MythrilChainmail, ItemID.OrichalcumBreastplate);
			RecipeGroup.RegisterGroup(nameof(ItemID.MythrilChainmail), mythrilChainmailGroup);

			RecipeGroup mythrilGreavesGroup = new RecipeGroup(() => $"{Lang.GetItemNameValue(ItemID.MythrilGreaves)} or {Lang.GetItemNameValue(ItemID.OrichalcumLeggings)}", ItemID.MythrilGreaves, ItemID.OrichalcumLeggings);
			RecipeGroup.RegisterGroup(nameof(ItemID.MythrilGreaves), mythrilGreavesGroup);


			//Adamantite Head
			RecipeGroup adamantiteHelmetGroup = new RecipeGroup(() => $"{Lang.GetItemNameValue(ItemID.AdamantiteHelmet)} or {Lang.GetItemNameValue(ItemID.TitaniumMask)}", ItemID.AdamantiteHelmet, ItemID.TitaniumMask);
			RecipeGroup.RegisterGroup(nameof(ItemID.AdamantiteHelmet), adamantiteHelmetGroup);

			RecipeGroup adamantiteMaskGroup = new RecipeGroup(() => $"{Lang.GetItemNameValue(ItemID.AdamantiteMask)} or {Lang.GetItemNameValue(ItemID.TitaniumHelmet)}", ItemID.AdamantiteMask, ItemID.AdamantiteMask);
			RecipeGroup.RegisterGroup(nameof(ItemID.AdamantiteMask), adamantiteMaskGroup);

			RecipeGroup adamantiteHeadgearGroup = new RecipeGroup(() => $"{Lang.GetItemNameValue(ItemID.AdamantiteHeadgear)} or {Lang.GetItemNameValue(ItemID.TitaniumHeadgear)}", ItemID.AdamantiteHeadgear, ItemID.TitaniumHeadgear);
			RecipeGroup.RegisterGroup(nameof(ItemID.AdamantiteHeadgear), adamantiteHeadgearGroup);

			//Adamantite Other
			RecipeGroup adamantiteBreastplateGroup = new RecipeGroup(() => $"{Lang.GetItemNameValue(ItemID.AdamantiteBreastplate)} or {Lang.GetItemNameValue(ItemID.TitaniumBreastplate)}", ItemID.AdamantiteBreastplate, ItemID.TitaniumBreastplate);
			RecipeGroup.RegisterGroup(nameof(ItemID.AdamantiteBreastplate), adamantiteBreastplateGroup);

			RecipeGroup adamantiteLeggingsGroup = new RecipeGroup(() => $"{Lang.GetItemNameValue(ItemID.AdamantiteLeggings)} or {Lang.GetItemNameValue(ItemID.TitaniumLeggings)}", ItemID.AdamantiteLeggings, ItemID.TitaniumLeggings);
			RecipeGroup.RegisterGroup(nameof(ItemID.AdamantiteLeggings), adamantiteLeggingsGroup);


			//Hallowed Head
			RecipeGroup hallowedHelmetGroup = new RecipeGroup(() => $"{Lang.GetItemNameValue(ItemID.HallowedHelmet)}", ItemID.HallowedHelmet, ItemID.AncientHallowedHelmet);
			RecipeGroup.RegisterGroup(nameof(ItemID.HallowedHelmet), hallowedHelmetGroup);

			RecipeGroup hallowedMaskGroup = new RecipeGroup(() => $"{Lang.GetItemNameValue(ItemID.HallowedMask)}", ItemID.HallowedMask, ItemID.AncientHallowedMask);
			RecipeGroup.RegisterGroup(nameof(ItemID.HallowedMask), hallowedMaskGroup);

			RecipeGroup hallowedHeadgearGroup = new RecipeGroup(() => $"{Lang.GetItemNameValue(ItemID.HallowedHeadgear)}", ItemID.HallowedHeadgear, ItemID.AncientHallowedHeadgear);
			RecipeGroup.RegisterGroup(nameof(ItemID.HallowedHeadgear), hallowedHeadgearGroup);

			//Hallowed Other
			RecipeGroup hallowedPlatemailGroup = new RecipeGroup(() => $"{Lang.GetItemNameValue(ItemID.HallowedPlateMail)}", ItemID.HallowedPlateMail, ItemID.AncientHallowedPlateMail);
			RecipeGroup.RegisterGroup(nameof(ItemID.HallowedPlateMail), hallowedPlatemailGroup);

			RecipeGroup hallowedGreavesGroup = new RecipeGroup(() => $"{Lang.GetItemNameValue(ItemID.HallowedGreaves)}", ItemID.HallowedGreaves, ItemID.AncientHallowedGreaves);
			RecipeGroup.RegisterGroup(nameof(ItemID.HallowedGreaves), hallowedGreavesGroup);

			//Bars
			RecipeGroup adamantiteBars = new RecipeGroup(() => $"{Language.GetTextValue("LegacyMisc.37")} {Lang.GetItemNameValue(ItemID.AdamantiteBar)}", ItemID.AdamantiteBar, ItemID.TitaniumBar);
			RecipeGroup.RegisterGroup(nameof(ItemID.AdamantiteBar), adamantiteBars);

			RecipeGroup copperBars = new RecipeGroup(() => $"{Language.GetTextValue("LegacyMisc.37")} {Lang.GetItemNameValue(ItemID.CopperBar)}", ItemID.CopperBar, ItemID.TinBar);
			RecipeGroup.RegisterGroup(nameof(ItemID.CopperBar), copperBars);

			RecipeGroup silverBars = new RecipeGroup(() => $"{Language.GetTextValue("LegacyMisc.37")} {Lang.GetItemNameValue(ItemID.SilverBar)}", ItemID.SilverBar, ItemID.TungstenBar);
			RecipeGroup.RegisterGroup(nameof(ItemID.SilverBar), silverBars);

			RecipeGroup goldBars = new RecipeGroup(() => $"{Language.GetTextValue("LegacyMisc.37")} {Lang.GetItemNameValue(ItemID.GoldBar)}", ItemID.GoldBar, ItemID.PlatinumBar);
			RecipeGroup.RegisterGroup(nameof(ItemID.GoldBar), goldBars);
		}
    }
}