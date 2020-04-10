using Il2CppDummyDll;
using System;
using UnityEngine;

namespace Cinemachine
{
	[Attribute(Name="DocumentationSortingAttribute", RVA="0x1049EA8", Offset="0x1049EA8")]
	[Attribute(Name="ExecuteInEditMode", RVA="0x1049EA8", Offset="0x1049EA8")]
	public class CinemachineDollyCart : MonoBehaviour
	{
		[Attribute(Name="TooltipAttribute", RVA="0x1066470", Offset="0x1066470")]
		[FieldOffset(Offset="0x18")]
		public CinemachinePathBase m_Path;

		[Attribute(Name="TooltipAttribute", RVA="0x10664A8", Offset="0x10664A8")]
		[FieldOffset(Offset="0x20")]
		public CinemachineDollyCart.UpdateMethod m_UpdateMethod;

		[Attribute(Name="TooltipAttribute", RVA="0x10664E0", Offset="0x10664E0")]
		[FieldOffset(Offset="0x24")]
		public CinemachinePathBase.PositionUnits m_PositionUnits;

		[Attribute(Name="FormerlySerializedAsAttribute", RVA="0x1066518", Offset="0x1066518")]
		[Attribute(Name="TooltipAttribute", RVA="0x1066518", Offset="0x1066518")]
		[FieldOffset(Offset="0x28")]
		public float m_Speed;

		[Attribute(Name="FormerlySerializedAsAttribute", RVA="0x1066578", Offset="0x1066578")]
		[Attribute(Name="TooltipAttribute", RVA="0x1066578", Offset="0x1066578")]
		[FieldOffset(Offset="0x2C")]
		public float m_Position;

		[Address(RVA="0x1D49470", Offset="0x1D49470", VA="0x1D49470")]
		public CinemachineDollyCart()
		{
		}

		[Address(RVA="0x1D491F0", Offset="0x1D491F0", VA="0x1D491F0")]
		private void FixedUpdate()
		{
		}

		[Address(RVA="0x1D4924C", Offset="0x1D4924C", VA="0x1D4924C")]
		private void SetCartPosition(float distanceAlongPath)
		{
		}

		[Address(RVA="0x1D49404", Offset="0x1D49404", VA="0x1D49404")]
		private void Update()
		{
		}

		public enum UpdateMethod
		{
			[FieldOffset(Offset="0x0")]
			Update,
			[FieldOffset(Offset="0x0")]
			FixedUpdate
		}
	}
}