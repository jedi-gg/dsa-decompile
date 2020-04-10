using DG.Tweening;
using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;
using UnityEngine;

public class SpecialOfferPopupView : APopupView
{
	[FieldOffset(Offset="0x68")]
	private StoreItemWidget _activeItemWidget;

	[FieldOffset(Offset="0x70")]
	private Sequence _popInSequence;

	private SpecialOfferPopupView.SerializedFields Fields
	{
		[Address(RVA="0x124152C", Offset="0x124152C", VA="0x124152C")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x1241774", Offset="0x1241774", VA="0x1241774")]
	public SpecialOfferPopupView()
	{
	}

	[Address(RVA="0x1241230", Offset="0x1241230", VA="0x1241230")]
	public void SetData(StoreItem specialOffer)
	{
	}

	[Address(RVA="0x1240E4C", Offset="0x1240E4C", VA="0x1240E4C")]
	public void TickUpdate()
	{
	}

	[Address(RVA="0x124160C", Offset="0x124160C", VA="0x124160C", Slot="11")]
	protected override void ViewAssetLoaded()
	{
	}

	[Address(RVA="0x12416C4", Offset="0x12416C4", VA="0x12416C4", Slot="12")]
	protected override void ViewShuttingDown()
	{
	}

	[Serializable]
	public class SerializedFields : PopupViewSerializedFields
	{
		[FieldOffset(Offset="0x30")]
		public CanvasGroup SpecialOfferRoot;

		[FieldOffset(Offset="0x38")]
		public StoreItemWidget SpecialOfferItem;

		[FieldOffset(Offset="0x40")]
		public CanvasGroup MediumRoot;

		[FieldOffset(Offset="0x48")]
		public StoreItemWidget MediumItem;

		[Address(RVA="0x124177C", Offset="0x124177C", VA="0x124177C")]
		public SerializedFields()
		{
		}
	}
}