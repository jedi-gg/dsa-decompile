using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.UI;

public class ClubHubRosterListItem : WrappedScrollRectListItem
{
	[FieldOffset(Offset="0x28")]
	private DispatchSystem _dispatch;

	[FieldOffset(Offset="0x30")]
	private LocalizationManager _lm;

	[FieldOffset(Offset="0x38")]
	private SingleAssetRegistry _singleAssetRegistry;

	[FieldOffset(Offset="0x40")]
	private ClubHubController.RosterEntry _player;

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
	[SerializeField]
	private Image _leaderIcon;

	[FieldOffset(Offset="0x78")]
	[SerializeField]
	private Image _bg;

	public Color BackgroundColor
	{
		[Address(RVA="0x11BBF30", Offset="0x11BBF30", VA="0x11BBF30")]
		get
		{
			return new Color();
		}
	}

	public Color LeaderIconColor
	{
		[Address(RVA="0x11BBEF8", Offset="0x11BBEF8", VA="0x11BBEF8")]
		get
		{
			return new Color();
		}
	}

	public Color NameLabelColor
	{
		[Address(RVA="0x11BBE88", Offset="0x11BBE88", VA="0x11BBE88")]
		get
		{
			return new Color();
		}
	}

	public Color RoleLabelColor
	{
		[Address(RVA="0x11BBEC0", Offset="0x11BBEC0", VA="0x11BBEC0")]
		get
		{
			return new Color();
		}
	}

	[Address(RVA="0x11BC918", Offset="0x11BC918", VA="0x11BC918")]
	public ClubHubRosterListItem()
	{
	}

	[Address(RVA="0x11BC854", Offset="0x11BC854", VA="0x11BC854")]
	private void Clicked()
	{
	}

	[Address(RVA="0x11BBF68", Offset="0x11BBF68", VA="0x11BBF68")]
	public void Initialize(WidgetDependencyContainer dependencies)
	{
	}

	[Address(RVA="0x11BC7EC", Offset="0x11BC7EC", VA="0x11BC7EC")]
	public void SetBackgroundColor(Color color)
	{
	}

	[Address(RVA="0x11BC6A4", Offset="0x11BC6A4", VA="0x11BC6A4")]
	public void SetColors(Color color)
	{
	}

	[Address(RVA="0x11BC6D8", Offset="0x11BC6D8", VA="0x11BC6D8")]
	public void SetColors(Color name, Color role, Color icon)
	{
	}

	[Address(RVA="0x11BC0F4", Offset="0x11BC0F4", VA="0x11BC0F4")]
	public void SetData(ClubHubController.RosterEntry player)
	{
	}

	[Address(RVA="0x11BC5A0", Offset="0x11BC5A0", VA="0x11BC5A0")]
	public void ShowCollectionScore()
	{
	}

	[Address(RVA="0x11BC40C", Offset="0x11BC40C", VA="0x11BC40C")]
	public void ShowDonationCount()
	{
	}

	[Address(RVA="0x11BC630", Offset="0x11BC630", VA="0x11BC630")]
	public void ShowJoinDate()
	{
	}

	[Address(RVA="0x11BC49C", Offset="0x11BC49C", VA="0x11BC49C")]
	public void ShowLastLogin()
	{
	}

	[Address(RVA="0x11BC2F0", Offset="0x11BC2F0", VA="0x11BC2F0")]
	public void ShowRole()
	{
	}

	[Address(RVA="0x11BC078", Offset="0x11BC078", VA="0x11BC078", Slot="4")]
	public override void Shutdown()
	{
	}
}