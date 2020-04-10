using Gamedata;
using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;
using UnityEngine;
using UnityEngine.UI;

public class ClubListItem : WrappedScrollRectListItem
{
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x105646C", Offset="0x105646C")]
	[FieldOffset(Offset="0x28")]
	private UnityEngine.RectTransform <RectTransform>k__BackingField;

	[FieldOffset(Offset="0x30")]
	private DispatchSystem _dispatch;

	[FieldOffset(Offset="0x38")]
	private LocalizationManager _lm;

	[FieldOffset(Offset="0x40")]
	private SingleAssetRegistry _singleAssetRegistry;

	[FieldOffset(Offset="0x48")]
	private Club _club;

	[FieldOffset(Offset="0x50")]
	private uint _maxClubSize;

	[FieldOffset(Offset="0x54")]
	private UnityEngine.Color _defaultRequiredLevelLabelColor;

	[FieldOffset(Offset="0x68")]
	[SerializeField]
	private Button _listItemButton;

	[FieldOffset(Offset="0x70")]
	[SerializeField]
	private UiLabel _clubNameLabel;

	[FieldOffset(Offset="0x78")]
	[SerializeField]
	private UiLabel _clubSizeLabel;

	[FieldOffset(Offset="0x80")]
	[SerializeField]
	private UiLabel _clubInvitePolicyLabel;

	[FieldOffset(Offset="0x88")]
	[SerializeField]
	private UiLabel _rankLabel;

	[FieldOffset(Offset="0x90")]
	[SerializeField]
	private UiLabel _requiredLevelLabel;

	[FieldOffset(Offset="0x98")]
	[SerializeField]
	private UnityEngine.Color _underReqLevelLabelColor;

	[FieldOffset(Offset="0xA8")]
	[SerializeField]
	private Graphic _background;

	[FieldOffset(Offset="0xB0")]
	[SerializeField]
	private UnityEngine.Color _selectedBgColor;

	[FieldOffset(Offset="0xC0")]
	[SerializeField]
	private UnityEngine.Color _unselectedBgColor;

	[FieldOffset(Offset="0xD0")]
	[SerializeField]
	private RawImage _icon;

	[FieldOffset(Offset="0xD8")]
	[SerializeField]
	private GameObject _memberIndicator;

	public UnityEngine.RectTransform RectTransform
	{
		[Address(RVA="0x125B650", Offset="0x125B650", VA="0x125B650")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106EE54", Offset="0x106EE54")]
		get
		{
			return null;
		}
		[Address(RVA="0x125C724", Offset="0x125C724", VA="0x125C724")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106EE64", Offset="0x106EE64")]
		private set
		{
		}
	}

	[Address(RVA="0x125CEA8", Offset="0x125CEA8", VA="0x125CEA8")]
	public ClubListItem()
	{
	}

	[Address(RVA="0x125CE1C", Offset="0x125CE1C", VA="0x125CE1C")]
	private void Clicked()
	{
	}

	[Address(RVA="0x125C72C", Offset="0x125C72C", VA="0x125C72C")]
	public void Initialize(WidgetDependencyContainer dependencies, uint maxClubSize)
	{
	}

	[Address(RVA="0x125CD54", Offset="0x125CD54", VA="0x125CD54")]
	public void Select(bool select)
	{
	}

	[Address(RVA="0x125C928", Offset="0x125C928", VA="0x125C928")]
	public void SetData(Club club, int rank, Gamedata.InventoryItem? clubAvatar, ulong playerLevel)
	{
	}

	[Address(RVA="0x125CDE4", Offset="0x125CDE4", VA="0x125CDE4")]
	public void ShowMemberIndicator(bool showing)
	{
	}

	[Address(RVA="0x125C8AC", Offset="0x125C8AC", VA="0x125C8AC", Slot="4")]
	public override void Shutdown()
	{
	}
}