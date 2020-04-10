using Cinemachine.Utility;
using Il2CppDummyDll;
using System;
using UnityEngine;

namespace Cinemachine
{
	[Attribute(Name="AddComponentMenu", RVA="0x104A4D4", Offset="0x104A4D4")]
	[Attribute(Name="DocumentationSortingAttribute", RVA="0x104A4D4", Offset="0x104A4D4")]
	[Attribute(Name="ExecuteInEditMode", RVA="0x104A4D4", Offset="0x104A4D4")]
	[Attribute(Name="RequireComponent", RVA="0x104A4D4", Offset="0x104A4D4")]
	[Attribute(Name="SaveDuringPlayAttribute", RVA="0x104A4D4", Offset="0x104A4D4")]
	public class CinemachineFramingTransposer : CinemachineComponentBase
	{
		[Attribute(Name="HideInInspector", RVA="0x10678F0", Offset="0x10678F0")]
		[Attribute(Name="NoSaveDuringPlayAttribute", RVA="0x10678F0", Offset="0x10678F0")]
		[FieldOffset(Offset="0x20")]
		public Action OnGUICallback;

		[Attribute(Name="RangeAttribute", RVA="0x1067928", Offset="0x1067928")]
		[Attribute(Name="TooltipAttribute", RVA="0x1067928", Offset="0x1067928")]
		[FieldOffset(Offset="0x28")]
		public float m_LookaheadTime;

		[Attribute(Name="RangeAttribute", RVA="0x106797C", Offset="0x106797C")]
		[Attribute(Name="TooltipAttribute", RVA="0x106797C", Offset="0x106797C")]
		[FieldOffset(Offset="0x2C")]
		public float m_LookaheadSmoothing;

		[Attribute(Name="RangeAttribute", RVA="0x10679D0", Offset="0x10679D0")]
		[Attribute(Name="TooltipAttribute", RVA="0x10679D0", Offset="0x10679D0")]
		[FieldOffset(Offset="0x30")]
		public float m_XDamping;

		[Attribute(Name="RangeAttribute", RVA="0x1067A24", Offset="0x1067A24")]
		[Attribute(Name="TooltipAttribute", RVA="0x1067A24", Offset="0x1067A24")]
		[FieldOffset(Offset="0x34")]
		public float m_YDamping;

		[Attribute(Name="RangeAttribute", RVA="0x1067A78", Offset="0x1067A78")]
		[Attribute(Name="TooltipAttribute", RVA="0x1067A78", Offset="0x1067A78")]
		[FieldOffset(Offset="0x38")]
		public float m_ZDamping;

		[Attribute(Name="RangeAttribute", RVA="0x1067ACC", Offset="0x1067ACC")]
		[Attribute(Name="SpaceAttribute", RVA="0x1067ACC", Offset="0x1067ACC")]
		[Attribute(Name="TooltipAttribute", RVA="0x1067ACC", Offset="0x1067ACC")]
		[FieldOffset(Offset="0x3C")]
		public float m_ScreenX;

		[Attribute(Name="RangeAttribute", RVA="0x1067B30", Offset="0x1067B30")]
		[Attribute(Name="TooltipAttribute", RVA="0x1067B30", Offset="0x1067B30")]
		[FieldOffset(Offset="0x40")]
		public float m_ScreenY;

		[Attribute(Name="TooltipAttribute", RVA="0x1067B84", Offset="0x1067B84")]
		[FieldOffset(Offset="0x44")]
		public float m_CameraDistance;

		[Attribute(Name="RangeAttribute", RVA="0x1067BBC", Offset="0x1067BBC")]
		[Attribute(Name="SpaceAttribute", RVA="0x1067BBC", Offset="0x1067BBC")]
		[Attribute(Name="TooltipAttribute", RVA="0x1067BBC", Offset="0x1067BBC")]
		[FieldOffset(Offset="0x48")]
		public float m_DeadZoneWidth;

		[Attribute(Name="RangeAttribute", RVA="0x1067C20", Offset="0x1067C20")]
		[Attribute(Name="TooltipAttribute", RVA="0x1067C20", Offset="0x1067C20")]
		[FieldOffset(Offset="0x4C")]
		public float m_DeadZoneHeight;

		[Attribute(Name="FormerlySerializedAsAttribute", RVA="0x1067C74", Offset="0x1067C74")]
		[Attribute(Name="TooltipAttribute", RVA="0x1067C74", Offset="0x1067C74")]
		[FieldOffset(Offset="0x50")]
		public float m_DeadZoneDepth;

		[Attribute(Name="SpaceAttribute", RVA="0x1067CD4", Offset="0x1067CD4")]
		[Attribute(Name="TooltipAttribute", RVA="0x1067CD4", Offset="0x1067CD4")]
		[FieldOffset(Offset="0x54")]
		public bool m_UnlimitedSoftZone;

