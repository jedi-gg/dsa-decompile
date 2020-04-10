using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class StoreItemVipData : IMessage<StoreItemVipData>, IMessage, IEquatable<StoreItemVipData>, IDeepCloneable<StoreItemVipData>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<StoreItemVipData> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int InitialRewardFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private ItemCount initialReward_;

		[FieldOffset(Offset="0x0")]
		public const int DailyRewardFieldNumber = 2;

		[FieldOffset(Offset="0x20")]
		private ItemCount dailyReward_;

		[FieldOffset(Offset="0x0")]
		public const int TotalRewardFieldNumber = 3;

		[FieldOffset(Offset="0x28")]
		private ItemCount totalReward_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109C488", Offset="0x109C488")]
		public ItemCount DailyReward
		{
			[Address(RVA="0x1B5FC9C", Offset="0x1B5FC9C", VA="0x1B5FC9C")]
			get
			{
				return null;
			}
			[Address(RVA="0x1B5FCA4", Offset="0x1B5FCA4", VA="0x1B5FCA4")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109C458", Offset="0x109C458")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1B5FA30", Offset="0x1B5FA30", VA="0x1B5FA30")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109C478", Offset="0x109C478")]
		public ItemCount InitialReward
		{
			[Address(RVA="0x1B5FC8C", Offset="0x1B5FC8C", VA="0x1B5FC8C")]
			get
			{
				return null;
			}
			[Address(RVA="0x1B5FC94", Offset="0x1B5FC94", VA="0x1B5FC94")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109C448", Offset="0x109C448")]
		public static MessageParser<StoreItemVipData> Parser
		{
			[Address(RVA="0x1B5F9C8", Offset="0x1B5F9C8", VA="0x1B5F9C8")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109C468", Offset="0x109C468")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1B5FB84", Offset="0x1B5FB84", VA="0x1B5FB84", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109C498", Offset="0x109C498")]
		public ItemCount TotalReward
		{
			[Address(RVA="0x1B5FCAC", Offset="0x1B5FCAC", VA="0x1B5FCAC")]
			get
			{
				return null;
			}
			[Address(RVA="0x1B5FCB4", Offset="0x1B5FCB4", VA="0x1B5FCB4")]
			set
			{
			}
		}

		[Address(RVA="0x1B60414", Offset="0x1B60414", VA="0x1B60414")]
		static StoreItemVipData()
		{
		}

		[Address(RVA="0x1B5FBE0", Offset="0x1B5FBE0", VA="0x1B5FBE0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10883CC", Offset="0x10883CC")]
		public StoreItemVipData()
		{
		}

		[Address(RVA="0x1B5FBE8", Offset="0x1B5FBE8", VA="0x1B5FBE8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10883DC", Offset="0x10883DC")]
		public StoreItemVipData(StoreItemVipData other)
		{
		}

		[Address(RVA="0x1B6005C", Offset="0x1B6005C", VA="0x1B6005C", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108844C", Offset="0x108844C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1B5FCBC", Offset="0x1B5FCBC", VA="0x1B5FCBC", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10883EC", Offset="0x10883EC")]
		public StoreItemVipData Clone()
		{
			return null;
		}

		[Address(RVA="0x1B5FD1C", Offset="0x1B5FD1C", VA="0x1B5FD1C", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10883FC", Offset="0x10883FC")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1B5FD90", Offset="0x1B5FD90", VA="0x1B5FD90", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108840C", Offset="0x108840C")]
		public bool Equals(StoreItemVipData other)
		{
			return new bool();
		}

		[Address(RVA="0x1B5FE1C", Offset="0x1B5FE1C", VA="0x1B5FE1C", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108841C", Offset="0x108841C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1B6016C", Offset="0x1B6016C", VA="0x1B6016C", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108845C", Offset="0x108845C")]
		public void MergeFrom(StoreItemVipData other)
		{
		}

		[Address(RVA="0x1B602C0", Offset="0x1B602C0", VA="0x1B602C0", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108846C", Offset="0x108846C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1B5FEA4", Offset="0x1B5FEA4", VA="0x1B5FEA4", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108842C", Offset="0x108842C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1B5FF0C", Offset="0x1B5FF0C", VA="0x1B5FF0C", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108843C", Offset="0x108843C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1050A98", Offset="0x1050A98")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static StoreItemVipData.<>c <>9;

			[Address(RVA="0x1B604EC", Offset="0x1B604EC", VA="0x1B604EC")]
			static <>c()
			{
			}

			[Address(RVA="0x1B60550", Offset="0x1B60550", VA="0x1B60550")]
			public <>c()
			{
			}

			[Address(RVA="0x1B60558", Offset="0x1B60558", VA="0x1B60558")]
			internal StoreItemVipData <.cctor>b__35_0()
			{
				return null;
			}
		}
	}
}