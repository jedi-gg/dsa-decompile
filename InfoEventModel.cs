using Il2CppDummyDll;
using Serverproto;
using System;
using System.Collections.Generic;

public class InfoEventModel : IEventModel
{
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1058114", Offset="0x1058114")]
	[FieldOffset(Offset="0x10")]
	private Serverproto.InfoEvent <InfoEvent>k__BackingField;

	public string BannerImage
	{
		[Address(RVA="0x1184DDC", Offset="0x1184DDC", VA="0x1184DDC", Slot="11")]
		get
		{
			return null;
		}
	}

	public string BannerText
	{
		[Address(RVA="0x1184E0C", Offset="0x1184E0C", VA="0x1184E0C", Slot="12")]
		get
		{
			return null;
		}
	}

	public ulong BeginTimestamp
	{
		[Address(RVA="0x1184E6C", Offset="0x1184E6C", VA="0x1184E6C", Slot="14")]
		get
		{
			return new ulong();
		}
	}

	public ulong ContentId
	{
		[Address(RVA="0x1184C8C", Offset="0x1184C8C", VA="0x1184C8C", Slot="4")]
		get
		{
			return new ulong();
		}
	}

	public string Description
	{
		[Address(RVA="0x1184D1C", Offset="0x1184D1C", VA="0x1184D1C", Slot="7")]
		get
		{
			return null;
		}
	}

	public ulong EndTimestamp
	{
		[Address(RVA="0x1184E9C", Offset="0x1184E9C", VA="0x1184E9C", Slot="15")]
		get
		{
			return new ulong();
		}
	}

	public ulong EventGroupId
	{
		[Address(RVA="0x1184CBC", Offset="0x1184CBC", VA="0x1184CBC", Slot="5")]
		get
		{
			return new ulong();
		}
	}

	public string Image
	{
		[Address(RVA="0x1184D7C", Offset="0x1184D7C", VA="0x1184D7C", Slot="9")]
		get
		{
			return null;
		}
	}

	public Serverproto.InfoEvent InfoEvent
	{
		[Address(RVA="0x1184C7C", Offset="0x1184C7C", VA="0x1184C7C")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106F6B4", Offset="0x106F6B4")]
		get
		{
			return null;
		}
		[Address(RVA="0x1184C84", Offset="0x1184C84", VA="0x1184C84")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106F6C4", Offset="0x106F6C4")]
		private set
		{
		}
	}

	public string Name
	{
		[Address(RVA="0x1184CEC", Offset="0x1184CEC", VA="0x1184CEC", Slot="6")]
		get
		{
			return null;
		}
	}

	public string PreviewText
	{
		[Address(RVA="0x1184DAC", Offset="0x1184DAC", VA="0x1184DAC", Slot="10")]
		get
		{
			return null;
		}
	}

	public IList<ulong> ShowcaseItems
	{
		[Address(RVA="0x1184E3C", Offset="0x1184E3C", VA="0x1184E3C", Slot="13")]
		get
		{
			return null;
		}
	}

	public long SortOrder
	{
		[Address(RVA="0x1184D4C", Offset="0x1184D4C", VA="0x1184D4C", Slot="8")]
		get
		{
			return new long();
		}
	}

	[Address(RVA="0x1184ECC", Offset="0x1184ECC", VA="0x1184ECC")]
	public InfoEventModel(Serverproto.InfoEvent infoEvent)
	{
	}

	[Address(RVA="0x1184EF8", Offset="0x1184EF8", VA="0x1184EF8", Slot="16")]
	public bool HasBegun()
	{
		return new bool();
	}

	[Address(RVA="0x1184F08", Offset="0x1184F08", VA="0x1184F08", Slot="17")]
	public bool HasEnded(ulong bufferWindowS = 0L)
	{
		return new bool();
	}

	[Address(RVA="0x1184F14", Offset="0x1184F14", VA="0x1184F14", Slot="18")]
	public bool IsActive()
	{
		return new bool();
	}
}