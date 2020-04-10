using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;

public class DailyPvpRewardHelper : ILoggable<LogCategory>, IDispatchHandler<DPlayerActivityUpdatedAction>, IDispatchHandler, IDispatchHandler<DDailyPvpRewardAction>
{
	[Attribute(Name="InjectAttribute", RVA="0x105BC90", Offset="0x105BC90")]
	[FieldOffset(Offset="0x10")]
	private PlayerDomainController _playerDC;

	[Attribute(Name="InjectAttribute", RVA="0x105BCA0", Offset="0x105BCA0")]
	[FieldOffset(Offset="0x18")]
	private GamedataDomainController _gamedataDC;

	[Attribute(Name="InjectAttribute", RVA="0x105BCB0", Offset="0x105BCB0")]
	[FieldOffset(Offset="0x20")]
	private PlayerService _playerService;

	[Attribute(Name="InjectAttribute", RVA="0x105BCC0", Offset="0x105BCC0")]
	[FieldOffset(Offset="0x28")]
	private DispatchSystem _dispatchSystem;

	[Attribute(Name="InjectAttribute", RVA="0x105BCD0", Offset="0x105BCD0")]
	[FieldOffset(Offset="0x30")]
	private LocalizationManager _lm;

	[Attribute(Name="InjectAttribute", RVA="0x105BCE0", Offset="0x105BCE0")]
	[FieldOffset(Offset="0x38")]
	private GameStateMachine _gameStateMachine;

	[FieldOffset(Offset="0x40")]
	private DailyPvpRewardWidget _widget;

	[FieldOffset(Offset="0x48")]
	private bool _isShutdown;

	public LogCategory LogCategory
	{
		[Address(RVA="0x12B24B0", Offset="0x12B24B0", VA="0x12B24B0", Slot="4")]
		get
		{
			return new LogCategory();
		}
	}

	[Address(RVA="0x12B3468", Offset="0x12B3468", VA="0x12B3468")]
	public DailyPvpRewardHelper()
	{
	}

	[Address(RVA="0x12B3470", Offset="0x12B3470", VA="0x12B3470")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1070724", Offset="0x1070724")]
	private void <ClaimDailyPvpReward>b__9_0(ClaimActivityResponse response)
	{
	}

	[Address(RVA="0x12B34DC", Offset="0x12B34DC", VA="0x12B34DC")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1070734", Offset="0x1070734")]
	private void <ClaimDailyPvpReward>b__9_1(long errorCode)
	{
	}

	[Address(RVA="0x12B28CC", Offset="0x12B28CC", VA="0x12B28CC")]
	private bool CanPurchaseDailyPvpReward()
	{
		return new bool();
	}

	[Address(RVA="0x12B2B18", Offset="0x12B2B18", VA="0x12B2B18")]
	private void ClaimDailyPvpReward()
	{
	}

	[Address(RVA="0x19A0C78", Offset="0x19A0C78", VA="0x19A0C78")]
	private void EnterState<TState>(GameStateTransitionContext context = // 
	// Current member / type: System.Void DailyPvpRewardHelper::EnterState(Glunies.GameStateTransitionContext)
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


	[Address(RVA="0x12B2870", Offset="0x12B2870", VA="0x12B2870", Slot="5")]
	public void HandleDispatchAction(DPlayerActivityUpdatedAction action)
	{
	}

	[Address(RVA="0x12B2880", Offset="0x12B2880", VA="0x12B2880", Slot="6")]
	public void HandleDispatchAction(DDailyPvpRewardAction action)
	{
	}

	[Address(RVA="0x12B24B8", Offset="0x12B24B8", VA="0x12B24B8")]
	public void Initialize(DailyPvpRewardWidget widget)
	{
	}

	[Address(RVA="0x12B24F8", Offset="0x12B24F8", VA="0x12B24F8")]
	private void InitializeDailyPvpReward()
	{
	}

	[Address(RVA="0x12B3460", Offset="0x12B3460", VA="0x12B3460")]
	private bool IsShutdown()
	{
		return new bool();
	}

	[Address(RVA="0x12B29E4", Offset="0x12B29E4", VA="0x12B29E4")]
	private void PurchaseDailyPvpReward()
	{
	}

	[Address(RVA="0x12B2828", Offset="0x12B2828", VA="0x12B2828")]
	public void Shutdown()
	{
	}

	[Address(RVA="0x12B26A4", Offset="0x12B26A4", VA="0x12B26A4")]
	public void TickUpdate()
	{
	}
}