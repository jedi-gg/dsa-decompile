using DG.Tweening;
using Gamedata;
using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.UI;

public class ClubItemDonateListItem : WrappedScrollRectListItem
{
	[FieldOffset(Offset="0x28")]
	private DispatchSystem _dispatch;

	[FieldOffset(Offset="0x30")]
	private GamedataDomainController _gamedataDc;

	[FieldOffset(Offset="0x38")]
	private LocalizationManager _lm;

	[FieldOffset(Offset="0x40")]
	private PlayerDomainController _playerDc;

	[FieldOffset(Offset="0x48")]
	private SingleAssetRegistry _playerAvatarAssetRegistry;

	[FieldOffset(Offset="0x50")]
	private SingleAssetRegistry _itemIconAssetRegistry;

	[FieldOffset(Offset="0x58")]
	private ClubItemDonateController.AClubRequestModel _request;

	[FieldOffset(Offset="0x60")]
	private InventoryItem? _item;

	[FieldOffset(Offset="0x78")]
	private UiTimerLabel _itemDonateUiTimerLabel;

	[FieldOffset(Offset="0x80")]
	private UiTimerLabel _itemRequestExpiryUiTimerLabel;

	[FieldOffset(Offset="0x88")]
	private UiTimerLabel _supportRequestExpiryUiTimerLabel;

	[FieldOffset(Offset="0x90")]
	private UiTimerLabel _supportFulfillCooldownUiTimerLabel;

	[FieldOffset(Offset="0x98")]
	private Sequence _boxJiggleSequence;

	[Attribute(Name="HeaderAttribute", RVA="0x10561B8", Offset="0x10561B8")]
	[FieldOffset(Offset="0xA0")]
	[SerializeField]
	private Image _bg;

	[Attribute(Name="HeaderAttribute", RVA="0x1056204", Offset="0x1056204")]
	[FieldOffset(Offset="0xA8")]
	[SerializeField]
	private GameObject _itemRequestRoot;

	[FieldOffset(Offset="0xB0")]
	[SerializeField]
	private LabelButton _donateButton;

	[FieldOffset(Offset="0xB8")]
	[SerializeField]
	private Button _findButton;

	[FieldOffset(Offset="0xC0")]
	[SerializeField]
	private RawImage _inventoryItemImage;

	[FieldOffset(Offset="0xC8")]
	[SerializeField]
	private RawImage _ownedInventoryItemImage;

	[FieldOffset(Offset="0xD0")]
	[SerializeField]
	private UiLabel _ownedInventoryItemCount;

	[FieldOffset(Offset="0xD8")]
	[SerializeField]
	private UiLabel _playerUsernameLabel;

	[FieldOffset(Offset="0xE0")]
	[SerializeField]
	private RawImage _playerAvatar;

	[FieldOffset(Offset="0xE8")]
	[SerializeField]
	private Image _playerAvatarVipBg;

	[FieldOffset(Offset="0xF0")]
	[SerializeField]
	private UiLabel _donateTimerLabel;

	[FieldOffset(Offset="0xF8")]
	[SerializeField]
	private UiLabel _progressBarLabel;

	[FieldOffset(Offset="0x100")]
	[SerializeField]
	private Image _progressBarFill;

	[FieldOffset(Offset="0x108")]
	[SerializeField]
	private RectTransform _boxTransform;

	[FieldOffset(Offset="0x110")]
	[SerializeField]
	private GameObject _donateButtonContainer;

	[FieldOffset(Offset="0x118")]
	[SerializeField]
	private ParticleSystem _donateParticles;

	[FieldOffset(Offset="0x120")]
	[SerializeField]
	private UiLabel _expiryTimerLabel;

	[Attribute(Name="HeaderAttribute", RVA="0x1056340", Offset="0x1056340")]
	[FieldOffset(Offset="0x128")]
	[SerializeField]
	private GameObject _supportRequestRoot;

	[FieldOffset(Offset="0x130")]
	[SerializeField]
	private LabelButton _supportFulfillButton;

	[FieldOffset(Offset="0x138")]
	[SerializeField]
	private UiLabel _supportPlayerUsernameLabel;

	[FieldOffset(Offset="0x140")]
	[SerializeField]
	private RawImage _supportPlayerAvatar;

	[FieldOffset(Offset="0x148")]
	[SerializeField]
	private Image _supportPlayerAvatarVipBg;

	[FieldOffset(Offset="0x150")]
	[SerializeField]
	private UiLabel _supportDescriptionLabel;

	[FieldOffset(Offset="0x158")]
	[SerializeField]
	private UiLabel _supportTimerLabel;

	[FieldOffset(Offset="0x160")]
	[SerializeField]
	private UiLabel _supportFulfillCooldownLabel;

	[Address(RVA="0x1258514", Offset="0x1258514", VA="0x1258514")]
	public ClubItemDonateListItem()
	{
	}

	[Address(RVA="0x12582EC", Offset="0x12582EC", VA="0x12582EC")]
	private void FindClicked()
	{
	}

	[Address(RVA="0x1256728", Offset="0x1256728", VA="0x1256728")]
	public void Initialize(WidgetDependencyContainer dependencies)
	{
	}

	[Address(RVA="0x12580C4", Offset="0x12580C4", VA="0x12580C4")]
	private void ItemDonateClicked()
	{
	}

	[Address(RVA="0x1257B74", Offset="0x1257B74", VA="0x1257B74")]
	public void PlayDonateAnimation()
	{
	}

	[Address(RVA="0x1256F44", Offset="0x1256F44", VA="0x1256F44")]
	private void RefreshItemDonateButtonInteractable()
	{
	}

	[Address(RVA="0x1257D5C", Offset="0x1257D5C", VA="0x1257D5C")]
	private void ResetVisualState()
	{
	}

	[Address(RVA="0x1257CF4", Offset="0x1257CF4", VA="0x1257CF4")]
	public void SetBackgroundColor(UnityEngine.Color color)
	{
	}

	[Address(RVA="0x12572E8", Offset="0x12572E8", VA="0x12572E8")]
	public void SetData(ClubItemDonateController.AClubRequestModel request, DateTime itemDonationResetTimeUtc)
	{
	}

	[Address(RVA="0x12573DC", Offset="0x12573DC", VA="0x12573DC")]
	private void SetItemRequestData(ClubItemDonateController.ClubItemRequestModel itemRequest, DateTime itemDonationResetTimeUtc)
	{
	}

	[Address(RVA="0x1257E84", Offset="0x1257E84", VA="0x1257E84")]
	private void SetPlayerData(UiLabel playerNameLabel, GameObject playerAvatarVipBg, RawImage playerAvatar)
	{
	}

	[Address(RVA="0x1257140", Offset="0x1257140", VA="0x1257140")]
	private void SetSupportFulfillButtonState()
	{
	}

	[Address(RVA="0x12579E4", Offset="0x12579E4", VA="0x12579E4")]
	private void SetSupportRequestData(ClubItemDonateController.ClubSupportRequestModel supportRequest)
	{
	}

	[Address(RVA="0x1256B50", Offset="0x1256B50", VA="0x1256B50", Slot="4")]
	public override void Shutdown()
	{
	}

	[Address(RVA="0x12583B4", Offset="0x12583B4", VA="0x12583B4")]
	private void SupportFulfillClicked()
	{
	}

	[Address(RVA="0x1256C70", Offset="0x1256C70", VA="0x1256C70", Slot="5")]
	public override void TickUpdate()
	{
	}
}