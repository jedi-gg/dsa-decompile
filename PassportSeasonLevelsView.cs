using Gamedata;
using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.UI;

public class PassportSeasonLevelsView : AStandardView
{
	[FieldOffset(Offset="0x0")]
	public const int PLAYER_LEVEL_DATA_OFFSET = 2;

	[Attribute(Name="InjectAttribute", RVA="0x105AEBC", Offset="0x105AEBC")]
	[FieldOffset(Offset="0x68")]
	private GamedataDomainController _gamedataDC;

	[Attribute(Name="InjectAttribute", RVA="0x105AECC", Offset="0x105AECC")]
	[FieldOffset(Offset="0x70")]
	private PlayerDomainController _playerDC;

	[FieldOffset(Offset="0x78")]
	private PassportSeason? _season;

	[FieldOffset(Offset="0x90")]
	private PassportSeasonLevelTable? _seasonLevelTable;

	[FieldOffset(Offset="0xA8")]
	private bool _hasPremium;

	private PassportSeasonLevelsView.SerializedFields Fields
	{
		[Address(RVA="0x1405100", Offset="0x1405100", VA="0x1405100")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x1405C54", Offset="0x1405C54", VA="0x1405C54")]
	public PassportSeasonLevelsView()
	{
	}

	[Address(RVA="0x14051E0", Offset="0x14051E0", VA="0x14051E0")]
	private bool AnimateXpFill(long passportXp, int passportLevel, float duration, bool preview, bool fillUp)
	{
		return new bool();
	}

	[Address(RVA="0x1405950", Offset="0x1405950", VA="0x1405950")]
	private void BindLevelsListItem(WrappedScrollRectListItem listItem, int dataIndex)
	{
	}

	[Address(RVA="0x1404EDC", Offset="0x1404EDC", VA="0x1404EDC")]
	public float CelebrateLevelUp(long previousPlayerXp, int previousPassportLevel)
	{
		return new float();
	}

	[Address(RVA="0x140562C", Offset="0x140562C", VA="0x140562C", Slot="15")]
	protected override RectTransform GetDynamicPointAtObject(string pointAtId)
	{
		return null;
	}

	[Address(RVA="0x1405874", Offset="0x1405874", VA="0x1405874")]
	private void InitializeLevelsListItem(WrappedScrollRectListItem listItem)
	{
	}

	[Address(RVA="0x14041A4", Offset="0x14041A4", VA="0x14041A4")]
	public void PreviewBuyLevelXpFill(long currentPassportXp, int currentPassportLevel, bool fillUp)
	{
	}

	[Address(RVA="0x1404460", Offset="0x1404460", VA="0x1404460")]
	public void RebindLevelData()
	{
	}

	[Address(RVA="0x14048F4", Offset="0x14048F4", VA="0x14048F4")]
	public void SetPassportSeason(PassportSeason? season, bool hasPremium, int playerPassportLevel)
	{
	}

	[Address(RVA="0x14037A4", Offset="0x14037A4", VA="0x14037A4")]
	public void TickUpdate()
	{
	}

	[Address(RVA="0x14054EC", Offset="0x14054EC", VA="0x14054EC", Slot="11")]
	protected override void ViewAssetLoaded()
	{
	}

	[Address(RVA="0x14055D0", Offset="0x14055D0", VA="0x14055D0", Slot="12")]
	protected override void ViewShuttingDown()
	{
	}

	[Serializable]
	public class SerializedFields : ViewSerializedFields
	{
		[Attribute(Name="HeaderAttribute", RVA="0x106B1AC", Offset="0x106B1AC")]
		[FieldOffset(Offset="0x28")]
		public WrappedScrollRect LevelsScrollRect;

		[FieldOffset(Offset="0x30")]
		public RawImage PremiumPassportIcon;

		[FieldOffset(Offset="0x38")]
		public RawImage XpIcon;

		[FieldOffset(Offset="0x40")]
		public UnityEngine.GameObject PremiumPassportIconLock;

		[FieldOffset(Offset="0x48")]
		public UnityEngine.GameObject PremiumUpgradeLabel;

		[Attribute(Name="TooltipAttribute", RVA="0x106B1E4", Offset="0x106B1E4")]
		[FieldOffset(Offset="0x50")]
		public Graphic FreeIcon;

		[Attribute(Name="HeaderAttribute", RVA="0x106B21C", Offset="0x106B21C")]
		[FieldOffset(Offset="0x58")]
		public float XpFillDurationS;

		[FieldOffset(Offset="0x5C")]
		public float XpFillEndDelayS;

		[FieldOffset(Offset="0x60")]
		public float XpPreviewFillDurationS;

		[Address(RVA="0x1405C5C", Offset="0x1405C5C", VA="0x1405C5C")]
		public SerializedFields()
		{
		}
	}
}