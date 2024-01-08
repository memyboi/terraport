using Terraria;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace terraport.Dusts
{
    public class tonbogiridustvary : ModDust
    {
        public override void OnSpawn(Dust Dust) {
			Dust.velocity *= 0.4f; // Multiply the dust's start velocity by 0.4, slowing it down
			Dust.noGravity = true; // Makes the dust have no gravity.
			Dust.noLight = true; // Makes the dust emit no light.
			Dust.scale *= 1.5f; // Multiplies the dust's initial scale by 1.5.
			Dust.color = Color.White;
		}

		public override bool Update(Dust Dust) { // Calls every frame the dust is active
			Dust.position += Dust.velocity;
			Dust.rotation += Dust.velocity.X * 0.15f;
			Dust.scale *= 0.99f;

			float light = 1f * Dust.scale;
			float r = 255;
			float g = 255;
			float b = 255;

			Lighting.AddLight(Dust.position, light*(r/255f), light*(g/255f), light*(b/255f));

			if (Dust.scale < 0.5f) {
				Dust.active = false;
			}

			return false; // Return false to prevent vanilla behavior.
		}
    }
}