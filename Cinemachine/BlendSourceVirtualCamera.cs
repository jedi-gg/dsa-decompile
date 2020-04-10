using Il2CppDummyDll;
using System;
using UnityEngine;

namespace Cinemachine
{
	internal class BlendSourceVirtualCamera : ICinemachineCamera
	{
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1065D5C", Offset="0x1065D5C")]
		[FieldOffset(Offset="0x10")]
		private CinemachineBlend <Blend>k__BackingField;

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1065D6C", Offset="0x1065D6C")]
		[FieldOffset(Offset="0x18")]
		private int <Priority>k__BackingField;

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1065D7C", Offset="0x1065D7C")]
		[FieldOffset(Offset="0x20")]
		private Transform <LookAt>k__BackingField;

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1065D8C", Offset="0x1065D8C")]
		[FieldOffset(Offset="0x28")]
		private Transform <Follow>k__BackingField;

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1065D9C", Offset="0x1065D9C")]
		[FieldOffset(Offset="0x30")]
		private CameraState <State>k__BackingField;

		public CinemachineBlend Blend
		{
			[Address(RVA="0x1D39D40", Offset="0x1D39D40", VA="0x1D39D40")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108AAA4", Offset="0x108AAA4")]
			get
			{
				return null;
			}
			[Address(RVA="0x1D39C84", Offset="0x1D39C84", VA="0x1D39C84")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108AAB4", Offset="0x108AAB4")]
			private set
			{
			}
		}

		public string Description
		{
			[Address(RVA="0x1D39D90", Offset="0x1D39D90", VA="0x1D39D90", Slot="5")]
			get
			{
				return null;
			}
		}

		public Transform Follow
		{
			[Address(RVA="0x1D39FE4", Offset="0x1D39FE4", VA="0x1D39FE4", Slot="10")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108AB04", Offset="0x108AB04")]
			get
			{
				return null;
			}
			[Address(RVA="0x1D39FEC", Offset="0x1D39FEC", VA="0x1D39FEC", Slot="11")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108AB14", Offset="0x108AB14")]
			set
			{
			}
		}

		public ICinemachineCamera LiveChildOrSelf
		{
			[Address(RVA="0x1D3A028", Offset="0x1D3A028", VA="0x1D3A028", Slot="14")]
			get
			{
				return null;
			}
		}

		public Transform LookAt
		{
			[Address(RVA="0x1D39FD4", Offset="0x1D39FD4", VA="0x1D39FD4", Slot="8")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108AAE4", Offset="0x108AAE4")]
			get
			{
				return null;
			}
			[Address(RVA="0x1D39FDC", Offset="0x1D39FDC", VA="0x1D39FDC", Slot="9")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108AAF4", Offset="0x108AAF4")]
			set
			{
			}
		}

		public string Name
		{
			[Address(RVA="0x1D39D48", Offset="0x1D39D48", VA="0x1D39D48", Slot="4")]
			get
			{
				return null;
			}
		}

		public ICinemachineCamera ParentCamera
		{
			[Address(RVA="0x1D3A05C", Offset="0x1D3A05C", VA="0x1D3A05C", Slot="15")]
			get
			{
				return null;
			}
		}

		public int Priority
		{
			[Address(RVA="0x1D39FC4", Offset="0x1D39FC4", VA="0x1D39FC4", Slot="6")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108AAC4", Offset="0x108AAC4")]
			get
			{
				return new int();
			}
			[Address(RVA="0x1D39FCC", Offset="0x1D39FCC", VA="0x1D39FCC", Slot="7")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108AAD4", Offset="0x108AAD4")]
			set
			{
			}
		}

		public CameraState State
		{
			[Address(RVA="0x1D39FF4", Offset="0x1D39FF4", VA="0x1D39FF4", Slot="12")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108AB24", Offset="0x108AB24")]
			get
			{
				return JustDecompileGenerated_get_State();
			}
			[Address(RVA="0x1D3A004", Offset="0x1D3A004", VA="0x1D3A004")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108AB34", Offset="0x108AB34")]
			set
			{
				JustDecompileGenerated_set_State(value);
			}
		}

		public CameraState JustDecompileGenerated_get_State()
		{
			return new CameraState();
		}

		private void JustDecompileGenerated_set_State(CameraState value)
		{
		}

		public GameObject VirtualCameraGameObject
		{
			[Address(RVA="0x1D3A020", Offset="0x1D3A020", VA="0x1D3A020", Slot="13")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1D39B74", Offset="0x1D39B74", VA="0x1D39B74")]
		public BlendSourceVirtualCamera(CinemachineBlend blend, float deltaTime)
		{
		}

		[Address(RVA="0x1D3A0CC", Offset="0x1D3A0CC", VA="0x1D3A0CC")]
		public CameraState CalculateNewState(float deltaTime)
		{
			return new CameraState();
		}

		[Address(RVA="0x1D3A064", Offset="0x1D3A064", VA="0x1D3A064", Slot="16")]
		public bool IsLiveChild(ICinemachineCamera vcam)
		{
			return new bool();
		}

		[Address(RVA="0x1D3A390", Offset="0x1D3A390", VA="0x1D3A390", Slot="18")]
		public void OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime)
		{
		}

		[Address(RVA="0x1D39CA0", Offset="0x1D39CA0", VA="0x1D39CA0", Slot="17")]
		public void UpdateCameraState(Vector3 worldUp, float deltaTime)
		{
		}
	}
}