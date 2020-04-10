using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;

public class AgeGateController : AFeatureController, IDispatchHandler<DAgeGateViewAction>, IDispatchHandler, IDispatchHandler<DTitleViewAction>, IDispatchHandler<DAgeGateNameViewAction>
{
	[Attribute(Name="InjectAttribute", RVA="0x10524C0", Offset="0x10524C0")]
	[FieldOffset(Offset="0x68")]
	private PlayerService _playerService;

	[Attribute(Name="InjectAttribute", RVA="0x10524D0", Offset="0x10524D0")]
	[FieldOffset(Offset="0x70")]
	private GamedataDomainController _gamedataDC;

	[Attribute(Name="InjectAttribute", RVA="0x10524E0", Offset="0x10524E0")]
	[FieldOffset(Offset="0x78")]
	private TitleController _titleController;

	[Attribute(Name="InjectAttribute", RVA="0x10524F0", Offset="0x10524F0")]
	[FieldOffset(Offset="0x80")]
	private PlayerDomainController _playerDC;

	[Attribute(Name="InjectAttribute", RVA="0x1052500", Offset="0x1052500")]
	[FieldOffset(Offset="0x88")]
	private ProfanityFilter _profanityFilter;

	[Attribute(Name="InjectAttribute", RVA="0x1052510", Offset="0x1052510")]
	[FieldOffset(Offset="0x90")]
	private SystemDialogManager _dialogManager;

	[Attribute(Name="InjectAttribute", RVA="0x1052520", Offset="0x1052520")]
	[FieldOffset(Offset="0x98")]
	private LocalizationManager _lm;

	[FieldOffset(Offset="0xA0")]
	private AgeGateView _ageGateView;

	[FieldOffset(Offset="0xA8")]
	private AgeGateNameView _ageGateNameView;

	[Address(RVA="0x1157D4C", Offset="0x1157D4C", VA="0x1157D4C")]
	public AgeGateController()
	{
	}

	[Address(RVA="0x1157D54", Offset="0x1157D54", VA="0x1157D54")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106DF88", Offset="0x106DF88")]
	private void <SendAgeGateRequest>b__4_0(AgeGateResponse success)
	{
	}

	[Address(RVA="0x1157DAC", Offset="0x1157DAC", VA="0x1157DAC")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106DF98", Offset="0x106DF98")]
	private void <SendAgeGateRequest>b__4_1(long failureCode)
	{
	}

	[Address(RVA="0x11576B0", Offset="0x11576B0", VA="0x11576B0", Slot="13")]
	public void HandleDispatchAction(DAgeGateViewAction action)
	{
	}

	[Address(RVA="0x1157934", Offset="0x1157934", VA="0x1157934", Slot="14")]
	public void HandleDispatchAction(DTitleViewAction action)
	{
	}

	[Address(RVA="0x1157974", Offset="0x1157974", VA="0x1157974", Slot="15")]
	public void HandleDispatchAction(DAgeGateNameViewAction action)
	{
	}

	[Address(RVA="0x1157514", Offset="0x1157514", VA="0x1157514", Slot="6")]
	public override void Initialize(GameStateTransitionContext context)
	{
	}

	[Address(RVA="0x11578F4", Offset="0x11578F4", VA="0x11578F4")]
	private void NavigateToUrl(string url)
	{
	}

	[Address(RVA="0x115779C", Offset="0x115779C", VA="0x115779C")]
	private void SendAgeGateRequest(int age)
	{
	}

	[Address(RVA="0x1157AA4", Offset="0x1157AA4", VA="0x1157AA4")]
	private void SetPlayerName(string name)
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104AE2C", Offset="0x104AE2C")]
	private sealed class <>c__DisplayClass0_0
	{
		[FieldOffset(Offset="0x10")]
		public AgeGateController <>4__this;

		[FieldOffset(Offset="0x18")]
		public bool enteredFromTitleScreen;

		[FieldOffset(Offset="0x20")]
		public GameStateTransitionContext context;

		[Address(RVA="0x11576A8", Offset="0x11576A8", VA="0x11576A8")]
		public <>c__DisplayClass0_0()
		{
		}

		[Address(RVA="0x1157E28", Offset="0x1157E28", VA="0x1157E28")]
		internal void <Initialize>b__0(Action finished)
		{
		}

		[Address(RVA="0x1157F24", Offset="0x1157F24", VA="0x1157F24")]
		internal void <Initialize>b__1()
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104AE3C", Offset="0x104AE3C")]
	private sealed class <>c__DisplayClass0_1
	{
		[FieldOffset(Offset="0x10")]
		public Action finished;

		[FieldOffset(Offset="0x18")]
		public AgeGateController.<>c__DisplayClass0_0 CS$<>8__locals1;

		[Address(RVA="0x1157F1C", Offset="0x1157F1C", VA="0x1157F1C")]
		public <>c__DisplayClass0_1()
		{
		}

		[Address(RVA="0x1157FC0", Offset="0x1157FC0", VA="0x1157FC0")]
		internal void <Initialize>b__2(AgeGateNameView view)
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104AE4C", Offset="0x104AE4C")]
	private sealed class <>c__DisplayClass6_0
	{
		[FieldOffset(Offset="0x10")]
		public string name;

		[FieldOffset(Offset="0x18")]
		public AgeGateController <>4__this;

		[FieldOffset(Offset="0x20")]
		public Action<UpdatePlayerProfileResponse> <>9__2;

		[FieldOffset(Offset="0x28")]
		public Action<long> <>9__3;

		[Address(RVA="0x1157D44", Offset="0x1157D44", VA="0x1157D44")]
		public <>c__DisplayClass6_0()
		{
		}

		[Address(RVA="0x1158104", Offset="0x1158104", VA="0x1158104")]
		internal void <SetPlayerName>b__0(AgeGateResponse success)
		{
		}

		[Address(RVA="0x11584FC", Offset="0x11584FC", VA="0x11584FC")]
		internal void <SetPlayerName>b__1(long failureCode)
		{
		}

		[Address(RVA="0x115834C", Offset="0x115834C", VA="0x115834C")]
		internal void <SetPlayerName>b__2(UpdatePlayerProfileResponse response)
		{
		}

		[Address(RVA="0x1158404", Offset="0x1158404", VA="0x1158404")]
		internal void <SetPlayerName>b__3(long errorCode)
		{
		}
	}
}