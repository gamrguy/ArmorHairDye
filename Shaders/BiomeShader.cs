using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using ShaderLib.Shaders;

namespace ArmorHairDye.Shaders
{
	public class BiomeShader : ModArmorShaderData
	{
		public override int? BoundItemID => ItemID.BiomeHairDye;

		public BiomeShader() {
			Saturation = 1.2f;
		}

		public override void PreApply(Entity e, DrawData? drawData) {
			Color color = default(Color);
			if(Main.waterStyle == 2)
				color = new Color(124, 118, 242);
			else if(Main.waterStyle == 3)
				color = new Color(143, 215, 29);
			else if(Main.waterStyle == 4)
				color = new Color(78, 193, 227);
			else if(Main.waterStyle == 5)
				color = new Color(189, 231, 255);
			else if(Main.waterStyle == 6)
				color = new Color(230, 219, 100);
			else if(Main.waterStyle == 7)
				color = new Color(151, 107, 75);
			else if(Main.waterStyle == 8)
				color = new Color(128, 128, 128);
			else if(Main.waterStyle == 9)
				color = new Color(200, 0, 0);
			else if(Main.waterStyle == 10)
				color = new Color(208, 80, 80);
			else if(Main.waterStyle >= WaterStyleLoader.vanillaWaterCount)
				color = WaterStyleLoader.GetWaterStyle(Main.waterStyle).BiomeHairColor();
			else
				color = new Color(28, 216, 94);
			
			Primary = color;
		}
	}
}