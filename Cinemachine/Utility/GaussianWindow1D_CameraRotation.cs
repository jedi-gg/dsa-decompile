using Il2CppDummyDll;
using System;
using UnityEngine;

namespace Cinemachine.Utility
{
	internal class GaussianWindow1D_CameraRotation : GaussianWindow1d<Vector2>
	{
		[Address(RVA="0x1461574", Offset="0x1461574", VA="0x1461574")]
		public GaussianWindow1D_CameraRotation(float sigma, int maxKernelRadius = 10)
		{
		}

		[Address(RVA="0x14615E4", Offset="0x14615E4", VA="0x14615E4", Slot="4")]
		protected override Vector2 Compute(int windowPos)
		{
			return new Vector2();
		}
	}
}