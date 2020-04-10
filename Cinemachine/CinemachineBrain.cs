using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.Events;

namespace Cinemachine
{
	[Attribute(Name="AddComponentMenu", RVA="0x1049CC8", Offset="0x1049CC8")]
	[Attribute(Name="DisallowMultipleComponent", RVA="0x1049CC8", Offset="0x1049CC8")]
	[Attribute(Name="DocumentationSortingAttribute", RVA="0x1049CC8", Offset="0x1049CC8")]
	[Attribute(Name="ExecuteInEditMode", RVA="0x1049CC8", Offset="0x1049CC8")]
	[Attribute(Name="SaveDuringPlayAttribute", RVA="0x1049CC8", Offset="0x1049CC8")]
	public class CinemachineBrain : MonoBehaviour
	{
		[Attribute(Name="TooltipAttribute", RVA="0x1065AD0", Offset="0x1065AD0")]
		[FieldOffset(Offset="0x18")]
		public bool m_ShowDebugText;

		[Attribute(Name="TooltipAttribute", RVA="0x1065B08", Offset="0x1065B08")]
		[FieldOffset(Offset="0x19")]
		public bool m_ShowCameraFrustum;

		[Attribute(Name="TooltipAttribute", RVA="0x1065B40", Offset="0x1065B40")]
		[FieldOffset(Offset="0x1A")]
		public bool m_IgnoreTimeScale;

		[Attribute(Name="TooltipAttribute", RVA="0x1065B78", Offset="0x1065B78")]
		[FieldOffset(Offset="0x20")]
		public Transform m_WorldUpOverride;

		[Attribute(Name="TooltipAttribute", RVA="0x1065BB0", Offset="0x1065BB0")]
		[FieldOffset(Offset="0x28")]
		public CinemachineBrain.UpdateMethod m_UpdateMethod;

		[Attribute(Name="CinemachineBlendDefinitionPropertyAttribute", RVA="0x1065BE8", Offset="0x1065BE8")]
		[Attribute(Name="TooltipAttribute", RVA="0x1065BE8", Offset="0x1065BE8")]
		[FieldOffset(Offset="0x2C")]
		public CinemachineBlendDefinition m_DefaultBlend;

		[Attribute(Name="TooltipAttribute", RVA="0x1065C34", Offset="0x1065C34")]
		[FieldOffset(Offset="0x38")]
		public CinemachineBlenderSettings m_CustomBlends;

		[FieldOffset(Offset="0x40")]
		private Camera m_OutputCamera;

		[Attribute(Name="TooltipAttribute", RVA="0x1065C6C", Offset="0x1065C6C")]
		[FieldOffset(Offset="0x48")]
		public CinemachineBrain.BrainEvent m_CameraCutEvent;

		[Attribute(Name="TooltipAttribute", RVA="0x1065CA4", Offset="0x1065CA4")]
		[FieldOffset(Offset="0x50")]
		public CinemachineBrain.VcamEvent m_CameraActivatedEvent;

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1065CDC", Offset="0x1065CDC")]
		[FieldOffset(Offset="0x58")]
		private Component <PostProcessingComponent>k__BackingField;

		[FieldOffset(Offset="0x0")]
		internal static CinemachineBrain.BrainEvent sPostProcessingHandler;

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1065CEC", Offset="0x1065CEC")]
		[FieldOffset(Offset="0x8")]
		private static ICinemachineCamera <SoloCamera>k__BackingField;

		[FieldOffset(Offset="0x60")]
		private ICinemachineCamera mActiveCameraPreviousFrame;

		[FieldOffset(Offset="0x68")]
		private ICinemachineCamera mOutgoingCameraPreviousFrame;

		[FieldOffset(Offset="0x70")]
		private CinemachineBlend mActiveBlend;

		[FieldOffset(Offset="0x78")]
		private bool mPreviousFrameWasOverride;

		[FieldOffset(Offset="0x80")]
		private List<CinemachineBrain.OverrideStackFrame> mOverrideStack;

		[FieldOffset(Offset="0x88")]
		private int mNextOverrideId;

		[FieldOffset(Offset="0x90")]
		private CinemachineBrain.OverrideStackFrame mOverrideBlendFromNothing;

		[FieldOffset(Offset="0x98")]
		private WaitForFixedUpdate mWaitForFixedUpdate;

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1065CFC", Offset="0x1065CFC")]
		[FieldOffset(Offset="0xA0")]
		private CameraState <CurrentCameraState>k__BackingField;

		[FieldOffset(Offset="0x10")]
		private static int msCurrentFrame;

		[FieldOffset(Offset="0x14")]
		private static int msFirstBrainObjectId;

		[FieldOffset(Offset="0x18")]
		private static int msSubframes;

		public CinemachineBlend ActiveBlend
		{
			[Address(RVA="0x1D3FA00", Offset="0x1D3FA00", VA="0x1D3FA00")]
			get
			{
				return null;
			}
		}

