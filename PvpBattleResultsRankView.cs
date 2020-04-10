using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.UI;

public class PvpBattleResultsRankView : AStandardView
{
	[Attribute(Name="InjectAttribute", RVA="0x105BC10", Offset="0x105BC10")]
	[FieldOffset(Offset="0x68")]
	private GamedataDomainController _gamedataDC;

	[Attribute(Name="InjectAttribute", RVA="0x105BC20", Offset="0x105BC20")]
	[FieldOffset(Offset="0x70")]
	private Procrastinator _procrastinator;

	private PvpBattleResultsRankView.SerializedFields Fields
	{
		[Address(RVA="0x128489C", Offset="0x128489C", VA="0x128489C")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x1284B44", Offset="0x1284B44", VA="0x1284B44")]
	public PvpBattleResultsRankView()
	{
	}

	[Address(RVA="0x1284AC0", Offset="0x1284AC0", VA="0x1284AC0")]
	private void ContinueClicked()
	{
	}

	[Address(RVA="0x1283798", Offset="0x1283798", VA="0x1283798")]
	public void SetPvpScore(ulong oldPvpScore, ulong newPvpScore)
	{
	}

	[Address(RVA="0x128497C", Offset="0x128497C", VA="0x128497C", Slot="11")]
	protected override void ViewAssetLoaded()
	{
	}

	[Address(RVA="0x1284A4C", Offset="0x1284A4C", VA="0x1284A4C", Slot="12")]
	protected override void ViewShuttingDown()
	{
	}

	[Serializable]
	public class SerializedFields : ViewSerializedFields
	{
		[Attribute(Name="HeaderAttribute", RVA="0x106B6D4", Offset="0x106B6D4")]
		[FieldOffset(Offset="0x28")]
		public UiLabel RankUpLabel;

		[FieldOffset(Offset="0x30")]
		public TallyLabelUnsigned ScoreTallyLabel;

		[FieldOffset(Offset="0x38")]
		public float TallyDuration;

		[FieldOffset(Offset="0x3C")]
		public float TallyEndOfAnimClipOffset;

		[FieldOffset(Offset="0x40")]
		public RawImage OldRankIcon;

		[FieldOffset(Offset="0x48")]
		public RawImage CurrentRankIcon;

		[FieldOffset(Offset="0x50")]
		public Button ContinueButton;

		[FieldOffset(Offset="0x58")]
		public Animation Animation;

		[FieldOffset(Offset="0x60")]
		public AnimationClip RankUpAnimClip;

		[FieldOffset(Offset="0x68")]
		public AnimationClip DidNotRankUpAnimClip;

		[FieldOffset(Offset="0x70")]
		public UiLabel NewLeagueLabel;

		[Address(RVA="0x1284B4C", Offset="0x1284B4C", VA="0x1284B4C")]
		public SerializedFields()
		{
		}
	}
}