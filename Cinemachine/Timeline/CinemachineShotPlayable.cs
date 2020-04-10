using Cinemachine;
using Il2CppDummyDll;
using System;
using UnityEngine.Playables;

namespace Cinemachine.Timeline
{
	internal sealed class CinemachineShotPlayable : PlayableBehaviour
	{
		[FieldOffset(Offset="0x10")]
		public CinemachineVirtualCameraBase VirtualCamera;

		[Address(RVA="0x1460C00", Offset="0x1460C00", VA="0x1460C00")]
		public CinemachineShotPlayable()
		{
		}
	}
}