using Il2CppDummyDll;
using System;
using UnityEngine;

namespace Fenderrio.ImageWarp
{
	[Serializable]
	public class BezierCurve
	{
		[FieldOffset(Offset="0x0")]
		private const int NUM_CURVE_SAMPLE_SUBSECTIONS = 50;

		[FieldOffset(Offset="0x0")]
		private const int MAX_NUM_ANCHOR_POINTS = 5;

		[FieldOffset(Offset="0x10")]
		public BezierCurve.BezierCurvePoint[] m_pointsData;

		[FieldOffset(Offset="0x18")]
		private Vector3[] m_temp_anchor_points;

		[FieldOffset(Offset="0x20")]
		private Vector3 m_rot;

		[Address(RVA="0x12BBF84", Offset="0x12BBF84", VA="0x12BBF84")]
		public BezierCurve()
		{
		}

		[Address(RVA="0x12BBD98", Offset="0x12BBD98", VA="0x12BBD98")]
		private float GetCurveLength(int curve_idx)
		{
			return new float();
		}

		[Address(RVA="0x12BAF00", Offset="0x12BAF00", VA="0x12BAF00")]
		public Vector3 GetCurvePoint(float progress, int num_anchors = 4, int curve_idx = -1, float yOffset = 0f)
		{
			return new Vector3();
		}

		[Address(RVA="0x12BB9F4", Offset="0x12BB9F4", VA="0x12BB9F4")]
		public Vector3 GetCurvePointRotation(float progress, int curve_idx = -1)
		{
			return new Vector3();
		}

		[Serializable]
		public class BezierCurvePoint
		{
			[FieldOffset(Offset="0x10")]
			[SerializeField]
			private Vector3 m_anchorPoint;

			[FieldOffset(Offset="0x1C")]
			[SerializeField]
			private Vector3 m_handlePointA;

			[FieldOffset(Offset="0x28")]
			[SerializeField]
			private Vector3 m_handlePointB;

			[FieldOffset(Offset="0x34")]
			[SerializeField]
			private bool m_mirroredHandles;

			[FieldOffset(Offset="0x35")]
			[SerializeField]
			private bool m_handlesFollowAnchor;

			public Vector3 AnchorPoint
			{
				[Address(RVA="0x12BB9D0", Offset="0x12BB9D0", VA="0x12BB9D0")]
				get
				{
					return new Vector3();
				}
				[Address(RVA="0x12BBF8C", Offset="0x12BBF8C", VA="0x12BBF8C")]
				set
				{
				}
			}

			public Vector3 HandlePointA
			{
				[Address(RVA="0x12BB9E8", Offset="0x12BB9E8", VA="0x12BB9E8")]
				get
				{
					return new Vector3();
				}
				[Address(RVA="0x12BC0B4", Offset="0x12BC0B4", VA="0x12BC0B4")]
				set
				{
				}
			}

			public Vector3 HandlePointB
			{
				[Address(RVA="0x12BB9DC", Offset="0x12BB9DC", VA="0x12BB9DC")]
				get
				{
					return new Vector3();
				}
				[Address(RVA="0x12BC198", Offset="0x12BC198", VA="0x12BC198")]
				set
				{
				}
			}

			public bool HandlesFollowAnchor
			{
				[Address(RVA="0x12BC284", Offset="0x12BC284", VA="0x12BC284")]
				get
				{
					return new bool();
				}
			}

			public bool MirroredHandles
			{
				[Address(RVA="0x12BC27C", Offset="0x12BC27C", VA="0x12BC27C")]
				get
				{
					return new bool();
				}
			}

			[Address(RVA="0x12BC28C", Offset="0x12BC28C", VA="0x12BC28C")]
			public BezierCurvePoint()
			{
			}
		}
	}
}