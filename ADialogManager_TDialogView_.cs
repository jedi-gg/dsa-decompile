using Glunies;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;

public abstract class ADialogManager<TDialogView> : IAssetDependentLifecycleObject, IDispatchHandler<DDialogViewAction>, IDispatchHandler, IDispatchHandler<DViewAction>
where TDialogView : ADialogView, new()
{
	[FieldOffset(Offset="0x0")]
	private const float IGNORE_INPUT_DURATION_S = 0.5f;

	[Attribute(Name="InjectAttribute", RVA="0x1057B54", Offset="0x1057B54")]
	[FieldOffset(Offset="0x0")]
	protected ViewController _viewController;

	[Attribute(Name="InjectAttribute", RVA="0x1057B64", Offset="0x1057B64")]
	[FieldOffset(Offset="0x0")]
	protected DispatchSystem _dispatchSystem;

	[FieldOffset(Offset="0x0")]
	protected ADialogView _view;

	[FieldOffset(Offset="0x0")]
	private Stack<DialogContext> _dialogStack;

	[FieldOffset(Offset="0x0")]
	private float _ignoreInputCountdownS;

	[FieldOffset(Offset="0x0")]
	private bool _isShutdown;

	public bool DialogShowing
	{
		[Address(RVA="0x211E058", Offset="0x211E058", VA="0x211E058")]
		get
		{
			return new bool();
		}
	}

	[Address(RVA="0x211EC00", Offset="0x211EC00", VA="0x211EC00")]
	protected ADialogManager()
	{
	}

	[Address(RVA="0x211E60C", Offset="0x211E60C", VA="0x211E60C")]
	public void Alert(string alertText, Action acknowledged = // 
	// Current member / type: System.Void ADialogManager`1::Alert(System.String,System.Action)
	// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
	// 
	// Product version: 2018.1.123.0
	// Exception in: System.Void Alert(System.String,System.Action)
	// 
	// Object reference not set to an instance of an object.
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
	//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
	// 
	// mailto: JustDecompilePublicFeedback@telerik.com


	[Address(RVA="0x211E6F8", Offset="0x211E6F8", VA="0x211E6F8")]
	public void Confirm(string confirmText, string buttonText, Action confirmed)
	{
	}

	[Address(RVA="0x211EAB0", Offset="0x211EAB0", VA="0x211EAB0")]
	private void DismissWithAction(DDialogViewAction.Type dialogAction)
	{
	}

	[Address(RVA="0x211E7EC", Offset="0x211E7EC", VA="0x211E7EC", Slot="8")]
	public void HandleDispatchAction(DDialogViewAction dialogAction)
	{
	}

	[Address(RVA="0x211E82C", Offset="0x211E82C", VA="0x211E82C", Slot="9")]
	public void HandleDispatchAction(DViewAction viewAction)
	{
	}

	[Address(RVA="0x211E0C4", Offset="0x211E0C4", VA="0x211E0C4", Slot="4")]
	public void Initialize(Action finished)
	{
	}

	[Address(RVA="0x211E414", Offset="0x211E414", VA="0x211E414")]
	public bool IsShowing(string dialogId)
	{
		return new bool();
	}

	[Address(RVA="0x211E93C", Offset="0x211E93C", VA="0x211E93C")]
	private bool IsShutdown()
	{
		return new bool();
	}

	[Address(RVA="0x211E154", Offset="0x211E154", VA="0x211E154", Slot="6")]
	public void LoadAssets(Action finished)
	{
	}

	[Address(RVA="0x211E2DC", Offset="0x211E2DC", VA="0x211E2DC", Slot="7")]
	public void ReleaseAssets()
	{
	}

	[Address(RVA="0x211E4EC", Offset="0x211E4EC", VA="0x211E4EC")]
	public void Show(DialogContext context)
	{
	}

	[Address(RVA="0x211E944", Offset="0x211E944", VA="0x211E944")]
	private void ShowTopDialog()
	{
	}

	[Address(RVA="0x211E110", Offset="0x211E110", VA="0x211E110", Slot="5")]
	public void Shutdown()
	{
	}

	[Address(RVA="0x211E390", Offset="0x211E390", VA="0x211E390")]
	public void TickUpdate()
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104BCFC", Offset="0x104BCFC")]
	private sealed class <>c__DisplayClass4_0
	{
		[FieldOffset(Offset="0x0")]
		public ADialogManager<TDialogView> <>4__this;

		[FieldOffset(Offset="0x0")]
		public Action finished;

		[Address(RVA="0x211DFD8", Offset="0x211DFD8", VA="0x211DFD8")]
		public <>c__DisplayClass4_0()
		{
		}

		[Address(RVA="0x211E004", Offset="0x211E004", VA="0x211E004")]
		internal void <LoadAssets>b__0(TDialogView view)
		{
		}
	}
}