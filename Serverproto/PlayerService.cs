using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public class PlayerService : APlayerService
	{
		[Address(RVA="0x1B10908", Offset="0x1B10908", VA="0x1B10908")]
		public PlayerService()
		{
		}

		[Address(RVA="0x1B106BC", Offset="0x1B106BC", VA="0x1B106BC", Slot="28")]
		protected override void AdRewardedEnergyServiceSuccess(AdRewardedEnergyResponse response)
		{
		}

		[Address(RVA="0x1B10568", Offset="0x1B10568", VA="0x1B10568", Slot="23")]
		protected override void BuyExpiredDailyLoginServiceSuccess(BuyExpiredDailyLoginResponse response)
		{
		}

		[Address(RVA="0x1B10724", Offset="0x1B10724", VA="0x1B10724", Slot="29")]
		protected override void BuyPassportSeasonLevelServiceSuccess(BuyPassportSeasonLevelResponse response)
		{
		}

		[Address(RVA="0x1B0FF58", Offset="0x1B0FF58", VA="0x1B0FF58", Slot="5")]
		protected override void ClaimActivityServiceSuccess(ClaimActivityResponse response)
		{
		}

		[Address(RVA="0x1B105FC", Offset="0x1B105FC", VA="0x1B105FC", Slot="24")]
		protected override void ClaimDailyLoginBonusServiceSuccess(ClaimDailyLoginBonusResponse response)
		{
		}

		[Address(RVA="0x1B104A4", Offset="0x1B104A4", VA="0x1B104A4", Slot="22")]
		protected override void ClaimDailyLoginServiceSuccess(ClaimDailyLoginResponse response)
		{
		}

		[Address(RVA="0x1B107A4", Offset="0x1B107A4", VA="0x1B107A4", Slot="37")]
		protected override void ClaimDailyRewardServiceSuccess(DailyRewardClaimResponse response)
		{
		}

		[Address(RVA="0x1B103A8", Offset="0x1B103A8", VA="0x1B103A8", Slot="8")]
		protected override void ClaimEnergyGiftServiceSuccess(ClaimDailyEnergyGiftResponse response)
		{
		}

		[Address(RVA="0x1B102AC", Offset="0x1B102AC", VA="0x1B102AC", Slot="7")]
		protected override void EnergyRefreshServiceSuccess(EnergyRefreshResponse response)
		{
		}

		[Address(RVA="0x1B10868", Offset="0x1B10868", VA="0x1B10868", Slot="11")]
		protected override void FriendsListServiceSuccess(FriendsListResponse response)
		{
		}

		[Address(RVA="0x1B100BC", Offset="0x1B100BC", VA="0x1B100BC")]
		private void HandleInventoryDelta(InventoryDelta delta)
		{
		}

		[Address(RVA="0x1B10764", Offset="0x1B10764", VA="0x1B10764", Slot="33")]
		protected override void KothClearCooldownServiceSuccess(KothClearCooldownResponse response)
		{
		}

		[Address(RVA="0x1B10144", Offset="0x1B10144", VA="0x1B10144", Slot="6")]
		protected override void PlayerServiceSuccess(PlayerResponse response)
		{
		}
	}
}