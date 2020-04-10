using Il2CppDummyDll;
using System;
using UnityEngine;

namespace Cinemachine
{
	[Attribute(Name="AddComponentMenu", RVA="0x104A7B4", Offset="0x104A7B4")]
	[Attribute(Name="DocumentationSortingAttribute", RVA="0x104A7B4", Offset="0x104A7B4")]
	[Attribute(Name="RequireComponent", RVA="0x104A7B4", Offset="0x104A7B4")]
	[Attribute(Name="SaveDuringPlayAttribute", RVA="0x104A7B4", Offset="0x104A7B4")]
	public class CinemachineOrbitalTransposer : CinemachineTransposer
	{
		[Attribute(Name="SpaceAttribute", RVA="0x10684E8", Offset="0x10684E8")]
		[Attribute(Name="TooltipAttribute", RVA="0x10684E8", Offset="0x10684E8")]
		[FieldOffset(Offset="0x80")]
		public CinemachineOrbitalTransposer.Heading m_Heading;

		[Attribute(Name="TooltipAttribute", RVA="0x1068534", Offset="0x1068534")]
		[FieldOffset(Offset="0x8C")]
		public CinemachineOrbitalTransposer.Recentering m_RecenterToTargetHeading;

		[Attribute(Name="TooltipAttribute", RVA="0x106856C", Offset="0x106856C")]
		[FieldOffset(Offset="0xA0")]
		public AxisState m_XAxis;

		[Attribute(Name="FormerlySerializedAsAttribute", RVA="0x10685A4", Offset="0x10685A4")]
		[Attribute(Name="HideInInspector", RVA="0x10685A4", Offset="0x10685A4")]
		[FieldOffset(Offset="0xD0")]
		[SerializeField]
		private float m_LegacyRadius;

		[Attribute(Name="FormerlySerializedAsAttribute", RVA="0x1068600", Offset="0x1068600")]
		[Attribute(Name="HideInInspector", RVA="0x1068600", Offset="0x1068600")]
		[FieldOffset(Offset="0xD4")]
		[SerializeField]
		private float m_LegacyHeightOffset;

		[Attribute(Name="FormerlySerializedAsAttribute", RVA="0x106865C", Offset="0x106865C")]
		[Attribute(Name="HideInInspector", RVA="0x106865C", Offset="0x106865C")]
		[FieldOffset(Offset="0xD8")]
		[SerializeField]
		private float m_LegacyHeadingBias;

		[Attribute(Name="HideInInspector", RVA="0x10686B8", Offset="0x10686B8")]
		[Attribute(Name="NoSaveDuringPlayAttribute", RVA="0x10686B8", Offset="0x10686B8")]
		[FieldOffset(Offset="0xDC")]
		public bool m_HeadingIsSlave;

		[FieldOffset(Offset="0xE0")]
		internal CinemachineOrbitalTransposer.UpdateHeadingDelegate HeadingUpdater;

		[FieldOffset(Offset="0xE8")]
		private float mLastHeadingAxisInputTime;

		[FieldOffset(Offset="0xEC")]
		private float mHeadingRecenteringVelocity;

		[FieldOffset(Offset="0xF0")]
		private Vector3 mLastTargetPosition;

		[FieldOffset(Offset="0x100")]
		private CinemachineOrbitalTransposer.HeadingTracker mHeadingTracker;

		[FieldOffset(Offset="0x108")]
		private Rigidbody mTargetRigidBody;

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10686F0", Offset="0x10686F0")]
		[FieldOffset(Offset="0x110")]
		private Transform <PreviousTarget>k__BackingField;

		[FieldOffset(Offset="0x118")]
		private Quaternion mHeadingPrevFrame;

		[FieldOffset(Offset="0x128")]
		private Vector3 mOffsetPrevFrame;

