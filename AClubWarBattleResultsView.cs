using Glunies;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AClubWarBattleResultsView : AStandardView
{
	[Attribute(Name="InjectAttribute", RVA="0x1057258", Offset="0x1057258")]
	[FieldOffset(Offset="0x68")]
	private BadgingController _badgingController;

	private AClubWarBattleResultsView.ClubWarBattleResultsViewSerializedFields Fields
	{
		[Address(RVA="0x10E05F0", Offset="0x10E05F0", VA="0x10E05F0")]
		get
		{
			return null;
		}
	}

	protected override bool WillHandleBackButton
	{
		[Address(RVA="0x10E0B70", Offset="0x10E0B70", VA="0x10E0B70", Slot="19")]
		get
		{
			return new bool();
		}
	}

	[Address(RVA="0x10E0B78", Offset="0x10E0B78", VA="0x10E0B78")]
	public AClubWarBattleResultsView()
	{
	}

	[Address(RVA="0x10E0B80", Offset="0x10E0B80", VA="0x10E0B80")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106F284", Offset="0x106F284")]
	private void <ViewAssetLoaded>b__2_0()
	{
	}

	[Address(RVA="0x10E0C04", Offset="0x10E0C04", VA="0x10E0C04")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106F294", Offset="0x106F294")]
	private void <ViewAssetLoaded>b__2_1()
	{
	}

	[Address(RVA="0x10E0AF8", Offset="0x10E0AF8", VA="0x10E0AF8")]
	private void HideAlert()
	{
	}

	[Address(RVA="0x10E020C", Offset="0x10E020C", VA="0x10E020C")]
	public void SetData(ClubWarBattleResultsGameState.TransitionContext context)
	{
	}

	[Address(RVA="0x10E06D0", Offset="0x10E06D0", VA="0x10E06D0", Slot="21")]
	public virtual void TickUpdate()
	{
	}

	[Address(RVA="0x10E06D4", Offset="0x10E06D4", VA="0x10E06D4", Slot="11")]
	protected override void ViewAssetLoaded()
	{
	}

	[Address(RVA="0x10E0954", Offset="0x10E0954", VA="0x10E0954", Slot="12")]
	protected override void ViewShuttingDown()
	{
	}

	[Serializable]
	public class ClubWarBattleResultsViewSerializedFields : ViewSerializedFields
	{
		[FieldOffset(Offset="0x28")]
		public ClubWarTeamHudWidget AttackerScore;

		[FieldOffset(Offset="0x30")]
		public ClubWarTeamHudWidget DefenderScore;

		[FieldOffset(Offset="0x38")]
		public Animation ShowAnimation;

		[FieldOffset(Offset="0x40")]
		public UiLabel EndReasonLabel;

		[Attribute(Name="HeaderAttribute", RVA="0x106A1DC", Offset="0x106A1DC")]
		[FieldOffset(Offset="0x48")]
		public List<Badge> Badges;

		[FieldOffset(Offset="0x50")]
		public Button ContinueButton;

		[FieldOffset(Offset="0x58")]
		public Button InventoryButton;

		[Attribute(Name="HeaderAttribute", RVA="0x106A214", Offset="0x106A214")]
		[FieldOffset(Offset="0x60")]
		public UnityEngine.GameObject AlertContainer;

		[FieldOffset(Offset="0x68")]
		public UiLabel AlertLabel;

		[FieldOffset(Offset="0x70")]
		public Button AlertDismissButton;

		[Address(RVA="0x10E0C88", Offset="0x10E0C88", VA="0x10E0C88")]
		public ClubWarBattleResultsViewSerializedFields()
		{
		}
	}
}