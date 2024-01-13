using System;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace terraport.Items.Weapons.fakes
{
    public class faketerrablade : ModItem
    {
        readonly float cooldownTime = 30f; // in ms (200ms)

        public override void SetDefaults() {
            Item.DamageType = DamageClass.Melee;
            Item.rare = ItemRarityID.Yellow;
            Item.UseSound = SoundID.Item1;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.damage = 88;
            Item.useAnimation = 16;
            Item.useTime = 16;
            Item.width = 30;
            Item.height = 30;
            Item.shoot = ProjectileID.TerraBeam;
            Item.scale = 1.1f;
            Item.shootSpeed = 12f;
            Item.knockBack = 6.5f;
            Item.noMelee = false;
            Item.value = Item.sellPrice(0, 20, 0, 0);
            Item.autoReuse = true;
        }

        public override bool CanShoot(Player player)
        {
            return !player.GetModPlayer<plr>().faketerrabladestart;
        }

        public override void MeleeEffects(Player player, Rectangle hitbox)
        {
            int dust = Dust.NewDust(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, DustID.Terra, 0f, 0f, 150, default, 1.5f); //55, 174, 6
			Main.dust[dust].noGravity = true;
            if (player.GetModPlayer<plr>().faketerrabladestart) return;
            player.GetModPlayer<plr>().faketerrabladecooldown = (int)(cooldownTime / player.GetAttackSpeed(DamageClass.Melee));
            player.GetModPlayer<plr>().faketerrabladestart = true;
        }

        public override Vector2? HoldoutOffset()
        {
            return base.HoldoutOffset();
        }
    }
}