using Il2CppDummyDll;
using System;
using UnityEngine;

namespace Cinemachine
{
	[Attribute(Name="AddComponentMenu", RVA="0x1049C54", Offset="0x1049C54")]
	[Attribute(Name="DisallowMultipleComponent", RVA="0x1049C54", Offset="0x1049C54")]
	[Attribute(Name="DocumentationSortingAttribute", RVA="0x1049C54", Offset="0x1049C54")]
	[Attribute(Name="ExecuteInEditMode", RVA="0x1049C54", Offset="0x1049C54")]
	public class CinemachineBlendListCamera : CinemachineVirtualCameraBase
	{
		[Attribute(Name="NoSaveDuringPlayAttribute", RVA="0x1065938", Offset="0x1065938")]
		[Attribute(Name="TooltipAttribute", RVA="0x1065938", Offset="0x1065938")]
		[FieldOffset(Offset="0x78")]
		public Transform m_LookAt;

		[Attribute(Name="NoSaveDuringPlayAttribute", RVA="0x1065984", Offset="0x1065984")]
		[Attribute(Name="TooltipAttribute", RVA="0x1065984", Offset="0x1065984")]
		[FieldOffset(Offset="0x80")]
		public Transform m_Follow;

		[Attribute(Name="TooltipAttribute", RVA="0x10659D0", Offset="0x10659D0")]
		[FieldOffset(Offset="0x88")]
		public bool m_ShowDebugText;

		[Attribute(Name="TooltipAttribute", RVA="0x1065A08", Offset="0x1065A08")]
		[FieldOffset(Offset="0x89")]
		public bool m_EnableAllChildCameras;

		[Attribute(Name="HideInInspector", RVA="0x1065A40", Offset="0x1065A40")]
		[Attribute(Name="NoSaveDuringPlayAttribute", RVA="0x1065A40", Offset="0x1065A40")]
		[FieldOffset(Offset="0x90")]
		[SerializeField]
		public CinemachineVirtualCameraBase[] m_ChildCameras;

		[Attribute(Name="TooltipAttribute", RVA="0x1065A88", Offset="0x1065A88")]
		[FieldOffset(Offset="0x98")]
		public CinemachineBlendListCamera.Instruction[] m_Instructions;

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1065AC0", Offset="0x1065AC0")]
		[FieldOffset(Offset="0xA0")]
		private ICinemachineCamera <LiveChild>k__BackingField;

		[FieldOffset(Offset="0xA8")]
		private CameraState m_State;

		[FieldOffset(Offset="0x178")]
		private float mActivationTime;

		[FieldOffset(Offset="0x17C")]
		private int mCurrentInstruction;

		[FieldOffset(Offset="0x180")]
		private CinemachineBlend mActiveBlend;

		public CinemachineVirtualCameraBase[] ChildCameras
		{
			[Address(RVA="0x1D3DA18", Offset="0x1D3DA18", VA="0x1D3DA18")]
			get
			{
				return null;
			}
		}

		public override string Description
		{
			[Address(RVA="0x1D3CA24", Offset="0x1D3CA24", VA="0x1D3CA24", Slot="21")]
			get
			{
				return null;
			}
		}

		public override Transform Follow
		{
			[Address(RVA="0x1D3CBA0", Offset="0x1D3CBA0", VA="0x1D3CBA0", Slot="27")]
			get
			{
				return null;
			}
			[Address(RVA="0x1D3CBAC", Offset="0x1D3CBAC", VA="0x1D3CBAC", Slot="28")]
			set
			{
			}
		}

		public bool IsBlending
		{
			[Address(RVA="0x1D3DA3C", Offset="0x1D3DA3C", VA="0x1D3DA3C")]
			get
			{
				return new bool();
			}
		}

