using Il2CppDummyDll;
using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Cinemachine.Utility
{
	public static class UnityQuaternionExtensions
	{
		[Address(RVA="0x14632D4", Offset="0x14632D4", VA="0x14632D4")]
		public static Quaternion ApplyCameraRotation(Quaternion orient, Vector2 rot, Vector3 worldUp)
		{
			return new Quaternion();
		}

		[Address(RVA="0x1462D20", Offset="0x1462D20", VA="0x1462D20")]
		public static Vector2 GetCameraRotationToTarget(Quaternion orient, Vector3 lookAtDir, Vector3 worldUp)
		{
			return new Vector2();
		}

		[Address(RVA="0x14575EC", Offset="0x14575EC", VA="0x14575EC")]
		public static Quaternion Normalized(Quaternion q)
		{
			return new Quaternion();
		}

		[Address(RVA="0x14628D4", Offset="0x14628D4", VA="0x14628D4")]
		public static Quaternion SlerpWithReferenceUp(Quaternion qA, Quaternion qB, float t, Vector3 up)
		{
			return new Quaternion();
		}
	}
}