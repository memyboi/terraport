using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;

namespace terraport.UI
{
    public class titlescreen : ModMenu
    {
        public override string DisplayName => "Terraport";
        public override int Music => 60; //60 => console music
        public override Asset<Texture2D> Logo => ModContent.Request<Texture2D>("terraport/UI/Logo3");
    }
}