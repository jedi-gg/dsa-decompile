using DG.Tweening;
using Gamedata;
using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;
using UnityEngine;

public class BattleAbilityTooltipView : AStandardView, IDispatchHandler<DBattleUnitsControllerAction>, IDispatchHandler, IDispatchHandler<DShowAuraAction>, IDispatchHandler<DHideAurasAction>
{
	[Attribute(Name="InjectAttribute", RVA="0x1054690", Offset="0x1054690")]
	[FieldOffset(Offset="0x68")]
	private AbilityDescriptionFormatUtil _descFormatUtil;

	[Attribute(Name="InjectAttribute", RVA="0x10546A0", Offset="0x10546A0")]
	[FieldOffset(Offset="0x70")]
	private GamedataDomainController _gamedataDc;

	[FieldOffset(Offset="0x78")]
	private BattleLib_Bootstrap.Types.Player _localPlayer;

	[FieldOffset(Offset="0x80")]
	private BattleAbilityCardData _data;

	[FieldOffset(Offset="0x88")]
	private Sequence _popInSequence;

	private BattleAbilityTooltipView.SerializedFields Fields
	{
		[Address(RVA="0x11674B0", Offset="0x11674B0", VA="0x11674B0")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x116842C", Offset="0x116842C", VA="0x116842C")]
	public BattleAbilityTooltipView()
	{
	}

	[Address(RVA="0x11675EC", Offset="0x11675EC", VA="0x11675EC")]
	private void DismissTooltip()
	{
	}

	[Address(RVA="0x11680F4", Offset="0x11680F4", VA="0x11680F4", Slot="21")]
	public void HandleDispatchAction(DBattleUnitsControllerAction action)
	{
	}

	[Address(RVA="0x1168128", Offset="0x1168128", VA="0x1168128", Slot="22")]
	public void HandleDispatchAction(DShowAuraAction action)
	{
	}

	[Address(RVA="0x1168328", Offset="0x1168328", VA="0x1168328", Slot="23")]
	public void HandleDispatchAction(DHideAurasAction action)
	{
	}

	[Address(RVA="0x1167454", Offset="0x1167454", VA="0x1167454")]
	public void Initialize(BattleLib_Bootstrap.Types.Player localPlayer)
	{
	}

	[Address(RVA="0x11676B0", Offset="0x11676B0", VA="0x11676B0")]
	private void SetAbility(BattleAbilityCardData abilityCardData)
	{
	}

	[Address(RVA="0x1167B78", Offset="0x1167B78", VA="0x1167B78")]
	private void ShowAtLocation(RectTransform rect)
	{
	}

	[Address(RVA="0x11675F8", Offset="0x11675F8", VA="0x11675F8")]
	public void ShowTooltip(BattleAbilityCardWidget abilityCard)
	{
	}

	[Address(RVA="0x116813C", Offset="0x116813C", VA="0x116813C")]
	private void ShowTooltip(Aura aura, RectTransform rect, BattleLib_Bootstrap.Types.Unit unit, int abilityId)
	{
	}

	[Address(RVA="0x1167590", Offset="0x1167590", VA="0x1167590")]
	public void TickUpdate()
	{
	}

	[Address(RVA="0x1168334", Offset="0x1168334", VA="0x1168334", Slot="11")]
	protected override void ViewAssetLoaded()
	{
	}

	[Address(RVA="0x11683CC", Offset="0x11683CC", VA="0x11683CC", Slot="12")]
	protected override void ViewShuttingDown()
	{
	}

	[Serializable]
	public class SerializedFields : ViewSerializedFields
	{
		[FieldOffset(Offset="0x28")]
		public RectTransform SafeArea;

		[Attribute(Name="HeaderAttribute", RVA="0x1069BF4", Offset="0x1069BF4")]
		[FieldOffset(Offset="0x30")]
		public CanvasGroup TweenRoot;

		[FieldOffset(Offset="0x38")]
		public RectTransform AbilityTooltipRoot;

		[FieldOffset(Offset="0x40")]
		public AbilityCardWidget AbilityCard;

		[FieldOffset(Offset="0x48")]
		public UiLabel AbilityNameLabel;

		[FieldOffset(Offset="0x50")]
		public UiLabel AbilityDescriptionLabel;

		[FieldOffset(Offset="0x58")]
		public float OuterPadding;

		[Address(RVA="0x1168434", Offset="0x1168434", VA="0x1168434")]
		public SerializedFields()
		{
		}
	}
}