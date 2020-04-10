using DG.Tweening;
using Gamedata;
using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.UI;

public class EmoteInventoryListItem : MonoBehaviour, IDispatchHandler<DEmoteInventoryPlayAction>, IDispatchHandler, IDispatchHandler<DEmoteInventoryWiggleAction>
{
	[FieldOffset(Offset="0x18")]
	private DispatchSystem _dispatchSystem;

	[FieldOffset(Offset="0x20")]
	private BadgingController _badgingController;

	[FieldOffset(Offset="0x28")]
	[SerializeField]
	private EmoteWidget _emote;

	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private Button _emoteButton;

	[FieldOffset(Offset="0x38")]
	[SerializeField]
	private Badge _badge;

	[FieldOffset(Offset="0x40")]
	[SerializeField]
	private UnityEngine.Color _ownedColor;

	[FieldOffset(Offset="0x50")]
	[SerializeField]
	private UnityEngine.Color _notOwnedColor;

	[FieldOffset(Offset="0x60")]
	private ulong _emoteId;

	[FieldOffset(Offset="0x68")]
	private bool _emoteOwned;

	[FieldOffset(Offset="0x6C")]
	private EmoteInventoryListItem.ButtonMode _buttonMode;

	[FieldOffset(Offset="0x70")]
	private int _dataIndex;

	[FieldOffset(Offset="0x78")]
	private Sequence _wiggleSequence;

	[Address(RVA="0x1209A40", Offset="0x1209A40", VA="0x1209A40")]
	public EmoteInventoryListItem()
	{
	}

	[Address(RVA="0x1209678", Offset="0x1209678", VA="0x1209678")]
	public void EmoteClicked()
	{
	}

	[Address(RVA="0x1209788", Offset="0x1209788", VA="0x1209788", Slot="4")]
	public void HandleDispatchAction(DEmoteInventoryPlayAction action)
	{
	}

	[Address(RVA="0x12099E0", Offset="0x12099E0", VA="0x12099E0", Slot="5")]
	public void HandleDispatchAction(DEmoteInventoryWiggleAction action)
	{
	}

	[Address(RVA="0x12087D0", Offset="0x12087D0", VA="0x12087D0", Slot="6")]
	public virtual void Initialize(WidgetDependencyContainer dependencies)
	{
	}

	[Address(RVA="0x1208E6C", Offset="0x1208E6C", VA="0x1208E6C")]
	public void SetEmote(InventoryItem? emoteItem, bool owned, EmoteInventoryListItem.ButtonMode buttonMode, int index)
	{
	}

	[Address(RVA="0x1208BAC", Offset="0x1208BAC", VA="0x1208BAC")]
	public void Shutdown()
	{
	}

	[Address(RVA="0x1208D14", Offset="0x1208D14", VA="0x1208D14")]
	public void TickUpdate()
	{
	}

	public enum ButtonMode
	{
		[FieldOffset(Offset="0x0")]
		Equipped,
		[FieldOffset(Offset="0x0")]
		Selectable
	}
}