using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using terraport.Items.Weapons.fakes;

namespace terraport.Reverts
{
    public class craftingRevert : ModSystem
    {
        public void ChangeIngredientCount(int barid, int amnt, Recipe recipe) {
			recipe.RemoveIngredient(barid);
			recipe.AddIngredient(barid, amnt);
		}

        public override void AddRecipes() {
            Recipe.Create(ItemID.DepthMeter)
			    .AddRecipeGroup("CopperBar", 10)
                .AddRecipeGroup("SilverBar", 8)
                .AddRecipeGroup("GoldBar", 6)
			    .AddTile(TileID.Tables)
                .AddTile(TileID.Chairs)
			    .Register();

            Recipe.Create(ModContent.ItemType<faketerrablade>())
			    .AddIngredient(ItemID.BrokenHeroSword)
                .AddIngredient(ModContent.ItemType<fakestexcalibur>())
                .AddIngredient(ModContent.ItemType<fakenightsedge>())
			    .AddTile(TileID.MythrilAnvil)
			    .Register();

            Recipe.Create(ModContent.ItemType<fakestexcalibur>())
			    .AddIngredient(ItemID.BrokenHeroSword)
                .AddIngredient(ItemID.Excalibur)
			    .AddTile(TileID.MythrilAnvil)
			    .Register();
            
            Recipe.Create(ModContent.ItemType<fakenightsedge>())
			    .AddIngredient(ItemID.BrokenHeroSword)
                .AddIngredient(ItemID.NightsEdge)
			    .AddTile(TileID.MythrilAnvil)
			    .Register();
        }

