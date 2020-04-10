using Il2CppDummyDll;
using System;
using UnityEngine;

namespace Cinemachine
{
	public abstract class CinemachinePathBase : MonoBehaviour
	{
		[Attribute(Name="RangeAttribute", RVA="0x10690B4", Offset="0x10690B4")]
		[Attribute(Name="TooltipAttribute", RVA="0x10690B4", Offset="0x10690B4")]
		[FieldOffset(Offset="0x18")]
		public int m_Resolution;

		[Attribute(Name="TooltipAttribute", RVA="0x106910C", Offset="0x106910C")]
		[FieldOffset(Offset="0x20")]
		public CinemachinePathBase.Appearance m_Appearance;

		[FieldOffset(Offset="0x28")]
		private float[] m_DistanceToPos;

		[FieldOffset(Offset="0x30")]
		private float[] m_PosToDistance;

		[FieldOffset(Offset="0x38")]
		private int m_CachedSampleSteps;

		[FieldOffset(Offset="0x3C")]
		private float m_PathLength;

		[FieldOffset(Offset="0x40")]
		private float m_cachedPosStepSize;

		[FieldOffset(Offset="0x44")]
		private float m_cachedDistanceStepSize;

		public abstract int DistanceCacheSampleStepsPerSegment
		{
			get;
		}

		public abstract bool Looped
		{
			get;
		}

		public abstract float MaxPos
		{
			get;
		}

		public abstract float MinPos
		{
			get;
		}

		public float PathLength
		{
			[Address(RVA="0x1451790", Offset="0x1451790", VA="0x1451790")]
			get
			{
				return new float();
			}
		}

		[Address(RVA="0x145112C", Offset="0x145112C", VA="0x145112C")]
		protected CinemachinePathBase()
		{
		}

		[Address(RVA="0x1451B94", Offset="0x1451B94", VA="0x1451B94")]
		public bool DistanceCacheIsValid()
		{
			return new bool();
		}

		public abstract Quaternion EvaluateOrientation(float pos);

		[Address(RVA="0x1451B50", Offset="0x1451B50", VA="0x1451B50")]
		public Quaternion EvaluateOrientationAtUnit(float pos, CinemachinePathBase.PositionUnits units)
		{
			return new Quaternion();
		}

		public abstract Vector3 EvaluatePosition(float pos);

		[Address(RVA="0x14518E8", Offset="0x14518E8", VA="0x14518E8")]
		public Vector3 EvaluatePositionAtUnit(float pos, CinemachinePathBase.PositionUnits units)
		{
			return new Vector3();
		}

		public abstract Vector3 EvaluateTangent(float pos);

		[Address(RVA="0x1451B18", Offset="0x1451B18", VA="0x1451B18")]
		public Vector3 EvaluateTangentAtUnit(float pos, CinemachinePathBase.PositionUnits units)
		{
			return new Vector3();
		}

		[Address(RVA="0x14512A0", Offset="0x14512A0", VA="0x14512A0", Slot="11")]
		public virtual float FindClosestPoint(Vector3 p, int startSegment, int searchRadius, int stepsPerSegment)
		{
			return new float();
		}

		[Address(RVA="0x1451FD8", Offset="0x1451FD8", VA="0x1451FD8")]
		public float GetPathDistanceFromPosition(float pos)
		{
			return new float();
		}

		[Address(RVA="0x1451920", Offset="0x1451920", VA="0x1451920")]
		public float GetPathPositionFromDistance(float distance)
		{
			return new float();
		}

		[Address(RVA="0x1451B88", Offset="0x1451B88", VA="0x1451B88", Slot="14")]
		public virtual void InvalidateDistanceCache()
		{
		}

		[Address(RVA="0x1451778", Offset="0x1451778", VA="0x1451778")]
		public float MaxUnit(CinemachinePathBase.PositionUnits units)
		{
			return new float();
		}

		[Address(RVA="0x145175C", Offset="0x145175C", VA="0x145175C")]
		public float MinUnit(CinemachinePathBase.PositionUnits units)
		{
			return new float();
		}

		[Address(RVA="0x145180C", Offset="0x145180C", VA="0x145180C")]
		public float NormalizePathDistance(float distance)
		{
			return new float();
		}

		[Address(RVA="0x1451198", Offset="0x1451198", VA="0x1451198", Slot="7")]
		public virtual float NormalizePos(float pos)
		{
			return new float();
		}

		[Address(RVA="0x14517F4", Offset="0x14517F4", VA="0x14517F4", Slot="12")]
		public virtual float NormalizeUnit(float pos, CinemachinePathBase.PositionUnits units)
		{
			return new float();
		}

		[Address(RVA="0x1451C28", Offset="0x1451C28", VA="0x1451C28")]
		private void ResamplePath(int stepsPerSegment)
		{
		}

		[Attribute(Name="DocumentationSortingAttribute", RVA="0x10514B4", Offset="0x10514B4")]
		[Serializable]
		public class Appearance
		{
			[Attribute(Name="TooltipAttribute", RVA="0x106D664", Offset="0x106D664")]
			[FieldOffset(Offset="0x10")]
			public Color pathColor;

			[Attribute(Name="TooltipAttribute", RVA="0x106D69C", Offset="0x106D69C")]
			[FieldOffset(Offset="0x20")]
			public Color inactivePathColor;

			[Attribute(Name="RangeAttribute", RVA="0x106D6D4", Offset="0x106D6D4")]
			[Attribute(Name="TooltipAttribute", RVA="0x106D6D4", Offset="0x106D6D4")]
			[FieldOffset(Offset="0x30")]
			public float width;

			[Address(RVA="0x14521A4", Offset="0x14521A4", VA="0x14521A4")]
			public Appearance()
			{
			}
		}

		public enum PositionUnits
		{
			[FieldOffset(Offset="0x0")]
			PathUnits,
			[FieldOffset(Offset="0x0")]
			Distance
		}
	}
}