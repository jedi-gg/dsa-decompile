using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Cinemachine
{
	[Attribute(Name="AddComponentMenu", RVA="0x104A090", Offset="0x104A090")]
	[Attribute(Name="DisallowMultipleComponent", RVA="0x104A090", Offset="0x104A090")]
	[Attribute(Name="DocumentationSortingAttribute", RVA="0x104A090", Offset="0x104A090")]
	[Attribute(Name="ExecuteInEditMode", RVA="0x104A090", Offset="0x104A090")]
	public class CinemachineMixingCamera : CinemachineVirtualCameraBase
	{
		[FieldOffset(Offset="0x0")]
		public const int MaxCameras = 8;

		[Attribute(Name="TooltipAttribute", RVA="0x1066B94", Offset="0x1066B94")]
		[FieldOffset(Offset="0x74")]
		public float m_Weight0;

		[Attribute(Name="TooltipAttribute", RVA="0x1066BCC", Offset="0x1066BCC")]
		[FieldOffset(Offset="0x78")]
		public float m_Weight1;

		[Attribute(Name="TooltipAttribute", RVA="0x1066C04", Offset="0x1066C04")]
		[FieldOffset(Offset="0x7C")]
		public float m_Weight2;

		[Attribute(Name="TooltipAttribute", RVA="0x1066C3C", Offset="0x1066C3C")]
		[FieldOffset(Offset="0x80")]
		public float m_Weight3;

		[Attribute(Name="TooltipAttribute", RVA="0x1066C74", Offset="0x1066C74")]
		[FieldOffset(Offset="0x84")]
		public float m_Weight4;

		[Attribute(Name="TooltipAttribute", RVA="0x1066CAC", Offset="0x1066CAC")]
		[FieldOffset(Offset="0x88")]
		public float m_Weight5;

		[Attribute(Name="TooltipAttribute", RVA="0x1066CE4", Offset="0x1066CE4")]
		[FieldOffset(Offset="0x8C")]
		public float m_Weight6;

		[Attribute(Name="TooltipAttribute", RVA="0x1066D1C", Offset="0x1066D1C")]
		[FieldOffset(Offset="0x90")]
		public float m_Weight7;

		[FieldOffset(Offset="0x98")]
		private CameraState m_State;

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1066D54", Offset="0x1066D54")]
		[FieldOffset(Offset="0x168")]
		private ICinemachineCamera <LiveChild>k__BackingField;

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1066D64", Offset="0x1066D64")]
		[FieldOffset(Offset="0x170")]
		private Transform <LookAt>k__BackingField;

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1066D74", Offset="0x1066D74")]
		[FieldOffset(Offset="0x178")]
		private Transform <Follow>k__BackingField;

		[FieldOffset(Offset="0x180")]
		private CinemachineVirtualCameraBase[] m_ChildCameras;

		[FieldOffset(Offset="0x188")]
		private Dictionary<CinemachineVirtualCameraBase, int> m_indexMap;

		public CinemachineVirtualCameraBase[] ChildCameras
		{
			[Address(RVA="0x1D525C0", Offset="0x1D525C0", VA="0x1D525C0")]
			get
			{
				return null;
			}
		}

		public override Transform Follow
		{
			[Address(RVA="0x1D520C8", Offset="0x1D520C8", VA="0x1D520C8", Slot="27")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108ABD4", Offset="0x108ABD4")]
			get
			{
				return null;
			}
			[Address(RVA="0x1D520D0", Offset="0x1D520D0", VA="0x1D520D0", Slot="28")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108ABE4", Offset="0x108ABE4")]
			set
			{
			}
		}

		private ICinemachineCamera LiveChild
		{
			[Address(RVA="0x1D520A0", Offset="0x1D520A0", VA="0x1D520A0")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108ABA4", Offset="0x108ABA4")]
			get
			{
				return null;
			}
			[Address(RVA="0x1D52098", Offset="0x1D52098", VA="0x1D52098")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108AB94", Offset="0x108AB94")]
			set
			{
			}
		}

		public override ICinemachineCamera LiveChildOrSelf
		{
			[Address(RVA="0x1D520D8", Offset="0x1D520D8", VA="0x1D520D8", Slot="23")]
			get
			{
				return null;
			}
		}

		public override Transform LookAt
		{
			[Address(RVA="0x1D520B8", Offset="0x1D520B8", VA="0x1D520B8", Slot="25")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108ABB4", Offset="0x108ABB4")]
			get
			{
				return null;
			}
			[Address(RVA="0x1D520C0", Offset="0x1D520C0", VA="0x1D520C0", Slot="26")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108ABC4", Offset="0x108ABC4")]
			set
			{
			}
		}

		public override CameraState State
		{
			[Address(RVA="0x1D520A8", Offset="0x1D520A8", VA="0x1D520A8", Slot="22")]
			get
			{
				return new CameraState();
			}
		}

		[Address(RVA="0x1D52810", Offset="0x1D52810", VA="0x1D52810")]
		public CinemachineMixingCamera()
		{
		}

		[Address(RVA="0x1D51BC4", Offset="0x1D51BC4", VA="0x1D51BC4")]
		public float GetWeight(int index)
		{
			return new float();
		}

		[Address(RVA="0x1D51E04", Offset="0x1D51E04", VA="0x1D51E04")]
		public float GetWeight(CinemachineVirtualCameraBase vcam)
		{
			return new float();
		}

		[Address(RVA="0x1D523F8", Offset="0x1D523F8", VA="0x1D523F8")]
		protected void InvalidateListOfChildren()
		{
		}

		[Address(RVA="0x1D524C8", Offset="0x1D524C8", VA="0x1D524C8", Slot="24")]
		public override bool IsLiveChild(ICinemachineCamera vcam)
		{
			return new bool();
		}

		[Address(RVA="0x1D523CC", Offset="0x1D523CC", VA="0x1D523CC", Slot="34")]
		protected override void OnEnable()
		{
		}

		[Address(RVA="0x1D52404", Offset="0x1D52404", VA="0x1D52404")]
		public void OnTransformChildrenChanged()
		{
		}

		[Address(RVA="0x1D52410", Offset="0x1D52410", VA="0x1D52410", Slot="33")]
		protected override void OnValidate()
		{
		}

		[Address(RVA="0x1D520E0", Offset="0x1D520E0", VA="0x1D520E0", Slot="20")]
		public override void RemovePostPipelineStageHook(CinemachineVirtualCameraBase.OnPostPipelineStageDelegate d)
		{
		}

		[Address(RVA="0x1D51CDC", Offset="0x1D51CDC", VA="0x1D51CDC")]
		public void SetWeight(int index, float w)
		{
		}

		[Address(RVA="0x1D51F44", Offset="0x1D51F44", VA="0x1D51F44")]
		public void SetWeight(CinemachineVirtualCameraBase vcam, float w)
		{
		}

		[Address(RVA="0x1D525E4", Offset="0x1D525E4", VA="0x1D525E4", Slot="29")]
		public override void UpdateCameraState(Vector3 worldUp, float deltaTime)
		{
		}

		[Address(RVA="0x1D52188", Offset="0x1D52188", VA="0x1D52188")]
		protected void ValidateListOfChildren()
		{
		}
	}
}