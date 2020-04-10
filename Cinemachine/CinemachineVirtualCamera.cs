using Il2CppDummyDll;
using System;
using UnityEngine;

namespace Cinemachine
{
	[Attribute(Name="AddComponentMenu", RVA="0x104A2F0", Offset="0x104A2F0")]
	[Attribute(Name="DisallowMultipleComponent", RVA="0x104A2F0", Offset="0x104A2F0")]
	[Attribute(Name="DocumentationSortingAttribute", RVA="0x104A2F0", Offset="0x104A2F0")]
	[Attribute(Name="ExecuteInEditMode", RVA="0x104A2F0", Offset="0x104A2F0")]
	public class CinemachineVirtualCamera : CinemachineVirtualCameraBase
	{
		[Attribute(Name="NoSaveDuringPlayAttribute", RVA="0x1067230", Offset="0x1067230")]
		[Attribute(Name="TooltipAttribute", RVA="0x1067230", Offset="0x1067230")]
		[FieldOffset(Offset="0x78")]
		public Transform m_LookAt;

		[Attribute(Name="NoSaveDuringPlayAttribute", RVA="0x106727C", Offset="0x106727C")]
		[Attribute(Name="TooltipAttribute", RVA="0x106727C", Offset="0x106727C")]
		[FieldOffset(Offset="0x80")]
		public Transform m_Follow;

		[Attribute(Name="FormerlySerializedAsAttribute", RVA="0x10672C8", Offset="0x10672C8")]
		[Attribute(Name="LensSettingsPropertyAttribute", RVA="0x10672C8", Offset="0x10672C8")]
		[Attribute(Name="TooltipAttribute", RVA="0x10672C8", Offset="0x10672C8")]
		[FieldOffset(Offset="0x88")]
		public LensSettings m_Lens;

		[FieldOffset(Offset="0x0")]
		public const string PipelineName = "cm";

		[FieldOffset(Offset="0x0")]
		public static CinemachineVirtualCamera.CreatePipelineDelegate CreatePipelineOverride;

		[FieldOffset(Offset="0x8")]
		public static CinemachineVirtualCamera.DestroyPipelineDelegate DestroyPipelineOverride;

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1067338", Offset="0x1067338")]
		[FieldOffset(Offset="0xA4")]
		private bool <UserIsDragging>k__BackingField;

		[FieldOffset(Offset="0xA8")]
		private CameraState m_State;

		[FieldOffset(Offset="0x178")]
		private CinemachineComponentBase[] m_ComponentPipeline;

		[Attribute(Name="HideInInspector", RVA="0x1067348", Offset="0x1067348")]
		[FieldOffset(Offset="0x180")]
		[SerializeField]
		private Transform m_ComponentOwner;

		public override Transform Follow
		{
			[Address(RVA="0x145A04C", Offset="0x145A04C", VA="0x145A04C", Slot="27")]
			get
			{
				return null;
			}
			[Address(RVA="0x145A054", Offset="0x145A054", VA="0x145A054", Slot="28")]
			set
			{
			}
		}

		public override Transform LookAt
		{
			[Address(RVA="0x145A03C", Offset="0x145A03C", VA="0x145A03C", Slot="25")]
			get
			{
				return null;
			}
			[Address(RVA="0x145A044", Offset="0x145A044", VA="0x145A044", Slot="26")]
			set
			{
			}
		}

		public override CameraState State
		{
			[Address(RVA="0x145A02C", Offset="0x145A02C", VA="0x145A02C", Slot="22")]
			get
			{
				return new CameraState();
			}
		}

