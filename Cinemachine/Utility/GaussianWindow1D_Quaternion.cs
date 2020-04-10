using Il2CppDummyDll;
using System;
using UnityEngine;

namespace Cinemachine.Utility
{
	internal class GaussianWindow1D_Quaternion : GaussianWindow1d<Quaternion>
	{
		[Address(RVA="0x1461898", Offset="0x1461898", VA="0x1461898")]
		public GaussianWindow1D_Quaternion(float sigma, int maxKernelRadius = 10)
		{
		}

		[Address(RVA="0x1461908", Offset="0x1461908", VA="0x1461908", Slot="4")]
		protected override Quaternion Compute(int windowPos)
		{
			return new Quaternion();
		}
	}
}