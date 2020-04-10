using Cinemachine.Utility;
using Il2CppDummyDll;
using System;
using UnityEngine;

namespace Cinemachine
{
	[Attribute(Name="AddComponentMenu", RVA="0x104A414", Offset="0x104A414")]
	[Attribute(Name="DocumentationSortingAttribute", RVA="0x104A414", Offset="0x104A414")]
	[Attribute(Name="ExecuteInEditMode", RVA="0x104A414", Offset="0x104A414")]
	[Attribute(Name="RequireComponent", RVA="0x104A414", Offset="0x104A414")]
	[Attribute(Name="SaveDuringPlayAttribute", RVA="0x104A414", Offset="0x104A414")]
	public class CinemachineComposer : CinemachineComponentBase
	{
		[Attribute(Name="HideInInspector", RVA="0x1067460", Offset="0x1067460")]
		[Attribute(Name="NoSaveDuringPlayAttribute", RVA="0x1067460", Offset="0x1067460")]
		[FieldOffset(Offset="0x20")]
		public Action OnGUICallback;

		[Attribute(Name="TooltipAttribute", RVA="0x1067498", Offset="0x1067498")]
		[FieldOffset(Offset="0x28")]
		public Vector3 m_TrackedObjectOffset;

		[Attribute(Name="RangeAttribute", RVA="0x10674D0", Offset="0x10674D0")]
		[Attribute(Name="TooltipAttribute", RVA="0x10674D0", Offset="0x10674D0")]
		[FieldOffset(Offset="0x34")]
		public float m_LookaheadTime;

		[Attribute(Name="RangeAttribute", RVA="0x1067524", Offset="0x1067524")]
		[Attribute(Name="TooltipAttribute", RVA="0x1067524", Offset="0x1067524")]
		[FieldOffset(Offset="0x38")]
		public float m_LookaheadSmoothing;

		[Attribute(Name="RangeAttribute", RVA="0x1067578", Offset="0x1067578")]
		[Attribute(Name="SpaceAttribute", RVA="0x1067578", Offset="0x1067578")]
		[Attribute(Name="TooltipAttribute", RVA="0x1067578", Offset="0x1067578")]
		[FieldOffset(Offset="0x3C")]
		public float m_HorizontalDamping;

		[Attribute(Name="RangeAttribute", RVA="0x10675DC", Offset="0x10675DC")]
		[Attribute(Name="TooltipAttribute", RVA="0x10675DC", Offset="0x10675DC")]
		[FieldOffset(Offset="0x40")]
		public float m_VerticalDamping;

		[Attribute(Name="RangeAttribute", RVA="0x1067630", Offset="0x1067630")]
		[Attribute(Name="SpaceAttribute", RVA="0x1067630", Offset="0x1067630")]
		[Attribute(Name="TooltipAttribute", RVA="0x1067630", Offset="0x1067630")]
		[FieldOffset(Offset="0x44")]
		public float m_ScreenX;

		[Attribute(Name="RangeAttribute", RVA="0x1067694", Offset="0x1067694")]
		[Attribute(Name="TooltipAttribute", RVA="0x1067694", Offset="0x1067694")]
		[FieldOffset(Offset="0x48")]
		public float m_ScreenY;

		[Attribute(Name="RangeAttribute", RVA="0x10676E8", Offset="0x10676E8")]
		[Attribute(Name="TooltipAttribute", RVA="0x10676E8", Offset="0x10676E8")]
		[FieldOffset(Offset="0x4C")]
		public float m_DeadZoneWidth;

		[Attribute(Name="RangeAttribute", RVA="0x106773C", Offset="0x106773C")]
		[Attribute(Name="TooltipAttribute", RVA="0x106773C", Offset="0x106773C")]
		[FieldOffset(Offset="0x50")]
		public float m_DeadZoneHeight;

		[Attribute(Name="RangeAttribute", RVA="0x1067790", Offset="0x1067790")]
		[Attribute(Name="TooltipAttribute", RVA="0x1067790", Offset="0x1067790")]
		[FieldOffset(Offset="0x54")]
		public float m_SoftZoneWidth;

		[Attribute(Name="RangeAttribute", RVA="0x10677E4", Offset="0x10677E4")]
		[Attribute(Name="TooltipAttribute", RVA="0x10677E4", Offset="0x10677E4")]
		[FieldOffset(Offset="0x58")]
		public float m_SoftZoneHeight;

