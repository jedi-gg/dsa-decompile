using Il2CppDummyDll;
using System;
using UnityEngine;

namespace Cinemachine
{
	[Attribute(Name="AddComponentMenu", RVA="0x104A01C", Offset="0x104A01C")]
	[Attribute(Name="DisallowMultipleComponent", RVA="0x104A01C", Offset="0x104A01C")]
	[Attribute(Name="DocumentationSortingAttribute", RVA="0x104A01C", Offset="0x104A01C")]
	[Attribute(Name="ExecuteInEditMode", RVA="0x104A01C", Offset="0x104A01C")]
	public class CinemachineFreeLook : CinemachineVirtualCameraBase
	{
		[Attribute(Name="NoSaveDuringPlayAttribute", RVA="0x1066770", Offset="0x1066770")]
		[Attribute(Name="TooltipAttribute", RVA="0x1066770", Offset="0x1066770")]
		[FieldOffset(Offset="0x78")]
		public Transform m_LookAt;

		[Attribute(Name="NoSaveDuringPlayAttribute", RVA="0x10667BC", Offset="0x10667BC")]
		[Attribute(Name="TooltipAttribute", RVA="0x10667BC", Offset="0x10667BC")]
		[FieldOffset(Offset="0x80")]
		public Transform m_Follow;

		[Attribute(Name="FormerlySerializedAsAttribute", RVA="0x1066808", Offset="0x1066808")]
		[Attribute(Name="TooltipAttribute", RVA="0x1066808", Offset="0x1066808")]
		[FieldOffset(Offset="0x88")]
		public bool m_CommonLens;

		[Attribute(Name="FormerlySerializedAsAttribute", RVA="0x1066868", Offset="0x1066868")]
		[Attribute(Name="LensSettingsPropertyAttribute", RVA="0x1066868", Offset="0x1066868")]
		[Attribute(Name="TooltipAttribute", RVA="0x1066868", Offset="0x1066868")]
		[FieldOffset(Offset="0x8C")]
		public LensSettings m_Lens;

		[Attribute(Name="HeaderAttribute", RVA="0x10668D8", Offset="0x10668D8")]
		[Attribute(Name="TooltipAttribute", RVA="0x10668D8", Offset="0x10668D8")]
		[FieldOffset(Offset="0xA8")]
		public AxisState m_YAxis;

		[Attribute(Name="TooltipAttribute", RVA="0x1066938", Offset="0x1066938")]
		[FieldOffset(Offset="0xD8")]
		public AxisState m_XAxis;

		[Attribute(Name="TooltipAttribute", RVA="0x1066970", Offset="0x1066970")]
		[FieldOffset(Offset="0x108")]
		public CinemachineOrbitalTransposer.Heading m_Heading;

		[Attribute(Name="TooltipAttribute", RVA="0x10669A8", Offset="0x10669A8")]
		[FieldOffset(Offset="0x114")]
		public CinemachineOrbitalTransposer.Recentering m_RecenterToTargetHeading;

		[Attribute(Name="HeaderAttribute", RVA="0x10669E0", Offset="0x10669E0")]
		[Attribute(Name="TooltipAttribute", RVA="0x10669E0", Offset="0x10669E0")]
		[FieldOffset(Offset="0x128")]
		public CinemachineTransposer.BindingMode m_BindingMode;

		[Attribute(Name="FormerlySerializedAsAttribute", RVA="0x1066A40", Offset="0x1066A40")]
		[Attribute(Name="RangeAttribute", RVA="0x1066A40", Offset="0x1066A40")]
		[Attribute(Name="TooltipAttribute", RVA="0x1066A40", Offset="0x1066A40")]
		[FieldOffset(Offset="0x12C")]
		public float m_SplineCurvature;

		[Attribute(Name="TooltipAttribute", RVA="0x1066AB8", Offset="0x1066AB8")]
		[FieldOffset(Offset="0x130")]
		public CinemachineFreeLook.Orbit[] m_Orbits;

