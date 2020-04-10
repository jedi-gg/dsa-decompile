using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Cinemachine
{
	public sealed class CinemachineCore
	{
		[FieldOffset(Offset="0x0")]
		public readonly static int kStreamingVersion;

		[FieldOffset(Offset="0x8")]
		public readonly static string kVersionString;

		[FieldOffset(Offset="0x10")]
		private static CinemachineCore sInstance;

		[FieldOffset(Offset="0x18")]
		public static bool sShowHiddenObjects;

		[FieldOffset(Offset="0x20")]
		public static CinemachineCore.AxisInputDelegate GetInputAxis;

		[FieldOffset(Offset="0x10")]
		private List<CinemachineBrain> mActiveBrains;

		[FieldOffset(Offset="0x18")]
		private List<ICinemachineCamera> mActiveCameras;

		[FieldOffset(Offset="0x20")]
		private List<List<ICinemachineCamera>> mChildCameras;

		[FieldOffset(Offset="0x28")]
		private Dictionary<ICinemachineCamera, CinemachineCore.UpdateStatus> mUpdateStatus;

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10690A4", Offset="0x10690A4")]
		[FieldOffset(Offset="0x30")]
		private CinemachineCore.UpdateFilter <CurrentUpdateFilter>k__BackingField;

		public int BrainCount
		{
			[Address(RVA="0x1D48060", Offset="0x1D48060", VA="0x1D48060")]
			get
			{
				return new int();
			}
		}

		internal CinemachineCore.UpdateFilter CurrentUpdateFilter
		{
			[Address(RVA="0x1D48618", Offset="0x1D48618", VA="0x1D48618")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108AEF4", Offset="0x108AEF4")]
			get
			{
				return new CinemachineCore.UpdateFilter();
			}
			[Address(RVA="0x1D3F78C", Offset="0x1D3F78C", VA="0x1D3F78C")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108AF04", Offset="0x108AF04")]
			set
			{
			}
		}

		public static CinemachineCore Instance
		{
			[Address(RVA="0x1D3C1F4", Offset="0x1D3C1F4", VA="0x1D3C1F4")]
			get
			{
				return null;
			}
		}

		public int VirtualCameraCount
		{
			[Address(RVA="0x1D405C4", Offset="0x1D405C4", VA="0x1D405C4")]
			get
			{
				return new int();
			}
		}

		[Address(RVA="0x1D490CC", Offset="0x1D490CC", VA="0x1D490CC")]
		static CinemachineCore()
		{
		}

		[Address(RVA="0x1D47FA0", Offset="0x1D47FA0", VA="0x1D47FA0")]
		public CinemachineCore()
		{
		}

		[Address(RVA="0x1D3EBD4", Offset="0x1D3EBD4", VA="0x1D3EBD4")]
		internal void AddActiveBrain(CinemachineBrain brain)
		{
		}

		[Address(RVA="0x1D48130", Offset="0x1D48130", VA="0x1D48130")]
		internal void AddActiveCamera(ICinemachineCamera vcam)
		{
		}

		[Address(RVA="0x1D48384", Offset="0x1D48384", VA="0x1D48384")]
		internal void AddChildCamera(ICinemachineCamera vcam)
		{
		}

		[Address(RVA="0x1D48EEC", Offset="0x1D48EEC", VA="0x1D48EEC")]
		public CinemachineBrain FindPotentialTargetBrain(ICinemachineCamera vcam)
		{
			return null;
		}

		[Address(RVA="0x1D3D798", Offset="0x1D3D798", VA="0x1D3D798")]
		public void GenerateCameraActivationEvent(ICinemachineCamera vcam)
		{
		}

		[Address(RVA="0x1D3D8B0", Offset="0x1D3D8B0", VA="0x1D3D8B0")]
		public void GenerateCameraCutEvent(ICinemachineCamera vcam)
		{
		}

		[Address(RVA="0x1D480C0", Offset="0x1D480C0", VA="0x1D480C0")]
		public CinemachineBrain GetActiveBrain(int index)
		{
			return null;
		}

		[Address(RVA="0x1D486D8", Offset="0x1D486D8", VA="0x1D486D8")]
		private static bool GetTargetPosition(ICinemachineCamera vcam, out Matrix4x4 targetPos)
		{
			targetPos = new Matrix4x4();
			return new bool();
		}

		[Address(RVA="0x1D48D68", Offset="0x1D48D68", VA="0x1D48D68")]
		public CinemachineCore.UpdateFilter GetVcamUpdateStatus(ICinemachineCamera vcam)
		{
			return new CinemachineCore.UpdateFilter();
		}

		[Address(RVA="0x1D40624", Offset="0x1D40624", VA="0x1D40624")]
		public ICinemachineCamera GetVirtualCamera(int index)
		{
			return null;
		}

		[Address(RVA="0x1D48DFC", Offset="0x1D48DFC", VA="0x1D48DFC")]
		public bool IsLive(ICinemachineCamera vcam)
		{
			return new bool();
		}

		[Address(RVA="0x1D3ECFC", Offset="0x1D3ECFC", VA="0x1D3ECFC")]
		internal void RemoveActiveBrain(CinemachineBrain brain)
		{
		}

		[Address(RVA="0x1D48314", Offset="0x1D48314", VA="0x1D48314")]
		internal void RemoveActiveCamera(ICinemachineCamera vcam)
		{
		}

		[Address(RVA="0x1D48538", Offset="0x1D48538", VA="0x1D48538")]
		internal void RemoveChildCamera(ICinemachineCamera vcam)
		{
		}

		[Address(RVA="0x1D3F794", Offset="0x1D3F794", VA="0x1D3F794")]
		internal void UpdateAllActiveVirtualCameras(Vector3 worldUp, float deltaTime)
		{
		}

		[Address(RVA="0x1D3C2B0", Offset="0x1D3C2B0", VA="0x1D3C2B0")]
		internal bool UpdateVirtualCamera(ICinemachineCamera vcam, Vector3 worldUp, float deltaTime)
		{
			return new bool();
		}

		public delegate float AxisInputDelegate(string axisName);

		public enum Stage
		{
			[FieldOffset(Offset="0x0")]
			Body,
			[FieldOffset(Offset="0x0")]
			Aim,
			[FieldOffset(Offset="0x0")]
			Noise
		}

		public enum UpdateFilter
		{
			[FieldOffset(Offset="0x0")]
			Fixed,
			[FieldOffset(Offset="0x0")]
			ForcedFixed,
			[FieldOffset(Offset="0x0")]
			Late,
			[FieldOffset(Offset="0x0")]
			ForcedLate
		}

		private struct UpdateStatus
		{
			[FieldOffset(Offset="0x0")]
			private const int kWindowSize = 30;

			[FieldOffset(Offset="0x0")]
			public int lastUpdateFrame;

			[FieldOffset(Offset="0x4")]
			public int lastUpdateSubframe;

			[FieldOffset(Offset="0x8")]
			public int windowStart;

			[FieldOffset(Offset="0xC")]
			public int numWindowLateUpdateMoves;

			[FieldOffset(Offset="0x10")]
			public int numWindowFixedUpdateMoves;

			[FieldOffset(Offset="0x14")]
			public int numWindows;

			[FieldOffset(Offset="0x18")]
			public CinemachineCore.UpdateFilter preferredUpdate;

			[FieldOffset(Offset="0x1C")]
			public Matrix4x4 targetPos;

			[Address(RVA="0xF2E384", Offset="0xF2E384", VA="0xF2E384")]
			public UpdateStatus(int currentFrame)
			{
			}

			[Address(RVA="0xF2E38C", Offset="0xF2E38C", VA="0xF2E38C")]
			public CinemachineCore.UpdateFilter ChoosePreferredUpdate(int currentFrame, Matrix4x4 pos, CinemachineCore.UpdateFilter updateFilter)
			{
				return new CinemachineCore.UpdateFilter();
			}
		}
	}
}