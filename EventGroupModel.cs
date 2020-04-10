using Il2CppDummyDll;
using Serverproto;
using System;
using System.Collections.Generic;

public class EventGroupModel
{
	[FieldOffset(Offset="0x10")]
	public EventGroup Group;

	[FieldOffset(Offset="0x18")]
	public List<IEventModel> Events;

	[Address(RVA="0x1216564", Offset="0x1216564", VA="0x1216564")]
	public EventGroupModel()
	{
	}
}