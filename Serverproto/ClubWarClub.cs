using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class ClubWarClub : IMessage<ClubWarClub>, IMessage, IEquatable<ClubWarClub>, IDeepCloneable<ClubWarClub>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<ClubWarClub> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int ClubFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private Serverproto.Club club_;

		[FieldOffset(Offset="0x0")]
		public const int GdTeamIdFieldNumber = 2;

		[FieldOffset(Offset="0x20")]
		private ulong gdTeamId_;

		[FieldOffset(Offset="0x0")]
		public const int ScoreFieldNumber = 3;

		[FieldOffset(Offset="0x28")]
		private ulong score_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1095C90", Offset="0x1095C90")]
		public Serverproto.Club Club
		{
			[Address(RVA="0x1B1F1E8", Offset="0x1B1F1E8", VA="0x1B1F1E8")]
			get
			{
				return null;
			}
			[Address(RVA="0x1B1F1F0", Offset="0x1B1F1F0", VA="0x1B1F1F0")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1095C70", Offset="0x1095C70")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1B1F008", Offset="0x1B1F008", VA="0x1B1F008")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1095CA0", Offset="0x1095CA0")]
		public ulong GdTeamId
		{
			[Address(RVA="0x1B1F258", Offset="0x1B1F258", VA="0x1B1F258")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1B1F260", Offset="0x1B1F260", VA="0x1B1F260")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1095C60", Offset="0x1095C60")]
		public static MessageParser<ClubWarClub> Parser
		{
			[Address(RVA="0x1B1907C", Offset="0x1B1907C", VA="0x1B1907C")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1095C80", Offset="0x1095C80")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1B1F0F8", Offset="0x1B1F0F8", VA="0x1B1F0F8", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1095CB0", Offset="0x1095CB0")]
		public ulong Score
		{
			[Address(RVA="0x1B1F268", Offset="0x1B1F268", VA="0x1B1F268")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1B1F270", Offset="0x1B1F270", VA="0x1B1F270")]
			set
			{
			}
		}

		[Address(RVA="0x1B1F8D4", Offset="0x1B1F8D4", VA="0x1B1F8D4")]
		static ClubWarClub()
		{
		}

		[Address(RVA="0x1B1F154", Offset="0x1B1F154", VA="0x1B1F154")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107D43C", Offset="0x107D43C")]
		public ClubWarClub()
		{
		}

		[Address(RVA="0x1B1F15C", Offset="0x1B1F15C", VA="0x1B1F15C")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107D44C", Offset="0x107D44C")]
		public ClubWarClub(ClubWarClub other)
		{
		}

		[Address(RVA="0x1B1F5C4", Offset="0x1B1F5C4", VA="0x1B1F5C4", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107D4BC", Offset="0x107D4BC")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1B1F1F8", Offset="0x1B1F1F8", VA="0x1B1F1F8", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107D45C", Offset="0x107D45C")]
		public ClubWarClub Clone()
		{
			return null;
		}

		[Address(RVA="0x1B1F278", Offset="0x1B1F278", VA="0x1B1F278", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107D46C", Offset="0x107D46C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1B1F2EC", Offset="0x1B1F2EC", VA="0x1B1F2EC", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107D47C", Offset="0x107D47C")]
		public bool Equals(ClubWarClub other)
		{
			return new bool();
		}

		[Address(RVA="0x1B1F370", Offset="0x1B1F370", VA="0x1B1F370", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107D48C", Offset="0x107D48C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1B1F6D4", Offset="0x1B1F6D4", VA="0x1B1F6D4", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107D4CC", Offset="0x107D4CC")]
		public void MergeFrom(ClubWarClub other)
		{
		}

		[Address(RVA="0x1B1F7A0", Offset="0x1B1F7A0", VA="0x1B1F7A0", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107D4DC", Offset="0x107D4DC")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1B1F40C", Offset="0x1B1F40C", VA="0x1B1F40C", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107D49C", Offset="0x107D49C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1B1F474", Offset="0x1B1F474", VA="0x1B1F474", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107D4AC", Offset="0x107D4AC")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104FA98", Offset="0x104FA98")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static ClubWarClub.<>c <>9;

			[Address(RVA="0x1B1F9AC", Offset="0x1B1F9AC", VA="0x1B1F9AC")]
			static <>c()
			{
			}

			[Address(RVA="0x1B1FA10", Offset="0x1B1FA10", VA="0x1B1FA10")]
			public <>c()
			{
			}

			[Address(RVA="0x1B1FA18", Offset="0x1B1FA18", VA="0x1B1FA18")]
			internal ClubWarClub <.cctor>b__35_0()
			{
				return null;
			}
		}
	}
}