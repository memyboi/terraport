using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.ItemDropRules;
using terraport.Items.Items;
using System.Collections.Generic;

namespace terraport.Reverts
{
    public class terraportNpcs : GlobalNPC
    {
        public override void ModifyNPCLoot(NPC npc, NPCLoot npcLoot) {
            // We will now use the Guide to explain many of the other types of drop rules.

            if (npc.type == NPCID.Guide) {
                npcLoot.RemoveWhere(
                    rule => rule is ItemDropWithConditionRule drop
                        && drop.itemId == ItemID.GreenCap
                        && drop.condition is Conditions.NamedNPC npcNameCondition
                        && npcNameCondition.neededName == "Andrew"
                );

                // npcLoot.Add(ItemDropRule.Common(ItemID.GreenCap, 1));
            } else if (npc.type == NPCID.EyeofCthulhu) {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<soulofblight>(), 1, 30, 40)); // Drop a stack of 10 to 15 torches with 1 in 4 chance (25% chance)
                npcLoot.Remove(ItemDropRule.Common(ItemID.BadgersHat));
            }
        }
    }
}