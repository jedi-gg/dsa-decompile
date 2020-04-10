using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class AEventView : AStandardView, IDispatchHandler<DInventoryItemListItemAction>, IDispatchHandler
{
	[FieldOffset(Offset="0x0")]
	private const float AUTO_SCROLL_DURATION = 0.6f;

	[Attribute(Name="InjectAttribute", RVA="0x1058370", Offset="0x1058370")]
	[FieldOffset(Offset="0x68")]
	private FeatureLockController _featureLockController;

	[Attribute(Name="InjectAttribute", RVA="0x1058380", Offset="0x1058380")]
	[FieldOffset(Offset="0x70")]
	private PlayerDomainController _playerDC;

	[Attribute(Name="InjectAttribute", RVA="0x1058390", Offset="0x1058390")]
	[FieldOffset(Offset="0x78")]
	private GamedataDomainController _gamedataDC;

	[FieldOffset(Offset="0x80")]
	private List<EventGroupModel> _eventGroupData;

	[FieldOffset(Offset="0x88")]
	private ulong _selectedEventGroupId;

	[FieldOffset(Offset="0x90")]
	private Serverproto.Event _selectedEvent;

	[FieldOffset(Offset="0x98")]
	protected bool _alwaysShowEventGroups;

	[FieldOffset(Offset="0x99")]
	protected bool _showClubSupportButton;

	protected AEventView.SerializedFields Fields
	{
		[Address(RVA="0x10E8F28", Offset="0x10E8F28", VA="0x10E8F28")]
		get
		{
			return null;
		}
	}

	public override string PrefabName
	{
		[Address(RVA="0x10E8E80", Offset="0x10E8E80", VA="0x10E8E80", Slot="8")]
		get
		{
			return null;
		}
	}

	public Serverproto.Event SelectedEvent
	{
		[Address(RVA="0x10E4424", Offset="0x10E4424", VA="0x10E4424")]
		get
		{
			return null;
		}
	}

	public ulong SelectedEventGroupId
	{
		[Address(RVA="0x10E47F0", Offset="0x10E47F0", VA="0x10E47F0")]
		get
		{
			return new ulong();
		}
	}

	[Address(RVA="0x10EB628", Offset="0x10EB628", VA="0x10EB628")]
	protected AEventView()
	{
	}

	[Address(RVA="0x10EA7BC", Offset="0x10EA7BC", VA="0x10EA7BC")]
	private void BindEventGroupListItem(WrappedScrollRectListItem listItem, int index)
	{
	}

	[Address(RVA="0x10EAE40", Offset="0x10EAE40", VA="0x10EAE40")]
	private void BindEventListItem(WrappedScrollRectListItem listItem, int index)
	{
	}

	[Address(RVA="0x10EB260", Offset="0x10EB260", VA="0x10EB260", Slot="23")]
	protected virtual void BindEventTierListItem(WrappedScrollRectListItem listItem, int index)
	{
	}

	[Address(RVA="0x10E9BC4", Offset="0x10E9BC4", VA="0x10E9BC4", Slot="15")]
	protected override RectTransform GetDynamicPointAtObject(string pointAtId)
	{
		return null;
	}

	[Address(RVA="0x10E9108", Offset="0x10E9108", VA="0x10E9108")]
	private List<IEventModel> GetSelectedEventGroupEventList()
	{
		return null;
	}

	[Address(RVA="0x10E92C4", Offset="0x10E92C4", VA="0x10E92C4", Slot="21")]
	public void HandleDispatchAction(DInventoryItemListItemAction action)
	{
	}

	[Address(RVA="0x10E8EC8", Offset="0x10E8EC8", VA="0x10E8EC8", Slot="22")]
	public virtual void Initialize(string title)
	{
	}

	[Address(RVA="0x10EA6DC", Offset="0x10EA6DC", VA="0x10EA6DC")]
	private void InitializeEventGroupListItem(WrappedScrollRectListItem listItem)
	{
	}

	[Address(RVA="0x10EAD60", Offset="0x10EAD60", VA="0x10EAD60")]
	private void InitializeEventListItem(WrappedScrollRectListItem listItem)
	{
	}

	[Address(RVA="0x10EB164", Offset="0x10EB164", VA="0x10EB164")]
	private void InitializeEventTierListItem(WrappedScrollRectListItem listItem)
	{
	}

	[Address(RVA="0x10EB414", Offset="0x10EB414", VA="0x10EB414")]
	private void InstantWinAllClicked()
	{
	}

	[Address(RVA="0x10EA464", Offset="0x10EA464", VA="0x10EA464")]
	private bool IsLifetimeEventGroupComplete(EventGroupModel eventGroup)
	{
		return new bool();
	}

	[Address(RVA="0x10E99FC", Offset="0x10E99FC", VA="0x10E99FC", Slot="18")]
	protected override void ProcessBackButton()
	{
	}

	[Address(RVA="0x10E62AC", Offset="0x10E62AC", VA="0x10E62AC")]
	public void ScrollToEvent(ulong eventId, float autoScrollDurationS = 0.6f)
	{
	}

	[Address(RVA="0x10E6968", Offset="0x10E6968", VA="0x10E6968")]
	public void SelectEvent(Serverproto.Event selectedEvent)
	{
	}

	[Address(RVA="0x10E68A8", Offset="0x10E68A8", VA="0x10E68A8")]
	public void SelectEventGroup(ulong eventGroupId)
	{
	}

	[Address(RVA="0x10E5F54", Offset="0x10E5F54", VA="0x10E5F54")]
	public void SetEventData(List<EventGroupModel> eventGroupData)
	{
	}

	[Address(RVA="0x10E736C", Offset="0x10E736C", VA="0x10E736C")]
	public void SetInstantWinAllEnabled(bool enabled)
	{
	}

	[Address(RVA="0x10E9008", Offset="0x10E9008", VA="0x10E9008")]
	private void ShowList(AEventView.EventListType listType)
	{
	}

	[Address(RVA="0x10E1FA8", Offset="0x10E1FA8", VA="0x10E1FA8")]
	public void TickUpdate()
	{
	}

	[Address(RVA="0x10E67E8", Offset="0x10E67E8", VA="0x10E67E8")]
	public void UpdateEventGroupStatus(bool rebindEventGroupList)
	{
	}

	[Address(RVA="0x10E65B8", Offset="0x10E65B8", VA="0x10E65B8")]
	public void UpdateSelectedEventStatus(bool rebindEventTierList)
	{
	}

	[Address(RVA="0x10E9488", Offset="0x10E9488", VA="0x10E9488", Slot="11")]
	protected override void ViewAssetLoaded()
	{
	}

	[Address(RVA="0x10E9844", Offset="0x10E9844", VA="0x10E9844", Slot="12")]
	protected override void ViewShuttingDown()
	{
	}

	private enum EventListType
	{
		[FieldOffset(Offset="0x0")]
		EventGroups,
		[FieldOffset(Offset="0x0")]
		Events,
		[FieldOffset(Offset="0x0")]
		EventTiers
	}

	[Serializable]
	public class SerializedFields : ViewSerializedFields
	{
		[Attribute(Name="HeaderAttribute", RVA="0x106A4BC", Offset="0x106A4BC")]
		[FieldOffset(Offset="0x28")]
		public UiLabel TitleLabel;

		[FieldOffset(Offset="0x30")]
		public UiLabel NoEventsLabel;

		[FieldOffset(Offset="0x38")]
		public UnityEngine.GameObject EventGroupListRoot;

		[FieldOffset(Offset="0x40")]
		public WrappedScrollRect EventGroupList;

		[FieldOffset(Offset="0x48")]
		public UnityEngine.GameObject EventListRoot;

		[FieldOffset(Offset="0x50")]
		public WrappedScrollRect EventList;

		[FieldOffset(Offset="0x58")]
		public UnityEngine.GameObject EventTierListRoot;

		[FieldOffset(Offset="0x60")]
		public WrappedScrollRect EventTierList;

		[FieldOffset(Offset="0x68")]
		public UnityEngine.GameObject TierSpecificContainer;

		[FieldOffset(Offset="0x70")]
		public EventStatusComponent EventStatusComponent;

		[FieldOffset(Offset="0x78")]
		public ShipmentButtonWidget ShipmentWidget;

		[FieldOffset(Offset="0x80")]
		public ClubSupportRequestButton ClubSupportRequestButton;

		[FieldOffset(Offset="0x88")]
		public Button InstantWinAllButton;

		[FieldOffset(Offset="0x90")]
		public UnityEngine.GameObject InstantWinAllRoot;

		[Address(RVA="0x10EB630", Offset="0x10EB630", VA="0x10EB630")]
		public SerializedFields()
		{
		}
	}
}