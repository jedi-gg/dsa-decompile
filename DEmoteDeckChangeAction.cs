using Il2CppDummyDll;
using System;
using System.Collections.Generic;

public struct DEmoteDeckChangeAction
{
	[FieldOffset(Offset="0x0")]
	public readonly IReadOnlyList<ulong> EmoteDeck;

	[Address(RVA="0xF04D88", Offset="0xF04D88", VA="0xF04D88")]
	public DEmoteDeckChangeAction(IReadOnlyList<ulong> emoteDeck)
	{
	}
}