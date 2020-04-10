using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

public class PlayerEmoteWidget
{
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1053204", Offset="0x1053204")]
	[FieldOffset(Offset="0x10")]
	private uint <PlayerId>k__BackingField;

	[FieldOffset(Offset="0x18")]
	private GameObject _root;

	[FieldOffset(Offset="0x20")]
	private EmoteWidget _widget;

	[FieldOffset(Offset="0x28")]
	private Dictionary<ulong, EmoteData> _emoteData;

	public uint PlayerId
	{
		[Address(RVA="0x133AB00", Offset="0x133AB00", VA="0x133AB00")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106E4E8", Offset="0x106E4E8")]
		get
		{
			return new uint();
		}
		[Address(RVA="0x133AB08", Offset="0x133AB08", VA="0x133AB08")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106E4F8", Offset="0x106E4F8")]
		private set
		{
		}
	}

	[Address(RVA="0x133AB10", Offset="0x133AB10", VA="0x133AB10")]
	public PlayerEmoteWidget(uint playerId, GameObject root, EmoteWidget widget)
	{
	}

	[Address(RVA="0x133ABA8", Offset="0x133ABA8", VA="0x133ABA8")]
	public void AddEmoteData(ulong emoteId, EmoteData data)
	{
	}

	[Address(RVA="0x133AC64", Offset="0x133AC64", VA="0x133AC64")]
	public void PlayEmote(ulong emoteId)
	{
	}

	[Address(RVA="0x133AD08", Offset="0x133AD08", VA="0x133AD08")]
	public void TickUpdate()
	{
	}
}