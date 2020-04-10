using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EventListItem : WrappedScrollRectListItem
{
	[FieldOffset(Offset="0x28")]
	private DispatchSystem _dispatch;

	[FieldOffset(Offset="0x30")]
	private LocalizationManager _lm;

	[FieldOffset(Offset="0x38")]
	private GamedataDomainController _gamedataDC;

	[FieldOffset(Offset="0x40")]
	private PlayerDomainController _playerDC;

	[FieldOffset(Offset="0x48")]
	private BadgingController _badgingController;

	[FieldOffset(Offset="0x50")]
	private SingleAssetRegistry _eventImageAssetRegistry;

	[FieldOffset(Offset="0x58")]
	private SingleAssetRegistry _bannerImageAssetRegistry;

	[FieldOffset(Offset="0x60")]
	private AssetRegistry _showcaseItemImagesRegistry;

	[FieldOffset(Offset="0x68")]
	private IEventModel _data;

	[FieldOffset(Offset="0x70")]
	private EventStatus _eventStatus;

	[FieldOffset(Offset="0x78")]
	private UiTimerLabel _remainingTimeTimerLabel;

	[FieldOffset(Offset="0x80")]
	private UiTimerLabel _availableInTimerLabel;

	[FieldOffset(Offset="0x88")]
	private UiTimerLabel _cooldownTimerLabel;

	[FieldOffset(Offset="0x90")]
	private UnityEngine.Color _defaultBookImageColor;

	[FieldOffset(Offset="0xA0")]
	[SerializeField]
	private UiLabel _nameLabel;

	[FieldOffset(Offset="0xA8")]
	[SerializeField]
	private UiLabel _descriptionLabel;

	[FieldOffset(Offset="0xB0")]
	[SerializeField]
	private UiLabel _remainingTimeLabel;

	[FieldOffset(Offset="0xB8")]
	[SerializeField]
	private GameObject _remainingTimeParent;

	[FieldOffset(Offset="0xC0")]
	[SerializeField]
	private UiLabel _availableInLabel;

	[FieldOffset(Offset="0xC8")]
	[SerializeField]
	private Button _enterButton;

	[FieldOffset(Offset="0xD0")]
	[SerializeField]
	private Button _actionButton;

	[FieldOffset(Offset="0xD8")]
	[SerializeField]
	private RawImage _image;

	[FieldOffset(Offset="0xE0")]
	[SerializeField]
	private UiLabel _previewTextLabel;

	[FieldOffset(Offset="0xE8")]
	[SerializeField]
	private GameObject _battlesRemainingContainer;

	[FieldOffset(Offset="0xF0")]
	[SerializeField]
	private UiLabel _battlesRemainingLabel;

	[FieldOffset(Offset="0xF8")]
	[SerializeField]
	private GameObject _cooldownContainer;

	[FieldOffset(Offset="0x100")]
	[SerializeField]
	private UiLabel _cooldownLabel;

	[FieldOffset(Offset="0x108")]
	[SerializeField]
	private Graphic _bookImage;

	[FieldOffset(Offset="0x110")]
	[SerializeField]
	private UnityEngine.Color _lockedBookImageColor;

	[FieldOffset(Offset="0x120")]
	[SerializeField]
	private UnityEngine.Color _lockedImageColor;

	[FieldOffset(Offset="0x130")]
	[SerializeField]
	private GameObject _bannerContainer;

	[FieldOffset(Offset="0x138")]
	[SerializeField]
	private GameObject _finishedContainer;

	[FieldOffset(Offset="0x140")]
	[SerializeField]
	private RawImage _bannerImage;

	[FieldOffset(Offset="0x148")]
	[SerializeField]
	private UiLabel _bannerLabel;

	[FieldOffset(Offset="0x150")]
	[SerializeField]
	private List<RawImage> _showcaseItems;

	[FieldOffset(Offset="0x158")]
	[SerializeField]
	private List<UiLabel> _persistentRewardAvailableLabel;

	[FieldOffset(Offset="0x160")]
	[SerializeField]
	private GameObject _inactiveContainer;

	[FieldOffset(Offset="0x168")]
	[SerializeField]
	private Badge _badge;

	[FieldOffset(Offset="0x170")]
	[SerializeField]
	private UiLabel _starLabel;

	[FieldOffset(Offset="0x178")]
	[SerializeField]
	private GameObject _starLabelParent;

	[Address(RVA="0x1219334", Offset="0x1219334", VA="0x1219334")]
	public EventListItem()
	{
	}

	[Address(RVA="0x1218DB8", Offset="0x1218DB8", VA="0x1218DB8")]
	private void EnterClicked()
	{
	}

	[Address(RVA="0x1218C10", Offset="0x1218C10", VA="0x1218C10")]
	public RectTransform GetDynamicPointAtObject(string pointAtId)
	{
		return null;
	}

	[Address(RVA="0x12165D4", Offset="0x12165D4", VA="0x12165D4")]
	public void Initialize(WidgetDependencyContainer dependencies)
	{
	}

	[Address(RVA="0x1217980", Offset="0x1217980", VA="0x1217980")]
	public void SetData(IEventModel data, EventStatus status, ulong starsEarned, ulong maxStars)
	{
	}

	[Address(RVA="0x1216D8C", Offset="0x1216D8C", VA="0x1216D8C")]
	private void SetEventState()
	{
	}

	[Address(RVA="0x121902C", Offset="0x121902C", VA="0x121902C")]
	private void ShowcaseItemClicked(int index)
	{
	}

	[Address(RVA="0x1216A7C", Offset="0x1216A7C", VA="0x1216A7C", Slot="4")]
	public override void Shutdown()
	{
	}

	[Address(RVA="0x1216C70", Offset="0x1216C70", VA="0x1216C70", Slot="5")]
	public override void TickUpdate()
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104BE5C", Offset="0x104BE5C")]
	private sealed class <>c__DisplayClass0_0
	{
		[FieldOffset(Offset="0x10")]
		public int closureIndex;

		[FieldOffset(Offset="0x18")]
		public EventListItem <>4__this;

		[Address(RVA="0x12B40E4", Offset="0x12B40E4", VA="0x12B40E4")]
		public <>c__DisplayClass0_0()
		{
		}

		[Address(RVA="0x12B40EC", Offset="0x12B40EC", VA="0x12B40EC")]
		internal void <Initialize>b__0()
		{
		}
	}
}