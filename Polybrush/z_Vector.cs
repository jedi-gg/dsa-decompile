using Il2CppDummyDll;
using System;
using UnityEngine;

namespace Polybrush
{
	public static class z_Vector
	{
		[Address(RVA="0x126F4B8", Offset="0x126F4B8", VA="0x126F4B8")]
		public static void Cross(Vector3 a, Vector3 b, ref float x, ref float y, ref float z)
		{
		}

		[Address(RVA="0x126F000", Offset="0x126F000", VA="0x126F000")]
		public static void Cross(Vector3 a, Vector3 b, ref Vector3 res)
		{
		}

		[Address(RVA="0x126F674", Offset="0x126F674", VA="0x126F674")]
		public static void Cross(float ax, float ay, float az, float bx, float by, float bz, ref float x, ref float y, ref float z)
		{
		}

		[Address(RVA="0x126EFE8", Offset="0x126EFE8", VA="0x126EFE8")]
		public static void Subtract(Vector3 a, Vector3 b, ref Vector3 res)
		{
		}
	}
}