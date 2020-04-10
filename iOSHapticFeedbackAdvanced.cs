using Il2CppDummyDll;
using System;

public class iOSHapticFeedbackAdvanced : iOSHapticFeedback
{
	[Address(RVA="0x2341550", Offset="0x2341550", VA="0x2341550")]
	public iOSHapticFeedbackAdvanced()
	{
	}

	[Address(RVA="0x234152C", Offset="0x234152C", VA="0x234152C", Slot="4")]
	protected override void Awake()
	{
	}

	[Address(RVA="0x2341538", Offset="0x2341538", VA="0x2341538")]
	public void InstantiateFeedbackGenerator(iOSHapticFeedback.iOSFeedbackType feedbackType)
	{
	}

	[Address(RVA="0x234153C", Offset="0x234153C", VA="0x234153C")]
	public void PrepareFeedbackGenerator(iOSHapticFeedback.iOSFeedbackType feedbackType)
	{
	}

	[Address(RVA="0x234154C", Offset="0x234154C", VA="0x234154C")]
	public void ReleaseFeedbackGenerator(iOSHapticFeedback.iOSFeedbackType feedbackType)
	{
	}

	[Address(RVA="0x2341530", Offset="0x2341530", VA="0x2341530", Slot="5")]
	public override void Trigger(iOSHapticFeedback.iOSFeedbackType feedbackType)
	{
	}

	[Address(RVA="0x2341540", Offset="0x2341540", VA="0x2341540")]
	public void TriggerFeedbackGenerator(iOSHapticFeedback.iOSFeedbackType feedbackType)
	{
	}
}