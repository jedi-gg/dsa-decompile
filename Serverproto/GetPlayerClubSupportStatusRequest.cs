using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class GetPlayerClubSupportStatusRequest : IMessage<GetPlayerClubSupportStatusRequest>, IMessage, IEquatable<GetPlayerClubSupportStatusRequest>, IDeepCloneable<GetPlayerClubSupportStatusRequest>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<GetPlayerClubSupportStatusRequest> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int SupportRequestTypeFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private ClubSupportRequestType supportRequestType_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10953B0", Offset="0x10953B0")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1BAB15C", Offset="0x1BAB15C", VA="0x1BAB15C")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10953A0", Offset="0x10953A0")]
		public static MessageParser<GetPlayerClubSupportStatusRequest> Parser
		{
			[Address(RVA="0x1BAB0F4", Offset="0x1BAB0F4", VA="0x1BAB0F4")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10953C0", Offset="0x10953C0")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1BAB24C", Offset="0x1BAB24C", VA="0x1BAB24C", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10953D0", Offset="0x10953D0")]
		public ClubSupportRequestType SupportRequestType
		{
			[Address(RVA="0x1BAB374", Offset="0x1BAB374", VA="0x1BAB374")]
			get
			{
				return new ClubSupportRequestType();
			}
			[Address(RVA="0x1BAB37C", Offset="0x1BAB37C", VA="0x1BAB37C")]
			set
			{
			}
		}

		[Address(RVA="0x1BAB6F0", Offset="0x1BAB6F0", VA="0x1BAB6F0")]
		static GetPlayerClubSupportStatusRequest()
		{
		}

		[Address(RVA="0x1BAB2A8", Offset="0x1BAB2A8", VA="0x1BAB2A8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107C04C", Offset="0x107C04C")]
		public GetPlayerClubSupportStatusRequest()
		{
		}

		[Address(RVA="0x1BAB2B0", Offset="0x1BAB2B0", VA="0x1BAB2B0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107C05C", Offset="0x107C05C")]
		public GetPlayerClubSupportStatusRequest(GetPlayerClubSupportStatusRequest other)
		{
		}

		[Address(RVA="0x1BAB5A4", Offset="0x1BAB5A4", VA="0x1BAB5A4", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107C0CC", Offset="0x107C0CC")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1BAB314", Offset="0x1BAB314", VA="0x1BAB314", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107C06C", Offset="0x107C06C")]
		public GetPlayerClubSupportStatusRequest Clone()
		{
			return null;
		}

		[Address(RVA="0x1BAB384", Offset="0x1BAB384", VA="0x1BAB384", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107C07C", Offset="0x107C07C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1BAB3F8", Offset="0x1BAB3F8", VA="0x1BAB3F8", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107C08C", Offset="0x107C08C")]
		public bool Equals(GetPlayerClubSupportStatusRequest other)
		{
			return new bool();
		}

		[Address(RVA="0x1BAB434", Offset="0x1BAB434", VA="0x1BAB434", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107C09C", Offset="0x107C09C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1BAB634", Offset="0x1BAB634", VA="0x1BAB634", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107C0DC", Offset="0x107C0DC")]
		public void MergeFrom(GetPlayerClubSupportStatusRequest other)
		{
		}

		[Address(RVA="0x1BAB674", Offset="0x1BAB674", VA="0x1BAB674", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107C0EC", Offset="0x107C0EC")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1BAB49C", Offset="0x1BAB49C", VA="0x1BAB49C", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107C0AC", Offset="0x107C0AC")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1BAB504", Offset="0x1BAB504", VA="0x1BAB504", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107C0BC", Offset="0x107C0BC")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104F8B8", Offset="0x104F8B8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static GetPlayerClubSupportStatusRequest.<>c <>9;

			[Address(RVA="0x1BAB7C8", Offset="0x1BAB7C8", VA="0x1BAB7C8")]
			static <>c()
			{
			}

			[Address(RVA="0x1BAB82C", Offset="0x1BAB82C", VA="0x1BAB82C")]
			public <>c()
			{
			}

			[Address(RVA="0x1BAB834", Offset="0x1BAB834", VA="0x1BAB834")]
			internal GetPlayerClubSupportStatusRequest <.cctor>b__25_0()
			{
				return null;
			}
		}
	}
}