using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class APvpBattleResultsView : AStandardView, IDispatchHandler<DInventoryItemListItemAction>, IDispatchHandler
{
	[Attribute(Name="InjectAttribute", RVA="0x105BB80", Offset="0x105BB80")]
	[FieldOffset(Offset="0x68")]
	private GamedataDomainController _gamedataDC;

	[Attribute(Name="InjectAttribute", RVA="0x105BB90", Offset="0x105BB90")]
	[FieldOffset(Offset="0x70")]
	private Procrastinator _procrastinator;

	[Attribute(Name="InjectAttribute", RVA="0x105BBA0", Offset="0x105BBA0")]
	[FieldOffset(Offset="0x78")]
	private PassportSeasonUtility _passportSeasonUtility;

	[FieldOffset(Offset="0x80")]
	private IReadOnlyList<InventoryItem> _rewards;

	[FieldOffset(Offset="0x88")]
	private UiTimerLabel _nextSeasonTimerLabel;

	public DailyPvpRewardWidget DailyPvpRewardWidget
	{
		[Address(RVA="0x10F3300", Offset="0x10F3300", VA="0x10F3300")]
		get
		{
			return null;
		}
	}

	private APvpBattleResultsView.PvpBattleResultViewSerializedFields Fields
	{
		[Address(RVA="0x10F331C", Offset="0x10F331C", VA="0x10F331C")]
		get
		{
			return null;
		}
	}

	protected override bool WillHandleBackButton
	{
		[Address(RVA="0x10F48A0", Offset="0x10F48A0", VA="0x10F48A0", Slot="19")]
		get
		{
			return new bool();
		}
	}

	[Address(RVA="0x10F48A8", Offset="0x10F48A8", VA="0x10F48A8")]
	public APvpBattleResultsView()
	{
	}

	[Address(RVA="0x10F48B0", Offset="0x10F48B0", VA="0x10F48B0")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1070714", Offset="0x1070714")]
	private void <ViewAssetLoaded>b__6_0()
	{
	}

	[Address(RVA="0x10F45C0", Offset="0x10F45C0", VA="0x10F45C0")]
	private void BindRewardListItem(WrappedScrollRectListItem listItem, int index)
	{
	}

	[Address(RVA="0x10F481C", Offset="0x10F481C", VA="0x10F481C")]
	private void ContinueClicked()
	{
	}

	[Address(RVA="0x10F3968", Offset="0x10F3968", VA="0x10F3968", Slot="21")]
	public void HandleDispatchAction(DInventoryItemListItemAction action)
	{
	}

	[Address(RVA="0x10F44C4", Offset="0x10F44C4", VA="0x10F44C4")]
	private void InitializeRewardListItem(WrappedScrollRectListItem listItem)
	{
	}

	[Address(RVA="0x10F33FC", Offset="0x10F33FC", VA="0x10F33FC")]
	public void SetData(ulong currentPvpScore, InventoryDelta rewards, int stars, string endReasonText, PvpTakeoverResultResponse pvpTakeoverResult = // 
	// Current member / type: System.Void APvpBattleResultsView::SetData(System.UInt64,Serverproto.InventoryDelta,System.Int32,System.String,Serverproto.PvpTakeoverResultResponse)
	// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
	// 
	// Product version: 2018.1.123.0
	// Exception in: System.Void SetData(System.UInt64,Serverproto.InventoryDelta,System.Int32,System.String,Serverproto.PvpTakeoverResultResponse)
	// 
	// Object reference not set to an instance of an object.
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
	//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
	// 
	// mailto: JustDecompilePublicFeedback@telerik.com


	[Address(RVA="0x10F37EC", Offset="0x10F37EC", VA="0x10F37EC")]
	public void TallyLabel(ulong oldPvpScore, ulong newPvpScore)
	{
	}

	[Address(RVA="0x10F3954", Offset="0x10F3954", VA="0x10F3954", Slot="22")]
	public virtual void TickUpdate()
	{
	}

	[Address(RVA="0x10F3B1C", Offset="0x10F3B1C", VA="0x10F3B1C", Slot="11")]
	protected override void ViewAssetLoaded()
	{
	}

	[Address(RVA="0x10F436C", Offset="0x10F436C", VA="0x10F436C", Slot="12")]
	protected override void ViewShuttingDown()
	{
	}

	[Serializable]
	public class PvpBattleResultViewSerializedFields : ViewSerializedFields
	{
		[Attribute(Name="HeaderAttribute", RVA="0x106B664", Offset="0x106B664")]
		[FieldOffset(Offset="0x28")]
		public RawImage CurrentRankIcon;

		[FieldOffset(Offset="0x30")]
		public TallyLabelUnsigned ScoreLabel;

		[FieldOffset(Offset="0x38")]
		public WrappedScrollRect RewardsScrollRect;

		[FieldOffset(Offset="0x40")]
		public Button ContinueButton;

		[FieldOffset(Offset="0x48")]
		public Button LeaderboardButton;

		[FieldOffset(Offset="0x50")]
		public float TallyDuration;

		[FieldOffset(Offset="0x54")]
		public float TallyDelay;

		[FieldOffset(Offset="0x58")]
		public DailyPvpRewardWidget DailyPvpRewardWidget;

		[FieldOffset(Offset="0x60")]
		public UnityEngine.GameObject SeasonActiveContainer;

		[FieldOffset(Offset="0x68")]
		public UnityEngine.GameObject SeasonInactiveContainer;

		[FieldOffset(Offset="0x70")]
		public UiLabel NextSeasonTimerLabel;

		[FieldOffset(Offset="0x78")]
		public List<UnityEngine.GameObject> Stars;

		[FieldOffset(Offset="0x80")]
		public UiLabel EndReasonLabel;

		[Address(RVA="0x10F4934", Offset="0x10F4934", VA="0x10F4934")]
		public PvpBattleResultViewSerializedFields()
		{
		}
	}
}