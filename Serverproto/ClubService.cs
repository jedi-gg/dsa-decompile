using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public class ClubService : AClubService
	{
		[Attribute(Name="InjectAttribute", RVA="0x1063AFC", Offset="0x1063AFC")]
		[FieldOffset(Offset="0x50")]
		private PlayerDomainController _playerDc;

		[Address(RVA="0x1B15C84", Offset="0x1B15C84", VA="0x1B15C84")]
		public ClubService()
		{
		}

		[Address(RVA="0x1B15738", Offset="0x1B15738", VA="0x1B15738", Slot="20")]
		protected override void ClubDungeonStatusServiceSuccess(ClubDungeonStatusResponse response)
		{
		}

		[Address(RVA="0x1B159AC", Offset="0x1B159AC", VA="0x1B159AC", Slot="34")]
		protected override void ClubWarOpenRewardServiceSuccess(ClubWarOpenRewardResponse response)
		{
		}

		[Address(RVA="0x1B155F8", Offset="0x1B155F8", VA="0x1B155F8", Slot="5")]
		protected override void CreateClubServiceSuccess(CreateClubResponse response)
		{
		}

		[Address(RVA="0x1B15698", Offset="0x1B15698", VA="0x1B15698", Slot="18")]
		protected override void DonateClubItemServiceSuccess(DonateClubItemResponse response)
		{
		}

		[Address(RVA="0x1B15BD8", Offset="0x1B15BD8", VA="0x1B15BD8", Slot="41")]
		protected override void FulfillClubSupportServiceSuccess(FulfillClubSupportResponse response)
		{
		}

		[Address(RVA="0x1B15924", Offset="0x1B15924", VA="0x1B15924", Slot="13")]
		protected override void GetClubInvitesServiceSuccess(GetClubInvitesResponse response)
		{
		}

		[Address(RVA="0x1B154F8", Offset="0x1B154F8", VA="0x1B154F8", Slot="6")]
		protected override void GetClubServiceSuccess(ClubResponse response)
		{
		}

		[Address(RVA="0x1B15A48", Offset="0x1B15A48", VA="0x1B15A48", Slot="39")]
		protected override void GetPlayerClubSupportStatusServiceSuccess(GetPlayerClubSupportStatusResponse response)
		{
		}

		[Address(RVA="0x1B157F4", Offset="0x1B157F4", VA="0x1B157F4", Slot="16")]
		protected override void KickClubMemberServiceSuccess(KickClubMemberResponse response)
		{
		}

		[Address(RVA="0x1B15B10", Offset="0x1B15B10", VA="0x1B15B10", Slot="40")]
		protected override void RequestClubSupportServiceSuccess(RequestClubSupportResponse response)
		{
		}
	}
}