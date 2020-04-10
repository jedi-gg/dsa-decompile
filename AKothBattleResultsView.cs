using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine.UI;

public class AKothBattleResultsView : AStandardView
{
	private AKothBattleResultsView.KothBattleResultsViewSerializedFields Fields
	{
		[Address(RVA="0x10EB7E8", Offset="0x10EB7E8", VA="0x10EB7E8")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x10EBC2C", Offset="0x10EBC2C", VA="0x10EBC2C")]
	public AKothBattleResultsView()
	{
	}

	[Address(RVA="0x10EBAD0", Offset="0x10EBAD0", VA="0x10EBAD0")]
	private void ContinueClicked()
	{
	}

	[Address(RVA="0x10EBB54", Offset="0x10EBB54", VA="0x10EBB54")]
	private void LeaderboardClicked()
	{
	}

	[Address(RVA="0x10EB638", Offset="0x10EB638", VA="0x10EB638", Slot="21")]
	public virtual void SetData(ulong newRank, ulong rankDelta, string endReasonText)
	{
	}

	[Address(RVA="0x10EB8C8", Offset="0x10EB8C8", VA="0x10EB8C8", Slot="22")]
	public virtual void TickUpdate()
	{
	}

	[Address(RVA="0x10EB8CC", Offset="0x10EB8CC", VA="0x10EB8CC", Slot="11")]
	protected override void ViewAssetLoaded()
	{
	}

	[Address(RVA="0x10EBA14", Offset="0x10EBA14", VA="0x10EBA14", Slot="12")]
	protected override void ViewShuttingDown()
	{
	}

	[Serializable]
	public class KothBattleResultsViewSerializedFields : ViewSerializedFields
	{
		[FieldOffset(Offset="0x28")]
		public UiLabel RankLabel;

		[FieldOffset(Offset="0x30")]
		public UiLabel RankDeltaLabel;

		[FieldOffset(Offset="0x38")]
		public Button ContinueButton;

		[FieldOffset(Offset="0x40")]
		public Button LeaderboardButton;

		[FieldOffset(Offset="0x48")]
		public UiLabel EndReasonLabel;

		[Address(RVA="0x10EBC34", Offset="0x10EBC34", VA="0x10EBC34")]
		public KothBattleResultsViewSerializedFields()
		{
		}
	}
}