		[Attribute(Name="FormerlySerializedAsAttribute", RVA="0x1066AF0", Offset="0x1066AF0")]
		[Attribute(Name="HideInInspector", RVA="0x1066AF0", Offset="0x1066AF0")]
		[FieldOffset(Offset="0x138")]
		[SerializeField]
		private float m_LegacyHeadingBias;

		[FieldOffset(Offset="0x13C")]
		private bool mUseLegacyRigDefinitions;

		[FieldOffset(Offset="0x13D")]
		private bool mIsDestroyed;

		[FieldOffset(Offset="0x140")]
		private CameraState m_State;

		[Attribute(Name="HideInInspector", RVA="0x1066B4C", Offset="0x1066B4C")]
		[Attribute(Name="NoSaveDuringPlayAttribute", RVA="0x1066B4C", Offset="0x1066B4C")]
		[FieldOffset(Offset="0x210")]
		[SerializeField]
		private CinemachineVirtualCamera[] m_Rigs;

		[FieldOffset(Offset="0x218")]
		private CinemachineOrbitalTransposer[] mOrbitals;

		[FieldOffset(Offset="0x220")]
		private CinemachineBlend mBlendA;

		[FieldOffset(Offset="0x228")]
		private CinemachineBlend mBlendB;

		[FieldOffset(Offset="0x0")]
		public static CinemachineFreeLook.CreateRigDelegate CreateRigOverride;

		[FieldOffset(Offset="0x8")]
		public static CinemachineFreeLook.DestroyRigDelegate DestroyRigOverride;

		[FieldOffset(Offset="0x230")]
		private CinemachineFreeLook.Orbit[] m_CachedOrbits;

		[FieldOffset(Offset="0x238")]
		private float m_CachedTension;

		[FieldOffset(Offset="0x240")]
		private Vector4[] m_CachedKnots;

		[FieldOffset(Offset="0x248")]
		private Vector4[] m_CachedCtrl1;

		[FieldOffset(Offset="0x250")]
		private Vector4[] m_CachedCtrl2;

		public override Transform Follow
		{
			[Address(RVA="0x1D4CB48", Offset="0x1D4CB48", VA="0x1D4CB48", Slot="27")]
			get
			{
				return null;
			}
			[Address(RVA="0x1D4CB54", Offset="0x1D4CB54", VA="0x1D4CB54", Slot="28")]
			set
			{
			}
		}

		public override ICinemachineCamera LiveChildOrSelf
		{
			[Address(RVA="0x1D4CB5C", Offset="0x1D4CB5C", VA="0x1D4CB5C", Slot="23")]
			get
			{
				return null;
			}
		}

		public override Transform LookAt
		{
			[Address(RVA="0x1D4CB34", Offset="0x1D4CB34", VA="0x1D4CB34", Slot="25")]
			get
			{
				return null;
			}
			[Address(RVA="0x1D4CB40", Offset="0x1D4CB40", VA="0x1D4CB40", Slot="26")]
			set
			{
			}
		}

		public static string[] RigNames
		{
			[Address(RVA="0x1D4C23C", Offset="0x1D4C23C", VA="0x1D4C23C")]
			get
			{
				return null;
			}
		}

		public override CameraState State
		{
			[Address(RVA="0x1D4CB24", Offset="0x1D4CB24", VA="0x1D4CB24", Slot="22")]
			get
			{
				return new CameraState();
			}
		}

		[Address(RVA="0x1D50464", Offset="0x1D50464", VA="0x1D50464")]
		public CinemachineFreeLook()
		{
		}

