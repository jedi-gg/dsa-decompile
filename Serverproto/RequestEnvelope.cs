using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class RequestEnvelope : IMessage<RequestEnvelope>, IMessage, IEquatable<RequestEnvelope>, IDeepCloneable<RequestEnvelope>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<RequestEnvelope> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int PayloadFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private ByteString payload_;

		[FieldOffset(Offset="0x0")]
		public const int AuthTokenFieldNumber = 2;

		[FieldOffset(Offset="0x20")]
		private string authToken_;

		[FieldOffset(Offset="0x0")]
		public const int ClientVersionFieldNumber = 3;

		[FieldOffset(Offset="0x28")]
		private string clientVersion_;

		[FieldOffset(Offset="0x0")]
		public const int GamedataVersionFieldNumber = 4;

		[FieldOffset(Offset="0x30")]
		private string gamedataVersion_;

		[FieldOffset(Offset="0x0")]
		public const int RpcNameFieldNumber = 5;

		[FieldOffset(Offset="0x38")]
		private string rpcName_;

		[FieldOffset(Offset="0x0")]
		public const int CorrelationIdFieldNumber = 6;

		[FieldOffset(Offset="0x40")]
		private ulong correlationId_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109B9A0", Offset="0x109B9A0")]
		public string AuthToken
		{
			[Address(RVA="0x1BC9748", Offset="0x1BC9748", VA="0x1BC9748")]
			get
			{
				return null;
			}
			[Address(RVA="0x1BC9750", Offset="0x1BC9750", VA="0x1BC9750")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109B9B0", Offset="0x109B9B0")]
		public string ClientVersion
		{
			[Address(RVA="0x1BC97C0", Offset="0x1BC97C0", VA="0x1BC97C0")]
			get
			{
				return null;
			}
			[Address(RVA="0x1BC97C8", Offset="0x1BC97C8", VA="0x1BC97C8")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109B9E0", Offset="0x109B9E0")]
		public ulong CorrelationId
		{
			[Address(RVA="0x1BC9928", Offset="0x1BC9928", VA="0x1BC9928")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1BC9930", Offset="0x1BC9930", VA="0x1BC9930")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109B970", Offset="0x109B970")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1BC934C", Offset="0x1BC934C", VA="0x1BC934C")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109B9C0", Offset="0x109B9C0")]
		public string GamedataVersion
		{
			[Address(RVA="0x1BC9838", Offset="0x1BC9838", VA="0x1BC9838")]
			get
			{
				return null;
			}
			[Address(RVA="0x1BC9840", Offset="0x1BC9840", VA="0x1BC9840")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109B960", Offset="0x109B960")]
		public static MessageParser<RequestEnvelope> Parser
		{
			[Address(RVA="0x1BC92E4", Offset="0x1BC92E4", VA="0x1BC92E4")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109B990", Offset="0x109B990")]
		public ByteString Payload
		{
			[Address(RVA="0x1BC96D0", Offset="0x1BC96D0", VA="0x1BC96D0")]
			get
			{
				return null;
			}
			[Address(RVA="0x1BC96D8", Offset="0x1BC96D8", VA="0x1BC96D8")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109B980", Offset="0x109B980")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1BC94A0", Offset="0x1BC94A0", VA="0x1BC94A0", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109B9D0", Offset="0x109B9D0")]
		public string RpcName
		{
			[Address(RVA="0x1BC98B0", Offset="0x1BC98B0", VA="0x1BC98B0")]
			get
			{
				return null;
			}
			[Address(RVA="0x1BC98B8", Offset="0x1BC98B8", VA="0x1BC98B8")]
			set
			{
			}
		}

		[Address(RVA="0x1BCA4B0", Offset="0x1BCA4B0", VA="0x1BCA4B0")]
		static RequestEnvelope()
		{
		}

		[Address(RVA="0x1BC94FC", Offset="0x1BC94FC", VA="0x1BC94FC")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10876BC", Offset="0x10876BC")]
		public RequestEnvelope()
		{
		}

		[Address(RVA="0x1BC9584", Offset="0x1BC9584", VA="0x1BC9584")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10876CC", Offset="0x10876CC")]
		public RequestEnvelope(RequestEnvelope other)
		{
		}

		[Address(RVA="0x1BC9FBC", Offset="0x1BC9FBC", VA="0x1BC9FBC", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108773C", Offset="0x108773C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1BC9670", Offset="0x1BC9670", VA="0x1BC9670", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10876DC", Offset="0x10876DC")]
		public RequestEnvelope Clone()
		{
			return null;
		}

		[Address(RVA="0x1BC9938", Offset="0x1BC9938", VA="0x1BC9938", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10876EC", Offset="0x10876EC")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1BC99AC", Offset="0x1BC99AC", VA="0x1BC99AC", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10876FC", Offset="0x10876FC")]
		public bool Equals(RequestEnvelope other)
		{
			return new bool();
		}

		[Address(RVA="0x1BC9AC8", Offset="0x1BC9AC8", VA="0x1BC9AC8", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108770C", Offset="0x108770C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1BCA214", Offset="0x1BCA214", VA="0x1BCA214", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108774C", Offset="0x108774C")]
		public void MergeFrom(RequestEnvelope other)
		{
		}

		[Address(RVA="0x1BCA33C", Offset="0x1BCA33C", VA="0x1BCA33C", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108775C", Offset="0x108775C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1BC9C84", Offset="0x1BC9C84", VA="0x1BC9C84", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108771C", Offset="0x108771C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1BC9CEC", Offset="0x1BC9CEC", VA="0x1BC9CEC", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108772C", Offset="0x108772C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1050958", Offset="0x1050958")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static RequestEnvelope.<>c <>9;

			[Address(RVA="0x1BCA588", Offset="0x1BCA588", VA="0x1BCA588")]
			static <>c()
			{
			}

			[Address(RVA="0x1BCA5EC", Offset="0x1BCA5EC", VA="0x1BCA5EC")]
			public <>c()
			{
			}

			[Address(RVA="0x1BCA5F4", Offset="0x1BCA5F4", VA="0x1BCA5F4")]
			internal RequestEnvelope <.cctor>b__50_0()
			{
				return null;
			}
		}
	}
}