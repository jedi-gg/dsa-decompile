using Glunies;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TowerScene : AFeatureScene
{
	[FieldOffset(Offset="0x50")]
	private DispatchSystem _dispatch;

	[FieldOffset(Offset="0x58")]
	private bool _playingIntroAnimation;

	[FieldOffset(Offset="0x5C")]
	private float _introAnimationTimer;

	[FieldOffset(Offset="0x60")]
	[SerializeField]
	private ScrollRect _scrollRect;

	[FieldOffset(Offset="0x68")]
	[SerializeField]
	private TowerWorldInputHandler _worldInputHandler;

	[FieldOffset(Offset="0x70")]
	[SerializeField]
	private AnimationClip _cameraDollyAnimation;

	[FieldOffset(Offset="0x78")]
	[SerializeField]
	private List<Transform> _towerNodeMarkers;

	[Attribute(Name="TooltipAttribute", RVA="0x105D874", Offset="0x105D874")]
	[FieldOffset(Offset="0x80")]
	[SerializeField]
	private List<float> _towerNodeMarkerGoToAnimTime;

	[FieldOffset(Offset="0x88")]
	[SerializeField]
	private float _progressionLootGoToAnimTime;

	[FieldOffset(Offset="0x90")]
	[SerializeField]
	private GameObject _victoryBanner;

	[FieldOffset(Offset="0x98")]
	[SerializeField]
	private UiLabel _victoryBannerText;

	[FieldOffset(Offset="0xA0")]
	[SerializeField]
	private Animator _progressionLootAnimator;

	[FieldOffset(Offset="0xA8")]
	[SerializeField]
	private Button _progressionRewardButton;

	[FieldOffset(Offset="0xB0")]
	[SerializeField]
	private float _introAnimationDurationS;

	public UnityEngine.Camera Camera
	{
		[Address(RVA="0x1432958", Offset="0x1432958", VA="0x1432958")]
		get
		{
			return null;
		}
	}

	public RectTransform ProgressionRewardPointAt
	{
		[Address(RVA="0x14328E0", Offset="0x14328E0", VA="0x14328E0")]
		get
		{
			return null;
		}
	}

	public List<Transform> TowerNodeMarkers
	{
		[Address(RVA="0x14330A4", Offset="0x14330A4", VA="0x14330A4")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x14375E8", Offset="0x14375E8", VA="0x14375E8")]
	public TowerScene()
	{
	}

	[Address(RVA="0x1433860", Offset="0x1433860", VA="0x1433860")]
	public void BeginIntroAnimation()
	{
	}

	[Address(RVA="0x1433958", Offset="0x1433958", VA="0x1433958")]
	public void GoToNodeIndex(int nodeIndex)
	{
	}

	[Address(RVA="0x14338F8", Offset="0x14338F8", VA="0x14338F8")]
	public void GoToProgressionLootChest()
	{
	}

	[Address(RVA="0x1437044", Offset="0x1437044", VA="0x1437044", Slot="4")]
	public override void Initialize()
	{
	}

	[Address(RVA="0x14374F8", Offset="0x14374F8", VA="0x14374F8")]
	[Attribute(Name="ContextMenu", RVA="0x1070E14", Offset="0x1070E14")]
	private void PrintAnimationTime()
	{
	}

	[Address(RVA="0x1437494", Offset="0x1437494", VA="0x1437494")]
	private void ProgressionRewardButtonClicked()
	{
	}

	[Address(RVA="0x14373B4", Offset="0x14373B4", VA="0x14373B4")]
	private void ScrollRectValueChanged(Vector2 normalizedPos)
	{
	}

	[Address(RVA="0x14350F8", Offset="0x14350F8", VA="0x14350F8")]
	public void SetDependencies(WidgetDependencyContainer dependencies)
	{
	}

	[Address(RVA="0x14337B4", Offset="0x14337B4", VA="0x14337B4")]
	public void SetProgressionCompleteLootState(TowerScene.ProgressionChestLootState state)
	{
	}

	[Address(RVA="0x143377C", Offset="0x143377C", VA="0x143377C")]
	public void ShowVictoryBanner(bool show)
	{
	}

	[Address(RVA="0x1437260", Offset="0x1437260", VA="0x1437260", Slot="5")]
	public override void Shutdown()
	{
	}

	[Address(RVA="0x1430BC0", Offset="0x1430BC0", VA="0x1430BC0")]
	public void TickUpdate()
	{
	}

	public enum ProgressionChestLootState
	{
		[FieldOffset(Offset="0x0")]
		Closed,
		[FieldOffset(Offset="0x0")]
		Opening,
		[FieldOffset(Offset="0x0")]
		Open
	}
}