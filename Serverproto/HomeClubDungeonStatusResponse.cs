using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class HomeClubDungeonStatusResponse : IMessage<HomeClubDungeonStatusResponse>, IMessage, IEquatable<HomeClubDungeonStatusResponse>, IDeepCloneable<HomeClubDungeonStatusResponse>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<HomeClubDungeonStatusResponse> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int IsPlayableFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private bool isPlayable_;

		[FieldOffset(Offset="0x0")]
		public const int IsLeadFieldNumber = 2;

		[FieldOffset(Offset="0x19")]
		private bool isLead_;

		[FieldOffset(Offset="0x0")]
		public const int DungeonIdFieldNumber = 3;

		[FieldOffset(Offset="0x20")]
		private string dungeonId_;

		[FieldOffset(Offset="0x0")]
		public const int EndTimestampFieldNumber = 4;

		[FieldOffset(Offset="0x28")]
		private ulong endTimestamp_;

		[FieldOffset(Offset="0x0")]
		public const int RankFieldNumber = 5;

		[FieldOffset(Offset="0x30")]
		private ulong rank_;

		[FieldOffset(Offset="0x0")]
		public const int CompletedAttemptsTodayFieldNumber = 6;

		[FieldOffset(Offset="0x38")]
		private ulong completedAttemptsToday_;

		[FieldOffset(Offset="0x0")]
		public const int MaxAttemptsTodayFieldNumber = 7;

		[FieldOffset(Offset="0x40")]
		private ulong maxAttemptsToday_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1097BC8", Offset="0x1097BC8")]
		public ulong CompletedAttemptsToday
		{
			[Address(RVA="0x1CFFE74", Offset="0x1CFFE74", VA="0x1CFFE74")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1CFFE7C", Offset="0x1CFFE7C", VA="0x1CFFE7C")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1097B30", Offset="0x1097B30")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1CFFAAC", Offset="0x1CFFAAC", VA="0x1CFFAAC")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1097B98", Offset="0x1097B98")]
		public string DungeonId
		{
			[Address(RVA="0x1CFFDDC", Offset="0x1CFFDDC", VA="0x1CFFDDC")]
			get
			{
				return null;
			}
			[Address(RVA="0x1CFFDE4", Offset="0x1CFFDE4", VA="0x1CFFDE4")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1097BA8", Offset="0x1097BA8")]
		public ulong EndTimestamp
		{
			[Address(RVA="0x1CFFE54", Offset="0x1CFFE54", VA="0x1CFFE54")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1CFFE5C", Offset="0x1CFFE5C", VA="0x1CFFE5C")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1097B60", Offset="0x1097B60")]
		[Attribute(Name="ObsoleteAttribute", RVA="0x1097B60", Offset="0x1097B60")]
		public bool IsLead
		{
			[Address(RVA="0x1CFFDC8", Offset="0x1CFFDC8", VA="0x1CFFDC8")]
			get
			{
				return new bool();
			}
			[Address(RVA="0x1CFFDD0", Offset="0x1CFFDD0", VA="0x1CFFDD0")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1097B50", Offset="0x1097B50")]
		public bool IsPlayable
		{
			[Address(RVA="0x1CFFDB4", Offset="0x1CFFDB4", VA="0x1CFFDB4")]
			get
			{
				return new bool();
			}
			[Address(RVA="0x1CFFDBC", Offset="0x1CFFDBC", VA="0x1CFFDBC")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1097BD8", Offset="0x1097BD8")]
		public ulong MaxAttemptsToday
		{
			[Address(RVA="0x1CFFE84", Offset="0x1CFFE84", VA="0x1CFFE84")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1CFFE8C", Offset="0x1CFFE8C", VA="0x1CFFE8C")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1097B20", Offset="0x1097B20")]
		public static MessageParser<HomeClubDungeonStatusResponse> Parser
		{
			[Address(RVA="0x1CFFA44", Offset="0x1CFFA44", VA="0x1CFFA44")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1097B40", Offset="0x1097B40")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1CFFB98", Offset="0x1CFFB98", VA="0x1CFFB98", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1097BB8", Offset="0x1097BB8")]
		public ulong Rank
		{
			[Address(RVA="0x1CFFE64", Offset="0x1CFFE64", VA="0x1CFFE64")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1CFFE6C", Offset="0x1CFFE6C", VA="0x1CFFE6C")]
			set
			{
			}
		}

		[Address(RVA="0x1D00864", Offset="0x1D00864", VA="0x1D00864")]
		static HomeClubDungeonStatusResponse()
		{
		}

		[Address(RVA="0x1CFFBF4", Offset="0x1CFFBF4", VA="0x1CFFBF4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10805BC", Offset="0x10805BC")]
		public HomeClubDungeonStatusResponse()
		{
		}

		[Address(RVA="0x1CFFC4C", Offset="0x1CFFC4C", VA="0x1CFFC4C")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10805CC", Offset="0x10805CC")]
		public HomeClubDungeonStatusResponse(HomeClubDungeonStatusResponse other)
		{
		}

		[Address(RVA="0x1D00464", Offset="0x1D00464", VA="0x1D00464", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108063C", Offset="0x108063C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1CFFD54", Offset="0x1CFFD54", VA="0x1CFFD54", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10805DC", Offset="0x10805DC")]
		public HomeClubDungeonStatusResponse Clone()
		{
			return null;
		}

		[Address(RVA="0x1CFFE94", Offset="0x1CFFE94", VA="0x1CFFE94", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10805EC", Offset="0x10805EC")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1CFFF08", Offset="0x1CFFF08", VA="0x1CFFF08", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10805FC", Offset="0x10805FC")]
		public bool Equals(HomeClubDungeonStatusResponse other)
		{
			return new bool();
		}

		[Address(RVA="0x1CFFFEC", Offset="0x1CFFFEC", VA="0x1CFFFEC", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108060C", Offset="0x108060C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1D00624", Offset="0x1D00624", VA="0x1D00624", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108064C", Offset="0x108064C")]
		public void MergeFrom(HomeClubDungeonStatusResponse other)
		{
		}

		[Address(RVA="0x1D006D8", Offset="0x1D006D8", VA="0x1D006D8", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108065C", Offset="0x108065C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1D0012C", Offset="0x1D0012C", VA="0x1D0012C", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108061C", Offset="0x108061C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1D00194", Offset="0x1D00194", VA="0x1D00194", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108062C", Offset="0x108062C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104FF18", Offset="0x104FF18")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static HomeClubDungeonStatusResponse.<>c <>9;

			[Address(RVA="0x1D0093C", Offset="0x1D0093C", VA="0x1D0093C")]
			static <>c()
			{
			}

			[Address(RVA="0x1D009A0", Offset="0x1D009A0", VA="0x1D009A0")]
			public <>c()
			{
			}

			[Address(RVA="0x1D009A8", Offset="0x1D009A8", VA="0x1D009A8")]
			internal HomeClubDungeonStatusResponse <.cctor>b__55_0()
			{
				return null;
			}
		}
	}
}