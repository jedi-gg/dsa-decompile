using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;
using UnityEngine;
using UnityEngine.UI;

public class PlayerProfileListItem : WrappedScrollRectListItem
{
	[FieldOffset(Offset="0x28")]
	private LocalizationManager _lm;

	[FieldOffset(Offset="0x30")]
	private GamedataDomainController _gamedataDc;

	[FieldOffset(Offset="0x38")]
	private SingleAssetRegistry _singleAssetRegistry;

	[FieldOffset(Offset="0x40")]
	protected DispatchSystem _dispatch;

	[FieldOffset(Offset="0x48")]
	[SerializeField]
	private Button _listItemButton;

	[FieldOffset(Offset="0x50")]
	[SerializeField]
	private RawImage _avatar;

	[FieldOffset(Offset="0x58")]
	[SerializeField]
	private UiLabel _nameLabel;

	[FieldOffset(Offset="0x60")]
	[SerializeField]
	private UiLabel _roleLabel;

	[FieldOffset(Offset="0x68")]
	[SerializeField]
	private Image _vipBg;

	[FieldOffset(Offset="0x70")]
	private PlayerProfileSimple _player;

	[FieldOffset(Offset="0x78")]
	protected object _ownerIdentifier;

	[Address(RVA="0x1341364", Offset="0x1341364", VA="0x1341364")]
	public PlayerProfileListItem()
	{
	}

	[Address(RVA="0x13412B0", Offset="0x13412B0", VA="0x13412B0")]
	private void Clicked()
	{
	}

	[Address(RVA="0x1340E58", Offset="0x1340E58", VA="0x1340E58", Slot="7")]
	public virtual void Initialize(WidgetDependencyContainer dependencies, object ownerIdentifier)
	{
	}

	[Address(RVA="0x1341030", Offset="0x1341030", VA="0x1341030", Slot="8")]
	public virtual void SetData(PlayerProfileSimple player)
	{
	}

	[Address(RVA="0x1340FA4", Offset="0x1340FA4", VA="0x1340FA4", Slot="4")]
	public override void Shutdown()
	{
	}
}