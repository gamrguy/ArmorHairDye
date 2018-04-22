using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using ShaderLib.Shaders;

namespace ArmorHairDye.Shaders
{
	public class MartianShader : ModArmorShaderData
	{
		public override int? BoundItemID => ItemID.MartianHairDye;

		public MartianShader() {
			Saturation = 1.2f;
		}

		public override void PreApply(Entity e, DrawData? drawData) {
			Color newColor = default(Color);
			Color color = Lighting.GetColor((int)(e.position.X + e.width * 0.5) / 16, (int)((e.position.Y + e.height * 0.25) / 16.0));
			newColor.R = ((byte)(color.R + newColor.R >> 1));
			newColor.G = ((byte)(color.G + newColor.G >> 1));
			newColor.B = ((byte)(color.B + newColor.B >> 1));
			Primary = newColor;
		}
	}
}