		public ICinemachineCamera LiveChild
		{
			[Address(RVA="0x1D3CB24", Offset="0x1D3CB24", VA="0x1D3CB24")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108A930", Offset="0x108A930")]
			get
			{
				return null;
			}
			[Address(RVA="0x1D3CB2C", Offset="0x1D3CB2C", VA="0x1D3CB2C")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108A920", Offset="0x108A920")]
			set
			{
			}
		}

		public override ICinemachineCamera LiveChildOrSelf
		{
			[Address(RVA="0x1D3CB34", Offset="0x1D3CB34", VA="0x1D3CB34", Slot="23")]
			get
			{
				return null;
			}
		}

		public override Transform LookAt
		{
			[Address(RVA="0x1D3CB8C", Offset="0x1D3CB8C", VA="0x1D3CB8C", Slot="25")]
			get
			{
				return null;
			}
			[Address(RVA="0x1D3CB98", Offset="0x1D3CB98", VA="0x1D3CB98", Slot="26")]
			set
			{
			}
		}

		public override CameraState State
		{
			[Address(RVA="0x1D3CB7C", Offset="0x1D3CB7C", VA="0x1D3CB7C", Slot="22")]
			get
			{
				return new CameraState();
			}
		}

		[Address(RVA="0x1D3DC44", Offset="0x1D3DC44", VA="0x1D3DC44")]
		public CinemachineBlendListCamera()
		{
		}

		[Address(RVA="0x1D3D488", Offset="0x1D3D488", VA="0x1D3D488")]
		private void AdvanceCurrentInstruction()
		{
		}

		[Address(RVA="0x1D3D60C", Offset="0x1D3D60C", VA="0x1D3D60C")]
		private CinemachineBlend CreateBlend(ICinemachineCamera camA, ICinemachineCamera camB, AnimationCurve blendCurve, float duration, CinemachineBlend activeBlend, float deltaTime)
		{
			return null;
		}

		[Address(RVA="0x1D3DA00", Offset="0x1D3DA00", VA="0x1D3DA00")]
		private void InvalidateListOfChildren()
		{
		}

		[Address(RVA="0x1D3CB3C", Offset="0x1D3CB3C", VA="0x1D3CB3C", Slot="24")]
		public override bool IsLiveChild(ICinemachineCamera vcam)
		{
			return new bool();
		}

		[Address(RVA="0x1D3D9D0", Offset="0x1D3D9D0", VA="0x1D3D9D0", Slot="34")]
		protected override void OnEnable()
		{
		}

		[Address(RVA="0x1D3DA0C", Offset="0x1D3DA0C", VA="0x1D3DA0C")]
		public void OnTransformChildrenChanged()
		{
		}

		[Address(RVA="0x1D3CE30", Offset="0x1D3CE30", VA="0x1D3CE30", Slot="30")]
		public override void OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime)
		{
		}

		[Address(RVA="0x1D3CBB4", Offset="0x1D3CBB4", VA="0x1D3CBB4", Slot="20")]
		public override void RemovePostPipelineStageHook(CinemachineVirtualCameraBase.OnPostPipelineStageDelegate d)
		{
		}

		[Address(RVA="0x1D3CEB0", Offset="0x1D3CEB0", VA="0x1D3CEB0", Slot="29")]
		public override void UpdateCameraState(Vector3 worldUp, float deltaTime)
		{
		}

		[Address(RVA="0x1D3CC5C", Offset="0x1D3CC5C", VA="0x1D3CC5C")]
		private void UpdateListOfChildren()
		{
		}

		[Address(RVA="0x1D3DA4C", Offset="0x1D3DA4C", VA="0x1D3DA4C")]
		public void ValidateInstructions()
		{
		}

		[Serializable]
		public struct Instruction
		{
			[Attribute(Name="TooltipAttribute", RVA="0x106CF10", Offset="0x106CF10")]
			[FieldOffset(Offset="0x0")]
			public CinemachineVirtualCameraBase m_VirtualCamera;

			[Attribute(Name="TooltipAttribute", RVA="0x106CF48", Offset="0x106CF48")]
			[FieldOffset(Offset="0x8")]
			public float m_Hold;

			[Attribute(Name="CinemachineBlendDefinitionPropertyAttribute", RVA="0x106CF80", Offset="0x106CF80")]
			[Attribute(Name="TooltipAttribute", RVA="0x106CF80", Offset="0x106CF80")]
			[FieldOffset(Offset="0xC")]
			public CinemachineBlendDefinition m_Blend;
		}
	}
}