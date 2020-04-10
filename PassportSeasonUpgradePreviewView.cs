using Gamedata;
using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.UI;

public class PassportSeasonUpgradePreviewView : APopupView
{
	private PassportSeasonUpgradePreviewView.SerializedFields Fields
	{
		[Address(RVA="0x1409444", Offset="0x1409444", VA="0x1409444")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x1409B0C", Offset="0x1409B0C", VA="0x1409B0C")]
	public PassportSeasonUpgradePreviewView()
	{
	}

	[Address(RVA="0x1409B14", Offset="0x1409B14", VA="0x1409B14")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1070334", Offset="0x1070334")]
	private void <ViewAssetLoaded>b__1_0()
	{
	}

	[Address(RVA="0x1409524", Offset="0x1409524", VA="0x1409524")]
	private void SetCallToAction(PassportSeasonCallToAction? cta)
	{
	}

	[Address(RVA="0x1409108", Offset="0x1409108", VA="0x1409108")]
	public void SetSeason(PassportSeason? season)
	{
	}

	[Address(RVA="0x14099C8", Offset="0x14099C8", VA="0x14099C8", Slot="11")]
	protected override void ViewAssetLoaded()
	{
	}

	[Address(RVA="0x1409A98", Offset="0x1409A98", VA="0x1409A98", Slot="12")]
	protected override void ViewShuttingDown()
	{
	}

	[Serializable]
	public class SerializedFields : PopupViewSerializedFields
	{
		[Attribute(Name="HeaderAttribute", RVA="0x106B334", Offset="0x106B334")]
		[FieldOffset(Offset="0x30")]
		public UiLabel SeasonNameLabel;

		[FieldOffset(Offset="0x38")]
		public UiLabel SeasonDatesLabel;

		[FieldOffset(Offset="0x40")]
		public UiLabel SeasonDescriptionLabel;

		[FieldOffset(Offset="0x48")]
		public Button PurchaseButton;

		[FieldOffset(Offset="0x50")]
		public RawImage PreviewImage;

		[FieldOffset(Offset="0x58")]
		public Transform CallToActionOfferContainer;

		[FieldOffset(Offset="0x60")]
		public PassportSeasonCallToActionOffer CallToActionOfferTemplate;

		[Address(RVA="0x1409B98", Offset="0x1409B98", VA="0x1409B98")]
		public SerializedFields()
		{
		}
	}
}