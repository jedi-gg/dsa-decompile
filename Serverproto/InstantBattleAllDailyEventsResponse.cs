using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class InstantBattleAllDailyEventsResponse : IMessage<InstantBattleAllDailyEventsResponse>, IMessage, IEquatable<InstantBattleAllDailyEventsResponse>, IDeepCloneable<InstantBattleAllDailyEventsResponse>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<InstantBattleAllDailyEventsResponse> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int InventoryDeltaFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private Serverproto.InventoryDelta inventoryDelta_;

		[FieldOffset(Offset="0x0")]
		public const int UpdatedStatusesFieldNumber = 2;

		[FieldOffset(Offset="0x8")]
		private readonly static FieldCodec<EventStatus> _repeated_updatedStatuses_codec;

		[FieldOffset(Offset="0x20")]
		private readonly RepeatedField<EventStatus> updatedStatuses_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1092E50", Offset="0x1092E50")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x18E435C", Offset="0x18E435C", VA="0x18E435C")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1092E70", Offset="0x1092E70")]
		public Serverproto.InventoryDelta InventoryDelta
		{
			[Address(RVA="0x18E45DC", Offset="0x18E45DC", VA="0x18E45DC")]
			get
			{
				return null;
			}
			[Address(RVA="0x18E45E4", Offset="0x18E45E4", VA="0x18E45E4")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1092E40", Offset="0x1092E40")]
		public static MessageParser<InstantBattleAllDailyEventsResponse> Parser
		{
			[Address(RVA="0x18E42F4", Offset="0x18E42F4", VA="0x18E42F4")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1092E60", Offset="0x1092E60")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x18E444C", Offset="0x18E444C", VA="0x18E444C", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1092E80", Offset="0x1092E80")]
		public RepeatedField<EventStatus> UpdatedStatuses
		{
			[Address(RVA="0x18E464C", Offset="0x18E464C", VA="0x18E464C")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x18E4CA8", Offset="0x18E4CA8", VA="0x18E4CA8")]
		static InstantBattleAllDailyEventsResponse()
		{
		}

		[Address(RVA="0x18E44A8", Offset="0x18E44A8", VA="0x18E44A8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1077BDC", Offset="0x1077BDC")]
		public InstantBattleAllDailyEventsResponse()
		{
		}

		[Address(RVA="0x18E4518", Offset="0x18E4518", VA="0x18E4518")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1077BEC", Offset="0x1077BEC")]
		public InstantBattleAllDailyEventsResponse(InstantBattleAllDailyEventsResponse other)
		{
		}

		[Address(RVA="0x18E4998", Offset="0x18E4998", VA="0x18E4998", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1077C5C", Offset="0x1077C5C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x18E45EC", Offset="0x18E45EC", VA="0x18E45EC", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1077BFC", Offset="0x1077BFC")]
		public InstantBattleAllDailyEventsResponse Clone()
		{
			return null;
		}

		[Address(RVA="0x18E4654", Offset="0x18E4654", VA="0x18E4654", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1077C0C", Offset="0x1077C0C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x18E46C8", Offset="0x18E46C8", VA="0x18E46C8", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1077C1C", Offset="0x1077C1C")]
		public bool Equals(InstantBattleAllDailyEventsResponse other)
		{
			return new bool();
		}

		[Address(RVA="0x18E478C", Offset="0x18E478C", VA="0x18E478C", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1077C2C", Offset="0x1077C2C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x18E4A94", Offset="0x18E4A94", VA="0x18E4A94", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1077C6C", Offset="0x1077C6C")]
		public void MergeFrom(InstantBattleAllDailyEventsResponse other)
		{
		}

		[Address(RVA="0x18E4B6C", Offset="0x18E4B6C", VA="0x18E4B6C", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1077C7C", Offset="0x1077C7C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x18E4814", Offset="0x18E4814", VA="0x18E4814", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1077C3C", Offset="0x1077C3C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x18E487C", Offset="0x18E487C", VA="0x18E487C", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1077C4C", Offset="0x1077C4C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104F248", Offset="0x104F248")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static InstantBattleAllDailyEventsResponse.<>c <>9;

			[Address(RVA="0x18E4DCC", Offset="0x18E4DCC", VA="0x18E4DCC")]
			static <>c()
			{
			}

			[Address(RVA="0x18E4E30", Offset="0x18E4E30", VA="0x18E4E30")]
			public <>c()
			{
			}

			[Address(RVA="0x18E4E38", Offset="0x18E4E38", VA="0x18E4E38")]
			internal InstantBattleAllDailyEventsResponse <.cctor>b__30_0()
			{
				return null;
			}
		}
	}
}