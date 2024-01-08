using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.ItemDropRules;
using terraport.Items.Items;

namespace terraport.Reverts
{
    public class terraportNpcDrops : GlobalNPC
    {
        public override void ModifyNPCLoot(NPC npc, NPCLoot npcLoot) {
            // We will now use the Guide to explain many of the other types of drop rules.
            if (npc.type == NPCID.Guide) {
                // RemoveWhere will remove any drop rule that matches the provided expression.
                // To make your own expressions to remove vanilla drop rules, you'll usually have to study the original source code that adds those rules.
                npcLoot.RemoveWhere(
                    // The following expression returns true if the following conditions are met:
                    rule => rule is ItemDropWithConditionRule drop // If the rule is an ItemDropWithConditionRule instance
                        && drop.itemId == ItemID.GreenCap // And that instance drops a green cap
                        && drop.condition is Conditions.NamedNPC npcNameCondition // ..And if its condition is that an npc name must match some string
                        && npcNameCondition.neededName == "Andrew" // And the condition's string is "Andrew".
                );

                // npcLoot.Add(ItemDropRule.Common(ItemID.GreenCap, 1));
            } else if (npc.type == NPCID.EyeofCthulhu) {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<soulofblight>(), 1, 30, 40)); // Drop a stack of 10 to 15 torches with 1 in 4 chance (25% chance)
            }
        }
    }
}