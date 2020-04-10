using Il2CppDummyDll;
using System;

public class TallyLabelUnsigned : ATallyLabel<ulong>
{
	[Address(RVA="0x1321680", Offset="0x1321680", VA="0x1321680")]
	public TallyLabelUnsigned()
	{
	}

	[Address(RVA="0x1321428", Offset="0x1321428", VA="0x1321428", Slot="137")]
	public override ulong GetCurrentValue()
	{
		return new ulong();
	}

	[Address(RVA="0x132148C", Offset="0x132148C", VA="0x132148C", Slot="138")]
	public override ulong GetValueAtTime(float t)
	{
		return new ulong();
	}

	[Address(RVA="0x1321510", Offset="0x1321510", VA="0x1321510", Slot="139")]
	protected override void SetLabelValue(ulong currentValue)
	{
	}
}