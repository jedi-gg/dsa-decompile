using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;

public class PvpLobbyController : IDispatchHandler<DPvpLobbyViewAction>, IDispatchHandler, IDispatchHandler<DDailyPvpRewardAction>
{
	[Attribute(Name="InjectAttribute", RVA="0x105BD80", Offset="0x105BD80")]
	[FieldOffset(Offset="0x10")]
	private DispatchSystem _dispatchSystem;

	[Attribute(Name="InjectAttribute", RVA="0x105BD90", Offset="0x105BD90")]
	[FieldOffset(Offset="0x18")]
	private ViewController _viewController;

	[Attribute(Name="InjectAttribute", RVA="0x105BDA0", Offset="0x105BDA0")]
	[FieldOffset(Offset="0x20")]
	private GameStateMachine _gameStateMachine;

	[Attribute(Name="InjectAttribute", RVA="0x105BDB0", Offset="0x105BDB0")]
	[FieldOffset(Offset="0x28")]
	private PlayerDomainController _playerDC;

	[Attribute(Name="InjectAttribute", RVA="0x105BDC0", Offset="0x105BDC0")]
	[FieldOffset(Offset="0x30")]
	private GamedataDomainController _gamedataDC;

	[Attribute(Name="InjectAttribute", RVA="0x105BDD0", Offset="0x105BDD0")]
	[FieldOffset(Offset="0x38")]
	private ChatPreviewController _chatPreviewController;

	[Attribute(Name="InjectAttribute", RVA="0x105BDE0", Offset="0x105BDE0")]
	[FieldOffset(Offset="0x40")]
	private DailyPvpRewardHelper _dailyPvpRewardHelper;

	[Attribute(Name="InjectAttribute", RVA="0x105BDF0", Offset="0x105BDF0")]
	[FieldOffset(Offset="0x48")]
	private PassportSeasonUtility _passportSeasonUtility;

	[FieldOffset(Offset="0x50")]
	private PvpLobbyView _view;

	[FieldOffset(Offset="0x58")]
	private bool _isShutdown;

	[Address(RVA="0x12873A0", Offset="0x12873A0", VA="0x12873A0")]
	public PvpLobbyController()
	{
	}

	[Address(RVA="0x138E920", Offset="0x138E920", VA="0x138E920")]
	private void EnterState<TState>(GameStateTransitionContext context = // 
	// Current member / type: System.Void PvpLobbyController::EnterState(Glunies.GameStateTransitionContext)
	// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
	// 
	// Product version: 2018.1.123.0
	// Exception in: System.Void EnterState(Glunies.GameStateTransitionContext)
	// 
	// Object reference not set to an instance of an object.
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
	//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
	// 
	// mailto: JustDecompilePublicFeedback@telerik.com


	[Address(RVA="0x1286AD0", Offset="0x1286AD0", VA="0x1286AD0")]
	public void FinishFeatureInitialization(PvpLobbyResponse pvpLobbyResponse)
	{
	}

	[Address(RVA="0x1287250", Offset="0x1287250", VA="0x1287250")]
	private string GetSeasonIdString()
	{
		return null;
	}

	[Address(RVA="0x1286E54", Offset="0x1286E54", VA="0x1286E54", Slot="4")]
	public void HandleDispatchAction(DPvpLobbyViewAction action)
	{
	}

	[Address(RVA="0x1287334", Offset="0x1287334", VA="0x1287334", Slot="5")]
	public void HandleDispatchAction(DDailyPvpRewardAction action)
	{
	}

	[Address(RVA="0x1286858", Offset="0x1286858", VA="0x1286858")]
	public void Initialize(Action completed)
	{
	}

	[Address(RVA="0x1287398", Offset="0x1287398", VA="0x1287398")]
	private bool IsShutdown()
	{
		return new bool();
	}

	[Address(RVA="0x1286A24", Offset="0x1286A24", VA="0x1286A24")]
	public void Shutdown()
	{
	}

	[Address(RVA="0x12869A8", Offset="0x12869A8", VA="0x12869A8")]
	public void TickUpdate()
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104C85C", Offset="0x104C85C")]
	private sealed class <>c__DisplayClass0_0
	{
		[FieldOffset(Offset="0x10")]
		public PvpLobbyController <>4__this;

		[FieldOffset(Offset="0x18")]
		public Action completed;

		[Address(RVA="0x12869A0", Offset="0x12869A0", VA="0x12869A0")]
		public <>c__DisplayClass0_0()
		{
		}

		[Address(RVA="0x12873A8", Offset="0x12873A8", VA="0x12873A8")]
		internal void <Initialize>b__0(PvpLobbyView view)
		{
		}
	}
}