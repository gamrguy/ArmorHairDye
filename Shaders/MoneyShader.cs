using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using ShaderLib.Shaders;

namespace ArmorHairDye.Shaders
{
	public class MoneyShader : ModArmorShaderData
	{
		public override int? BoundItemID => ItemID.MoneyHairDye;

		public MoneyShader() {
			Saturation = 1.2f;
		}

		public override void PreApply(Entity e, DrawData? drawData) {
			Player player = e as Player;
			if(player == null) return;

			Color newColor = default(Color);
			int num = 0;
			for(int i = 0; i < 54; i++) {
				if(player.inventory[i].type == 71) {
					num += player.inventory[i].stack;
				}
				if(player.inventory[i].type == 72) {
					num += player.inventory[i].stack * 100;
				}
				if(player.inventory[i].type == 73) {
					num += player.inventory[i].stack * 10000;
				}
				if(player.inventory[i].type == 74) {
					num += player.inventory[i].stack * 1000000;
				}
			}
			float num2 = Item.buyPrice(0, 5, 0, 0);
			float num3 = Item.buyPrice(0, 50, 0, 0);
			float num4 = Item.buyPrice(2, 0, 0, 0);
			Color color = new Color(226, 118, 76);
			Color color2 = new Color(174, 194, 196);
			Color color3 = new Color(204, 181, 72);
			Color color4 = new Color(161, 172, 173);
			if(num < num2) {
				float num5 = num / num2;
				float num6 = 1f - num5;
				newColor.R = ((byte)(color.R * num6 + color2.R * num5));
				newColor.G = ((byte)(color.G * num6 + color2.G * num5));
				newColor.B = ((byte)(color.B * num6 + color2.B * num5));
			} else if(num < num3) {
				float num7 = num2;
				float num8 = ((float)num - num7) / (num3 - num7);
				float num9 = 1f - num8;
				newColor.R = ((byte)(color2.R * num9 + color3.R * num8));
				newColor.G = ((byte)(color2.G * num9 + color3.G * num8));
				newColor.B = ((byte)(color2.B * num9 + color3.B * num8));
			} else if(num < num4) {
				float num10 = num3;
				float num11 = ((float)num - num10) / (num4 - num10);
				float num12 = 1f - num11;
				newColor.R = ((byte)(color3.R * num12 + color4.R * num11));
				newColor.G = ((byte)(color3.G * num12 + color4.G * num11));
				newColor.B = ((byte)(color3.B * num12 + color4.B * num11));
			} else {
				newColor = color4;
			}
			Primary = newColor;
		}
	}
}