		public override void PostAddRecipes() { //disable recipes
            for (int i = 0; i < Recipe.numRecipes; i++) {
                Recipe recipe = Main.recipe[i];
				// sorry but i can't rlly use a switch statement here

				bool HasIngredient(int ingredientid) {
					return (recipe.TryGetIngredient(ingredientid, out Item ingredient));
				}

                // Modifying crafting recipies for parity w/ console/3ds version

                if (recipe.HasResult(ItemID.CopperShortsword)) {
                    ChangeIngredientCount(ItemID.CopperBar, 7, recipe);
                } else if (recipe.HasResult(ItemID.TinShortsword)) {
                    ChangeIngredientCount(ItemID.TinBar, 7, recipe);
                } else if (recipe.HasResult(ItemID.IronShortsword)) {
                    ChangeIngredientCount(ItemID.IronBar, 7, recipe);
                } else if (recipe.HasResult(ItemID.LeadShortsword)) {
                    ChangeIngredientCount(ItemID.LeadBar, 7, recipe);
                } else if (recipe.HasResult(ItemID.SilverShortsword)) {
                    ChangeIngredientCount(ItemID.SilverBar, 6, recipe);
                } else if (recipe.HasResult(ItemID.TungstenShortsword)) {
                    ChangeIngredientCount(ItemID.TungstenBar, 6, recipe);
                } else if (recipe.HasResult(ItemID.GoldShortsword)) {
                    ChangeIngredientCount(ItemID.GoldBar, 7, recipe);
                } else if (recipe.HasResult(ItemID.PlatinumShortsword)) {
                    ChangeIngredientCount(ItemID.PlatinumBar, 7, recipe);
                } else if (recipe.HasResult(ItemID.AngelWings)) {
                    ChangeIngredientCount(ItemID.SoulofLight, 25, recipe);
                } else if (recipe.HasResult(ItemID.DemonWings)) {
                    ChangeIngredientCount(ItemID.SoulofNight, 25, recipe);
                } else if (recipe.HasResult(ItemID.FairyWings)) {
                    ChangeIngredientCount(ItemID.PixieDust, 100, recipe);
                } else if (recipe.HasResult(ItemID.CopperChainmail)) {
                    ChangeIngredientCount(ItemID.CopperBar, 25, recipe);
                } else if (recipe.HasResult(ItemID.CopperGreaves)) {
                    ChangeIngredientCount(ItemID.CopperBar, 20, recipe);
                } else if (recipe.HasResult(ItemID.CopperHelmet)) {
                    ChangeIngredientCount(ItemID.CopperBar, 15, recipe);
                } else if (recipe.HasResult(ItemID.CopperAxe)) {
                    ChangeIngredientCount(ItemID.CopperBar, 9, recipe);
                } else if (recipe.HasResult(ItemID.CopperBroadsword)) {
                    ChangeIngredientCount(ItemID.CopperBar, 8, recipe);
                } else if (recipe.HasResult(ItemID.CopperHammer)) {
                    ChangeIngredientCount(ItemID.CopperBar, 10, recipe);
                } else if (recipe.HasResult(ItemID.CopperPickaxe)) {
                    ChangeIngredientCount(ItemID.CopperBar, 12, recipe);
                } else if (recipe.HasResult(ItemID.SpookyChandelier)) {
                    recipe.RemoveTile(TileID.Anvils);
                    recipe.AddTile(TileID.WorkBenches);
                } else if (recipe.HasResult(ItemID.TinChainmail)) {
                    ChangeIngredientCount(ItemID.TinBar, 25, recipe);
                } else if (recipe.HasResult(ItemID.TinGreaves)) {
                    ChangeIngredientCount(ItemID.TinBar, 20, recipe);
                } else if (recipe.HasResult(ItemID.TinHelmet)) {
                    ChangeIngredientCount(ItemID.TinBar, 25, recipe);
                } else if (recipe.HasResult(ItemID.IronHelmet)) {
                    ChangeIngredientCount(ItemID.IronBar, 20, recipe);
                } else if (recipe.HasResult(ItemID.IronGreaves)) {
                    ChangeIngredientCount(ItemID.IronBar, 25, recipe);
                } else if (recipe.HasResult(ItemID.IronChainmail)) {
                    ChangeIngredientCount(ItemID.IronBar, 30, recipe);
                } else if (recipe.HasResult(ItemID.LeadHelmet)) {
                    ChangeIngredientCount(ItemID.LeadBar, 20, recipe);
                } else if (recipe.HasResult(ItemID.LeadGreaves)) {
                    ChangeIngredientCount(ItemID.LeadBar, 25, recipe);
                } else if (recipe.HasResult(ItemID.LeadChainmail)) {
                    ChangeIngredientCount(ItemID.LeadBar, 30, recipe);
                } else if (recipe.HasResult(ItemID.TinAxe)) {
                    ChangeIngredientCount(ItemID.TinBar, 9, recipe);
                } else if (recipe.HasResult(ItemID.TinBroadsword)) {
                    ChangeIngredientCount(ItemID.TinBar, 9, recipe);
                } else if (recipe.HasResult(ItemID.TinHammer)) {
                    ChangeIngredientCount(ItemID.TinBar, 10, recipe);
                } else if (recipe.HasResult(ItemID.TinPickaxe)) {
                    ChangeIngredientCount(ItemID.TinBar, 12, recipe);
                } else if (recipe.HasResult(ItemID.LeadAxe)) {
                    ChangeIngredientCount(ItemID.LeadBar, 9, recipe);
                } else if (recipe.HasResult(ItemID.LeadHammer)) {
                    ChangeIngredientCount(ItemID.LeadBar, 10, recipe);
                } else if (recipe.HasResult(ItemID.LeadPickaxe)) {
                    ChangeIngredientCount(ItemID.LeadBar, 12, recipe);
                } else if (recipe.HasResult(ItemID.IronAxe)) {
                    ChangeIngredientCount(ItemID.IronBar, 9, recipe);
                } else if (recipe.HasResult(ItemID.IronHammer)) {
                    ChangeIngredientCount(ItemID.IronBar, 10, recipe);
                } else if (recipe.HasResult(ItemID.IronPickaxe)) {
                    ChangeIngredientCount(ItemID.IronBar, 12, recipe);
                }

                 else if (recipe.HasResult(ItemID.SilverAxe)) {
                    ChangeIngredientCount(ItemID.SilverBar, 9, recipe);
                } else if (recipe.HasResult(ItemID.SilverBroadsword)) {
                    ChangeIngredientCount(ItemID.SilverBar, 8, recipe);
                } else if (recipe.HasResult(ItemID.SilverHammer)) {
                    ChangeIngredientCount(ItemID.SilverBar, 10, recipe);
                } else if (recipe.HasResult(ItemID.SilverPickaxe)) {
                    ChangeIngredientCount(ItemID.SilverBar, 12, recipe);
                } else if (recipe.HasResult(ItemID.SilverHelmet)) {
                    ChangeIngredientCount(ItemID.SilverBar, 20, recipe);
                } else if (recipe.HasResult(ItemID.SilverGreaves)) {
                    ChangeIngredientCount(ItemID.SilverBar, 25, recipe);
                } else if (recipe.HasResult(ItemID.SilverChainmail)) {
                    ChangeIngredientCount(ItemID.SilverBar, 30, recipe);
                }

                 else if (recipe.HasResult(ItemID.TungstenAxe)) {
                    ChangeIngredientCount(ItemID.TungstenBar, 9, recipe);
                } else if (recipe.HasResult(ItemID.TungstenBroadsword)) {
                    ChangeIngredientCount(ItemID.TungstenBar, 8, recipe);
                } else if (recipe.HasResult(ItemID.TungstenHammer)) {
                    ChangeIngredientCount(ItemID.TungstenBar, 10, recipe);
                } else if (recipe.HasResult(ItemID.TungstenPickaxe)) {
                    ChangeIngredientCount(ItemID.TungstenBar, 12, recipe);
                } else if (recipe.HasResult(ItemID.TungstenHelmet)) {
                    ChangeIngredientCount(ItemID.TungstenBar, 20, recipe);
                } else if (recipe.HasResult(ItemID.TungstenGreaves)) {
                    ChangeIngredientCount(ItemID.TungstenBar, 25, recipe);
                } else if (recipe.HasResult(ItemID.TungstenChainmail)) {
                    ChangeIngredientCount(ItemID.TungstenBar, 30, recipe);
                }

                 else if (recipe.HasResult(ItemID.GoldCrown)) {
                    ChangeIngredientCount(ItemID.GoldBar, 30, recipe);
                } else if (recipe.HasResult(ItemID.GoldGreaves)) {
                    ChangeIngredientCount(ItemID.GoldBar, 30, recipe);
                } else if (recipe.HasResult(ItemID.GoldHelmet)) {
                    ChangeIngredientCount(ItemID.GoldBar, 25, recipe);
                } else if (recipe.HasResult(ItemID.GoldChainmail)) {
                    ChangeIngredientCount(ItemID.GoldBar, 35, recipe);
                } else if (recipe.HasResult(ItemID.GoldAxe)) {
                    ChangeIngredientCount(ItemID.GoldBar, 9, recipe);
                } else if (recipe.HasResult(ItemID.GoldBroadsword)) {
                    ChangeIngredientCount(ItemID.GoldBar, 8, recipe);
                } else if (recipe.HasResult(ItemID.GoldHammer)) {
                    ChangeIngredientCount(ItemID.GoldBar, 19, recipe);
                } else if (recipe.HasResult(ItemID.GoldPickaxe)) {
                    ChangeIngredientCount(ItemID.GoldBar, 12, recipe);
                }

                 else if (recipe.HasResult(ItemID.PlatinumCrown)) {
                    ChangeIngredientCount(ItemID.PlatinumBar, 30, recipe);
                } else if (recipe.HasResult(ItemID.PlatinumGreaves)) {
                    ChangeIngredientCount(ItemID.PlatinumBar, 30, recipe);
                } else if (recipe.HasResult(ItemID.PlatinumHelmet)) {
                    ChangeIngredientCount(ItemID.PlatinumBar, 25, recipe);
                } else if (recipe.HasResult(ItemID.PlatinumChainmail)) {
                    ChangeIngredientCount(ItemID.PlatinumBar, 35, recipe);
                } else if (recipe.HasResult(ItemID.PlatinumAxe)) {
                    ChangeIngredientCount(ItemID.PlatinumBar, 9, recipe);
                } else if (recipe.HasResult(ItemID.PlatinumBroadsword)) {
                    ChangeIngredientCount(ItemID.PlatinumBar, 8, recipe);
                } else if (recipe.HasResult(ItemID.PlatinumHammer)) {
                    ChangeIngredientCount(ItemID.PlatinumBar, 19, recipe);
                } else if (recipe.HasResult(ItemID.PlatinumPickaxe)) {
                    ChangeIngredientCount(ItemID.PlatinumBar, 12, recipe);
                }

                 else if (recipe.HasResult(ItemID.MeteorHelmet)) {
                    ChangeIngredientCount(ItemID.MeteoriteBar, 15, recipe);
                } else if (recipe.HasResult(ItemID.MeteorLeggings)) {
                    ChangeIngredientCount(ItemID.MeteoriteBar, 20, recipe);
                } else if (recipe.HasResult(ItemID.MeteorSuit)) {
                    ChangeIngredientCount(ItemID.MeteoriteBar, 25, recipe);
                } else if (recipe.HasResult(ItemID.SpaceGun)) {
                    ChangeIngredientCount(ItemID.MeteoriteBar, 30, recipe);
                    recipe.AddIngredient(ItemID.FallenStar, 2);
                    recipe.AddIngredient(ItemID.FlintlockPistol, 1);
                } else if (recipe.HasResult(ItemID.MeteorHamaxe)) {
                    ChangeIngredientCount(ItemID.MeteoriteBar, 35, recipe);
                } else if (recipe.HasResult(ItemID.GreenPhaseblade)) {
                    ChangeIngredientCount(ItemID.MeteoriteBar, 20, recipe);
                    ChangeIngredientCount(ItemID.Emerald, 10, recipe);
                } else if (recipe.HasResult(ItemID.BluePhaseblade)) {
                    ChangeIngredientCount(ItemID.MeteoriteBar, 20, recipe);
                    ChangeIngredientCount(ItemID.Sapphire, 10, recipe);
                } else if (recipe.HasResult(ItemID.BluePhaseblade)) {
                    ChangeIngredientCount(ItemID.MeteoriteBar, 20, recipe);
                    ChangeIngredientCount(ItemID.Sapphire, 10, recipe);
                } else if (recipe.HasResult(ItemID.PurplePhaseblade)) {
                    ChangeIngredientCount(ItemID.MeteoriteBar, 20, recipe);
                    ChangeIngredientCount(ItemID.Amethyst, 10, recipe);
                } else if (recipe.HasResult(ItemID.RedPhaseblade)) {
                    ChangeIngredientCount(ItemID.MeteoriteBar, 20, recipe);
                    ChangeIngredientCount(ItemID.Ruby, 10, recipe);
                } else if (recipe.HasResult(ItemID.WhitePhaseblade)) {
                    ChangeIngredientCount(ItemID.MeteoriteBar, 20, recipe);
                    ChangeIngredientCount(ItemID.Diamond, 10, recipe);
                } else if (recipe.HasResult(ItemID.YellowPhaseblade)) {
                    ChangeIngredientCount(ItemID.MeteoriteBar, 20, recipe);
                    ChangeIngredientCount(ItemID.Topaz, 10, recipe);
                }

                 else if (recipe.HasResult(ItemID.JungleShirt)) {
                    ChangeIngredientCount(ItemID.Stinger, 12, recipe);
                } else if (recipe.HasResult(ItemID.BladeofGrass)) {
                    ChangeIngredientCount(ItemID.Stinger, 15, recipe);
                    recipe.RemoveIngredient(ItemID.Vine);
                } else if (recipe.HasResult(ItemID.ThornChakram)) {
                    ChangeIngredientCount(ItemID.Stinger, 15, recipe);
                }

                 else if (recipe.HasResult(ItemID.BlueTorch)) {
                    ChangeIngredientCount(ItemID.Torch, 3, recipe);
                } else if (recipe.HasResult(ItemID.GreenTorch)) {
                    ChangeIngredientCount(ItemID.Torch, 3, recipe);
                } else if (recipe.HasResult(ItemID.OrangeTorch)) {
                    ChangeIngredientCount(ItemID.Torch, 3, recipe);
                } else if (recipe.HasResult(ItemID.PurpleTorch)) {
                    ChangeIngredientCount(ItemID.Torch, 3, recipe);
                } else if (recipe.HasResult(ItemID.RedTorch)) {
                    ChangeIngredientCount(ItemID.Torch, 3, recipe);
                } else if (recipe.HasResult(ItemID.YellowTorch)) {
                    ChangeIngredientCount(ItemID.Torch, 3, recipe);
                } else if (recipe.HasResult(ItemID.WhiteTorch)) {
                    ChangeIngredientCount(ItemID.Torch, 3, recipe);
                }

                 else if (recipe.HasResult(ItemID.FlamingArrow)) {
                    ChangeIngredientCount(ItemID.WoodenArrow, 5, recipe);
                }
                
                // Removing EVERY craftable accessory not in console/3ds version
                
                else if (HasIngredient(ItemID.LunarOre) || HasIngredient(ItemID.LunarBar)) {
					recipe.DisableRecipe();
				} else if (HasIngredient(ItemID.FrogLeg)) {
					recipe.DisableRecipe();
				} else if (recipe.HasResult(ItemID.TerrasparkBoots) || recipe.HasResult(ItemID.FairyBoots)) {
					recipe.DisableRecipe();
				} else if (recipe.HasResult(ItemID.LavaWaders) && !HasIngredient(ItemID.LavaCharm)) {
					recipe.DisableRecipe();
				} else if (HasIngredient(ItemID.ObsidianRose)) {
					recipe.RemoveIngredient(ItemID.ObsidianRose);
				} else if (recipe.HasResult(ItemID.HellfireTreads)) {
					recipe.DisableRecipe();
				} else if (HasIngredient(ItemID.SailfishBoots) || HasIngredient(ItemID.SandBoots)) {
					recipe.DisableRecipe();
				} else if (HasIngredient(ItemID.SharkronBalloon) || HasIngredient(ItemID.TsunamiInABottle) || recipe.HasResult(ItemID.HorseshoeBundle) || recipe.HasResult(ItemID.BalloonHorseshoeHoney) || recipe.HasResult(ItemID.BalloonHorseshoeFart)) {
					recipe.DisableRecipe();
				} else if (recipe.HasResult(ItemID.CelestialShell)) {
					recipe.DisableRecipe();
				} else if (HasIngredient(ItemID.GPS) || HasIngredient(ItemID.REK) || HasIngredient(ItemID.FishFinder) || HasIngredient(ItemID.GoblinTech) || HasIngredient(ItemID.PDA) || HasIngredient(ItemID.Radar) || HasIngredient(ItemID.LifeformAnalyzer) || HasIngredient(ItemID.TallyCounter) || HasIngredient(ItemID.MetalDetector) || HasIngredient(ItemID.Stopwatch) || HasIngredient(ItemID.DPSMeter) || HasIngredient(ItemID.FishermansGuide) || HasIngredient(ItemID.WeatherRadio) || HasIngredient(ItemID.Sextant)) {
                    recipe.DisableRecipe();
                } else if (recipe.HasResult(ItemID.WireKite)) {
                    recipe.DisableRecipe();
                } else if (HasIngredient(ItemID.PutridScent)) {
                    recipe.DisableRecipe();
                } else if (HasIngredient(ItemID.ManaFlower)) {
                    recipe.DisableRecipe();
                } else if (HasIngredient(ItemID.FleshKnuckles)) {
                    recipe.DisableRecipe();
                } else if (HasIngredient(ItemID.MagicQuiver)) {
                    recipe.DisableRecipe();
                } else if (HasIngredient(ItemID.PocketMirror)) {
					recipe.RemoveIngredient(ItemID.PocketMirror);
				} else if (HasIngredient(ItemID.MoltenSkullRose)) {
                    recipe.DisableRecipe();
                } else if (HasIngredient(ItemID.ObsidianSkullRose)) {
                    recipe.DisableRecipe();
                } else if (recipe.HasResult(ItemID.StingerNecklace)) {
                    recipe.DisableRecipe();
                } else if (recipe.HasResult(ItemID.StingerNecklace)) {
                    recipe.DisableRecipe();
                } else if (recipe.HasResult(ItemID.ArchitectGizmoPack) || recipe.HasResult(ItemID.ActuationAccessory) || recipe.HasResult(ItemID.AncientChisel) || recipe.HasResult(ItemID.HandOfCreation)) {
                    recipe.DisableRecipe();
                } else if (HasIngredient(ItemID.FishingBobberGlowingStar)) {
                    recipe.DisableRecipe();
                } else if (HasIngredient(ItemID.FishingBobber)) {
                    recipe.DisableRecipe();
                } else if (HasIngredient(ItemID.LavaFishingHook)) {
                    recipe.DisableRecipe();
                } else if (HasIngredient(ItemID.FragmentVortex) || HasIngredient(ItemID.FragmentSolar) || HasIngredient(ItemID.FragmentStardust) || HasIngredient(ItemID.FragmentNebula)) {
                    recipe.DisableRecipe();
                } else if (HasIngredient(ItemID.GolfBall)) {
                    recipe.DisableRecipe();
                } else if (HasIngredient(ItemID.SpectreBar)) {
                    recipe.DisableRecipe();
                } else if (recipe.HasResult(ItemID.BeetleWings)) {
                    recipe.DisableRecipe();
                }

                // Removing EVERY craftable weapon not available in console/3ds version

                else if (recipe.HasResult(ItemID.Chik) || recipe.HasResult(ItemID.HiveFive) || recipe.HasResult(ItemID.JungleYoyo) || recipe.HasResult(ItemID.WoodYoyo) || recipe.HasResult(ItemID.CorruptYoyo) || recipe.HasResult(ItemID.CrimsonYoyo)) {
                    recipe.DisableRecipe();
                } else if (HasIngredient(ItemID.Mace)) {
                    recipe.DisableRecipe();
                } else if (recipe.HasResult(ItemID.SwordWhip) || recipe.HasResult(ItemID.HallowedHood) || recipe.HasResult(ItemID.HallowJoustingLance)) {
                    recipe.DisableRecipe();
                } else if (HasIngredient(ItemID.AshWood)) {
                    recipe.DisableRecipe();
                } else if (HasIngredient(ItemID.StarCannon)) {
                    recipe.DisableRecipe();
                } else if (HasIngredient(ItemID.WandofSparking)) {
                    recipe.DisableRecipe();
                } else if (HasIngredient(ItemID.FossilOre)) {
                    recipe.DisableRecipe();
                } else if (HasIngredient(ItemID.MagicMissile)) {
                    recipe.DisableRecipe();
                } else if (recipe.HasResult(ItemID.MeteorStaff)) {
                    recipe.DisableRecipe();
                } else if (HasIngredient(ItemID.DjinnLamp) || HasIngredient(ItemID.AncientBattleArmorMaterial)) {
                    recipe.DisableRecipe();
                } else if (recipe.HasResult(ItemID.BoneWhip)) {
                    recipe.DisableRecipe();
                } else if (recipe.HasResult(ItemID.CoolWhip)) {
                    recipe.DisableRecipe();
                } else if (recipe.HasResult(ItemID.StickyDynamite)) {
                    recipe.DisableRecipe();
                } else if (recipe.HasResult(ItemID.BloodWater)) {
                    recipe.DisableRecipe();
                } else if (recipe.HasResult(ItemID.MechdusaSummon)) {
                    recipe.DisableRecipe();
                } else if (HasIngredient(ItemID.Stinkbug)) {
                    recipe.DisableRecipe();
                }

                // Removing other things that is not available in console/3ds version

                 else if (HasIngredient(ItemID.FlinxFur)) {
                    recipe.DisableRecipe();
                } else if (recipe.HasResult(ItemID.ChlorophyteExtractinator)) {
                    recipe.DisableRecipe();
                } else if (recipe.HasResult(ItemID.Beenade)) {
                    recipe.DisableRecipe();
                } else if (recipe.HasResult(ItemID.DemonTorch)) {
                    recipe.DisableRecipe();
                } else if (recipe.HasResult(ItemID.ObsidianShirt)) {
                    recipe.DisableRecipe();
                } else if (recipe.HasResult(ItemID.ObsidianHelm)) {
                    recipe.DisableRecipe();
                } else if (recipe.HasResult(ItemID.ObsidianPants)) {
                    recipe.DisableRecipe();
                } else if (recipe.HasResult(ItemID.ToiletObsidian)) {
                    recipe.DisableRecipe();
                } else if (recipe.HasResult(ItemID.ObsidianBackEcho)) {
                    recipe.DisableRecipe();
                } else if (recipe.HasResult(ItemID.ObsidianSink)) {
                    recipe.DisableRecipe();
                } else if (recipe.HasResult(ItemID.ObsidianChest)) {
                    recipe.DisableRecipe();
                } else if (recipe.HasResult(ItemID.AncientHallowedHood)) {
                    recipe.DisableRecipe();
                } else if (recipe.HasResult(ItemID.AncientHallowedHelmet)) {
                    recipe.DisableRecipe();
                } else if (recipe.HasResult(ItemID.AncientHallowedHeadgear)) {
                    recipe.DisableRecipe();
                } else if (recipe.HasResult(ItemID.AncientHallowedMask)) {
                    recipe.DisableRecipe();
                } else if (recipe.HasResult(ItemID.AncientHallowedPlateMail)) {
                    recipe.DisableRecipe();
                } else if (recipe.HasResult(ItemID.AncientHallowedGreaves)) {
                    recipe.DisableRecipe();
                } else if (HasIngredient(ItemID.NightVisionHelmet)) {
                    recipe.DisableRecipe();
                } else if (recipe.HasResult(ItemID.GlassCandle) || recipe.HasResult(ItemID.LesionCandle) || recipe.HasResult(ItemID.SkywareCandle) || recipe.HasResult(ItemID.BalloonCandle) || recipe.HasResult(ItemID.BambooCandle) || recipe.HasResult(ItemID.CrystalCandle) || recipe.HasResult(ItemID.DynastyCandle) || recipe.HasResult(ItemID.GraniteCandle) || recipe.HasResult(ItemID.MarbleCandle) || recipe.HasResult(ItemID.MartianHoverCandle) || recipe.HasResult(ItemID.MeteoriteCandle) || recipe.HasResult(ItemID.PalmWoodCandle) || recipe.HasResult(ItemID.PeaceCandle) || recipe.HasResult(ItemID.PumpkinCandle) || recipe.HasResult(ItemID.SandstoneCandle) || recipe.HasResult(ItemID.SpiderCandle) || recipe.HasResult(ItemID.ShadowCandle)) {
                    recipe.DisableRecipe();
                } else if (recipe.HasResult(ItemID.GlassChandelier) || recipe.HasResult(ItemID.SkywareChandelier) || recipe.HasResult(ItemID.BoneChandelier) || recipe.HasResult(ItemID.DynastyChandelier) || recipe.HasResult(ItemID.PalmWoodChandelier) || recipe.HasResult(ItemID.FleshChandelier) || recipe.HasResult(ItemID.BalloonChandelier) || recipe.HasResult(ItemID.BambooChandelier) || recipe.HasResult(ItemID.PumpkinChandelier)) {
                    recipe.DisableRecipe();
                } else if (HasIngredient(ItemID.CrystalBlock)) {
                    recipe.DisableRecipe();
                } else if (HasIngredient(ItemID.GraniteBlock)) {
                    recipe.DisableRecipe();
                } else if (HasIngredient(ItemID.MartianConduitPlating)) {
                    recipe.DisableRecipe();
                } else if (HasIngredient(ItemID.MeteoriteBrick)) {
                    recipe.DisableRecipe();
                } else if (HasIngredient(ItemID.ReefBlock)) {
                    recipe.DisableRecipe();
                } else if (HasIngredient(ItemID.SmoothSandstone)) {
                    recipe.DisableRecipe();
                } else if (HasIngredient(ItemID.SpiderBlock)) {
                    recipe.DisableRecipe();
                } else if (HasIngredient(ItemID.LesionBlock)) {
                    recipe.DisableRecipe();
                } else if (HasIngredient(ItemID.PinkGel)) {
                    recipe.DisableRecipe();
                } else if (recipe.HasResult(ItemID.WroughtIronFence)) {
                    recipe.DisableRecipe();
                } else if (recipe.HasResult(ItemID.MagicMirror)) {
                    recipe.DisableRecipe();
                } else if (recipe.HasResult(ItemID.OrangePhaseblade)) {
                    recipe.DisableRecipe();
                } else if (recipe.HasResult(ItemID.VoidLens)) {
                    recipe.DisableRecipe();
                } else if (recipe.HasResult(ItemID.VoidVault)) {
                    recipe.DisableRecipe();
                } else if (HasIngredient(ItemID.StaffofRegrowth)) {
                    recipe.DisableRecipe();
                } else if (HasIngredient(ItemID.TrueNightsEdge)) {
                    recipe.DisableRecipe();
                } else if (HasIngredient(ItemID.TrueExcalibur)) {
                    recipe.DisableRecipe();
                } else if (recipe.HasResult(ItemID.TrueNightsEdge)) {
                    recipe.DisableRecipe();
                } else if (recipe.HasResult(ItemID.TrueExcalibur)) {
                    recipe.DisableRecipe();
                } else if (recipe.HasResult(ItemID.WormholePotion)) {
                    recipe.DisableRecipe();
                }

                //Disable crafting stations not available in console/3ds version

                else if (recipe.HasTile(ItemID.ChlorophyteExtractinator)) {
                    recipe.DisableRecipe();
                } else if (recipe.HasTile(ItemID.LunarCraftingStation)) {
                    recipe.DisableRecipe();
                }
            }
        }
    }
}