		private Transform PreviousTarget
		{
			[Address(RVA="0x1D52ED8", Offset="0x1D52ED8", VA="0x1D52ED8")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108ACF4", Offset="0x108ACF4")]
			get
			{
				return null;
			}
			[Address(RVA="0x1D52ED0", Offset="0x1D52ED0", VA="0x1D52ED0")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108AD04", Offset="0x108AD04")]
			set
			{
			}
		}

		[Address(RVA="0x1D53790", Offset="0x1D53790", VA="0x1D53790")]
		public CinemachineOrbitalTransposer()
		{
		}

		[Address(RVA="0x1D535D8", Offset="0x1D535D8", VA="0x1D535D8")]
		private static string GetFullName(GameObject current)
		{
			return null;
		}

		[Address(RVA="0x1D52994", Offset="0x1D52994", VA="0x1D52994")]
		private float GetTargetHeading(float currentHeading, Quaternion targetOrientation, float deltaTime)
		{
			return new float();
		}

		[Address(RVA="0x1D52EE0", Offset="0x1D52EE0", VA="0x1D52EE0", Slot="7")]
		public override void MutateCameraState(ref CameraState curState, float deltaTime)
		{
		}

		[Address(RVA="0x1D52E4C", Offset="0x1D52E4C", VA="0x1D52E4C")]
		private void OnEnable()
		{
		}

		[Address(RVA="0x1D53474", Offset="0x1D53474", VA="0x1D53474", Slot="8")]
		public override void OnPositionDragged(Vector3 delta)
		{
		}

		[Address(RVA="0x1D528A4", Offset="0x1D528A4", VA="0x1D528A4", Slot="9")]
		protected override void OnValidate()
		{
		}

		[Address(RVA="0x1D50768", Offset="0x1D50768", VA="0x1D50768")]
		public float UpdateHeading(float deltaTime, Vector3 up, ref AxisState axis)
		{
			return new float();
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1051418", Offset="0x1051418")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static CinemachineOrbitalTransposer.<>c <>9;

			[FieldOffset(Offset="0x8")]
			public static CinemachineOrbitalTransposer.UpdateHeadingDelegate <>9__30_0;

			[Address(RVA="0x144E868", Offset="0x144E868", VA="0x144E868")]
			static <>c()
			{
			}

			[Address(RVA="0x144E8CC", Offset="0x144E8CC", VA="0x144E8CC")]
			public <>c()
			{
			}

			[Address(RVA="0x144E8D4", Offset="0x144E8D4", VA="0x144E8D4")]
			internal float <.ctor>b__30_0(CinemachineOrbitalTransposer orbital, float deltaTime, Vector3 up)
			{
				return new float();
			}
		}

		[Attribute(Name="DocumentationSortingAttribute", RVA="0x10513E4", Offset="0x10513E4")]
		[Serializable]
		public struct Heading
		{
			[Attribute(Name="TooltipAttribute", RVA="0x106D26C", Offset="0x106D26C")]
			[FieldOffset(Offset="0x0")]
			public CinemachineOrbitalTransposer.Heading.HeadingDefinition m_HeadingDefinition;

			[Attribute(Name="RangeAttribute", RVA="0x106D2A4", Offset="0x106D2A4")]
			[Attribute(Name="TooltipAttribute", RVA="0x106D2A4", Offset="0x106D2A4")]
			[FieldOffset(Offset="0x4")]
			public int m_VelocityFilterStrength;

			[Attribute(Name="RangeAttribute", RVA="0x106D2F8", Offset="0x106D2F8")]
			[Attribute(Name="TooltipAttribute", RVA="0x106D2F8", Offset="0x106D2F8")]
			[FieldOffset(Offset="0x8")]
			public float m_HeadingBias;

			[Address(RVA="0xF00F38", Offset="0xF00F38", VA="0xF00F38")]
			public Heading(CinemachineOrbitalTransposer.Heading.HeadingDefinition def, int filterStrength, float bias)
			{
			}

			[Attribute(Name="DocumentationSortingAttribute", RVA="0x10516B8", Offset="0x10516B8")]
			public enum HeadingDefinition
			{
				[FieldOffset(Offset="0x0")]
				PositionDelta,
				[FieldOffset(Offset="0x0")]
				Velocity,
				[FieldOffset(Offset="0x0")]
				TargetForward,
				[FieldOffset(Offset="0x0")]
				WorldForward
			}
		}

		private class HeadingTracker
		{
			[FieldOffset(Offset="0x10")]
			private CinemachineOrbitalTransposer.HeadingTracker.Item[] mHistory;

			[FieldOffset(Offset="0x18")]
			private int mTop;

			[FieldOffset(Offset="0x1C")]
			private int mBottom;

			[FieldOffset(Offset="0x20")]
			private int mCount;

			[FieldOffset(Offset="0x24")]
			private Vector3 mHeadingSum;

			[FieldOffset(Offset="0x30")]
			private float mWeightSum;

			[FieldOffset(Offset="0x34")]
			private float mWeightTime;

			[FieldOffset(Offset="0x38")]
			private Vector3 mLastGoodHeading;

			[FieldOffset(Offset="0x0")]
			private static float mDecayExponent;

			public int FilterSize
			{
				[Address(RVA="0x144EAC0", Offset="0x144EAC0", VA="0x144EAC0")]
				get
				{
					return new int();
				}
			}

			[Address(RVA="0x144E94C", Offset="0x144E94C", VA="0x144E94C")]
			public HeadingTracker(int filterSize)
			{
			}

			[Address(RVA="0x144EB6C", Offset="0x144EB6C", VA="0x144EB6C")]
			public void Add(Vector3 velocity)
			{
			}

			[Address(RVA="0x144EA44", Offset="0x144EA44", VA="0x144EA44")]
			private void ClearHistory()
			{
			}

			[Address(RVA="0x144EAEC", Offset="0x144EAEC", VA="0x144EAEC")]
			private static float Decay(float time)
			{
				return new float();
			}

			[Address(RVA="0x144EF10", Offset="0x144EF10", VA="0x144EF10")]
			public void DecayHistory()
			{
			}

			[Address(RVA="0x144EFF8", Offset="0x144EFF8", VA="0x144EFF8")]
			public Vector3 GetReliableHeading()
			{
				return new Vector3();
			}

			[Address(RVA="0x144ED4C", Offset="0x144ED4C", VA="0x144ED4C")]
			private void PopBottom()
			{
			}

			private struct Item
			{
				[FieldOffset(Offset="0x0")]
				public Vector3 velocity;

				[FieldOffset(Offset="0xC")]
				public float weight;

				[FieldOffset(Offset="0x10")]
				public float time;
			}
		}

		[Attribute(Name="DocumentationSortingAttribute", RVA="0x1051400", Offset="0x1051400")]
		[Serializable]
		public struct Recentering
		{
			[Attribute(Name="TooltipAttribute", RVA="0x106D354", Offset="0x106D354")]
			[FieldOffset(Offset="0x0")]
			public bool m_enabled;

			[Attribute(Name="TooltipAttribute", RVA="0x106D38C", Offset="0x106D38C")]
			[FieldOffset(Offset="0x4")]
			public float m_RecenterWaitTime;

			[Attribute(Name="TooltipAttribute", RVA="0x106D3C4", Offset="0x106D3C4")]
			[FieldOffset(Offset="0x8")]
			public float m_RecenteringTime;

			[Attribute(Name="FormerlySerializedAsAttribute", RVA="0x106D3FC", Offset="0x106D3FC")]
			[Attribute(Name="HideInInspector", RVA="0x106D3FC", Offset="0x106D3FC")]
			[FieldOffset(Offset="0xC")]
			[SerializeField]
			private int m_LegacyHeadingDefinition;

			[Attribute(Name="FormerlySerializedAsAttribute", RVA="0x106D458", Offset="0x106D458")]
			[Attribute(Name="HideInInspector", RVA="0x106D458", Offset="0x106D458")]
			[FieldOffset(Offset="0x10")]
			[SerializeField]
			private int m_LegacyVelocityFilterStrength;

			[Address(RVA="0xF00FA8", Offset="0xF00FA8", VA="0xF00FA8")]
			public Recentering(bool enabled, float recenterWaitTime, float recenteringSpeed)
			{
			}

			[Address(RVA="0xF00FC8", Offset="0xF00FC8", VA="0xF00FC8")]
			internal bool LegacyUpgrade(ref CinemachineOrbitalTransposer.Heading.HeadingDefinition heading, ref int velocityFilter)
			{
				return new bool();
			}

			[Address(RVA="0xF00FC0", Offset="0xF00FC0", VA="0xF00FC0")]
			public void Validate()
			{
			}
		}

		internal delegate float UpdateHeadingDelegate(CinemachineOrbitalTransposer orbital, float deltaTime, Vector3 up);
	}
}