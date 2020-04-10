using Il2CppDummyDll;
using System;

namespace Cinemachine
{
	[Attribute(Name="AddComponentMenu", RVA="0x1049FA8", Offset="0x1049FA8")]
	[Attribute(Name="DocumentationSortingAttribute", RVA="0x1049FA8", Offset="0x1049FA8")]
	[Attribute(Name="ExecuteInEditMode", RVA="0x1049FA8", Offset="0x1049FA8")]
	[Attribute(Name="SaveDuringPlayAttribute", RVA="0x1049FA8", Offset="0x1049FA8")]
	public class CinemachineFollowZoom : CinemachineExtension
	{
		[Attribute(Name="TooltipAttribute", RVA="0x1066634", Offset="0x1066634")]
		[FieldOffset(Offset="0x28")]
		public float m_Width;

		[Attribute(Name="RangeAttribute", RVA="0x106666C", Offset="0x106666C")]
		[Attribute(Name="TooltipAttribute", RVA="0x106666C", Offset="0x106666C")]
		[FieldOffset(Offset="0x2C")]
		public float m_Damping;

		[Attribute(Name="RangeAttribute", RVA="0x10666C0", Offset="0x10666C0")]
		[Attribute(Name="TooltipAttribute", RVA="0x10666C0", Offset="0x10666C0")]
		[FieldOffset(Offset="0x30")]
		public float m_MinFOV;

		[Attribute(Name="RangeAttribute", RVA="0x1066718", Offset="0x1066718")]
		[Attribute(Name="TooltipAttribute", RVA="0x1066718", Offset="0x1066718")]
		[FieldOffset(Offset="0x34")]
		public float m_MaxFOV;

		[Address(RVA="0x1D49F00", Offset="0x1D49F00", VA="0x1D49F00")]
		public CinemachineFollowZoom()
		{
		}

		[Address(RVA="0x1D49B44", Offset="0x1D49B44", VA="0x1D49B44")]
		private void OnValidate()
		{
		}

		[Address(RVA="0x1D49C04", Offset="0x1D49C04", VA="0x1D49C04", Slot="6")]
		protected override void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime)
		{
		}

		private class VcamExtraState
		{
			[FieldOffset(Offset="0x10")]
			public float m_previousFrameZoom;

			[Address(RVA="0x1D49F14", Offset="0x1D49F14", VA="0x1D49F14")]
			public VcamExtraState()
			{
			}
		}
	}
}