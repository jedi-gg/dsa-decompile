using Il2CppDummyDll;
using System;
using UnityEngine;

namespace Cinemachine.Utility
{
	public static class Damper
	{
		[FieldOffset(Offset="0x0")]
		private const float Epsilon = 0.0001f;

		[FieldOffset(Offset="0x0")]
		public const float kNegligibleResidual = 0.01f;

		[Address(RVA="0x14583FC", Offset="0x14583FC", VA="0x14583FC")]
		public static float Damp(float initial, float dampTime, float deltaTime)
		{
			return new float();
		}

		[Address(RVA="0x1458990", Offset="0x1458990", VA="0x1458990")]
		public static Vector3 Damp(Vector3 initial, Vector3 dampTime, float deltaTime)
		{
			return new Vector3();
		}

		[Address(RVA="0x14584C8", Offset="0x14584C8", VA="0x14584C8")]
		public static Vector3 Damp(Vector3 initial, float dampTime, float deltaTime)
		{
			return new Vector3();
		}

		[Address(RVA="0x14614F0", Offset="0x14614F0", VA="0x14614F0")]
		private static float Decay(float initial, float decayConstant, float deltaTime)
		{
			return new float();
		}

		[Address(RVA="0x1461474", Offset="0x1461474", VA="0x1461474")]
		private static float DecayConstant(float time, float residual)
		{
			return new float();
		}
	}
}