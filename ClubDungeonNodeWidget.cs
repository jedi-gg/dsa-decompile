using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;
using UnityEngine;
using UnityEngine.UI;

public class ClubDungeonNodeWidget : MonoBehaviour, IDispatchHandler<DClubDungeonNodeAction>, IDispatchHandler
{
	[FieldOffset(Offset="0x18")]
	[SerializeField]
	private Button _selectButton;

	[FieldOffset(Offset="0x20")]
	[SerializeField]
	private UiLabel _nameLabel;

	[FieldOffset(Offset="0x28")]
	[SerializeField]
	private GameObject _lockedContainer;

	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private GameObject _completedContainer;

	[FieldOffset(Offset="0x38")]
	[SerializeField]
	private LabelButton _playerCountButton;

	[FieldOffset(Offset="0x40")]
	[SerializeField]
	private GameObject _bonusUnitRestrictionIndicator;

	[FieldOffset(Offset="0x48")]
	[SerializeField]
	private GameObject _currentNodeIndicator;

	[FieldOffset(Offset="0x50")]
	private DispatchSystem _dispatch;

	[FieldOffset(Offset="0x58")]
	private DClubDungeonNodeVisuals _nodeVisuals;

	[FieldOffset(Offset="0x88")]
	private ClubDungeonNode _node;

	[FieldOffset(Offset="0x90")]
	private ulong? _selectedNodeId;

	private bool IsCompleted
	{
		[Address(RVA="0x11B2924", Offset="0x11B2924", VA="0x11B2924")]
		get
		{
			return new bool();
		}
	}

	private bool IsSelected
	{
		[Address(RVA="0x11B27D8", Offset="0x11B27D8", VA="0x11B27D8")]
		get
		{
			return new bool();
		}
	}

	[Address(RVA="0x11B2954", Offset="0x11B2954", VA="0x11B2954")]
	public ClubDungeonNodeWidget()
	{
	}

	[Address(RVA="0x11B2674", Offset="0x11B2674", VA="0x11B2674", Slot="4")]
	public void HandleDispatchAction(DClubDungeonNodeAction action)
	{
	}

	[Address(RVA="0x11B2520", Offset="0x11B2520", VA="0x11B2520")]
	public void Hide()
	{
	}

	[Address(RVA="0x11B204C", Offset="0x11B204C", VA="0x11B204C")]
	public void Initialize(DClubDungeonNodeVisuals nodeVisuals, WidgetDependencyContainer dependencies)
	{
	}

	[Address(RVA="0x11B2880", Offset="0x11B2880", VA="0x11B2880")]
	private void PlayersButtonClicked()
	{
	}

	[Address(RVA="0x11B270C", Offset="0x11B270C", VA="0x11B270C")]
	private void SelectButtonClicked()
	{
	}

	[Address(RVA="0x11B2258", Offset="0x11B2258", VA="0x11B2258")]
	public void Show(ClubDungeonNode node, bool isCompleted, bool isCurrent, int numPlayers)
	{
	}

	[Address(RVA="0x11B21B0", Offset="0x11B21B0", VA="0x11B21B0")]
	public void Shutdown()
	{
	}

	[Address(RVA="0x11B2560", Offset="0x11B2560", VA="0x11B2560")]
	private void UpdateNodeButton()
	{
	}
}