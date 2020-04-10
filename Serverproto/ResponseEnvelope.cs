using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class ResponseEnvelope : IMessage<ResponseEnvelope>, IMessage, IEquatable<ResponseEnvelope>, IDeepCloneable<ResponseEnvelope>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<ResponseEnvelope> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int PayloadFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private ByteString payload_;

		[FieldOffset(Offset="0x0")]
		public const int ResponseCodeFieldNumber = 2;

		[FieldOffset(Offset="0x20")]
		private Serverproto.ResponseCode responseCode_;

		[FieldOffset(Offset="0x0")]
		public const int ErrorMessageFieldNumber = 3;

		[FieldOffset(Offset="0x28")]
		private string errorMessage_;

		[FieldOffset(Offset="0x0")]
		public const int DynamicMessagesFieldNumber = 4;

		[FieldOffset(Offset="0x8")]
		private readonly static FieldCodec<DynamicMessage> _repeated_dynamicMessages_codec;

		[FieldOffset(Offset="0x30")]
		private readonly RepeatedField<DynamicMessage> dynamicMessages_;

		[FieldOffset(Offset="0x0")]
		public const int CacheSettingsFieldNumber = 5;

		[FieldOffset(Offset="0x38")]
		private Serverproto.CacheSettings cacheSettings_;

		[FieldOffset(Offset="0x0")]
		public const int CorrelationIdFieldNumber = 6;

		[FieldOffset(Offset="0x40")]
		private ulong correlationId_;

		[FieldOffset(Offset="0x0")]
		public const int OutOfBandFieldNumber = 7;

		[FieldOffset(Offset="0x48")]
		private bool outOfBand_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109BA60", Offset="0x109BA60")]
		public Serverproto.CacheSettings CacheSettings
		{
			[Address(RVA="0x1BCA9BC", Offset="0x1BCA9BC", VA="0x1BCA9BC")]
			get
			{
				return null;
			}
			[Address(RVA="0x1BCA9C4", Offset="0x1BCA9C4", VA="0x1BCA9C4")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109BA70", Offset="0x109BA70")]
		public ulong CorrelationId
		{
			[Address(RVA="0x1BCAB34", Offset="0x1BCAB34", VA="0x1BCAB34")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1BCAB3C", Offset="0x1BCAB3C", VA="0x1BCAB3C")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109BA00", Offset="0x109BA00")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1BCA6B4", Offset="0x1BCA6B4", VA="0x1BCA6B4")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109BA50", Offset="0x109BA50")]
		public RepeatedField<DynamicMessage> DynamicMessages
		{
			[Address(RVA="0x1BCAB2C", Offset="0x1BCAB2C", VA="0x1BCAB2C")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109BA40", Offset="0x109BA40")]
		public string ErrorMessage
		{
			[Address(RVA="0x1BCAAB4", Offset="0x1BCAAB4", VA="0x1BCAAB4")]
			get
			{
				return null;
			}
			[Address(RVA="0x1BCAABC", Offset="0x1BCAABC", VA="0x1BCAABC")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109BA80", Offset="0x109BA80")]
		public bool OutOfBand
		{
			[Address(RVA="0x1BCAB44", Offset="0x1BCAB44", VA="0x1BCAB44")]
			get
			{
				return new bool();
			}
			[Address(RVA="0x1BCAB4C", Offset="0x1BCAB4C", VA="0x1BCAB4C")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109B9F0", Offset="0x109B9F0")]
		public static MessageParser<ResponseEnvelope> Parser
		{
			[Address(RVA="0x1BCA64C", Offset="0x1BCA64C", VA="0x1BCA64C")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109BA20", Offset="0x109BA20")]
		public ByteString Payload
		{
			[Address(RVA="0x1BCAA2C", Offset="0x1BCAA2C", VA="0x1BCAA2C")]
			get
			{
				return null;
			}
			[Address(RVA="0x1BCAA34", Offset="0x1BCAA34", VA="0x1BCAA34")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109BA10", Offset="0x109BA10")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1BCA7A0", Offset="0x1BCA7A0", VA="0x1BCA7A0", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109BA30", Offset="0x109BA30")]
		public Serverproto.ResponseCode ResponseCode
		{
			[Address(RVA="0x1BCAAA4", Offset="0x1BCAAA4", VA="0x1BCAAA4")]
			get
			{
				return new Serverproto.ResponseCode();
			}
			[Address(RVA="0x1BCAAAC", Offset="0x1BCAAAC", VA="0x1BCAAAC")]
			set
			{
			}
		}

		[Address(RVA="0x1BCB7C0", Offset="0x1BCB7C0", VA="0x1BCB7C0")]
		static ResponseEnvelope()
		{
		}

		[Address(RVA="0x1BCA7FC", Offset="0x1BCA7FC", VA="0x1BCA7FC")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108776C", Offset="0x108776C")]
		public ResponseEnvelope()
		{
		}

		[Address(RVA="0x1BCA8A8", Offset="0x1BCA8A8", VA="0x1BCA8A8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108777C", Offset="0x108777C")]
		public ResponseEnvelope(ResponseEnvelope other)
		{
		}

		[Address(RVA="0x1BCB208", Offset="0x1BCB208", VA="0x1BCB208", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10877EC", Offset="0x10877EC")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1BCA9CC", Offset="0x1BCA9CC", VA="0x1BCA9CC", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108778C", Offset="0x108778C")]
		public ResponseEnvelope Clone()
		{
			return null;
		}

		[Address(RVA="0x1BCAB58", Offset="0x1BCAB58", VA="0x1BCAB58", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108779C", Offset="0x108779C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1BCABCC", Offset="0x1BCABCC", VA="0x1BCABCC", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10877AC", Offset="0x10877AC")]
		public bool Equals(ResponseEnvelope other)
		{
			return new bool();
		}

		[Address(RVA="0x1BCAD20", Offset="0x1BCAD20", VA="0x1BCAD20", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10877BC", Offset="0x10877BC")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1BCB438", Offset="0x1BCB438", VA="0x1BCB438", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10877FC", Offset="0x10877FC")]
		public void MergeFrom(ResponseEnvelope other)
		{
		}

		[Address(RVA="0x1BCB594", Offset="0x1BCB594", VA="0x1BCB594", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108780C", Offset="0x108780C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1BCAE98", Offset="0x1BCAE98", VA="0x1BCAE98", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10877CC", Offset="0x10877CC")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1BCAF00", Offset="0x1BCAF00", VA="0x1BCAF00", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10877DC", Offset="0x10877DC")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1050968", Offset="0x1050968")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static ResponseEnvelope.<>c <>9;

			[Address(RVA="0x1BCB8E4", Offset="0x1BCB8E4", VA="0x1BCB8E4")]
			static <>c()
			{
			}

			[Address(RVA="0x1BCB948", Offset="0x1BCB948", VA="0x1BCB948")]
			public <>c()
			{
			}

			[Address(RVA="0x1BCB950", Offset="0x1BCB950", VA="0x1BCB950")]
			internal ResponseEnvelope <.cctor>b__55_0()
			{
				return null;
			}
		}
	}
}