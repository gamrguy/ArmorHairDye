using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using ShaderLib;

namespace ArmorHairDye.Shaders
{
	public class SpeedShader : ModArmorShaderData
	{
		public override int? BoundItemID => ItemID.SpeedHairDye;

		public SpeedShader() {
			Primary = new Color(75, 255, 200);
			Saturation = 1.2f;
		}

		public override void PreApply(Entity entity, DrawData? drawData) {
			if(entity == null) return;

			Color newColor = default(Color);
			float velSum = Math.Abs(entity.velocity.X) + Math.Abs(entity.velocity.Y);
			float max = 10f;
			if(velSum > max) {
				velSum = max;
			}
			float percent = velSum / max;

			newColor.R = (byte)(Primary.R * percent);
			newColor.G = (byte)(Primary.G * percent);
			newColor.B = (byte)(Primary.B * percent);
			UseColor(newColor);
		}
	}
}