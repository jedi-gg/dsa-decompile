using Il2CppDummyDll;
using System;

public class ConsoleCommandToggleData : ConsoleCommandButtonData
{
	[FieldOffset(Offset="0x28")]
	public Func<bool> IsOn;

	[Address(RVA="0x1544D44", Offset="0x1544D44", VA="0x1544D44")]
	public ConsoleCommandToggleData(string text, Func<bool> isOn, string parameters = "")
	{
	}
}