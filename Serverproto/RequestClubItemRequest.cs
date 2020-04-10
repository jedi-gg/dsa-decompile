using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class RequestClubItemRequest : IMessage<RequestClubItemRequest>, IMessage, IEquatable<RequestClubItemRequest>, IDeepCloneable<RequestClubItemRequest>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<RequestClubItemRequest> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int ItemIdFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private ulong itemId_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1095230", Offset="0x1095230")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x2024700", Offset="0x2024700", VA="0x2024700")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1095250", Offset="0x1095250")]
		public ulong ItemId
		{
			[Address(RVA="0x2024918", Offset="0x2024918", VA="0x2024918")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x2024920", Offset="0x2024920", VA="0x2024920")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1095220", Offset="0x1095220")]
		public static MessageParser<RequestClubItemRequest> Parser
		{
			[Address(RVA="0x2024698", Offset="0x2024698", VA="0x2024698")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1095240", Offset="0x1095240")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x20247F0", Offset="0x20247F0", VA="0x20247F0", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x2024C94", Offset="0x2024C94", VA="0x2024C94")]
		static RequestClubItemRequest()
		{
		}

		[Address(RVA="0x202484C", Offset="0x202484C", VA="0x202484C")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107BC2C", Offset="0x107BC2C")]
		public RequestClubItemRequest()
		{
		}

		[Address(RVA="0x2024854", Offset="0x2024854", VA="0x2024854")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107BC3C", Offset="0x107BC3C")]
		public RequestClubItemRequest(RequestClubItemRequest other)
		{
		}

		[Address(RVA="0x2024B48", Offset="0x2024B48", VA="0x2024B48", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107BCAC", Offset="0x107BCAC")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x20248B8", Offset="0x20248B8", VA="0x20248B8", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107BC4C", Offset="0x107BC4C")]
		public RequestClubItemRequest Clone()
		{
			return null;
		}

		[Address(RVA="0x2024928", Offset="0x2024928", VA="0x2024928", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107BC5C", Offset="0x107BC5C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x202499C", Offset="0x202499C", VA="0x202499C", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107BC6C", Offset="0x107BC6C")]
		public bool Equals(RequestClubItemRequest other)
		{
			return new bool();
		}

		[Address(RVA="0x20249D8", Offset="0x20249D8", VA="0x20249D8", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107BC7C", Offset="0x107BC7C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x2024BD8", Offset="0x2024BD8", VA="0x2024BD8", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107BCBC", Offset="0x107BCBC")]
		public void MergeFrom(RequestClubItemRequest other)
		{
		}

		[Address(RVA="0x2024C18", Offset="0x2024C18", VA="0x2024C18", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107BCCC", Offset="0x107BCCC")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x2024A40", Offset="0x2024A40", VA="0x2024A40", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107BC8C", Offset="0x107BC8C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x2024AA8", Offset="0x2024AA8", VA="0x2024AA8", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107BC9C", Offset="0x107BC9C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104F858", Offset="0x104F858")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static RequestClubItemRequest.<>c <>9;

			[Address(RVA="0x2024D6C", Offset="0x2024D6C", VA="0x2024D6C")]
			static <>c()
			{
			}

			[Address(RVA="0x2024DD0", Offset="0x2024DD0", VA="0x2024DD0")]
			public <>c()
			{
			}

			[Address(RVA="0x2024DD8", Offset="0x2024DD8", VA="0x2024DD8")]
			internal RequestClubItemRequest <.cctor>b__25_0()
			{
				return null;
			}
		}
	}
}