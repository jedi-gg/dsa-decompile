using Il2CppDummyDll;
using System;
using UnityEngine;

namespace Cinemachine.Utility
{
	internal static class SplineHelpers
	{
		[Address(RVA="0x14543E8", Offset="0x14543E8", VA="0x14543E8")]
		public static float Bezier1(float t, float p0, float p1, float p2, float p3)
		{
			return new float();
		}

		[Address(RVA="0x14504AC", Offset="0x14504AC", VA="0x14504AC")]
		public static Vector3 Bezier3(float t, Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3)
		{
			return new Vector3();
		}

		[Address(RVA="0x14627E4", Offset="0x14627E4", VA="0x14627E4")]
		public static float BezierTangent1(float t, float p0, float p1, float p2, float p3)
		{
			return new float();
		}

		[Address(RVA="0x1450A00", Offset="0x1450A00", VA="0x1450A00")]
		public static Vector3 BezierTangent3(float t, Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3)
		{
			return new Vector3();
		}

		[Address(RVA="0x1452BFC", Offset="0x1452BFC", VA="0x1452BFC")]
		public static void ComputeSmoothControlPoints(ref Vector4[] knot, ref Vector4[] ctrl1, ref Vector4[] ctrl2)
		{
		}

		[Address(RVA="0x1452740", Offset="0x1452740", VA="0x1452740")]
		public static void ComputeSmoothControlPointsLooped(ref Vector4[] knot, ref Vector4[] ctrl1, ref Vector4[] ctrl2)
		{
		}
	}
}