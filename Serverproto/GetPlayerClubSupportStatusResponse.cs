using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class GetPlayerClubSupportStatusResponse : IMessage<GetPlayerClubSupportStatusResponse>, IMessage, IEquatable<GetPlayerClubSupportStatusResponse>, IDeepCloneable<GetPlayerClubSupportStatusResponse>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<GetPlayerClubSupportStatusResponse> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int SupportRequestFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private ClubSupportRequest supportRequest_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10953F0", Offset="0x10953F0")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1BAB8F8", Offset="0x1BAB8F8", VA="0x1BAB8F8")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10953E0", Offset="0x10953E0")]
		public static MessageParser<GetPlayerClubSupportStatusResponse> Parser
		{
			[Address(RVA="0x1BAB890", Offset="0x1BAB890", VA="0x1BAB890")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1095400", Offset="0x1095400")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1BAB9E8", Offset="0x1BAB9E8", VA="0x1BAB9E8", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1095410", Offset="0x1095410")]
		public ClubSupportRequest SupportRequest
		{
			[Address(RVA="0x1BABAC8", Offset="0x1BABAC8", VA="0x1BABAC8")]
			get
			{
				return null;
			}
			[Address(RVA="0x1BABAD0", Offset="0x1BABAD0", VA="0x1BABAD0")]
			set
			{
			}
		}

		[Address(RVA="0x1BABF90", Offset="0x1BABF90", VA="0x1BABF90")]
		static GetPlayerClubSupportStatusResponse()
		{
		}

		[Address(RVA="0x1BABA44", Offset="0x1BABA44", VA="0x1BABA44")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107C0FC", Offset="0x107C0FC")]
		public GetPlayerClubSupportStatusResponse()
		{
		}

		[Address(RVA="0x1BABA4C", Offset="0x1BABA4C", VA="0x1BABA4C")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107C10C", Offset="0x107C10C")]
		public GetPlayerClubSupportStatusResponse(GetPlayerClubSupportStatusResponse other)
		{
		}

		[Address(RVA="0x1BABD70", Offset="0x1BABD70", VA="0x1BABD70", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107C17C", Offset="0x107C17C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1BABAD8", Offset="0x1BABAD8", VA="0x1BABAD8", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107C11C", Offset="0x107C11C")]
		public GetPlayerClubSupportStatusResponse Clone()
		{
			return null;
		}

		[Address(RVA="0x1BABB38", Offset="0x1BABB38", VA="0x1BABB38", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107C12C", Offset="0x107C12C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1BABBAC", Offset="0x1BABBAC", VA="0x1BABBAC", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107C13C", Offset="0x107C13C")]
		public bool Equals(GetPlayerClubSupportStatusResponse other)
		{
			return new bool();
		}

		[Address(RVA="0x1BABC10", Offset="0x1BABC10", VA="0x1BABC10", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107C14C", Offset="0x107C14C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1BABE00", Offset="0x1BABE00", VA="0x1BABE00", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107C18C", Offset="0x107C18C")]
		public void MergeFrom(GetPlayerClubSupportStatusResponse other)
		{
		}

		[Address(RVA="0x1BABEB4", Offset="0x1BABEB4", VA="0x1BABEB4", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107C19C", Offset="0x107C19C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1BABC68", Offset="0x1BABC68", VA="0x1BABC68", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107C15C", Offset="0x107C15C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1BABCD0", Offset="0x1BABCD0", VA="0x1BABCD0", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107C16C", Offset="0x107C16C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104F8C8", Offset="0x104F8C8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static GetPlayerClubSupportStatusResponse.<>c <>9;

			[Address(RVA="0x1BAC068", Offset="0x1BAC068", VA="0x1BAC068")]
			static <>c()
			{
			}

			[Address(RVA="0x1BAC0CC", Offset="0x1BAC0CC", VA="0x1BAC0CC")]
			public <>c()
			{
			}

			[Address(RVA="0x1BAC0D4", Offset="0x1BAC0D4", VA="0x1BAC0D4")]
			internal GetPlayerClubSupportStatusResponse <.cctor>b__25_0()
			{
				return null;
			}
		}
	}
}