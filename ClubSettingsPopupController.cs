using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;

public class ClubSettingsPopupController : APopupController, IDispatchHandler<DClubSettingsPopupViewAction>, IDispatchHandler, IDispatchHandler<DClubAvatarChangedAction>, IDispatchHandler<DClubSettingsChangedAction>
{
	[Attribute(Name="InjectAttribute", RVA="0x105661C", Offset="0x105661C")]
	[FieldOffset(Offset="0x38")]
	private GamedataDomainController _gamedataDC;

	[Attribute(Name="InjectAttribute", RVA="0x105662C", Offset="0x105662C")]
	[FieldOffset(Offset="0x40")]
	private ClubServiceUtility _clubServiceUtility;

	[Attribute(Name="InjectAttribute", RVA="0x105663C", Offset="0x105663C")]
	[FieldOffset(Offset="0x48")]
	private ProfanityFilter _profanityFilter;

	[Attribute(Name="InjectAttribute", RVA="0x105664C", Offset="0x105664C")]
	[FieldOffset(Offset="0x50")]
	private SystemDialogManager _dialogManager;

	[Attribute(Name="InjectAttribute", RVA="0x105665C", Offset="0x105665C")]
	[FieldOffset(Offset="0x58")]
	private LocalizationManager _lm;

	[FieldOffset(Offset="0x60")]
	private ClubSettingsPopupView _view;

	[FieldOffset(Offset="0x68")]
	private Club _club;

	[FieldOffset(Offset="0x70")]
	private ClubSettings _newSettings;

	[Address(RVA="0x1266790", Offset="0x1266790", VA="0x1266790")]
	public ClubSettingsPopupController()
	{
	}

	[Address(RVA="0x1265FB4", Offset="0x1265FB4", VA="0x1265FB4", Slot="14")]
	public void HandleDispatchAction(DClubSettingsPopupViewAction action)
	{
	}

	[Address(RVA="0x12664DC", Offset="0x12664DC", VA="0x12664DC", Slot="15")]
	public void HandleDispatchAction(DClubAvatarChangedAction action)
	{
	}

	[Address(RVA="0x1266704", Offset="0x1266704", VA="0x1266704", Slot="16")]
	public void HandleDispatchAction(DClubSettingsChangedAction action)
	{
	}

	[Address(RVA="0x1266280", Offset="0x1266280", VA="0x1266280")]
	private bool HaveSettingsChanged()
	{
		return new bool();
	}

	[Address(RVA="0x1265E14", Offset="0x1265E14", VA="0x1265E14", Slot="8")]
	public override void Initialize(ITransitionContext context, Action completed)
	{
	}

	[Address(RVA="0x1266428", Offset="0x1266428", VA="0x1266428")]
	private bool IsDescriptionValid()
	{
		return new bool();
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104B85C", Offset="0x104B85C")]
	private sealed class <>c__DisplayClass0_0
	{
		[FieldOffset(Offset="0x10")]
		public ClubSettingsPopupController <>4__this;

		[FieldOffset(Offset="0x18")]
		public Action completed;

		[Address(RVA="0x1265FAC", Offset="0x1265FAC", VA="0x1265FAC")]
		public <>c__DisplayClass0_0()
		{
		}

		[Address(RVA="0x1266798", Offset="0x1266798", VA="0x1266798")]
		internal void <Initialize>b__0(ClubSettingsPopupView view)
		{
		}
	}

	public class Context : ITransitionContext
	{
		[FieldOffset(Offset="0x10")]
		public readonly Club Club;

		[Address(RVA="0x1266BC4", Offset="0x1266BC4", VA="0x1266BC4")]
		public Context(Club club)
		{
		}
	}
}