using DG.Tweening;
using Glunies.Audio;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

public class KothBattleResultsVictoryView : AKothBattleResultsView
{
	[Attribute(Name="InjectAttribute", RVA="0x105A358", Offset="0x105A358")]
	[FieldOffset(Offset="0x68")]
	private GamedataDomainController _gamedataDc;

	[Attribute(Name="InjectAttribute", RVA="0x105A368", Offset="0x105A368")]
	[FieldOffset(Offset="0x70")]
	private PlayerDomainController _playerDc;

	[FieldOffset(Offset="0x78")]
	private List<PlayerListItemData> _leaderboardEntries;

	[FieldOffset(Offset="0x80")]
	private PlayerListItem _localPlayerRow;

	[FieldOffset(Offset="0x88")]
	private int _localPlayerFromIndex;

	[FieldOffset(Offset="0x8C")]
	private int _localPlayerToIndex;

	[FieldOffset(Offset="0x90")]
	private int _rankDelta;

	[FieldOffset(Offset="0x94")]
	private float _timer;

	[FieldOffset(Offset="0x98")]
	private float _autoScrollDuration;

	[FieldOffset(Offset="0xA0")]
	private Sequence _rowUpSequence;

	[FieldOffset(Offset="0xA8")]
	private Sequence _rowDownSequence;

	[FieldOffset(Offset="0xB0")]
	private ulong _minDisplayedRank;

	[FieldOffset(Offset="0xB8")]
	private ulong _maxDisplayedRank;

	[FieldOffset(Offset="0xC0")]
	private float _fireworkTimer;

	private KothBattleResultsVictoryView.SerializedFields Fields
	{
		[Address(RVA="0x11CBD28", Offset="0x11CBD28", VA="0x11CBD28")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x11CCF1C", Offset="0x11CCF1C", VA="0x11CCF1C")]
	public KothBattleResultsVictoryView()
	{
	}

	[Address(RVA="0x11CCF9C", Offset="0x11CCF9C", VA="0x11CCF9C")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10700E4", Offset="0x10700E4")]
	private void <ViewAssetLoaded>b__2_0()
	{
	}

	[Address(RVA="0x11CCFDC", Offset="0x11CCFDC", VA="0x11CCFDC")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10700F4", Offset="0x10700F4")]
	private void <ViewAssetLoaded>b__2_1()
	{
	}

	[Address(RVA="0x11CCD10", Offset="0x11CCD10", VA="0x11CCD10")]
	private void BindPlayerListItem(WrappedScrollRectListItem listItem, int dataIndex)
	{
	}

	[Address(RVA="0x11CC4A4", Offset="0x11CC4A4", VA="0x11CC4A4")]
	private PlayerListItemData GenerateFakeLeaderboardEntry(int rank)
	{
		return null;
	}

	[Address(RVA="0x11CCC30", Offset="0x11CCC30", VA="0x11CCC30")]
	private void InitPlayerListItem(WrappedScrollRectListItem listItem)
	{
	}

	[Address(RVA="0x11CB73C", Offset="0x11CB73C", VA="0x11CB73C")]
	private void PopulateLeaderboard(uint newRank, uint oldRank)
	{
	}

	[Address(RVA="0x11CB5D0", Offset="0x11CB5D0", VA="0x11CB5D0", Slot="21")]
	public override void SetData(ulong newRank, ulong rankDelta, string endReason)
	{
	}

	[Address(RVA="0x11CBE08", Offset="0x11CBE08", VA="0x11CBE08", Slot="22")]
	public override void TickUpdate()
	{
	}

	[Address(RVA="0x11CC71C", Offset="0x11CC71C", VA="0x11CC71C", Slot="11")]
	protected override void ViewAssetLoaded()
	{
	}

	[Address(RVA="0x11CCBF0", Offset="0x11CCBF0", VA="0x11CCBF0", Slot="13")]
	protected override void ViewShown()
	{
	}

	[Address(RVA="0x11CCAC4", Offset="0x11CCAC4", VA="0x11CCAC4", Slot="12")]
	protected override void ViewShuttingDown()
	{
	}

	[Serializable]
	public class SerializedFields : AKothBattleResultsView.KothBattleResultsViewSerializedFields
	{
		[FieldOffset(Offset="0x50")]
		public WrappedScrollRect LeaderboardScrollRect;

		[FieldOffset(Offset="0x58")]
		public UiColorPalette UiColorPalette;

		[FieldOffset(Offset="0x60")]
		public RectTransform RowAnimationContainer;

		[FieldOffset(Offset="0x68")]
		public ParticleSystem RowUpParticles;

		[FieldOffset(Offset="0x70")]
		public ParticleSystem RowDownParticles;

		[Attribute(Name="HeaderAttribute", RVA="0x106ACD4", Offset="0x106ACD4")]
		[FieldOffset(Offset="0x78")]
		public float RowUpDownScaleMagnitude;

		[FieldOffset(Offset="0x7C")]
		public float RowUpDownScaleDuration;

		[FieldOffset(Offset="0x80")]
		public float RowDownTranslateDuration;

		[FieldOffset(Offset="0x84")]
		public float AutoScrollRate;

		[FieldOffset(Offset="0x88")]
		public float AutoScrollMaxDuration;

		[FieldOffset(Offset="0x8C")]
		public float AutoScrollDelay;

		[Attribute(Name="HeaderAttribute", RVA="0x106AD0C", Offset="0x106AD0C")]
		[FieldOffset(Offset="0x90")]
		public AudioClipGroup FireworkAudio;

		[FieldOffset(Offset="0x98")]
		public float FireworkAudioPlayTimeS;

		[Address(RVA="0x11CD01C", Offset="0x11CD01C", VA="0x11CD01C")]
		public SerializedFields()
		{
		}
	}
}