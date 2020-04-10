using Il2CppDummyDll;
using System;
using UnityEngine;

namespace Cinemachine.Utility
{
	internal class GaussianWindow1D_Vector3 : GaussianWindow1d<Vector3>
	{
		[Address(RVA="0x1461C00", Offset="0x1461C00", VA="0x1461C00")]
		public GaussianWindow1D_Vector3(float sigma, int maxKernelRadius = 10)
		{
		}

		[Address(RVA="0x1461C70", Offset="0x1461C70", VA="0x1461C70", Slot="4")]
		protected override Vector3 Compute(int windowPos)
		{
			return new Vector3();
		}
	}
}