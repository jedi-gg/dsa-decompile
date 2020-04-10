using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.UI;

public class DailyLoginListItem : MonoBehaviour
{
	[FieldOffset(Offset="0x18")]
	private DispatchSystem _dispatch;

	[FieldOffset(Offset="0x20")]
	private SingleAssetRegistry _singleAssetRegistry;

	[FieldOffset(Offset="0x28")]
	private DailyLoginView.DayState _state;

	[FieldOffset(Offset="0x2C")]
	private int _index;

	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private Button _button;

	[FieldOffset(Offset="0x38")]
	[SerializeField]
	private RawImage _image;

	[FieldOffset(Offset="0x40")]
	[SerializeField]
	private UiLabel _countLabel;

	[FieldOffset(Offset="0x48")]
	[SerializeField]
	private GameObject _claimedScrim;

	[FieldOffset(Offset="0x50")]
	[SerializeField]
	private GameObject _claimedBonus;

	[FieldOffset(Offset="0x58")]
	[SerializeField]
	private GameObject _canBuyExpiredIndicator;

	[FieldOffset(Offset="0x60")]
	[SerializeField]
	private Image _background;

	[FieldOffset(Offset="0x68")]
	[SerializeField]
	private Color _currentCalendarDayBackgroundColor;

	[FieldOffset(Offset="0x78")]
	[SerializeField]
	private UiLabel _dayLabel;

	[FieldOffset(Offset="0x80")]
	[SerializeField]
	private Sprite _todaysStartingDayBackgroundSprite;

	public int Index
	{
		[Address(RVA="0x12B03A0", Offset="0x12B03A0", VA="0x12B03A0")]
		get
		{
			return new int();
		}
	}

	public DailyLoginView.DayState State
	{
		[Address(RVA="0x12B03A8", Offset="0x12B03A8", VA="0x12B03A8")]
		get
		{
			return new DailyLoginView.DayState();
		}
	}

	[Address(RVA="0x12B07DC", Offset="0x12B07DC", VA="0x12B07DC")]
	public DailyLoginListItem()
	{
	}

	[Address(RVA="0x12B0758", Offset="0x12B0758", VA="0x12B0758")]
	private void ButtonClicked()
	{
	}

	[Address(RVA="0x12B03B0", Offset="0x12B03B0", VA="0x12B03B0")]
	public void Initialize(WidgetDependencyContainer dependencies, int index, string iconName, ulong itemCount)
	{
	}

	[Address(RVA="0x12B05FC", Offset="0x12B05FC", VA="0x12B05FC")]
	public void SetState(DailyLoginView.DayState state, bool isTodaysStartingDay, bool isCurrentCalendarDay, bool todayBonusGranted)
	{
	}

	[Address(RVA="0x12B058C", Offset="0x12B058C", VA="0x12B058C")]
	public void Shutdown()
	{
	}
}