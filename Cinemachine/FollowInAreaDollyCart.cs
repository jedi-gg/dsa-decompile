using Il2CppDummyDll;
using System;
using UnityEngine;

namespace Cinemachine
{
	[Attribute(Name="ExecuteInEditMode", RVA="0x1049BBC", Offset="0x1049BBC")]
	public class FollowInAreaDollyCart : MonoBehaviour
	{
		[FieldOffset(Offset="0x0")]
		private readonly static Color GIZMO_COLOR;

		[FieldOffset(Offset="0x18")]
		[SerializeField]
		private Transform _follow;

		[FieldOffset(Offset="0x20")]
		[SerializeField]
		private CinemachinePathBase _path;

		[FieldOffset(Offset="0x28")]
		[SerializeField]
		private FollowInAreaDollyCart.Orientation _posOrientation;

		[FieldOffset(Offset="0x2C")]
		[SerializeField]
		private float _areaStart;

		[FieldOffset(Offset="0x30")]
		[SerializeField]
		private float _areaEnd;

		[FieldOffset(Offset="0x34")]
		[SerializeField]
		private float _damping;

		[FieldOffset(Offset="0x38")]
		private float _lastPosition;

		[Address(RVA="0x145E870", Offset="0x145E870", VA="0x145E870")]
		static FollowInAreaDollyCart()
		{
		}

		[Address(RVA="0x145E860", Offset="0x145E860", VA="0x145E860")]
		public FollowInAreaDollyCart()
		{
		}

		[Address(RVA="0x145E764", Offset="0x145E764", VA="0x145E764")]
		private float GetPercentInArea()
		{
			return new float();
		}

		[Address(RVA="0x145E5C0", Offset="0x145E5C0", VA="0x145E5C0")]
		private void OnDrawGizmos()
		{
		}

		[Address(RVA="0x145E368", Offset="0x145E368", VA="0x145E368")]
		private void Update()
		{
		}

		[Address(RVA="0x145E390", Offset="0x145E390", VA="0x145E390")]
		private void UpdateCartPosition(float deltaTime)
		{
		}

		public enum Orientation
		{
			[FieldOffset(Offset="0x0")]
			X,
			[FieldOffset(Offset="0x0")]
			Z
		}
	}
}