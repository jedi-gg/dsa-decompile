using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class PvpScore : IMessage<PvpScore>, IMessage, IEquatable<PvpScore>, IDeepCloneable<PvpScore>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<PvpScore> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int CurrentSeasonIdFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private ulong currentSeasonId_;

		[FieldOffset(Offset="0x0")]
		public const int CurrentSeasonScoreFieldNumber = 2;

		[FieldOffset(Offset="0x20")]
		private ulong currentSeasonScore_;

		[FieldOffset(Offset="0x0")]
		public const int PrevSeasonIdFieldNumber = 3;

		[FieldOffset(Offset="0x28")]
		private ulong prevSeasonId_;

		[FieldOffset(Offset="0x0")]
		public const int PrevSeasonScoreFieldNumber = 4;

		[FieldOffset(Offset="0x30")]
		private ulong prevSeasonScore_;

		[FieldOffset(Offset="0x0")]
		public const int LifetimeScoreFieldNumber = 5;

		[FieldOffset(Offset="0x38")]
		private ulong lifetimeScore_;

		[FieldOffset(Offset="0x0")]
		public const int DailyBattleCountFieldNumber = 6;

		[FieldOffset(Offset="0x40")]
		private ulong dailyBattleCount_;

		[FieldOffset(Offset="0x0")]
		public const int DailyBattleResetTimeFieldNumber = 7;

		[FieldOffset(Offset="0x48")]
		private ulong dailyBattleResetTime_;

		[FieldOffset(Offset="0x0")]
		public const int CurrentSeasonHighScoreFieldNumber = 8;

		[FieldOffset(Offset="0x50")]
		private ulong currentSeasonHighScore_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1099EE0", Offset="0x1099EE0")]
		public ulong CurrentSeasonHighScore
		{
			[Address(RVA="0x201BFC0", Offset="0x201BFC0", VA="0x201BFC0")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x201BFC8", Offset="0x201BFC8", VA="0x201BFC8")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1099E70", Offset="0x1099E70")]
		public ulong CurrentSeasonId
		{
			[Address(RVA="0x201BF50", Offset="0x201BF50", VA="0x201BF50")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x201BF58", Offset="0x201BF58", VA="0x201BF58")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1099E80", Offset="0x1099E80")]
		public ulong CurrentSeasonScore
		{
			[Address(RVA="0x201BF60", Offset="0x201BF60", VA="0x201BF60")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x201BF68", Offset="0x201BF68", VA="0x201BF68")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1099EC0", Offset="0x1099EC0")]
		public ulong DailyBattleCount
		{
			[Address(RVA="0x201BFA0", Offset="0x201BFA0", VA="0x201BFA0")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x201BFA8", Offset="0x201BFA8", VA="0x201BFA8")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1099ED0", Offset="0x1099ED0")]
		public ulong DailyBattleResetTime
		{
			[Address(RVA="0x201BFB0", Offset="0x201BFB0", VA="0x201BFB0")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x201BFB8", Offset="0x201BFB8", VA="0x201BFB8")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1099E50", Offset="0x1099E50")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x201BC74", Offset="0x201BC74", VA="0x201BC74")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1099EB0", Offset="0x1099EB0")]
		public ulong LifetimeScore
		{
			[Address(RVA="0x201BF90", Offset="0x201BF90", VA="0x201BF90")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x201BF98", Offset="0x201BF98", VA="0x201BF98")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1099E40", Offset="0x1099E40")]
		public static MessageParser<PvpScore> Parser
		{
			[Address(RVA="0x201BC0C", Offset="0x201BC0C", VA="0x201BC0C")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1099E60", Offset="0x1099E60")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x201BD64", Offset="0x201BD64", VA="0x201BD64", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1099E90", Offset="0x1099E90")]
		public ulong PrevSeasonId
		{
			[Address(RVA="0x201BF70", Offset="0x201BF70", VA="0x201BF70")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x201BF78", Offset="0x201BF78", VA="0x201BF78")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1099EA0", Offset="0x1099EA0")]
		public ulong PrevSeasonScore
		{
			[Address(RVA="0x201BF80", Offset="0x201BF80", VA="0x201BF80")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x201BF88", Offset="0x201BF88", VA="0x201BF88")]
			set
			{
			}
		}

		[Address(RVA="0x201CA08", Offset="0x201CA08", VA="0x201CA08")]
		static PvpScore()
		{
		}

		[Address(RVA="0x201BDC0", Offset="0x201BDC0", VA="0x201BDC0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1083A3C", Offset="0x1083A3C")]
		public PvpScore()
		{
		}

		[Address(RVA="0x201BDC8", Offset="0x201BDC8", VA="0x201BDC8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1083A4C", Offset="0x1083A4C")]
		public PvpScore(PvpScore other)
		{
		}

		[Address(RVA="0x201C58C", Offset="0x201C58C", VA="0x201C58C", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1083ABC", Offset="0x1083ABC")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x201BEF0", Offset="0x201BEF0", VA="0x201BEF0", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1083A5C", Offset="0x1083A5C")]
		public PvpScore Clone()
		{
			return null;
		}

		[Address(RVA="0x201BFD0", Offset="0x201BFD0", VA="0x201BFD0", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1083A6C", Offset="0x1083A6C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x201C044", Offset="0x201C044", VA="0x201C044", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1083A7C", Offset="0x1083A7C")]
		public bool Equals(PvpScore other)
		{
			return new bool();
		}

		[Address(RVA="0x201C0F0", Offset="0x201C0F0", VA="0x201C0F0", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1083A8C", Offset="0x1083A8C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x201C7C8", Offset="0x201C7C8", VA="0x201C7C8", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1083ACC", Offset="0x1083ACC")]
		public void MergeFrom(PvpScore other)
		{
		}

		[Address(RVA="0x201C85C", Offset="0x201C85C", VA="0x201C85C", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1083ADC", Offset="0x1083ADC")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x201C21C", Offset="0x201C21C", VA="0x201C21C", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1083A9C", Offset="0x1083A9C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x201C284", Offset="0x201C284", VA="0x201C284", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1083AAC", Offset="0x1083AAC")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10503D8", Offset="0x10503D8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static PvpScore.<>c <>9;

			[Address(RVA="0x201CAE0", Offset="0x201CAE0", VA="0x201CAE0")]
			static <>c()
			{
			}

			[Address(RVA="0x201CB44", Offset="0x201CB44", VA="0x201CB44")]
			public <>c()
			{
			}

			[Address(RVA="0x201CB4C", Offset="0x201CB4C", VA="0x201CB4C")]
			internal PvpScore <.cctor>b__60_0()
			{
				return null;
			}
		}
	}
}