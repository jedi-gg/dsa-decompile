using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class UnblockChatUserRequest : IMessage<UnblockChatUserRequest>, IMessage, IEquatable<UnblockChatUserRequest>, IDeepCloneable<UnblockChatUserRequest>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<UnblockChatUserRequest> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int PlayerIdFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private string playerId_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1094790", Offset="0x1094790")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1B7A6B4", Offset="0x1B7A6B4", VA="0x1B7A6B4")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1094780", Offset="0x1094780")]
		public static MessageParser<UnblockChatUserRequest> Parser
		{
			[Address(RVA="0x1B7A64C", Offset="0x1B7A64C", VA="0x1B7A64C")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10947A0", Offset="0x10947A0")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1B7A7A4", Offset="0x1B7A7A4", VA="0x1B7A7A4", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10947B0", Offset="0x10947B0")]
		public string PlayerId
		{
			[Address(RVA="0x1B7A918", Offset="0x1B7A918", VA="0x1B7A918")]
			get
			{
				return null;
			}
			[Address(RVA="0x1B7A920", Offset="0x1B7A920", VA="0x1B7A920")]
			set
			{
			}
		}

		[Address(RVA="0x1B7ADB0", Offset="0x1B7ADB0", VA="0x1B7ADB0")]
		static UnblockChatUserRequest()
		{
		}

		[Address(RVA="0x1B7A800", Offset="0x1B7A800", VA="0x1B7A800")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107A4CC", Offset="0x107A4CC")]
		public UnblockChatUserRequest()
		{
		}

		[Address(RVA="0x1B7A858", Offset="0x1B7A858", VA="0x1B7A858")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107A4DC", Offset="0x107A4DC")]
		public UnblockChatUserRequest(UnblockChatUserRequest other)
		{
		}

		[Address(RVA="0x1B7AC0C", Offset="0x1B7AC0C", VA="0x1B7AC0C", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107A54C", Offset="0x107A54C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1B7A8B8", Offset="0x1B7A8B8", VA="0x1B7A8B8", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107A4EC", Offset="0x107A4EC")]
		public UnblockChatUserRequest Clone()
		{
			return null;
		}

		[Address(RVA="0x1B7A990", Offset="0x1B7A990", VA="0x1B7A990", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107A4FC", Offset="0x107A4FC")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1B7AA04", Offset="0x1B7AA04", VA="0x1B7AA04", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107A50C", Offset="0x107A50C")]
		public bool Equals(UnblockChatUserRequest other)
		{
			return new bool();
		}

		[Address(RVA="0x1B7AA68", Offset="0x1B7AA68", VA="0x1B7AA68", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107A51C", Offset="0x107A51C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1B7ACC0", Offset="0x1B7ACC0", VA="0x1B7ACC0", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107A55C", Offset="0x107A55C")]
		public void MergeFrom(UnblockChatUserRequest other)
		{
		}

		[Address(RVA="0x1B7AD2C", Offset="0x1B7AD2C", VA="0x1B7AD2C", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107A56C", Offset="0x107A56C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1B7AAEC", Offset="0x1B7AAEC", VA="0x1B7AAEC", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107A52C", Offset="0x107A52C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1B7AB54", Offset="0x1B7AB54", VA="0x1B7AB54", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107A53C", Offset="0x107A53C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104F638", Offset="0x104F638")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static UnblockChatUserRequest.<>c <>9;

			[Address(RVA="0x1B7AE88", Offset="0x1B7AE88", VA="0x1B7AE88")]
			static <>c()
			{
			}

			[Address(RVA="0x1B7AEEC", Offset="0x1B7AEEC", VA="0x1B7AEEC")]
			public <>c()
			{
			}

			[Address(RVA="0x1B7AEF4", Offset="0x1B7AEF4", VA="0x1B7AEF4")]
			internal UnblockChatUserRequest <.cctor>b__25_0()
			{
				return null;
			}
		}
	}
}