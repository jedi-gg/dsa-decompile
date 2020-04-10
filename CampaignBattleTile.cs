using DG.Tweening;
using Gamedata;
using Glunies;
using Glunies.Audio;
using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.UI;

public class CampaignBattleTile : MonoBehaviour, IMonoArchetypePooledItem
{
	[Attribute(Name="InjectAttribute", RVA="0x1055084", Offset="0x1055084")]
	[FieldOffset(Offset="0x18")]
	private DispatchSystem _dispatch;

	[Attribute(Name="InjectAttribute", RVA="0x1055094", Offset="0x1055094")]
	[FieldOffset(Offset="0x20")]
	private SingleAssetRegistry _lootIconRegistry;

	[Attribute(Name="InjectAttribute", RVA="0x10550A4", Offset="0x10550A4")]
	[FieldOffset(Offset="0x28")]
	private LocalizationManager _lm;

	[FieldOffset(Offset="0x30")]
	private RectTransform _transform;

	[FieldOffset(Offset="0x38")]
	private DCampaignAddress _campaignAddress;

	[FieldOffset(Offset="0x50")]
	private CampaignBattleTile.DModel _model;

	[FieldOffset(Offset="0x98")]
	private Sequence _oneStarTween;

	[FieldOffset(Offset="0xA0")]
	private Sequence _twoStarTween;

	[FieldOffset(Offset="0xA8")]
	private Sequence _threeStarTween;

	[FieldOffset(Offset="0xB0")]
	[SerializeField]
	private Button _button;

	[FieldOffset(Offset="0xB8")]
	[SerializeField]
	private Image[] _stars;

	[FieldOffset(Offset="0xC0")]
	[SerializeField]
	private UiLabel _titleLabel;

	[FieldOffset(Offset="0xC8")]
	[SerializeField]
	private GameObject _lockRoot;

	[FieldOffset(Offset="0xD0")]
	[SerializeField]
	private GameObject _starsRoot;

	[FieldOffset(Offset="0xD8")]
	[SerializeField]
	private GameObject _lootPreviewContainer;

	[FieldOffset(Offset="0xE0")]
	[SerializeField]
	private RawImage _lootPreviewIcon;

	[FieldOffset(Offset="0xE8")]
	[SerializeField]
	private UiLabel _lootPreviewLabel;

	[FieldOffset(Offset="0xF0")]
	[SerializeField]
	private Button _lootPreviewButton;

	[FieldOffset(Offset="0xF8")]
	[SerializeField]
	private GameObject _limitedAttemptsContainer;

	[FieldOffset(Offset="0x100")]
	[SerializeField]
	private UiLabel _limitedAttemptLabel;

	[FieldOffset(Offset="0x108")]
	[SerializeField]
	private GameObject _bonusUnitRestrictionIndicator;

	[FieldOffset(Offset="0x110")]
	[SerializeField]
	private GameObject _bonusLootContainer;

	[FieldOffset(Offset="0x118")]
	[SerializeField]
	private UiLabel _bonusLootLabel;

	[Attribute(Name="HeaderAttribute", RVA="0x1055194", Offset="0x1055194")]
	[FieldOffset(Offset="0x120")]
	[SerializeField]
	private Image _nodeImage;

	[FieldOffset(Offset="0x128")]
	[SerializeField]
	private Sprite _normalSprite;

	[FieldOffset(Offset="0x130")]
	[SerializeField]
	private Sprite _normalSelectedSprite;

	[FieldOffset(Offset="0x138")]
	[SerializeField]
	private Sprite _bossSprite;

	[FieldOffset(Offset="0x140")]
	[SerializeField]
	private Sprite _bossSelectedSprite;

	[FieldOffset(Offset="0x148")]
	[SerializeField]
	private Sprite _hardSprite;

	[FieldOffset(Offset="0x150")]
	[SerializeField]
	private Sprite _hardSelectedSprite;

	[FieldOffset(Offset="0x158")]
	[SerializeField]
	private Sprite _hardBossSprite;

	[FieldOffset(Offset="0x160")]
	[SerializeField]
	private Sprite _hardBossSelectedSprite;

	[Attribute(Name="HeaderAttribute", RVA="0x1055260", Offset="0x1055260")]
	[FieldOffset(Offset="0x168")]
	[SerializeField]
	private AudioClipGroup _clickAudio;

	[FieldOffset(Offset="0x170")]
	[SerializeField]
	private AudioClipGroup _oneStarAudio;

	[FieldOffset(Offset="0x178")]
	[SerializeField]
	private AudioClipGroup _twoStarAudio;

	[FieldOffset(Offset="0x180")]
	[SerializeField]
	private AudioClipGroup _threeStarAudio;

	public DCampaignAddress CampaignAddress
	{
		[Address(RVA="0x1124F58", Offset="0x1124F58", VA="0x1124F58")]
		get
		{
			return new DCampaignAddress();
		}
	}

	public bool IsBoss
	{
		[Address(RVA="0x1124F6C", Offset="0x1124F6C", VA="0x1124F6C")]
		get
		{
			return new bool();
		}
	}

