using Il2CppDummyDll;
using System;
using UnityEngine;

namespace Cinemachine
{
	[Attribute(Name="AddComponentMenu", RVA="0x1049D4C", Offset="0x1049D4C")]
	[Attribute(Name="DisallowMultipleComponent", RVA="0x1049D4C", Offset="0x1049D4C")]
	[Attribute(Name="DocumentationSortingAttribute", RVA="0x1049D4C", Offset="0x1049D4C")]
	[Attribute(Name="ExecuteInEditMode", RVA="0x1049D4C", Offset="0x1049D4C")]
	public class CinemachineClearShot : CinemachineVirtualCameraBase
	{
		[Attribute(Name="NoSaveDuringPlayAttribute", RVA="0x1065DAC", Offset="0x1065DAC")]
		[Attribute(Name="TooltipAttribute", RVA="0x1065DAC", Offset="0x1065DAC")]
		[FieldOffset(Offset="0x78")]
		public Transform m_LookAt;

		[Attribute(Name="NoSaveDuringPlayAttribute", RVA="0x1065DF8", Offset="0x1065DF8")]
		[Attribute(Name="TooltipAttribute", RVA="0x1065DF8", Offset="0x1065DF8")]
		[FieldOffset(Offset="0x80")]
		public Transform m_Follow;

		[Attribute(Name="NoSaveDuringPlayAttribute", RVA="0x1065E44", Offset="0x1065E44")]
		[Attribute(Name="TooltipAttribute", RVA="0x1065E44", Offset="0x1065E44")]
		[FieldOffset(Offset="0x88")]
		public bool m_ShowDebugText;

		[Attribute(Name="HideInInspector", RVA="0x1065E90", Offset="0x1065E90")]
		[Attribute(Name="NoSaveDuringPlayAttribute", RVA="0x1065E90", Offset="0x1065E90")]
		[FieldOffset(Offset="0x90")]
		[SerializeField]
		public CinemachineVirtualCameraBase[] m_ChildCameras;

		[Attribute(Name="TooltipAttribute", RVA="0x1065ED8", Offset="0x1065ED8")]
		[FieldOffset(Offset="0x98")]
		public float m_ActivateAfter;

		[Attribute(Name="TooltipAttribute", RVA="0x1065F10", Offset="0x1065F10")]
		[FieldOffset(Offset="0x9C")]
		public float m_MinDuration;

		[Attribute(Name="TooltipAttribute", RVA="0x1065F48", Offset="0x1065F48")]
		[FieldOffset(Offset="0xA0")]
		public bool m_RandomizeChoice;

		[Attribute(Name="CinemachineBlendDefinitionPropertyAttribute", RVA="0x1065F80", Offset="0x1065F80")]
		[Attribute(Name="TooltipAttribute", RVA="0x1065F80", Offset="0x1065F80")]
		[FieldOffset(Offset="0xA4")]
		public CinemachineBlendDefinition m_DefaultBlend;

		[Attribute(Name="HideInInspector", RVA="0x1065FCC", Offset="0x1065FCC")]
		[FieldOffset(Offset="0xB0")]
		public CinemachineBlenderSettings m_CustomBlends;

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1065FDC", Offset="0x1065FDC")]
		[FieldOffset(Offset="0xB8")]
		private ICinemachineCamera <LiveChild>k__BackingField;

		[FieldOffset(Offset="0xC0")]
		private CameraState m_State;

		[FieldOffset(Offset="0x190")]
		private float mActivationTime;

		[FieldOffset(Offset="0x194")]
		private float mPendingActivationTime;

		[FieldOffset(Offset="0x198")]
		private ICinemachineCamera mPendingCamera;

		[FieldOffset(Offset="0x1A0")]
		private CinemachineBlend mActiveBlend;

		[FieldOffset(Offset="0x1A8")]
		private bool mRandomizeNow;

		[FieldOffset(Offset="0x1B0")]
		private CinemachineVirtualCameraBase[] m_RandomizedChilden;

		public CinemachineVirtualCameraBase[] ChildCameras
		{
			[Address(RVA="0x1D41E10", Offset="0x1D41E10", VA="0x1D41E10")]
			get
			{
				return null;
			}
		}

		public override string Description
		{
			[Address(RVA="0x1D40CBC", Offset="0x1D40CBC", VA="0x1D40CBC", Slot="21")]
			get
			{
				return null;
			}
		}

		public override Transform Follow
		{
			[Address(RVA="0x1D40E38", Offset="0x1D40E38", VA="0x1D40E38", Slot="27")]
			get
			{
				return null;
			}
			[Address(RVA="0x1D40E44", Offset="0x1D40E44", VA="0x1D40E44", Slot="28")]
			set
			{
			}
		}

		public bool IsBlending
		{
			[Address(RVA="0x1D41E00", Offset="0x1D41E00", VA="0x1D41E00")]
			get
			{
				return new bool();
			}
		}

