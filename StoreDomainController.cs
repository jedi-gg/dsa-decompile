using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;
using System.Collections.Generic;

public class StoreDomainController : IDispatchHandler<DPlayerChangeAction>, IDispatchHandler, IDispatchHandler<DAvailableStoreItemIdsUpdatedAction>, IDispatchHandler<DNextFreeStoreItemTimeChangeAction>, IDispatchHandler<DSpecialOfferDynamicMessageAction>, IDispatchHandler<DStoreTabViewedAction>, IDispatchHandler<DStoreSpecialOfferViewedAction>, IDispatchHandler<DHomeStoreResponse>, IDispatchHandler<DStoreResponseAction>
{
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x105CC94", Offset="0x105CC94")]
	[FieldOffset(Offset="0x10")]
	private DateTime <NextFreeStoreItemTime>k__BackingField;

	[Attribute(Name="InjectAttribute", RVA="0x105CCA4", Offset="0x105CCA4")]
	[FieldOffset(Offset="0x18")]
	private DispatchSystem _dispatch;

	[Attribute(Name="InjectAttribute", RVA="0x105CCB4", Offset="0x105CCB4")]
	[FieldOffset(Offset="0x20")]
	private AccountPrefs _accountPrefs;

	[FieldOffset(Offset="0x28")]
	private SortedSet<ulong> _availableStorePackIds;

	[FieldOffset(Offset="0x30")]
	private SortedSet<ulong> _newStorePackIds;

	[FieldOffset(Offset="0x38")]
	private SortedSet<ulong> _specialOffersSilencedThisSession;

	[FieldOffset(Offset="0x40")]
	private StoreItem _highestPrioritySpecialOffer;

	[FieldOffset(Offset="0x48")]
	private List<StoreItem> _specialOffers;

	[FieldOffset(Offset="0x50")]
	private StoreResponse _store;

	public bool HasNewStorePackAvailable
	{
		[Address(RVA="0x122D71C", Offset="0x122D71C", VA="0x122D71C")]
		get
		{
			return new bool();
		}
	}

	public StoreItem HighestPrioritySpecialOffer
	{
		[Address(RVA="0x122D798", Offset="0x122D798", VA="0x122D798")]
		get
		{
			return null;
		}
	}

	public DateTime NextFreeStoreItemTime
	{
		[Address(RVA="0x122D788", Offset="0x122D788", VA="0x122D788")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1070AAC", Offset="0x1070AAC")]
		get
		{
			return new DateTime();
		}
		[Address(RVA="0x122D790", Offset="0x122D790", VA="0x122D790")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1070ABC", Offset="0x1070ABC")]
		private set
		{
		}
	}

	public StoreResponse Store
	{
		[Address(RVA="0x122D7A0", Offset="0x122D7A0", VA="0x122D7A0")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x122F4A0", Offset="0x122F4A0", VA="0x122F4A0")]
	public StoreDomainController()
	{
	}

	[Address(RVA="0x122DB50", Offset="0x122DB50", VA="0x122DB50")]
	public StoreItem GetSpecialOfferForPopup(string placement, uint globalLimit, uint globalLimitCooldown)
	{
		return null;
	}

	[Address(RVA="0x122E4D4", Offset="0x122E4D4", VA="0x122E4D4", Slot="4")]
	public void HandleDispatchAction(DPlayerChangeAction action)
	{
	}

	[Address(RVA="0x122E588", Offset="0x122E588", VA="0x122E588", Slot="5")]
	public void HandleDispatchAction(DAvailableStoreItemIdsUpdatedAction action)
	{
	}

	[Address(RVA="0x122EE60", Offset="0x122EE60", VA="0x122EE60", Slot="6")]
	public void HandleDispatchAction(DNextFreeStoreItemTimeChangeAction action)
	{
	}

	[Address(RVA="0x122EEDC", Offset="0x122EEDC", VA="0x122EEDC", Slot="7")]
	public void HandleDispatchAction(DSpecialOfferDynamicMessageAction action)
	{
	}

	[Address(RVA="0x122F048", Offset="0x122F048", VA="0x122F048", Slot="8")]
	public void HandleDispatchAction(DStoreTabViewedAction action)
	{
	}

	[Address(RVA="0x122F290", Offset="0x122F290", VA="0x122F290", Slot="9")]
	public void HandleDispatchAction(DStoreSpecialOfferViewedAction action)
	{
	}

	[Address(RVA="0x122F388", Offset="0x122F388", VA="0x122F388", Slot="10")]
	public void HandleDispatchAction(DHomeStoreResponse action)
	{
	}

	[Address(RVA="0x122F410", Offset="0x122F410", VA="0x122F410", Slot="11")]
	public void HandleDispatchAction(DStoreResponseAction action)
	{
	}

	[Address(RVA="0x122D7A8", Offset="0x122D7A8", VA="0x122D7A8")]
	public void Initialize()
	{
	}

	[Address(RVA="0x122D820", Offset="0x122D820", VA="0x122D820")]
	public bool IsNewPackAvailableInTab(StoreTab storeTab)
	{
		return new bool();
	}

	[Address(RVA="0x122DB10", Offset="0x122DB10", VA="0x122DB10")]
	public bool IsStoreItemNew(ulong storeItemId)
	{
		return new bool();
	}

	[Address(RVA="0x122E58C", Offset="0x122E58C", VA="0x122E58C")]
	private void SetAvailableStorePackIds(IList<ulong> storePackIds)
	{
	}

	[Address(RVA="0x122E1C0", Offset="0x122E1C0", VA="0x122E1C0")]
	public void SetSpecialOfferPopupSeen(StoreItem storeItem)
	{
	}

	[Address(RVA="0x122D7E0", Offset="0x122D7E0", VA="0x122D7E0")]
	public void Shutdown()
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104CCEC", Offset="0x104CCEC")]
	private sealed class <>c__DisplayClass24_0
	{
		[FieldOffset(Offset="0x10")]
		public IList<ulong> storePackIds;

		[Address(RVA="0x122F498", Offset="0x122F498", VA="0x122F498")]
		public <>c__DisplayClass24_0()
		{
		}

		[Address(RVA="0x122F570", Offset="0x122F570", VA="0x122F570")]
		internal bool <SetAvailableStorePackIds>b__0(ulong u)
		{
			return new bool();
		}
	}
}