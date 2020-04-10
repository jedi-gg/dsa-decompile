using Il2CppDummyDll;
using System;

namespace Cinemachine
{
	[Attribute(Name="AddComponentMenu", RVA="0x104A654", Offset="0x104A654")]
	[Attribute(Name="DocumentationSortingAttribute", RVA="0x104A654", Offset="0x104A654")]
	[Attribute(Name="RequireComponent", RVA="0x104A654", Offset="0x104A654")]
	[Attribute(Name="SaveDuringPlayAttribute", RVA="0x104A654", Offset="0x104A654")]
	public class CinemachineHardLockToTarget : CinemachineComponentBase
	{
		public override bool IsValid
		{
			[Address(RVA="0x1D517A8", Offset="0x1D517A8", VA="0x1D517A8", Slot="4")]
			get
			{
				return new bool();
			}
		}

		public override CinemachineCore.Stage Stage
		{
			[Address(RVA="0x1D51844", Offset="0x1D51844", VA="0x1D51844", Slot="6")]
			get
			{
				return new CinemachineCore.Stage();
			}
		}

		[Address(RVA="0x1D518A8", Offset="0x1D518A8", VA="0x1D518A8")]
		public CinemachineHardLockToTarget()
		{
		}

		[Address(RVA="0x1D5184C", Offset="0x1D5184C", VA="0x1D5184C", Slot="7")]
		public override void MutateCameraState(ref CameraState curState, float deltaTime)
		{
		}
	}
}