using Il2CppDummyDll;
using System;
using UnityEngine;

namespace TechArt
{
	public class ObjectOrbiter : MonoBehaviour
	{
		[FieldOffset(Offset="0x18")]
		[SerializeField]
		private Transform target;

		[FieldOffset(Offset="0x20")]
		[SerializeField]
		private float distance;

		[FieldOffset(Offset="0x24")]
		[SerializeField]
		private float xSpeed;

		[FieldOffset(Offset="0x28")]
		[SerializeField]
		private float ySpeed;

		[FieldOffset(Offset="0x2C")]
		[SerializeField]
		private float yMinLimit;

		[FieldOffset(Offset="0x30")]
		[SerializeField]
		private float yMaxLimit;

		[FieldOffset(Offset="0x34")]
		[SerializeField]
		private float distanceMin;

		[FieldOffset(Offset="0x38")]
		[SerializeField]
		private float distanceMax;

		[FieldOffset(Offset="0x3C")]
		private float x;

		[FieldOffset(Offset="0x40")]
		private float y;

		[FieldOffset(Offset="0x44")]
		private Vector3 defaultPos;

		[FieldOffset(Offset="0x50")]
		private Quaternion defaultRot;

		[FieldOffset(Offset="0x60")]
		private Quaternion rotation;

		[FieldOffset(Offset="0x70")]
		private Vector3 position;

		[FieldOffset(Offset="0x7C")]
		private float defaultDist;

		[Address(RVA="0x1322CE4", Offset="0x1322CE4", VA="0x1322CE4")]
		public ObjectOrbiter()
		{
		}

		[Address(RVA="0x1322C34", Offset="0x1322C34", VA="0x1322C34")]
		public static float ClampAngle(float angle, float min, float max)
		{
			return new float();
		}

		[Address(RVA="0x13227CC", Offset="0x13227CC", VA="0x13227CC")]
		private void LateUpdate()
		{
		}

		[Address(RVA="0x1322784", Offset="0x1322784", VA="0x1322784")]
		private void SetCamera()
		{
		}

		[Address(RVA="0x1322708", Offset="0x1322708", VA="0x1322708")]
		private void Start()
		{
		}
	}
}