using Glunies.Audio;
using Il2CppDummyDll;
using System;
using UnityEngine.UI;

public class ClubWarBattleResultsVictoryView : AClubWarBattleResultsView
{
	[FieldOffset(Offset="0x70")]
	private float _fireworkTimer;

	private ClubWarBattleResultsVictoryView.SerializedFields Fields
	{
		[Address(RVA="0x126A218", Offset="0x126A218", VA="0x126A218")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x126A47C", Offset="0x126A47C", VA="0x126A47C")]
	public ClubWarBattleResultsVictoryView()
	{
	}

	[Address(RVA="0x126A48C", Offset="0x126A48C", VA="0x126A48C")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106F2A4", Offset="0x106F2A4")]
	private void <ViewAssetLoaded>b__1_0()
	{
	}

	[Address(RVA="0x126A108", Offset="0x126A108", VA="0x126A108", Slot="21")]
	public override void TickUpdate()
	{
	}

	[Address(RVA="0x126A2F8", Offset="0x126A2F8", VA="0x126A2F8", Slot="11")]
	protected override void ViewAssetLoaded()
	{
	}

	[Address(RVA="0x126A43C", Offset="0x126A43C", VA="0x126A43C", Slot="13")]
	protected override void ViewShown()
	{
	}

	[Address(RVA="0x126A3C8", Offset="0x126A3C8", VA="0x126A3C8", Slot="12")]
	protected override void ViewShuttingDown()
	{
	}

	[Serializable]
	public class SerializedFields : AClubWarBattleResultsView.ClubWarBattleResultsViewSerializedFields
	{
		[Attribute(Name="HeaderAttribute", RVA="0x106A24C", Offset="0x106A24C")]
		[FieldOffset(Offset="0x78")]
		public Button DailyActivitiesButton;

		[Attribute(Name="HeaderAttribute", RVA="0x106A284", Offset="0x106A284")]
		[FieldOffset(Offset="0x80")]
		public AudioClipGroup FireworkAudio;

		[FieldOffset(Offset="0x88")]
		public float FireworkAudioPlayTimeS;

		[Address(RVA="0x126A510", Offset="0x126A510", VA="0x126A510")]
		public SerializedFields()
		{
		}
	}
}