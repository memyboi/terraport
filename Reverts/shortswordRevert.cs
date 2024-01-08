using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace terraport.Reverts
{
    public class WeaponMods : GlobalItem
    {
        public void ConvertShortsword(Item item, int Damage) //to 1.3 variant
        {
            item.noUseGraphic = false;
            item.noMelee = false;
            item.shoot = ProjectileID.None;
            item.useStyle = ItemUseStyleID.Thrust;
            item.damage = Damage;
            item.autoReuse = false;
        }
        
        public override void SetDefaults(Item item) {
            if (item.type == ItemID.CopperShortsword) ConvertShortsword(item, 7);
            if (item.type == ItemID.TinShortsword) ConvertShortsword(item, 7);
            if (item.type == ItemID.IronShortsword) ConvertShortsword(item, 8);
            if (item.type == ItemID.LeadShortsword) ConvertShortsword(item, 9);
            if (item.type == ItemID.SilverShortsword) ConvertShortsword(item, 9);
            if (item.type == ItemID.TungstenShortsword) ConvertShortsword(item, 10);
            if (item.type == ItemID.GoldShortsword) ConvertShortsword(item, 12);
            if (item.type == ItemID.PlatinumShortsword) ConvertShortsword(item, 13);
        }
    }
}