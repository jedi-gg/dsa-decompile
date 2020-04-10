using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

namespace Cinemachine.Timeline
{
	[Attribute(Name="TrackBindingTypeAttribute", RVA="0x104ABFC", Offset="0x104ABFC")]
	[Attribute(Name="TrackClipTypeAttribute", RVA="0x104ABFC", Offset="0x104ABFC")]
	[Attribute(Name="TrackColorAttribute", RVA="0x104ABFC", Offset="0x104ABFC")]
	[Serializable]
	public class CinemachineTrack : TrackAsset
	{
		[Address(RVA="0x14610B8", Offset="0x14610B8", VA="0x14610B8")]
		public CinemachineTrack()
		{
		}

		[Address(RVA="0x1460C08", Offset="0x1460C08", VA="0x1460C08", Slot="14")]
		public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
		{
			return new Playable();
		}
	}
}