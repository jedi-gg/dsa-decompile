using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class EventStatus : IMessage<EventStatus>, IMessage, IEquatable<EventStatus>, IDeepCloneable<EventStatus>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<EventStatus> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int EventContentIdFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private ulong eventContentId_;

		[FieldOffset(Offset="0x0")]
		public const int BattlesRemainingFieldNumber = 2;

		[FieldOffset(Offset="0x20")]
		private ulong battlesRemaining_;

		[FieldOffset(Offset="0x0")]
		public const int BattleLimitRefreshedCountFieldNumber = 3;

		[FieldOffset(Offset="0x28")]
		private ulong battleLimitRefreshedCount_;

		[FieldOffset(Offset="0x0")]
		public const int NextBattleLimitResetTimestampFieldNumber = 4;

		[FieldOffset(Offset="0x30")]
		private ulong nextBattleLimitResetTimestamp_;

		[FieldOffset(Offset="0x0")]
		public const int NextBattleCooldownTimestampFieldNumber = 5;

		[FieldOffset(Offset="0x38")]
		private ulong nextBattleCooldownTimestamp_;

		[FieldOffset(Offset="0x0")]
		public const int PersistentRewardsFieldNumber = 6;

		[FieldOffset(Offset="0x8")]
		private readonly static FieldCodec<Serverproto.PersistentRewards> _repeated_persistentRewards_codec;

		[FieldOffset(Offset="0x40")]
		private readonly RepeatedField<Serverproto.PersistentRewards> persistentRewards_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10972C8", Offset="0x10972C8")]
		public ulong BattleLimitRefreshedCount
		{
			[Address(RVA="0x1B98734", Offset="0x1B98734", VA="0x1B98734")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1B9873C", Offset="0x1B9873C", VA="0x1B9873C")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10972B8", Offset="0x10972B8")]
		public ulong BattlesRemaining
		{
			[Address(RVA="0x1B98724", Offset="0x1B98724", VA="0x1B98724")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1B9872C", Offset="0x1B9872C", VA="0x1B9872C")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1097288", Offset="0x1097288")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1B983D0", Offset="0x1B983D0", VA="0x1B983D0")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10972A8", Offset="0x10972A8")]
		public ulong EventContentId
		{
			[Address(RVA="0x1B98714", Offset="0x1B98714", VA="0x1B98714")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1B9871C", Offset="0x1B9871C", VA="0x1B9871C")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10972E8", Offset="0x10972E8")]
		public ulong NextBattleCooldownTimestamp
		{
			[Address(RVA="0x1B98754", Offset="0x1B98754", VA="0x1B98754")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1B9875C", Offset="0x1B9875C", VA="0x1B9875C")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10972D8", Offset="0x10972D8")]
		public ulong NextBattleLimitResetTimestamp
		{
			[Address(RVA="0x1B98744", Offset="0x1B98744", VA="0x1B98744")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1B9874C", Offset="0x1B9874C", VA="0x1B9874C")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1097278", Offset="0x1097278")]
		public static MessageParser<EventStatus> Parser
		{
			[Address(RVA="0x1B98368", Offset="0x1B98368", VA="0x1B98368")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1097298", Offset="0x1097298")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1B984C0", Offset="0x1B984C0", VA="0x1B984C0", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10972F8", Offset="0x10972F8")]
		public RepeatedField<Serverproto.PersistentRewards> PersistentRewards
		{
			[Address(RVA="0x1B98764", Offset="0x1B98764", VA="0x1B98764")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1B99130", Offset="0x1B99130", VA="0x1B99130")]
		static EventStatus()
		{
		}

		[Address(RVA="0x1B9851C", Offset="0x1B9851C", VA="0x1B9851C")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107F8AC", Offset="0x107F8AC")]
		public EventStatus()
		{
		}

		[Address(RVA="0x1B9858C", Offset="0x1B9858C", VA="0x1B9858C")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107F8BC", Offset="0x107F8BC")]
		public EventStatus(EventStatus other)
		{
		}

		[Address(RVA="0x1B98CC4", Offset="0x1B98CC4", VA="0x1B98CC4", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107F92C", Offset="0x107F92C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1B986B4", Offset="0x1B986B4", VA="0x1B986B4", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107F8CC", Offset="0x107F8CC")]
		public EventStatus Clone()
		{
			return null;
		}

		[Address(RVA="0x1B9876C", Offset="0x1B9876C", VA="0x1B9876C", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107F8DC", Offset="0x107F8DC")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1B987E0", Offset="0x1B987E0", VA="0x1B987E0", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107F8EC", Offset="0x107F8EC")]
		public bool Equals(EventStatus other)
		{
			return new bool();
		}

		[Address(RVA="0x1B988E0", Offset="0x1B988E0", VA="0x1B988E0", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107F8FC", Offset="0x107F8FC")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1B98EB0", Offset="0x1B98EB0", VA="0x1B98EB0", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107F93C", Offset="0x107F93C")]
		public void MergeFrom(EventStatus other)
		{
		}

		[Address(RVA="0x1B98F7C", Offset="0x1B98F7C", VA="0x1B98F7C", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107F94C", Offset="0x107F94C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1B989E0", Offset="0x1B989E0", VA="0x1B989E0", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107F90C", Offset="0x107F90C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1B98A48", Offset="0x1B98A48", VA="0x1B98A48", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107F91C", Offset="0x107F91C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104FDE8", Offset="0x104FDE8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static EventStatus.<>c <>9;

			[Address(RVA="0x1B99254", Offset="0x1B99254", VA="0x1B99254")]
			static <>c()
			{
			}

			[Address(RVA="0x1B992B8", Offset="0x1B992B8", VA="0x1B992B8")]
			public <>c()
			{
			}

			[Address(RVA="0x1B992C0", Offset="0x1B992C0", VA="0x1B992C0")]
			internal EventStatus <.cctor>b__50_0()
			{
				return null;
			}
		}
	}
}