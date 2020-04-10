using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;
using UnityEngine;

public class EventStatusComponent : MonoBehaviour
{
	[FieldOffset(Offset="0x18")]
	private LocalizationManager _lm;

	[FieldOffset(Offset="0x20")]
	private DispatchSystem _dispatch;

	[FieldOffset(Offset="0x28")]
	private GamedataDomainController _gamedataDC;

	[FieldOffset(Offset="0x30")]
	private SingleAssetRegistry _refreshCostItemImageAssetRegistry;

	[FieldOffset(Offset="0x38")]
	private CostController _costController;

	[FieldOffset(Offset="0x40")]
	private Serverproto.Event _eventData;

	[FieldOffset(Offset="0x48")]
	private EventStatus _status;

	[FieldOffset(Offset="0x50")]
	private UiTimerLabel _battleCooldownTimerLabel;

	[FieldOffset(Offset="0x58")]
	private UiTimerLabel _battleRefreshTimerLabel;

	[FieldOffset(Offset="0x60")]
	private GameObject _battleCooldownLabelParent;

	[FieldOffset(Offset="0x68")]
	private GameObject _battleRefreshLabelParent;

	[FieldOffset(Offset="0x70")]
	[SerializeField]
	private GameObject _battlesRemainingContainer;

	[FieldOffset(Offset="0x78")]
	[SerializeField]
	private UiLabel _battlesRemainingLabel;

	[FieldOffset(Offset="0x80")]
	[SerializeField]
	private UiLabel _battleCooldownLabel;

	[FieldOffset(Offset="0x88")]
	[SerializeField]
	private UiLabel _battleRefreshPrefixLabel;

	[FieldOffset(Offset="0x90")]
	[SerializeField]
	private UiLabel _battleRefreshLabel;

	[FieldOffset(Offset="0x98")]
	[SerializeField]
	private CostButton _battleRefreshButton;

	[Address(RVA="0x12B5070", Offset="0x12B5070", VA="0x12B5070")]
	public EventStatusComponent()
	{
	}

	[Address(RVA="0x12B4F1C", Offset="0x12B4F1C", VA="0x12B4F1C")]
	private void BattleRefreshClicked()
	{
	}

	[Address(RVA="0x12B43D0", Offset="0x12B43D0", VA="0x12B43D0")]
	public void Initialize(WidgetDependencyContainer dependencies)
	{
	}

	[Address(RVA="0x12B4984", Offset="0x12B4984", VA="0x12B4984")]
	public void SetStatus(Serverproto.Event eventData, EventStatus status)
	{
	}

	[Address(RVA="0x12B4760", Offset="0x12B4760", VA="0x12B4760")]
	private void SetupTimerLabels()
	{
	}

	[Address(RVA="0x12B4654", Offset="0x12B4654", VA="0x12B4654")]
	public void Shutdown()
	{
	}

	[Address(RVA="0x12B46BC", Offset="0x12B46BC", VA="0x12B46BC")]
	public void TickUpdate()
	{
	}
}