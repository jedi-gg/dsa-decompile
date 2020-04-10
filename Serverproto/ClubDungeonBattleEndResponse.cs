using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class ClubDungeonBattleEndResponse : IMessage<ClubDungeonBattleEndResponse>, IMessage, IEquatable<ClubDungeonBattleEndResponse>, IDeepCloneable<ClubDungeonBattleEndResponse>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<ClubDungeonBattleEndResponse> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int InventoryDeltaFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private Serverproto.InventoryDelta inventoryDelta_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1093200", Offset="0x1093200")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1A4D834", Offset="0x1A4D834", VA="0x1A4D834")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1093220", Offset="0x1093220")]
		public Serverproto.InventoryDelta InventoryDelta
		{
			[Address(RVA="0x1A4DA04", Offset="0x1A4DA04", VA="0x1A4DA04")]
			get
			{
				return null;
			}
			[Address(RVA="0x1A4DA0C", Offset="0x1A4DA0C", VA="0x1A4DA0C")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10931F0", Offset="0x10931F0")]
		public static MessageParser<ClubDungeonBattleEndResponse> Parser
		{
			[Address(RVA="0x1A4D7CC", Offset="0x1A4D7CC", VA="0x1A4D7CC")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1093210", Offset="0x1093210")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1A4D924", Offset="0x1A4D924", VA="0x1A4D924", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1A4DECC", Offset="0x1A4DECC", VA="0x1A4DECC")]
		static ClubDungeonBattleEndResponse()
		{
		}

		[Address(RVA="0x1A4D980", Offset="0x1A4D980", VA="0x1A4D980")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107836C", Offset="0x107836C")]
		public ClubDungeonBattleEndResponse()
		{
		}

		[Address(RVA="0x1A4D988", Offset="0x1A4D988", VA="0x1A4D988")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107837C", Offset="0x107837C")]
		public ClubDungeonBattleEndResponse(ClubDungeonBattleEndResponse other)
		{
		}

		[Address(RVA="0x1A4DCAC", Offset="0x1A4DCAC", VA="0x1A4DCAC", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10783EC", Offset="0x10783EC")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1A4DA14", Offset="0x1A4DA14", VA="0x1A4DA14", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107838C", Offset="0x107838C")]
		public ClubDungeonBattleEndResponse Clone()
		{
			return null;
		}

		[Address(RVA="0x1A4DA74", Offset="0x1A4DA74", VA="0x1A4DA74", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107839C", Offset="0x107839C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1A4DAE8", Offset="0x1A4DAE8", VA="0x1A4DAE8", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10783AC", Offset="0x10783AC")]
		public bool Equals(ClubDungeonBattleEndResponse other)
		{
			return new bool();
		}

		[Address(RVA="0x1A4DB4C", Offset="0x1A4DB4C", VA="0x1A4DB4C", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10783BC", Offset="0x10783BC")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1A4DD3C", Offset="0x1A4DD3C", VA="0x1A4DD3C", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10783FC", Offset="0x10783FC")]
		public void MergeFrom(ClubDungeonBattleEndResponse other)
		{
		}

		[Address(RVA="0x1A4DDF0", Offset="0x1A4DDF0", VA="0x1A4DDF0", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107840C", Offset="0x107840C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1A4DBA4", Offset="0x1A4DBA4", VA="0x1A4DBA4", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10783CC", Offset="0x10783CC")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1A4DC0C", Offset="0x1A4DC0C", VA="0x1A4DC0C", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10783DC", Offset="0x10783DC")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104F2F8", Offset="0x104F2F8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static ClubDungeonBattleEndResponse.<>c <>9;

			[Address(RVA="0x1A4DFA4", Offset="0x1A4DFA4", VA="0x1A4DFA4")]
			static <>c()
			{
			}

			[Address(RVA="0x1A4E008", Offset="0x1A4E008", VA="0x1A4E008")]
			public <>c()
			{
			}

			[Address(RVA="0x1A4E010", Offset="0x1A4E010", VA="0x1A4E010")]
			internal ClubDungeonBattleEndResponse <.cctor>b__25_0()
			{
				return null;
			}
		}
	}
}