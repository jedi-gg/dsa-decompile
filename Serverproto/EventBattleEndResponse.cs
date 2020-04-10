using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class EventBattleEndResponse : IMessage<EventBattleEndResponse>, IMessage, IEquatable<EventBattleEndResponse>, IDeepCloneable<EventBattleEndResponse>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<EventBattleEndResponse> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int InventoryDeltaFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private Serverproto.InventoryDelta inventoryDelta_;

		[FieldOffset(Offset="0x0")]
		public const int UpdatedStatusFieldNumber = 2;

		[FieldOffset(Offset="0x20")]
		private EventStatus updatedStatus_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1092D30", Offset="0x1092D30")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1FCAF3C", Offset="0x1FCAF3C", VA="0x1FCAF3C")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1092D50", Offset="0x1092D50")]
		public Serverproto.InventoryDelta InventoryDelta
		{
			[Address(RVA="0x1FCB120", Offset="0x1FCB120", VA="0x1FCB120")]
			get
			{
				return null;
			}
			[Address(RVA="0x1FCB128", Offset="0x1FCB128", VA="0x1FCB128")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1092D20", Offset="0x1092D20")]
		public static MessageParser<EventBattleEndResponse> Parser
		{
			[Address(RVA="0x1FCAED4", Offset="0x1FCAED4", VA="0x1FCAED4")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1092D40", Offset="0x1092D40")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1FCB02C", Offset="0x1FCB02C", VA="0x1FCB02C", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1092D60", Offset="0x1092D60")]
		public EventStatus UpdatedStatus
		{
			[Address(RVA="0x1FCB130", Offset="0x1FCB130", VA="0x1FCB130")]
			get
			{
				return null;
			}
			[Address(RVA="0x1FCB138", Offset="0x1FCB138", VA="0x1FCB138")]
			set
			{
			}
		}

		[Address(RVA="0x1FCB748", Offset="0x1FCB748", VA="0x1FCB748")]
		static EventBattleEndResponse()
		{
		}

		[Address(RVA="0x1FCB088", Offset="0x1FCB088", VA="0x1FCB088")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107791C", Offset="0x107791C")]
		public EventBattleEndResponse()
		{
		}

		[Address(RVA="0x1FCB090", Offset="0x1FCB090", VA="0x1FCB090")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107792C", Offset="0x107792C")]
		public EventBattleEndResponse(EventBattleEndResponse other)
		{
		}

		[Address(RVA="0x1FCB45C", Offset="0x1FCB45C", VA="0x1FCB45C", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107799C", Offset="0x107799C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1FCB140", Offset="0x1FCB140", VA="0x1FCB140", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107793C", Offset="0x107793C")]
		public EventBattleEndResponse Clone()
		{
			return null;
		}

		[Address(RVA="0x1FCB1A0", Offset="0x1FCB1A0", VA="0x1FCB1A0", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107794C", Offset="0x107794C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1FCB214", Offset="0x1FCB214", VA="0x1FCB214", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107795C", Offset="0x107795C")]
		public bool Equals(EventBattleEndResponse other)
		{
			return new bool();
		}

		[Address(RVA="0x1FCB28C", Offset="0x1FCB28C", VA="0x1FCB28C", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107796C", Offset="0x107796C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1FCB530", Offset="0x1FCB530", VA="0x1FCB530", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10779AC", Offset="0x10779AC")]
		public void MergeFrom(EventBattleEndResponse other)
		{
		}

		[Address(RVA="0x1FCB634", Offset="0x1FCB634", VA="0x1FCB634", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10779BC", Offset="0x10779BC")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1FCB2FC", Offset="0x1FCB2FC", VA="0x1FCB2FC", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107797C", Offset="0x107797C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1FCB364", Offset="0x1FCB364", VA="0x1FCB364", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107798C", Offset="0x107798C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104F208", Offset="0x104F208")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static EventBattleEndResponse.<>c <>9;

			[Address(RVA="0x1FCB820", Offset="0x1FCB820", VA="0x1FCB820")]
			static <>c()
			{
			}

			[Address(RVA="0x1FCB884", Offset="0x1FCB884", VA="0x1FCB884")]
			public <>c()
			{
			}

			[Address(RVA="0x1FCB88C", Offset="0x1FCB88C", VA="0x1FCB88C")]
			internal EventBattleEndResponse <.cctor>b__30_0()
			{
				return null;
			}
		}
	}
}