using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ArmorHairDye
{
	public class GlobalDye : GlobalItem
	{
		public override void SetDefaults(Item item) {
			// Allows equipping hair dye as armor dye
			switch(item.type) {
				case (ItemID.BiomeHairDye):
				case (ItemID.DepthHairDye):
				case (ItemID.LifeHairDye):
				case (ItemID.ManaHairDye):
				case (ItemID.MartianHairDye):
				case (ItemID.MoneyHairDye):
				case (ItemID.PartyHairDye):
				case (ItemID.RainbowHairDye):
				case (ItemID.SpeedHairDye):
				case (ItemID.TimeHairDye):
					item.dye = 1;
					break;
			}
		}
	}
}