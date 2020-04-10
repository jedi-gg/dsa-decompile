using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;
using UnityEngine;
using UnityEngine.UI;

public class PlayerActivityBanner : MonoBehaviour
{
	[FieldOffset(Offset="0x18")]
	private DispatchSystem _dispatchSystem;

	[FieldOffset(Offset="0x20")]
	private LocalizationManager _lm;

	[FieldOffset(Offset="0x28")]
	private GamedataDomainController _gamedataDC;

	[FieldOffset(Offset="0x30")]
	private PlayerDomainController _playerDC;

	[FieldOffset(Offset="0x38")]
	private WidgetDependencyContainer _widgetDependencyContainer;

	[FieldOffset(Offset="0x40")]
	private PlayerActivity _activity;

	[FieldOffset(Offset="0x48")]
	private object _rewardsListOwner;

	[FieldOffset(Offset="0x50")]
	[SerializeField]
	private GameObject _incompleteContainer;

	[FieldOffset(Offset="0x58")]
	[SerializeField]
	private GameObject _completedContainer;

	[FieldOffset(Offset="0x60")]
	[SerializeField]
	private Button _claimButton;

	[FieldOffset(Offset="0x68")]
	[SerializeField]
	private UiLabel _titleLabel;

	[FieldOffset(Offset="0x70")]
	[SerializeField]
	private UiLabel _descriptionLabel;

	[FieldOffset(Offset="0x78")]
	[SerializeField]
	private GameObject _progressContainer;

	[FieldOffset(Offset="0x80")]
	[SerializeField]
	private UiLabel _progressLabel;

	[FieldOffset(Offset="0x88")]
	[SerializeField]
	private Badge _badge;

	[FieldOffset(Offset="0x90")]
	[SerializeField]
	private WrappedScrollRect _rewardsScrollRect;

	[FieldOffset(Offset="0x98")]
	[SerializeField]
	private UnitListItem _highlightedUnitListItem;

	[FieldOffset(Offset="0xA0")]
	[SerializeField]
	private SpellListItem _highlightedSpellListItem;

	[Attribute(Name="HeaderAttribute", RVA="0x1057818", Offset="0x1057818")]
	[FieldOffset(Offset="0xA8")]
	[SerializeField]
	private ParticleSystem _claimVfx;

	public RectTransform ButtonRect
	{
		[Address(RVA="0x1413060", Offset="0x1413060", VA="0x1413060")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x1414158", Offset="0x1414158", VA="0x1414158")]
	public PlayerActivityBanner()
	{
	}

	[Address(RVA="0x1413EF8", Offset="0x1413EF8", VA="0x1413EF8")]
	private void BindRewardListItem(WrappedScrollRectListItem listItem, int dataIndex)
	{
	}

	[Address(RVA="0x1413D80", Offset="0x1413D80", VA="0x1413D80")]
	public void CelebrateClaim()
	{
	}

	[Address(RVA="0x14140B4", Offset="0x14140B4", VA="0x14140B4")]
	private void ClaimClicked()
	{
	}

	[Address(RVA="0x14130D8", Offset="0x14130D8", VA="0x14130D8")]
	public void Initialize(WidgetDependencyContainer dependencies, object rewardsListOwner)
	{
	}

	[Address(RVA="0x1413E1C", Offset="0x1413E1C", VA="0x1413E1C")]
	private void InitializeRewardListItem(WrappedScrollRectListItem listItem)
	{
	}

	[Address(RVA="0x14133BC", Offset="0x14133BC", VA="0x14133BC")]
	public void SetData(PlayerActivity activity, int remainingActivities)
	{
	}

	[Address(RVA="0x1413308", Offset="0x1413308", VA="0x1413308")]
	public void Shutdown()
	{
	}
}