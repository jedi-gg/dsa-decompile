using Il2CppDummyDll;
using System;
using UnityEngine;

namespace Cinemachine
{
	[Attribute(Name="AddComponentMenu", RVA="0x104A104", Offset="0x104A104")]
	[Attribute(Name="DocumentationSortingAttribute", RVA="0x104A104", Offset="0x104A104")]
	[Attribute(Name="SaveDuringPlayAttribute", RVA="0x104A104", Offset="0x104A104")]
	public class CinemachinePath : CinemachinePathBase
	{
		[Attribute(Name="TooltipAttribute", RVA="0x1066D84", Offset="0x1066D84")]
		[FieldOffset(Offset="0x48")]
		public bool m_Looped;

		[Attribute(Name="TooltipAttribute", RVA="0x1066DBC", Offset="0x1066DBC")]
		[FieldOffset(Offset="0x50")]
		public CinemachinePath.Waypoint[] m_Waypoints;

		public override int DistanceCacheSampleStepsPerSegment
		{
			[Address(RVA="0x1450030", Offset="0x1450030", VA="0x1450030", Slot="13")]
			get
			{
				return new int();
			}
		}

		public override bool Looped
		{
			[Address(RVA="0x1450028", Offset="0x1450028", VA="0x1450028", Slot="6")]
			get
			{
				return new bool();
			}
		}

		public override float MaxPos
		{
			[Address(RVA="0x144FFD4", Offset="0x144FFD4", VA="0x144FFD4", Slot="5")]
			get
			{
				return new float();
			}
		}

		public override float MinPos
		{
			[Address(RVA="0x144FFCC", Offset="0x144FFCC", VA="0x144FFCC", Slot="4")]
			get
			{
				return new float();
			}
		}

		[Address(RVA="0x14510D0", Offset="0x14510D0", VA="0x14510D0")]
		public CinemachinePath()
		{
		}

		[Address(RVA="0x1450D6C", Offset="0x1450D6C", VA="0x1450D6C", Slot="10")]
		public override Quaternion EvaluateOrientation(float pos)
		{
			return new Quaternion();
		}

		[Address(RVA="0x14501D8", Offset="0x14501D8", VA="0x14501D8", Slot="8")]
		public override Vector3 EvaluatePosition(float pos)
		{
			return new Vector3();
		}

		[Address(RVA="0x14506A4", Offset="0x14506A4", VA="0x14506A4", Slot="9")]
		public override Vector3 EvaluateTangent(float pos)
		{
			return new Vector3();
		}

		[Address(RVA="0x1450038", Offset="0x1450038", VA="0x1450038")]
		private float GetBoundingIndices(float pos, out int indexA, out int indexB)
		{
			indexA = 0;
			indexB = 0;
			return new float();
		}

		[Address(RVA="0x14510C0", Offset="0x14510C0", VA="0x14510C0")]
		private void OnValidate()
		{
		}

		[Attribute(Name="DocumentationSortingAttribute", RVA="0x10512F4", Offset="0x10512F4")]
		[Serializable]
		public struct Waypoint
		{
			[Attribute(Name="TooltipAttribute", RVA="0x106CFCC", Offset="0x106CFCC")]
			[FieldOffset(Offset="0x0")]
			public Vector3 position;

			[Attribute(Name="TooltipAttribute", RVA="0x106D004", Offset="0x106D004")]
			[FieldOffset(Offset="0xC")]
			public Vector3 tangent;

			[Attribute(Name="TooltipAttribute", RVA="0x106D03C", Offset="0x106D03C")]
			[FieldOffset(Offset="0x18")]
			public float roll;
		}
	}
}