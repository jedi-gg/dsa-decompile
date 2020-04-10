using Glunies;
using Il2CppDummyDll;
using System;

public class ClubInvitesListController : AFeatureController, IDispatchHandler<DClubInvitesListItemClickedAction>, IDispatchHandler, IDispatchHandler<DClubInviteAcceptedAction>, IDispatchHandler<DClubInviteRejectedAction>, IDispatchHandler<DPlayerClubChangedAction>, IDispatchHandler<DClubJoinRequestAction>, IDispatchHandler<DClubInvitesProcessedAction>
{
	[Attribute(Name="InjectAttribute", RVA="0x1056C68", Offset="0x1056C68")]
	[FieldOffset(Offset="0x68")]
	private ClubServiceUtility _clubServiceUtility;

	[Attribute(Name="InjectAttribute", RVA="0x1056C78", Offset="0x1056C78")]
	[FieldOffset(Offset="0x70")]
	private PlayerDomainController _playerDc;

	[Attribute(Name="InjectAttribute", RVA="0x1056C88", Offset="0x1056C88")]
	[FieldOffset(Offset="0x78")]
	private ClubDomainController _clubDc;

	[FieldOffset(Offset="0x80")]
	private ClubInvitesListView _view;

	[Address(RVA="0x11C0298", Offset="0x11C0298", VA="0x11C0298")]
	public ClubInvitesListController()
	{
	}

	[Address(RVA="0x11C004C", Offset="0x11C004C", VA="0x11C004C", Slot="10")]
	protected override GameStateTransitionContext CreateContext()
	{
		return null;
	}

	[Address(RVA="0x11BFD08", Offset="0x11BFD08", VA="0x11BFD08", Slot="13")]
	public void HandleDispatchAction(DClubInvitesListItemClickedAction action)
	{
	}

	[Address(RVA="0x11BFF24", Offset="0x11BFF24", VA="0x11BFF24", Slot="14")]
	public void HandleDispatchAction(DClubInviteAcceptedAction action)
	{
	}

	[Address(RVA="0x11BFFBC", Offset="0x11BFFBC", VA="0x11BFFBC", Slot="15")]
	public void HandleDispatchAction(DClubInviteRejectedAction action)
	{
	}

	[Address(RVA="0x11BFFC0", Offset="0x11BFFC0", VA="0x11BFFC0", Slot="16")]
	public void HandleDispatchAction(DPlayerClubChangedAction action)
	{
	}

	[Address(RVA="0x11C0044", Offset="0x11C0044", VA="0x11C0044", Slot="17")]
	public void HandleDispatchAction(DClubJoinRequestAction action)
	{
	}

	[Address(RVA="0x11C0048", Offset="0x11C0048", VA="0x11C0048", Slot="18")]
	public void HandleDispatchAction(DClubInvitesProcessedAction action)
	{
	}

	[Address(RVA="0x11BFC04", Offset="0x11BFC04", VA="0x11BFC04", Slot="6")]
	public override void Initialize(GameStateTransitionContext context)
	{
	}

	[Address(RVA="0x11BFF28", Offset="0x11BFF28", VA="0x11BFF28")]
	private void RefreshInviteList()
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104B99C", Offset="0x104B99C")]
	private sealed class <>c__DisplayClass0_0
	{
		[FieldOffset(Offset="0x10")]
		public ClubInvitesListController <>4__this;

		[FieldOffset(Offset="0x18")]
		public GameStateTransitionContext context;

		[Address(RVA="0x11BFD00", Offset="0x11BFD00", VA="0x11BFD00")]
		public <>c__DisplayClass0_0()
		{
		}

		[Address(RVA="0x11C02A0", Offset="0x11C02A0", VA="0x11C02A0")]
		internal void <Initialize>b__0(ClubInvitesListView view)
		{
		}
	}
}