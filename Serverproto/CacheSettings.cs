using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class CacheSettings : IMessage<CacheSettings>, IMessage, IEquatable<CacheSettings>, IDeepCloneable<CacheSettings>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<CacheSettings> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int ExpireTimestampFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private ulong expireTimestamp_;

		[FieldOffset(Offset="0x0")]
		public const int NumToKeepFieldNumber = 2;

		[FieldOffset(Offset="0x20")]
		private ulong numToKeep_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109BB30", Offset="0x109BB30")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1F8BE1C", Offset="0x1F8BE1C", VA="0x1F8BE1C")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109BB50", Offset="0x109BB50")]
		public ulong ExpireTimestamp
		{
			[Address(RVA="0x1F8C050", Offset="0x1F8C050", VA="0x1F8C050")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1F8C058", Offset="0x1F8C058", VA="0x1F8C058")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109BB60", Offset="0x109BB60")]
		public ulong NumToKeep
		{
			[Address(RVA="0x1F8C060", Offset="0x1F8C060", VA="0x1F8C060")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1F8C068", Offset="0x1F8C068", VA="0x1F8C068")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109BB20", Offset="0x109BB20")]
		public static MessageParser<CacheSettings> Parser
		{
			[Address(RVA="0x1F8BDB4", Offset="0x1F8BDB4", VA="0x1F8BDB4")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109BB40", Offset="0x109BB40")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1F8BF0C", Offset="0x1F8BF0C", VA="0x1F8BF0C", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1F8C4D8", Offset="0x1F8C4D8", VA="0x1F8C4D8")]
		static CacheSettings()
		{
		}

		[Address(RVA="0x1F8BF68", Offset="0x1F8BF68", VA="0x1F8BF68")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108797C", Offset="0x108797C")]
		public CacheSettings()
		{
		}

		[Address(RVA="0x1F8BF70", Offset="0x1F8BF70", VA="0x1F8BF70")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108798C", Offset="0x108798C")]
		public CacheSettings(CacheSettings other)
		{
		}

		[Address(RVA="0x1F8C314", Offset="0x1F8C314", VA="0x1F8C314", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10879FC", Offset="0x10879FC")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1F8BFF0", Offset="0x1F8BFF0", VA="0x1F8BFF0", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108799C", Offset="0x108799C")]
		public CacheSettings Clone()
		{
			return null;
		}

		[Address(RVA="0x1F8C070", Offset="0x1F8C070", VA="0x1F8C070", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10879AC", Offset="0x10879AC")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1F8C0E4", Offset="0x1F8C0E4", VA="0x1F8C0E4", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10879BC", Offset="0x10879BC")]
		public bool Equals(CacheSettings other)
		{
			return new bool();
		}

		[Address(RVA="0x1F8C130", Offset="0x1F8C130", VA="0x1F8C130", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10879CC", Offset="0x10879CC")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1F8C3E8", Offset="0x1F8C3E8", VA="0x1F8C3E8", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1087A0C", Offset="0x1087A0C")]
		public void MergeFrom(CacheSettings other)
		{
		}

		[Address(RVA="0x1F8C434", Offset="0x1F8C434", VA="0x1F8C434", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1087A1C", Offset="0x1087A1C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1F8C1B4", Offset="0x1F8C1B4", VA="0x1F8C1B4", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10879DC", Offset="0x10879DC")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1F8C21C", Offset="0x1F8C21C", VA="0x1F8C21C", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10879EC", Offset="0x10879EC")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1050998", Offset="0x1050998")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static CacheSettings.<>c <>9;

			[Address(RVA="0x1F8C5B0", Offset="0x1F8C5B0", VA="0x1F8C5B0")]
			static <>c()
			{
			}

			[Address(RVA="0x1F8C614", Offset="0x1F8C614", VA="0x1F8C614")]
			public <>c()
			{
			}

			[Address(RVA="0x1F8C61C", Offset="0x1F8C61C", VA="0x1F8C61C")]
			internal CacheSettings <.cctor>b__30_0()
			{
				return null;
			}
		}
	}
}