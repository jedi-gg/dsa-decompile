using Google.Protobuf;
using Il2CppDummyDll;
using System;

public struct DSystemMessageAction<T>
where T : IMessage
{
	[FieldOffset(Offset="0x0")]
	public readonly T Message;

	[Address(RVA="0xF16AC0", Offset="0xF16AC0", VA="0xF16AC0")]
	public DSystemMessageAction(T message)
	{
	}
}