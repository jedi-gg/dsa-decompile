using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TowerView : AStandardView, IDispatchHandler<DTowerWorldClickAction>, IDispatchHandler, IDispatchHandler<DTowerSceneIntroAnimationAction>
{
	[Attribute(Name="InjectAttribute", RVA="0x105D920", Offset="0x105D920")]
	[FieldOffset(Offset="0x68")]
	private FeatureLockController _featureLockController;

	[Attribute(Name="InjectAttribute", RVA="0x105D930", Offset="0x105D930")]
	[FieldOffset(Offset="0x70")]
	private PlayerDomainController _playerDC;

	[FieldOffset(Offset="0x78")]
	private Action<int> _navigateToNodeFunction;

	[FieldOffset(Offset="0x80")]
	private Action _navigateToProgressionRewardFunction;

	[FieldOffset(Offset="0x88")]
	private RectTransform _progressionRewardPointAt;

	[FieldOffset(Offset="0x90")]
	private Camera _pointAtWorldCamera;

	[FieldOffset(Offset="0x98")]
	private UiTimerLabel _refreshTimerLabel;

	[FieldOffset(Offset="0xA0")]
	private TowerMap _towerMap;

	[FieldOffset(Offset="0xA8")]
	private TowerStatus _status;

	[FieldOffset(Offset="0xB0")]
	private List<TowerNodeWidget> _towerNodes;

	private TowerView.SerializedFields Fields
	{
		[Address(RVA="0x143AC64", Offset="0x143AC64", VA="0x143AC64")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x143BEF4", Offset="0x143BEF4", VA="0x143BEF4")]
	public TowerView()
	{
	}

	[Address(RVA="0x143BF64", Offset="0x143BF64", VA="0x143BF64")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1070E4C", Offset="0x1070E4C")]
	private void <ViewAssetLoaded>b__7_0(UiLockableFeature l)
	{
	}

	[Address(RVA="0x143BA00", Offset="0x143BA00", VA="0x143BA00")]
	private void AutoWinButtonClicked()
	{
	}

	[Address(RVA="0x143BCE0", Offset="0x143BCE0", VA="0x143BCE0")]
	private void ClaimProgressionLoot()
	{
	}

	[Address(RVA="0x143B608", Offset="0x143B608", VA="0x143B608", Slot="15")]
	protected override RectTransform GetDynamicPointAtObject(string pointAtId)
	{
		return null;
	}

	[Address(RVA="0x143B7E8", Offset="0x143B7E8", VA="0x143B7E8", Slot="16")]
	protected override Camera GetDynamicPointAtObjectWorldCamera(string pointAtId)
	{
		return null;
	}

	[Address(RVA="0x143AD44", Offset="0x143AD44", VA="0x143AD44", Slot="21")]
	public void HandleDispatchAction(DTowerWorldClickAction action)
	{
	}

	[Address(RVA="0x143ADC8", Offset="0x143ADC8", VA="0x143ADC8", Slot="22")]
	public void HandleDispatchAction(DTowerSceneIntroAnimationAction action)
	{
	}

	[Address(RVA="0x143BD64", Offset="0x143BD64", VA="0x143BD64")]
	private void InfoButtonClicked()
	{
	}

	[Address(RVA="0x143BE70", Offset="0x143BE70", VA="0x143BE70")]
	private void NextTowerButtonClicked()
	{
	}

	[Address(RVA="0x143B8D0", Offset="0x143B8D0", VA="0x143B8D0")]
	private void RefreshButtonClicked()
	{
	}

	[Address(RVA="0x143AB08", Offset="0x143AB08", VA="0x143AB08")]
	private void SetRefreshAvailable(bool available)
	{
	}

	[Address(RVA="0x14330AC", Offset="0x14330AC", VA="0x14330AC")]
	public void SetTowerData(TowerMap towerMap, TowerStatus status, List<Transform> nodeMarkers, bool isFinalTowerMap)
	{
	}

	[Address(RVA="0x1432960", Offset="0x1432960", VA="0x1432960")]
	public void SetTutorialPointAtWorldData(Action<int> navigateToNodeFunction, Action navigateToProgressionRewardFunction, RectTransform progressionRewardPointAt, Camera pointAtWorldCamera)
	{
	}

	[Address(RVA="0x143B84C", Offset="0x143B84C", VA="0x143B84C")]
	private void ShipmentButtonClicked()
	{
	}

	[Address(RVA="0x143371C", Offset="0x143371C", VA="0x143371C")]
	public void ShowNextTowerButton(bool show)
	{
	}

	[Address(RVA="0x14336D4", Offset="0x14336D4", VA="0x14336D4")]
	public void ShowProgressionLootClaimable(bool claimable)
	{
	}

	[Address(RVA="0x1430B30", Offset="0x1430B30", VA="0x1430B30")]
	public void TickUpdate()
	{
	}

	[Address(RVA="0x143AE14", Offset="0x143AE14", VA="0x143AE14", Slot="11")]
	protected override void ViewAssetLoaded()
	{
	}

	[Address(RVA="0x143B2C4", Offset="0x143B2C4", VA="0x143B2C4", Slot="12")]
	protected override void ViewShuttingDown()
	{
	}

	[Serializable]
	public class SerializedFields : ViewSerializedFields
	{
		[FieldOffset(Offset="0x28")]
		public List<UiLockableFeature> UiLockableFeatures;

		[FieldOffset(Offset="0x30")]
		public Button ShipmentButton;

		[FieldOffset(Offset="0x38")]
		public TowerNodeWidget NodeWidgetArchetype;

		[FieldOffset(Offset="0x40")]
		public UnityEngine.GameObject CanClaimProgressionLootContainer;

		[FieldOffset(Offset="0x48")]
		public Button ClaimProgressionLootButton;

		[FieldOffset(Offset="0x50")]
		public UnityEngine.GameObject FullscreenClickCatcher;

		[FieldOffset(Offset="0x58")]
		public Button InfoButton;

		[FieldOffset(Offset="0x60")]
		public LabelButton NextTowerButton;

		[Attribute(Name="HeaderAttribute", RVA="0x106BFD4", Offset="0x106BFD4")]
		[FieldOffset(Offset="0x68")]
		public UiLabel RefreshTimerLabel;

		[FieldOffset(Offset="0x70")]
		public Button RefreshButton;

		[FieldOffset(Offset="0x78")]
		public UnityEngine.GameObject RefreshActiveIndicator;

		[Attribute(Name="HeaderAttribute", RVA="0x106C00C", Offset="0x106C00C")]
		[FieldOffset(Offset="0x80")]
		public Button AutoWinButton;

		[Address(RVA="0x143BFE4", Offset="0x143BFE4", VA="0x143BFE4")]
		public SerializedFields()
		{
		}
	}
}