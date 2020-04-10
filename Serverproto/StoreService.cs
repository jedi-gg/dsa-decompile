using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public class StoreService : AStoreService
	{
		[Address(RVA="0x1B68F74", Offset="0x1B68F74", VA="0x1B68F74")]
		public StoreService()
		{
		}

		[Address(RVA="0x1B68EB0", Offset="0x1B68EB0", VA="0x1B68EB0", Slot="10")]
		protected override void BuyAllShipmentItemsServiceSuccess(BuyAllShipmentItemsResponse response)
		{
		}

		[Address(RVA="0x1B68AE4", Offset="0x1B68AE4", VA="0x1B68AE4", Slot="9")]
		protected override void BuyShipmentItemServiceSuccess(BuyShipmentItemResponse response)
		{
		}

		[Address(RVA="0x1B68D98", Offset="0x1B68D98", VA="0x1B68D98", Slot="14")]
		protected override void BuyStoreItemDirectServiceSuccess(BuyStoreItemDirectResponse response)
		{
		}

		[Address(RVA="0x1B68878", Offset="0x1B68878", VA="0x1B68878", Slot="7")]
		protected override void BuyStoreItemServiceSuccess(BuyStoreItemResponse response)
		{
		}

		[Address(RVA="0x1B68A58", Offset="0x1B68A58", VA="0x1B68A58")]
		private void ClearItemFindCache()
		{
		}

		[Address(RVA="0x1B68BA8", Offset="0x1B68BA8", VA="0x1B68BA8", Slot="11")]
		protected override void RefreshShipmentServiceSuccess(RefreshShipmentResponse response)
		{
		}

		[Address(RVA="0x1B68C6C", Offset="0x1B68C6C", VA="0x1B68C6C", Slot="13")]
		protected override void StoreAdRewardServiceSuccess(StoreAdRewardResponse response)
		{
		}

		[Address(RVA="0x1B687F0", Offset="0x1B687F0", VA="0x1B687F0", Slot="5")]
		protected override void StoreServiceSuccess(StoreResponse response)
		{
		}
	}
}