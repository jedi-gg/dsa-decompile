using DG.Tweening;
using Gamedata;
using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.UI;

public class PassportSeasonXpContainer : MonoBehaviour, IDispatchHandler<DInventoryDeltaProcessedAction>, IDispatchHandler
{
	[FieldOffset(Offset="0x0")]
	private const float INVALID_OVERFILL_PERCENT = -1f;

	[FieldOffset(Offset="0x18")]
	private DispatchSystem _dispatchSystem;

	[FieldOffset(Offset="0x20")]
	private SingleAssetRegistry _assetRegistry;

	[FieldOffset(Offset="0x28")]
	private PassportSeasonUtility _passportSeasonUtility;

	[FieldOffset(Offset="0x30")]
	private PassportSeason? _season;

	[FieldOffset(Offset="0x48")]
	private ulong _xpItemId;

	[FieldOffset(Offset="0x50")]
	private Tweener _xpFillTween;

	[FieldOffset(Offset="0x58")]
	private Tweener _levelTween;

	[FieldOffset(Offset="0x60")]
	private float _overfillPercent;

	[FieldOffset(Offset="0x68")]
	[SerializeField]
	private UiLabel _seasonNameLabel;

	[FieldOffset(Offset="0x70")]
	[SerializeField]
	private UiLabel _currentLevelLabel;

	[FieldOffset(Offset="0x78")]
	[SerializeField]
	private UiLabel _xpProgressLabel;

	[FieldOffset(Offset="0x80")]
	[SerializeField]
	private Image _seasonLevelProgressFillImage;

	[FieldOffset(Offset="0x88")]
	[SerializeField]
	private RawImage _passportImage;

	[Attribute(Name="HeaderAttribute", RVA="0x105AFBC", Offset="0x105AFBC")]
	[FieldOffset(Offset="0x90")]
	[SerializeField]
	private float _tweenDuration;

	[FieldOffset(Offset="0x94")]
	[SerializeField]
	private Ease _tweenEase;

	[FieldOffset(Offset="0x98")]
	[SerializeField]
	private float _labelPunchScale;

	[FieldOffset(Offset="0x9C")]
	[SerializeField]
	private float _labelPunchDuration;

	[FieldOffset(Offset="0xA0")]
	[SerializeField]
	private float _labelPunchDelay;

	[Attribute(Name="HeaderAttribute", RVA="0x105B048", Offset="0x105B048")]
	[FieldOffset(Offset="0xA8")]
	[SerializeField]
	private ParticleSystem _levelUpVfx;

	[Address(RVA="0x140B0F0", Offset="0x140B0F0", VA="0x140B0F0")]
	public PassportSeasonXpContainer()
	{
	}

	[Address(RVA="0x140ACB4", Offset="0x140ACB4", VA="0x140ACB4")]
	public void CelebrateNewLevel()
	{
	}

	[Address(RVA="0x140B010", Offset="0x140B010", VA="0x140B010")]
	private void CheckTweenXpOverflow()
	{
	}

	[Address(RVA="0x140AD68", Offset="0x140AD68", VA="0x140AD68", Slot="4")]
	public void HandleDispatchAction(DInventoryDeltaProcessedAction action)
	{
	}

	[Address(RVA="0x140A514", Offset="0x140A514", VA="0x140A514")]
	public void Initialize(WidgetDependencyContainer dependencies, PassportSeason? season)
	{
	}

	[Address(RVA="0x140AC18", Offset="0x140AC18", VA="0x140AC18")]
	public void Shutdown()
	{
	}

	[Address(RVA="0x140A8D0", Offset="0x140A8D0", VA="0x140A8D0")]
	private void UpdatePlayerLevel(bool animateXp)
	{
	}
}