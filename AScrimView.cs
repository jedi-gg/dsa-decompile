using Glunies;
using Il2CppDummyDll;
using System;

public class AScrimView : AView
{
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x105C180", Offset="0x105C180")]
	[FieldOffset(Offset="0x68")]
	private bool <ShowImmediately>k__BackingField;

	public override bool CanTriggerContextualMessages
	{
		[Address(RVA="0x10F4E9C", Offset="0x10F4E9C", VA="0x10F4E9C", Slot="7")]
		get
		{
			return new bool();
		}
	}

	public override ViewDepth Depth
	{
		[Address(RVA="0x10F4E94", Offset="0x10F4E94", VA="0x10F4E94", Slot="5")]
		get
		{
			return new ViewDepth();
		}
	}

	public bool ShowImmediately
	{
		[Address(RVA="0x10F4EA4", Offset="0x10F4EA4", VA="0x10F4EA4")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10707E4", Offset="0x10707E4")]
		protected get
		{
			return new bool();
		}
		[Address(RVA="0x10F4EAC", Offset="0x10F4EAC", VA="0x10F4EAC")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10707F4", Offset="0x10707F4")]
		set
		{
		}
	}

	[Address(RVA="0x10F4EB8", Offset="0x10F4EB8", VA="0x10F4EB8")]
	public AScrimView()
	{
	}

	[Serializable]
	public class SerializedFields : ViewSerializedFields
	{
		[FieldOffset(Offset="0x28")]
		public float ScrimRevealDelay;

		[FieldOffset(Offset="0x2C")]
		public float RevealDuration;

		[Address(RVA="0x10F4EC0", Offset="0x10F4EC0", VA="0x10F4EC0")]
		public SerializedFields()
		{
		}
	}
}