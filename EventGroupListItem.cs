using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EventGroupListItem : WrappedScrollRectListItem
{
	[FieldOffset(Offset="0x28")]
	private DispatchSystem _dispatch;

	[FieldOffset(Offset="0x30")]
	private LocalizationManager _lm;

	[FieldOffset(Offset="0x38")]
	private GamedataDomainController _gamedataDC;

	[FieldOffset(Offset="0x40")]
	private BadgingController _badgingController;

	[FieldOffset(Offset="0x48")]
	private SingleAssetRegistry _imageAssetRegistry;

	[FieldOffset(Offset="0x50")]
	private AssetRegistry _showcaseItemImagesRegistry;

	[FieldOffset(Offset="0x58")]
	private EventGroup _eventGroup;

	[FieldOffset(Offset="0x60")]
	private DateTime _earliestStartTime;

	[FieldOffset(Offset="0x68")]
	private DateTime _latestEndTime;

	[FieldOffset(Offset="0x70")]
	private UiTimerLabel _timerLabel;

	[FieldOffset(Offset="0x78")]
	[SerializeField]
	private UiLabel _nameLabel;

	[FieldOffset(Offset="0x80")]
	[SerializeField]
	private UiLabel _descriptionLabel;

	[FieldOffset(Offset="0x88")]
	[SerializeField]
	private Button _enterButtonLarge;

	[FieldOffset(Offset="0x90")]
	[SerializeField]
	private Button _enterButtonSmall;

	[FieldOffset(Offset="0x98")]
	[SerializeField]
	private Image _backgroundImage;

	[FieldOffset(Offset="0xA0")]
	[SerializeField]
	private RawImage _image;

	[FieldOffset(Offset="0xA8")]
	[SerializeField]
	private List<RawImage> _showcaseItems;

	[FieldOffset(Offset="0xB0")]
	[SerializeField]
	private List<UiLabel> _persistentRewardAvailableLabel;

	[FieldOffset(Offset="0xB8")]
	[SerializeField]
	private UiLabel _timerPrefixLabel;

	[FieldOffset(Offset="0xC0")]
	[SerializeField]
	private UiLabel _timeLabel;

	[FieldOffset(Offset="0xC8")]
	[SerializeField]
	private Badge _badge;

	[FieldOffset(Offset="0xD0")]
	[SerializeField]
	private GameObject _finishedContainer;

	[FieldOffset(Offset="0xD8")]
	[SerializeField]
	private UnityEngine.Color _lockedImageColor;

	[Address(RVA="0x12164FC", Offset="0x12164FC", VA="0x12164FC")]
	public EventGroupListItem()
	{
	}

	[Address(RVA="0x12162B4", Offset="0x12162B4", VA="0x12162B4")]
	private void EnterClicked()
	{
	}

	[Address(RVA="0x121610C", Offset="0x121610C", VA="0x121610C")]
	public RectTransform GetDynamicPointAtObject(string pointAtId)
	{
		return null;
	}

	[Address(RVA="0x1214914", Offset="0x1214914", VA="0x1214914")]
	public void Initialize(WidgetDependencyContainer dependencies)
	{
	}

	[Address(RVA="0x12152F4", Offset="0x12152F4", VA="0x12152F4")]
	public void SetData(EventGroup eventGroup, DateTime earliestStartTime, DateTime latestEndTime, bool isComplete, IList<EventStatus> eventStatuses)
	{
	}

	[Address(RVA="0x121506C", Offset="0x121506C", VA="0x121506C")]
	private void SetTimer(bool disableTimer = false)
	{
	}

	[Address(RVA="0x1216354", Offset="0x1216354", VA="0x1216354")]
	private void ShowcaseItemClicked(int index)
	{
	}

	[Address(RVA="0x1214D50", Offset="0x1214D50", VA="0x1214D50", Slot="4")]
	public override void Shutdown()
	{
	}

	[Address(RVA="0x1214FC4", Offset="0x1214FC4", VA="0x1214FC4", Slot="5")]
	public override void TickUpdate()
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104BE4C", Offset="0x104BE4C")]
	private sealed class <>c__DisplayClass0_0
	{
		[FieldOffset(Offset="0x10")]
		public int closureIndex;

		[FieldOffset(Offset="0x18")]
		public EventGroupListItem <>4__this;

		[Address(RVA="0x1214D48", Offset="0x1214D48", VA="0x1214D48")]
		public <>c__DisplayClass0_0()
		{
		}

		[Address(RVA="0x1216530", Offset="0x1216530", VA="0x1216530")]
		internal void <Initialize>b__0()
		{
		}
	}
}