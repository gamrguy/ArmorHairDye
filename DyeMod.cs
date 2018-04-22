using Terraria.ModLoader;
using ShaderLib;

namespace ArmorHairDye
{
	public class DyeMod : Mod
	{
		public override void Load() {
			ShaderLoader.RegisterMod(this);
		}
	}
}