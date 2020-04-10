using Il2CppDummyDll;
using System;

namespace Zenject
{
	public class MemoryPoolBindInfo
	{
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10600D8", Offset="0x10600D8")]
		[FieldOffset(Offset="0x10")]
		private PoolExpandMethods <ExpandMethod>k__BackingField;

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10600E8", Offset="0x10600E8")]
		[FieldOffset(Offset="0x14")]
		private int <InitialSize>k__BackingField;

		public PoolExpandMethods ExpandMethod
		{
			[Address(RVA="0x183D750", Offset="0x183D750", VA="0x183D750")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10725B4", Offset="0x10725B4")]
			get
			{
				return new PoolExpandMethods();
			}
			[Address(RVA="0x183D758", Offset="0x183D758", VA="0x183D758")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10725C4", Offset="0x10725C4")]
			set
			{
			}
		}

		public int InitialSize
		{
			[Address(RVA="0x183D760", Offset="0x183D760", VA="0x183D760")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10725D4", Offset="0x10725D4")]
			get
			{
				return new int();
			}
			[Address(RVA="0x183D768", Offset="0x183D768", VA="0x183D768")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10725E4", Offset="0x10725E4")]
			set
			{
			}
		}

		[Address(RVA="0x183D748", Offset="0x183D748", VA="0x183D748")]
		public MemoryPoolBindInfo()
		{
		}
	}
}