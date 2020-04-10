using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class ClubWarRegisterMemberResponse : IMessage<ClubWarRegisterMemberResponse>, IMessage, IEquatable<ClubWarRegisterMemberResponse>, IDeepCloneable<ClubWarRegisterMemberResponse>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<ClubWarRegisterMemberResponse> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1095EF0", Offset="0x1095EF0")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1B29668", Offset="0x1B29668", VA="0x1B29668")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1095EE0", Offset="0x1095EE0")]
		public static MessageParser<ClubWarRegisterMemberResponse> Parser
		{
			[Address(RVA="0x1B29600", Offset="0x1B29600", VA="0x1B29600")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1095F00", Offset="0x1095F00")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1B29758", Offset="0x1B29758", VA="0x1B29758", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1B29A6C", Offset="0x1B29A6C", VA="0x1B29A6C")]
		static ClubWarRegisterMemberResponse()
		{
		}

		[Address(RVA="0x1B297B4", Offset="0x1B297B4", VA="0x1B297B4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107D90C", Offset="0x107D90C")]
		public ClubWarRegisterMemberResponse()
		{
		}

		[Address(RVA="0x1B297BC", Offset="0x1B297BC", VA="0x1B297BC")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107D91C", Offset="0x107D91C")]
		public ClubWarRegisterMemberResponse(ClubWarRegisterMemberResponse other)
		{
		}

		[Address(RVA="0x1B299D0", Offset="0x1B299D0", VA="0x1B299D0", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107D98C", Offset="0x107D98C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1B29800", Offset="0x1B29800", VA="0x1B29800", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107D92C", Offset="0x107D92C")]
		public ClubWarRegisterMemberResponse Clone()
		{
			return null;
		}

		[Address(RVA="0x1B29860", Offset="0x1B29860", VA="0x1B29860", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107D93C", Offset="0x107D93C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1B298F8", Offset="0x1B298F8", VA="0x1B298F8", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107D94C", Offset="0x107D94C")]
		public bool Equals(ClubWarRegisterMemberResponse other)
		{
			return new bool();
		}

		[Address(RVA="0x1B29924", Offset="0x1B29924", VA="0x1B29924", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107D95C", Offset="0x107D95C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1B299E4", Offset="0x1B299E4", VA="0x1B299E4", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107D99C", Offset="0x107D99C")]
		public void MergeFrom(ClubWarRegisterMemberResponse other)
		{
		}

		[Address(RVA="0x1B29A18", Offset="0x1B29A18", VA="0x1B29A18", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107D9AC", Offset="0x107D9AC")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1B29954", Offset="0x1B29954", VA="0x1B29954", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107D96C", Offset="0x107D96C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1B299BC", Offset="0x1B299BC", VA="0x1B299BC", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107D97C", Offset="0x107D97C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104FB08", Offset="0x104FB08")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static ClubWarRegisterMemberResponse.<>c <>9;

			[Address(RVA="0x1B29B44", Offset="0x1B29B44", VA="0x1B29B44")]
			static <>c()
			{
			}

			[Address(RVA="0x1B29BA8", Offset="0x1B29BA8", VA="0x1B29BA8")]
			public <>c()
			{
			}

			[Address(RVA="0x1B29BB0", Offset="0x1B29BB0", VA="0x1B29BB0")]
			internal ClubWarRegisterMemberResponse <.cctor>b__20_0()
			{
				return null;
			}
		}
	}
}