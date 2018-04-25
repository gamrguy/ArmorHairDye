using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using ShaderLib;

namespace ArmorHairDye.Shaders
{
	public class DepthShader : ModArmorShaderData
	{
		public override int? BoundItemID => ItemID.DepthHairDye;

		public DepthShader() {
			Saturation = 1.2f;
		}

		public override void PreApply(Entity entity, DrawData? drawData) {
			if(entity == null) return;

			Color newColor = default(Color);
			float num = (float)(Main.worldSurface * 0.45) * 16f;
			float num2 = (float)(Main.worldSurface + Main.rockLayer) * 8f;
			float num3 = (float)(Main.rockLayer + Main.maxTilesY) * 8f;
			float num4 = (Main.maxTilesY - 150) * 16f;
			Vector2 center = entity.Center;
			if(center.Y < num) {
				float num5 = center.Y / num;
				float num6 = 1f - num5;
				newColor.R = ((byte)(116f * num6 + 28f * num5));
				newColor.G = ((byte)(160f * num6 + 216f * num5));
				newColor.B = ((byte)(249f * num6 + 94f * num5));
			} else if(center.Y < num2) {
				float num7 = num;
				float num8 = (center.Y - num7) / (num2 - num7);
				float num9 = 1f - num8;
				newColor.R = ((byte)(28f * num9 + 151f * num8));
				newColor.G = ((byte)(216f * num9 + 107f * num8));
				newColor.B = ((byte)(94f * num9 + 75f * num8));
			} else if(center.Y < num3) {
				float num10 = num2;
				float num11 = (center.Y - num10) / (num3 - num10);
				float num12 = 1f - num11;
				newColor.R = ((byte)(151f * num12 + 128f * num11));
				newColor.G = ((byte)(107f * num12 + 128f * num11));
				newColor.B = ((byte)(75f * num12 + 128f * num11));
			} else if(center.Y < num4) {
				float num13 = num3;
				float num14 = (center.Y - num13) / (num4 - num13);
				float num15 = 1f - num14;
				newColor.R = ((byte)(128f * num15 + 255f * num14));
				newColor.G = ((byte)(128f * num15 + 50f * num14));
				newColor.B = ((byte)(128f * num15 + 15f * num14));
			} else {
				newColor.R = (255);
				newColor.G = (50);
				newColor.B = (10);
			}
			Primary = newColor;
		}
	}
}