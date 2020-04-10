using Gamedata;
using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.UI;

public class PassportSeasonPreviewView : AStandardView
{
	[FieldOffset(Offset="0x68")]
	private UiTimerLabel _nextSeasonTimer;

	private PassportSeasonPreviewView.SerializedFields Fields
	{
		[Address(RVA="0x1406BE8", Offset="0x1406BE8", VA="0x1406BE8")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x1407598", Offset="0x1407598", VA="0x1407598")]
	public PassportSeasonPreviewView()
	{
	}

	[Address(RVA="0x14075A0", Offset="0x14075A0", VA="0x14075A0")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1070324", Offset="0x1070324")]
	private void <ViewAssetLoaded>b__3_0()
	{
	}

	[Address(RVA="0x1406F5C", Offset="0x1406F5C", VA="0x1406F5C")]
	public void SetCallToAction(PassportSeasonCallToAction? cta)
	{
	}

	[Address(RVA="0x140616C", Offset="0x140616C", VA="0x140616C")]
	public void SetSeason(PassportSeason? season)
	{
	}

	[Address(RVA="0x1405DDC", Offset="0x1405DDC", VA="0x1405DDC")]
	public void TickUpdate()
	{
	}

	[Address(RVA="0x1407400", Offset="0x1407400", VA="0x1407400", Slot="11")]
	protected override void ViewAssetLoaded()
	{
	}

	[Address(RVA="0x1407524", Offset="0x1407524", VA="0x1407524", Slot="12")]
	protected override void ViewShuttingDown()
	{
	}

	[Serializable]
	public class SerializedFields : ViewSerializedFields
	{
		[Attribute(Name="HeaderAttribute", RVA="0x106B2FC", Offset="0x106B2FC")]
		[FieldOffset(Offset="0x28")]
		public UnityEngine.GameObject ActivePreviewContainer;

		[FieldOffset(Offset="0x30")]
		public UnityEngine.GameObject NoPreviewContainer;

		[FieldOffset(Offset="0x38")]
		public UiLabel SeasonNameLabel;

		[FieldOffset(Offset="0x40")]
		public UiLabel SeasonDatesLabel;

		[FieldOffset(Offset="0x48")]
		public UiLabel SeasonDescriptionLabel;

		[FieldOffset(Offset="0x50")]
		public Button PurchaseButton;

		[FieldOffset(Offset="0x58")]
		public RawImage PreviewImage;

		[FieldOffset(Offset="0x60")]
		public UiLabel ComingSoonTimerLabel;

		[FieldOffset(Offset="0x68")]
		public Transform CallToActionOfferContainer;

		[FieldOffset(Offset="0x70")]
		public PassportSeasonCallToActionOffer CallToActionOfferTemplate;

		[FieldOffset(Offset="0x78")]
		public RawImage NoPreviewImage;

		[FieldOffset(Offset="0x80")]
		public UiTimerLabel NoPreviewCountdown;

		[FieldOffset(Offset="0x88")]
		public UiLabel NoPreviewHeading;

		[FieldOffset(Offset="0x90")]
		public UiLabel NoPreviewDescription;

		[Address(RVA="0x1407624", Offset="0x1407624", VA="0x1407624")]
		public SerializedFields()
		{
		}
	}
}