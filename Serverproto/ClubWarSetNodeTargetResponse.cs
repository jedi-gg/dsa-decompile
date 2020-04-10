using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class ClubWarSetNodeTargetResponse : IMessage<ClubWarSetNodeTargetResponse>, IMessage, IEquatable<ClubWarSetNodeTargetResponse>, IDeepCloneable<ClubWarSetNodeTargetResponse>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<ClubWarSetNodeTargetResponse> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10964C0", Offset="0x10964C0")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1EE5868", Offset="0x1EE5868", VA="0x1EE5868")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10964B0", Offset="0x10964B0")]
		public static MessageParser<ClubWarSetNodeTargetResponse> Parser
		{
			[Address(RVA="0x1EE5800", Offset="0x1EE5800", VA="0x1EE5800")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10964D0", Offset="0x10964D0")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1EE5958", Offset="0x1EE5958", VA="0x1EE5958", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1EE5C6C", Offset="0x1EE5C6C", VA="0x1EE5C6C")]
		static ClubWarSetNodeTargetResponse()
		{
		}

		[Address(RVA="0x1EE59B4", Offset="0x1EE59B4", VA="0x1EE59B4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107E77C", Offset="0x107E77C")]
		public ClubWarSetNodeTargetResponse()
		{
		}

		[Address(RVA="0x1EE59BC", Offset="0x1EE59BC", VA="0x1EE59BC")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107E78C", Offset="0x107E78C")]
		public ClubWarSetNodeTargetResponse(ClubWarSetNodeTargetResponse other)
		{
		}

		[Address(RVA="0x1EE5BD0", Offset="0x1EE5BD0", VA="0x1EE5BD0", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107E7FC", Offset="0x107E7FC")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1EE5A00", Offset="0x1EE5A00", VA="0x1EE5A00", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107E79C", Offset="0x107E79C")]
		public ClubWarSetNodeTargetResponse Clone()
		{
			return null;
		}

		[Address(RVA="0x1EE5A60", Offset="0x1EE5A60", VA="0x1EE5A60", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107E7AC", Offset="0x107E7AC")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1EE5AF8", Offset="0x1EE5AF8", VA="0x1EE5AF8", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107E7BC", Offset="0x107E7BC")]
		public bool Equals(ClubWarSetNodeTargetResponse other)
		{
			return new bool();
		}

		[Address(RVA="0x1EE5B24", Offset="0x1EE5B24", VA="0x1EE5B24", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107E7CC", Offset="0x107E7CC")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1EE5BE4", Offset="0x1EE5BE4", VA="0x1EE5BE4", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107E80C", Offset="0x107E80C")]
		public void MergeFrom(ClubWarSetNodeTargetResponse other)
		{
		}

		[Address(RVA="0x1EE5C18", Offset="0x1EE5C18", VA="0x1EE5C18", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107E81C", Offset="0x107E81C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1EE5B54", Offset="0x1EE5B54", VA="0x1EE5B54", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107E7DC", Offset="0x107E7DC")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1EE5BBC", Offset="0x1EE5BBC", VA="0x1EE5BBC", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107E7EC", Offset="0x107E7EC")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104FC58", Offset="0x104FC58")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static ClubWarSetNodeTargetResponse.<>c <>9;

			[Address(RVA="0x1EE5D44", Offset="0x1EE5D44", VA="0x1EE5D44")]
			static <>c()
			{
			}

			[Address(RVA="0x1EE5DA8", Offset="0x1EE5DA8", VA="0x1EE5DA8")]
			public <>c()
			{
			}

			[Address(RVA="0x1EE5DB0", Offset="0x1EE5DB0", VA="0x1EE5DB0")]
			internal ClubWarSetNodeTargetResponse <.cctor>b__20_0()
			{
				return null;
			}
		}
	}
}