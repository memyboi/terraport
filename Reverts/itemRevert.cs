using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using System.Collections.Generic;
using System.Linq;
using Terraria.DataStructures;
using Terraria.Localization;
using Terraria.UI;

namespace terraport.Reverts
{
    public class itemRevert : GlobalItem
    {
        public void defaultOverwrite(Item item) {
            item.shoot = ProjectileID.None;
            item.noMelee = false;
        }

        static int[] itemRemovementIds = {
			3068,3084,3093,2880,2800,674,675,3278,3285,3279,3280,3281,3262,3282,3317,3283,3315,3290,3289,3316,3284,3286,3287,3288,3291,3292,3389,3306,3301,3308,3305,3299,3297,3296,3294,3304,3302,3307,3293,3300,3298,3295,3544,2756,2997,678
		};

        void bork(Item item) {
            item.useStyle = ItemUseStyleID.None;
            item.noMelee = true;
            item.noUseGraphic = true;
            item.accessory = false;
            item.damage = 0;
            item.knockBack = 0;
            item.shoot = ProjectileID.None;
            item.useAmmo = 0;
            item.axe = 0;
            item.pick = 0;
            item.value = 0;
            item.crit = 0;
            item.consumable = false;
            item.ammo = 0;
            item.hammer = 0;
            item.defense = 0;
            item.width = 64;
            item.height = 64;
            item.autoReuse = false;
            item.bait = 0;
            item.channel = false;
            item.createTile = -1;
            item.createWall = -1;
            item.DD2Summon = false;
            item.glowMask = -1;
            item.holdStyle = 0;
            item.material = false;
            item.mountType = 0;
            item.placeStyle = 0;
            item.potion = false;
            item.tileBoost = 0;
            item.useAnimation = 0;
        }

        public override void SetDefaults(Item item) {
            if (item.type > ItemID.DjinnsCurse && item.type < ItemID.DontHurtComboBookInactive+1) {bork(item); return;} //this works cuz the ids are just ints
            for (int i = 0; i < itemRemovementIds.Length; i++) {
                if (item.type == itemRemovementIds[i] && item.type != ItemID.SleepingIcon) {
                    bork(item);
                }
			}
            switch (item.type) {
                case ItemID.Muramasa:
                    defaultOverwrite(item);
                break;
                case ItemID.Excalibur:
                    defaultOverwrite(item);
                    item.damage = 47;
                    item.useTime = 25;
                break;
                case ItemID.NightsEdge:
                    defaultOverwrite(item);
                    item.damage = 42;
                break;
                case ItemID.TrueNightsEdge:
                    defaultOverwrite(item);
                    item.useStyle = ItemUseStyleID.Swing;
                    item.useAnimation = 26;
                    item.useTime = 26;
                    item.shoot = ProjectileID.NightBeam;
                    item.shootSpeed = 10f;
                    item.knockBack = 4.75f;
                    item.crit = 4;
                    item.width = 40;
                    item.height = 40;
                    item.damage = 78;
                    item.scale = 1.15f;
                    item.UseSound = SoundID.Item1;
                    item.rare = ItemRarityID.Yellow;
                    item.value = Item.sellPrice(gold: 10);
                    item.noMelee = false;
                break;
                case ItemID.TrueExcalibur:
                    defaultOverwrite(item);
                    item.shoot = ProjectileID.LightBeam;
                break;
                case ItemID.TerraBlade:
                    defaultOverwrite(item);
                    item.shoot = ProjectileID.TerraBeam;
                break;
                case ItemID.TheHorsemansBlade:
                    defaultOverwrite(item);
                break;
                case ItemID.BladeofGrass:
                    defaultOverwrite(item);
                    item.useStyle = ItemUseStyleID.Swing;
                    item.useAnimation = 30;
                    item.knockBack = 3f;
                    item.width = 40;
                    item.height = 40;
                    item.damage = 28;
                    item.scale = 1.4f;
                    item.UseSound = SoundID.Item1;
                    item.rare = ItemRarityID.Orange;
                    item.value = 27000;
                    item.noMelee = false;
                break;
                case ItemID.Ruler:
                    defaultOverwrite(item);
                    item.noMelee = true;
                    item.noUseGraphic = true;
                    item.DamageType = DamageClass.Generic;
                    item.useStyle = ItemUseStyleID.None;
                    item.accessory = true;
                    item.damage = 0;
                    item.useTime = 0;
                    item.knockBack = 0;
                break;
                case ItemID.LightsBane:
                    defaultOverwrite(item);
                    item.damage = 17;
                    item.glowMask = -1;
                break;
            }
        }

        public override void MeleeEffects(Item item, Player player, Rectangle hitbox) {
            switch(item.type) {
                case ItemID.Excalibur:
                    int dust = Dust.NewDust(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, DustID.Enchanted_Gold, 0f, 0f, 150, default, 1.5f); //55, 174, 6
			        Main.dust[dust].noGravity = true;
                break;
            }
        }

        public override void OnHitNPC(Item item, Player player, NPC target, NPC.HitInfo hitinfo, int damage) {
            switch(item.type) {
                case ItemID.TheHorsemansBlade:
                    // spawn ProjectileID.FlamingJack
                break;
                case ItemID.BloodButcherer:
                    
                break;
            }
        }
    }
}