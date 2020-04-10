using Il2CppDummyDll;
using System;

public class TallyLabelSigned : ATallyLabel<long>
{
	[Address(RVA="0x13213D8", Offset="0x13213D8", VA="0x13213D8")]
	public TallyLabelSigned()
	{
	}

	[Address(RVA="0x1321180", Offset="0x1321180", VA="0x1321180", Slot="137")]
	public override long GetCurrentValue()
	{
		return new long();
	}

	[Address(RVA="0x13211E4", Offset="0x13211E4", VA="0x13211E4", Slot="138")]
	public override long GetValueAtTime(float t)
	{
		return new long();
	}

	[Address(RVA="0x1321268", Offset="0x1321268", VA="0x1321268", Slot="139")]
	protected override void SetLabelValue(long currentValue)
	{
	}
}