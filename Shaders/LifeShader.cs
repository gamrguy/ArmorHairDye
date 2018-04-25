using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using ShaderLib;

namespace ArmorHairDye.Shaders
{
	public class LifeShader : ModArmorShaderData
	{
		public override int? BoundItemID => ItemID.LifeHairDye;

		public LifeShader() {
			Primary = new Color(255, 20, 20);
			Secondary = new Color(20, 20, 20);
			Saturation = 1.2f;
		}

		public override void PreApply(Entity e, DrawData? drawData) {
			Player player = e as Player;
			if(player == null) return;

			//Color darkens to secondary
			Color newColor = default(Color);
			newColor.R = (byte)((float)player.statLife / player.statLifeMax2 * Primary.R);
			newColor.B = (byte)((float)player.statLife / player.statLifeMax2 * Primary.B);
			newColor.G = (byte)((float)player.statLife / player.statLifeMax2 * Primary.G);
			if(newColor.R < Secondary.R) newColor.R = Secondary.R;
			if(newColor.B < Secondary.B) newColor.B = Secondary.B;
			if(newColor.G < Secondary.G) newColor.G = Secondary.G;
			UseColor(newColor);
		}
	}
}