using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using ShaderLib;

namespace ArmorHairDye.Shaders
{
	public class PartyShader : ModArmorShaderData
	{
		public override int? BoundItemID => ItemID.PartyHairDye;

		public PartyShader() {
			Primary = new Color(244, 22, 175);
			Saturation = 1.2f;
		}

		public override void PreApply(Entity entity, DrawData? drawData) {
			if(entity == null) return;

			if(!Main.gameMenu && !Main.gamePaused) {
				if(Main.rand.Next(45) == 0) {
					int type = Main.rand.Next(139, 143);
					int num = Dust.NewDust(entity.position, entity.width, 8, type, 0f, 0f, 0, default(Color), 1.2f);
					Dust dust1 = Main.dust[num];
					dust1.velocity.X = dust1.velocity.X * (1f + Main.rand.Next(-50, 51) * 0.01f);
					Dust dust2 = Main.dust[num];
					dust2.velocity.Y = dust2.velocity.Y * (1f + Main.rand.Next(-50, 51) * 0.01f);
					Dust dust3 = Main.dust[num];
					dust3.velocity.X = dust3.velocity.X + Main.rand.Next(-50, 51) * 0.01f;
					Dust dust4 = Main.dust[num];
					dust4.velocity.Y = dust4.velocity.Y + Main.rand.Next(-50, 51) * 0.01f;
					Dust dust5 = Main.dust[num];
					dust5.velocity.Y = dust5.velocity.Y - 1f;
					Main.dust[num].scale *= 0.7f + Main.rand.Next(-30, 31) * 0.01f;
					Main.dust[num].velocity += entity.velocity * 0.2f;
				}
				if(Main.rand.Next(225) == 0) {
					int type2 = Main.rand.Next(276, 283);
					int num2 = Gore.NewGore(new Vector2(entity.position.X + Main.rand.Next(entity.width), entity.position.Y + Main.rand.Next(8)), entity.velocity, type2, 1f);
					Gore gore1 = Main.gore[num2];
					gore1.velocity.X = gore1.velocity.X * (1f + Main.rand.Next(-50, 51) * 0.01f);
					Gore gore2 = Main.gore[num2];
					gore2.velocity.Y = gore2.velocity.Y * (1f + Main.rand.Next(-50, 51) * 0.01f);
					Main.gore[num2].scale *= 1f + Main.rand.Next(-20, 21) * 0.01f;
					Gore gore3 = Main.gore[num2];
					gore3.velocity.X = gore3.velocity.X + Main.rand.Next(-50, 51) * 0.01f;
					Gore gore4 = Main.gore[num2];
					gore4.velocity.Y = gore4.velocity.Y + Main.rand.Next(-50, 51) * 0.01f;
					Gore gore5 = Main.gore[num2];
					gore5.velocity.Y = gore5.velocity.Y - 1f;
					Main.gore[num2].velocity += entity.velocity * 0.2f;
				}
			}
		}
	}
}