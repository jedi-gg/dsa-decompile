using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class HomeClubWarResponse : IMessage<HomeClubWarResponse>, IMessage, IEquatable<HomeClubWarResponse>, IDeepCloneable<HomeClubWarResponse>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<HomeClubWarResponse> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int ClubWarIdFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private string clubWarId_;

		[FieldOffset(Offset="0x0")]
		public const int ClubWarDefIdFieldNumber = 2;

		[FieldOffset(Offset="0x20")]
		private ulong clubWarDefId_;

		[FieldOffset(Offset="0x0")]
		public const int CurrentPhaseFieldNumber = 3;

		[FieldOffset(Offset="0x28")]
		private ulong currentPhase_;

		[FieldOffset(Offset="0x0")]
		public const int CurrentPhaseEndTimeFieldNumber = 4;

		[FieldOffset(Offset="0x30")]
		private ulong currentPhaseEndTime_;

		[FieldOffset(Offset="0x0")]
		public const int IsPlayerRegisteredFieldNumber = 5;

		[FieldOffset(Offset="0x38")]
		private bool isPlayerRegistered_;

		[FieldOffset(Offset="0x0")]
		public const int HasUnclaimedRewardFieldNumber = 6;

		[FieldOffset(Offset="0x39")]
		private bool hasUnclaimedReward_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1098100", Offset="0x1098100")]
		public ulong ClubWarDefId
		{
			[Address(RVA="0x1D023C4", Offset="0x1D023C4", VA="0x1D023C4")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1D023CC", Offset="0x1D023CC", VA="0x1D023CC")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10980F0", Offset="0x10980F0")]
		public string ClubWarId
		{
			[Address(RVA="0x1D0234C", Offset="0x1D0234C", VA="0x1D0234C")]
			get
			{
				return null;
			}
			[Address(RVA="0x1D02354", Offset="0x1D02354", VA="0x1D02354")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1098110", Offset="0x1098110")]
		public ulong CurrentPhase
		{
			[Address(RVA="0x1D023D4", Offset="0x1D023D4", VA="0x1D023D4")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1D023DC", Offset="0x1D023DC", VA="0x1D023DC")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1098120", Offset="0x1098120")]
		public ulong CurrentPhaseEndTime
		{
			[Address(RVA="0x1D023E4", Offset="0x1D023E4", VA="0x1D023E4")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1D023EC", Offset="0x1D023EC", VA="0x1D023EC")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10980D0", Offset="0x10980D0")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1D02060", Offset="0x1D02060", VA="0x1D02060")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1098140", Offset="0x1098140")]
		public bool HasUnclaimedReward
		{
			[Address(RVA="0x1D02408", Offset="0x1D02408", VA="0x1D02408")]
			get
			{
				return new bool();
			}
			[Address(RVA="0x1D02410", Offset="0x1D02410", VA="0x1D02410")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1098130", Offset="0x1098130")]
		public bool IsPlayerRegistered
		{
			[Address(RVA="0x1D023F4", Offset="0x1D023F4", VA="0x1D023F4")]
			get
			{
				return new bool();
			}
			[Address(RVA="0x1D023FC", Offset="0x1D023FC", VA="0x1D023FC")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10980C0", Offset="0x10980C0")]
		public static MessageParser<HomeClubWarResponse> Parser
		{
			[Address(RVA="0x1D01FF8", Offset="0x1D01FF8", VA="0x1D01FF8")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10980E0", Offset="0x10980E0")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1D0214C", Offset="0x1D0214C", VA="0x1D0214C", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1D02D00", Offset="0x1D02D00", VA="0x1D02D00")]
		static HomeClubWarResponse()
		{
		}

		[Address(RVA="0x1D021A8", Offset="0x1D021A8", VA="0x1D021A8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108116C", Offset="0x108116C")]
		public HomeClubWarResponse()
		{
		}

		[Address(RVA="0x1D02200", Offset="0x1D02200", VA="0x1D02200")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108117C", Offset="0x108117C")]
		public HomeClubWarResponse(HomeClubWarResponse other)
		{
		}

		[Address(RVA="0x1D0296C", Offset="0x1D0296C", VA="0x1D0296C", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10811EC", Offset="0x10811EC")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1D022EC", Offset="0x1D022EC", VA="0x1D022EC", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108118C", Offset="0x108118C")]
		public HomeClubWarResponse Clone()
		{
			return null;
		}

		[Address(RVA="0x1D0241C", Offset="0x1D0241C", VA="0x1D0241C", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108119C", Offset="0x108119C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1D02490", Offset="0x1D02490", VA="0x1D02490", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10811AC", Offset="0x10811AC")]
		public bool Equals(HomeClubWarResponse other)
		{
			return new bool();
		}

		[Address(RVA="0x1D02564", Offset="0x1D02564", VA="0x1D02564", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10811BC", Offset="0x10811BC")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1D02AFC", Offset="0x1D02AFC", VA="0x1D02AFC", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10811FC", Offset="0x10811FC")]
		public void MergeFrom(HomeClubWarResponse other)
		{
		}

		[Address(RVA="0x1D02BA4", Offset="0x1D02BA4", VA="0x1D02BA4", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108120C", Offset="0x108120C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1D0268C", Offset="0x1D0268C", VA="0x1D0268C", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10811CC", Offset="0x10811CC")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1D026F4", Offset="0x1D026F4", VA="0x1D026F4", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10811DC", Offset="0x10811DC")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1050028", Offset="0x1050028")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static HomeClubWarResponse.<>c <>9;

			[Address(RVA="0x1D02DD8", Offset="0x1D02DD8", VA="0x1D02DD8")]
			static <>c()
			{
			}

			[Address(RVA="0x1D02E3C", Offset="0x1D02E3C", VA="0x1D02E3C")]
			public <>c()
			{
			}

			[Address(RVA="0x1D02E44", Offset="0x1D02E44", VA="0x1D02E44")]
			internal HomeClubWarResponse <.cctor>b__50_0()
			{
				return null;
			}
		}
	}
}