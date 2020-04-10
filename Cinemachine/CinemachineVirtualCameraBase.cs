using Il2CppDummyDll;
using System;
using UnityEngine;

namespace Cinemachine
{
	[Attribute(Name="SaveDuringPlayAttribute", RVA="0x104ABBC", Offset="0x104ABBC")]
	public abstract class CinemachineVirtualCameraBase : MonoBehaviour, ICinemachineCamera
	{
		[Attribute(Name="HideInInspector", RVA="0x1069164", Offset="0x1069164")]
		[Attribute(Name="NoSaveDuringPlayAttribute", RVA="0x1069164", Offset="0x1069164")]
		[FieldOffset(Offset="0x18")]
		public Action CinemachineGUIDebuggerCallback;

		[Attribute(Name="HideInInspector", RVA="0x106919C", Offset="0x106919C")]
		[Attribute(Name="NoSaveDuringPlayAttribute", RVA="0x106919C", Offset="0x106919C")]
		[FieldOffset(Offset="0x20")]
		[SerializeField]
		public string[] m_ExcludedPropertiesInInspector;

		[Attribute(Name="HideInInspector", RVA="0x10691E4", Offset="0x10691E4")]
		[Attribute(Name="NoSaveDuringPlayAttribute", RVA="0x10691E4", Offset="0x10691E4")]
		[FieldOffset(Offset="0x28")]
		[SerializeField]
		public CinemachineCore.Stage[] m_LockStageInInspector;

		[FieldOffset(Offset="0x30")]
		private int m_ValidatingStreamVersion;

		[FieldOffset(Offset="0x34")]
		private bool m_OnValidateCalled;

		[Attribute(Name="HideInInspector", RVA="0x106922C", Offset="0x106922C")]
		[Attribute(Name="NoSaveDuringPlayAttribute", RVA="0x106922C", Offset="0x106922C")]
		[FieldOffset(Offset="0x38")]
		[SerializeField]
		private int m_StreamingVersion;

		[Attribute(Name="NoSaveDuringPlayAttribute", RVA="0x1069274", Offset="0x1069274")]
		[Attribute(Name="TooltipAttribute", RVA="0x1069274", Offset="0x1069274")]
		[FieldOffset(Offset="0x3C")]
		public int m_Priority;

		[FieldOffset(Offset="0x40")]
		protected CinemachineVirtualCameraBase.OnPostPipelineStageDelegate OnPostPipelineStage;

		[FieldOffset(Offset="0x48")]
		private bool m_previousStateIsValid;

		[FieldOffset(Offset="0x50")]
		private Transform m_previousLookAtTarget;

		[FieldOffset(Offset="0x58")]
		private Transform m_previousFollowTarget;

		[FieldOffset(Offset="0x60")]
		private bool mSlaveStatusUpdated;

		[FieldOffset(Offset="0x68")]
		private CinemachineVirtualCameraBase m_parentVcam;

		[FieldOffset(Offset="0x70")]
		private int m_QueuePriority;

		public virtual string Description
		{
			[Address(RVA="0x145DEA8", Offset="0x145DEA8", VA="0x145DEA8", Slot="21")]
			get
			{
				return null;
			}
		}

		public abstract Transform Follow
		{
			get;
			set;
		}

		public virtual ICinemachineCamera LiveChildOrSelf
		{
			[Address(RVA="0x145DEF8", Offset="0x145DEF8", VA="0x145DEF8", Slot="23")]
			get
			{
				return null;
			}
		}

		public abstract Transform LookAt
		{
			get;
			set;
		}

		public string Name
		{
			[Address(RVA="0x145DEA0", Offset="0x145DEA0", VA="0x145DEA0", Slot="4")]
			get
			{
				return null;
			}
		}

		public ICinemachineCamera ParentCamera
		{
			[Address(RVA="0x145DE64", Offset="0x145DE64", VA="0x145DE64", Slot="15")]
			get
			{
				return null;
			}
		}

		public bool PreviousStateIsValid
		{
			[Address(RVA="0x1455190", Offset="0x1455190", VA="0x1455190")]
			get
			{
				return new bool();
			}
			[Address(RVA="0x1455D54", Offset="0x1455D54", VA="0x1455D54")]
			set
			{
			}
		}

