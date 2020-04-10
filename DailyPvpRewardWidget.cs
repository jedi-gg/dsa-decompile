using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;
using UnityEngine;
using UnityEngine.UI;

public class DailyPvpRewardWidget : MonoBehaviour
{
	[FieldOffset(Offset="0x18")]
	[SerializeField]
	private UnityEngine.UI.Button _button;

	[FieldOffset(Offset="0x20")]
	[SerializeField]
	private Image _lockImage;

	[FieldOffset(Offset="0x28")]
	[SerializeField]
	private UiLabel _claimLabel;

	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private UiLabel _countdownHeadingLabel;

	[FieldOffset(Offset="0x38")]
	[SerializeField]
	private UiLabel _countdownLabel;

	[FieldOffset(Offset="0x40")]
	[SerializeField]
	private GameObject _stars;

	[FieldOffset(Offset="0x48")]
	[SerializeField]
	private UiLabel _starsLabel;

	[FieldOffset(Offset="0x50")]
	[SerializeField]
	private GameObject _particles;

	[FieldOffset(Offset="0x58")]
	[SerializeField]
	private RawImage _rewardImage;

	[FieldOffset(Offset="0x60")]
	private WidgetDependencyContainer _dependencies;

	[FieldOffset(Offset="0x68")]
	private SingleAssetRegistry _assetRegistry;

	[FieldOffset(Offset="0x70")]
	private UiTimerLabel _countdownTimerLabel;

	public UnityEngine.UI.Button Button
	{
		[Address(RVA="0x12B35C4", Offset="0x12B35C4", VA="0x12B35C4")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x12B36F0", Offset="0x12B36F0", VA="0x12B36F0")]
	public DailyPvpRewardWidget()
	{
	}

	[Address(RVA="0x12B35CC", Offset="0x12B35CC", VA="0x12B35CC")]
	public void Initialize(WidgetDependencyContainer dependencies)
	{
	}

	[Address(RVA="0x12B2F4C", Offset="0x12B2F4C", VA="0x12B2F4C")]
	public void SetData(Player player, PlayerActivity dailyPvpActivity, bool canPurchaseReward)
	{
	}

	[Address(RVA="0x12B363C", Offset="0x12B363C", VA="0x12B363C")]
	public void SetPvpRewardAsset(string pvpRewardAsset)
	{
	}

	[Address(RVA="0x12B3424", Offset="0x12B3424", VA="0x12B3424")]
	public void Show(bool showing)
	{
	}

	[Address(RVA="0x12B360C", Offset="0x12B360C", VA="0x12B360C")]
	public void Shutdown()
	{
	}

	[Address(RVA="0x12B2744", Offset="0x12B2744", VA="0x12B2744")]
	public void TickUpdate()
	{
	}
}