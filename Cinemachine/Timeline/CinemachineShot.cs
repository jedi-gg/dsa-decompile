using Cinemachine;
using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

namespace Cinemachine.Timeline
{
	public sealed class CinemachineShot : PlayableAsset, IPropertyPreview
	{
		[FieldOffset(Offset="0x18")]
		public ExposedReference<CinemachineVirtualCameraBase> VirtualCamera;

		[Address(RVA="0x1460BF8", Offset="0x1460BF8", VA="0x1460BF8")]
		public CinemachineShot()
		{
		}

		[Address(RVA="0x1460540", Offset="0x1460540", VA="0x1460540", Slot="6")]
		public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			return new Playable();
		}

		[Address(RVA="0x146064C", Offset="0x146064C", VA="0x146064C", Slot="9")]
		public void GatherProperties(PlayableDirector director, IPropertyCollector driver)
		{
		}
	}
}