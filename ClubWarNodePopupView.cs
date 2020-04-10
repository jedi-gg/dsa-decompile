using DG.Tweening;
using Gamedata;
using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClubWarNodePopupView : APopupView
{
	[Attribute(Name="InjectAttribute", RVA="0x1057378", Offset="0x1057378")]
	[FieldOffset(Offset="0x68")]
	private ClubWarDomainController _clubWarDc;

	[FieldOffset(Offset="0x70")]
	private string _nodeId;

	[FieldOffset(Offset="0x78")]
	private List<ClubWarDefense> _defenses;

	[FieldOffset(Offset="0x80")]
	private bool _ownedByPlayersClub;

	[FieldOffset(Offset="0x81")]
	private ClubWarTeam _ownerTeam;

	[FieldOffset(Offset="0x88")]
	private UiTimerLabel _rebuildTimer;

	[FieldOffset(Offset="0x90")]
	private ClubWarNodeDetailResponse _nodeDetail;

	[FieldOffset(Offset="0x98")]
	private Sequence _showSequence;

	private ClubWarNodePopupView.SerializedFields Fields
	{
		[Address(RVA="0x14D661C", Offset="0x14D661C", VA="0x14D661C")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x14D78F4", Offset="0x14D78F4", VA="0x14D78F4")]
	public ClubWarNodePopupView()
	{
	}

	[Address(RVA="0x14D6D2C", Offset="0x14D6D2C", VA="0x14D6D2C")]
	private void BindDefenseListItem(WrappedScrollRectListItem listItem, int dataIndex)
	{
	}

	[Address(RVA="0x14D7644", Offset="0x14D7644", VA="0x14D7644")]
	private bool CanEditDefenses()
	{
		return new bool();
	}

	[Address(RVA="0x14D7280", Offset="0x14D7280", VA="0x14D7280")]
	private bool CanRemoveDefenses()
	{
		return new bool();
	}

	[Address(RVA="0x14D7870", Offset="0x14D7870", VA="0x14D7870")]
	private void CaptureButtonClicked()
	{
	}

	[Address(RVA="0x14D7768", Offset="0x14D7768", VA="0x14D7768")]
	private void CycleLeftClicked()
	{
	}

	[Address(RVA="0x14D77EC", Offset="0x14D77EC", VA="0x14D77EC")]
	private void CycleRightClicked()
	{
	}

	[Address(RVA="0x14D6C60", Offset="0x14D6C60", VA="0x14D6C60")]
	private void InitDefenseListItem(WrappedScrollRectListItem listItem)
	{
	}

	[Address(RVA="0x14D35E4", Offset="0x14D35E4", VA="0x14D35E4")]
	public void SetNodeData(ClubWarNode clubWarNode, ClubWarNodeDetailResponse nodeDetail, bool ownedByPlayersClub, bool allowSetTarget)
	{
	}

	[Address(RVA="0x14D76E4", Offset="0x14D76E4", VA="0x14D76E4")]
	private void TargetButtonClicked()
	{
	}

	[Address(RVA="0x14D189C", Offset="0x14D189C", VA="0x14D189C")]
	public void TickUpdate()
	{
	}

	[Address(RVA="0x14D66FC", Offset="0x14D66FC", VA="0x14D66FC", Slot="11")]
	protected override void ViewAssetLoaded()
	{
	}

	[Address(RVA="0x14D6C1C", Offset="0x14D6C1C", VA="0x14D6C1C", Slot="13")]
	protected override void ViewShown()
	{
	}

	[Address(RVA="0x14D6A84", Offset="0x14D6A84", VA="0x14D6A84", Slot="12")]
	protected override void ViewShuttingDown()
	{
	}

	[Serializable]
	public class SerializedFields : PopupViewSerializedFields
	{
		[FieldOffset(Offset="0x30")]
		public WrappedScrollRect DefensesScrollRect;

		[FieldOffset(Offset="0x38")]
		public LabelButton TargetButton;

		[FieldOffset(Offset="0x40")]
		public Button CycleLeftButton;

		[FieldOffset(Offset="0x48")]
		public Button CycleRightButton;

		[FieldOffset(Offset="0x50")]
		public Button CaptureButton;

		[FieldOffset(Offset="0x58")]
		public UnityEngine.GameObject FogContainer;

		[FieldOffset(Offset="0x60")]
		public ClubWarHealthBar NodeHealthBar;

		[FieldOffset(Offset="0x68")]
		public UnityEngine.GameObject RebuildContainer;

		[FieldOffset(Offset="0x70")]
		public UiLabel RebuildTimerLabel;

		[FieldOffset(Offset="0x78")]
		public CanvasGroup WindowRoot;

		[FieldOffset(Offset="0x80")]
		public UiLabel DefenseCountLabel;

		[Address(RVA="0x14D7964", Offset="0x14D7964", VA="0x14D7964")]
		public SerializedFields()
		{
		}
	}
}