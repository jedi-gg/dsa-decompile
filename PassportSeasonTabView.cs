using Gamedata;
using Glunies;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PassportSeasonTabView : ATabView
{
	[Attribute(Name="InjectAttribute", RVA="0x105AEEC", Offset="0x105AEEC")]
	[FieldOffset(Offset="0x68")]
	private GamedataDomainController _gamedataDC;

	[FieldOffset(Offset="0x70")]
	private UiTimerLabel _timerLabel;

	private PassportSeasonTabView.PassportSeasonTabSerializedFields Fields
	{
		[Address(RVA="0x1407CA8", Offset="0x1407CA8", VA="0x1407CA8")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x1408310", Offset="0x1408310", VA="0x1408310")]
	public PassportSeasonTabView()
	{
	}

	[Address(RVA="0x14080B4", Offset="0x14080B4", VA="0x14080B4", Slot="15")]
	protected override RectTransform GetDynamicPointAtObject(string pointAtId)
	{
		return null;
	}

	[Address(RVA="0x1408208", Offset="0x1408208", VA="0x1408208")]
	private void InfoClicked()
	{
	}

	[Address(RVA="0x140763C", Offset="0x140763C", VA="0x140763C")]
	public void SetPassportSeason(PassportSeason? season, bool hasPremium, int week)
	{
	}

	[Address(RVA="0x1407D88", Offset="0x1407D88", VA="0x1407D88")]
	public void TickUpdate()
	{
	}

	[Address(RVA="0x140828C", Offset="0x140828C", VA="0x140828C")]
	private void UpgradeToPremiumClicked()
	{
	}

	[Address(RVA="0x1407E5C", Offset="0x1407E5C", VA="0x1407E5C", Slot="11")]
	protected override void ViewAssetLoaded()
	{
	}

	[Address(RVA="0x1407FF8", Offset="0x1407FF8", VA="0x1407FF8", Slot="12")]
	protected override void ViewShuttingDown()
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104C55C", Offset="0x104C55C")]
	private sealed class <>c__DisplayClass0_0
	{
		[FieldOffset(Offset="0x10")]
		public bool hasPremium;

		[Address(RVA="0x1407CA0", Offset="0x1407CA0", VA="0x1407CA0")]
		public <>c__DisplayClass0_0()
		{
		}

		[Address(RVA="0x1408318", Offset="0x1408318", VA="0x1408318")]
		internal void <SetPassportSeason>b__0(UnityEngine.GameObject g)
		{
		}

		[Address(RVA="0x1408354", Offset="0x1408354", VA="0x1408354")]
		internal void <SetPassportSeason>b__1(UnityEngine.GameObject g)
		{
		}
	}

	[Serializable]
	public class PassportSeasonTabSerializedFields : ATabView.SerializedFields
	{
		[Attribute(Name="HeaderAttribute", RVA="0x106B254", Offset="0x106B254")]
		[FieldOffset(Offset="0x30")]
		public Button InfoButton;

		[FieldOffset(Offset="0x38")]
		public UiLabel TimerLabel;

		[FieldOffset(Offset="0x40")]
		public RawImage PassportImage;

		[FieldOffset(Offset="0x48")]
		public UnityEngine.Color PassportImageNotActivatedColor;

		[FieldOffset(Offset="0x58")]
		public Graphic PassportImageFrame;

		[FieldOffset(Offset="0x60")]
		public UnityEngine.Color PassportImageFrameNotActivatedColor;

		[FieldOffset(Offset="0x70")]
		public RawImage PremiumItemImage;

		[FieldOffset(Offset="0x78")]
		public List<UnityEngine.GameObject> PassholderActivatedObjects;

		[FieldOffset(Offset="0x80")]
		public List<UnityEngine.GameObject> PassholderNotActivatedObjects;

		[FieldOffset(Offset="0x88")]
		public Button UpgradeToPremiumButton;

		[FieldOffset(Offset="0x90")]
		public UiLabel SeasonNameLabel;

		[FieldOffset(Offset="0x98")]
		public UiLabel WeekNameLabel;

		[Address(RVA="0x1408390", Offset="0x1408390", VA="0x1408390")]
		public PassportSeasonTabSerializedFields()
		{
		}
	}
}