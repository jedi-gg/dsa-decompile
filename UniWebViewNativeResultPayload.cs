using Il2CppDummyDll;
using System;

[Serializable]
public class UniWebViewNativeResultPayload
{
	[FieldOffset(Offset="0x10")]
	public string identifier;

	[FieldOffset(Offset="0x18")]
	public string resultCode;

	[FieldOffset(Offset="0x20")]
	public string data;

	[Address(RVA="0x159EF14", Offset="0x159EF14", VA="0x159EF14")]
	public UniWebViewNativeResultPayload()
	{
	}
}