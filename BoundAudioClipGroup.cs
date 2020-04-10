using Glunies.Audio;
using Glunies.Sequencer;
using Il2CppDummyDll;
using System;

[Attribute(Name="SequencerBoundFieldAttribute", RVA="0x104821C", Offset="0x104821C")]
[Serializable]
public class BoundAudioClipGroup : ABoundField
{
	public AudioClipGroup Value
	{
		[Address(RVA="0x1121628", Offset="0x1121628", VA="0x1121628")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x1121680", Offset="0x1121680", VA="0x1121680")]
	public BoundAudioClipGroup()
	{
	}
}