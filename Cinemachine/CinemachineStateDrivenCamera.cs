using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Cinemachine
{
	[Attribute(Name="AddComponentMenu", RVA="0x104A208", Offset="0x104A208")]
	[Attribute(Name="DisallowMultipleComponent", RVA="0x104A208", Offset="0x104A208")]
	[Attribute(Name="DocumentationSortingAttribute", RVA="0x104A208", Offset="0x104A208")]
	[Attribute(Name="ExecuteInEditMode", RVA="0x104A208", Offset="0x104A208")]
	public class CinemachineStateDrivenCamera : CinemachineVirtualCameraBase
	{
		[Attribute(Name="NoSaveDuringPlayAttribute", RVA="0x1066E64", Offset="0x1066E64")]
		[Attribute(Name="TooltipAttribute", RVA="0x1066E64", Offset="0x1066E64")]
		[FieldOffset(Offset="0x78")]
		public Transform m_LookAt;

		[Attribute(Name="NoSaveDuringPlayAttribute", RVA="0x1066EB0", Offset="0x1066EB0")]
		[Attribute(Name="TooltipAttribute", RVA="0x1066EB0", Offset="0x1066EB0")]
		[FieldOffset(Offset="0x80")]
		public Transform m_Follow;

		[Attribute(Name="SpaceAttribute", RVA="0x1066EFC", Offset="0x1066EFC")]
		[Attribute(Name="TooltipAttribute", RVA="0x1066EFC", Offset="0x1066EFC")]
		[FieldOffset(Offset="0x88")]
		public Animator m_AnimatedTarget;

		[Attribute(Name="TooltipAttribute", RVA="0x1066F48", Offset="0x1066F48")]
		[FieldOffset(Offset="0x90")]
		public int m_LayerIndex;

		[Attribute(Name="TooltipAttribute", RVA="0x1066F80", Offset="0x1066F80")]
		[FieldOffset(Offset="0x94")]
		public bool m_ShowDebugText;

		[Attribute(Name="TooltipAttribute", RVA="0x1066FB8", Offset="0x1066FB8")]
		[FieldOffset(Offset="0x95")]
		public bool m_EnableAllChildCameras;

		[Attribute(Name="HideInInspector", RVA="0x1066FF0", Offset="0x1066FF0")]
		[Attribute(Name="NoSaveDuringPlayAttribute", RVA="0x1066FF0", Offset="0x1066FF0")]
		[FieldOffset(Offset="0x98")]
		[SerializeField]
		public CinemachineVirtualCameraBase[] m_ChildCameras;

		[Attribute(Name="TooltipAttribute", RVA="0x1067038", Offset="0x1067038")]
		[FieldOffset(Offset="0xA0")]
		public CinemachineStateDrivenCamera.Instruction[] m_Instructions;

		[Attribute(Name="CinemachineBlendDefinitionPropertyAttribute", RVA="0x1067070", Offset="0x1067070")]
		[Attribute(Name="TooltipAttribute", RVA="0x1067070", Offset="0x1067070")]
		[FieldOffset(Offset="0xA8")]
		public CinemachineBlendDefinition m_DefaultBlend;

		[Attribute(Name="TooltipAttribute", RVA="0x10670BC", Offset="0x10670BC")]
		[FieldOffset(Offset="0xB0")]
		public CinemachineBlenderSettings m_CustomBlends;

		[Attribute(Name="HideInInspector", RVA="0x10670F4", Offset="0x10670F4")]
		[FieldOffset(Offset="0xB8")]
		[SerializeField]
		public CinemachineStateDrivenCamera.ParentHash[] m_ParentHash;

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106712C", Offset="0x106712C")]
		[FieldOffset(Offset="0xC0")]
		private ICinemachineCamera <LiveChild>k__BackingField;

		[FieldOffset(Offset="0xC8")]
		private CameraState m_State;

		[FieldOffset(Offset="0x198")]
		private float mActivationTime;

		[FieldOffset(Offset="0x1A0")]
		private CinemachineStateDrivenCamera.Instruction mActiveInstruction;

		[FieldOffset(Offset="0x1B8")]
		private float mPendingActivationTime;

		[FieldOffset(Offset="0x1C0")]
		private CinemachineStateDrivenCamera.Instruction mPendingInstruction;

		[FieldOffset(Offset="0x1D8")]
		private CinemachineBlend mActiveBlend;

		[FieldOffset(Offset="0x1E0")]
		private Dictionary<int, int> mInstructionDictionary;

		[FieldOffset(Offset="0x1E8")]
		private Dictionary<int, int> mStateParentLookup;

		[FieldOffset(Offset="0x1F0")]
		private List<AnimatorClipInfo> m_clipInfoList;

		public CinemachineVirtualCameraBase[] ChildCameras
		{
			[Address(RVA="0x1455F8C", Offset="0x1455F8C", VA="0x1455F8C")]
			get
			{
				return null;
			}
		}

		public override string Description
		{
			[Address(RVA="0x1454524", Offset="0x1454524", VA="0x1454524", Slot="21")]
			get
			{
				return null;
			}
		}

		public override Transform Follow
		{
			[Address(RVA="0x14547EC", Offset="0x14547EC", VA="0x14547EC", Slot="27")]
			get
			{
				return null;
			}
			[Address(RVA="0x1454910", Offset="0x1454910", VA="0x1454910", Slot="28")]
			set
			{
			}
		}

		public bool IsBlending
		{
			[Address(RVA="0x1455FB0", Offset="0x1455FB0", VA="0x1455FB0")]
			get
			{
				return new bool();
			}
		}

		public ICinemachineCamera LiveChild
		{
			[Address(RVA="0x1454628", Offset="0x1454628", VA="0x1454628")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108AC04", Offset="0x108AC04")]
			get
			{
				return null;
			}
			[Address(RVA="0x1454630", Offset="0x1454630", VA="0x1454630")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108ABF4", Offset="0x108ABF4")]
			set
			{
			}
		}

		public override ICinemachineCamera LiveChildOrSelf
		{
			[Address(RVA="0x1454638", Offset="0x1454638", VA="0x1454638", Slot="23")]
			get
			{
				return null;
			}
		}

		public override Transform LookAt
		{
			[Address(RVA="0x14546C0", Offset="0x14546C0", VA="0x14546C0", Slot="25")]
			get
			{
				return null;
			}
			[Address(RVA="0x14547E4", Offset="0x14547E4", VA="0x14547E4", Slot="26")]
			set
			{
			}
		}

		public override CameraState State
		{
			[Address(RVA="0x14546B0", Offset="0x14546B0", VA="0x14546B0", Slot="22")]
			get
			{
				return new CameraState();
			}
		}

		[Address(RVA="0x1456558", Offset="0x1456558", VA="0x1456558")]
		public CinemachineStateDrivenCamera()
		{
		}

		[Address(RVA="0x14552C8", Offset="0x14552C8", VA="0x14552C8")]
		private CinemachineVirtualCameraBase ChooseCurrentCamera(float deltaTime)
		{
			return null;
		}

		[Address(RVA="0x1455BB8", Offset="0x1455BB8", VA="0x1455BB8")]
		private CinemachineBlend CreateBlend(ICinemachineCamera camA, ICinemachineCamera camB, AnimationCurve blendCurve, float duration, CinemachineBlend activeBlend, float deltaTime)
		{
			return null;
		}

		[Address(RVA="0x1455FC0", Offset="0x1455FC0", VA="0x1455FC0")]
		public static string CreateFakeHashName(int parentHash, string stateName)
		{
			return null;
		}

		[Address(RVA="0x1456344", Offset="0x1456344", VA="0x1456344")]
		private int GetClipHash(int hash, List<AnimatorClipInfo> clips)
		{
			return new int();
		}

		[Address(RVA="0x1455F74", Offset="0x1455F74", VA="0x1455F74")]
		private void InvalidateListOfChildren()
		{
		}

		[Address(RVA="0x1454640", Offset="0x1454640", VA="0x1454640", Slot="24")]
		public override bool IsLiveChild(ICinemachineCamera vcam)
		{
			return new bool();
		}

		[Address(RVA="0x145596C", Offset="0x145596C", VA="0x145596C")]
		private AnimationCurve LookupBlendCurve(ICinemachineCamera fromKey, ICinemachineCamera toKey, out float duration)
		{
			duration = 0f;
			return null;
		}

		[Address(RVA="0x1455D60", Offset="0x1455D60", VA="0x1455D60", Slot="34")]
		protected override void OnEnable()
		{
		}

		[Address(RVA="0x1455F80", Offset="0x1455F80", VA="0x1455F80")]
		public void OnTransformChildrenChanged()
		{
		}

		[Address(RVA="0x1454918", Offset="0x1454918", VA="0x1454918", Slot="20")]
		public override void RemovePostPipelineStageHook(CinemachineVirtualCameraBase.OnPostPipelineStageDelegate d)
		{
		}

		[Address(RVA="0x1454C64", Offset="0x1454C64", VA="0x1454C64", Slot="29")]
		public override void UpdateCameraState(Vector3 worldUp, float deltaTime)
		{
		}

		[Address(RVA="0x1454A80", Offset="0x1454A80", VA="0x1454A80")]
		private void UpdateListOfChildren()
		{
		}

		[Address(RVA="0x1456030", Offset="0x1456030", VA="0x1456030")]
		public void ValidateInstructions()
		{
		}

		[Serializable]
		public struct Instruction
		{
			[Attribute(Name="TooltipAttribute", RVA="0x106D0E4", Offset="0x106D0E4")]
			[FieldOffset(Offset="0x0")]
			public int m_FullHash;

			[Attribute(Name="TooltipAttribute", RVA="0x106D11C", Offset="0x106D11C")]
			[FieldOffset(Offset="0x8")]
			public CinemachineVirtualCameraBase m_VirtualCamera;

			[Attribute(Name="TooltipAttribute", RVA="0x106D154", Offset="0x106D154")]
			[FieldOffset(Offset="0x10")]
			public float m_ActivateAfter;

			[Attribute(Name="TooltipAttribute", RVA="0x106D18C", Offset="0x106D18C")]
			[FieldOffset(Offset="0x14")]
			public float m_MinDuration;
		}

		[Attribute(Name="DocumentationSortingAttribute", RVA="0x105132C", Offset="0x105132C")]
		[Serializable]
		public struct ParentHash
		{
			[FieldOffset(Offset="0x0")]
			public int m_Hash;

			[FieldOffset(Offset="0x4")]
			public int m_ParentHash;

			[Address(RVA="0xF01058", Offset="0xF01058", VA="0xF01058")]
			public ParentHash(int h, int p)
			{
			}
		}
	}
}