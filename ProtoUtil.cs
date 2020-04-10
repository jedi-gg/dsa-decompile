using Google.Protobuf;
using Il2CppDummyDll;
using Serverproto;
using System;
using System.Runtime.CompilerServices;

public static class ProtoUtil
{
	[Address(RVA="0x127F498", Offset="0x127F498", VA="0x127F498")]
	public static PlayerProfileSimple ToSimpleProfile(Player player)
	{
		return null;
	}

	[Address(RVA="0x127F31C", Offset="0x127F31C", VA="0x127F31C")]
	public static bool TryParseBattleData(ByteString battleDataBuffer, out BattleLib_Bootstrap battleData)
	{
		battleData = null;
		return new bool();
	}

	[Address(RVA="0x1F65868", Offset="0x1F65868", VA="0x1F65868")]
	public static bool TryParseJson<T>(MessageParser<T> parser, string json, out T msg)
	where T : IMessage<T>
	{
		msg = default(T);
		return new bool();
	}
}