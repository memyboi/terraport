using System;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace terraport.Items.Weapons.fakes
{
    public class fakestexcalibur : ModItem
    {
        readonly float cooldownTime = 30f; // in ms (200ms)

        public override void SetDefaults() {
            Item.useStyle = ItemUseStyleID.Swing;
            Item.useAnimation = 16;
            Item.useTime = 16;
            Item.shoot = ProjectileID.LightBeam;
            Item.DamageType = DamageClass.Melee;
            Item.shootSpeed = 11f;
            Item.knockBack = 4.5f;
            Item.width = 40;
            Item.height = 40;
            Item.damage = 66;
            Item.scale = 1.05f;
            Item.UseSound = SoundID.Item1;
            Item.rare = ItemRarityID.Yellow;
            Item.value = Item.sellPrice(0, 10, 0, 0);
            Item.noMelee = false;
        }

        public override bool CanShoot(Player player)
        {
            return !player.GetModPlayer<plr>().fakeexcaliburstart;
        }

        public override void MeleeEffects(Player player, Rectangle hitbox)
        {
            int dust = Dust.NewDust(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, DustID.Enchanted_Gold, 0f, 0f, 150, default, 1.5f); //55, 174, 6
			Main.dust[dust].noGravity = true;
            if (player.GetModPlayer<plr>().fakeexcaliburstart) return;
            player.GetModPlayer<plr>().fakeexcaliburcooldown = (int)(cooldownTime / player.GetAttackSpeed(DamageClass.Melee));
            player.GetModPlayer<plr>().fakeexcaliburstart = true;
        }
    }
}