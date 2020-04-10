using Il2CppDummyDll;
using System;

namespace Cinemachine
{
	[Attribute(Name="AddComponentMenu", RVA="0x104A704", Offset="0x104A704")]
	[Attribute(Name="DocumentationSortingAttribute", RVA="0x104A704", Offset="0x104A704")]
	[Attribute(Name="RequireComponent", RVA="0x104A704", Offset="0x104A704")]
	[Attribute(Name="SaveDuringPlayAttribute", RVA="0x104A704", Offset="0x104A704")]
	public class CinemachineHardLookAt : CinemachineComponentBase
	{
		public override bool IsValid
		{
			[Address(RVA="0x1D518B0", Offset="0x1D518B0", VA="0x1D518B0", Slot="4")]
			get
			{
				return new bool();
			}
		}

		public override CinemachineCore.Stage Stage
		{
			[Address(RVA="0x1D5194C", Offset="0x1D5194C", VA="0x1D5194C", Slot="6")]
			get
			{
				return new CinemachineCore.Stage();
			}
		}

		[Address(RVA="0x1D51BBC", Offset="0x1D51BBC", VA="0x1D51BBC")]
		public CinemachineHardLookAt()
		{
		}

		[Address(RVA="0x1D51954", Offset="0x1D51954", VA="0x1D51954", Slot="7")]
		public override void MutateCameraState(ref CameraState curState, float deltaTime)
		{
		}
	}
}