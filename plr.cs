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

            // getting the value of string property
            string value = variable.ToString();

            // print the string property
            return value;
        }

        public static string getStringFromInt(int variable)
        {

            // getting the value of string property
            string value = variable.ToString();

            // print the string property
            return value;
        }

        int titanMailAR = 5;
        int titanLeggingsAR = 10;
        int titanBonusAR = 28;
        public bool titanMail;
        public bool titanHelmet;
        public bool titanLeggings;

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
    }
}