using Glunies;
using Il2CppDummyDll;
using System;

public class PlayerCollectionPowerController : IAssetDependentLifecycleObject, IDispatchHandler<DPlayerCollectionPowerUpdatedAction>, IDispatchHandler, IDispatchHandler<DPlayerCollectionPowerHideAction>
{
	[Attribute(Name="InjectAttribute", RVA="0x105B6D4", Offset="0x105B6D4")]
	[FieldOffset(Offset="0x10")]
	private ViewController _viewController;

	[Attribute(Name="InjectAttribute", RVA="0x105B6E4", Offset="0x105B6E4")]
	[FieldOffset(Offset="0x18")]
	private DispatchSystem _dispatchSystem;

	[Attribute(Name="InjectAttribute", RVA="0x105B6F4", Offset="0x105B6F4")]
	[FieldOffset(Offset="0x20")]
	private FeatureLockController _featureLockController;

	[FieldOffset(Offset="0x28")]
	private PlayerCollectionPowerView _view;

	[FieldOffset(Offset="0x30")]
	private bool _isShutdown;

	[Address(RVA="0x132ED48", Offset="0x132ED48", VA="0x132ED48")]
	public PlayerCollectionPowerController()
	{
	}

	[Address(RVA="0x132EAF0", Offset="0x132EAF0", VA="0x132EAF0", Slot="8")]
	public void HandleDispatchAction(DPlayerCollectionPowerUpdatedAction action)
	{
	}

	[Address(RVA="0x132ED28", Offset="0x132ED28", VA="0x132ED28", Slot="9")]
	public void HandleDispatchAction(DPlayerCollectionPowerHideAction action)
	{
	}

	[Address(RVA="0x132E944", Offset="0x132E944", VA="0x132E944", Slot="4")]
	public void Initialize(Action finished)
	{
	}

	[Address(RVA="0x132ED40", Offset="0x132ED40", VA="0x132ED40")]
	private bool IsShutdown()
	{
		return new bool();
	}

	[Address(RVA="0x132E948", Offset="0x132E948", VA="0x132E948", Slot="6")]
	public void LoadAssets(Action finished)
	{
	}

	[Address(RVA="0x132EA7C", Offset="0x132EA7C", VA="0x132EA7C", Slot="7")]
	public void ReleaseAssets()
	{
	}

	[Address(RVA="0x132EA70", Offset="0x132EA70", VA="0x132EA70", Slot="5")]
	public void Shutdown()
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104C71C", Offset="0x104C71C")]
	private sealed class <>c__DisplayClass2_0
	{
		[FieldOffset(Offset="0x10")]
		public PlayerCollectionPowerController <>4__this;

		[FieldOffset(Offset="0x18")]
		public Action finished;

		[Address(RVA="0x132EAE8", Offset="0x132EAE8", VA="0x132EAE8")]
		public <>c__DisplayClass2_0()
		{
		}

		[Address(RVA="0x132ED50", Offset="0x132ED50", VA="0x132ED50")]
		internal void <LoadAssets>b__0(PlayerCollectionPowerView view)
		{
		}
	}
}