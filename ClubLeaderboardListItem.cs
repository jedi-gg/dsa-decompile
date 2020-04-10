using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.UI;

public class ClubLeaderboardListItem : WrappedScrollRectListItem
{
	[FieldOffset(Offset="0x28")]
	private SingleAssetRegistry _singleAssetRegistry;

	[FieldOffset(Offset="0x30")]
	private ClubLeaderboardEntry _item;

	[FieldOffset(Offset="0x38")]
	[SerializeField]
	private RawImage _avatar;

	[FieldOffset(Offset="0x40")]
	[SerializeField]
	private UiLabel _nameLabel;

	[FieldOffset(Offset="0x48")]
	[SerializeField]
	private UiLabel _rankLabel;

	[FieldOffset(Offset="0x50")]
	[SerializeField]
	private GameObject _rankDeltaParent;

	[FieldOffset(Offset="0x58")]
	[SerializeField]
	private UiLabel _rankDeltaLabel;

	[FieldOffset(Offset="0x60")]
	[SerializeField]
	private GameObject _rankDeltaPositiveArrow;

	[FieldOffset(Offset="0x68")]
	[SerializeField]
	private GameObject _rankDeltaNegativeArrow;

	[FieldOffset(Offset="0x70")]
	[SerializeField]
	private Image _bg;

	[FieldOffset(Offset="0x78")]
	[SerializeField]
	private Color _evenBgColor;

	[FieldOffset(Offset="0x88")]
	[SerializeField]
	private Color _oddBgColor;

	[FieldOffset(Offset="0x98")]
	[SerializeField]
	private UiLabel _scoreLabel;

	[Address(RVA="0x1259900", Offset="0x1259900", VA="0x1259900")]
	public ClubLeaderboardListItem()
	{
	}

	[Address(RVA="0x1259458", Offset="0x1259458", VA="0x1259458")]
	public void Initialize(WidgetDependencyContainer dependencies)
	{
	}

	[Address(RVA="0x1259898", Offset="0x1259898", VA="0x1259898")]
	public void SetBackgroundColor(Color color)
	{
	}

	[Address(RVA="0x12594D8", Offset="0x12594D8", VA="0x12594D8")]
	public void SetData(ClubLeaderboardEntry item)
	{
	}

	[Address(RVA="0x1259494", Offset="0x1259494", VA="0x1259494", Slot="4")]
	public override void Shutdown()
	{
	}
}