using Il2CppDummyDll;
using System;

namespace Cinemachine
{
	[Attribute(Name="AddComponentMenu", RVA="0x104A914", Offset="0x104A914")]
	[Attribute(Name="DocumentationSortingAttribute", RVA="0x104A914", Offset="0x104A914")]
	[Attribute(Name="RequireComponent", RVA="0x104A914", Offset="0x104A914")]
	[Attribute(Name="SaveDuringPlayAttribute", RVA="0x104A914", Offset="0x104A914")]
	public class CinemachineSameAsFollowObject : CinemachineComponentBase
	{
		public override bool IsValid
		{
			[Address(RVA="0x14521FC", Offset="0x14521FC", VA="0x14521FC", Slot="4")]
			get
			{
				return new bool();
			}
		}

		public override CinemachineCore.Stage Stage
		{
			[Address(RVA="0x145229C", Offset="0x145229C", VA="0x145229C", Slot="6")]
			get
			{
				return new CinemachineCore.Stage();
			}
		}

		[Address(RVA="0x1452328", Offset="0x1452328", VA="0x1452328")]
		public CinemachineSameAsFollowObject()
		{
		}

		[Address(RVA="0x14522A4", Offset="0x14522A4", VA="0x14522A4", Slot="7")]
		public override void MutateCameraState(ref CameraState curState, float deltaTime)
		{
		}
	}
}