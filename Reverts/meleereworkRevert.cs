using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace terraport.Reverts
{
    public class meleereworkRevert : GlobalItem
    {
        public void defaultOverwrite(Item item) {
            item.shoot = ProjectileID.None;
            item.noMelee = false;
        }

        public override void SetDefaults(Item item) {
            switch (item.type) {
                case ItemID.Excalibur:
                    defaultOverwrite(item);
                break;
                case ItemID.NightsEdge:
                    defaultOverwrite(item);
                break;
                case ItemID.TrueNightsEdge:
                    defaultOverwrite(item);
                    item.useStyle = ItemUseStyleID.Swing;
                    item.useAnimation = 26;
                    item.useTime = 26;
                    item.shoot = ProjectileID.NightBeam;
                    item.shootSpeed = 10f;
                    item.knockBack = 4.75f;
                    item.width = 40;
                    item.height = 40;
                    item.damage = 105;
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
                break;
            }
        }

        public override void MeleeEffects(Item item, Player player, Rectangle hitbox) {
            switch(item.type) {
                case ItemID.TrueNightsEdge:
                    
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