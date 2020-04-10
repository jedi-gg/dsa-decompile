using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public class EventService : AEventService
	{
		[Address(RVA="0x1B98360", Offset="0x1B98360", VA="0x1B98360")]
		public EventService()
		{
		}

		[Address(RVA="0x1B98114", Offset="0x1B98114", VA="0x1B98114", Slot="8")]
		protected override void GetEventStatusServiceSuccess(GetEventStatusResponse response)
		{
		}

		[Address(RVA="0x1B97EC0", Offset="0x1B97EC0", VA="0x1B97EC0", Slot="6")]
		protected override void GetScheduledEventsServiceSuccess(GetScheduledEventsResponse response)
		{
		}

		[Address(RVA="0x1B98004", Offset="0x1B98004", VA="0x1B98004")]
		private void HandleInventoryDelta(InventoryDelta delta)
		{
		}

		[Address(RVA="0x1B97F88", Offset="0x1B97F88", VA="0x1B97F88", Slot="7")]
		protected override void RefreshBattleLimitServiceSuccess(RefreshEventBattleLimitResponse response)
		{
		}

		[Address(RVA="0x1B9808C", Offset="0x1B9808C", VA="0x1B9808C")]
		private void UpdateEventStatus(EventStatus status)
		{
		}
	}
}