		public bool UserIsDragging
		{
			[Address(RVA="0x145A8A4", Offset="0x145A8A4", VA="0x145A8A4")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108AC14", Offset="0x108AC14")]
			get
			{
				return new bool();
			}
			[Address(RVA="0x145D098", Offset="0x145D098", VA="0x145D098")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108AC24", Offset="0x108AC24")]
			set
			{
			}
		}

		[Address(RVA="0x145D310", Offset="0x145D310", VA="0x145D310")]
		public CinemachineVirtualCamera()
		{
		}

		[Address(RVA="0x16A7A48", Offset="0x16A7A48", VA="0x16A7A48")]
		public T AddCinemachineComponent<T>()
		where T : CinemachineComponentBase
		{
			return null;
		}

		[Address(RVA="0x145D15C", Offset="0x145D15C", VA="0x145D15C")]
		private CinemachineCore.Stage AdvancePipelineStage(ref CameraState state, float deltaTime, CinemachineCore.Stage curStage, int maxStage)
		{
			return new CinemachineCore.Stage();
		}

		[Address(RVA="0x145A588", Offset="0x145A588", VA="0x145A588")]
		private CameraState CalculateNewState(Vector3 worldUp, float deltaTime)
		{
			return new CameraState();
		}

		[Address(RVA="0x145BD48", Offset="0x145BD48", VA="0x145BD48")]
		private Transform CreatePipeline(CinemachineVirtualCamera copyFrom)
		{
			return null;
		}

		[Address(RVA="0x199FDC4", Offset="0x199FDC4", VA="0x199FDC4")]
		public void DestroyCinemachineComponent<T>()
		where T : CinemachineComponentBase
		{
		}

		[Address(RVA="0x145B0FC", Offset="0x145B0FC", VA="0x145B0FC")]
		private void DestroyPipeline()
		{
		}

		[Address(RVA="0x145AAE8", Offset="0x145AAE8", VA="0x145AAE8")]
		public CinemachineComponentBase GetCinemachineComponent(CinemachineCore.Stage stage)
		{
			return null;
		}

		[Address(RVA="0x16A7CA4", Offset="0x16A7CA4", VA="0x16A7CA4")]
		public T GetCinemachineComponent<T>()
		where T : CinemachineComponentBase
		{
			return null;
		}

		[Address(RVA="0x145C90C", Offset="0x145C90C", VA="0x145C90C")]
		public Transform GetComponentOwner()
		{
			return null;
		}

		[Address(RVA="0x145BFA8", Offset="0x145BFA8", VA="0x145BFA8")]
		public CinemachineComponentBase[] GetComponentPipeline()
		{
			return null;
		}

		[Address(RVA="0x145AA64", Offset="0x145AA64", VA="0x145AA64")]
		public void InvalidateComponentPipeline()
		{
		}

		[Address(RVA="0x145AB8C", Offset="0x145AB8C", VA="0x145AB8C", Slot="32")]
		protected override void OnDestroy()
		{
		}

		[Address(RVA="0x145A8AC", Offset="0x145A8AC", VA="0x145A8AC", Slot="34")]
		protected override void OnEnable()
		{
		}

		[Address(RVA="0x145D0A4", Offset="0x145D0A4", VA="0x145D0A4")]
		public void OnPositionDragged(Vector3 delta)
		{
		}

		[Address(RVA="0x145B0F0", Offset="0x145B0F0", VA="0x145B0F0")]
		private void OnTransformChildrenChanged()
		{
		}

		[Address(RVA="0x145AFAC", Offset="0x145AFAC", VA="0x145AFAC", Slot="33")]
		protected override void OnValidate()
		{
		}

		[Address(RVA="0x145A2F0", Offset="0x145A2F0", VA="0x145A2F0")]
		private CameraState PullStateFromVirtualCamera(Vector3 worldUp)
		{
			return new CameraState();
		}

		[Address(RVA="0x145B0F8", Offset="0x145B0F8", VA="0x145B0F8")]
		private void Reset()
		{
		}

		[Address(RVA="0x145D304", Offset="0x145D304", VA="0x145D304")]
		internal void SetStateRawPosition(Vector3 pos)
		{
		}

		[Address(RVA="0x145A05C", Offset="0x145A05C", VA="0x145A05C", Slot="29")]
		public override void UpdateCameraState(Vector3 worldUp, float deltaTime)
		{
		}

		[Address(RVA="0x145C930", Offset="0x145C930", VA="0x145C930")]
		private void UpdateComponentPipeline()
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x105139C", Offset="0x105139C")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static CinemachineVirtualCamera.<>c <>9;

			[FieldOffset(Offset="0x8")]
			public static Comparison<CinemachineComponentBase> <>9__39_0;

			[Address(RVA="0x145D3DC", Offset="0x145D3DC", VA="0x145D3DC")]
			static <>c()
			{
			}

			[Address(RVA="0x145D440", Offset="0x145D440", VA="0x145D440")]
			public <>c()
			{
			}

			[Address(RVA="0x145D448", Offset="0x145D448", VA="0x145D448")]
			internal int <UpdateComponentPipeline>b__39_0(CinemachineComponentBase c1, CinemachineComponentBase c2)
			{
				return new int();
			}
		}

		public delegate Transform CreatePipelineDelegate(CinemachineVirtualCamera vcam, string name, CinemachineComponentBase[] copyFrom);

		public delegate void DestroyPipelineDelegate(GameObject pipeline);
	}
}