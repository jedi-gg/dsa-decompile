using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class ClubDungeonResponse : IMessage<ClubDungeonResponse>, IMessage, IEquatable<ClubDungeonResponse>, IDeepCloneable<ClubDungeonResponse>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<ClubDungeonResponse> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int DungeonFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private ClubDungeon dungeon_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1095770", Offset="0x1095770")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1FF34BC", Offset="0x1FF34BC", VA="0x1FF34BC")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1095790", Offset="0x1095790")]
		public ClubDungeon Dungeon
		{
			[Address(RVA="0x1FF3688", Offset="0x1FF3688", VA="0x1FF3688")]
			get
			{
				return null;
			}
			[Address(RVA="0x1FF3690", Offset="0x1FF3690", VA="0x1FF3690")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1095760", Offset="0x1095760")]
		public static MessageParser<ClubDungeonResponse> Parser
		{
			[Address(RVA="0x1FF3454", Offset="0x1FF3454", VA="0x1FF3454")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1095780", Offset="0x1095780")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1FF35A8", Offset="0x1FF35A8", VA="0x1FF35A8", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1FF3B50", Offset="0x1FF3B50", VA="0x1FF3B50")]
		static ClubDungeonResponse()
		{
		}

		[Address(RVA="0x1FF3604", Offset="0x1FF3604", VA="0x1FF3604")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107C93C", Offset="0x107C93C")]
		public ClubDungeonResponse()
		{
		}

		[Address(RVA="0x1FF360C", Offset="0x1FF360C", VA="0x1FF360C")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107C94C", Offset="0x107C94C")]
		public ClubDungeonResponse(ClubDungeonResponse other)
		{
		}

		[Address(RVA="0x1FF3930", Offset="0x1FF3930", VA="0x1FF3930", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107C9BC", Offset="0x107C9BC")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1FF3698", Offset="0x1FF3698", VA="0x1FF3698", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107C95C", Offset="0x107C95C")]
		public ClubDungeonResponse Clone()
		{
			return null;
		}

		[Address(RVA="0x1FF36F8", Offset="0x1FF36F8", VA="0x1FF36F8", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107C96C", Offset="0x107C96C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1FF376C", Offset="0x1FF376C", VA="0x1FF376C", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107C97C", Offset="0x107C97C")]
		public bool Equals(ClubDungeonResponse other)
		{
			return new bool();
		}

		[Address(RVA="0x1FF37D0", Offset="0x1FF37D0", VA="0x1FF37D0", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107C98C", Offset="0x107C98C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1FF39C0", Offset="0x1FF39C0", VA="0x1FF39C0", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107C9CC", Offset="0x107C9CC")]
		public void MergeFrom(ClubDungeonResponse other)
		{
		}

		[Address(RVA="0x1FF3A74", Offset="0x1FF3A74", VA="0x1FF3A74", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107C9DC", Offset="0x107C9DC")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1FF3828", Offset="0x1FF3828", VA="0x1FF3828", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107C99C", Offset="0x107C99C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1FF3890", Offset="0x1FF3890", VA="0x1FF3890", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107C9AC", Offset="0x107C9AC")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104F988", Offset="0x104F988")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static ClubDungeonResponse.<>c <>9;

			[Address(RVA="0x1FF3C28", Offset="0x1FF3C28", VA="0x1FF3C28")]
			static <>c()
			{
			}

			[Address(RVA="0x1FF3C8C", Offset="0x1FF3C8C", VA="0x1FF3C8C")]
			public <>c()
			{
			}

			[Address(RVA="0x1FF3C94", Offset="0x1FF3C94", VA="0x1FF3C94")]
			internal ClubDungeonResponse <.cctor>b__25_0()
			{
				return null;
			}
		}
	}
}