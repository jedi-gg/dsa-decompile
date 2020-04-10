using Il2CppDummyDll;
using System;
using UnityEngine;

namespace Cinemachine
{
	[Attribute(Name="AddComponentMenu", RVA="0x104A594", Offset="0x104A594")]
	[Attribute(Name="DocumentationSortingAttribute", RVA="0x104A594", Offset="0x104A594")]
	[Attribute(Name="ExecuteInEditMode", RVA="0x104A594", Offset="0x104A594")]
	[Attribute(Name="RequireComponent", RVA="0x104A594", Offset="0x104A594")]
	[Attribute(Name="SaveDuringPlayAttribute", RVA="0x104A594", Offset="0x104A594")]
	public class CinemachineGroupComposer : CinemachineComposer
	{
		[Attribute(Name="SpaceAttribute", RVA="0x1068180", Offset="0x1068180")]
		[Attribute(Name="TooltipAttribute", RVA="0x1068180", Offset="0x1068180")]
		[FieldOffset(Offset="0xA8")]
		public float m_GroupFramingSize;

		[Attribute(Name="TooltipAttribute", RVA="0x10681CC", Offset="0x10681CC")]
		[FieldOffset(Offset="0xAC")]
		public CinemachineGroupComposer.FramingMode m_FramingMode;

		[Attribute(Name="RangeAttribute", RVA="0x1068204", Offset="0x1068204")]
		[Attribute(Name="TooltipAttribute", RVA="0x1068204", Offset="0x1068204")]
		[FieldOffset(Offset="0xB0")]
		public float m_FrameDamping;

		[Attribute(Name="TooltipAttribute", RVA="0x1068258", Offset="0x1068258")]
		[FieldOffset(Offset="0xB4")]
		public CinemachineGroupComposer.AdjustmentMode m_AdjustmentMode;

		[Attribute(Name="TooltipAttribute", RVA="0x1068290", Offset="0x1068290")]
		[FieldOffset(Offset="0xB8")]
		public float m_DollyDamping;

		[FieldOffset(Offset="0xBC")]
		private Vector3 m_lastPositionCorrection;

		[Attribute(Name="TooltipAttribute", RVA="0x10682C8", Offset="0x10682C8")]
		[FieldOffset(Offset="0xC8")]
		public float m_MaxDollyIn;

		[Attribute(Name="TooltipAttribute", RVA="0x1068300", Offset="0x1068300")]
		[FieldOffset(Offset="0xCC")]
		public float m_MaxDollyOut;

		[Attribute(Name="TooltipAttribute", RVA="0x1068338", Offset="0x1068338")]
		[FieldOffset(Offset="0xD0")]
		public float m_MinimumDistance;

		[Attribute(Name="TooltipAttribute", RVA="0x1068370", Offset="0x1068370")]
		[FieldOffset(Offset="0xD4")]
		public float m_MaximumDistance;

		[Attribute(Name="RangeAttribute", RVA="0x10683A8", Offset="0x10683A8")]
		[Attribute(Name="TooltipAttribute", RVA="0x10683A8", Offset="0x10683A8")]
		[FieldOffset(Offset="0xD8")]
		public float m_MinimumFOV;

		[Attribute(Name="RangeAttribute", RVA="0x1068400", Offset="0x1068400")]
		[Attribute(Name="TooltipAttribute", RVA="0x1068400", Offset="0x1068400")]
		[FieldOffset(Offset="0xDC")]
		public float m_MaximumFOV;

		[Attribute(Name="TooltipAttribute", RVA="0x1068458", Offset="0x1068458")]
		[FieldOffset(Offset="0xE0")]
		public float m_MinimumOrthoSize;

		[Attribute(Name="TooltipAttribute", RVA="0x1068490", Offset="0x1068490")]
		[FieldOffset(Offset="0xE4")]
		public float m_MaximumOrthoSize;

		[FieldOffset(Offset="0xE8")]
		private float m_prevTargetHeight;

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10684C8", Offset="0x10684C8")]
		[FieldOffset(Offset="0xEC")]
		private Bounds <m_LastBounds>k__BackingField;

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10684D8", Offset="0x10684D8")]
		[FieldOffset(Offset="0x104")]
		private Matrix4x4 <m_lastBoundsMatrix>k__BackingField;

		public Bounds m_LastBounds
		{
			[Address(RVA="0x1D5154C", Offset="0x1D5154C", VA="0x1D5154C")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108ACB4", Offset="0x108ACB4")]
			get
			{
				return new Bounds();
			}
			[Address(RVA="0x1D51538", Offset="0x1D51538", VA="0x1D51538")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108ACC4", Offset="0x108ACC4")]
			private set
			{
			}
		}

		public Matrix4x4 m_lastBoundsMatrix
		{
			[Address(RVA="0x1D51504", Offset="0x1D51504", VA="0x1D51504")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108ACD4", Offset="0x108ACD4")]
			get
			{
				return new Matrix4x4();
			}
			[Address(RVA="0x1D514D8", Offset="0x1D514D8", VA="0x1D514D8")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108ACE4", Offset="0x108ACE4")]
			private set
			{
			}
		}

		public CinemachineTargetGroup TargetGroup
		{
			[Address(RVA="0x1D50BA8", Offset="0x1D50BA8", VA="0x1D50BA8")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1D51774", Offset="0x1D51774", VA="0x1D51774")]
		public CinemachineGroupComposer()
		{
		}

		[Address(RVA="0x1D51560", Offset="0x1D51560", VA="0x1D51560")]
		private float GetTargetHeight(Bounds b)
		{
			return new float();
		}

		[Address(RVA="0x1D50C54", Offset="0x1D50C54", VA="0x1D50C54", Slot="7")]
		public override void MutateCameraState(ref CameraState curState, float deltaTime)
		{
		}

		[Address(RVA="0x1D50A78", Offset="0x1D50A78", VA="0x1D50A78")]
		private void OnValidate()
		{
		}

		public enum AdjustmentMode
		{
			[FieldOffset(Offset="0x0")]
			ZoomOnly,
			[FieldOffset(Offset="0x0")]
			DollyOnly,
			[FieldOffset(Offset="0x0")]
			DollyThenZoom
		}

		[Attribute(Name="DocumentationSortingAttribute", RVA="0x10513C8", Offset="0x10513C8")]
		public enum FramingMode
		{
			[FieldOffset(Offset="0x0")]
			Horizontal,
			[FieldOffset(Offset="0x0")]
			Vertical,
			[FieldOffset(Offset="0x0")]
			HorizontalAndVertical
		}
	}
}