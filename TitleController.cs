using Glunies;
using Il2CppDummyDll;
using System;

public class TitleController : IDispatchHandler<DTutorialAssetsDownloadCompletedAction>, IDispatchHandler, IDispatchHandler<DTitleViewAction>, IDispatchHandler<DHideTitleViewAction>
{
	[Attribute(Name="InjectAttribute", RVA="0x105D678", Offset="0x105D678")]
	[FieldOffset(Offset="0x10")]
	private ViewController _viewController;

	[Attribute(Name="InjectAttribute", RVA="0x105D688", Offset="0x105D688")]
	[FieldOffset(Offset="0x18")]
	private DispatchSystem _dispatchSystem;

	[Attribute(Name="InjectAttribute", RVA="0x105D698", Offset="0x105D698")]
	[FieldOffset(Offset="0x20")]
	private SharedPrefs _sharedPrefs;

	[Attribute(Name="InjectAttribute", RVA="0x105D6A8", Offset="0x105D6A8")]
	[FieldOffset(Offset="0x28")]
	private DeepLinkHandler _deepLinkHandler;

	[FieldOffset(Offset="0x30")]
	private TitleView _view;

	[FieldOffset(Offset="0x38")]
	private bool _isShutdown;

	public bool IsActive
	{
		[Address(RVA="0x1326D60", Offset="0x1326D60", VA="0x1326D60")]
		get
		{
			return new bool();
		}
	}

	[Address(RVA="0x1327748", Offset="0x1327748", VA="0x1327748")]
	public TitleController()
	{
	}

	[Address(RVA="0x1327148", Offset="0x1327148", VA="0x1327148", Slot="4")]
	public void HandleDispatchAction(DTutorialAssetsDownloadCompletedAction action)
	{
	}

	[Address(RVA="0x13271B4", Offset="0x13271B4", VA="0x13271B4", Slot="6")]
	public void HandleDispatchAction(DHideTitleViewAction action)
	{
	}

	[Address(RVA="0x1327694", Offset="0x1327694", VA="0x1327694", Slot="5")]
	public void HandleDispatchAction(DTitleViewAction action)
	{
	}

	[Address(RVA="0x1326D70", Offset="0x1326D70", VA="0x1326D70")]
	public void Initialize(Action completed)
	{
	}

	[Address(RVA="0x1327740", Offset="0x1327740", VA="0x1327740")]
	private bool IsShutdown()
	{
		return new bool();
	}

	[Address(RVA="0x1326F80", Offset="0x1326F80", VA="0x1326F80")]
	public void Show(TitleView.InitialState initialState)
	{
	}

	[Address(RVA="0x1326ED8", Offset="0x1326ED8", VA="0x1326ED8")]
	public void Shutdown()
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104CE5C", Offset="0x104CE5C")]
	private sealed class <>c__DisplayClass2_0
	{
		[FieldOffset(Offset="0x10")]
		public TitleController <>4__this;

		[FieldOffset(Offset="0x18")]
		public Action completed;

		[Address(RVA="0x1326ED0", Offset="0x1326ED0", VA="0x1326ED0")]
		public <>c__DisplayClass2_0()
		{
		}

		[Address(RVA="0x1327758", Offset="0x1327758", VA="0x1327758")]
		internal void <Initialize>b__0(TitleView view)
		{
		}
	}
}