	public RectTransform Transform
	{
		[Address(RVA="0x1124F50", Offset="0x1124F50", VA="0x1124F50")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x1125FB0", Offset="0x1125FB0", VA="0x1125FB0")]
	public CampaignBattleTile()
	{
	}

	[Address(RVA="0x1125FB8", Offset="0x1125FB8", VA="0x1125FB8")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106E8E8", Offset="0x106E8E8")]
	private void <Initialize>b__6_0()
	{
	}

	[Address(RVA="0x1126014", Offset="0x1126014", VA="0x1126014")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106E8F8", Offset="0x106E8F8")]
	private void <Initialize>b__6_1()
	{
	}

	[Address(RVA="0x112609C", Offset="0x112609C", VA="0x112609C")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106E908", Offset="0x106E908")]
	private void <Initialize>b__6_2()
	{
	}

	[Address(RVA="0x11260B0", Offset="0x11260B0", VA="0x11260B0")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106E918", Offset="0x106E918")]
	private void <Initialize>b__6_3()
	{
	}

	[Address(RVA="0x1126110", Offset="0x1126110", VA="0x1126110")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106E928", Offset="0x106E928")]
	private void <Initialize>b__6_4()
	{
	}

	[Address(RVA="0x1126198", Offset="0x1126198", VA="0x1126198")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106E938", Offset="0x106E938")]
	private void <Initialize>b__6_5()
	{
	}

	[Address(RVA="0x11261AC", Offset="0x11261AC", VA="0x11261AC")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106E948", Offset="0x106E948")]
	private void <Initialize>b__6_6()
	{
	}

	[Address(RVA="0x112620C", Offset="0x112620C", VA="0x112620C")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106E958", Offset="0x106E958")]
	private void <Initialize>b__6_7()
	{
	}

	[Address(RVA="0x1125D80", Offset="0x1125D80", VA="0x1125D80")]
	private void ButtonClicked()
	{
	}

	[Address(RVA="0x1125C0C", Offset="0x1125C0C", VA="0x1125C0C")]
	public RectTransform GetTutorialPointAt(string pointAtId)
	{
		return null;
	}

	[Address(RVA="0x1124F74", Offset="0x1124F74", VA="0x1124F74", Slot="4")]
	public void Initialize()
	{
	}

	[Address(RVA="0x1125E64", Offset="0x1125E64", VA="0x1125E64")]
	private void LootPreviewClicked()
	{
	}

	[Address(RVA="0x1125554", Offset="0x1125554", VA="0x1125554", Slot="6")]
	public void Reinitialize()
	{
	}

	[Address(RVA="0x112563C", Offset="0x112563C", VA="0x112563C")]
	public void SetData(CampaignBattleTile.DModel model, DCampaignAddress campaignAddress)
	{
	}

	[Address(RVA="0x1125B7C", Offset="0x1125B7C", VA="0x1125B7C")]
	private void SetPlatformSprite(bool selected)
	{
	}

	[Address(RVA="0x1125904", Offset="0x1125904", VA="0x1125904")]
	private void SetProgress()
	{
	}

	[Address(RVA="0x11258FC", Offset="0x11258FC", VA="0x11258FC")]
	public void SetSelected(bool selected)
	{
	}

	[Address(RVA="0x1125558", Offset="0x1125558", VA="0x1125558", Slot="5")]
	public void Shutdown()
	{
	}

	[Address(RVA="0x1125AC4", Offset="0x1125AC4", VA="0x1125AC4")]
	public void UpdateBonusLootLabel(bool isActive)
	{
	}

	[Address(RVA="0x112587C", Offset="0x112587C", VA="0x112587C")]
	public void UpdateLimitedAttempts(uint attemptsRemaining)
	{
	}

	[Address(RVA="0x1125BFC", Offset="0x1125BFC", VA="0x1125BFC")]
	public void UpdateProgress(bool locked, int starCount)
	{
	}

	public struct DModel
	{
		[FieldOffset(Offset="0x0")]
		public int StarCount;

		[FieldOffset(Offset="0x4")]
		public bool Locked;

		[FieldOffset(Offset="0x5")]
		public bool NewProgressUpdated;

		[FieldOffset(Offset="0x8")]
		public string BattleName;

		[FieldOffset(Offset="0x10")]
		public string LootIcon;

		[FieldOffset(Offset="0x18")]
		public ulong? LootId;

		[FieldOffset(Offset="0x28")]
		public ulong LootCountMin;

		[FieldOffset(Offset="0x30")]
		public ulong LootCountMax;

		[FieldOffset(Offset="0x38")]
		public bool IsBoss;

		[FieldOffset(Offset="0x39")]
		public bool BonusUnitRestrictionActive;

		[FieldOffset(Offset="0x3C")]
		public uint LimitedAttemptsRemaining;

		[FieldOffset(Offset="0x40")]
		public uint LimitedAttemptsMax;

		[FieldOffset(Offset="0x44")]
		public CampaignType CampaignType;

		[FieldOffset(Offset="0x45")]
		public bool ShowBonusLootLabel;
	}
}