using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;

public class HomeServiceUtility : ILoggable<LogCategory>, IDispatchHandler<DPlayerChangeProcessedAction>, IDispatchHandler, IDispatchHandler<DTowerRefreshedAction>, IDispatchHandler<DBuyStoreItemInventoryDeltaAction>, IDispatchHandler<DInboxViewAction>, IDispatchHandler<DClubItemRequestedAction>, IDispatchHandler<DClubItemDonatedAction>, IDispatchHandler<DClubInviteAcceptedAction>, IDispatchHandler<DClubInviteRejectedAction>, IDispatchHandler<DEventTierListItemAction>, IDispatchHandler<DPlayerClubChangedAction>, IDispatchHandler<DRevSdkPlacementShownAction>, IDispatchHandler<DGetClubInvitesResponse>, IDispatchHandler<DClubSupportRequestChangedAction>, IDispatchHandler<DFriendListModifyAction>
{
	[FieldOffset(Offset="0x10")]
	private TowerIdentifier _lastKnownTowerId;

	[Attribute(Name="InjectAttribute", RVA="0x1058E58", Offset="0x1058E58")]
	[FieldOffset(Offset="0x18")]
	private DispatchSystem _dispatchSystem;

	[Attribute(Name="InjectAttribute", RVA="0x1058E68", Offset="0x1058E68")]
	[FieldOffset(Offset="0x20")]
	private FeatureLockController _featureLockController;

	[Attribute(Name="InjectAttribute", RVA="0x1058E78", Offset="0x1058E78")]
	[FieldOffset(Offset="0x28")]
	private InboxService _inboxService;

	[Attribute(Name="InjectAttribute", RVA="0x1058E88", Offset="0x1058E88")]
	[FieldOffset(Offset="0x30")]
	private PlayerDomainController _playerDC;

	[Attribute(Name="InjectAttribute", RVA="0x1058E98", Offset="0x1058E98")]
	[FieldOffset(Offset="0x38")]
	private StoreDomainController _storeDC;

	[Attribute(Name="InjectAttribute", RVA="0x1058EA8", Offset="0x1058EA8")]
	[FieldOffset(Offset="0x40")]
	private HomeService _homeService;

	public TowerIdentifier LastKnownTowerId
	{
		[Address(RVA="0x116CC90", Offset="0x116CC90", VA="0x116CC90")]
		get
		{
			return null;
		}
	}

	public LogCategory LogCategory
	{
		[Address(RVA="0x1170E34", Offset="0x1170E34", VA="0x1170E34", Slot="4")]
		get
		{
			return new LogCategory();
		}
	}

	[Address(RVA="0x11725D0", Offset="0x11725D0", VA="0x11725D0")]
	public HomeServiceUtility()
	{
	}

	[Address(RVA="0x1170EAC", Offset="0x1170EAC", VA="0x1170EAC")]
	private HomeRequest BuildHomeRequest()
	{
		return null;
	}

	[Address(RVA="0x1171C7C", Offset="0x1171C7C", VA="0x1171C7C")]
	public void ClubDungeonReloaded()
	{
	}

	[Address(RVA="0x116C8B8", Offset="0x116C8B8", VA="0x116C8B8")]
	public void FetchHomeData(Func<bool> silence)
	{
	}

	[Address(RVA="0x11715C4", Offset="0x11715C4", VA="0x11715C4", Slot="5")]
	public void HandleDispatchAction(DPlayerChangeProcessedAction action)
	{
	}

	[Address(RVA="0x1171794", Offset="0x1171794", VA="0x1171794", Slot="6")]
	public void HandleDispatchAction(DTowerRefreshedAction action)
	{
	}

	[Address(RVA="0x11717F8", Offset="0x11717F8", VA="0x11717F8", Slot="7")]
	public void HandleDispatchAction(DBuyStoreItemInventoryDeltaAction action)
	{
	}

	[Address(RVA="0x117185C", Offset="0x117185C", VA="0x117185C", Slot="8")]
	public void HandleDispatchAction(DInboxViewAction action)
	{
	}

	[Address(RVA="0x11718E0", Offset="0x11718E0", VA="0x11718E0", Slot="10")]
	public void HandleDispatchAction(DClubItemDonatedAction action)
	{
	}

	[Address(RVA="0x1171944", Offset="0x1171944", VA="0x1171944", Slot="9")]
	public void HandleDispatchAction(DClubItemRequestedAction action)
	{
	}

	[Address(RVA="0x11719A8", Offset="0x11719A8", VA="0x11719A8", Slot="11")]
	public void HandleDispatchAction(DClubInviteAcceptedAction action)
	{
	}

	[Address(RVA="0x1171A0C", Offset="0x1171A0C", VA="0x1171A0C", Slot="12")]
	public void HandleDispatchAction(DClubInviteRejectedAction action)
	{
	}

	[Address(RVA="0x1171A70", Offset="0x1171A70", VA="0x1171A70", Slot="13")]
	public void HandleDispatchAction(DEventTierListItemAction action)
	{
	}

	[Address(RVA="0x1171AD4", Offset="0x1171AD4", VA="0x1171AD4")]
	public void HandleDispatchAction(DDailyActivityListItemAction action)
	{
	}

	[Address(RVA="0x1171B38", Offset="0x1171B38", VA="0x1171B38", Slot="14")]
	public void HandleDispatchAction(DPlayerClubChangedAction action)
	{
	}

	[Address(RVA="0x1171BEC", Offset="0x1171BEC", VA="0x1171BEC", Slot="15")]
	public void HandleDispatchAction(DRevSdkPlacementShownAction action)
	{
	}

	[Address(RVA="0x1171CE0", Offset="0x1171CE0", VA="0x1171CE0", Slot="16")]
	public void HandleDispatchAction(DGetClubInvitesResponse action)
	{
	}

	[Address(RVA="0x1171D44", Offset="0x1171D44", VA="0x1171D44", Slot="17")]
	public void HandleDispatchAction(DClubSupportRequestChangedAction action)
	{
	}

	[Address(RVA="0x1171DD0", Offset="0x1171DD0", VA="0x1171DD0", Slot="18")]
	public void HandleDispatchAction(DFriendListModifyAction action)
	{
	}

	[Address(RVA="0x1171E34", Offset="0x1171E34", VA="0x1171E34")]
	private void HomeSuccess(HomeResponse response)
	{
	}

	[Address(RVA="0x1170E3C", Offset="0x1170E3C", VA="0x1170E3C")]
	public void Initialize()
	{
	}

	[Address(RVA="0x1170E74", Offset="0x1170E74", VA="0x1170E74")]
	public void Shutdown()
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104C04C", Offset="0x104C04C")]
	[Serializable]
	private sealed class <>c
	{
		[FieldOffset(Offset="0x0")]
		public readonly static HomeServiceUtility.<>c <>9;

		[FieldOffset(Offset="0x8")]
		public static Action<long> <>9__6_0;

		[Address(RVA="0x11725D8", Offset="0x11725D8", VA="0x11725D8")]
		static <>c()
		{
		}

		[Address(RVA="0x117263C", Offset="0x117263C", VA="0x117263C")]
		public <>c()
		{
		}

		[Address(RVA="0x1172644", Offset="0x1172644", VA="0x1172644")]
		internal void <FetchHomeData>b__6_0(long failureCode)
		{
		}
	}
}