		[Address(RVA="0x1D50704", Offset="0x1D50704", VA="0x1D50704")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108AB84", Offset="0x108AB84")]
		private float <LocateExistingRigs>b__50_0(CinemachineOrbitalTransposer orbital, float deltaTime, Vector3 up)
		{
			return new float();
		}

		[Address(RVA="0x1D4D488", Offset="0x1D4D488", VA="0x1D4D488")]
		private CameraState CalculateNewState(Vector3 worldUp, float deltaTime)
		{
			return new CameraState();
		}

		[Address(RVA="0x1D4E5A4", Offset="0x1D4E5A4", VA="0x1D4E5A4")]
		private CinemachineVirtualCamera[] CreateRigs(CinemachineVirtualCamera[] copyFrom)
		{
			return null;
		}

		[Address(RVA="0x1D4C558", Offset="0x1D4C558", VA="0x1D4C558")]
		private void DestroyRigs()
		{
		}

		[Address(RVA="0x1D4FBC8", Offset="0x1D4FBC8", VA="0x1D4FBC8")]
		public Vector3 GetLocalPositionForCameraFromInput(float t)
		{
			return new Vector3();
		}

		[Address(RVA="0x1D4BA44", Offset="0x1D4BA44", VA="0x1D4BA44")]
		public CinemachineVirtualCamera GetRig(int i)
		{
			return null;
		}

		[Address(RVA="0x1D4BA3C", Offset="0x1D4BA3C", VA="0x1D4BA3C")]
		private void InvalidateRigCache()
		{
		}

		[Address(RVA="0x1D4CBAC", Offset="0x1D4CBAC", VA="0x1D4CBAC", Slot="24")]
		public override bool IsLiveChild(ICinemachineCamera vcam)
		{
			return new bool();
		}

		[Address(RVA="0x1D4F3B0", Offset="0x1D4F3B0", VA="0x1D4F3B0")]
		private int LocateExistingRigs(string[] rigNames, bool forceOrbital)
		{
			return new int();
		}

		[Address(RVA="0x1D4C3C0", Offset="0x1D4C3C0", VA="0x1D4C3C0", Slot="32")]
		protected override void OnDestroy()
		{
		}

		[Address(RVA="0x1D4C394", Offset="0x1D4C394", VA="0x1D4C394", Slot="34")]
		protected override void OnEnable()
		{
		}

		[Address(RVA="0x1D4C54C", Offset="0x1D4C54C", VA="0x1D4C54C")]
		private void OnTransformChildrenChanged()
		{
		}

		[Address(RVA="0x1D4DD00", Offset="0x1D4DD00", VA="0x1D4DD00", Slot="30")]
		public override void OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime)
		{
		}

		[Address(RVA="0x1D4B9A4", Offset="0x1D4B9A4", VA="0x1D4B9A4", Slot="33")]
		protected override void OnValidate()
		{
		}

		[Address(RVA="0x1D4D1BC", Offset="0x1D4D1BC", VA="0x1D4D1BC")]
		private CameraState PullStateFromVirtualCamera(Vector3 worldUp)
		{
			return new CameraState();
		}

		[Address(RVA="0x1D4D5C0", Offset="0x1D4D5C0", VA="0x1D4D5C0")]
		private void PushSettingsToRigs()
		{
		}

		[Address(RVA="0x1D4CC0C", Offset="0x1D4CC0C", VA="0x1D4CC0C", Slot="20")]
		public override void RemovePostPipelineStageHook(CinemachineVirtualCameraBase.OnPostPipelineStageDelegate d)
		{
		}

		[Address(RVA="0x1D4C554", Offset="0x1D4C554", VA="0x1D4C554")]
		private void Reset()
		{
		}

		[Address(RVA="0x1D4FE48", Offset="0x1D4FE48", VA="0x1D4FE48")]
		private void UpdateCachedSpline()
		{
		}

		[Address(RVA="0x1D4CD1C", Offset="0x1D4CD1C", VA="0x1D4CD1C", Slot="29")]
		public override void UpdateCameraState(Vector3 worldUp, float deltaTime)
		{
		}

		[Address(RVA="0x1D4BAB0", Offset="0x1D4BAB0", VA="0x1D4BAB0")]
		private void UpdateRigCache()
		{
		}

		public delegate CinemachineVirtualCamera CreateRigDelegate(CinemachineFreeLook vcam, string name, CinemachineVirtualCamera copyFrom);

		public delegate void DestroyRigDelegate(GameObject rig);

		[Serializable]
		public struct Orbit
		{
			[FieldOffset(Offset="0x0")]
			public float m_Height;

			[FieldOffset(Offset="0x4")]
			public float m_Radius;

			[Address(RVA="0xF2E3D0", Offset="0xF2E3D0", VA="0xF2E3D0")]
			public Orbit(float h, float r)
			{
			}
		}
	}
}