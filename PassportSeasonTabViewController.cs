using Glunies;
using Il2CppDummyDll;
using System;

public class PassportSeasonTabViewController : TabViewController<PassportSeasonTabView>, IDispatchHandler<DPassportSeasonTabViewAction>, IDispatchHandler
{
	[Attribute(Name="InjectAttribute", RVA="0x105AEFC", Offset="0x105AEFC")]
	[FieldOffset(Offset="0x30")]
	private PassportSeasonUtility _passportSeasonUtility;

	[Attribute(Name="InjectAttribute", RVA="0x105AF0C", Offset="0x105AF0C")]
	[FieldOffset(Offset="0x38")]
	private GameStateMachine _gameStateMachine;

	[Attribute(Name="InjectAttribute", RVA="0x105AF1C", Offset="0x105AF1C")]
	[FieldOffset(Offset="0x40")]
	private LocalizationManager _lm;

	[Attribute(Name="InjectAttribute", RVA="0x105AF2C", Offset="0x105AF2C")]
	[FieldOffset(Offset="0x48")]
	private SystemDialogManager _systemDialogManager;

	[Address(RVA="0x1408B0C", Offset="0x1408B0C", VA="0x1408B0C")]
	public PassportSeasonTabViewController()
	{
	}

	[Address(RVA="0x1408B5C", Offset="0x1408B5C", VA="0x1408B5C")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10702D4", Offset="0x10702D4")]
	private void <PassportSeasonExpired>b__4_0()
	{
	}

	[Address(RVA="0x138E3E8", Offset="0x138E3E8", VA="0x138E3E8")]
	private void EnterState<TState>(GameStateTransitionContext context = // 
	// Current member / type: System.Void PassportSeasonTabViewController::EnterState(Glunies.GameStateTransitionContext)
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


	[Address(RVA="0x1408398", Offset="0x1408398", VA="0x1408398", Slot="6")]
	public void HandleDispatchAction(DPassportSeasonTabViewAction action)
	{
	}

	[Address(RVA="0x1408918", Offset="0x1408918", VA="0x1408918", Slot="5")]
	protected override void InitializeView(int initialSelectedTab)
	{
	}

	[Address(RVA="0x14087F4", Offset="0x14087F4", VA="0x14087F4")]
	private void PassportSeasonExpired()
	{
	}

	[Address(RVA="0x13FBE94", Offset="0x13FBE94", VA="0x13FBE94")]
	public void TickUpdate()
	{
	}
}