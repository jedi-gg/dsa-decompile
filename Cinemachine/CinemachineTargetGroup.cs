using Il2CppDummyDll;
using System;
using UnityEngine;

namespace Cinemachine
{
	[Attribute(Name="AddComponentMenu", RVA="0x104A27C", Offset="0x104A27C")]
	[Attribute(Name="DocumentationSortingAttribute", RVA="0x104A27C", Offset="0x104A27C")]
	[Attribute(Name="ExecuteInEditMode", RVA="0x104A27C", Offset="0x104A27C")]
	[Attribute(Name="SaveDuringPlayAttribute", RVA="0x104A27C", Offset="0x104A27C")]
	public class CinemachineTargetGroup : MonoBehaviour
	{
		[Attribute(Name="TooltipAttribute", RVA="0x106713C", Offset="0x106713C")]
		[FieldOffset(Offset="0x18")]
		public CinemachineTargetGroup.PositionMode m_PositionMode;

		[Attribute(Name="TooltipAttribute", RVA="0x1067174", Offset="0x1067174")]
		[FieldOffset(Offset="0x1C")]
		public CinemachineTargetGroup.RotationMode m_RotationMode;

		[Attribute(Name="TooltipAttribute", RVA="0x10671AC", Offset="0x10671AC")]
		[FieldOffset(Offset="0x20")]
		public CinemachineTargetGroup.UpdateMethod m_UpdateMethod;

		[Attribute(Name="NoSaveDuringPlayAttribute", RVA="0x10671E4", Offset="0x10671E4")]
		[Attribute(Name="TooltipAttribute", RVA="0x10671E4", Offset="0x10671E4")]
		[FieldOffset(Offset="0x28")]
		public CinemachineTargetGroup.Target[] m_Targets;

		[FieldOffset(Offset="0x30")]
		private float m_lastRadius;

		public Bounds BoundingBox
		{
			[Address(RVA="0x1456710", Offset="0x1456710", VA="0x1456710")]
			get
			{
				return new Bounds();
			}
		}

		public bool IsEmpty
		{
			[Address(RVA="0x1456E58", Offset="0x1456E58", VA="0x1456E58")]
			get
			{
				return new bool();
			}
		}

		[Address(RVA="0x1457908", Offset="0x1457908", VA="0x1457908")]
		public CinemachineTargetGroup()
		{
		}

		[Address(RVA="0x1457404", Offset="0x1457404", VA="0x1457404")]
		private Quaternion CalculateAverageOrientation()
		{
			return new Quaternion();
		}

		[Address(RVA="0x1456ADC", Offset="0x1456ADC", VA="0x1456ADC")]
		private Vector3 CalculateAveragePosition(out float averageWeight)
		{
			averageWeight = 0f;
			return new Vector3();
		}

		[Address(RVA="0x1457774", Offset="0x1457774", VA="0x1457774")]
		private void FixedUpdate()
		{
		}

		[Address(RVA="0x1456F94", Offset="0x1456F94", VA="0x1456F94")]
		public Bounds GetViewSpaceBoundingBox(Matrix4x4 mView)
		{
			return new Bounds();
		}

		[Address(RVA="0x14578F4", Offset="0x14578F4", VA="0x14578F4")]
		private void LateUpdate()
		{
		}

		[Address(RVA="0x1457644", Offset="0x1457644", VA="0x1457644")]
		private void OnValidate()
		{
		}

		[Address(RVA="0x14578B4", Offset="0x14578B4", VA="0x14578B4")]
		private void Update()
		{
		}

		[Address(RVA="0x1457788", Offset="0x1457788", VA="0x1457788")]
		private void UpdateTransform()
		{
		}

		[Attribute(Name="DocumentationSortingAttribute", RVA="0x1051364", Offset="0x1051364")]
		public enum PositionMode
		{
			[FieldOffset(Offset="0x0")]
			GroupCenter,
			[FieldOffset(Offset="0x0")]
			GroupAverage
		}

		[Attribute(Name="DocumentationSortingAttribute", RVA="0x1051380", Offset="0x1051380")]
		public enum RotationMode
		{
			[FieldOffset(Offset="0x0")]
			Manual,
			[FieldOffset(Offset="0x0")]
			GroupAverage
		}

		[Attribute(Name="DocumentationSortingAttribute", RVA="0x1051348", Offset="0x1051348")]
		[Serializable]
		public struct Target
		{
			[Attribute(Name="TooltipAttribute", RVA="0x106D1C4", Offset="0x106D1C4")]
			[FieldOffset(Offset="0x0")]
			public Transform target;

			[Attribute(Name="TooltipAttribute", RVA="0x106D1FC", Offset="0x106D1FC")]
			[FieldOffset(Offset="0x8")]
			public float weight;

			[Attribute(Name="TooltipAttribute", RVA="0x106D234", Offset="0x106D234")]
			[FieldOffset(Offset="0xC")]
			public float radius;
		}

		public enum UpdateMethod
		{
			[FieldOffset(Offset="0x0")]
			Update,
			[FieldOffset(Offset="0x0")]
			FixedUpdate,
			[FieldOffset(Offset="0x0")]
			LateUpdate
		}
	}
}