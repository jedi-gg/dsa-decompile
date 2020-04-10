using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class TowerBattleEndResponse : IMessage<TowerBattleEndResponse>, IMessage, IEquatable<TowerBattleEndResponse>, IDeepCloneable<TowerBattleEndResponse>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<TowerBattleEndResponse> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int InventoryDeltaFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private Serverproto.InventoryDelta inventoryDelta_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1093030", Offset="0x1093030")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1B6F360", Offset="0x1B6F360", VA="0x1B6F360")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1093050", Offset="0x1093050")]
		public Serverproto.InventoryDelta InventoryDelta
		{
			[Address(RVA="0x1B6F530", Offset="0x1B6F530", VA="0x1B6F530")]
			get
			{
				return null;
			}
			[Address(RVA="0x1B6F538", Offset="0x1B6F538", VA="0x1B6F538")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1093020", Offset="0x1093020")]
		public static MessageParser<TowerBattleEndResponse> Parser
		{
			[Address(RVA="0x1B6F2F8", Offset="0x1B6F2F8", VA="0x1B6F2F8")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1093040", Offset="0x1093040")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1B6F450", Offset="0x1B6F450", VA="0x1B6F450", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1B6F9F8", Offset="0x1B6F9F8", VA="0x1B6F9F8")]
		static TowerBattleEndResponse()
		{
		}

		[Address(RVA="0x1B6F4AC", Offset="0x1B6F4AC", VA="0x1B6F4AC")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1077F4C", Offset="0x1077F4C")]
		public TowerBattleEndResponse()
		{
		}

		[Address(RVA="0x1B6F4B4", Offset="0x1B6F4B4", VA="0x1B6F4B4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1077F5C", Offset="0x1077F5C")]
		public TowerBattleEndResponse(TowerBattleEndResponse other)
		{
		}

		[Address(RVA="0x1B6F7D8", Offset="0x1B6F7D8", VA="0x1B6F7D8", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1077FCC", Offset="0x1077FCC")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1B6F540", Offset="0x1B6F540", VA="0x1B6F540", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1077F6C", Offset="0x1077F6C")]
		public TowerBattleEndResponse Clone()
		{
			return null;
		}

		[Address(RVA="0x1B6F5A0", Offset="0x1B6F5A0", VA="0x1B6F5A0", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1077F7C", Offset="0x1077F7C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1B6F614", Offset="0x1B6F614", VA="0x1B6F614", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1077F8C", Offset="0x1077F8C")]
		public bool Equals(TowerBattleEndResponse other)
		{
			return new bool();
		}

		[Address(RVA="0x1B6F678", Offset="0x1B6F678", VA="0x1B6F678", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1077F9C", Offset="0x1077F9C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1B6F868", Offset="0x1B6F868", VA="0x1B6F868", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1077FDC", Offset="0x1077FDC")]
		public void MergeFrom(TowerBattleEndResponse other)
		{
		}

		[Address(RVA="0x1B6F91C", Offset="0x1B6F91C", VA="0x1B6F91C", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1077FEC", Offset="0x1077FEC")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1B6F6D0", Offset="0x1B6F6D0", VA="0x1B6F6D0", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1077FAC", Offset="0x1077FAC")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1B6F738", Offset="0x1B6F738", VA="0x1B6F738", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1077FBC", Offset="0x1077FBC")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104F298", Offset="0x104F298")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static TowerBattleEndResponse.<>c <>9;

			[Address(RVA="0x1B6FAD0", Offset="0x1B6FAD0", VA="0x1B6FAD0")]
			static <>c()
			{
			}

			[Address(RVA="0x1B6FB34", Offset="0x1B6FB34", VA="0x1B6FB34")]
			public <>c()
			{
			}

			[Address(RVA="0x1B6FB3C", Offset="0x1B6FB3C", VA="0x1B6FB3C")]
			internal TowerBattleEndResponse <.cctor>b__25_0()
			{
				return null;
			}
		}
	}
}