		[Attribute(Name="RangeAttribute", RVA="0x1067838", Offset="0x1067838")]
		[Attribute(Name="TooltipAttribute", RVA="0x1067838", Offset="0x1067838")]
		[FieldOffset(Offset="0x5C")]
		public float m_BiasX;

		[Attribute(Name="RangeAttribute", RVA="0x106788C", Offset="0x106788C")]
		[Attribute(Name="TooltipAttribute", RVA="0x106788C", Offset="0x106788C")]
		[FieldOffset(Offset="0x60")]
		public float m_BiasY;

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10678E0", Offset="0x10678E0")]
		[FieldOffset(Offset="0x64")]
		private Vector3 <TrackedPoint>k__BackingField;

		[FieldOffset(Offset="0x70")]
		private Vector3 m_CameraPosPrevFrame;

		[FieldOffset(Offset="0x7C")]
		private Vector3 m_LookAtPrevFrame;

		[FieldOffset(Offset="0x88")]
		private Vector2 m_ScreenOffsetPrevFrame;

		[FieldOffset(Offset="0x90")]
		private Quaternion m_CameraOrientationPrevFrame;

		[FieldOffset(Offset="0xA0")]
		private PositionPredictor m_Predictor;

		public Rect HardGuideRect
		{
			[Address(RVA="0x1D4658C", Offset="0x1D4658C", VA="0x1D4658C")]
			get
			{
				return new Rect();
			}
			[Address(RVA="0x1D467BC", Offset="0x1D467BC", VA="0x1D467BC")]
			set
			{
			}
		}

		public override bool IsValid
		{
			[Address(RVA="0x1D4546C", Offset="0x1D4546C", VA="0x1D4546C", Slot="4")]
			get
			{
				return new bool();
			}
		}

		public Rect SoftGuideRect
		{
			[Address(RVA="0x1D45EC8", Offset="0x1D45EC8", VA="0x1D45EC8")]
			get
			{
				return new Rect();
			}
			[Address(RVA="0x1D46690", Offset="0x1D46690", VA="0x1D46690")]
			set
			{
			}
		}

		public override CinemachineCore.Stage Stage
		{
			[Address(RVA="0x1D45508", Offset="0x1D45508", VA="0x1D45508", Slot="6")]
			get
			{
				return new CinemachineCore.Stage();
			}
		}

		public Vector3 TrackedPoint
		{
			[Address(RVA="0x1D45510", Offset="0x1D45510", VA="0x1D45510")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108AC34", Offset="0x108AC34")]
			get
			{
				return new Vector3();
			}
			[Address(RVA="0x1D4551C", Offset="0x1D4551C", VA="0x1D4551C")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108AC44", Offset="0x108AC44")]
			private set
			{
			}
		}

		[Address(RVA="0x1D46BEC", Offset="0x1D46BEC", VA="0x1D46BEC")]
		public CinemachineComposer()
		{
		}

		[Address(RVA="0x1D469E0", Offset="0x1D469E0", VA="0x1D469E0")]
		private bool ClampVerticalBounds(ref Rect r, Vector3 dir, Vector3 up, float fov)
		{
			return new bool();
		}

		[Address(RVA="0x1D45528", Offset="0x1D45528", VA="0x1D45528", Slot="9")]
		protected virtual Vector3 GetLookAtPointAndSetTrackedPoint(Vector3 lookAt)
		{
			return new Vector3();
		}

		[Address(RVA="0x1D457BC", Offset="0x1D457BC", VA="0x1D457BC", Slot="7")]
		public override void MutateCameraState(ref CameraState curState, float deltaTime)
		{
		}

		[Address(RVA="0x1D4575C", Offset="0x1D4575C", VA="0x1D4575C", Slot="5")]
		public override void PrePipelineMutateCameraState(ref CameraState curState)
		{
		}

		[Address(RVA="0x1D4633C", Offset="0x1D4633C", VA="0x1D4633C")]
		private bool RotateToScreenBounds(ref CameraState state, Rect screenRect, ref Quaternion rigOrientation, float fov, float fovH, float deltaTime)
		{
			return new bool();
		}

		[Address(RVA="0x1D45F14", Offset="0x1D45F14", VA="0x1D45F14")]
		private Rect ScreenToFOV(Rect rScreen, float fov, float fovH, float aspect)
		{
			return new Rect();
		}
	}
}