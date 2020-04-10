using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class AgeGateResponse : IMessage<AgeGateResponse>, IMessage, IEquatable<AgeGateResponse>, IDeepCloneable<AgeGateResponse>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<AgeGateResponse> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109AFE0", Offset="0x109AFE0")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1607670", Offset="0x1607670", VA="0x1607670")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109AFD0", Offset="0x109AFD0")]
		public static MessageParser<AgeGateResponse> Parser
		{
			[Address(RVA="0x1607608", Offset="0x1607608", VA="0x1607608")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109AFF0", Offset="0x109AFF0")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1607760", Offset="0x1607760", VA="0x1607760", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1607A74", Offset="0x1607A74", VA="0x1607A74")]
		static AgeGateResponse()
		{
		}

		[Address(RVA="0x16077BC", Offset="0x16077BC", VA="0x16077BC")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108616C", Offset="0x108616C")]
		public AgeGateResponse()
		{
		}

		[Address(RVA="0x16077C4", Offset="0x16077C4", VA="0x16077C4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108617C", Offset="0x108617C")]
		public AgeGateResponse(AgeGateResponse other)
		{
		}

		[Address(RVA="0x16079D8", Offset="0x16079D8", VA="0x16079D8", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10861EC", Offset="0x10861EC")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1607808", Offset="0x1607808", VA="0x1607808", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108618C", Offset="0x108618C")]
		public AgeGateResponse Clone()
		{
			return null;
		}

		[Address(RVA="0x1607868", Offset="0x1607868", VA="0x1607868", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108619C", Offset="0x108619C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1607900", Offset="0x1607900", VA="0x1607900", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10861AC", Offset="0x10861AC")]
		public bool Equals(AgeGateResponse other)
		{
			return new bool();
		}

		[Address(RVA="0x160792C", Offset="0x160792C", VA="0x160792C", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10861BC", Offset="0x10861BC")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x16079EC", Offset="0x16079EC", VA="0x16079EC", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10861FC", Offset="0x10861FC")]
		public void MergeFrom(AgeGateResponse other)
		{
		}

		[Address(RVA="0x1607A20", Offset="0x1607A20", VA="0x1607A20", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108620C", Offset="0x108620C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x160795C", Offset="0x160795C", VA="0x160795C", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10861CC", Offset="0x10861CC")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x16079C4", Offset="0x16079C4", VA="0x16079C4", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10861DC", Offset="0x10861DC")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1050768", Offset="0x1050768")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static AgeGateResponse.<>c <>9;

			[Address(RVA="0x1607B4C", Offset="0x1607B4C", VA="0x1607B4C")]
			static <>c()
			{
			}

			[Address(RVA="0x1607BB0", Offset="0x1607BB0", VA="0x1607BB0")]
			public <>c()
			{
			}

			[Address(RVA="0x1607BB8", Offset="0x1607BB8", VA="0x1607BB8")]
			internal AgeGateResponse <.cctor>b__20_0()
			{
				return null;
			}
		}
	}
}