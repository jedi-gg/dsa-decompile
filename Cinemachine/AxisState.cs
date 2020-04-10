using Il2CppDummyDll;
using System;

namespace Cinemachine
{
	[Attribute(Name="DocumentationSortingAttribute", RVA="0x104AB24", Offset="0x104AB24")]
	[Serializable]
	public struct AxisState
	{
		[Attribute(Name="NoSaveDuringPlayAttribute", RVA="0x1068D20", Offset="0x1068D20")]
		[Attribute(Name="TooltipAttribute", RVA="0x1068D20", Offset="0x1068D20")]
		[FieldOffset(Offset="0x0")]
		public float Value;

		[Attribute(Name="TooltipAttribute", RVA="0x1068D6C", Offset="0x1068D6C")]
		[FieldOffset(Offset="0x4")]
		public float m_MaxSpeed;

		[Attribute(Name="TooltipAttribute", RVA="0x1068DA4", Offset="0x1068DA4")]
		[FieldOffset(Offset="0x8")]
		public float m_AccelTime;

		[Attribute(Name="TooltipAttribute", RVA="0x1068DDC", Offset="0x1068DDC")]
		[FieldOffset(Offset="0xC")]
		public float m_DecelTime;

		[Attribute(Name="FormerlySerializedAsAttribute", RVA="0x1068E14", Offset="0x1068E14")]
		[Attribute(Name="TooltipAttribute", RVA="0x1068E14", Offset="0x1068E14")]
		[FieldOffset(Offset="0x10")]
		public string m_InputAxisName;

		[Attribute(Name="NoSaveDuringPlayAttribute", RVA="0x1068E74", Offset="0x1068E74")]
		[Attribute(Name="TooltipAttribute", RVA="0x1068E74", Offset="0x1068E74")]
		[FieldOffset(Offset="0x18")]
		public float m_InputAxisValue;

		[Attribute(Name="NoSaveDuringPlayAttribute", RVA="0x1068EC0", Offset="0x1068EC0")]
		[Attribute(Name="TooltipAttribute", RVA="0x1068EC0", Offset="0x1068EC0")]
		[FieldOffset(Offset="0x1C")]
		public bool m_InvertAxis;

		[FieldOffset(Offset="0x20")]
		private float mCurrentSpeed;

		[FieldOffset(Offset="0x24")]
		private float mMinValue;

		[FieldOffset(Offset="0x28")]
		private float mMaxValue;

		[FieldOffset(Offset="0x2C")]
		private bool mWrapAround;

		[FieldOffset(Offset="0x0")]
		private const float Epsilon = 0.0001f;

		[Address(RVA="0xF2E048", Offset="0xF2E048", VA="0xF2E048")]
		public AxisState(float maxSpeed, float accelTime, float decelTime, float val, string name, bool invert)
		{
		}

		[Address(RVA="0xF2E08C", Offset="0xF2E08C", VA="0xF2E08C")]
		private float GetMaxSpeed()
		{
			return new float();
		}

		[Address(RVA="0xF2E074", Offset="0xF2E074", VA="0xF2E074")]
		public void SetThresholds(float minValue, float maxValue, bool wrapAround)
		{
		}

		[Address(RVA="0xF2E084", Offset="0xF2E084", VA="0xF2E084")]
		public bool Update(float deltaTime)
		{
			return new bool();
		}

		[Address(RVA="0xF2E06C", Offset="0xF2E06C", VA="0xF2E06C")]
		public void Validate()
		{
		}
	}
}