using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Polybrush
{
	public static class z_Math
	{
		[FieldOffset(Offset="0x0")]
		private static Vector3 tv1;

		[FieldOffset(Offset="0xC")]
		private static Vector3 tv2;

		[FieldOffset(Offset="0x18")]
		private static Vector3 tv3;

		[FieldOffset(Offset="0x24")]
		private static Vector3 tv4;

		[Address(RVA="0x12700A4", Offset="0x12700A4", VA="0x12700A4")]
		public static Vector3 Average(Vector3[] array, IEnumerable<int> indices)
		{
			return new Vector3();
		}

		[Address(RVA="0x1270088", Offset="0x1270088", VA="0x1270088")]
		public static int Clamp(int value, int min, int max)
		{
			return new int();
		}

		[Address(RVA="0x126F4EC", Offset="0x126F4EC", VA="0x126F4EC")]
		public static Vector3 Normal(Vector3 p0, Vector3 p1, Vector3 p2)
		{
			return new Vector3();
		}

		[Address(RVA="0x126F6A8", Offset="0x126F6A8", VA="0x126F6A8")]
		public static Vector3 Normal(Vector3[] p)
		{
			return new Vector3();
		}

		[Address(RVA="0x126FAA0", Offset="0x126FAA0", VA="0x126FAA0")]
		public static void NormalTangentBitangent(Vector3[] vertices, Vector2[] uv, int[] tri, out Vector3 normal, out Vector3 tangent, out Vector3 bitangent)
		{
			normal = new Vector3();
			tangent = new Vector3();
			bitangent = new Vector3();
		}

		[Address(RVA="0x126F030", Offset="0x126F030", VA="0x126F030")]
		public static bool RayIntersectsTriangle(Vector3 origin, Vector3 direction, Vector3 InTriangleA, Vector3 InTriangleB, Vector3 InTriangleC, out float OutDistance, out Vector3 OutPoint)
		{
			OutDistance = 0f;
			OutPoint = new Vector3();
			return new bool();
		}

		[Address(RVA="0x126EC30", Offset="0x126EC30", VA="0x126EC30")]
		public static bool RayIntersectsTriangle2(Vector3 origin, Vector3 dir, Vector3 vert0, Vector3 vert1, Vector3 vert2, ref float distance, ref Vector3 normal)
		{
			return new bool();
		}

		[Address(RVA="0x12708F0", Offset="0x12708F0", VA="0x12708F0")]
		public static bool VectorIsUniform(Vector3 vec)
		{
			return new bool();
		}

		[Address(RVA="0x1270440", Offset="0x1270440", VA="0x1270440")]
		public static Vector3 WeightedAverage(Vector3[] array, IList<int> indices, float[] weightLookup)
		{
			return new Vector3();
		}
	}
}