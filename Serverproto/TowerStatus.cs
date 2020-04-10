using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class TowerStatus : IMessage<TowerStatus>, IMessage, IEquatable<TowerStatus>, IDeepCloneable<TowerStatus>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<TowerStatus> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int RefreshTimestampFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private ulong refreshTimestamp_;

		[FieldOffset(Offset="0x0")]
		public const int CurrentNodeFieldNumber = 2;

		[FieldOffset(Offset="0x20")]
		private ulong currentNode_;

		[FieldOffset(Offset="0x0")]
		public const int UnitStatesFieldNumber = 3;

		[FieldOffset(Offset="0x8")]
		private readonly static FieldCodec<UnitBattleState> _repeated_unitStates_codec;

		[FieldOffset(Offset="0x28")]
		private readonly RepeatedField<UnitBattleState> unitStates_;

		[FieldOffset(Offset="0x0")]
		public const int IdFieldNumber = 4;

		[FieldOffset(Offset="0x30")]
		private TowerIdentifier id_;

		[FieldOffset(Offset="0x0")]
		public const int TimesCompletedFieldNumber = 5;

		[FieldOffset(Offset="0x38")]
		private ulong timesCompleted_;

		[FieldOffset(Offset="0x0")]
		public const int ClaimedProgressionLootFieldNumber = 6;

		[FieldOffset(Offset="0x40")]
		private bool claimedProgressionLoot_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109CE58", Offset="0x109CE58")]
		public bool ClaimedProgressionLoot
		{
			[Address(RVA="0x1B777F4", Offset="0x1B777F4", VA="0x1B777F4")]
			get
			{
				return new bool();
			}
			[Address(RVA="0x1B777FC", Offset="0x1B777FC", VA="0x1B777FC")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109CE18", Offset="0x109CE18")]
		public ulong CurrentNode
		{
			[Address(RVA="0x1B777CC", Offset="0x1B777CC", VA="0x1B777CC")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1B777D4", Offset="0x1B777D4", VA="0x1B777D4")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109CDE8", Offset="0x109CDE8")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1B774A0", Offset="0x1B774A0", VA="0x1B774A0")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109CE38", Offset="0x109CE38")]
		public TowerIdentifier Id
		{
			[Address(RVA="0x1B7774C", Offset="0x1B7774C", VA="0x1B7774C")]
			get
			{
				return null;
			}
			[Address(RVA="0x1B77754", Offset="0x1B77754", VA="0x1B77754")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109CDD8", Offset="0x109CDD8")]
		public static MessageParser<TowerStatus> Parser
		{
			[Address(RVA="0x1B76114", Offset="0x1B76114", VA="0x1B76114")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109CDF8", Offset="0x109CDF8")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1B7758C", Offset="0x1B7758C", VA="0x1B7758C", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109CE08", Offset="0x109CE08")]
		public ulong RefreshTimestamp
		{
			[Address(RVA="0x1B777BC", Offset="0x1B777BC", VA="0x1B777BC")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1B777C4", Offset="0x1B777C4", VA="0x1B777C4")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109CE48", Offset="0x109CE48")]
		public ulong TimesCompleted
		{
			[Address(RVA="0x1B777E4", Offset="0x1B777E4", VA="0x1B777E4")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1B777EC", Offset="0x1B777EC", VA="0x1B777EC")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109CE28", Offset="0x109CE28")]
		public RepeatedField<UnitBattleState> UnitStates
		{
			[Address(RVA="0x1B777DC", Offset="0x1B777DC", VA="0x1B777DC")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1B78234", Offset="0x1B78234", VA="0x1B78234")]
		static TowerStatus()
		{
		}

		[Address(RVA="0x1B775E8", Offset="0x1B775E8", VA="0x1B775E8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108965C", Offset="0x108965C")]
		public TowerStatus()
		{
		}

		[Address(RVA="0x1B77658", Offset="0x1B77658", VA="0x1B77658")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108966C", Offset="0x108966C")]
		public TowerStatus(TowerStatus other)
		{
		}

		[Address(RVA="0x1B77D80", Offset="0x1B77D80", VA="0x1B77D80", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10896DC", Offset="0x10896DC")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1B7775C", Offset="0x1B7775C", VA="0x1B7775C", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108967C", Offset="0x108967C")]
		public TowerStatus Clone()
		{
			return null;
		}

		[Address(RVA="0x1B77808", Offset="0x1B77808", VA="0x1B77808", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108968C", Offset="0x108968C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1B7787C", Offset="0x1B7787C", VA="0x1B7787C", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108969C", Offset="0x108969C")]
		public bool Equals(TowerStatus other)
		{
			return new bool();
		}

		[Address(RVA="0x1B77990", Offset="0x1B77990", VA="0x1B77990", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10896AC", Offset="0x10896AC")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1B77F3C", Offset="0x1B77F3C", VA="0x1B77F3C", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10896EC", Offset="0x10896EC")]
		public void MergeFrom(TowerStatus other)
		{
		}

		[Address(RVA="0x1B78048", Offset="0x1B78048", VA="0x1B78048", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10896FC", Offset="0x10896FC")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1B77A98", Offset="0x1B77A98", VA="0x1B77A98", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10896BC", Offset="0x10896BC")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1B77B00", Offset="0x1B77B00", VA="0x1B77B00", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10896CC", Offset="0x10896CC")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1050C48", Offset="0x1050C48")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static TowerStatus.<>c <>9;

			[Address(RVA="0x1B78358", Offset="0x1B78358", VA="0x1B78358")]
			static <>c()
			{
			}

			[Address(RVA="0x1B783BC", Offset="0x1B783BC", VA="0x1B783BC")]
			public <>c()
			{
			}

			[Address(RVA="0x1B783C4", Offset="0x1B783C4", VA="0x1B783C4")]
			internal TowerStatus <.cctor>b__50_0()
			{
				return null;
			}
		}
	}
}