using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class RejectClubInviteRequest : IMessage<RejectClubInviteRequest>, IMessage, IEquatable<RejectClubInviteRequest>, IDeepCloneable<RejectClubInviteRequest>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<RejectClubInviteRequest> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int ClubIdFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private string clubId_;

		[FieldOffset(Offset="0x0")]
		public const int PlayerIdFieldNumber = 2;

		[FieldOffset(Offset="0x20")]
		private string playerId_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1095040", Offset="0x1095040")]
		public string ClubId
		{
			[Address(RVA="0x2023854", Offset="0x2023854", VA="0x2023854")]
			get
			{
				return null;
			}
			[Address(RVA="0x202385C", Offset="0x202385C", VA="0x202385C")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1095020", Offset="0x1095020")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x20235D4", Offset="0x20235D4", VA="0x20235D4")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1095010", Offset="0x1095010")]
		public static MessageParser<RejectClubInviteRequest> Parser
		{
			[Address(RVA="0x202356C", Offset="0x202356C", VA="0x202356C")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1095030", Offset="0x1095030")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x20236C4", Offset="0x20236C4", VA="0x20236C4", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1095050", Offset="0x1095050")]
		public string PlayerId
		{
			[Address(RVA="0x20238CC", Offset="0x20238CC", VA="0x20238CC")]
			get
			{
				return null;
			}
			[Address(RVA="0x20238D4", Offset="0x20238D4", VA="0x20238D4")]
			set
			{
			}
		}

		[Address(RVA="0x2023EF0", Offset="0x2023EF0", VA="0x2023EF0")]
		static RejectClubInviteRequest()
		{
		}

		[Address(RVA="0x2023720", Offset="0x2023720", VA="0x2023720")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107B6AC", Offset="0x107B6AC")]
		public RejectClubInviteRequest()
		{
		}

		[Address(RVA="0x2023778", Offset="0x2023778", VA="0x2023778")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107B6BC", Offset="0x107B6BC")]
		public RejectClubInviteRequest(RejectClubInviteRequest other)
		{
		}

		[Address(RVA="0x2023C90", Offset="0x2023C90", VA="0x2023C90", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107B72C", Offset="0x107B72C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x20237F4", Offset="0x20237F4", VA="0x20237F4", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107B6CC", Offset="0x107B6CC")]
		public RejectClubInviteRequest Clone()
		{
			return null;
		}

		[Address(RVA="0x2023944", Offset="0x2023944", VA="0x2023944", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107B6DC", Offset="0x107B6DC")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x20239B8", Offset="0x20239B8", VA="0x20239B8", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107B6EC", Offset="0x107B6EC")]
		public bool Equals(RejectClubInviteRequest other)
		{
			return new bool();
		}

		[Address(RVA="0x2023A30", Offset="0x2023A30", VA="0x2023A30", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107B6FC", Offset="0x107B6FC")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x2023DA4", Offset="0x2023DA4", VA="0x2023DA4", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107B73C", Offset="0x107B73C")]
		public void MergeFrom(RejectClubInviteRequest other)
		{
		}

		[Address(RVA="0x2023E3C", Offset="0x2023E3C", VA="0x2023E3C", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107B74C", Offset="0x107B74C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x2023B00", Offset="0x2023B00", VA="0x2023B00", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107B70C", Offset="0x107B70C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x2023B68", Offset="0x2023B68", VA="0x2023B68", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107B71C", Offset="0x107B71C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104F7D8", Offset="0x104F7D8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static RejectClubInviteRequest.<>c <>9;

			[Address(RVA="0x2023FC8", Offset="0x2023FC8", VA="0x2023FC8")]
			static <>c()
			{
			}

			[Address(RVA="0x202402C", Offset="0x202402C", VA="0x202402C")]
			public <>c()
			{
			}

			[Address(RVA="0x2024034", Offset="0x2024034", VA="0x2024034")]
			internal RejectClubInviteRequest <.cctor>b__30_0()
			{
				return null;
			}
		}
	}
}