using Il2CppDummyDll;
using System;

public struct DBattleMsgAction<T>
{
	[FieldOffset(Offset="0x0")]
	public readonly T Msg;

	[Address(RVA="0xF36888", Offset="0xF36888", VA="0xF36888")]
	public DBattleMsgAction(T msg)
	{
	}
}