		public int Priority
		{
			[Address(RVA="0x1456508", Offset="0x1456508", VA="0x1456508", Slot="6")]
			get
			{
				return new int();
			}
			[Address(RVA="0x145DEF0", Offset="0x145DEF0", VA="0x145DEF0", Slot="7")]
			set
			{
			}
		}

		public abstract CameraState State
		{
			get;
		}

		public int ValidatingStreamVersion
		{
			[Address(RVA="0x145AA6C", Offset="0x145AA6C", VA="0x145AA6C")]
			get
			{
				return new int();
			}
			[Address(RVA="0x145D534", Offset="0x145D534", VA="0x145D534")]
			private set
			{
			}
		}

		public GameObject VirtualCameraGameObject
		{
			[Address(RVA="0x14558E0", Offset="0x14558E0", VA="0x14558E0", Slot="13")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1456634", Offset="0x1456634", VA="0x1456634")]
		protected CinemachineVirtualCameraBase()
		{
		}

		[Address(RVA="0x145D53C", Offset="0x145D53C", VA="0x145D53C", Slot="19")]
		public virtual void AddPostPipelineStageHook(CinemachineVirtualCameraBase.OnPostPipelineStageDelegate d)
		{
		}

		[Address(RVA="0x145D1CC", Offset="0x145D1CC", VA="0x145D1CC")]
		protected void InvokePostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState newState, float deltaTime)
		{
		}

		[Address(RVA="0x145DFCC", Offset="0x145DFCC", VA="0x145DFCC", Slot="24")]
		public virtual bool IsLiveChild(ICinemachineCamera vcam)
		{
			return new bool();
		}

		[Address(RVA="0x145E1F4", Offset="0x145E1F4", VA="0x145E1F4")]
		public void MoveToTopOfPrioritySubqueue()
		{
		}

		[Address(RVA="0x145AF2C", Offset="0x145AF2C", VA="0x145AF2C", Slot="32")]
		protected virtual void OnDestroy()
		{
		}

		[Address(RVA="0x145E1B4", Offset="0x145E1B4", VA="0x145E1B4", Slot="35")]
		protected virtual void OnDisable()
		{
		}

		[Address(RVA="0x1455D8C", Offset="0x1455D8C", VA="0x1455D8C", Slot="34")]
		protected virtual void OnEnable()
		{
		}

		[Address(RVA="0x145E1D0", Offset="0x145E1D0", VA="0x145E1D0", Slot="37")]
		protected virtual void OnTransformParentChanged()
		{
		}

		[Address(RVA="0x145DFD4", Offset="0x145DFD4", VA="0x145DFD4", Slot="30")]
		public virtual void OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime)
		{
		}

		[Address(RVA="0x145AFD0", Offset="0x145AFD0", VA="0x145AFD0", Slot="33")]
		protected virtual void OnValidate()
		{
		}

		[Address(RVA="0x14549BC", Offset="0x14549BC", VA="0x14549BC", Slot="20")]
		public virtual void RemovePostPipelineStageHook(CinemachineVirtualCameraBase.OnPostPipelineStageDelegate d)
		{
		}

		[Address(RVA="0x14547F4", Offset="0x14547F4", VA="0x14547F4")]
		protected Transform ResolveFollow(Transform localFollow)
		{
			return null;
		}

		[Address(RVA="0x14546C8", Offset="0x14546C8", VA="0x14546C8")]
		protected Transform ResolveLookAt(Transform localLookAt)
		{
			return null;
		}

		[Address(RVA="0x145E018", Offset="0x145E018", VA="0x145E018", Slot="31")]
		protected virtual void Start()
		{
		}

		[Address(RVA="0x145E1B8", Offset="0x145E1B8", VA="0x145E1B8", Slot="36")]
		protected virtual void Update()
		{
		}

		public abstract void UpdateCameraState(Vector3 worldUp, float deltaTime);

		[Address(RVA="0x145DEFC", Offset="0x145DEFC", VA="0x145DEFC")]
		private void UpdateSlaveStatus()
		{
		}

		[Address(RVA="0x145E01C", Offset="0x145E01C", VA="0x145E01C")]
		private void UpdateVcamPoolStatus()
		{
		}

		public delegate void OnPostPipelineStageDelegate(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState newState, float deltaTime);
	}
}