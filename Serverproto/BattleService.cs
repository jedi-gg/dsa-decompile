using Google.Protobuf.Collections;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public class BattleService : ABattleService
	{
		[Address(RVA="0x1DCCE90", Offset="0x1DCCE90", VA="0x1DCCE90")]
		public BattleService()
		{
		}

		[Address(RVA="0x1DCCD2C", Offset="0x1DCCD2C", VA="0x1DCCD2C", Slot="24")]
		protected override void ClubDungeonBattleEndServiceSuccess(ClubDungeonBattleEndResponse response)
		{
		}

		[Address(RVA="0x1DCCADC", Offset="0x1DCCADC", VA="0x1DCCADC", Slot="17")]
		protected override void EventBattleEndServiceSuccess(EventBattleEndResponse response)
		{
		}

		[Address(RVA="0x1DCCA9C", Offset="0x1DCCA9C", VA="0x1DCCA9C", Slot="16")]
		protected override void EventBattleStartServiceSuccess(EventBattleStartResponse response)
		{
		}

		[Address(RVA="0x1DCC0C8", Offset="0x1DCC0C8", VA="0x1DCC0C8")]
		public void GetBattleActivityResults(RepeatedField<BattleActivityResult> appendList, byte playerBattleId, BattleLib_UpdateResult.Types.BattleEnded battleEndData)
		{
		}

		[Address(RVA="0x1DCC6F4", Offset="0x1DCC6F4", VA="0x1DCC6F4")]
		private void HandleInventoryDelta(InventoryDelta delta)
		{
		}

		[Address(RVA="0x1DCCD94", Offset="0x1DCCD94", VA="0x1DCCD94", Slot="19")]
		protected override void InstantBattleAllDailyEventsServiceSuccess(InstantBattleAllDailyEventsResponse response)
		{
		}

		[Address(RVA="0x1DCCBE0", Offset="0x1DCCBE0", VA="0x1DCCBE0", Slot="18")]
		protected override void InstantBattleEventServiceSuccess(InstantBattleEventResponse response)
		{
		}

		[Address(RVA="0x1DCC9A4", Offset="0x1DCC9A4", VA="0x1DCC9A4", Slot="15")]
		protected override void InstantBattleServiceSuccess(InstantBattleResponse response)
		{
		}

		[Address(RVA="0x1DCC8A8", Offset="0x1DCC8A8", VA="0x1DCC8A8", Slot="14")]
		protected override void MultiplayerBattleResultServiceSuccess(MultiplayerBattleResultResponse response)
		{
		}

		[Address(RVA="0x1DCC77C", Offset="0x1DCC77C", VA="0x1DCC77C", Slot="6")]
		protected override void PveBattleEndServiceSuccess(PveBattleEndResponse response)
		{
		}

		[Address(RVA="0x1DCC6B4", Offset="0x1DCC6B4", VA="0x1DCC6B4", Slot="5")]
		protected override void PveBattleStartServiceSuccess(PveBattleStartResponse response)
		{
		}

		[Address(RVA="0x1DCCCC4", Offset="0x1DCCCC4", VA="0x1DCCCC4", Slot="22")]
		protected override void TowerAutoWinServiceSuccess(TowerAutoWinResponse response)
		{
		}

		[Address(RVA="0x1DCCC5C", Offset="0x1DCCC5C", VA="0x1DCCC5C", Slot="21")]
		protected override void TowerBattleEndServiceSuccess(TowerBattleEndResponse response)
		{
		}

		[Address(RVA="0x1DCCB58", Offset="0x1DCCB58", VA="0x1DCCB58")]
		private void UpdateEventStatus(EventStatus status)
		{
		}
	}
}