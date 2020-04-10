using Il2CppDummyDll;
using System;
using UnityEngine;

namespace Cinemachine
{
	[Attribute(Name="AddComponentMenu", RVA="0x104AA74", Offset="0x104AA74")]
	[Attribute(Name="DocumentationSortingAttribute", RVA="0x104AA74", Offset="0x104AA74")]
	[Attribute(Name="RequireComponent", RVA="0x104AA74", Offset="0x104AA74")]
	[Attribute(Name="SaveDuringPlayAttribute", RVA="0x104AA74", Offset="0x104AA74")]
	public class CinemachineTransposer : CinemachineComponentBase
	{
		[Attribute(Name="TooltipAttribute", RVA="0x1068AB8", Offset="0x1068AB8")]
		[FieldOffset(Offset="0x20")]
		public CinemachineTransposer.BindingMode m_BindingMode;

		[Attribute(Name="TooltipAttribute", RVA="0x1068AF0", Offset="0x1068AF0")]
		[FieldOffset(Offset="0x24")]
		public Vector3 m_FollowOffset;

		[Attribute(Name="RangeAttribute", RVA="0x1068B28", Offset="0x1068B28")]
		[Attribute(Name="TooltipAttribute", RVA="0x1068B28", Offset="0x1068B28")]
		[FieldOffset(Offset="0x30")]
		public float m_XDamping;

		[Attribute(Name="RangeAttribute", RVA="0x1068B7C", Offset="0x1068B7C")]
		[Attribute(Name="TooltipAttribute", RVA="0x1068B7C", Offset="0x1068B7C")]
		[FieldOffset(Offset="0x34")]
		public float m_YDamping;

		[Attribute(Name="RangeAttribute", RVA="0x1068BD0", Offset="0x1068BD0")]
		[Attribute(Name="TooltipAttribute", RVA="0x1068BD0", Offset="0x1068BD0")]
		[FieldOffset(Offset="0x38")]
		public float m_ZDamping;

		[Attribute(Name="RangeAttribute", RVA="0x1068C24", Offset="0x1068C24")]
		[Attribute(Name="TooltipAttribute", RVA="0x1068C24", Offset="0x1068C24")]
		[FieldOffset(Offset="0x3C")]
		public float m_PitchDamping;

		[Attribute(Name="RangeAttribute", RVA="0x1068C78", Offset="0x1068C78")]
		[Attribute(Name="TooltipAttribute", RVA="0x1068C78", Offset="0x1068C78")]
		[FieldOffset(Offset="0x40")]
		public float m_YawDamping;

		[Attribute(Name="RangeAttribute", RVA="0x1068CCC", Offset="0x1068CCC")]
		[Attribute(Name="TooltipAttribute", RVA="0x1068CCC", Offset="0x1068CCC")]
		[FieldOffset(Offset="0x44")]
		public float m_RollDamping;

		[FieldOffset(Offset="0x48")]
		private Vector3 m_PreviousTargetPosition;

		[FieldOffset(Offset="0x54")]
		private Quaternion m_PreviousReferenceOrientation;

		[FieldOffset(Offset="0x64")]
		private Quaternion m_targetOrientationOnAssign;

		[FieldOffset(Offset="0x78")]
		private Transform m_previousTarget;

		protected Vector3 AngularDamping
		{
			[Address(RVA="0x1459B28", Offset="0x1459B28", VA="0x1459B28")]
			get
			{
				return new Vector3();
			}
		}

		protected Vector3 Damping
		{
			[Address(RVA="0x1459C18", Offset="0x1459C18", VA="0x1459C18")]
			get
			{
				return new Vector3();
			}
		}

		protected Vector3 EffectiveOffset
		{
			[Address(RVA="0x1458CA0", Offset="0x1458CA0", VA="0x1458CA0")]
			get
			{
				return new Vector3();
			}
		}

		public override bool IsValid
		{
			[Address(RVA="0x1458D34", Offset="0x1458D34", VA="0x1458D34", Slot="4")]
			get
			{
				return new bool();
			}
		}

		public override CinemachineCore.Stage Stage
		{
			[Address(RVA="0x1458DD4", Offset="0x1458DD4", VA="0x1458DD4", Slot="6")]
			get
			{
				return new CinemachineCore.Stage();
			}
		}

		[Address(RVA="0x1459F40", Offset="0x1459F40", VA="0x1459F40")]
		public CinemachineTransposer()
		{
		}

		[Address(RVA="0x1459C78", Offset="0x1459C78", VA="0x1459C78")]
		public Vector3 GeTargetCameraPosition(Vector3 worldUp)
		{
			return new Vector3();
		}

		[Address(RVA="0x14597DC", Offset="0x14597DC", VA="0x14597DC")]
		public Quaternion GetReferenceOrientation(Vector3 worldUp)
		{
			return new Quaternion();
		}

		[Address(RVA="0x1458FC4", Offset="0x1458FC4", VA="0x1458FC4")]
		protected void InitPrevFrameStateInfo(ref CameraState curState, float deltaTime)
		{
		}

		[Address(RVA="0x1458DDC", Offset="0x1458DDC", VA="0x1458DDC", Slot="7")]
		public override void MutateCameraState(ref CameraState curState, float deltaTime)
		{
		}

		[Address(RVA="0x1459654", Offset="0x1459654", VA="0x1459654", Slot="8")]
		public override void OnPositionDragged(Vector3 delta)
		{
		}

		[Address(RVA="0x1458C78", Offset="0x1458C78", VA="0x1458C78", Slot="9")]
		protected virtual void OnValidate()
		{
		}

		[Address(RVA="0x1459148", Offset="0x1459148", VA="0x1459148")]
		protected void TrackTarget(float deltaTime, Vector3 up, Vector3 desiredCameraOffset, out Vector3 outTargetPosition, out Quaternion outTargetOrient)
		{
			outTargetPosition = new Vector3();
			outTargetOrient = new Quaternion();
		}

		[Address(RVA="0x1459E30", Offset="0x1459E30", VA="0x1459E30")]
		private static Quaternion Uppify(Quaternion q, Vector3 up)
		{
			return new Quaternion();
		}

		[Attribute(Name="DocumentationSortingAttribute", RVA="0x1051460", Offset="0x1051460")]
		public enum BindingMode
		{
			[FieldOffset(Offset="0x0")]
			LockToTargetOnAssign,
			[FieldOffset(Offset="0x0")]
			LockToTargetWithWorldUp,
			[FieldOffset(Offset="0x0")]
			LockToTargetNoRoll,
			[FieldOffset(Offset="0x0")]
			LockToTarget,
			[FieldOffset(Offset="0x0")]
			WorldSpace,
			[FieldOffset(Offset="0x0")]
			SimpleFollowWithWorldUp
		}
	}
}