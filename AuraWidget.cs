using Gamedata;
using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class AuraWidget : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler
{
	[FieldOffset(Offset="0x18")]
	private DispatchSystem _dispatchSystem;

	[FieldOffset(Offset="0x20")]
	private SingleAssetRegistry _registry;

	[FieldOffset(Offset="0x28")]
	private Aura _aura;

	[FieldOffset(Offset="0x38")]
	private BattleLib_Bootstrap.Types.Unit _unit;

	[FieldOffset(Offset="0x40")]
	private int _abilityId;

	[FieldOffset(Offset="0x48")]
	[SerializeField]
	private RawImage _icon;

	[Address(RVA="0x115E048", Offset="0x115E048", VA="0x115E048")]
	public AuraWidget()
	{
	}

	[Address(RVA="0x115DDD4", Offset="0x115DDD4", VA="0x115DDD4")]
	public void Initialize(Aura aura, WidgetDependencyContainer dependencies, BattleLib_Bootstrap.Types.Unit unit, int abilityId)
	{
	}

	[Address(RVA="0x115DEF8", Offset="0x115DEF8", VA="0x115DEF8", Slot="4")]
	public void OnPointerDown(PointerEventData eventData)
	{
	}

	[Address(RVA="0x115DFE4", Offset="0x115DFE4", VA="0x115DFE4", Slot="5")]
	public void OnPointerUp(PointerEventData eventData)
	{
	}

	[Address(RVA="0x115DC2C", Offset="0x115DC2C", VA="0x115DC2C")]
	public void Shutdown()
	{
	}
}