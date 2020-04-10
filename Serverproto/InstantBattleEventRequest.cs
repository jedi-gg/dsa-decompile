using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class InstantBattleEventRequest : IMessage<InstantBattleEventRequest>, IMessage, IEquatable<InstantBattleEventRequest>, IDeepCloneable<InstantBattleEventRequest>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<InstantBattleEventRequest> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int EventIdFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private EventIdentifier eventId_;

		[FieldOffset(Offset="0x0")]
		public const int NumBattlesFieldNumber = 2;

		[FieldOffset(Offset="0x20")]
		private ulong numBattles_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1092D80", Offset="0x1092D80")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x18E4EF8", Offset="0x18E4EF8", VA="0x18E4EF8")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1092DA0", Offset="0x1092DA0")]
		public EventIdentifier EventId
		{
			[Address(RVA="0x18E50D0", Offset="0x18E50D0", VA="0x18E50D0")]
			get
			{
				return null;
			}
			[Address(RVA="0x18E50D8", Offset="0x18E50D8", VA="0x18E50D8")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1092DB0", Offset="0x1092DB0")]
		public ulong NumBattles
		{
			[Address(RVA="0x18E5140", Offset="0x18E5140", VA="0x18E5140")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x18E5148", Offset="0x18E5148", VA="0x18E5148")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1092D70", Offset="0x1092D70")]
		public static MessageParser<InstantBattleEventRequest> Parser
		{
			[Address(RVA="0x18E4E90", Offset="0x18E4E90", VA="0x18E4E90")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1092D90", Offset="0x1092D90")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x18E4FE8", Offset="0x18E4FE8", VA="0x18E4FE8", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x18E56B0", Offset="0x18E56B0", VA="0x18E56B0")]
		static InstantBattleEventRequest()
		{
		}

		[Address(RVA="0x18E5044", Offset="0x18E5044", VA="0x18E5044")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10779CC", Offset="0x10779CC")]
		public InstantBattleEventRequest()
		{
		}

		[Address(RVA="0x18E504C", Offset="0x18E504C", VA="0x18E504C")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10779DC", Offset="0x10779DC")]
		public InstantBattleEventRequest(InstantBattleEventRequest other)
		{
		}

		[Address(RVA="0x18E5418", Offset="0x18E5418", VA="0x18E5418", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1077A4C", Offset="0x1077A4C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x18E50E0", Offset="0x18E50E0", VA="0x18E50E0", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10779EC", Offset="0x10779EC")]
		public InstantBattleEventRequest Clone()
		{
			return null;
		}

		[Address(RVA="0x18E5150", Offset="0x18E5150", VA="0x18E5150", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10779FC", Offset="0x10779FC")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x18E51C4", Offset="0x18E51C4", VA="0x18E51C4", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1077A0C", Offset="0x1077A0C")]
		public bool Equals(InstantBattleEventRequest other)
		{
			return new bool();
		}

		[Address(RVA="0x18E5238", Offset="0x18E5238", VA="0x18E5238", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1077A1C", Offset="0x1077A1C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x18E54EC", Offset="0x18E54EC", VA="0x18E54EC", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1077A5C", Offset="0x1077A5C")]
		public void MergeFrom(InstantBattleEventRequest other)
		{
		}

		[Address(RVA="0x18E55AC", Offset="0x18E55AC", VA="0x18E55AC", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1077A6C", Offset="0x1077A6C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x18E52B8", Offset="0x18E52B8", VA="0x18E52B8", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1077A2C", Offset="0x1077A2C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x18E5320", Offset="0x18E5320", VA="0x18E5320", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1077A3C", Offset="0x1077A3C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104F218", Offset="0x104F218")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static InstantBattleEventRequest.<>c <>9;

			[Address(RVA="0x18E5788", Offset="0x18E5788", VA="0x18E5788")]
			static <>c()
			{
			}

			[Address(RVA="0x18E57EC", Offset="0x18E57EC", VA="0x18E57EC")]
			public <>c()
			{
			}

			[Address(RVA="0x18E57F4", Offset="0x18E57F4", VA="0x18E57F4")]
			internal InstantBattleEventRequest <.cctor>b__30_0()
			{
				return null;
			}
		}
	}
}