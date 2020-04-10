using Glunies.Audio;
using Il2CppDummyDll;
using System;

public class PvpBattleResultsVictoryView : APvpBattleResultsView
{
	[FieldOffset(Offset="0x90")]
	private float _fireworkTimer;

	private PvpBattleResultsVictoryView.SerializedFields Fields
	{
		[Address(RVA="0x1284C7C", Offset="0x1284C7C", VA="0x1284C7C")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x1284D9C", Offset="0x1284D9C", VA="0x1284D9C")]
	public PvpBattleResultsVictoryView()
	{
	}

	[Address(RVA="0x1284B6C", Offset="0x1284B6C", VA="0x1284B6C", Slot="22")]
	public override void TickUpdate()
	{
	}

	[Address(RVA="0x1284D5C", Offset="0x1284D5C", VA="0x1284D5C", Slot="13")]
	protected override void ViewShown()
	{
	}

	[Serializable]
	public class SerializedFields : APvpBattleResultsView.PvpBattleResultViewSerializedFields
	{
		[Attribute(Name="HeaderAttribute", RVA="0x106B70C", Offset="0x106B70C")]
		[FieldOffset(Offset="0x88")]
		public AudioClipGroup FireworkAudio;

		[FieldOffset(Offset="0x90")]
		public float FireworkAudioPlayTimeS;

		[Address(RVA="0x1284DAC", Offset="0x1284DAC", VA="0x1284DAC")]
		public SerializedFields()
		{
		}
	}
}