		public ICinemachineCamera ActiveVirtualCamera
		{
			[Address(RVA="0x1D3F950", Offset="0x1D3F950", VA="0x1D3F950")]
			get
			{
				return null;
			}
		}

		public CameraState CurrentCameraState
		{
			[Address(RVA="0x1D40598", Offset="0x1D40598", VA="0x1D40598")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108A9E4", Offset="0x108A9E4")]
			get
			{
				return new CameraState();
			}
			[Address(RVA="0x1D405A8", Offset="0x1D405A8", VA="0x1D405A8")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108A9F4", Offset="0x108A9F4")]
			private set
			{
			}
		}

		public Vector3 DefaultWorldUp
		{
			[Address(RVA="0x1D3E0EC", Offset="0x1D3E0EC", VA="0x1D3E0EC")]
			get
			{
				return new Vector3();
			}
		}

		public bool IsBlending
		{
			[Address(RVA="0x1D40364", Offset="0x1D40364", VA="0x1D40364")]
			get
			{
				return new bool();
			}
		}

		public Camera OutputCamera
		{
			[Address(RVA="0x1D3DEF4", Offset="0x1D3DEF4", VA="0x1D3DEF4")]
			get
			{
				return null;
			}
		}

		internal Component PostProcessingComponent
		{
			[Address(RVA="0x1D3DF8C", Offset="0x1D3DF8C", VA="0x1D3DF8C")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108A940", Offset="0x108A940")]
			get
			{
				return null;
			}
			[Address(RVA="0x1D3DF94", Offset="0x1D3DF94", VA="0x1D3DF94")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108A950", Offset="0x108A950")]
			set
			{
			}
		}

		public static ICinemachineCamera SoloCamera
		{
			[Address(RVA="0x1D3DF9C", Offset="0x1D3DF9C", VA="0x1D3DF9C")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108A960", Offset="0x108A960")]
			get
			{
				return null;
			}
			[Address(RVA="0x1D3E004", Offset="0x1D3E004", VA="0x1D3E004")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108A970", Offset="0x108A970")]
			set
			{
			}
		}

		[Address(RVA="0x1D40A10", Offset="0x1D40A10", VA="0x1D40A10")]
		static CinemachineBrain()
		{
		}

		[Address(RVA="0x1D40860", Offset="0x1D40860", VA="0x1D40860")]
		public CinemachineBrain()
		{
		}

		[Address(RVA="0x1D40694", Offset="0x1D40694", VA="0x1D40694")]
		private void AddSubframe()
		{
		}

		[Address(RVA="0x1D3EF3C", Offset="0x1D3EF3C", VA="0x1D3EF3C")]
		[Attribute(Name="IteratorStateMachineAttribute", RVA="0x108A980", Offset="0x108A980")]
		private IEnumerator AfterPhysics()
		{
			return null;
		}

		[Address(RVA="0x1D3FCCC", Offset="0x1D3FCCC", VA="0x1D3FCCC")]
		private CinemachineBlend CreateBlend(ICinemachineCamera camA, ICinemachineCamera camB, AnimationCurve blendCurve, float duration, CinemachineBlend activeBlend)
		{
			return null;
		}

		[Address(RVA="0x1D3E6F8", Offset="0x1D3E6F8", VA="0x1D3E6F8")]
		private CinemachineBrain.OverrideStackFrame GetActiveOverride()
		{
			return null;
		}

		[Address(RVA="0x1D3F038", Offset="0x1D3F038", VA="0x1D3F038")]
		private float GetEffectiveDeltaTime(bool fixedDelta)
		{
			return new float();
		}

		[Address(RVA="0x1D3E32C", Offset="0x1D3E32C", VA="0x1D3E32C")]
		private CinemachineBrain.OverrideStackFrame GetNextActiveFrame(int overrideId)
		{
			return null;
		}

		[Address(RVA="0x1D3E1C4", Offset="0x1D3E1C4", VA="0x1D3E1C4")]
		private CinemachineBrain.OverrideStackFrame GetOverrideFrame(int id)
		{
			return null;
		}

		[Address(RVA="0x1D3E070", Offset="0x1D3E070", VA="0x1D3E070")]
		public static Color GetSoloGUIColor()
		{
			return new Color();
		}

		[Address(RVA="0x1D407C8", Offset="0x1D407C8", VA="0x1D407C8")]
		internal static int GetSubframeCount()
		{
			return new int();
		}

		[Address(RVA="0x1D403B8", Offset="0x1D403B8", VA="0x1D403B8")]
		public bool IsLive(ICinemachineCamera vcam)
		{
			return new bool();
		}

		[Address(RVA="0x1D40520", Offset="0x1D40520", VA="0x1D40520")]
		private bool IsLiveItself(ICinemachineCamera vcam)
		{
			return new bool();
		}

		[Address(RVA="0x1D3EFDC", Offset="0x1D3EFDC", VA="0x1D3EFDC")]
		private void LateUpdate()
		{
		}

		[Address(RVA="0x1D3FA88", Offset="0x1D3FA88", VA="0x1D3FA88")]
		private AnimationCurve LookupBlendCurve(ICinemachineCamera fromKey, ICinemachineCamera toKey, out float duration)
		{
			duration = 0f;
			return null;
		}

		[Address(RVA="0x1D3EC54", Offset="0x1D3EC54", VA="0x1D3EC54")]
		private void OnDisable()
		{
		}

		[Address(RVA="0x1D3EB50", Offset="0x1D3EB50", VA="0x1D3EB50")]
		private void OnEnable()
		{
		}

		[Address(RVA="0x1D3F158", Offset="0x1D3F158", VA="0x1D3F158")]
		private void ProcessActiveCamera(float deltaTime)
		{
		}

		[Address(RVA="0x1D400E4", Offset="0x1D400E4", VA="0x1D400E4")]
		private void PushStateToUnityCamera(CameraState state, ICinemachineCamera vcam)
		{
		}

		[Address(RVA="0x1D3EA44", Offset="0x1D3EA44", VA="0x1D3EA44")]
		internal void ReleaseCameraOverride(int overrideId)
		{
		}

		[Address(RVA="0x1D3E7EC", Offset="0x1D3E7EC", VA="0x1D3E7EC")]
		internal int SetCameraOverride(int overrideId, ICinemachineCamera camA, ICinemachineCamera camB, float weightB, float deltaTime)
		{
			return new int();
		}

		[Address(RVA="0x1D3ED6C", Offset="0x1D3ED6C", VA="0x1D3ED6C")]
		private void Start()
		{
		}

		[Address(RVA="0x1D3E4C8", Offset="0x1D3E4C8", VA="0x1D3E4C8")]
		private ICinemachineCamera TopCameraFromPriorityQueue()
		{
			return null;
		}

		[Address(RVA="0x1D3EDA8", Offset="0x1D3EDA8", VA="0x1D3EDA8")]
		private void UpdateVirtualCameras(CinemachineCore.UpdateFilter updateFilter, float deltaTime)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10512D4", Offset="0x10512D4")]
		private sealed class <AfterPhysics>d__44 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[FieldOffset(Offset="0x10")]
			private int <>1__state;

			[FieldOffset(Offset="0x18")]
			private object <>2__current;

			[FieldOffset(Offset="0x20")]
			public CinemachineBrain <>4__this;

			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Address(RVA="0x1D40C44", Offset="0x1D40C44", VA="0x1D40C44", Slot="4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System.Collections.IEnumerator.Current
			{
				[Address(RVA="0x1D40CB4", Offset="0x1D40CB4", VA="0x1D40CB4", Slot="7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Address(RVA="0x1D3EFB0", Offset="0x1D3EFB0", VA="0x1D3EFB0")]
			[DebuggerHidden]
			public <AfterPhysics>d__44(int u003cu003e1__state)
			{
			}

			[Address(RVA="0x1D40A7C", Offset="0x1D40A7C", VA="0x1D40A7C", Slot="6")]
			private bool MoveNext()
			{
				return new bool();
			}

			[Address(RVA="0x1D40C4C", Offset="0x1D40C4C", VA="0x1D40C4C", Slot="8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Address(RVA="0x1D40A78", Offset="0x1D40A78", VA="0x1D40A78", Slot="5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}
		}

		[Serializable]
		public class BrainEvent : UnityEvent<CinemachineBrain>
		{
			[Address(RVA="0x1D40970", Offset="0x1D40970", VA="0x1D40970")]
			public BrainEvent()
			{
			}
		}

		private class OverrideStackFrame
		{
			[FieldOffset(Offset="0x10")]
			public int id;

			[FieldOffset(Offset="0x18")]
			public ICinemachineCamera camera;

			[FieldOffset(Offset="0x20")]
			public CinemachineBlend blend;

			[FieldOffset(Offset="0x28")]
			public float deltaTime;

			[FieldOffset(Offset="0x2C")]
			public float timeOfOverride;

			public bool Active
			{
				[Address(RVA="0x1D3E4B8", Offset="0x1D3E4B8", VA="0x1D3E4B8")]
				get
				{
					return new bool();
				}
			}

			public bool Expired
			{
				[Address(RVA="0x1D3F730", Offset="0x1D3F730", VA="0x1D3F730")]
				get
				{
					return new bool();
				}
			}

			[Address(RVA="0x1D3E324", Offset="0x1D3E324", VA="0x1D3E324")]
			public OverrideStackFrame()
			{
			}
		}

		[Attribute(Name="DocumentationSortingAttribute", RVA="0x10512B8", Offset="0x10512B8")]
		public enum UpdateMethod
		{
			[FieldOffset(Offset="0x0")]
			FixedUpdate,
			[FieldOffset(Offset="0x0")]
			LateUpdate,
			[FieldOffset(Offset="0x0")]
			SmartUpdate
		}

		[Serializable]
		public class VcamEvent : UnityEvent<ICinemachineCamera>
		{
			[Address(RVA="0x1D409C0", Offset="0x1D409C0", VA="0x1D409C0")]
			public VcamEvent()
			{
			}
		}
	}
}