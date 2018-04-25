using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using ShaderLib;

namespace ArmorHairDye.Shaders
{
	public class TimeShader : ModArmorShaderData
	{
		public override int? BoundItemID => ItemID.TimeHairDye;

		public TimeShader() {
			Saturation = 1.2f;
		}

		public override void PreApply(Entity e, DrawData? drawData) {
			Color newColor = default(Color);
			Color color = new Color(1, 142, 255);
			Color color2 = new Color(255, 255, 0);
			Color color3 = new Color(211, 45, 127);
			Color color4 = new Color(67, 44, 118);
			if(Main.dayTime) {
				if(Main.time < 27000.0) {
					float num = (float)(Main.time / 27000.0);
					float num2 = 1f - num;
					newColor.R = ((byte)(color.R * num2 + color2.R * num));
					newColor.G = ((byte)(color.G * num2 + color2.G * num));
					newColor.B = ((byte)(color.B * num2 + color2.B * num));
				} else {
					float num3 = 27000f;
					float num4 = (float)((Main.time - num3) / (54000.0 - num3));
					float num5 = 1f - num4;
					newColor.R = ((byte)(color2.R * num5 + color3.R * num4));
					newColor.G = ((byte)(color2.G * num5 + color3.G * num4));
					newColor.B = ((byte)(color2.B * num5 + color3.B * num4));
				}
			} else if(Main.time < 16200.0) {
				float num6 = (float)(Main.time / 16200.0);
				float num7 = 1f - num6;
				newColor.R = ((byte)(color3.R * num7 + color4.R * num6));
				newColor.G = ((byte)(color3.G * num7 + color4.G * num6));
				newColor.B = ((byte)(color3.B * num7 + color4.B * num6));
			} else {
				float num8 = 16200f;
				float num9 = (float)((Main.time - num8) / (32400.0 - num8));
				float num10 = 1f - num9;
				newColor.R = ((byte)(color4.R * num10 + color.R * num9));
				newColor.G = ((byte)(color4.G * num10 + color.G * num9));
				newColor.B = ((byte)(color4.B * num10 + color.B * num9));
			}
			Primary = newColor;
		}
	}
}