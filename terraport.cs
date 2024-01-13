using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Graphics;
using System;
using System.Collections.Generic;
using System.IO;
using Terraria;
using Terraria.GameContent;
using Terraria.GameContent.Dyes;
using Terraria.GameContent.UI;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.UI;
using System.Linq;

namespace terraport
{
	public class terraport : Mod
	{
		static void LoadItemTexture(int itemid) {
			TextureAssets.Item[itemid] = ModContent.Request<Texture2D>($"terraport/Reverts/Images/Item_{itemid}");
		}

		static void UnloadItemTexture(int itemid) {
			TextureAssets.Item[itemid] = ModContent.Request<Texture2D>($"Terraria/Images/Item_{itemid}");
		}

		static void LoadBorkedItemTexture(int itemid) {
			if (itemid == ItemID.SleepingIcon) return;
			TextureAssets.Item[itemid] = ModContent.Request<Texture2D>($"terraport/Reverts/Images/Borked");
		}

		static int[] itemReplacementIds = {
			4,6,19,20,21,22,24,57,65,117,121,155,175,186,190,273,381,382,391,486,653,656,703,704,705,706,724,795,881,921,946,989,1006,1123,1166,1184,1191,1198,1225,1257,1304,1552,1827,2273,2517,2608,2745,3483,3484,3489,3490,3495,3496,3501,3502,3507,3508,3513,3514,3519,55,274,277,280,284,802,2332,5,28,110,188,189,227,288,289,290,291,292,293,294,295,296,297,298,299,300,301,302,303,304,305,499,500,1134,1340,1353,1354,1355,1356,1357,1358,1359,1912,2209,2314,2322,2323,2324,2325,2326,2327,2328,2329,2344,2345,2346,2347,2348,2349,2350,2351,2352,2353,2354,2355,2356,2359,31,46,126,422,423,1431
		};

		static int[] itemRemovementIds = {
			3477,3068,3084,3093,2880,2800,674,675,3278,3285,3279,3280,3281,3262,3282,3317,3283,3315,3290,3289,3316,3284,3286,3287,3288,3291,3292,3389,3306,3301,3308,3305,3299,3297,3296,3294,3304,3302,3307,3293,3300,3298,3295,3544,2756,2997,678
		};

        public override void Load()
        {
			for (int i = ItemID.DjinnsCurse; i < ItemID.DontHurtComboBookInactive+1; i++) {
				LoadBorkedItemTexture(i);
			}
			for (int i = 0; i < itemReplacementIds.Length; i++) {
				LoadItemTexture(itemReplacementIds[i]);
			}
			for (int i = 0; i < itemRemovementIds.Length; i++) {
				LoadBorkedItemTexture(itemRemovementIds[i]);
			}
        }

        public override void Unload()
        {
			for (int i = ItemID.DjinnsCurse; i < ItemID.DontHurtComboBookInactive+1; i++) {
				UnloadItemTexture(i);
			}
            for (int i = 0; i < itemReplacementIds.Length; i++) {
				UnloadItemTexture(itemReplacementIds[i]);
			}
			for (int i = 0; i < itemRemovementIds.Length; i++) {
				UnloadItemTexture(itemRemovementIds[i]);
			}
        }
	}
}