using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using ShaderLib;

namespace ArmorHairDye.Shaders
{
	public class ManaShader : ModArmorShaderData
	{
		public override int? BoundItemID => ItemID.ManaHairDye;

		public ManaShader() {
			Primary = new Color(50, 75, 255);
			Secondary = Color.White;
			Saturation = 1.2f;
		}

		public override void PreApply(Entity e, DrawData? drawData) {
			Player player = e as Player;
			if(player == null) return;

			Color newColor = default(Color);
			newColor.R = (byte)((1f - (float)player.statMana / player.statManaMax2) * (Secondary.R - Primary.R) + Primary.R);
			newColor.G = (byte)((1f - (float)player.statMana / player.statManaMax2) * (Secondary.G - Primary.G) + Primary.G);
			newColor.B = (byte)((1f - (float)player.statMana / player.statManaMax2) * (Secondary.B - Primary.B) + Primary.B);

			UseColor(newColor);
		}
	}
}