		public ICinemachineCamera LiveChild
		{
			[Address(RVA="0x1D40DBC", Offset="0x1D40DBC", VA="0x1D40DBC")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108AB54", Offset="0x108AB54")]
			get
			{
				return null;
			}
			[Address(RVA="0x1D40DC4", Offset="0x1D40DC4", VA="0x1D40DC4")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108AB44", Offset="0x108AB44")]
			set
			{
			}
		}

		public override ICinemachineCamera LiveChildOrSelf
		{
			[Address(RVA="0x1D40DDC", Offset="0x1D40DDC", VA="0x1D40DDC", Slot="23")]
			get
			{
				return null;
			}
		}

		public override Transform LookAt
		{
			[Address(RVA="0x1D40E24", Offset="0x1D40E24", VA="0x1D40E24", Slot="25")]
			get
			{
				return null;
			}
			[Address(RVA="0x1D40E30", Offset="0x1D40E30", VA="0x1D40E30", Slot="26")]
			set
			{
			}
		}

		public override CameraState State
		{
			[Address(RVA="0x1D40DCC", Offset="0x1D40DCC", VA="0x1D40DCC", Slot="22")]
			get
			{
				return new CameraState();
			}
		}

		[Address(RVA="0x1D42190", Offset="0x1D42190", VA="0x1D42190")]
		public CinemachineClearShot()
		{
		}

		[Address(RVA="0x1D413EC", Offset="0x1D413EC", VA="0x1D413EC")]
		private ICinemachineCamera ChooseCurrentCamera(Vector3 worldUp, float deltaTime)
		{
			return null;
		}

		[Address(RVA="0x1D41C20", Offset="0x1D41C20", VA="0x1D41C20")]
		private CinemachineBlend CreateBlend(ICinemachineCamera camA, ICinemachineCamera camB, AnimationCurve blendCurve, float duration, CinemachineBlend activeBlend, float deltaTime)
		{
			return null;
		}

		[Address(RVA="0x1D41DE0", Offset="0x1D41DE0", VA="0x1D41DE0")]
		private void InvalidateListOfChildren()
		{
		}

		[Address(RVA="0x1D40DE4", Offset="0x1D40DE4", VA="0x1D40DE4", Slot="24")]
		public override bool IsLiveChild(ICinemachineCamera vcam)
		{
			return new bool();
		}

		[Address(RVA="0x1D419DC", Offset="0x1D419DC", VA="0x1D419DC")]
		private AnimationCurve LookupBlendCurve(ICinemachineCamera fromKey, ICinemachineCamera toKey, out float duration)
		{
			duration = 0f;
			return null;
		}

		[Address(RVA="0x1D41DAC", Offset="0x1D41DAC", VA="0x1D41DAC", Slot="34")]
		protected override void OnEnable()
		{
		}

		[Address(RVA="0x1D41DF0", Offset="0x1D41DF0", VA="0x1D41DF0")]
		public void OnTransformChildrenChanged()
		{
		}

		[Address(RVA="0x1D42100", Offset="0x1D42100", VA="0x1D42100", Slot="30")]
		public override void OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime)
		{
		}

		[Address(RVA="0x1D41E44", Offset="0x1D41E44", VA="0x1D41E44")]
		private CinemachineVirtualCameraBase[] Randomize(CinemachineVirtualCameraBase[] src)
		{
			return null;
		}

		[Address(RVA="0x1D40E4C", Offset="0x1D40E4C", VA="0x1D40E4C", Slot="20")]
		public override void RemovePostPipelineStageHook(CinemachineVirtualCameraBase.OnPostPipelineStageDelegate d)
		{
		}

		[Address(RVA="0x1D41E34", Offset="0x1D41E34", VA="0x1D41E34")]
		public void ResetRandomization()
		{
		}

		[Address(RVA="0x1D410B4", Offset="0x1D410B4", VA="0x1D410B4", Slot="29")]
		public override void UpdateCameraState(Vector3 worldUp, float deltaTime)
		{
		}

		[Address(RVA="0x1D40EF4", Offset="0x1D40EF4", VA="0x1D40EF4")]
		private void UpdateListOfChildren()
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10512E4", Offset="0x10512E4")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static CinemachineClearShot.<>c <>9;

			[FieldOffset(Offset="0x8")]
			public static Comparison<CinemachineClearShot.Pair> <>9__46_0;

			[Address(RVA="0x1D4221C", Offset="0x1D4221C", VA="0x1D4221C")]
			static <>c()
			{
			}

			[Address(RVA="0x1D42280", Offset="0x1D42280", VA="0x1D42280")]
			public <>c()
			{
			}

			[Address(RVA="0x1D42288", Offset="0x1D42288", VA="0x1D42288")]
			internal int <Randomize>b__46_0(CinemachineClearShot.Pair p1, CinemachineClearShot.Pair p2)
			{
				return new int();
			}
		}

		private struct Pair
		{
			[FieldOffset(Offset="0x0")]
			public int a;

			[FieldOffset(Offset="0x4")]
			public float b;
		}
	}
}