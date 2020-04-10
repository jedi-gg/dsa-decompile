using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class InstantBattleEventResponse : IMessage<InstantBattleEventResponse>, IMessage, IEquatable<InstantBattleEventResponse>, IDeepCloneable<InstantBattleEventResponse>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<InstantBattleEventResponse> _parser;

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

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1092DD0", Offset="0x1092DD0")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x18E58B8", Offset="0x18E58B8", VA="0x18E58B8")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1092DF0", Offset="0x1092DF0")]
		public Serverproto.InventoryDelta InventoryDelta
		{
			[Address(RVA="0x18E5A98", Offset="0x18E5A98", VA="0x18E5A98")]
			get
			{
				return null;
			}
			[Address(RVA="0x18E5AA0", Offset="0x18E5AA0", VA="0x18E5AA0")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1092DC0", Offset="0x1092DC0")]
		public static MessageParser<InstantBattleEventResponse> Parser
		{
			[Address(RVA="0x18E5850", Offset="0x18E5850", VA="0x18E5850")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1092DE0", Offset="0x1092DE0")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x18E59A8", Offset="0x18E59A8", VA="0x18E59A8", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1092E00", Offset="0x1092E00")]
		public EventStatus UpdatedStatus
		{
			[Address(RVA="0x18E5AA8", Offset="0x18E5AA8", VA="0x18E5AA8")]
			get
			{
				return null;
			}
			[Address(RVA="0x18E5AB0", Offset="0x18E5AB0", VA="0x18E5AB0")]
			set
			{
			}
		}

		[Address(RVA="0x18E60B4", Offset="0x18E60B4", VA="0x18E60B4")]
		static InstantBattleEventResponse()
		{
		}

		[Address(RVA="0x18E5A04", Offset="0x18E5A04", VA="0x18E5A04")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1077A7C", Offset="0x1077A7C")]
		public InstantBattleEventResponse()
		{
		}

		[Address(RVA="0x18E5A0C", Offset="0x18E5A0C", VA="0x18E5A0C")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1077A8C", Offset="0x1077A8C")]
		public InstantBattleEventResponse(InstantBattleEventResponse other)
		{
		}

		[Address(RVA="0x18E5DD4", Offset="0x18E5DD4", VA="0x18E5DD4", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1077AFC", Offset="0x1077AFC")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x18E5AB8", Offset="0x18E5AB8", VA="0x18E5AB8", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1077A9C", Offset="0x1077A9C")]
		public InstantBattleEventResponse Clone()
		{
			return null;
		}

		[Address(RVA="0x18E5B18", Offset="0x18E5B18", VA="0x18E5B18", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1077AAC", Offset="0x1077AAC")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x18E5B8C", Offset="0x18E5B8C", VA="0x18E5B8C", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1077ABC", Offset="0x1077ABC")]
		public bool Equals(InstantBattleEventResponse other)
		{
			return new bool();
		}

		[Address(RVA="0x18E5C04", Offset="0x18E5C04", VA="0x18E5C04", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1077ACC", Offset="0x1077ACC")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x18E5EA8", Offset="0x18E5EA8", VA="0x18E5EA8", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1077B0C", Offset="0x1077B0C")]
		public void MergeFrom(InstantBattleEventResponse other)
		{
		}

		[Address(RVA="0x18E5FA4", Offset="0x18E5FA4", VA="0x18E5FA4", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1077B1C", Offset="0x1077B1C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x18E5C74", Offset="0x18E5C74", VA="0x18E5C74", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1077ADC", Offset="0x1077ADC")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x18E5CDC", Offset="0x18E5CDC", VA="0x18E5CDC", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1077AEC", Offset="0x1077AEC")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104F228", Offset="0x104F228")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static InstantBattleEventResponse.<>c <>9;

			[Address(RVA="0x18E618C", Offset="0x18E618C", VA="0x18E618C")]
			static <>c()
			{
			}

			[Address(RVA="0x18E61F0", Offset="0x18E61F0", VA="0x18E61F0")]
			public <>c()
			{
			}

			[Address(RVA="0x18E61F8", Offset="0x18E61F8", VA="0x18E61F8")]
			internal InstantBattleEventResponse <.cctor>b__30_0()
			{
				return null;
			}
		}
	}
}