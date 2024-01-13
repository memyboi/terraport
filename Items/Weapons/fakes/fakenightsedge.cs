using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace terraport.Items.Weapons.fakes
{
    public class fakenightsedge : ModItem
    {
        readonly float cooldownTime = 45f; // in frames (750ms)

        public override void SetDefaults() {
            Item.useStyle = ItemUseStyleID.Swing;
            Item.DamageType = DamageClass.Melee;
            Item.useAnimation = 26;
            Item.useTime = 26;
            Item.shoot = ProjectileID.NightBeam;
            Item.shootSpeed = 10f;
            Item.knockBack = 4.75f;
            Item.crit = 4;
            Item.width = 40;
            Item.height = 40;
            Item.damage = 78;
            Item.scale = 1.15f;
            Item.UseSound = SoundID.Item1;
            Item.rare = ItemRarityID.Yellow;
            Item.value = Item.sellPrice(gold: 10);
            Item.noMelee = false;
        }

        public override bool CanShoot(Player player)
        {
            return !player.GetModPlayer<plr>().fakenightsedgestart;
        }

        public override void MeleeEffects(Player player, Rectangle hitbox)
        {
            int dust = Dust.NewDust(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, DustID.Shadowflame, 0f, 0f, 150, default, 1.5f); //55, 174, 6
			Main.dust[dust].noGravity = true;
            if (player.GetModPlayer<plr>().fakenightsedgestart) return;
            player.GetModPlayer<plr>().fakenightsedgecooldown = (int)(cooldownTime / player.GetAttackSpeed(DamageClass.Melee));
            player.GetModPlayer<plr>().fakenightsedgestart = true;
        }
    }
}
