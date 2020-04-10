using DG.Tweening;
using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.UI;

public class BattleAutoBattleView : AStandardView, IDispatchHandler<DBattleCatchupAction>, IDispatchHandler, IDispatchHandler<DBattleCinematicAction>
{
	[FieldOffset(Offset="0x0")]
	private const float INITIAL_TWEEN_X_OFFSET = -300f;

	[FieldOffset(Offset="0x0")]
	private const float INITIAL_TWEEN_DELAY = 0f;

	[FieldOffset(Offset="0x0")]
	private const float INITIAL_TWEEN_DURATION = 0.33f;

	[FieldOffset(Offset="0x0")]
	private const Ease INITIAL_TWEEN_EASE = Ease.OutSine;

	[Attribute(Name="InjectAttribute", RVA="0x1052DCC", Offset="0x1052DCC")]
	[FieldOffset(Offset="0x68")]
	private AccountPrefs _accountPrefs;

	[FieldOffset(Offset="0x70")]
	private string[] _formattedText;

	[FieldOffset(Offset="0x78")]
	private Color _defaultAutoToggleColor;

	[FieldOffset(Offset="0x88")]
	private Sequence _roundShowSequence;

	[FieldOffset(Offset="0x90")]
	private bool _roundShown;

	[FieldOffset(Offset="0x98")]
	private Sequence _turnLimitShowSequence;

	[FieldOffset(Offset="0xA0")]
	private bool _turnShown;

	[FieldOffset(Offset="0xA8")]
	private Sequence _turnLimitUpdateSequence;

	[FieldOffset(Offset="0xB0")]
	private Sequence _openingTweenSequence;

	private BattleAutoBattleView.SerializedFields Fields
	{
		[Address(RVA="0x1169988", Offset="0x1169988", VA="0x1169988")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x116AE4C", Offset="0x116AE4C", VA="0x116AE4C")]
	public BattleAutoBattleView()
	{
	}

	[Address(RVA="0x116AADC", Offset="0x116AADC", VA="0x116AADC", Slot="15")]
	protected override RectTransform GetDynamicPointAtObject(string pointAtId)
	{
		return null;
	}

	[Address(RVA="0x1169ECC", Offset="0x1169ECC", VA="0x1169ECC", Slot="21")]
	public void HandleDispatchAction(DBattleCatchupAction action)
	{
	}

	[Address(RVA="0x1169F28", Offset="0x1169F28", VA="0x1169F28", Slot="22")]
	public void HandleDispatchAction(DBattleCinematicAction action)
	{
	}

	[Address(RVA="0x1169714", Offset="0x1169714", VA="0x1169714")]
	public void Initialize(BattleConfig battleConfig)
	{
	}

	[Address(RVA="0x1169A68", Offset="0x1169A68", VA="0x1169A68")]
	private void SetAutoBattleOnGraphic(bool on)
	{
	}

	[Address(RVA="0x1169C20", Offset="0x1169C20", VA="0x1169C20")]
	public void SetCurrentRound(int roundNum, int numRounds)
	{
	}

	[Address(RVA="0x1169BD8", Offset="0x1169BD8", VA="0x1169BD8")]
	public void SetDisabledState()
	{
	}

	[Address(RVA="0x1169B2C", Offset="0x1169B2C", VA="0x1169B2C")]
	public void SetSpeed(int autobattleSpeed)
	{
	}

	[Address(RVA="0x1169CE8", Offset="0x1169CE8", VA="0x1169CE8")]
	public void SetTurnsLeft(uint turnsLeft)
	{
	}

	[Address(RVA="0x1169E68", Offset="0x1169E68", VA="0x1169E68")]
	public void ShowBadConnection(bool show)
	{
	}

	[Address(RVA="0x116ADC8", Offset="0x116ADC8", VA="0x116ADC8")]
	private void ShowMenuClicked()
	{
	}

	[Address(RVA="0x116AD08", Offset="0x116AD08", VA="0x116AD08")]
	private void ToggleAutoBattlePlay(bool on)
	{
	}

	[Address(RVA="0x116AC80", Offset="0x116AC80", VA="0x116AC80")]
	private void ToggleAutoBattleSpeed()
	{
	}

	[Address(RVA="0x1169F58", Offset="0x1169F58", VA="0x1169F58", Slot="11")]
	protected override void ViewAssetLoaded()
	{
	}

	[Address(RVA="0x116AA9C", Offset="0x116AA9C", VA="0x116AA9C", Slot="14")]
	protected override void ViewHidden()
	{
	}

	[Address(RVA="0x116AA60", Offset="0x116AA60", VA="0x116AA60", Slot="13")]
	protected override void ViewShown()
	{
	}

	[Address(RVA="0x116A8B8", Offset="0x116A8B8", VA="0x116A8B8", Slot="12")]
	protected override void ViewShuttingDown()
	{
	}

	[Serializable]
	public class SerializedFields : ViewSerializedFields
	{
		[FieldOffset(Offset="0x28")]
		public LabelButton ToggleButton;

		[FieldOffset(Offset="0x30")]
		public CanvasGroup RoundContainer;

		[FieldOffset(Offset="0x38")]
		public UiLabel RoundLabel;

		[FieldOffset(Offset="0x40")]
		public ToggleEx PlayToggle;

		[FieldOffset(Offset="0x48")]
		public Graphic AutoToggleGraphic;

		[FieldOffset(Offset="0x50")]
		public Color AutoToggleOnColor;

		[FieldOffset(Offset="0x60")]
		public Button MenuButton;

		[FieldOffset(Offset="0x68")]
		public BattleBadConnectionWidget BadConnectionWidget;

		[FieldOffset(Offset="0x70")]
		public RectTransform ButtonContainer;

		[Attribute(Name="HeaderAttribute", RVA="0x1069974", Offset="0x1069974")]
		[FieldOffset(Offset="0x78")]
		public CanvasGroup TurnLimitContainer;

		[FieldOffset(Offset="0x80")]
		public UiLabel TurnLimitLabel;

		[FieldOffset(Offset="0x88")]
		public int TurnLimitWarningThreshold;

		[FieldOffset(Offset="0x8C")]
		public Color TurnLimitWarningColor;

		[Address(RVA="0x116AE54", Offset="0x116AE54", VA="0x116AE54")]
		public SerializedFields()
		{
		}
	}
}