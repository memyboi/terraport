using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;

namespace terraport
{
    internal class plr : ModPlayer
    {

        public static string getStringFromBool(bool variable)
        {
            string value = variable.ToString();
            return value;
        }

        public static string getStringFromInt(int variable)
        {
            string value = variable.ToString();
            return value;
        }

        int titanMailAR = 5;
        int titanLeggingsAR = 10;
        int titanBonusAR = 28;
        public bool titanMail;
        public bool titanHelmet;
        public bool titanLeggings;

        public int fakenightsedgecooldown;
        public int fakenightsedgecooldowntimer = 0;
        public bool fakenightsedgestart;

        public int fakeexcaliburcooldown;
        public int fakeexcaliburcooldowntimer = 0;
        public bool fakeexcaliburstart;

        public int faketerrabladecooldown;
        public int faketerrabladecooldowntimer = 0;
        public bool faketerrabladestart;

        public override void ResetEffects() {
            titanMail = false;
            titanHelmet = false;
            titanLeggings = false;
        }

        public override bool CanConsumeAmmo(Item weapon, Item ammo) {
            int totalAR = 0;
            int titanTotalAR = 0;
            if (titanMail) titanTotalAR += titanMailAR;
            if (titanHelmet) titanTotalAR += titanMailAR;
            if (titanLeggings) titanTotalAR += titanLeggingsAR;
            if (titanMail && titanHelmet && titanLeggings) titanTotalAR += titanBonusAR;
            totalAR = titanTotalAR;
            int leRandom = Main.rand.Next(100);
            return leRandom >= totalAR;
        }

        public override void FrameEffects()
        {
            if (fakenightsedgestart) {
                if (fakenightsedgecooldowntimer < fakenightsedgecooldown) {
                    fakenightsedgecooldowntimer += 1;
                } else {
                    fakenightsedgecooldowntimer = 0;
                    fakenightsedgestart = false;
                }
            }
            if (fakeexcaliburstart) {
                if (fakeexcaliburcooldowntimer < fakeexcaliburcooldown) {
                    fakeexcaliburcooldowntimer += 1;
                } else {
                    fakeexcaliburcooldowntimer = 0;
                    fakeexcaliburstart = false;
                }
            }
            if (faketerrabladestart) {
                if (faketerrabladecooldowntimer < faketerrabladecooldown) {
                    faketerrabladecooldowntimer += 1;
                } else {
                    faketerrabladecooldowntimer = 0;
                    faketerrabladestart = false;
                }
            }
        }
    }
}