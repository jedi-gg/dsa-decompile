using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.UI;

public class ShipmentButtonWidget : MonoBehaviour
{
	[FieldOffset(Offset="0x18")]
	[SerializeField]
	private Button _button;

	[FieldOffset(Offset="0x20")]
	[SerializeField]
	private Badge _badge;

	[FieldOffset(Offset="0x28")]
	[SerializeField]
	private UiLockableFeature _lock;

	[FieldOffset(Offset="0x30")]
	private BadgingController _badgingController;

	[FieldOffset(Offset="0x38")]
	private DispatchSystem _dispatch;

	[FieldOffset(Offset="0x40")]
	private FeatureLockController _featureLockController;

	[FieldOffset(Offset="0x48")]
	private ulong _shipmentDefId;

	[Address(RVA="0x14BB0EC", Offset="0x14BB0EC", VA="0x14BB0EC")]
	public ShipmentButtonWidget()
	{
	}

	[Address(RVA="0x14BAF70", Offset="0x14BAF70", VA="0x14BAF70")]
	private void Clicked()
	{
	}

	[Address(RVA="0x14BACC8", Offset="0x14BACC8", VA="0x14BACC8")]
	public void Initialize(WidgetDependencyContainer dependencies)
	{
	}

	[Address(RVA="0x14BAF68", Offset="0x14BAF68", VA="0x14BAF68")]
	public void SetShipmentDefId(ulong shipmentDefId)
	{
	}

	[Address(RVA="0x14BAEB4", Offset="0x14BAEB4", VA="0x14BAEB4")]
	public void Shutdown()
	{
	}
}