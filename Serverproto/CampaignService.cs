using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public class CampaignService : ACampaignService
	{
		[Address(RVA="0x1F96504", Offset="0x1F96504", VA="0x1F96504")]
		public CampaignService()
		{
		}

		[Address(RVA="0x1F9642C", Offset="0x1F9642C", VA="0x1F9642C", Slot="6")]
		protected override void BuyPveRefreshServiceSuccess(BuyPveRefreshResponse response)
		{
		}
	}
}