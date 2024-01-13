using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.DataStructures;

namespace terraport.Reverts
{
    public class npcDelete : GlobalNPC
    {

        void Deletion(NPC npc) {
            npc.life = -10; //temp solution until tmodloader adds just flatout removing entities from spawn pools
            //might effect spawn rates but i haven't noticed anything + idrc
        }

        public override void OnSpawn(NPC npc, IEntitySource source)
        {
            switch(npc.type) {
                case NPCID.GreekSkeleton:
                    Deletion(npc);
                break;
                case NPCID.Ghost:
                    Deletion(npc);
                break;
                case NPCID.WebbedStylist:
                    Deletion(npc);
                break;
                case NPCID.ChatteringTeethBomb:
                    Deletion(npc);
                break;
                case NPCID.MartianProbe:
                    Deletion(npc);
                break;
                case NPCID.MartianSaucer:
                    Deletion(npc);
                break;
                case NPCID.MoonLordHand:
                    Deletion(npc);
                break;
                case NPCID.MoonLordHead:
                    Deletion(npc);
                break;
                case NPCID.MoonLordCore:
                    Deletion(npc);
                break;
                case NPCID.MoonLordFreeEye:
                    Deletion(npc);
                break;
                case NPCID.MoonLordLeechBlob:
                    Deletion(npc);
                break;
                case NPCID.LunarTowerVortex:
                    Deletion(npc);
                break;
                case NPCID.LunarTowerNebula:
                    Deletion(npc);
                break;
                case NPCID.LunarTowerSolar:
                    Deletion(npc);
                break;
                case NPCID.CultistTablet:
                    Deletion(npc);
                break;
                case NPCID.CultistBoss:
                    Deletion(npc);
                break;
                case NPCID.CultistBossClone:
                    Deletion(npc);
                break;
                case NPCID.SolarCrawltipedeBody:
                    Deletion(npc);
                break;
                case NPCID.SolarCrawltipedeHead:
                    Deletion(npc);
                break;
                case NPCID.SolarCrawltipedeTail:
                    Deletion(npc);
                break;
                case NPCID.SolarCorite:
                    Deletion(npc);
                break;
                case NPCID.SolarSolenian:
                    Deletion(npc);
                break;
                case NPCID.SolarSroller:
                    Deletion(npc);
                break;
                case NPCID.SolarDrakomire:
                    Deletion(npc);
                break;
                case NPCID.SolarDrakomireRider:
                    Deletion(npc);
                break;
                case NPCID.StardustCellBig:
                    Deletion(npc);
                break;
                case NPCID.StardustCellSmall:
                    Deletion(npc);
                break;
                case NPCID.StardustJellyfishBig:
                    Deletion(npc);
                break;
                case NPCID.StardustJellyfishSmall:
                    Deletion(npc);
                break;
                case NPCID.StardustSpiderBig:
                    Deletion(npc);
                break;
                case NPCID.StardustSpiderSmall:
                    Deletion(npc);
                break;
                case NPCID.StardustSoldier:
                    Deletion(npc);
                break;
                case NPCID.StardustWormBody:
                    Deletion(npc);
                break;
                case NPCID.StardustWormHead:
                    Deletion(npc);
                break;
                case NPCID.StardustWormTail:
                    Deletion(npc);
                break;
                case NPCID.ForceBubble:
                    Deletion(npc);
                break;
                case NPCID.MartianTurret:
                    Deletion(npc);
                break;
                case NPCID.MartianOfficer:
                    Deletion(npc);
                break;
                case NPCID.MartianEngineer:
                    Deletion(npc);
                break;
                case NPCID.MartianDrone:
                    Deletion(npc);
                break;
                case NPCID.GrayGrunt:
                    Deletion(npc);
                break;
                case NPCID.Scutlix:
                    Deletion(npc);
                break;
                case NPCID.ScutlixRider:
                    Deletion(npc);
                break;
                case NPCID.RayGunner:
                    Deletion(npc);
                break;
                case NPCID.BrainScrambler:
                    Deletion(npc);
                break;
                case NPCID.CultistArcherBlue:
                    Deletion(npc);
                break;
                case NPCID.CultistArcherWhite:
                    Deletion(npc);
                break;
                case NPCID.CultistDevote:
                    Deletion(npc);
                break;
                case NPCID.CultistDragonBody1:
                    Deletion(npc);
                break;
                case NPCID.CultistDragonBody2:
                    Deletion(npc);
                break;
                case NPCID.CultistDragonBody3:
                    Deletion(npc);
                break;
                case NPCID.CultistDragonBody4:
                    Deletion(npc);
                break;
                case NPCID.CultistDragonTail:
                    Deletion(npc);
                break;
                case NPCID.CultistDragonHead:
                    Deletion(npc);
                break;
                case NPCID.NebulaBrain:
                    Deletion(npc);
                break;
                case NPCID.NebulaSoldier:
                    Deletion(npc);
                break;
                case NPCID.NebulaHeadcrab:
                    Deletion(npc);
                break;
                case NPCID.NebulaBeast:
                    Deletion(npc);
                break;
                case NPCID.VortexHornet:
                    Deletion(npc);
                break;
                case NPCID.VortexHornetQueen:
                    Deletion(npc);
                break;
                case NPCID.VortexLarva:
                    Deletion(npc);
                break;
                case NPCID.VortexRifleman:
                    Deletion(npc);
                break;
                case NPCID.VortexSoldier:
                    Deletion(npc);
                break;
                case NPCID.GoldBird:
                    Deletion(npc);
                break;
                case NPCID.GoldBunny:
                    Deletion(npc);
                break;
                case NPCID.GoldButterfly:
                    Deletion(npc);
                break;
                case NPCID.GoldDragonfly:
                    Deletion(npc);
                break;
                case NPCID.GoldFrog:
                    Deletion(npc);
                break;
                case NPCID.GoldGoldfish:
                    Deletion(npc);
                break;
                case NPCID.GoldGoldfishWalker:
                    Deletion(npc);
                break;
                case NPCID.GoldGrasshopper:
                    Deletion(npc);
                break;
                case NPCID.GoldLadyBug:
                    Deletion(npc);
                break;
                case NPCID.GoldMouse:
                    Deletion(npc);
                break;
                case NPCID.GoldSeahorse:
                    Deletion(npc);
                break;
                case NPCID.GoldWaterStrider:
                    Deletion(npc);
                break;
                case NPCID.GoldWorm:
                    Deletion(npc);
                break;
                case NPCID.WaterStrider:
                    Deletion(npc);
                break;
                case NPCID.Owl:
                    Deletion(npc);
                break;
                case NPCID.Rat:
                    Deletion(npc);
                break;
                case NPCID.Grebe:
                    Deletion(npc);
                break;
                case NPCID.Grebe2:
                    Deletion(npc);
                break;
                case NPCID.Maggot:
                    Deletion(npc);
                break;
                case NPCID.MaggotZombie:
                    Deletion(npc);
                break;
                case NPCID.LadyBug:
                    Deletion(npc);
                break;
                case NPCID.Seagull:
                    Deletion(npc);
                break;
                case NPCID.Seagull2:
                    Deletion(npc);
                break;
                case NPCID.RedDragonfly:
                    Deletion(npc);
                break;
                case NPCID.BlueDragonfly:
                    Deletion(npc);
                break;
                case NPCID.BlackDragonfly:
                    Deletion(npc);
                break;
                case NPCID.GreenDragonfly:
                    Deletion(npc);
                break;
                case NPCID.OrangeDragonfly:
                    Deletion(npc);
                break;
                case NPCID.YellowDragonfly:
                    Deletion(npc);
                break;
                case NPCID.WindyBalloon:
                    Deletion(npc);
                break;
                case NPCID.FairyCritterBlue:
                    Deletion(npc);
                break;
                case NPCID.FairyCritterGreen:
                    Deletion(npc);
                break;
                case NPCID.FairyCritterPink:
                    Deletion(npc);
                break;
                case NPCID.SandShark:
                    Deletion(npc);
                break;
                case NPCID.SandsharkCorrupt:
                    Deletion(npc);
                break;
                case NPCID.SandsharkCrimson:
                    Deletion(npc);
                break;
                case NPCID.SandsharkHallow:
                    Deletion(npc);
                break;
                case NPCID.SandElemental:
                    Deletion(npc);
                break;
                case NPCID.SquirrelGold:
                    Deletion(npc);
                break;
                case NPCID.SquirrelRed:
                    Deletion(npc);
                break;
                case NPCID.SandSlime:
                    Deletion(npc);
                break;
                case NPCID.DesertBeast:
                    Deletion(npc);
                break;
                case NPCID.DesertDjinn:
                    Deletion(npc);
                break;
                case NPCID.DesertGhoul:
                    Deletion(npc);
                break;
                case NPCID.DesertGhoulCorruption:
                    Deletion(npc);
                break;
                case NPCID.DesertGhoulCrimson:
                    Deletion(npc);
                break;
                case NPCID.DesertGhoulHallow:
                    Deletion(npc);
                break;
                case NPCID.DesertLamiaDark:
                    Deletion(npc);
                break;
                case NPCID.DesertLamiaLight:
                    Deletion(npc);
                break;
                case NPCID.DesertScorpionWall:
                    Deletion(npc);
                break;
                case NPCID.DesertScorpionWalk:
                    Deletion(npc);
                break;
                case NPCID.SolarSpearman:
                    Deletion(npc);
                break;
                case NPCID.SolarGoop:
                    Deletion(npc);
                break;
                case NPCID.DuneSplicerBody:
                    Deletion(npc);
                break;
                case NPCID.DuneSplicerHead:
                    Deletion(npc);
                break;
                case NPCID.DuneSplicerTail:
                    Deletion(npc);
                break;
                case NPCID.TombCrawlerBody:
                    Deletion(npc);
                break;
                case NPCID.TombCrawlerTail:
                    Deletion(npc);
                break;
                case NPCID.TombCrawlerHead:
                    Deletion(npc);
                break;
                case NPCID.Tumbleweed:
                    Deletion(npc);
                break;
                case NPCID.DD2EterniaCrystal:
                    Deletion(npc);
                break;
                case NPCID.DD2AttackerTest:
                    Deletion(npc);
                break;
                case NPCID.DD2LanePortal:
                    Deletion(npc);
                break;
                case NPCID.DD2Betsy:
                    Deletion(npc);
                break;
                case NPCID.DD2GoblinBomberT1:
                    Deletion(npc);
                break;
                case NPCID.DD2GoblinBomberT2:
                    Deletion(npc);
                break;
                case NPCID.DD2GoblinBomberT3:
                    Deletion(npc);
                break;
                case NPCID.DD2GoblinT1:
                    Deletion(npc);
                break;
                case NPCID.DD2GoblinT2:
                    Deletion(npc);
                break;
                case NPCID.DD2GoblinT3:
                    Deletion(npc);
                break;
                case NPCID.DD2WyvernT1:
                    Deletion(npc);
                break;
                case NPCID.DD2WyvernT2:
                    Deletion(npc);
                break;
                case NPCID.DD2WyvernT3:
                    Deletion(npc);
                break;
                case NPCID.DD2JavelinstT1:
                    Deletion(npc);
                break;
                case NPCID.DD2JavelinstT2:
                    Deletion(npc);
                break;
                case NPCID.DD2JavelinstT3:
                    Deletion(npc);
                break;
                case NPCID.DD2DarkMageT1:
                    Deletion(npc);
                break;
                case NPCID.DD2DarkMageT3:
                    Deletion(npc);
                break;
                case NPCID.DD2SkeletonT1:
                    Deletion(npc);
                break;
                case NPCID.DD2SkeletonT3:
                    Deletion(npc);
                break;
                case NPCID.DD2WitherBeastT2:
                    Deletion(npc);
                break;
                case NPCID.DD2WitherBeastT3:
                    Deletion(npc);
                break;
                case NPCID.DD2DrakinT2:
                    Deletion(npc);
                break;
                case NPCID.DD2DrakinT3:
                    Deletion(npc);
                break;
                case NPCID.DD2KoboldFlyerT2:
                    Deletion(npc);
                break;
                case NPCID.DD2KoboldFlyerT3:
                    Deletion(npc);
                break;
                case NPCID.DD2KoboldWalkerT2:
                    Deletion(npc);
                break;
                case NPCID.DD2KoboldWalkerT3:
                    Deletion(npc);
                break;
                case NPCID.DD2OgreT2:
                    Deletion(npc);
                break;
                case NPCID.DD2OgreT3:
                    Deletion(npc);
                break;
                case NPCID.DD2LightningBugT3:
                    Deletion(npc);
                break;
                case NPCID.BartenderUnconscious:
                    Deletion(npc);
                break;
                case NPCID.WalkingAntlion:
                    Deletion(npc);
                break;
                case NPCID.FlyingAntlion:
                    Deletion(npc);
                break;
                case NPCID.LarvaeAntlion:
                    Deletion(npc);
                break;
                case NPCID.ZombieMerman:
                    Deletion(npc);
                break;
                case NPCID.EyeballFlyingFish:
                    Deletion(npc);
                break;
                case NPCID.GolferRescue:
                    Deletion(npc);
                break;
                case NPCID.Pupfish:
                    Deletion(npc);
                break;
                case NPCID.Dolphin:
                    Deletion(npc);
                break;
                case NPCID.Turtle:
                    Deletion(npc);
                break;
                case NPCID.TurtleJungle:
                    Deletion(npc);
                break;
                case NPCID.BloodNautilus:
                    Deletion(npc);
                break;
                case NPCID.BloodSquid:
                    Deletion(npc);
                break;
                case NPCID.GoblinShark:
                    Deletion(npc);
                break;
                case NPCID.BloodEelBody:
                    Deletion(npc);
                break;
                case NPCID.BloodEelHead:
                    Deletion(npc);
                break;
                case NPCID.BloodEelTail:
                    Deletion(npc);
                break;
                case NPCID.Gnome:
                    Deletion(npc);
                break;
                case NPCID.Seahorse:
                    Deletion(npc);
                break;
                case NPCID.SeaTurtle:
                    Deletion(npc);
                break;
                case NPCID.Dandelion:
                    Deletion(npc);
                break;
                case NPCID.BloodMummy:
                    Deletion(npc);
                break;
                case NPCID.SporeBat:
                    Deletion(npc);
                break;
                case NPCID.EmpressButterfly:
                    Deletion(npc);
                break;
                case NPCID.HallowBoss:
                    Deletion(npc);
                break;
                case NPCID.QueenSlimeBoss:
                    Deletion(npc);
                break;
                case NPCID.QueenSlimeMinionBlue:
                    Deletion(npc);
                break;
                case NPCID.QueenSlimeMinionPink:
                    Deletion(npc);
                break;
                case NPCID.QueenSlimeMinionPurple:
                    Deletion(npc);
                break;
                case NPCID.MagmaSnail:
                    Deletion(npc);
                break;
                case NPCID.HellButterfly:
                    Deletion(npc);
                break;
                case NPCID.Lavafly:
                    Deletion(npc);
                break;
                case NPCID.GemBunnyAmethyst:
                    Deletion(npc);
                break;
                case NPCID.GemBunnyAmber:
                    Deletion(npc);
                break;
                case NPCID.GemBunnyDiamond:
                    Deletion(npc);
                break;
                case NPCID.GemBunnyRuby:
                    Deletion(npc);
                break;
                case NPCID.GemBunnyEmerald:
                    Deletion(npc);
                break;
                case NPCID.GemBunnySapphire:
                    Deletion(npc);
                break;
                case NPCID.GemBunnyTopaz:
                    Deletion(npc);
                break;
                case NPCID.GemSquirrelAmethyst:
                    Deletion(npc);
                break;
                case NPCID.GemSquirrelAmber:
                    Deletion(npc);
                break;
                case NPCID.GemSquirrelDiamond:
                    Deletion(npc);
                break;
                case NPCID.GemSquirrelRuby:
                    Deletion(npc);
                break;
                case NPCID.GemSquirrelEmerald:
                    Deletion(npc);
                break;
                case NPCID.GemSquirrelSapphire:
                    Deletion(npc);
                break;
                case NPCID.GemSquirrelTopaz:
                    Deletion(npc);
                break;
                case NPCID.TorchGod:
                    Deletion(npc);
                break;
                case NPCID.Deerclops:
                    Deletion(npc);
                break;
                case NPCID.Stinkbug:
                    Deletion(npc);
                break;
                case NPCID.ScarletMacaw:
                    Deletion(npc);
                break;
                case NPCID.BlueMacaw:
                    Deletion(npc);
                break;
                case NPCID.YellowCockatiel:
                    Deletion(npc);
                break;
                case NPCID.GrayCockatiel:
                    Deletion(npc);
                break;
                case NPCID.Shimmerfly:
                    Deletion(npc);
                break;
                case NPCID.ShimmerSlime:
                    Deletion(npc);
                break;
                case NPCID.BoundTownSlimeOld:
                    Deletion(npc);
                break;
                case NPCID.BoundTownSlimePurple:
                    Deletion(npc);
                break;
                case NPCID.BoundTownSlimeYellow:
                    Deletion(npc);
                break;
                case NPCID.AncientLight:
                    Deletion(npc);
                break;
                case NPCID.AncientDoom:
                    Deletion(npc);
                break;
                case NPCID.AncientCultistSquidhead:
                    Deletion(npc);
                break;
                case NPCID.MartianWalker:
                    Deletion(npc);
                break;
                case NPCID.Salamander:
                    Deletion(npc);
                break;
                case NPCID.Salamander2:
                    Deletion(npc);
                break;
                case NPCID.Salamander3:
                    Deletion(npc);
                break;
                case NPCID.Salamander4:
                    Deletion(npc);
                break;
                case NPCID.Salamander5:
                    Deletion(npc);
                break;
                case NPCID.Salamander6:
                    Deletion(npc);
                break;
                case NPCID.Salamander7:
                    Deletion(npc);
                break;
                case NPCID.Salamander8:
                    Deletion(npc);
                break;
                case NPCID.Salamander9:
                    Deletion(npc);
                break;
                case NPCID.GiantShelly:
                    Deletion(npc);
                break;
                case NPCID.GiantShelly2:
                    Deletion(npc);
                break;
                case NPCID.Crawdad:
                    Deletion(npc);
                break;
                case NPCID.Crawdad2:
                    Deletion(npc);
                break;
                case NPCID.PirateShip:
                    Deletion(npc);
                break;
                case NPCID.PirateShipCannon:
                    Deletion(npc);
                break;
                case NPCID.Drippler:
                    Deletion(npc);
                break;
                case NPCID.BloodZombie:
                    Deletion(npc);
                break;
                case NPCID.Sluggy:
                    Deletion(npc);
                break;
                case NPCID.Buggy:
                    Deletion(npc);
                break;
                case NPCID.Grubby:
                    Deletion(npc);
                break;
                case NPCID.EnchantedNightcrawler:
                    Deletion(npc);
                break;
                case NPCID.GraniteFlyer:
                    Deletion(npc);
                break;
                case NPCID.GraniteGolem:
                    Deletion(npc);
                break;
                case NPCID.Medusa:
                    Deletion(npc);
                break;
                case NPCID.Mothron:
                    Deletion(npc);
                break;
                case NPCID.MothronEgg:
                    Deletion(npc);
                break;
                case NPCID.BigMimicJungle:
                    Deletion(npc);
                break;
                case NPCID.BigMimicCorruption:
                    Deletion(npc);
                break;
                case NPCID.BigMimicCrimson:
                    Deletion(npc);
                break;
                case NPCID.BigMimicHallow:
                    Deletion(npc);
                break;
                case NPCID.ShadowFlameApparition:
                    Deletion(npc);
                break;
                case NPCID.GoblinSummoner:
                    Deletion(npc);
                break;
                case NPCID.CrimsonPenguin:
                    Deletion(npc);
                break;
                case NPCID.ThePossessed:
                    Deletion(npc);
                break;
                case NPCID.DrManFly:
                    Deletion(npc);
                break;
                case NPCID.DeadlySphere:
                    Deletion(npc);
                break;
                case NPCID.Psycho:
                    Deletion(npc);
                break;
                case NPCID.CrimsonGoldfish:
                    Deletion(npc);
                break;
                case NPCID.CrimsonBunny:
                    Deletion(npc);
                break;
                case NPCID.Nailhead:
                    Deletion(npc);
                break;
                case NPCID.Fritz:
                    Deletion(npc);
                break;
                case NPCID.CreatureFromTheDeep:
                    Deletion(npc);
                break;
                case NPCID.Butcher:
                    Deletion(npc);
                break;
                case NPCID.SkeletonMerchant:
                    Deletion(npc);
                break;
            }
        }
    }
}