		[Attribute(Name="RangeAttribute", RVA="0x1067D20", Offset="0x1067D20")]
		[Attribute(Name="TooltipAttribute", RVA="0x1067D20", Offset="0x1067D20")]
		[FieldOffset(Offset="0x58")]
		public float m_SoftZoneWidth;

		[Attribute(Name="RangeAttribute", RVA="0x1067D74", Offset="0x1067D74")]
		[Attribute(Name="TooltipAttribute", RVA="0x1067D74", Offset="0x1067D74")]
		[FieldOffset(Offset="0x5C")]
		public float m_SoftZoneHeight;

		[Attribute(Name="RangeAttribute", RVA="0x1067DC8", Offset="0x1067DC8")]
		[Attribute(Name="TooltipAttribute", RVA="0x1067DC8", Offset="0x1067DC8")]
		[FieldOffset(Offset="0x60")]
		public float m_BiasX;

		[Attribute(Name="RangeAttribute", RVA="0x1067E1C", Offset="0x1067E1C")]
		[Attribute(Name="TooltipAttribute", RVA="0x1067E1C", Offset="0x1067E1C")]
		[FieldOffset(Offset="0x64")]
		public float m_BiasY;

		[Attribute(Name="FormerlySerializedAsAttribute", RVA="0x1067E70", Offset="0x1067E70")]
		[Attribute(Name="SpaceAttribute", RVA="0x1067E70", Offset="0x1067E70")]
		[Attribute(Name="TooltipAttribute", RVA="0x1067E70", Offset="0x1067E70")]
		[FieldOffset(Offset="0x68")]
		public CinemachineFramingTransposer.FramingMode m_GroupFramingMode;

		[Attribute(Name="TooltipAttribute", RVA="0x1067EE0", Offset="0x1067EE0")]
		[FieldOffset(Offset="0x6C")]
		public CinemachineFramingTransposer.AdjustmentMode m_AdjustmentMode;

		[Attribute(Name="TooltipAttribute", RVA="0x1067F18", Offset="0x1067F18")]
		[FieldOffset(Offset="0x70")]
		public float m_GroupFramingSize;

		[Attribute(Name="TooltipAttribute", RVA="0x1067F50", Offset="0x1067F50")]
		[FieldOffset(Offset="0x74")]
		public float m_MaxDollyIn;

		[Attribute(Name="TooltipAttribute", RVA="0x1067F88", Offset="0x1067F88")]
		[FieldOffset(Offset="0x78")]
		public float m_MaxDollyOut;

		[Attribute(Name="TooltipAttribute", RVA="0x1067FC0", Offset="0x1067FC0")]
		[FieldOffset(Offset="0x7C")]
		public float m_MinimumDistance;

		[Attribute(Name="TooltipAttribute", RVA="0x1067FF8", Offset="0x1067FF8")]
		[FieldOffset(Offset="0x80")]
		public float m_MaximumDistance;

		[Attribute(Name="RangeAttribute", RVA="0x1068030", Offset="0x1068030")]
		[Attribute(Name="TooltipAttribute", RVA="0x1068030", Offset="0x1068030")]
		[FieldOffset(Offset="0x84")]
		public float m_MinimumFOV;

		[Attribute(Name="RangeAttribute", RVA="0x1068088", Offset="0x1068088")]
		[Attribute(Name="TooltipAttribute", RVA="0x1068088", Offset="0x1068088")]
		[FieldOffset(Offset="0x88")]
		public float m_MaximumFOV;

		[Attribute(Name="TooltipAttribute", RVA="0x10680E0", Offset="0x10680E0")]
		[FieldOffset(Offset="0x8C")]
		public float m_MinimumOrthoSize;

		[Attribute(Name="TooltipAttribute", RVA="0x1068118", Offset="0x1068118")]
		[FieldOffset(Offset="0x90")]
		public float m_MaximumOrthoSize;

		[FieldOffset(Offset="0x0")]
		private const float kMinimumCameraDistance = 0.01f;

		[FieldOffset(Offset="0x94")]
		private Vector3 m_PreviousCameraPosition;

		[FieldOffset(Offset="0xA0")]
		private PositionPredictor m_Predictor;

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1068150", Offset="0x1068150")]
		[FieldOffset(Offset="0xA8")]
		private Vector3 <TrackedPoint>k__BackingField;

		[FieldOffset(Offset="0xB4")]
		private float m_prevTargetHeight;

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1068160", Offset="0x1068160")]
		[FieldOffset(Offset="0xB8")]
		private Bounds <m_LastBounds>k__BackingField;

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1068170", Offset="0x1068170")]
		[FieldOffset(Offset="0xD0")]
		private Matrix4x4 <m_lastBoundsMatrix>k__BackingField;

