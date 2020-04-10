using DG.Tweening;
using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.UI;

public class EmoteInventorySelectedWidget : MonoBehaviour, IDispatchHandler<DEmoteInventoryItemSelectAction>, IDispatchHandler
{
	[FieldOffset(Offset="0x18")]
	private DispatchSystem _dispatchSystem;

	[FieldOffset(Offset="0x20")]
	[SerializeField]
	private RawImage _emoteImage;

	[FieldOffset(Offset="0x28")]
	[SerializeField]
	private Button _findButton;

	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private Button _equipButton;

	[FieldOffset(Offset="0x38")]
	[SerializeField]
	private CanvasGroup _popInTweenTarget;

	[FieldOffset(Offset="0x40")]
	[SerializeField]
	private float _startEquipTweenDuration;

	[FieldOffset(Offset="0x44")]
	[SerializeField]
	private Color _ownedColor;

	[FieldOffset(Offset="0x54")]
	[SerializeField]
	private Color _notOwnedColor;

	[FieldOffset(Offset="0x68")]
	private RawImage _target;

	[FieldOffset(Offset="0x70")]
	private ulong _itemId;

	[FieldOffset(Offset="0x78")]
	private Sequence _popInSequence;

	public ulong SelectedId
	{
		[Address(RVA="0x1209A8C", Offset="0x1209A8C", VA="0x1209A8C")]
		get
		{
			return new ulong();
		}
	}

	[Address(RVA="0x120A4BC", Offset="0x120A4BC", VA="0x120A4BC")]
	public EmoteInventorySelectedWidget()
	{
	}

	[Address(RVA="0x120A434", Offset="0x120A434", VA="0x120A434")]
	private void EquipEmote()
	{
	}

	[Address(RVA="0x120A3AC", Offset="0x120A3AC", VA="0x120A3AC")]
	private void FindEmote()
	{
	}

	[Address(RVA="0x1209FA4", Offset="0x1209FA4", VA="0x1209FA4", Slot="4")]
	public void HandleDispatchAction(DEmoteInventoryItemSelectAction action)
	{
	}

	[Address(RVA="0x1209E6C", Offset="0x1209E6C", VA="0x1209E6C")]
	public void Hide()
	{
	}

	[Address(RVA="0x1209A94", Offset="0x1209A94", VA="0x1209A94")]
	public void Initialize(WidgetDependencyContainer widgetDependencyContainer)
	{
	}

	[Address(RVA="0x120A1E0", Offset="0x120A1E0", VA="0x120A1E0", Slot="5")]
	protected virtual void LateUpdate()
	{
	}

	[Address(RVA="0x1209ED0", Offset="0x1209ED0", VA="0x1209ED0")]
	public void SetPositionForEquip(Transform posTransform)
	{
	}

	[Address(RVA="0x1209DA4", Offset="0x1209DA4", VA="0x1209DA4")]
	public void Shutdown()
	{
	}
}