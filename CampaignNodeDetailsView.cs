using DG.Tweening;
using Gamedata;
using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CampaignNodeDetailsView : AStandardView, IDispatchHandler<DUnitListItemAction>, IDispatchHandler, IDispatchHandler<DInventoryItemListItemAction>, IDispatchHandler<DSpellListItemAction>
{
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10554BC", Offset="0x10554BC")]
	[FieldOffset(Offset="0x68")]
	private bool <HighlightBossEnemey>k__BackingField;

	[Attribute(Name="InjectAttribute", RVA="0x10554CC", Offset="0x10554CC")]
	[FieldOffset(Offset="0x70")]
	private GamedataDomainController _gamedataDc;

	[Attribute(Name="InjectAttribute", RVA="0x10554DC", Offset="0x10554DC")]
	[FieldOffset(Offset="0x78")]
	private PlayerDomainController _playerDc;

	[Attribute(Name="InjectAttribute", RVA="0x10554EC", Offset="0x10554EC")]
	[FieldOffset(Offset="0x80")]
	private SingleAssetRegistry _energyCostAssetRegistry;

	[Attribute(Name="InjectAttribute", RVA="0x10554FC", Offset="0x10554FC")]
	[FieldOffset(Offset="0x88")]
	private SingleAssetRegistry _attemptRefreshCostAssetRegistry;

	[Attribute(Name="InjectAttribute", RVA="0x105550C", Offset="0x105550C")]
	[FieldOffset(Offset="0x90")]
	private FeatureLockController _featureLockController;

	[Attribute(Name="InjectAttribute", RVA="0x105551C", Offset="0x105551C")]
	[FieldOffset(Offset="0x98")]
	private CostController _costController;

	[Attribute(Name="InjectAttribute", RVA="0x105552C", Offset="0x105552C")]
	[FieldOffset(Offset="0xA0")]
	private UnitSorter _unitSorter;

	[Attribute(Name="InjectAttribute", RVA="0x105553C", Offset="0x105553C")]
	[FieldOffset(Offset="0xA8")]
	private BattleRestrictionUtility _battleRestrictionUtility;

	[FieldOffset(Offset="0xB0")]
	private Sequence _openingSequence;

	[FieldOffset(Offset="0xB8")]
	private Tweener _allowedUnitsTweener;

	[FieldOffset(Offset="0xC0")]
	private EnemyUnitPreview _bossUnit;

	[FieldOffset(Offset="0xC8")]
	private List<EnemyUnitPreview> _enemies;

	[FieldOffset(Offset="0xD0")]
	private Serverproto.UnitStatOverride _enemyStats;

	[FieldOffset(Offset="0xD8")]
	private List<ItemCountRange> _rewards;

	[FieldOffset(Offset="0xE0")]
	private UiTimerLabel _attemptResetTimer;

	[FieldOffset(Offset="0xE8")]
	private CampaignUtility.DLimitedAttemptInfo _limitedAttemptInfo;

	[FieldOffset(Offset="0x108")]
	private List<Gamedata.Unit?> _allowedUnitDefs;

	[FieldOffset(Offset="0x110")]
	private List<Gamedata.Spell?> _allowedSpellDefs;

	[FieldOffset(Offset="0x118")]
	private BattleRestriction? _battleRestriction;

	[FieldOffset(Offset="0x130")]
	private PersistedPlayerBattleUnits _unitBattleStates;

	[FieldOffset(Offset="0x138")]
	private bool _passesBattleRestrictions;

	[FieldOffset(Offset="0x139")]
	private bool _handleBattleLocked;

	[FieldOffset(Offset="0x13A")]
	private bool _allUnitsAreDead;

	[FieldOffset(Offset="0x13C")]
	private Vector2 _battleRestrictionRootDefaultSize;

	[FieldOffset(Offset="0x144")]
	private float _battleRestrictionsScrollRectHeight;

	private CampaignNodeDetailsView.SerializedFields Fields
	{
		[Address(RVA="0x1130784", Offset="0x1130784", VA="0x1130784")]
		get
		{
			return null;
		}
	}

	public bool HighlightBossEnemey
	{
		[Address(RVA="0x113077C", Offset="0x113077C", VA="0x113077C")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106E978", Offset="0x106E978")]
		get
		{
			return new bool();
		}
		[Address(RVA="0x112D704", Offset="0x112D704", VA="0x112D704")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106E988", Offset="0x106E988")]
		set
		{
		}
	}

	[Address(RVA="0x1135384", Offset="0x1135384", VA="0x1135384")]
	public CampaignNodeDetailsView()
	{
	}

	[Address(RVA="0x113546C", Offset="0x113546C", VA="0x113546C")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106E998", Offset="0x106E998")]
	private int <SetEnemies>b__19_0(EnemyUnitPreview a, EnemyUnitPreview b)
	{
		return new int();
	}

	[Address(RVA="0x1135138", Offset="0x1135138", VA="0x1135138")]
	private void AllowedSpellsTabClicked()
	{
	}

	[Address(RVA="0x1132790", Offset="0x1132790", VA="0x1132790")]
	private void AllowedUnitsTabClicked()
	{
	}

	[Address(RVA="0x1134CA4", Offset="0x1134CA4", VA="0x1134CA4")]
	private void BindAllowedSpellsListItem(WrappedScrollRectListItem listItem, int dataIndex)
	{
	}

	[Address(RVA="0x11347AC", Offset="0x11347AC", VA="0x11347AC")]
	private void BindAllowedUnitsListItem(WrappedScrollRectListItem listItem, int dataIndex)
	{
	}

	[Address(RVA="0x1134300", Offset="0x1134300", VA="0x1134300")]
	private void BindEnemyListItem(WrappedScrollRectListItem listItem, int index)
	{
	}

	[Address(RVA="0x1134504", Offset="0x1134504", VA="0x1134504")]
	private void BindRewardListItem(WrappedScrollRectListItem listItem, int index)
	{
	}

	[Address(RVA="0x11324E4", Offset="0x11324E4", VA="0x11324E4", Slot="15")]
	protected override RectTransform GetDynamicPointAtObject(string pointAtId)
	{
		return null;
	}

	[Address(RVA="0x11310A0", Offset="0x11310A0", VA="0x11310A0", Slot="21")]
	public void HandleDispatchAction(DUnitListItemAction action)
	{
	}

	[Address(RVA="0x113135C", Offset="0x113135C", VA="0x113135C", Slot="22")]
	public void HandleDispatchAction(DInventoryItemListItemAction action)
	{
	}

	[Address(RVA="0x1131520", Offset="0x1131520", VA="0x1131520", Slot="23")]
	public void HandleDispatchAction(DSpellListItemAction action)
	{
	}

	[Address(RVA="0x1133FD8", Offset="0x1133FD8", VA="0x1133FD8")]
	private void HideEntryCost()
	{
	}

	[Address(RVA="0x112D290", Offset="0x112D290", VA="0x112D290")]
	public void Initialize(CampaignNodeDetailsView.WindowSize size = 0)
	{
	}

	[Address(RVA="0x1134BC0", Offset="0x1134BC0", VA="0x1134BC0")]
	private void InitializeAllowedSpellsListItem(WrappedScrollRectListItem listItem)
	{
	}

	[Address(RVA="0x11346C8", Offset="0x11346C8", VA="0x11346C8")]
	private void InitializeAllowedUnitsListItem(WrappedScrollRectListItem listItem)
	{
	}

	[Address(RVA="0x113421C", Offset="0x113421C", VA="0x113421C")]
	private void InitializeEnemyListItem(WrappedScrollRectListItem listItem)
	{
	}

	[Address(RVA="0x1134408", Offset="0x1134408", VA="0x1134408")]
	private void InitializeRewardListItem(WrappedScrollRectListItem listItem)
	{
	}

	[Address(RVA="0x11350B4", Offset="0x11350B4", VA="0x11350B4")]
	private void RefreshAttemptsClicked()
	{
	}

	[Address(RVA="0x1131F28", Offset="0x1131F28", VA="0x1131F28")]
	private void ResetAllowedUnitRoot()
	{
	}

	[Address(RVA="0x1134EA4", Offset="0x1134EA4", VA="0x1134EA4")]
	private void SelectHeroesClicked()
	{
	}

	[Address(RVA="0x1133258", Offset="0x1133258", VA="0x1133258")]
	private void SetBattleRestriction(Serverproto.BattleNode battleNode)
	{
	}

	[Address(RVA="0x1134020", Offset="0x1134020", VA="0x1134020")]
	private void SetBonusRestrictionUnitText(Serverproto.BattleNode battleNode)
	{
	}

	[Address(RVA="0x11328D4", Offset="0x11328D4", VA="0x11328D4")]
	private void SetDetailLabels(string nameKey, string descriptionKey)
	{
	}

	[Address(RVA="0x1132BE0", Offset="0x1132BE0", VA="0x1132BE0")]
	private void SetEnemies(IEnumerable<EnemyUnitPreview> enemyPreviews, Serverproto.UnitStatOverride statOverride)
	{
	}

	[Address(RVA="0x112C48C", Offset="0x112C48C", VA="0x112C48C")]
	public void SetLimitedAttempts(CampaignUtility.DLimitedAttemptInfo limitedAttemptInfo)
	{
	}

	[Address(RVA="0x112C3B0", Offset="0x112C3B0", VA="0x112C3B0")]
	public void SetNodeInfo(Serverproto.BattleNode battleNode, bool showFirstTimeRewards, bool allowBattle = true, CampaignNodeDetailsView.SimStyle simStyle = 0, bool handleBattleLocked = true)
	{
	}

	[Address(RVA="0x1130C9C", Offset="0x1130C9C", VA="0x1130C9C")]
	private void SetNodeInfo(Serverproto.BattleNode battleNode, IEnumerable<EnemyUnitPreview> enemies, bool showFirstTimeRewards, bool allowBattle = true, CampaignNodeDetailsView.SimStyle simStyle = 0, bool handleBattleLocked = true)
	{
	}

	[Address(RVA="0x113100C", Offset="0x113100C", VA="0x113100C")]
	public void SetNodeInfoWithEnemies(Serverproto.BattleNode battleNode, IEnumerable<EnemyUnitPreview> enemies, bool showFirstTimeRewards, bool allowBattle = true, CampaignNodeDetailsView.SimStyle simStyle = 0, bool handleBattleLocked = true, PersistedPlayerBattleUnits unitBattleStates = // 
	// Current member / type: System.Void CampaignNodeDetailsView::SetNodeInfoWithEnemies(Serverproto.BattleNode,System.Collections.Generic.IEnumerable`1<Serverproto.EnemyUnitPreview>,System.Boolean,System.Boolean,CampaignNodeDetailsView/SimStyle,System.Boolean,PersistedPlayerBattleUnits)
	// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
	// 
	// Product version: 2018.1.123.0
	// Exception in: System.Void SetNodeInfoWithEnemies(Serverproto.BattleNode,System.Collections.Generic.IEnumerable<Serverproto.EnemyUnitPreview>,System.Boolean,System.Boolean,CampaignNodeDetailsView/SimStyle,System.Boolean,PersistedPlayerBattleUnits)
	// 
	// Object reference not set to an instance of an object.
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
	//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
	// 
	// mailto: JustDecompilePublicFeedback@telerik.com


	[Address(RVA="0x1132F00", Offset="0x1132F00", VA="0x1132F00")]
	private void SetRewards(IEnumerable<ItemCountRange> items, bool showFirstTimeRewards)
	{
	}

	[Address(RVA="0x1132A10", Offset="0x1132A10", VA="0x1132A10")]
	private void ShowEntryCost(ulong costItemId, ulong costCount)
	{
	}

	[Address(RVA="0x1135030", Offset="0x1135030", VA="0x1135030")]
	private void SimClicked()
	{
	}

	[Address(RVA="0x11279E8", Offset="0x11279E8", VA="0x11279E8")]
	public void TickUpdate()
	{
	}

	[Address(RVA="0x1130864", Offset="0x1130864", VA="0x1130864")]
	private void UpdateLimitedAttemptWidgets()
	{
	}

	[Address(RVA="0x1131644", Offset="0x1131644", VA="0x1131644", Slot="11")]
	protected override void ViewAssetLoaded()
	{
	}

	[Address(RVA="0x11324BC", Offset="0x11324BC", VA="0x11324BC", Slot="14")]
	protected override void ViewHidden()
	{
	}

	[Address(RVA="0x1132478", Offset="0x1132478", VA="0x1132478", Slot="13")]
	protected override void ViewShown()
	{
	}

	[Address(RVA="0x1132108", Offset="0x1132108", VA="0x1132108", Slot="12")]
	protected override void ViewShuttingDown()
	{
	}

	[Address(RVA="0x113527C", Offset="0x113527C", VA="0x113527C")]
	private void VipClicked()
	{
	}

	[Serializable]
	public class SerializedFields : ViewSerializedFields
	{
		[Attribute(Name="HeaderAttribute", RVA="0x1069D44", Offset="0x1069D44")]
		[FieldOffset(Offset="0x28")]
		public CanvasGroup Root;

		[FieldOffset(Offset="0x30")]
		public WrappedScrollRect EnemiesScrollRect;

		[FieldOffset(Offset="0x38")]
		public WrappedScrollRect RewardsScrollRect;

		[FieldOffset(Offset="0x40")]
		public CostButton SimButton;

		[FieldOffset(Offset="0x48")]
		public LabelButton SelectHeroesButton;

		[FieldOffset(Offset="0x50")]
		public UiLabel MissionTitleLabel;

		[FieldOffset(Offset="0x58")]
		public UiLabel MissionDetailsLabel;

		[FieldOffset(Offset="0x60")]
		public UiLockableFeature InstantBattleLock;

		[FieldOffset(Offset="0x68")]
		public UnityEngine.GameObject PossibleEnemiesHeader;

		[FieldOffset(Offset="0x70")]
		public UnityEngine.GameObject EnemiesHeader;

		[FieldOffset(Offset="0x78")]
		public UnityEngine.GameObject LimitedAttemptsRoot;

		[FieldOffset(Offset="0x80")]
		public UiLabel LimitedAttemptLabel;

		[FieldOffset(Offset="0x88")]
		public UnityEngine.GameObject[] LimitedAttemptHearts;

		[FieldOffset(Offset="0x90")]
		public Graphic VipHeart;

		[FieldOffset(Offset="0x98")]
		public Button VipButton;

		[FieldOffset(Offset="0xA0")]
		public UiLabel AttemptResetTimerLabel;

		[FieldOffset(Offset="0xA8")]
		public LabelButton RefreshAttemptsButton;

		[FieldOffset(Offset="0xB0")]
		public UnityEngine.GameObject MainButtonContainer;

		[FieldOffset(Offset="0xB8")]
		public UnityEngine.GameObject RefreshAttemptsButtonContainer;

		[FieldOffset(Offset="0xC0")]
		public UnitListItem BossListItem;

		[FieldOffset(Offset="0xC8")]
		public UiLabel BonusUnitRestrictionLabel;

		[FieldOffset(Offset="0xD0")]
		public ClubSupportRequestButton ClubSupportRequestButton;

		[FieldOffset(Offset="0xD8")]
		public UnityEngine.GameObject VipBonusLockIcon;

		[Attribute(Name="HeaderAttribute", RVA="0x1069D7C", Offset="0x1069D7C")]
		[FieldOffset(Offset="0xE0")]
		public Button AllowedUnitsTabButton;

		[FieldOffset(Offset="0xE8")]
		public Button AllowedSpellsTabButton;

		[FieldOffset(Offset="0xF0")]
		public RectTransform BattleRestrictionRoot;

		[FieldOffset(Offset="0xF8")]
		public WrappedScrollRect AllowedUnitsScrollRect;

		[FieldOffset(Offset="0x100")]
		public WrappedScrollRect AllowedSpellsScrollRect;

		[FieldOffset(Offset="0x108")]
		public BattleRestrictionUtility.Labels RestrictionLabels;

		[FieldOffset(Offset="0x110")]
		public ScrollRect RestrictionsLabelScrollRect;

		[Attribute(Name="HeaderAttribute", RVA="0x1069DB4", Offset="0x1069DB4")]
		[FieldOffset(Offset="0x118")]
		public float SmallWindowSize;

		[Address(RVA="0x11355D8", Offset="0x11355D8", VA="0x11355D8")]
		public SerializedFields()
		{
		}
	}

	public enum SimStyle
	{
		[FieldOffset(Offset="0x0")]
		Hidden,
		[FieldOffset(Offset="0x0")]
		Disabled,
		[FieldOffset(Offset="0x0")]
		Active
	}

	public enum WindowSize
	{
		[FieldOffset(Offset="0x0")]
		Regular,
		[FieldOffset(Offset="0x0")]
		Small
	}
}