using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public class TowerService : ATowerService
	{
		[Address(RVA="0x1B77498", Offset="0x1B77498", VA="0x1B77498")]
		public TowerService()
		{
		}

		[Address(RVA="0x1B773E8", Offset="0x1B773E8", VA="0x1B773E8", Slot="8")]
		protected override void ClaimTowerProgressionLootServiceSuccess(ClaimTowerProgressionLootResponse response)
		{
		}
	}
}