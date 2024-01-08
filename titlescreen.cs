using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace terraport
{
    public class titlescreen : ModMenu
    {
        public override string DisplayName => "Terraport";
        public override int Music => 60; //60 => console music
    }
}