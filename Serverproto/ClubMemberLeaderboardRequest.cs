using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class ClubMemberLeaderboardRequest : IMessage<ClubMemberLeaderboardRequest>, IMessage, IEquatable<ClubMemberLeaderboardRequest>, IDeepCloneable<ClubMemberLeaderboardRequest>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<ClubMemberLeaderboardRequest> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int TypeFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private ClubMemberLeaderboardType type_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1099650", Offset="0x1099650")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1FFD414", Offset="0x1FFD414", VA="0x1FFD414")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1099640", Offset="0x1099640")]
		public static MessageParser<ClubMemberLeaderboardRequest> Parser
		{
			[Address(RVA="0x1FFD3AC", Offset="0x1FFD3AC", VA="0x1FFD3AC")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1099660", Offset="0x1099660")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1FFD504", Offset="0x1FFD504", VA="0x1FFD504", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1099670", Offset="0x1099670")]
		public ClubMemberLeaderboardType Type
		{
			[Address(RVA="0x1FFD62C", Offset="0x1FFD62C", VA="0x1FFD62C")]
			get
			{
				return new ClubMemberLeaderboardType();
			}
			[Address(RVA="0x1FFD634", Offset="0x1FFD634", VA="0x1FFD634")]
			set
			{
			}
		}

		[Address(RVA="0x1FFD9A8", Offset="0x1FFD9A8", VA="0x1FFD9A8")]
		static ClubMemberLeaderboardRequest()
		{
		}

		[Address(RVA="0x1FFD560", Offset="0x1FFD560", VA="0x1FFD560")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10835DC", Offset="0x10835DC")]
		public ClubMemberLeaderboardRequest()
		{
		}

		[Address(RVA="0x1FFD568", Offset="0x1FFD568", VA="0x1FFD568")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10835EC", Offset="0x10835EC")]
		public ClubMemberLeaderboardRequest(ClubMemberLeaderboardRequest other)
		{
		}

		[Address(RVA="0x1FFD85C", Offset="0x1FFD85C", VA="0x1FFD85C", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108365C", Offset="0x108365C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1FFD5CC", Offset="0x1FFD5CC", VA="0x1FFD5CC", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10835FC", Offset="0x10835FC")]
		public ClubMemberLeaderboardRequest Clone()
		{
			return null;
		}

		[Address(RVA="0x1FFD63C", Offset="0x1FFD63C", VA="0x1FFD63C", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108360C", Offset="0x108360C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1FFD6B0", Offset="0x1FFD6B0", VA="0x1FFD6B0", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108361C", Offset="0x108361C")]
		public bool Equals(ClubMemberLeaderboardRequest other)
		{
			return new bool();
		}

		[Address(RVA="0x1FFD6EC", Offset="0x1FFD6EC", VA="0x1FFD6EC", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108362C", Offset="0x108362C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1FFD8EC", Offset="0x1FFD8EC", VA="0x1FFD8EC", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108366C", Offset="0x108366C")]
		public void MergeFrom(ClubMemberLeaderboardRequest other)
		{
		}

		[Address(RVA="0x1FFD92C", Offset="0x1FFD92C", VA="0x1FFD92C", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108367C", Offset="0x108367C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1FFD754", Offset="0x1FFD754", VA="0x1FFD754", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108363C", Offset="0x108363C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1FFD7BC", Offset="0x1FFD7BC", VA="0x1FFD7BC", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108364C", Offset="0x108364C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1050378", Offset="0x1050378")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static ClubMemberLeaderboardRequest.<>c <>9;

			[Address(RVA="0x1FFDA80", Offset="0x1FFDA80", VA="0x1FFDA80")]
			static <>c()
			{
			}

			[Address(RVA="0x1FFDAE4", Offset="0x1FFDAE4", VA="0x1FFDAE4")]
			public <>c()
			{
			}

			[Address(RVA="0x1FFDAEC", Offset="0x1FFDAEC", VA="0x1FFDAEC")]
			internal ClubMemberLeaderboardRequest <.cctor>b__25_0()
			{
				return null;
			}
		}
	}
}