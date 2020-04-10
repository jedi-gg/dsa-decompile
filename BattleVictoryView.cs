using Gamedata;
using Glunies;
using Glunies.Audio;
using Il2CppDummyDll;
using Serverproto;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BattleVictoryView : AStandardView, IDispatchHandler<DInventoryItemListItemAction>, IDispatchHandler, IDispatchHandler<DInventoryDeltaProcessedAction>
{
	[Attribute(Name="InjectAttribute", RVA="0x1054BD4", Offset="0x1054BD4")]
	[FieldOffset(Offset="0x68")]
	private GamedataDomainController _gamedataDC;

	[Attribute(Name="InjectAttribute", RVA="0x1054BE4", Offset="0x1054BE4")]
	[FieldOffset(Offset="0x70")]
	private ItemFindTracker _itemFindTracker;

	[Attribute(Name="InjectAttribute", RVA="0x1054BF4", Offset="0x1054BF4")]
	[FieldOffset(Offset="0x78")]
	private PlayerDomainController _playerDC;

	[Attribute(Name="InjectAttribute", RVA="0x1054C04", Offset="0x1054C04")]
	[FieldOffset(Offset="0x80")]
	private BadgingController _badgingController;

	[Attribute(Name="InjectAttribute", RVA="0x1054C14", Offset="0x1054C14")]
	[FieldOffset(Offset="0x88")]
	private Procrastinator _procrastinator;

	[Attribute(Name="InjectAttribute", RVA="0x1054C24", Offset="0x1054C24")]
	[FieldOffset(Offset="0x90")]
	private CostController _costController;

	[FieldOffset(Offset="0x98")]
	private IReadOnlyList<Serverproto.InventoryItem> _rewards;

	[FieldOffset(Offset="0xA0")]
	private int _starCount;

	[FieldOffset(Offset="0xA4")]
	private float _fireworkTimer;

	[FieldOffset(Offset="0xA8")]
	private Gamedata.BattleNode? _currentCampaignNode;

	[FieldOffset(Offset="0xC0")]
	private Gamedata.BattleNode? _nextCampaignNode;

	private BattleVictoryView.SerializedFields Fields
	{
		[Address(RVA="0x12A21F0", Offset="0x12A21F0", VA="0x12A21F0")]
		get
		{
			return null;
		}
	}

	protected override bool WillHandleBackButton
	{
		[Address(RVA="0x12A367C", Offset="0x12A367C", VA="0x12A367C", Slot="19")]
		get
		{
			return new bool();
		}
	}

	[Address(RVA="0x12A3684", Offset="0x12A3684", VA="0x12A3684")]
	public BattleVictoryView()
	{
	}

	[Address(RVA="0x12A3694", Offset="0x12A3694", VA="0x12A3694")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106E858", Offset="0x106E858")]
	private void <SetAllowNavigateAway>b__1_0()
	{
	}

	[Address(RVA="0x12A3718", Offset="0x12A3718", VA="0x12A3718")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106E868", Offset="0x106E868")]
	private void <SetAllowNavigateAway>b__1_1()
	{
	}

	[Address(RVA="0x12A379C", Offset="0x12A379C", VA="0x12A379C")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106E878", Offset="0x106E878")]
	private void <ViewAssetLoaded>b__7_0()
	{
	}

	[Address(RVA="0x12A3820", Offset="0x12A3820", VA="0x12A3820")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106E888", Offset="0x106E888")]
	private void <ViewAssetLoaded>b__7_1()
	{
	}

	[Address(RVA="0x12A38A4", Offset="0x12A38A4", VA="0x12A38A4")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106E898", Offset="0x106E898")]
	private void <ViewAssetLoaded>b__7_2()
	{
	}

	[Address(RVA="0x12A32EC", Offset="0x12A32EC", VA="0x12A32EC")]
	private void BindRewardListItem(WrappedScrollRectListItem listItem, int index)
	{
	}

	[Address(RVA="0x12A2EF0", Offset="0x12A2EF0", VA="0x12A2EF0", Slot="15")]
	protected override RectTransform GetDynamicPointAtObject(string pointAtId)
	{
		return null;
	}

	[Address(RVA="0x12A24A4", Offset="0x12A24A4", VA="0x12A24A4", Slot="21")]
	public void HandleDispatchAction(DInventoryItemListItemAction action)
	{
	}

	[Address(RVA="0x12A2658", Offset="0x12A2658", VA="0x12A2658", Slot="22")]
	public void HandleDispatchAction(DInventoryDeltaProcessedAction action)
	{
	}

	[Address(RVA="0x12A31F0", Offset="0x12A31F0", VA="0x12A31F0")]
	private void InitializeRewardListItem(WrappedScrollRectListItem listItem)
	{
	}

	[Address(RVA="0x12A2B34", Offset="0x12A2B34", VA="0x12A2B34")]
	private void PlayStarsAnimation()
	{
	}

	[Address(RVA="0x1292BA0", Offset="0x1292BA0", VA="0x1292BA0")]
	public void SetAllowNavigateAway(bool allowNavigateAway)
	{
	}

	[Address(RVA="0x1292018", Offset="0x1292018", VA="0x1292018")]
	public void SetCampaignLimitedAttemptInfo(uint currentNodeAttemptsLimit, uint nextNodeAttemptsLimit)
	{
	}

	[Address(RVA="0x1292F10", Offset="0x1292F10", VA="0x1292F10")]
	public void SetCampaignProgressionData(Gamedata.BattleNode? currentCampaignNode, Gamedata.BattleNode? nextCampaignNode)
	{
	}

	[Address(RVA="0x1292148", Offset="0x1292148", VA="0x1292148")]
	public void SetData(BattleResultsGameState.TransitionContext context)
	{
	}

	[Address(RVA="0x1290FF4", Offset="0x1290FF4", VA="0x1290FF4")]
	public void TickUpdate()
	{
	}

	[Address(RVA="0x12A22D0", Offset="0x12A22D0", VA="0x12A22D0")]
	private void UpdateBattleEntryCostButtons()
	{
	}

	[Address(RVA="0x12A265C", Offset="0x12A265C", VA="0x12A265C", Slot="11")]
	protected override void ViewAssetLoaded()
	{
	}

	[Address(RVA="0x12A2AF0", Offset="0x12A2AF0", VA="0x12A2AF0", Slot="13")]
	protected override void ViewShown()
	{
	}

	[Address(RVA="0x12A28E8", Offset="0x12A28E8", VA="0x12A28E8", Slot="12")]
	protected override void ViewShuttingDown()
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104B40C", Offset="0x104B40C")]
	private sealed class <>c__DisplayClass14_0
	{
		[FieldOffset(Offset="0x10")]
		public int indexClosure;

		[FieldOffset(Offset="0x18")]
		public BattleVictoryView <>4__this;

		[Address(RVA="0x12A3674", Offset="0x12A3674", VA="0x12A3674")]
		public <>c__DisplayClass14_0()
		{
		}

		[Address(RVA="0x12A3928", Offset="0x12A3928", VA="0x12A3928")]
		internal void <PlayStarsAnimation>b__0()
		{
		}
	}

	[Serializable]
	public class AnimatedStar
	{
		[FieldOffset(Offset="0x10")]
		public AnimationClip AnimationClip;

		[FieldOffset(Offset="0x18")]
		public float[] StarAudioDelay;

		[Address(RVA="0x12A3AAC", Offset="0x12A3AAC", VA="0x12A3AAC")]
		public AnimatedStar()
		{
		}
	}

	[Serializable]
	public class SerializedFields : ViewSerializedFields
	{
		[Attribute(Name="HeaderAttribute", RVA="0x1069C9C", Offset="0x1069C9C")]
		[FieldOffset(Offset="0x28")]
		public List<Badge> Badges;

		[FieldOffset(Offset="0x30")]
		public WrappedScrollRect RewardsScrollRect;

		[FieldOffset(Offset="0x38")]
		public Button ContinueButton;

		[FieldOffset(Offset="0x40")]
		public Button InventoryButton;

		[FieldOffset(Offset="0x48")]
		public Button DailyActivitiesButton;

		[FieldOffset(Offset="0x50")]
		public CostButton NextBattleButton;

		[FieldOffset(Offset="0x58")]
		public UnityEngine.GameObject NextLimitedAttemptsContainer;

		[FieldOffset(Offset="0x60")]
		public UiLabel NextLimitedAttemptsLabel;

		[FieldOffset(Offset="0x68")]
		public CostButton ReplayBattleButton;

		[FieldOffset(Offset="0x70")]
		public UnityEngine.GameObject ReplayLimitedAttemptsContainer;

		[FieldOffset(Offset="0x78")]
		public UiLabel ReplayLimitedAttemptsLabel;

		[FieldOffset(Offset="0x80")]
		public UiLabel EndReasonLabel;

		[Attribute(Name="HeaderAttribute", RVA="0x1069CD4", Offset="0x1069CD4")]
		[FieldOffset(Offset="0x88")]
		public UnityEngine.GameObject StarsContainer;

		[FieldOffset(Offset="0x90")]
		public Animation StarsAnimation;

		[FieldOffset(Offset="0x98")]
		public BattleVictoryView.AnimatedStar[] AnimatedStars;

		[FieldOffset(Offset="0xA0")]
		public AudioClipGroup[] StarAudio;

		[Attribute(Name="HeaderAttribute", RVA="0x1069D0C", Offset="0x1069D0C")]
		[FieldOffset(Offset="0xA8")]
		public AudioClipGroup FireworkAudio;

		[FieldOffset(Offset="0xB0")]
		public float FireworkAudioPlayTimeS;

		[Address(RVA="0x12A3AB4", Offset="0x12A3AB4", VA="0x12A3AB4")]
		public SerializedFields()
		{
		}
	}
}