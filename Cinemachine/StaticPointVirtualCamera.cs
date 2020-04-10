using Il2CppDummyDll;
using System;
using UnityEngine;

namespace Cinemachine
{
	internal class StaticPointVirtualCamera : ICinemachineCamera
	{
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1065D0C", Offset="0x1065D0C")]
		[FieldOffset(Offset="0x10")]
		private string <Name>k__BackingField;

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1065D1C", Offset="0x1065D1C")]
		[FieldOffset(Offset="0x18")]
		private int <Priority>k__BackingField;

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1065D2C", Offset="0x1065D2C")]
		[FieldOffset(Offset="0x20")]
		private Transform <LookAt>k__BackingField;

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1065D3C", Offset="0x1065D3C")]
		[FieldOffset(Offset="0x28")]
		private Transform <Follow>k__BackingField;

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1065D4C", Offset="0x1065D4C")]
		[FieldOffset(Offset="0x30")]
		private CameraState <State>k__BackingField;

		public string Description
		{
			[Address(RVA="0x145FF48", Offset="0x145FF48", VA="0x145FF48", Slot="5")]
			get
			{
				return null;
			}
		}

		public Transform Follow
		{
			[Address(RVA="0x145FFB0", Offset="0x145FFB0", VA="0x145FFB0", Slot="10")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108AA64", Offset="0x108AA64")]
			get
			{
				return null;
			}
			[Address(RVA="0x145FFB8", Offset="0x145FFB8", VA="0x145FFB8", Slot="11")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108AA74", Offset="0x108AA74")]
			set
			{
			}
		}

		public ICinemachineCamera LiveChildOrSelf
		{
			[Address(RVA="0x145FFD8", Offset="0x145FFD8", VA="0x145FFD8", Slot="14")]
			get
			{
				return null;
			}
		}

		public Transform LookAt
		{
			[Address(RVA="0x145FFA0", Offset="0x145FFA0", VA="0x145FFA0", Slot="8")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108AA44", Offset="0x108AA44")]
			get
			{
				return null;
			}
			[Address(RVA="0x145FFA8", Offset="0x145FFA8", VA="0x145FFA8", Slot="9")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108AA54", Offset="0x108AA54")]
			set
			{
			}
		}

		public string Name
		{
			[Address(RVA="0x145FF40", Offset="0x145FF40", VA="0x145FF40", Slot="4")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108AA04", Offset="0x108AA04")]
			get
			{
				return JustDecompileGenerated_get_Name();
			}
			[Address(RVA="0x145FF1C", Offset="0x145FF1C", VA="0x145FF1C")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108AA14", Offset="0x108AA14")]
			set
			{
				JustDecompileGenerated_set_Name(value);
			}
		}

		public string JustDecompileGenerated_get_Name()
		{
			return null;
		}

		private void JustDecompileGenerated_set_Name(string value)
		{
		}

		public ICinemachineCamera ParentCamera
		{
			[Address(RVA="0x145FFDC", Offset="0x145FFDC", VA="0x145FFDC", Slot="15")]
			get
			{
				return null;
			}
		}

		public int Priority
		{
			[Address(RVA="0x145FF90", Offset="0x145FF90", VA="0x145FF90", Slot="6")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108AA24", Offset="0x108AA24")]
			get
			{
				return new int();
			}
			[Address(RVA="0x145FF98", Offset="0x145FF98", VA="0x145FF98", Slot="7")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108AA34", Offset="0x108AA34")]
			set
			{
			}
		}

		public CameraState State
		{
			[Address(RVA="0x145FFC0", Offset="0x145FFC0", VA="0x145FFC0", Slot="12")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108AA84", Offset="0x108AA84")]
			get
			{
				return JustDecompileGenerated_get_State();
			}
			[Address(RVA="0x145FF00", Offset="0x145FF00", VA="0x145FF00")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108AA94", Offset="0x108AA94")]
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
			[Address(RVA="0x145FFD0", Offset="0x145FFD0", VA="0x145FFD0", Slot="13")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1456510", Offset="0x1456510", VA="0x1456510")]
		public StaticPointVirtualCamera(CameraState state, string name)
		{
		}

		[Address(RVA="0x145FFE4", Offset="0x145FFE4", VA="0x145FFE4", Slot="16")]
		public bool IsLiveChild(ICinemachineCamera vcam)
		{
			return new bool();
		}

		[Address(RVA="0x145FFF0", Offset="0x145FFF0", VA="0x145FFF0", Slot="18")]
		public void OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime)
		{
		}

		[Address(RVA="0x145FF24", Offset="0x145FF24", VA="0x145FF24")]
		public void SetState(CameraState state)
		{
		}

		[Address(RVA="0x145FFEC", Offset="0x145FFEC", VA="0x145FFEC", Slot="17")]
		public void UpdateCameraState(Vector3 worldUp, float deltaTime)
		{
		}
	}
}