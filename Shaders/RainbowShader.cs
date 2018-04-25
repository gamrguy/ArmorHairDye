using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using ShaderLib;

namespace ArmorHairDye.Shaders
{
	public class RainbowShader : ModArmorShaderData
	{
		public override int? BoundItemID => ItemID.RainbowHairDye;

		public RainbowShader() {
			Saturation = 1.2f;
		}

		public override void PreApply(Entity e, DrawData? drawData){
			Primary = new Color(Main.DiscoR, Main.DiscoG, Main.DiscoB);
		}
	}
}