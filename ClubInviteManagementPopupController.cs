using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;
using System.Collections.Generic;

public class ClubInviteManagementPopupController : APopupController, IDispatchHandler<DClubInviteListItemAction>, IDispatchHandler, IDispatchHandler<DClubInviteAcceptedAction>, IDispatchHandler<DClubInviteRejectedAction>, IDispatchHandler<DClubInvitesProcessedAction>
{
	[Attribute(Name="InjectAttribute", RVA="0x1056078", Offset="0x1056078")]
	[FieldOffset(Offset="0x38")]
	private ClubServiceUtility _clubServiceUtility;

	[Attribute(Name="InjectAttribute", RVA="0x1056088", Offset="0x1056088")]
	[FieldOffset(Offset="0x40")]
	private PlayerDomainController _playerDc;

	[Attribute(Name="InjectAttribute", RVA="0x1056098", Offset="0x1056098")]
	[FieldOffset(Offset="0x48")]
	private ClubDomainController _clubDc;

	[FieldOffset(Offset="0x50")]
	private ClubInviteManagementPopupView _view;

	[FieldOffset(Offset="0x58")]
	private Club _club;

	[FieldOffset(Offset="0x60")]
	private List<ClubInvite> _joinRequests;

	[Address(RVA="0x11BE870", Offset="0x11BE870", VA="0x11BE870")]
	public ClubInviteManagementPopupController()
	{
	}

	[Address(RVA="0x11BE3E0", Offset="0x11BE3E0", VA="0x11BE3E0", Slot="14")]
	public void HandleDispatchAction(DClubInviteListItemAction action)
	{
	}

	[Address(RVA="0x11BE524", Offset="0x11BE524", VA="0x11BE524", Slot="15")]
	public void HandleDispatchAction(DClubInviteAcceptedAction action)
	{
	}

	[Address(RVA="0x11BE61C", Offset="0x11BE61C", VA="0x11BE61C", Slot="16")]
	public void HandleDispatchAction(DClubInviteRejectedAction action)
	{
	}

	[Address(RVA="0x11BE6A4", Offset="0x11BE6A4", VA="0x11BE6A4", Slot="17")]
	public void HandleDispatchAction(DClubInvitesProcessedAction action)
	{
	}

	[Address(RVA="0x11BE284", Offset="0x11BE284", VA="0x11BE284", Slot="8")]
	public override void Initialize(ITransitionContext context, Action completed)
	{
	}

	[Address(RVA="0x11BE52C", Offset="0x11BE52C", VA="0x11BE52C")]
	private void SetInvites()
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104B69C", Offset="0x104B69C")]
	private sealed class <>c__DisplayClass0_0
	{
		[FieldOffset(Offset="0x10")]
		public ClubInviteManagementPopupController <>4__this;

		[FieldOffset(Offset="0x18")]
		public Action completed;

		[Address(RVA="0x11BE3D8", Offset="0x11BE3D8", VA="0x11BE3D8")]
		public <>c__DisplayClass0_0()
		{
		}

		[Address(RVA="0x11BE8E0", Offset="0x11BE8E0", VA="0x11BE8E0")]
		internal void <Initialize>b__0(ClubInviteManagementPopupView view)
		{
		}
	}

	public class Context : ITransitionContext
	{
		[FieldOffset(Offset="0x10")]
		public readonly Club Club;

		[Address(RVA="0x11B7084", Offset="0x11B7084", VA="0x11B7084")]
		public Context(Club club)
		{
		}
	}
}