using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class GetEventStatusRequest : IMessage<GetEventStatusRequest>, IMessage, IEquatable<GetEventStatusRequest>, IDeepCloneable<GetEventStatusRequest>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<GetEventStatusRequest> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int EventContentIdFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private ulong eventContentId_;

		[FieldOffset(Offset="0x0")]
		public const int EventContentIdsFieldNumber = 2;

		[FieldOffset(Offset="0x8")]
		private readonly static FieldCodec<ulong> _repeated_eventContentIds_codec;

		[FieldOffset(Offset="0x20")]
		private readonly RepeatedField<ulong> eventContentIds_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10975D8", Offset="0x10975D8")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1BA9AD0", Offset="0x1BA9AD0", VA="0x1BA9AD0")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10975F8", Offset="0x10975F8")]
		[Attribute(Name="ObsoleteAttribute", RVA="0x10975F8", Offset="0x10975F8")]
		public ulong EventContentId
		{
			[Address(RVA="0x1BA9DA4", Offset="0x1BA9DA4", VA="0x1BA9DA4")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1BA9DAC", Offset="0x1BA9DAC", VA="0x1BA9DAC")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1097630", Offset="0x1097630")]
		public RepeatedField<ulong> EventContentIds
		{
			[Address(RVA="0x1BA9DB4", Offset="0x1BA9DB4", VA="0x1BA9DB4")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10975C8", Offset="0x10975C8")]
		public static MessageParser<GetEventStatusRequest> Parser
		{
			[Address(RVA="0x1BA9A68", Offset="0x1BA9A68", VA="0x1BA9A68")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10975E8", Offset="0x10975E8")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1BA9BC0", Offset="0x1BA9BC0", VA="0x1BA9BC0", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1BAA3B0", Offset="0x1BAA3B0", VA="0x1BAA3B0")]
		static GetEventStatusRequest()
		{
		}

		[Address(RVA="0x1BA9C1C", Offset="0x1BA9C1C", VA="0x1BA9C1C")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107FEDC", Offset="0x107FEDC")]
		public GetEventStatusRequest()
		{
		}

		[Address(RVA="0x1BA9C8C", Offset="0x1BA9C8C", VA="0x1BA9C8C")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107FEEC", Offset="0x107FEEC")]
		public GetEventStatusRequest(GetEventStatusRequest other)
		{
		}

		[Address(RVA="0x1BAA104", Offset="0x1BAA104", VA="0x1BAA104", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107FF5C", Offset="0x107FF5C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1BA9D44", Offset="0x1BA9D44", VA="0x1BA9D44", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107FEFC", Offset="0x107FEFC")]
		public GetEventStatusRequest Clone()
		{
			return null;
		}

		[Address(RVA="0x1BA9DBC", Offset="0x1BA9DBC", VA="0x1BA9DBC", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107FF0C", Offset="0x107FF0C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1BA9E30", Offset="0x1BA9E30", VA="0x1BA9E30", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107FF1C", Offset="0x107FF1C")]
		public bool Equals(GetEventStatusRequest other)
		{
			return new bool();
		}

		[Address(RVA="0x1BA9EF0", Offset="0x1BA9EF0", VA="0x1BA9EF0", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107FF2C", Offset="0x107FF2C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1BAA200", Offset="0x1BAA200", VA="0x1BAA200", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107FF6C", Offset="0x107FF6C")]
		public void MergeFrom(GetEventStatusRequest other)
		{
		}

		[Address(RVA="0x1BAA29C", Offset="0x1BAA29C", VA="0x1BAA29C", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107FF7C", Offset="0x107FF7C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1BA9F80", Offset="0x1BA9F80", VA="0x1BA9F80", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107FF3C", Offset="0x107FF3C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1BA9FE8", Offset="0x1BA9FE8", VA="0x1BA9FE8", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107FF4C", Offset="0x107FF4C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104FE78", Offset="0x104FE78")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static GetEventStatusRequest.<>c <>9;

			[Address(RVA="0x1BAA4A0", Offset="0x1BAA4A0", VA="0x1BAA4A0")]
			static <>c()
			{
			}

			[Address(RVA="0x1BAA504", Offset="0x1BAA504", VA="0x1BAA504")]
			public <>c()
			{
			}

			[Address(RVA="0x1BAA50C", Offset="0x1BAA50C", VA="0x1BAA50C")]
			internal GetEventStatusRequest <.cctor>b__30_0()
			{
				return null;
			}
		}
	}
}