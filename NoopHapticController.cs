using Il2CppDummyDll;
using System;

public class NoopHapticController : IHapticController
{
	[Address(RVA="0x12FDBC4", Offset="0x12FDBC4", VA="0x12FDBC4")]
	public NoopHapticController()
	{
	}

	[Address(RVA="0x12FDBAC", Offset="0x12FDBAC", VA="0x12FDBAC", Slot="4")]
	public void Initialize()
	{
	}

	[Address(RVA="0x12FDBBC", Offset="0x12FDBBC", VA="0x12FDBBC", Slot="8")]
	public bool IsSupported()
	{
		return new bool();
	}

	[Address(RVA="0x12FDBB8", Offset="0x12FDBB8", VA="0x12FDBB8", Slot="7")]
	public void SetEnabled(bool enabled)
	{
	}

	[Address(RVA="0x12FDBB0", Offset="0x12FDBB0", VA="0x12FDBB0", Slot="5")]
	public void Shutdown()
	{
	}

	[Address(RVA="0x12FDBB4", Offset="0x12FDBB4", VA="0x12FDBB4", Slot="6")]
	public void Vibrate()
	{
	}
}