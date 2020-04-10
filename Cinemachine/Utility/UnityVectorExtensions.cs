using Il2CppDummyDll;
using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Cinemachine.Utility
{
	public static class UnityVectorExtensions
	{
		[FieldOffset(Offset="0x0")]
		public const float Epsilon = 0.0001f;

		[Address(RVA="0x144F148", Offset="0x144F148", VA="0x144F148")]
		public static bool AlmostZero(Vector3 v)
		{
			return new bool();
		}

		[Address(RVA="0x14515E8", Offset="0x14515E8", VA="0x14515E8")]
		public static float ClosestPointOnSegment(Vector3 p, Vector3 s0, Vector3 s1)
		{
			return new float();
		}

		[Address(RVA="0x14634BC", Offset="0x14634BC", VA="0x14634BC")]
		public static float ClosestPointOnSegment(Vector2 p, Vector2 s0, Vector2 s1)
		{
			return new float();
		}

		[Address(RVA="0x1462C44", Offset="0x1462C44", VA="0x1462C44")]
		public static Vector3 ProjectOntoPlane(Vector3 vector, Vector3 planeNormal)
		{
			return new Vector3();
		}

		[Address(RVA="0x1463108", Offset="0x1463108", VA="0x1463108")]
		public static float SignedAngle(Vector3 from, Vector3 to, Vector3 refNormal)
		{
			return new float();
		}

		[Address(RVA="0x1463618", Offset="0x1463618", VA="0x1463618")]
		public static Vector3 SlerpWithReferenceUp(Vector3 vA, Vector3 vB, float t, Vector3 up)
		{
			return new Vector3();
		}
	}
}