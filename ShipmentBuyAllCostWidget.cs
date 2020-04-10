using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.UI;

public class ShipmentBuyAllCostWidget : MonoBehaviour, IMonoArchetypePooledItem
{
	[Attribute(Name="InjectAttribute", RVA="0x105C2E0", Offset="0x105C2E0")]
	[FieldOffset(Offset="0x18")]
	private SingleAssetRegistry _costIconRegistry;

	[FieldOffset(Offset="0x20")]
	[SerializeField]
	private UiLabel _costLabel;

	[FieldOffset(Offset="0x28")]
	[SerializeField]
	private RawImage _costImage;

	[Address(RVA="0x14BB280", Offset="0x14BB280", VA="0x14BB280")]
	public ShipmentBuyAllCostWidget()
	{
	}

	[Address(RVA="0x14BB0F4", Offset="0x14BB0F4", VA="0x14BB0F4", Slot="4")]
	public void Initialize()
	{
	}

	[Address(RVA="0x14BB128", Offset="0x14BB128", VA="0x14BB128", Slot="6")]
	public void Reinitialize()
	{
	}

	[Address(RVA="0x14BB1AC", Offset="0x14BB1AC", VA="0x14BB1AC")]
	public void SetCost(string icon, ulong count)
	{
	}

	[Address(RVA="0x14BB0F8", Offset="0x14BB0F8", VA="0x14BB0F8", Slot="5")]
	public void Shutdown()
	{
	}
}