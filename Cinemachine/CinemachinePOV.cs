using Il2CppDummyDll;
using System;

namespace Cinemachine
{
	[Attribute(Name="AddComponentMenu", RVA="0x104A864", Offset="0x104A864")]
	[Attribute(Name="DocumentationSortingAttribute", RVA="0x104A864", Offset="0x104A864")]
	[Attribute(Name="RequireComponent", RVA="0x104A864", Offset="0x104A864")]
	[Attribute(Name="SaveDuringPlayAttribute", RVA="0x104A864", Offset="0x104A864")]
	public class CinemachinePOV : CinemachineComponentBase
	{
		[Attribute(Name="TooltipAttribute", RVA="0x1068700", Offset="0x1068700")]
		[FieldOffset(Offset="0x20")]
		public AxisState m_VerticalAxis;

		[Attribute(Name="TooltipAttribute", RVA="0x1068738", Offset="0x1068738")]
		[FieldOffset(Offset="0x50")]
		public AxisState m_HorizontalAxis;

		public override bool IsValid
		{
			[Address(RVA="0x144FBF0", Offset="0x144FBF0", VA="0x144FBF0", Slot="4")]
			get
			{
				return new bool();
			}
		}

		public override CinemachineCore.Stage Stage
		{
			[Address(RVA="0x144FBF8", Offset="0x144FBF8", VA="0x144FBF8", Slot="6")]
			get
			{
				return new CinemachineCore.Stage();
			}
		}

		[Address(RVA="0x144FEC0", Offset="0x144FEC0", VA="0x144FEC0")]
		public CinemachinePOV()
		{
		}

		[Address(RVA="0x144FC88", Offset="0x144FC88", VA="0x144FC88", Slot="7")]
		public override void MutateCameraState(ref CameraState curState, float deltaTime)
		{
		}

		[Address(RVA="0x144FC30", Offset="0x144FC30", VA="0x144FC30")]
		private void OnEnable()
		{
		}

		[Address(RVA="0x144FC00", Offset="0x144FC00", VA="0x144FC00")]
		private void OnValidate()
		{
		}
	}
}