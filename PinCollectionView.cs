using Gamedata;
using Glunies;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

public class PinCollectionView : AStandardView, IDispatchHandler<DPinCollectionPageTabAction>, IDispatchHandler, IDispatchHandler<DPinPageComponentAction>, IDispatchHandler<DNewPinViewedProcessedAction>
{
	[FieldOffset(Offset="0x0")]
	public const int MAX_PINS_PER_PAGE = 10;

	[FieldOffset(Offset="0x0")]
	private const int MAX_CONCURRENT_PAGES = 3;

	[Attribute(Name="InjectAttribute", RVA="0x105B294", Offset="0x105B294")]
	[FieldOffset(Offset="0x68")]
	private Procrastinator _procrastinator;

	[Attribute(Name="InjectAttribute", RVA="0x105B2A4", Offset="0x105B2A4")]
	[FieldOffset(Offset="0x70")]
	private CardUnlockTrackerController _cardUnlockTracker;

	[FieldOffset(Offset="0x78")]
	private PinPageItemData.Pool _pinPageItemDataPool;

	[FieldOffset(Offset="0x80")]
	private List<PinPageCollection?> _pinPageCollections;

	[FieldOffset(Offset="0x88")]
	private List<OwnedSetPinPageCollection> _ownedSetPinCollections;

	[FieldOffset(Offset="0x90")]
	private int _selectedCollectionIndex;

	[FieldOffset(Offset="0x94")]
	private int _selectedPageIndex;

	[FieldOffset(Offset="0x98")]
	private PinPageComponent _previousPinPage;

	[FieldOffset(Offset="0xA0")]
	private PinPageComponent _currentPinPage;

	[FieldOffset(Offset="0xA8")]
	private PinPageComponent _nextPinPage;

	[FieldOffset(Offset="0xB0")]
	private List<UnityEngine.GameObject> _pinBacks;

	[FieldOffset(Offset="0xB8")]
	private UnityEngine.GameObject _pinBookModel;