		public Rect HardGuideRect
		{
			[Address(RVA="0x1D4A094", Offset="0x1D4A094", VA="0x1D4A094")]
			get
			{
				return new Rect();
			}
			[Address(RVA="0x1D4A198", Offset="0x1D4A198", VA="0x1D4A198")]
			set
			{
			}
		}

		public override bool IsValid
		{
			[Address(RVA="0x1D4A51C", Offset="0x1D4A51C", VA="0x1D4A51C", Slot="4")]
			get
			{
				return new bool();
			}
		}

		public Bounds m_LastBounds
		{
			[Address(RVA="0x1D4B69C", Offset="0x1D4B69C", VA="0x1D4B69C")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108AC74", Offset="0x108AC74")]
			get
			{
				return new Bounds();
			}
			[Address(RVA="0x1D4B6B0", Offset="0x1D4B6B0", VA="0x1D4B6B0")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108AC84", Offset="0x108AC84")]
			private set
			{
			}
		}

		public Matrix4x4 m_lastBoundsMatrix
		{
			[Address(RVA="0x1D4B6C4", Offset="0x1D4B6C4", VA="0x1D4B6C4")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108AC94", Offset="0x108AC94")]
			get
			{
				return new Matrix4x4();
			}
			[Address(RVA="0x1D4B6E8", Offset="0x1D4B6E8", VA="0x1D4B6E8")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108ACA4", Offset="0x108ACA4")]
			private set
			{
			}
		}

		public Rect SoftGuideRect
		{
			[Address(RVA="0x1D49F1C", Offset="0x1D49F1C", VA="0x1D49F1C")]
			get
			{
				return new Rect();
			}
			[Address(RVA="0x1D49F68", Offset="0x1D49F68", VA="0x1D49F68")]
			set
			{
			}
		}

		public override CinemachineCore.Stage Stage
		{
			[Address(RVA="0x1D4A600", Offset="0x1D4A600", VA="0x1D4A600", Slot="6")]
			get
			{
				return new CinemachineCore.Stage();
			}
		}

		public CinemachineTargetGroup TargetGroup
		{
			[Address(RVA="0x1D4AED8", Offset="0x1D4AED8", VA="0x1D4AED8")]
			get
			{
				return null;
			}
		}

		public Vector3 TrackedPoint
		{
			[Address(RVA="0x1D4A608", Offset="0x1D4A608", VA="0x1D4A608")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108AC54", Offset="0x108AC54")]
			get
			{
				return new Vector3();
			}
			[Address(RVA="0x1D4A614", Offset="0x1D4A614", VA="0x1D4A614")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108AC64", Offset="0x108AC64")]
			private set
			{
			}
		}

		[Address(RVA="0x1D4B894", Offset="0x1D4B894", VA="0x1D4B894")]
		public CinemachineFramingTransposer()
		{
		}

		[Address(RVA="0x1D4AF84", Offset="0x1D4AF84", VA="0x1D4AF84")]
		private float AdjustCameraDepthAndLensForGroupFraming(CinemachineTargetGroup group, float targetZ, ref CameraState curState, float deltaTime)
		{
			return new float();
		}

		[Address(RVA="0x1D4B6FC", Offset="0x1D4B6FC", VA="0x1D4B6FC")]
		private float GetTargetHeight(Bounds b)
		{
			return new float();
		}

		[Address(RVA="0x1D4A620", Offset="0x1D4A620", VA="0x1D4A620", Slot="7")]
		public override void MutateCameraState(ref CameraState curState, float deltaTime)
		{
		}

		[Address(RVA="0x1D4A3BC", Offset="0x1D4A3BC", VA="0x1D4A3BC")]
		private void OnValidate()
		{
		}

		[Address(RVA="0x1D4B550", Offset="0x1D4B550", VA="0x1D4B550")]
		private Vector3 OrthoOffsetToScreenBounds(Vector3 targetPos2D, Rect screenRect)
		{
			return new Vector3();
		}

		[Address(RVA="0x1D4B474", Offset="0x1D4B474", VA="0x1D4B474")]
		private Rect ScreenToOrtho(Rect rScreen, float orthoSize, float aspect)
		{
			return new Rect();
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

		[Attribute(Name="DocumentationSortingAttribute", RVA="0x10513AC", Offset="0x10513AC")]
		public enum FramingMode
		{
			[FieldOffset(Offset="0x0")]
			Horizontal,
			[FieldOffset(Offset="0x0")]
			Vertical,
			[FieldOffset(Offset="0x0")]
			HorizontalAndVertical,
			[FieldOffset(Offset="0x0")]
			None
		}
	}
}