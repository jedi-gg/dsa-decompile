using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class KothBattleResultResponse : IMessage<KothBattleResultResponse>, IMessage, IEquatable<KothBattleResultResponse>, IDeepCloneable<KothBattleResultResponse>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<KothBattleResultResponse> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int NewRankFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private ulong newRank_;

		[FieldOffset(Offset="0x0")]
		public const int InventoryDeltaFieldNumber = 2;

		[FieldOffset(Offset="0x20")]
		private Serverproto.InventoryDelta inventoryDelta_;

		[FieldOffset(Offset="0x0")]
		public const int RankDeltaFieldNumber = 3;

		[FieldOffset(Offset="0x28")]
		private ulong rankDelta_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10933E0", Offset="0x10933E0")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1A9A79C", Offset="0x1A9A79C", VA="0x1A9A79C")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1093410", Offset="0x1093410")]
		public Serverproto.InventoryDelta InventoryDelta
		{
			[Address(RVA="0x1A9A970", Offset="0x1A9A970", VA="0x1A9A970")]
			get
			{
				return null;
			}
			[Address(RVA="0x1A9A978", Offset="0x1A9A978", VA="0x1A9A978")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1093400", Offset="0x1093400")]
		public ulong NewRank
		{
			[Address(RVA="0x1A9A9E0", Offset="0x1A9A9E0", VA="0x1A9A9E0")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1A9A9E8", Offset="0x1A9A9E8", VA="0x1A9A9E8")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10933D0", Offset="0x10933D0")]
		public static MessageParser<KothBattleResultResponse> Parser
		{
			[Address(RVA="0x1A9A734", Offset="0x1A9A734", VA="0x1A9A734")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10933F0", Offset="0x10933F0")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1A9A88C", Offset="0x1A9A88C", VA="0x1A9A88C", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1093420", Offset="0x1093420")]
		public ulong RankDelta
		{
			[Address(RVA="0x1A9A9F0", Offset="0x1A9A9F0", VA="0x1A9A9F0")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1A9A9F8", Offset="0x1A9A9F8", VA="0x1A9A9F8")]
			set
			{
			}
		}

		[Address(RVA="0x1A9B05C", Offset="0x1A9B05C", VA="0x1A9B05C")]
		static KothBattleResultResponse()
		{
		}

		[Address(RVA="0x1A9A8E8", Offset="0x1A9A8E8", VA="0x1A9A8E8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107862C", Offset="0x107862C")]
		public KothBattleResultResponse()
		{
		}

		[Address(RVA="0x1A9A8F0", Offset="0x1A9A8F0", VA="0x1A9A8F0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107863C", Offset="0x107863C")]
		public KothBattleResultResponse(KothBattleResultResponse other)
		{
		}

		[Address(RVA="0x1A9AD4C", Offset="0x1A9AD4C", VA="0x1A9AD4C", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10786AC", Offset="0x10786AC")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1A9A980", Offset="0x1A9A980", VA="0x1A9A980", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107864C", Offset="0x107864C")]
		public KothBattleResultResponse Clone()
		{
			return null;
		}

		[Address(RVA="0x1A9AA00", Offset="0x1A9AA00", VA="0x1A9AA00", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107865C", Offset="0x107865C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1A9AA74", Offset="0x1A9AA74", VA="0x1A9AA74", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107866C", Offset="0x107866C")]
		public bool Equals(KothBattleResultResponse other)
		{
			return new bool();
		}

		[Address(RVA="0x1A9AAF8", Offset="0x1A9AAF8", VA="0x1A9AAF8", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107867C", Offset="0x107867C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1A9AE5C", Offset="0x1A9AE5C", VA="0x1A9AE5C", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10786BC", Offset="0x10786BC")]
		public void MergeFrom(KothBattleResultResponse other)
		{
		}

		[Address(RVA="0x1A9AF28", Offset="0x1A9AF28", VA="0x1A9AF28", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10786CC", Offset="0x10786CC")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1A9AB94", Offset="0x1A9AB94", VA="0x1A9AB94", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107868C", Offset="0x107868C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1A9ABFC", Offset="0x1A9ABFC", VA="0x1A9ABFC", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107869C", Offset="0x107869C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104F338", Offset="0x104F338")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static KothBattleResultResponse.<>c <>9;

			[Address(RVA="0x1A9B134", Offset="0x1A9B134", VA="0x1A9B134")]
			static <>c()
			{
			}

			[Address(RVA="0x1A9B198", Offset="0x1A9B198", VA="0x1A9B198")]
			public <>c()
			{
			}

			[Address(RVA="0x1A9B1A0", Offset="0x1A9B1A0", VA="0x1A9B1A0")]
			internal KothBattleResultResponse <.cctor>b__35_0()
			{
				return null;
			}
		}
	}
}