	private PinCollectionView.SerializedFields Fields
	{
		[Address(RVA="0x140CD64", Offset="0x140CD64", VA="0x140CD64")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x140F950", Offset="0x140F950", VA="0x140F950")]
	public PinCollectionView()
	{
	}

	[Address(RVA="0x140F9C4", Offset="0x140F9C4", VA="0x140F9C4")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1070344", Offset="0x1070344")]
	private void <ViewAssetLoaded>b__5_0()
	{
	}

	[Address(RVA="0x140F53C", Offset="0x140F53C", VA="0x140F53C")]
	private void BindPageTabListItem(WrappedScrollRectListItem listItem, int index)
	{
	}

	[Address(RVA="0x140EE04", Offset="0x140EE04", VA="0x140EE04")]
	private bool CanNavigateLeft(int collectionIndex, int pageIndex)
	{
		return new bool();
	}

	[Address(RVA="0x140DFAC", Offset="0x140DFAC", VA="0x140DFAC")]
	private bool CanNavigateLeftFromCurrentSelection()
	{
		return new bool();
	}

	[Address(RVA="0x140EE1C", Offset="0x140EE1C", VA="0x140EE1C")]
	private bool CanNavigateRight(int collectionIndex, int pageIndex)
	{
		return new bool();
	}

	[Address(RVA="0x140E168", Offset="0x140E168", VA="0x140E168")]
	private bool CanNavigateRightFromCurrentSelection()
	{
		return new bool();
	}

	[Address(RVA="0x140EF9C", Offset="0x140EF9C", VA="0x140EF9C")]
	private OwnedSetPinPageCollection FindOwnedSetPinPageCollection(ulong pinPageId)
	{
		return null;
	}

	[Address(RVA="0x140ED58", Offset="0x140ED58", VA="0x140ED58")]
	private UnityEngine.Color GetGradientColor(int index)
	{
		return new UnityEngine.Color();
	}

	[Address(RVA="0x140E170", Offset="0x140E170", VA="0x140E170")]
	private void GetNextIndex(ref int collectionIndex, ref int pageIndex)
	{
	}

	[Address(RVA="0x140DFC8", Offset="0x140DFC8", VA="0x140DFC8")]
	private void GetPreviousIndex(ref int collectionIndex, ref int pageIndex)
	{
	}

	[Address(RVA="0x140DEC4", Offset="0x140DEC4", VA="0x140DEC4")]
	private void HandleBookFlip(SinglePageFlipBook.FlipDirection flipMode)
	{
	}

	[Address(RVA="0x140CE44", Offset="0x140CE44", VA="0x140CE44", Slot="21")]
	public void HandleDispatchAction(DPinCollectionPageTabAction action)
	{
	}

	[Address(RVA="0x140CEFC", Offset="0x140CEFC", VA="0x140CEFC", Slot="22")]
	public void HandleDispatchAction(DPinPageComponentAction action)
	{
	}

	[Address(RVA="0x140CF44", Offset="0x140CF44", VA="0x140CF44", Slot="23")]
	public void HandleDispatchAction(DNewPinViewedProcessedAction action)
	{
	}

	[Address(RVA="0x140F460", Offset="0x140F460", VA="0x140F460")]
	private void InitializePageTabListItem(WrappedScrollRectListItem listItem)
	{
	}

	[Address(RVA="0x140C738", Offset="0x140C738", VA="0x140C738")]
	public void SetData(List<PinPageCollection?> pinPages, List<OwnedSetPinPageCollection> ownedSetPinPageCollections)
	{
	}

	[Address(RVA="0x140E920", Offset="0x140E920", VA="0x140E920")]
	private void SetNextPinPageData()
	{
	}

	[Address(RVA="0x140E54C", Offset="0x140E54C", VA="0x140E54C")]
	private void SetPinPageData(PinPageComponent pinPageComponent, int collectionIndex, int pageIndex)
	{
	}

	[Address(RVA="0x140CBA0", Offset="0x140CBA0", VA="0x140CBA0")]
	private void SetPinPages(int collectionIndex, int pageIndex)
	{
	}

	[Address(RVA="0x140E33C", Offset="0x140E33C", VA="0x140E33C")]
	private void SetPinPages(int collectionIndex, int pageIndex, SinglePageFlipBook.FlipDirection flipMode)
	{
	}

	[Address(RVA="0x140E8D4", Offset="0x140E8D4", VA="0x140E8D4")]
	private void SetPreviousPinPageData()
	{
	}

	[Address(RVA="0x140E96C", Offset="0x140E96C", VA="0x140E96C")]
	private void UpdatePinBacks()
	{
	}

	[Address(RVA="0x140CF84", Offset="0x140CF84", VA="0x140CF84", Slot="11")]
	protected override void ViewAssetLoaded()
	{
	}

	[Address(RVA="0x140DA64", Offset="0x140DA64", VA="0x140DA64", Slot="12")]
	protected override void ViewShuttingDown()
	{
	}

	[Serializable]
	public class SerializedFields : ViewSerializedFields
	{
		[Attribute(Name="HeaderAttribute", RVA="0x106B36C", Offset="0x106B36C")]
		[FieldOffset(Offset="0x28")]
		public WrappedScrollRect PageTabScrollRect;

		[FieldOffset(Offset="0x30")]
		public Gradient PageTabColors;

		[FieldOffset(Offset="0x38")]
		public PinPageComponent PinPage;

		[FieldOffset(Offset="0x40")]
		public SinglePageFlipBook Book;

		[FieldOffset(Offset="0x48")]
		public UnityEngine.GameObject PinBackArchetype;

		[Attribute(Name="HeaderAttribute", RVA="0x106B3A4", Offset="0x106B3A4")]
		[FieldOffset(Offset="0x50")]
		public UnityEngine.GameObject WorldRoot;

		[FieldOffset(Offset="0x58")]
		public UnityEngine.GameObject PinBookModelPrefab;

		[FieldOffset(Offset="0x60")]
		public float IntroAnimationDuration;

		[Address(RVA="0x140FB28", Offset="0x140FB28", VA="0x140FB28")]
		public SerializedFields()
		{
		}
	}
}