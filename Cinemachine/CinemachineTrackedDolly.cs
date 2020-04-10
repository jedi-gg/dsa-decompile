using Il2CppDummyDll;
using System;
using UnityEngine;

namespace Cinemachine
{
	[Attribute(Name="AddComponentMenu", RVA="0x104A9C4", Offset="0x104A9C4")]
	[Attribute(Name="DocumentationSortingAttribute", RVA="0x104A9C4", Offset="0x104A9C4")]
	[Attribute(Name="RequireComponent", RVA="0x104A9C4", Offset="0x104A9C4")]
	[Attribute(Name="SaveDuringPlayAttribute", RVA="0x104A9C4", Offset="0x104A9C4")]
	public class CinemachineTrackedDolly : CinemachineComponentBase
	{
		[Attribute(Name="TooltipAttribute", RVA="0x1068770", Offset="0x1068770")]
		[FieldOffset(Offset="0x20")]
		public CinemachinePathBase m_Path;

		[Attribute(Name="TooltipAttribute", RVA="0x10687A8", Offset="0x10687A8")]
		[FieldOffset(Offset="0x28")]
		public float m_PathPosition;

		[Attribute(Name="TooltipAttribute", RVA="0x10687E0", Offset="0x10687E0")]
		[FieldOffset(Offset="0x2C")]
		public CinemachinePathBase.PositionUnits m_PositionUnits;

		[Attribute(Name="TooltipAttribute", RVA="0x1068818", Offset="0x1068818")]
		[FieldOffset(Offset="0x30")]
		public Vector3 m_PathOffset;

		[Attribute(Name="RangeAttribute", RVA="0x1068850", Offset="0x1068850")]
		[Attribute(Name="TooltipAttribute", RVA="0x1068850", Offset="0x1068850")]
		[FieldOffset(Offset="0x3C")]
		public float m_XDamping;

		[Attribute(Name="RangeAttribute", RVA="0x10688A4", Offset="0x10688A4")]
		[Attribute(Name="TooltipAttribute", RVA="0x10688A4", Offset="0x10688A4")]
		[FieldOffset(Offset="0x40")]
		public float m_YDamping;

		[Attribute(Name="RangeAttribute", RVA="0x10688F8", Offset="0x10688F8")]
		[Attribute(Name="TooltipAttribute", RVA="0x10688F8", Offset="0x10688F8")]
		[FieldOffset(Offset="0x44")]
		public float m_ZDamping;

		[Attribute(Name="TooltipAttribute", RVA="0x106894C", Offset="0x106894C")]
		[FieldOffset(Offset="0x48")]
		public CinemachineTrackedDolly.CameraUpMode m_CameraUp;

		[Attribute(Name="RangeAttribute", RVA="0x1068984", Offset="0x1068984")]
		[Attribute(Name="TooltipAttribute", RVA="0x1068984", Offset="0x1068984")]
		[FieldOffset(Offset="0x4C")]
		public float m_PitchDamping;

		[Attribute(Name="RangeAttribute", RVA="0x10689D8", Offset="0x10689D8")]
		[Attribute(Name="TooltipAttribute", RVA="0x10689D8", Offset="0x10689D8")]
		[FieldOffset(Offset="0x50")]
		public float m_YawDamping;

		[Attribute(Name="RangeAttribute", RVA="0x1068A2C", Offset="0x1068A2C")]
		[Attribute(Name="TooltipAttribute", RVA="0x1068A2C", Offset="0x1068A2C")]
		[FieldOffset(Offset="0x54")]
		public float m_RollDamping;

		[Attribute(Name="TooltipAttribute", RVA="0x1068A80", Offset="0x1068A80")]
		[FieldOffset(Offset="0x58")]
		public CinemachineTrackedDolly.AutoDolly m_AutoDolly;

		[FieldOffset(Offset="0x68")]
		private float m_PreviousPathPosition;

		[FieldOffset(Offset="0x6C")]
		private Quaternion m_PreviousOrientation;

		[FieldOffset(Offset="0x7C")]
		private Vector3 m_PreviousCameraPosition;

		private Vector3 AngularDamping
		{
			[Address(RVA="0x14588C0", Offset="0x14588C0", VA="0x14588C0")]
			get
			{
				return new Vector3();
			}
		}

		public override bool IsValid
		{
			[Address(RVA="0x1457970", Offset="0x1457970", VA="0x1457970", Slot="4")]
			get
			{
				return new bool();
			}
		}

		public override CinemachineCore.Stage Stage
		{
			[Address(RVA="0x1457A00", Offset="0x1457A00", VA="0x1457A00", Slot="6")]
			get
			{
				return new CinemachineCore.Stage();
			}
		}

		[Address(RVA="0x1458B98", Offset="0x1458B98", VA="0x1458B98")]
		public CinemachineTrackedDolly()
		{
		}

		[Address(RVA="0x1458544", Offset="0x1458544", VA="0x1458544")]
		private Quaternion GetTargetOrientationAtPathPoint(Quaternion pathOrientation, Vector3 up)
		{
			return new Quaternion();
		}

		[Address(RVA="0x1457A08", Offset="0x1457A08", VA="0x1457A08", Slot="7")]
		public override void MutateCameraState(ref CameraState curState, float deltaTime)
		{
		}

		[Address(RVA="0x1458A28", Offset="0x1458A28", VA="0x1458A28", Slot="8")]
		public override void OnPositionDragged(Vector3 delta)
		{
		}

		[Attribute(Name="DocumentationSortingAttribute", RVA="0x1051444", Offset="0x1051444")]
		[Serializable]
		public struct AutoDolly
		{
			[Attribute(Name="TooltipAttribute", RVA="0x106D4B4", Offset="0x106D4B4")]
			[FieldOffset(Offset="0x0")]
			public bool m_Enabled;

			[Attribute(Name="TooltipAttribute", RVA="0x106D4EC", Offset="0x106D4EC")]
			[FieldOffset(Offset="0x4")]
			public float m_PositionOffset;

			[Attribute(Name="TooltipAttribute", RVA="0x106D524", Offset="0x106D524")]
			[FieldOffset(Offset="0x8")]
			public int m_SearchRadius;

			[Attribute(Name="FormerlySerializedAsAttribute", RVA="0x106D55C", Offset="0x106D55C")]
			[Attribute(Name="TooltipAttribute", RVA="0x106D55C", Offset="0x106D55C")]
			[FieldOffset(Offset="0xC")]
			public int m_SearchResolution;

			[Address(RVA="0xF01100", Offset="0xF01100", VA="0xF01100")]
			public AutoDolly(bool enabled, float positionOffset, int searchRadius, int stepsPerSegment)
			{
			}
		}

		[Attribute(Name="DocumentationSortingAttribute", RVA="0x1051428", Offset="0x1051428")]
		public enum CameraUpMode
		{
			[FieldOffset(Offset="0x0")]
			Default,
			[FieldOffset(Offset="0x0")]
			Path,
			[FieldOffset(Offset="0x0")]
			PathNoRoll,
			[FieldOffset(Offset="0x0")]
			FollowTarget,
			[FieldOffset(Offset="0x0")]
			FollowTargetNoRoll
		}
	}
}