using Google.Protobuf;
using Il2CppDummyDll;
using System;

public struct DCachedResponse
{
	[FieldOffset(Offset="0x0")]
	private DateTime _expiresAt;

	[FieldOffset(Offset="0x8")]
	private IMessage _request;

	[FieldOffset(Offset="0x10")]
	private IMessage _response;

	public DateTime ExpiresAt
	{
		[Address(RVA="0xF031B0", Offset="0xF031B0", VA="0xF031B0")]
		get
		{
			return new DateTime();
		}
	}

	public bool IsExpired
	{
		[Address(RVA="0xF031A8", Offset="0xF031A8", VA="0xF031A8")]
		get
		{
			return new bool();
		}
	}

	public IMessage Request
	{
		[Address(RVA="0xF031B8", Offset="0xF031B8", VA="0xF031B8")]
		get
		{
			return null;
		}
	}

	public IMessage Response
	{
		[Address(RVA="0xF031C0", Offset="0xF031C0", VA="0xF031C0")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0xF031C8", Offset="0xF031C8", VA="0xF031C8")]
	public DCachedResponse(ulong expireTimestamp, IMessage request, IMessage response)
	{
	}
}