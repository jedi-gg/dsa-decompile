using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class StoreAdRewardResponse : IMessage<StoreAdRewardResponse>, IMessage, IEquatable<StoreAdRewardResponse>, IDeepCloneable<StoreAdRewardResponse>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<StoreAdRewardResponse> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int InventoryDeltaFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private Serverproto.InventoryDelta inventoryDelta_;

		[FieldOffset(Offset="0x0")]
		public const int DailyStoreAdRewardCountFieldNumber = 2;

		[FieldOffset(Offset="0x20")]
		private ulong dailyStoreAdRewardCount_;

		[FieldOffset(Offset="0x0")]
		public const int ValidatedFieldNumber = 3;

		[FieldOffset(Offset="0x28")]
		private bool validated_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109CB38", Offset="0x109CB38")]
		public ulong DailyStoreAdRewardCount
		{
			[Address(RVA="0x1BDA180", Offset="0x1BDA180", VA="0x1BDA180")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1BDA188", Offset="0x1BDA188", VA="0x1BDA188")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109CB08", Offset="0x109CB08")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1BD9F30", Offset="0x1BD9F30", VA="0x1BD9F30")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109CB28", Offset="0x109CB28")]
		public Serverproto.InventoryDelta InventoryDelta
		{
			[Address(RVA="0x1BDA110", Offset="0x1BDA110", VA="0x1BDA110")]
			get
			{
				return null;
			}
			[Address(RVA="0x1BDA118", Offset="0x1BDA118", VA="0x1BDA118")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109CAF8", Offset="0x109CAF8")]
		public static MessageParser<StoreAdRewardResponse> Parser
		{
			[Address(RVA="0x1BD9EC8", Offset="0x1BD9EC8", VA="0x1BD9EC8")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109CB18", Offset="0x109CB18")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1BDA020", Offset="0x1BDA020", VA="0x1BDA020", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109CB48", Offset="0x109CB48")]
		public bool Validated
		{
			[Address(RVA="0x1BDA190", Offset="0x1BDA190", VA="0x1BDA190")]
			get
			{
				return new bool();
			}
			[Address(RVA="0x1BDA198", Offset="0x1BDA198", VA="0x1BDA198")]
			set
			{
			}
		}

		[Address(RVA="0x1BDA7FC", Offset="0x1BDA7FC", VA="0x1BDA7FC")]
		static StoreAdRewardResponse()
		{
		}

		[Address(RVA="0x1BDA07C", Offset="0x1BDA07C", VA="0x1BDA07C")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10890DC", Offset="0x10890DC")]
		public StoreAdRewardResponse()
		{
		}

		[Address(RVA="0x1BDA084", Offset="0x1BDA084", VA="0x1BDA084")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10890EC", Offset="0x10890EC")]
		public StoreAdRewardResponse(StoreAdRewardResponse other)
		{
		}

		[Address(RVA="0x1BDA50C", Offset="0x1BDA50C", VA="0x1BDA50C", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108915C", Offset="0x108915C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1BDA120", Offset="0x1BDA120", VA="0x1BDA120", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10890FC", Offset="0x10890FC")]
		public StoreAdRewardResponse Clone()
		{
			return null;
		}

		[Address(RVA="0x1BDA1A4", Offset="0x1BDA1A4", VA="0x1BDA1A4", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108910C", Offset="0x108910C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1BDA218", Offset="0x1BDA218", VA="0x1BDA218", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108911C", Offset="0x108911C")]
		public bool Equals(StoreAdRewardResponse other)
		{
			return new bool();
		}

		[Address(RVA="0x1BDA2AC", Offset="0x1BDA2AC", VA="0x1BDA2AC", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108912C", Offset="0x108912C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1BDA5F8", Offset="0x1BDA5F8", VA="0x1BDA5F8", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108916C", Offset="0x108916C")]
		public void MergeFrom(StoreAdRewardResponse other)
		{
		}

		[Address(RVA="0x1BDA6C4", Offset="0x1BDA6C4", VA="0x1BDA6C4", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108917C", Offset="0x108917C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1BDA350", Offset="0x1BDA350", VA="0x1BDA350", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108913C", Offset="0x108913C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1BDA3B8", Offset="0x1BDA3B8", VA="0x1BDA3B8", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108914C", Offset="0x108914C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1050BC8", Offset="0x1050BC8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static StoreAdRewardResponse.<>c <>9;

			[Address(RVA="0x1BDA8D4", Offset="0x1BDA8D4", VA="0x1BDA8D4")]
			static <>c()
			{
			}

			[Address(RVA="0x1BDA938", Offset="0x1BDA938", VA="0x1BDA938")]
			public <>c()
			{
			}

			[Address(RVA="0x1BDA940", Offset="0x1BDA940", VA="0x1BDA940")]
			internal StoreAdRewardResponse <.cctor>b__35_0()
			{
				return null;
			}
		}
	}
}