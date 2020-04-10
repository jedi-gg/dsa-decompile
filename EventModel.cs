using Il2CppDummyDll;
using Serverproto;
using System;
using System.Collections.Generic;

public class EventModel : IEventModel
{
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1058104", Offset="0x1058104")]
	[FieldOffset(Offset="0x10")]
	private Serverproto.Event <Event>k__BackingField;

	public string BannerImage
	{
		[Address(RVA="0x12B4284", Offset="0x12B4284", VA="0x12B4284", Slot="11")]
		get
		{
			return null;
		}
	}

	public string BannerText
	{
		[Address(RVA="0x12B42B4", Offset="0x12B42B4", VA="0x12B42B4", Slot="12")]
		get
		{
			return null;
		}
	}

	public ulong BeginTimestamp
	{
		[Address(RVA="0x12B4314", Offset="0x12B4314", VA="0x12B4314", Slot="14")]
		get
		{
			return new ulong();
		}
	}

	public ulong ContentId
	{
		[Address(RVA="0x12B4134", Offset="0x12B4134", VA="0x12B4134", Slot="4")]
		get
		{
			return new ulong();
		}
	}

	public string Description
	{
		[Address(RVA="0x12B41C4", Offset="0x12B41C4", VA="0x12B41C4", Slot="7")]
		get
		{
			return null;
		}
	}

	public ulong EndTimestamp
	{
		[Address(RVA="0x12B4344", Offset="0x12B4344", VA="0x12B4344", Slot="15")]
		get
		{
			return new ulong();
		}
	}

	public Serverproto.Event Event
	{
		[Address(RVA="0x12B4124", Offset="0x12B4124", VA="0x12B4124")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106F694", Offset="0x106F694")]
		get
		{
			return null;
		}
		[Address(RVA="0x12B412C", Offset="0x12B412C", VA="0x12B412C")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106F6A4", Offset="0x106F6A4")]
		private set
		{
		}
	}

	public ulong EventGroupId
	{
		[Address(RVA="0x12B4164", Offset="0x12B4164", VA="0x12B4164", Slot="5")]
		get
		{
			return new ulong();
		}
	}

	public string Image
	{
		[Address(RVA="0x12B4224", Offset="0x12B4224", VA="0x12B4224", Slot="9")]
		get
		{
			return null;
		}
	}

	public string Name
	{
		[Address(RVA="0x12B4194", Offset="0x12B4194", VA="0x12B4194", Slot="6")]
		get
		{
			return null;
		}
	}

	public string PreviewText
	{
		[Address(RVA="0x12B4254", Offset="0x12B4254", VA="0x12B4254", Slot="10")]
		get
		{
			return null;
		}
	}

	public IList<ulong> ShowcaseItems
	{
		[Address(RVA="0x12B42E4", Offset="0x12B42E4", VA="0x12B42E4", Slot="13")]
		get
		{
			return null;
		}
	}

	public long SortOrder
	{
		[Address(RVA="0x12B41F4", Offset="0x12B41F4", VA="0x12B41F4", Slot="8")]
		get
		{
			return new long();
		}
	}

	[Address(RVA="0x12B4374", Offset="0x12B4374", VA="0x12B4374")]
	public EventModel(Serverproto.Event evt)
	{
	}

	[Address(RVA="0x12B43A0", Offset="0x12B43A0", VA="0x12B43A0", Slot="16")]
	public bool HasBegun()
	{
		return new bool();
	}

	[Address(RVA="0x12B43B0", Offset="0x12B43B0", VA="0x12B43B0", Slot="17")]
	public bool HasEnded(ulong bufferWindowS = 0L)
	{
		return new bool();
	}

	[Address(RVA="0x12B43BC", Offset="0x12B43BC", VA="0x12B43BC", Slot="18")]
	public bool IsActive()
	{
		return new bool();
	}
}