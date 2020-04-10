using Il2CppDummyDll;
using System;
using System.Collections.Generic;

public struct UniWebViewMessage
{
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x105FE78", Offset="0x105FE78")]
	[FieldOffset(Offset="0x0")]
	private string <RawMessage>k__BackingField;

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x105FE88", Offset="0x105FE88")]
	[FieldOffset(Offset="0x8")]
	private string <Scheme>k__BackingField;

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x105FE98", Offset="0x105FE98")]
	[FieldOffset(Offset="0x10")]
	private string <Path>k__BackingField;

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x105FEA8", Offset="0x105FEA8")]
	[FieldOffset(Offset="0x18")]
	private Dictionary<string, string> <Args>k__BackingField;

	public Dictionary<string, string> Args
	{
		[Address(RVA="0xF05D9C", Offset="0xF05D9C", VA="0xF05D9C")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1071400", Offset="0x1071400")]
		get
		{
			return null;
		}
		[Address(RVA="0xF05DA4", Offset="0xF05DA4", VA="0xF05DA4")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1071410", Offset="0x1071410")]
		private set
		{
		}
	}

	public string Path
	{
		[Address(RVA="0xF05D8C", Offset="0xF05D8C", VA="0xF05D8C")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10713E0", Offset="0x10713E0")]
		get
		{
			return null;
		}
		[Address(RVA="0xF05D94", Offset="0xF05D94", VA="0xF05D94")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10713F0", Offset="0x10713F0")]
		private set
		{
		}
	}

	public string RawMessage
	{
		[Address(RVA="0xF05D6C", Offset="0xF05D6C", VA="0xF05D6C")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10713A0", Offset="0x10713A0")]
		get
		{
			return null;
		}
		[Address(RVA="0xF05D74", Offset="0xF05D74", VA="0xF05D74")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10713B0", Offset="0x10713B0")]
		private set
		{
		}
	}

	public string Scheme
	{
		[Address(RVA="0xF05D7C", Offset="0xF05D7C", VA="0xF05D7C")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10713C0", Offset="0x10713C0")]
		get
		{
			return null;
		}
		[Address(RVA="0xF05D84", Offset="0xF05D84", VA="0xF05D84")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10713D0", Offset="0x10713D0")]
		private set
		{
		}
	}

	[Address(RVA="0xF05DAC", Offset="0xF05DAC", VA="0xF05DAC")]
	public UniWebViewMessage(string rawMessage)
	{
	}
}