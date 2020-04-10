using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;

public class ClubInvitePopupController : APopupController, IDispatchHandler<DClubInvitePopupViewAction>, IDispatchHandler, IDispatchHandler<DClubInvitePopupViewNavigateAction>, IDispatchHandler<DClubInviteAcceptedAction>, IDispatchHandler<DClubInviteRejectedAction>
{
	[Attribute(Name="InjectAttribute", RVA="0x1056C48", Offset="0x1056C48")]
	[FieldOffset(Offset="0x38")]
	private ClubServiceUtility _clubServiceUtility;

	[FieldOffset(Offset="0x40")]
	private ClubInvitePopupController.Context _context;

	[FieldOffset(Offset="0x48")]
	private ClubInvitePopupView _view;

	[Address(RVA="0x11BF2A0", Offset="0x11BF2A0", VA="0x11BF2A0")]
	public ClubInvitePopupController()
	{
	}

	[Address(RVA="0x11BF298", Offset="0x11BF298", VA="0x11BF298", Slot="11")]
	public override ITransitionContext GetCurrentContext()
	{
		return null;
	}

	[Address(RVA="0x11BEF94", Offset="0x11BEF94", VA="0x11BEF94", Slot="14")]
	public void HandleDispatchAction(DClubInvitePopupViewAction action)
	{
	}

	[Address(RVA="0x11BF0F4", Offset="0x11BF0F4", VA="0x11BF0F4", Slot="16")]
	public void HandleDispatchAction(DClubInviteAcceptedAction action)
	{
	}

	[Address(RVA="0x11BF158", Offset="0x11BF158", VA="0x11BF158", Slot="17")]
	public void HandleDispatchAction(DClubInviteRejectedAction action)
	{
	}

	[Address(RVA="0x11BF1C8", Offset="0x11BF1C8", VA="0x11BF1C8", Slot="15")]
	public void HandleDispatchAction(DClubInvitePopupViewNavigateAction action)
	{
	}

	[Address(RVA="0x11BEE3C", Offset="0x11BEE3C", VA="0x11BEE3C", Slot="8")]
	public override void Initialize(ITransitionContext context, Action completed)
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104B98C", Offset="0x104B98C")]
	private sealed class <>c__DisplayClass0_0
	{
		[FieldOffset(Offset="0x10")]
		public ClubInvitePopupController <>4__this;

		[FieldOffset(Offset="0x18")]
		public Action completed;

		[Address(RVA="0x11BEF8C", Offset="0x11BEF8C", VA="0x11BEF8C")]
		public <>c__DisplayClass0_0()
		{
		}

		[Address(RVA="0x11BF2A8", Offset="0x11BF2A8", VA="0x11BF2A8")]
		internal void <Initialize>b__0(ClubInvitePopupView view)
		{
		}
	}

	public class Context : ITransitionContext
	{
		[FieldOffset(Offset="0x10")]
		public readonly ClubInvite Invite;

		[Address(RVA="0x11BF504", Offset="0x11BF504", VA="0x11BF504")]
		public Context(ClubInvite invite)
		{
		}
	}
}