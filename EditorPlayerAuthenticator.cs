using Il2CppDummyDll;
using Serverproto;
using System;

public class EditorPlayerAuthenticator : APlayerAuthenticator
{
	protected override AuthType AnonymousAuthType
	{
		[Address(RVA="0x1206494", Offset="0x1206494", VA="0x1206494", Slot="14")]
		get
		{
			return new AuthType();
		}
	}

	[Address(RVA="0x120649C", Offset="0x120649C", VA="0x120649C")]
	public EditorPlayerAuthenticator()
	{
	}

	[Address(RVA="0x120648C", Offset="0x120648C", VA="0x120648C", Slot="9")]
	public override void AutoAuthenticate(Action<bool> completed)
	{
	}
}