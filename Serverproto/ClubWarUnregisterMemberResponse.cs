using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class ClubWarUnregisterMemberResponse : IMessage<ClubWarUnregisterMemberResponse>, IMessage, IEquatable<ClubWarUnregisterMemberResponse>, IDeepCloneable<ClubWarUnregisterMemberResponse>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<ClubWarUnregisterMemberResponse> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1095F50", Offset="0x1095F50")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1EE7A90", Offset="0x1EE7A90", VA="0x1EE7A90")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1095F40", Offset="0x1095F40")]
		public static MessageParser<ClubWarUnregisterMemberResponse> Parser
		{
			[Address(RVA="0x1EE7A28", Offset="0x1EE7A28", VA="0x1EE7A28")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1095F60", Offset="0x1095F60")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1EE7B80", Offset="0x1EE7B80", VA="0x1EE7B80", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1EE7E94", Offset="0x1EE7E94", VA="0x1EE7E94")]
		static ClubWarUnregisterMemberResponse()
		{
		}

		[Address(RVA="0x1EE7BDC", Offset="0x1EE7BDC", VA="0x1EE7BDC")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107DA6C", Offset="0x107DA6C")]
		public ClubWarUnregisterMemberResponse()
		{
		}

		[Address(RVA="0x1EE7BE4", Offset="0x1EE7BE4", VA="0x1EE7BE4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107DA7C", Offset="0x107DA7C")]
		public ClubWarUnregisterMemberResponse(ClubWarUnregisterMemberResponse other)
		{
		}

		[Address(RVA="0x1EE7DF8", Offset="0x1EE7DF8", VA="0x1EE7DF8", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107DAEC", Offset="0x107DAEC")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1EE7C28", Offset="0x1EE7C28", VA="0x1EE7C28", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107DA8C", Offset="0x107DA8C")]
		public ClubWarUnregisterMemberResponse Clone()
		{
			return null;
		}

		[Address(RVA="0x1EE7C88", Offset="0x1EE7C88", VA="0x1EE7C88", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107DA9C", Offset="0x107DA9C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1EE7D20", Offset="0x1EE7D20", VA="0x1EE7D20", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107DAAC", Offset="0x107DAAC")]
		public bool Equals(ClubWarUnregisterMemberResponse other)
		{
			return new bool();
		}

		[Address(RVA="0x1EE7D4C", Offset="0x1EE7D4C", VA="0x1EE7D4C", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107DABC", Offset="0x107DABC")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1EE7E0C", Offset="0x1EE7E0C", VA="0x1EE7E0C", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107DAFC", Offset="0x107DAFC")]
		public void MergeFrom(ClubWarUnregisterMemberResponse other)
		{
		}

		[Address(RVA="0x1EE7E40", Offset="0x1EE7E40", VA="0x1EE7E40", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107DB0C", Offset="0x107DB0C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1EE7D7C", Offset="0x1EE7D7C", VA="0x1EE7D7C", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107DACC", Offset="0x107DACC")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1EE7DE4", Offset="0x1EE7DE4", VA="0x1EE7DE4", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107DADC", Offset="0x107DADC")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104FB28", Offset="0x104FB28")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static ClubWarUnregisterMemberResponse.<>c <>9;

			[Address(RVA="0x1EE7F6C", Offset="0x1EE7F6C", VA="0x1EE7F6C")]
			static <>c()
			{
			}

			[Address(RVA="0x1EE7FD0", Offset="0x1EE7FD0", VA="0x1EE7FD0")]
			public <>c()
			{
			}

			[Address(RVA="0x1EE7FD8", Offset="0x1EE7FD8", VA="0x1EE7FD8")]
			internal ClubWarUnregisterMemberResponse <.cctor>b__20_0()
			{
				return null;
			}
		}
	}
}