using Glunies;
using Il2CppDummyDll;
using System;

public class BattleStateTransitionController : IAssetDependentLifecycleObject, IDispatchHandler<DBattleStateTransitionViewAction>, IDispatchHandler, IDispatchHandler<DHideScrimsAction>
{
	[Attribute(Name="InjectAttribute", RVA="0x1053AF0", Offset="0x1053AF0")]
	[FieldOffset(Offset="0x10")]
	private DispatchSystem _dispatchSystem;

	[Attribute(Name="InjectAttribute", RVA="0x1053B00", Offset="0x1053B00")]
	[FieldOffset(Offset="0x18")]
	private ViewController _viewController;

	[Attribute(Name="InjectAttribute", RVA="0x1053B10", Offset="0x1053B10")]
	[FieldOffset(Offset="0x20")]
	private GameStateMachine _gameStateMachine;

	[FieldOffset(Offset="0x28")]
	private BattleStateTransitionView _transitionView;

	[FieldOffset(Offset="0x30")]
	private Type _pendingGameState;

	[FieldOffset(Offset="0x38")]
	private ITransitionContext _pendingTransitionContext;

	[FieldOffset(Offset="0x40")]
	private bool _isShutdown;

	[Address(RVA="0x1293FC4", Offset="0x1293FC4", VA="0x1293FC4")]
	public BattleStateTransitionController()
	{
	}

	[Address(RVA="0x199FC34", Offset="0x199FC34", VA="0x199FC34")]
	public void EnterState<TState>(ITransitionContext context = // 
	// Current member / type: System.Void BattleStateTransitionController::EnterState(Glunies.ITransitionContext)
	// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
	// 
	// Product version: 2018.1.123.0
	// Exception in: System.Void EnterState(Glunies.ITransitionContext)
	// 
	// Object reference not set to an instance of an object.
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
	//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
	// 
	// mailto: JustDecompilePublicFeedback@telerik.com


	[Address(RVA="0x1293DC4", Offset="0x1293DC4", VA="0x1293DC4")]
	public void EnterState(Type gameStateType, ITransitionContext context = // 
	// Current member / type: System.Void BattleStateTransitionController::EnterState(System.Type,Glunies.ITransitionContext)
	// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
	// 
	// Product version: 2018.1.123.0
	// Exception in: System.Void EnterState(System.Type,Glunies.ITransitionContext)
	// 
	// Object reference not set to an instance of an object.
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
	//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
	// 
	// mailto: JustDecompilePublicFeedback@telerik.com


	[Address(RVA="0x1293E30", Offset="0x1293E30", VA="0x1293E30", Slot="8")]
	public void HandleDispatchAction(DBattleStateTransitionViewAction action)
	{
	}

	[Address(RVA="0x1293E88", Offset="0x1293E88", VA="0x1293E88", Slot="9")]
	public void HandleDispatchAction(DHideScrimsAction action)
	{
	}

	[Address(RVA="0x1293C1C", Offset="0x1293C1C", VA="0x1293C1C", Slot="4")]
	public void Initialize(Action finished)
	{
	}

	[Address(RVA="0x1293FBC", Offset="0x1293FBC", VA="0x1293FBC")]
	private bool IsShutdown()
	{
		return new bool();
	}

	[Address(RVA="0x1293C20", Offset="0x1293C20", VA="0x1293C20", Slot="6")]
	public void LoadAssets(Action finished)
	{
	}

	[Address(RVA="0x1293D54", Offset="0x1293D54", VA="0x1293D54", Slot="7")]
	public void ReleaseAssets()
	{
	}

	[Address(RVA="0x1293D48", Offset="0x1293D48", VA="0x1293D48", Slot="5")]
	public void Shutdown()
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104B03C", Offset="0x104B03C")]
	private sealed class <>c__DisplayClass2_0
	{
		[FieldOffset(Offset="0x10")]
		public BattleStateTransitionController <>4__this;

		[FieldOffset(Offset="0x18")]
		public Action finished;

		[Address(RVA="0x1293DBC", Offset="0x1293DBC", VA="0x1293DBC")]
		public <>c__DisplayClass2_0()
		{
		}

		[Address(RVA="0x1293FCC", Offset="0x1293FCC", VA="0x1293FCC")]
		internal void <LoadAssets>b__0(BattleStateTransitionView view)
		{
		}
	}
}