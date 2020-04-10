using Il2CppDummyDll;
using System;
using UnityEngine;

namespace Cinemachine
{
	[Attribute(Name="AddComponentMenu", RVA="0x1049EE8", Offset="0x1049EE8")]
	[Attribute(Name="DisallowMultipleComponent", RVA="0x1049EE8", Offset="0x1049EE8")]
	[Attribute(Name="DocumentationSortingAttribute", RVA="0x1049EE8", Offset="0x1049EE8")]
	[Attribute(Name="ExecuteInEditMode", RVA="0x1049EE8", Offset="0x1049EE8")]
	[Attribute(Name="RequireComponent", RVA="0x1049EE8", Offset="0x1049EE8")]
	public class CinemachineExternalCamera : CinemachineVirtualCameraBase
	{
		[Attribute(Name="NoSaveDuringPlayAttribute", RVA="0x10665D8", Offset="0x10665D8")]
		[Attribute(Name="TooltipAttribute", RVA="0x10665D8", Offset="0x10665D8")]
		[FieldOffset(Offset="0x78")]
		public Transform m_LookAt;

		[FieldOffset(Offset="0x80")]
		private Camera m_Camera;

		[FieldOffset(Offset="0x88")]
		private CameraState m_State;

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1066624", Offset="0x1066624")]
		[FieldOffset(Offset="0x158")]
		private Transform <Follow>k__BackingField;

		public override Transform Follow
		{
			[Address(RVA="0x1D49670", Offset="0x1D49670", VA="0x1D49670", Slot="27")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108AB64", Offset="0x108AB64")]
			get
			{
				return null;
			}
			[Address(RVA="0x1D49678", Offset="0x1D49678", VA="0x1D49678", Slot="28")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108AB74", Offset="0x108AB74")]
			set
			{
			}
		}

		public override Transform LookAt
		{
			[Address(RVA="0x1D49660", Offset="0x1D49660", VA="0x1D49660", Slot="25")]
			get
			{
				return null;
			}
			[Address(RVA="0x1D49668", Offset="0x1D49668", VA="0x1D49668", Slot="26")]
			set
			{
			}
		}

		public override CameraState State
		{
			[Address(RVA="0x1D49650", Offset="0x1D49650", VA="0x1D49650", Slot="22")]
			get
			{
				return new CameraState();
			}
		}

		[Address(RVA="0x1D49ABC", Offset="0x1D49ABC", VA="0x1D49ABC")]
		public CinemachineExternalCamera()
		{
		}

		[Address(RVA="0x1D49680", Offset="0x1D49680", VA="0x1D49680", Slot="29")]
		public override void UpdateCameraState(Vector3 worldUp, float deltaTime)
		{
		}
	}
}