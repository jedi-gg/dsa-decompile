using Google.Protobuf;
using Il2CppDummyDll;
using System;

public abstract class ASystemMessageUtil
{
	[Address(RVA="0x10F5204", Offset="0x10F5204", VA="0x10F5204")]
	protected ASystemMessageUtil()
	{
	}

	[Address(RVA="0x10F4F00", Offset="0x10F4F00", VA="0x10F4F00")]
	public void Dispatch(string messageType, string encodedData)
	{
	}

	protected abstract void DispatchMessage<T>(MessageParser<T> parser, string encodedData)
	where T : IMessage<T>;

	[Address(RVA="0x10F5084", Offset="0x10F5084", VA="0x10F5084")]
	public IMessage Parse(string messageType, string encodedData)
	{
		return null;
	}

	protected abstract T ParseMessage<T>(MessageParser<T> parser, string encodedData)
	where T : IMessage<T>;
}