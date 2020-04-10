using Il2CppDummyDll;
using System;
using UnityEngine;

namespace Glunies.Sequencer
{
	public class LookAtHelper
	{
		[FieldOffset(Offset="0x0")]
		public const float DEFAULT_ROTATE_SPEED = 15.7079639f;

		[FieldOffset(Offset="0x10")]
		private float _rotationSpeed;

		[FieldOffset(Offset="0x14")]
		private Quaternion _desiredRotation;

		[FieldOffset(Offset="0x24")]
		private Quaternion _previousRotation;

		[FieldOffset(Offset="0x34")]
		private bool _2dRotate;

		[Address(RVA="0x152DF64", Offset="0x152DF64", VA="0x152DF64")]
		public LookAtHelper()
		{
		}

		[Address(RVA="0x152D38C", Offset="0x152D38C", VA="0x152D38C")]
		public void Initialize(Quaternion startRotation, float rotationSpeed = 15.7079639f, bool is2dRotate = false)
		{
		}

		[Address(RVA="0x152D914", Offset="0x152D914", VA="0x152D914")]
		public void TickUpdate(float deltaTime, Transform goTransform, Vector3 lookTarget, bool interpolate = true)
		{
		}
	}
}