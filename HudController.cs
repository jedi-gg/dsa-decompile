using Glunies;
using Il2CppDummyDll;
using System;

public class HudController : IAssetDependentLifecycleObject, IDispatchHandler<DHudViewAction>, IDispatchHandler, IDispatchHandler<DHudInputEnabledAction>, IDispatchHandler<DHudItemComponentAction>, IDispatchHandler<DHudShowAction>, IDispatchHandler<DHudHideAction>
{
	[Attribute(Name="InjectAttribute", RVA="0x1058FD8", Offset="0x1058FD8")]
	[FieldOffset(Offset="0x10")]
	private GameStateMachine _gameStateMachine;

	[Attribute(Name="InjectAttribute", RVA="0x1058FE8", Offset="0x1058FE8")]
	[FieldOffset(Offset="0x18")]
	private DispatchSystem _dispatchSystem;

	[Attribute(Name="InjectAttribute", RVA="0x1058FF8", Offset="0x1058FF8")]
	[FieldOffset(Offset="0x20")]
	private ViewController _viewController;

	[Attribute(Name="InjectAttribute", RVA="0x1059008", Offset="0x1059008")]
	[FieldOffset(Offset="0x28")]
	private GamedataDomainController _gamedataDC;

	[FieldOffset(Offset="0x30")]
	private HudView _hudView;

	[FieldOffset(Offset="0x38")]
	private HudController.ItemClickOverride _itemClickOverride;

	[FieldOffset(Offset="0x3C")]
	private bool _isShutdown;

	[Address(RVA="0x1177DB8", Offset="0x1177DB8", VA="0x1177DB8")]
	public HudController()
	{
	}

	[Address(RVA="0x1176D20", Offset="0x1176D20", VA="0x1176D20")]
	public void Configure(DHudConfig config)
	{
	}

	[Address(RVA="0x1388FE4", Offset="0x1388FE4", VA="0x1388FE4")]
	private void EnterState<TState>(GameStateTransitionContext context = // 
	// Current member / type: System.Void HudController::EnterState(Glunies.GameStateTransitionContext)
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


	[Address(RVA="0x1177650", Offset="0x1177650", VA="0x1177650", Slot="8")]
	public void HandleDispatchAction(DHudViewAction action)
	{
	}

	[Address(RVA="0x117779C", Offset="0x117779C", VA="0x117779C", Slot="10")]
	public void HandleDispatchAction(DHudItemComponentAction action)
	{
	}

	[Address(RVA="0x1177C08", Offset="0x1177C08", VA="0x1177C08", Slot="9")]
	public void HandleDispatchAction(DHudInputEnabledAction action)
	{
	}

	[Address(RVA="0x1177CF4", Offset="0x1177CF4", VA="0x1177CF4", Slot="11")]
	public void HandleDispatchAction(DHudShowAction action)
	{
	}

	[Address(RVA="0x1177DA8", Offset="0x1177DA8", VA="0x1177DA8", Slot="12")]
	public void HandleDispatchAction(DHudHideAction action)
	{
	}

	[Address(RVA="0x1176B24", Offset="0x1176B24", VA="0x1176B24", Slot="4")]
	public void Initialize(Action finished)
	{
	}

	[Address(RVA="0x1177DB0", Offset="0x1177DB0", VA="0x1177DB0")]
	private bool IsShutdown()
	{
		return new bool();
	}

	[Address(RVA="0x1176B60", Offset="0x1176B60", VA="0x1176B60", Slot="6")]
	public void LoadAssets(Action finished)
	{
	}

	[Address(RVA="0x117729C", Offset="0x117729C", VA="0x117729C")]
	public void PlayTitleAnimations()
	{
	}

	[Address(RVA="0x1176CCC", Offset="0x1176CCC", VA="0x1176CCC", Slot="7")]
	public void ReleaseAssets()
	{
	}

	[Address(RVA="0x1177648", Offset="0x1177648", VA="0x1177648")]
	public void SetItemClickOverride(HudController.ItemClickOverride itemClickOverride)
	{
	}

	[Address(RVA="0x1177120", Offset="0x1177120", VA="0x1177120")]
	public void Show(bool show)
	{
	}

	[Address(RVA="0x1176C88", Offset="0x1176C88", VA="0x1176C88", Slot="5")]
	public void Shutdown()
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104C08C", Offset="0x104C08C")]
	private sealed class <>c__DisplayClass2_0
	{
		[FieldOffset(Offset="0x10")]
		public HudController <>4__this;

		[FieldOffset(Offset="0x18")]
		public Action finished;

		[Address(RVA="0x1176D18", Offset="0x1176D18", VA="0x1176D18")]
		public <>c__DisplayClass2_0()
		{
		}

		[Address(RVA="0x1177DC0", Offset="0x1177DC0", VA="0x1177DC0")]
		internal void <LoadAssets>b__0(HudView view)
		{
		}
	}

	public enum ItemClickOverride
	{
		[FieldOffset(Offset="0x0")]
		None,
		[FieldOffset(Offset="0x0")]
		ShowItemDetails
	}
}