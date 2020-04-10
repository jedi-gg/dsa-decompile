using DG.Tweening;
using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;
using System.Collections.Generic;
using UnityEngine;

public class ClubWarRewardsPopupView : APopupView
{
	[FieldOffset(Offset="0x68")]
	private IList<ClubWarReward> _rewards;

	[FieldOffset(Offset="0x70")]
	private Sequence _showSequence;

	private ClubWarRewardsPopupView.SerializedFields Fields
	{
		[Address(RVA="0x14DA884", Offset="0x14DA884", VA="0x14DA884")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x14DADB0", Offset="0x14DADB0", VA="0x14DADB0")]
	public ClubWarRewardsPopupView()
	{
	}

	[Address(RVA="0x14DAC80", Offset="0x14DAC80", VA="0x14DAC80")]
	private void BindChest(WrappedScrollRectListItem listItem, int index)
	{
	}

	[Address(RVA="0x14DABC4", Offset="0x14DABC4", VA="0x14DABC4")]
	private void InitializeChest(WrappedScrollRectListItem listItem)
	{
	}

	[Address(RVA="0x14D9D5C", Offset="0x14D9D5C", VA="0x14D9D5C")]
	public void SetPlace(int place)
	{
	}

	[Address(RVA="0x14D96DC", Offset="0x14D96DC", VA="0x14D96DC")]
	public void SetRewards(IList<ClubWarReward> rewards)
	{
	}

	[Address(RVA="0x14DA964", Offset="0x14DA964", VA="0x14DA964", Slot="11")]
	protected override void ViewAssetLoaded()
	{
	}

	[Address(RVA="0x14DAB80", Offset="0x14DAB80", VA="0x14DAB80", Slot="13")]
	protected override void ViewShown()
	{
	}

	[Address(RVA="0x14DAB08", Offset="0x14DAB08", VA="0x14DAB08", Slot="12")]
	protected override void ViewShuttingDown()
	{
	}

	[Serializable]
	public class SerializedFields : PopupViewSerializedFields
	{
		[FieldOffset(Offset="0x30")]
		public WrappedScrollRect Rewards;

		[FieldOffset(Offset="0x38")]
		public UnityEngine.GameObject NoRewardsContainer;

		[FieldOffset(Offset="0x40")]
		public UnityEngine.GameObject FirstPlaceRoot;

		[FieldOffset(Offset="0x48")]
		public UnityEngine.GameObject SecondPlaceRoot;

		[FieldOffset(Offset="0x50")]
		public UnityEngine.GameObject ThirdPlaceRoot;

		[FieldOffset(Offset="0x58")]
		public CanvasGroup WindowRoot;

		[Address(RVA="0x14DADB8", Offset="0x14DADB8", VA="0x14DADB8")]
		public SerializedFields()
		{
		}
	}
}