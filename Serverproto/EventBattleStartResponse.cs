using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class EventBattleStartResponse : IMessage<EventBattleStartResponse>, IMessage, IEquatable<EventBattleStartResponse>, IDeepCloneable<EventBattleStartResponse>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<EventBattleStartResponse> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int BootstrapBytesFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private ByteString bootstrapBytes_;

		[FieldOffset(Offset="0x0")]
		public const int PlayerIdFieldNumber = 2;

		[FieldOffset(Offset="0x20")]
		private ulong playerId_;

		[FieldOffset(Offset="0x0")]
		public const int InventoryDeltaFieldNumber = 3;

		[FieldOffset(Offset="0x28")]
		private Serverproto.InventoryDelta inventoryDelta_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1092C90", Offset="0x1092C90")]
		public ByteString BootstrapBytes
		{
			[Address(RVA="0x1FCCC60", Offset="0x1FCCC60", VA="0x1FCCC60")]
			get
			{
				return null;
			}
			[Address(RVA="0x1FCCC68", Offset="0x1FCCC68", VA="0x1FCCC68")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1092C70", Offset="0x1092C70")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1FCC9A0", Offset="0x1FCC9A0", VA="0x1FCC9A0")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1092CB0", Offset="0x1092CB0")]
		public Serverproto.InventoryDelta InventoryDelta
		{
			[Address(RVA="0x1FCCBF0", Offset="0x1FCCBF0", VA="0x1FCCBF0")]
			get
			{
				return null;
			}
			[Address(RVA="0x1FCCBF8", Offset="0x1FCCBF8", VA="0x1FCCBF8")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1092C60", Offset="0x1092C60")]
		public static MessageParser<EventBattleStartResponse> Parser
		{
			[Address(RVA="0x1FCC938", Offset="0x1FCC938", VA="0x1FCC938")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1092C80", Offset="0x1092C80")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1FCCA90", Offset="0x1FCCA90", VA="0x1FCCA90", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1092CA0", Offset="0x1092CA0")]
		public ulong PlayerId
		{
			[Address(RVA="0x1FCCCD8", Offset="0x1FCCCD8", VA="0x1FCCCD8")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1FCCCE0", Offset="0x1FCCCE0", VA="0x1FCCCE0")]
			set
			{
			}
		}

		[Address(RVA="0x1FCD42C", Offset="0x1FCD42C", VA="0x1FCD42C")]
		static EventBattleStartResponse()
		{
		}

		[Address(RVA="0x1FCCAEC", Offset="0x1FCCAEC", VA="0x1FCCAEC")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10777BC", Offset="0x10777BC")]
		public EventBattleStartResponse()
		{
		}

		[Address(RVA="0x1FCCB60", Offset="0x1FCCB60", VA="0x1FCCB60")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10777CC", Offset="0x10777CC")]
		public EventBattleStartResponse(EventBattleStartResponse other)
		{
		}

		[Address(RVA="0x1FCD0D0", Offset="0x1FCD0D0", VA="0x1FCD0D0", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107783C", Offset="0x107783C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1FCCC00", Offset="0x1FCCC00", VA="0x1FCCC00", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10777DC", Offset="0x10777DC")]
		public EventBattleStartResponse Clone()
		{
			return null;
		}

		[Address(RVA="0x1FCCCE8", Offset="0x1FCCCE8", VA="0x1FCCCE8", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10777EC", Offset="0x10777EC")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1FCCD5C", Offset="0x1FCCD5C", VA="0x1FCCD5C", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10777FC", Offset="0x10777FC")]
		public bool Equals(EventBattleStartResponse other)
		{
			return new bool();
		}

		[Address(RVA="0x1FCCE3C", Offset="0x1FCCE3C", VA="0x1FCCE3C", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107780C", Offset="0x107780C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1FCD204", Offset="0x1FCD204", VA="0x1FCD204", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107784C", Offset="0x107784C")]
		public void MergeFrom(EventBattleStartResponse other)
		{
		}

		[Address(RVA="0x1FCD2F0", Offset="0x1FCD2F0", VA="0x1FCD2F0", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107785C", Offset="0x107785C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1FCCF00", Offset="0x1FCCF00", VA="0x1FCCF00", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107781C", Offset="0x107781C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1FCCF68", Offset="0x1FCCF68", VA="0x1FCCF68", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107782C", Offset="0x107782C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104F1E8", Offset="0x104F1E8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static EventBattleStartResponse.<>c <>9;

			[Address(RVA="0x1FCD504", Offset="0x1FCD504", VA="0x1FCD504")]
			static <>c()
			{
			}

			[Address(RVA="0x1FCD568", Offset="0x1FCD568", VA="0x1FCD568")]
			public <>c()
			{
			}

			[Address(RVA="0x1FCD570", Offset="0x1FCD570", VA="0x1FCD570")]
			internal EventBattleStartResponse <.cctor>b__35_0()
			{
				return null;
			}
		}
	}
}