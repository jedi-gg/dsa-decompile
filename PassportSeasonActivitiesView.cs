using Gamedata;
using Il2CppDummyDll;
using Serverproto;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PassportSeasonActivitiesView : APlayerActivityView
{
	[Attribute(Name="InjectAttribute", RVA="0x105AC60", Offset="0x105AC60")]
	[FieldOffset(Offset="0x88")]
	private CostController _costController;

	[Attribute(Name="InjectAttribute", RVA="0x105AC70", Offset="0x105AC70")]
	[FieldOffset(Offset="0x90")]
	private PassportSeasonUtility _passportSeasonUtility;

	[FieldOffset(Offset="0x98")]
	private PassportSeason? _season;

	[FieldOffset(Offset="0xB0")]
	private bool _playerIsPremium;

	[FieldOffset(Offset="0xB8")]
	private Dictionary<ulong, int> _activityIdToWeekLookup;

	[FieldOffset(Offset="0xC0")]
	private Gamedata.ItemCount? _nextLevelRewardItemCount;

	[FieldOffset(Offset="0xD8")]
	private ButtonRequireConfirmation _purchaseLevelConfirmation;

	[FieldOffset(Offset="0xE0")]
	private UiTimerLabel _previewActivitiesUiTimerLabel;

	private PassportSeasonActivitiesView.SerializedFields Fields
	{
		[Address(RVA="0x130B700", Offset="0x130B700", VA="0x130B700")]
		get
		{
			return null;
		}
	}

	private float LevelLabelFillPercent
	{
		[Address(RVA="0x130CB00", Offset="0x130CB00", VA="0x130CB00")]
		get
		{
			return new float();
		}
	}

	private int NumXpLevelsToShow
	{
		[Address(RVA="0x130CA8C", Offset="0x130CA8C", VA="0x130CA8C")]
		get
		{
			return new int();
		}
	}

	public float XpAnimationDurationS
	{
		[Address(RVA="0x130AF74", Offset="0x130AF74", VA="0x130AF74")]
		get
		{
			return new float();
		}
	}

	[Address(RVA="0x130CC80", Offset="0x130CC80", VA="0x130CC80")]
	public PassportSeasonActivitiesView()
	{
	}

	[Address(RVA="0x130AD24", Offset="0x130AD24", VA="0x130AD24")]
	public void AnimatePassportXp(int previousPassportLevel, long previousXp, long currentXp)
	{
	}

	[Address(RVA="0x130C790", Offset="0x130C790", VA="0x130C790", Slot="25")]
	protected override void BindActivityListItem(WrappedScrollRectListItem listItem, int index)
	{
	}

	[Address(RVA="0x130C900", Offset="0x130C900", VA="0x130C900")]
	private void BuyLevelClicked()
	{
	}

	[Address(RVA="0x130CA08", Offset="0x130CA08", VA="0x130CA08")]
	private void BuyLevelConfirmationExpired()
	{
	}

	[Address(RVA="0x130C984", Offset="0x130C984", VA="0x130C984")]
	private void BuyLevelConfirmationInitiated()
	{
	}

	[Address(RVA="0x130B7E0", Offset="0x130B7E0", VA="0x130B7E0")]
	private ValueTuple<int, float> GetXpLevelValues(int passportLevel, long currentXp)
	{
		return new ValueTuple<int, float>();
	}

	[Address(RVA="0x130CB20", Offset="0x130CB20", VA="0x130CB20")]
	private void NextLevelRewardClicked()
	{
	}

	[Address(RVA="0x1308E80", Offset="0x1308E80", VA="0x1308E80")]
	public void PreviewAnimatePassportXp(int currentPassportLevel, long currentXp)
	{
	}

	[Address(RVA="0x130BA50", Offset="0x130BA50", VA="0x130BA50")]
	private void RepositionXpAmountLabelUnderIndex(int labelIndex)
	{
	}

	[Address(RVA="0x130C6D4", Offset="0x130C6D4", VA="0x130C6D4", Slot="24")]
	protected override void SelectPlayerActivity(Serverproto.PlayerActivity activity)
	{
	}

	[Address(RVA="0x130A9F4", Offset="0x130A9F4", VA="0x130A9F4")]
	public void SetActivities(IEnumerable<Serverproto.PlayerActivity> activities, ulong selectActivityId)
	{
	}

	[Address(RVA="0x130BC9C", Offset="0x130BC9C", VA="0x130BC9C")]
	private void SetNextLevelReward()
	{
	}

	[Address(RVA="0x130A2EC", Offset="0x130A2EC", VA="0x130A2EC")]
	public void SetPassportLevel(int currentPassportLevel, long currentXp)
	{
	}

	[Address(RVA="0x1309B5C", Offset="0x1309B5C", VA="0x1309B5C")]
	public void SetSeason(PassportSeason? season, bool playerIsPremium, DateTime? nextPreviewCountdownTime)
	{
	}

	[Address(RVA="0x130C5F4", Offset="0x130C5F4", VA="0x130C5F4")]
	private int SortPassportSeasonActivities(Serverproto.PlayerActivity a, Serverproto.PlayerActivity b)
	{
		return new int();
	}

	[Address(RVA="0x1308A30", Offset="0x1308A30", VA="0x1308A30")]
	public void TickUpdate()
	{
	}

	[Address(RVA="0x130BF8C", Offset="0x130BF8C", VA="0x130BF8C", Slot="11")]
	protected override void ViewAssetLoaded()
	{
	}

	[Address(RVA="0x130C450", Offset="0x130C450", VA="0x130C450", Slot="12")]
	protected override void ViewShuttingDown()
	{
	}

	[Serializable]
	public class SerializedFields : APlayerActivityView.PlayerActivitySerializedFields
	{
		[Attribute(Name="HeaderAttribute", RVA="0x106B124", Offset="0x106B124")]
		[FieldOffset(Offset="0x60")]
		public UnityEngine.GameObject BuyLevelContainer;

		[FieldOffset(Offset="0x68")]
		public UnityEngine.GameObject MaxLevelContainer;

		[FieldOffset(Offset="0x70")]
		public CostButton BuyLevelButton;

		[FieldOffset(Offset="0x78")]
		public RawImage PassportXpIcon;

		[FieldOffset(Offset="0x80")]
		public Image XpFill;

		[FieldOffset(Offset="0x88")]
		public Image XpPreviewFill;

		[FieldOffset(Offset="0x90")]
		public UnityEngine.Color FreeProgressColor;

		[FieldOffset(Offset="0xA0")]
		public UnityEngine.Color PremiumProgressColor;

		[Attribute(Name="RangeAttribute", RVA="0x106B15C", Offset="0x106B15C")]
		[FieldOffset(Offset="0xB0")]
		public float PreviewFillColorVMultiplier;

		[FieldOffset(Offset="0xB8")]
		public RectTransform XpAmountContainer;

		[FieldOffset(Offset="0xC0")]
		public TallyLabelSigned XpAmountLabel;

		[FieldOffset(Offset="0xC8")]
		public List<UiLabel> LevelLabels;

		[FieldOffset(Offset="0xD0")]
		public UiLabel PreviewActivitiesLabel;

		[FieldOffset(Offset="0xD8")]
		public UiLabel PreviewActivitiesLabelPrefix;

		[FieldOffset(Offset="0xE0")]
		public RawImage NextLevelRewardImage;

		[FieldOffset(Offset="0xE8")]
		public UiLabel NextLevelRewardAmount;

		[FieldOffset(Offset="0xF0")]
		public Button NextLevelRewardButton;

		[Attribute(Name="HeaderAttribute", RVA="0x106B174", Offset="0x106B174")]
		[FieldOffset(Offset="0xF8")]
		public float XpFillDurationS;

		[FieldOffset(Offset="0xFC")]
		public float XpFillEndDelayS;

		[FieldOffset(Offset="0x100")]
		public float XpPreviewFillDurationS;

		[Address(RVA="0x13FB4B8", Offset="0x13FB4B8", VA="0x13FB4B8")]
		public SerializedFields()
		{
		}
	}
}