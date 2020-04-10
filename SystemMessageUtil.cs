using Glunies;
using Google.Protobuf;
using Il2CppDummyDll;
using System;

public class SystemMessageUtil : ASystemMessageUtil
{
	[Attribute(Name="InjectAttribute", RVA="0x105BB70", Offset="0x105BB70")]
	[FieldOffset(Offset="0x10")]
	private DispatchSystem _dispatch;

	[Address(RVA="0x131C038", Offset="0x131C038", VA="0x131C038")]
	public SystemMessageUtil()
	{
	}

	[Address(RVA="0x169F590", Offset="0x169F590", VA="0x169F590", Slot="4")]
	protected override void DispatchMessage<T>(MessageParser<T> parser, string data)
	where T : IMessage<T>
	{
	}

	[Address(RVA="0x1570A84", Offset="0x1570A84", VA="0x1570A84", Slot="5")]
	protected override T ParseMessage<T>(MessageParser<T> parser, string data)
	where T : IMessage<T>
	{
		return null;
	}
}