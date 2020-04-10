using Gamedata;
using Glunies;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;

public class PinCollectionController : AFeatureController, IDispatchHandler<DPinPageItemAction>, IDispatchHandler
{
	[Attribute(Name="InjectAttribute", RVA="0x105B204", Offset="0x105B204")]
	[FieldOffset(Offset="0x68")]
	private GamedataDomainController _gamedataDC;

	[Attribute(Name="InjectAttribute", RVA="0x105B214", Offset="0x105B214")]
	[FieldOffset(Offset="0x70")]
	private PlayerDomainController _playerDC;

	[FieldOffset(Offset="0x78")]
	private PinCollectionView _view;

	[FieldOffset(Offset="0x80")]
	private List<OwnedSetPinPageCollection> _ownedSetPinPageCollections;

	[Address(RVA="0x140C5A8", Offset="0x140C5A8", VA="0x140C5A8")]
	public PinCollectionController()
	{
	}

	[Address(RVA="0x140C424", Offset="0x140C424", VA="0x140C424")]
	private int ComparePinPageCollection(PinPageCollection? aPinPage, PinPageCollection? bPinPage)
	{
		return new int();
	}

	[Address(RVA="0x140B934", Offset="0x140B934", VA="0x140B934")]
	private List<InventoryItem?> GetOwnedLimitedPins()
	{
		return null;
	}

	[Address(RVA="0x140B5A4", Offset="0x140B5A4", VA="0x140B5A4")]
	private List<InventoryItem?> GetOwnedSeasonalPassportPins()
	{
		return null;
	}

	[Address(RVA="0x140BDFC", Offset="0x140BDFC", VA="0x140BDFC")]
	private List<PinPageCollection?> GetPinPageCollections()
	{
		return null;
	}

	[Address(RVA="0x140BCC4", Offset="0x140BCC4", VA="0x140BCC4", Slot="13")]
	public void HandleDispatchAction(DPinPageItemAction action)
	{
	}

	[Address(RVA="0x140B300", Offset="0x140B300", VA="0x140B300", Slot="6")]
	public override void Initialize(GameStateTransitionContext context)
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104C5CC", Offset="0x104C5CC")]
	private sealed class <>c__DisplayClass0_0
	{
		[FieldOffset(Offset="0x10")]
		public PinCollectionController <>4__this;

		[FieldOffset(Offset="0x18")]
		public GameStateTransitionContext context;

		[Address(RVA="0x140B59C", Offset="0x140B59C", VA="0x140B59C")]
		public <>c__DisplayClass0_0()
		{
		}

		[Address(RVA="0x140C5B0", Offset="0x140C5B0", VA="0x140C5B0")]
		internal void <Initialize>b__0(PinCollectionView view)
		{
		}
	}
}