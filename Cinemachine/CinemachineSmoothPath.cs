using Il2CppDummyDll;
using System;
using UnityEngine;

namespace Cinemachine
{
	[Attribute(Name="AddComponentMenu", RVA="0x104A1A0", Offset="0x104A1A0")]
	[Attribute(Name="DocumentationSortingAttribute", RVA="0x104A1A0", Offset="0x104A1A0")]
	[Attribute(Name="SaveDuringPlayAttribute", RVA="0x104A1A0", Offset="0x104A1A0")]
	public class CinemachineSmoothPath : CinemachinePathBase
	{
		[Attribute(Name="TooltipAttribute", RVA="0x1066DF4", Offset="0x1066DF4")]
		[FieldOffset(Offset="0x48")]
		public bool m_Looped;

		[Attribute(Name="TooltipAttribute", RVA="0x1066E2C", Offset="0x1066E2C")]
		[FieldOffset(Offset="0x50")]
		public CinemachineSmoothPath.Waypoint[] m_Waypoints;

		[FieldOffset(Offset="0x58")]
		private CinemachineSmoothPath.Waypoint[] m_ControlPoints1;

		[FieldOffset(Offset="0x60")]
		private CinemachineSmoothPath.Waypoint[] m_ControlPoints2;

		[FieldOffset(Offset="0x68")]
		private bool m_IsLoopedCache;

		public override int DistanceCacheSampleStepsPerSegment
		{
			[Address(RVA="0x1452394", Offset="0x1452394", VA="0x1452394", Slot="13")]
			get
			{
				return new int();
			}
		}

		public override bool Looped
		{
			[Address(RVA="0x145238C", Offset="0x145238C", VA="0x145238C", Slot="6")]
			get
			{
				return new bool();
			}
		}

		public override float MaxPos
		{
			[Address(RVA="0x1452338", Offset="0x1452338", VA="0x1452338", Slot="5")]
			get
			{
				return new float();
			}
		}

		public override float MinPos
		{
			[Address(RVA="0x1452330", Offset="0x1452330", VA="0x1452330", Slot="4")]
			get
			{
				return new float();
			}
		}

		[Address(RVA="0x14544C8", Offset="0x14544C8", VA="0x14544C8")]
		public CinemachineSmoothPath()
		{
		}

		[Address(RVA="0x1454044", Offset="0x1454044", VA="0x1454044", Slot="10")]
		public override Quaternion EvaluateOrientation(float pos)
		{
			return new Quaternion();
		}

		[Address(RVA="0x1453AC0", Offset="0x1453AC0", VA="0x1453AC0", Slot="8")]
		public override Vector3 EvaluatePosition(float pos)
		{
			return new Vector3();
		}

		[Address(RVA="0x1453D3C", Offset="0x1453D3C", VA="0x1453D3C", Slot="9")]
		public override Vector3 EvaluateTangent(float pos)
		{
			return new Vector3();
		}

		[Address(RVA="0x1453988", Offset="0x1453988", VA="0x1453988")]
		private float GetBoundingIndices(float pos, out int indexA, out int indexB)
		{
			indexA = 0;
			indexB = 0;
			return new float();
		}

		[Address(RVA="0x14523AC", Offset="0x14523AC", VA="0x14523AC", Slot="14")]
		public override void InvalidateDistanceCache()
		{
		}

		[Address(RVA="0x145239C", Offset="0x145239C", VA="0x145239C")]
		private void OnValidate()
		{
		}

		[Address(RVA="0x14523BC", Offset="0x14523BC", VA="0x14523BC")]
		private void UpdateControlPoints()
		{
		}

		[Attribute(Name="DocumentationSortingAttribute", RVA="0x1051310", Offset="0x1051310")]
		[Serializable]
		public struct Waypoint
		{
			[Attribute(Name="TooltipAttribute", RVA="0x106D074", Offset="0x106D074")]
			[FieldOffset(Offset="0x0")]
			public Vector3 position;

			[Attribute(Name="TooltipAttribute", RVA="0x106D0AC", Offset="0x106D0AC")]
			[FieldOffset(Offset="0xC")]
			public float roll;

			internal Vector4 AsVector4
			{
				[Address(RVA="0xF01004", Offset="0xF01004", VA="0xF01004")]
				get
				{
					return new Vector4();
				}
			}

			[Address(RVA="0x14538D8", Offset="0x14538D8", VA="0x14538D8")]
			internal static CinemachineSmoothPath.Waypoint FromVector4(Vector4 v)
			{
				return new CinemachineSmoothPath.Waypoint();
			}
		}
	}
}