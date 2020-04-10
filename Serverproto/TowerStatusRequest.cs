using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class TowerStatusRequest : IMessage<TowerStatusRequest>, IMessage, IEquatable<TowerStatusRequest>, IDeepCloneable<TowerStatusRequest>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<TowerStatusRequest> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109CEF8", Offset="0x109CEF8")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1B7841C", Offset="0x1B7841C", VA="0x1B7841C")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109CEE8", Offset="0x109CEE8")]
		public static MessageParser<TowerStatusRequest> Parser
		{
			[Address(RVA="0x1B7624C", Offset="0x1B7624C", VA="0x1B7624C")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109CF08", Offset="0x109CF08")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1B78508", Offset="0x1B78508", VA="0x1B78508", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1B7881C", Offset="0x1B7881C", VA="0x1B7881C")]
		static TowerStatusRequest()
		{
		}

		[Address(RVA="0x1B78564", Offset="0x1B78564", VA="0x1B78564")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108986C", Offset="0x108986C")]
		public TowerStatusRequest()
		{
		}

		[Address(RVA="0x1B7856C", Offset="0x1B7856C", VA="0x1B7856C")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108987C", Offset="0x108987C")]
		public TowerStatusRequest(TowerStatusRequest other)
		{
		}

		[Address(RVA="0x1B78780", Offset="0x1B78780", VA="0x1B78780", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10898EC", Offset="0x10898EC")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1B785B0", Offset="0x1B785B0", VA="0x1B785B0", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108988C", Offset="0x108988C")]
		public TowerStatusRequest Clone()
		{
			return null;
		}

		[Address(RVA="0x1B78610", Offset="0x1B78610", VA="0x1B78610", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108989C", Offset="0x108989C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1B786A8", Offset="0x1B786A8", VA="0x1B786A8", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10898AC", Offset="0x10898AC")]
		public bool Equals(TowerStatusRequest other)
		{
			return new bool();
		}

		[Address(RVA="0x1B786D4", Offset="0x1B786D4", VA="0x1B786D4", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10898BC", Offset="0x10898BC")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1B78794", Offset="0x1B78794", VA="0x1B78794", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10898FC", Offset="0x10898FC")]
		public void MergeFrom(TowerStatusRequest other)
		{
		}

		[Address(RVA="0x1B787C8", Offset="0x1B787C8", VA="0x1B787C8", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108990C", Offset="0x108990C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1B78704", Offset="0x1B78704", VA="0x1B78704", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10898CC", Offset="0x10898CC")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1B7876C", Offset="0x1B7876C", VA="0x1B7876C", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10898DC", Offset="0x10898DC")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1050C78", Offset="0x1050C78")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static TowerStatusRequest.<>c <>9;

			[Address(RVA="0x1B788F4", Offset="0x1B788F4", VA="0x1B788F4")]
			static <>c()
			{
			}

			[Address(RVA="0x1B78958", Offset="0x1B78958", VA="0x1B78958")]
			public <>c()
			{
			}

			[Address(RVA="0x1B78960", Offset="0x1B78960", VA="0x1B78960")]
			internal TowerStatusRequest <.cctor>b__20_0()
			{
				return null;
			}
		}
	}
}