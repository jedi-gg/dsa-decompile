using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class StoreAdRewardRequest : IMessage<StoreAdRewardRequest>, IMessage, IEquatable<StoreAdRewardRequest>, IDeepCloneable<StoreAdRewardRequest>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<StoreAdRewardRequest> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109CAD8", Offset="0x109CAD8")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1BD9924", Offset="0x1BD9924", VA="0x1BD9924")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109CAC8", Offset="0x109CAC8")]
		public static MessageParser<StoreAdRewardRequest> Parser
		{
			[Address(RVA="0x1BD98BC", Offset="0x1BD98BC", VA="0x1BD98BC")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109CAE8", Offset="0x109CAE8")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1BD9A14", Offset="0x1BD9A14", VA="0x1BD9A14", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1BD9D28", Offset="0x1BD9D28", VA="0x1BD9D28")]
		static StoreAdRewardRequest()
		{
		}

		[Address(RVA="0x1BD9A70", Offset="0x1BD9A70", VA="0x1BD9A70")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108902C", Offset="0x108902C")]
		public StoreAdRewardRequest()
		{
		}

		[Address(RVA="0x1BD9A78", Offset="0x1BD9A78", VA="0x1BD9A78")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108903C", Offset="0x108903C")]
		public StoreAdRewardRequest(StoreAdRewardRequest other)
		{
		}

		[Address(RVA="0x1BD9C8C", Offset="0x1BD9C8C", VA="0x1BD9C8C", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10890AC", Offset="0x10890AC")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1BD9ABC", Offset="0x1BD9ABC", VA="0x1BD9ABC", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108904C", Offset="0x108904C")]
		public StoreAdRewardRequest Clone()
		{
			return null;
		}

		[Address(RVA="0x1BD9B1C", Offset="0x1BD9B1C", VA="0x1BD9B1C", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108905C", Offset="0x108905C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1BD9BB4", Offset="0x1BD9BB4", VA="0x1BD9BB4", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108906C", Offset="0x108906C")]
		public bool Equals(StoreAdRewardRequest other)
		{
			return new bool();
		}

		[Address(RVA="0x1BD9BE0", Offset="0x1BD9BE0", VA="0x1BD9BE0", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108907C", Offset="0x108907C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1BD9CA0", Offset="0x1BD9CA0", VA="0x1BD9CA0", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10890BC", Offset="0x10890BC")]
		public void MergeFrom(StoreAdRewardRequest other)
		{
		}

		[Address(RVA="0x1BD9CD4", Offset="0x1BD9CD4", VA="0x1BD9CD4", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10890CC", Offset="0x10890CC")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1BD9C10", Offset="0x1BD9C10", VA="0x1BD9C10", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108908C", Offset="0x108908C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1BD9C78", Offset="0x1BD9C78", VA="0x1BD9C78", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108909C", Offset="0x108909C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1050BB8", Offset="0x1050BB8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static StoreAdRewardRequest.<>c <>9;

			[Address(RVA="0x1BD9E00", Offset="0x1BD9E00", VA="0x1BD9E00")]
			static <>c()
			{
			}

			[Address(RVA="0x1BD9E64", Offset="0x1BD9E64", VA="0x1BD9E64")]
			public <>c()
			{
			}

			[Address(RVA="0x1BD9E6C", Offset="0x1BD9E6C", VA="0x1BD9E6C")]
			internal StoreAdRewardRequest <.cctor>b__20_0()
			{
				return null;
			}
		}
	}
}