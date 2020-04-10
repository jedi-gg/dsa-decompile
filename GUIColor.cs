using Il2CppDummyDll;
using System;
using UnityEngine;

public class GUIColor : IDisposable
{
	[FieldOffset(Offset="0x10")]
	private Color _previousColor;

	[Address(RVA="0x15EA43C", Offset="0x15EA43C", VA="0x15EA43C")]
	public GUIColor(Color color)
	{
	}

	[Address(RVA="0x15EA4EC", Offset="0x15EA4EC", VA="0x15EA4EC", Slot="4")]
	public void Dispose()
	{
	}
}