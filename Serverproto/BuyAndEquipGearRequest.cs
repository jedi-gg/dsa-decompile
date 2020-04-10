using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class BuyAndEquipGearRequest : IMessage<BuyAndEquipGearRequest>, IMessage, IEquatable<BuyAndEquipGearRequest>, IDeepCloneable<BuyAndEquipGearRequest>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<BuyAndEquipGearRequest> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int UnitIdFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private ulong unitId_;

		[FieldOffset(Offset="0x0")]
		public const int SlotFieldNumber = 2;

		[FieldOffset(Offset="0x20")]
		private ulong slot_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1099340", Offset="0x1099340")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1F82E0C", Offset="0x1F82E0C", VA="0x1F82E0C")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1099330", Offset="0x1099330")]
		public static MessageParser<BuyAndEquipGearRequest> Parser
		{
			[Address(RVA="0x1F82DA4", Offset="0x1F82DA4", VA="0x1F82DA4")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1099350", Offset="0x1099350")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1F82EFC", Offset="0x1F82EFC", VA="0x1F82EFC", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1099370", Offset="0x1099370")]
		public ulong Slot
		{
			[Address(RVA="0x1F83050", Offset="0x1F83050", VA="0x1F83050")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1F83058", Offset="0x1F83058", VA="0x1F83058")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1099360", Offset="0x1099360")]
		public ulong UnitId
		{
			[Address(RVA="0x1F83040", Offset="0x1F83040", VA="0x1F83040")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1F83048", Offset="0x1F83048", VA="0x1F83048")]
			set
			{
			}
		}

		[Address(RVA="0x1F834C8", Offset="0x1F834C8", VA="0x1F834C8")]
		static BuyAndEquipGearRequest()
		{
		}

		[Address(RVA="0x1F82F58", Offset="0x1F82F58", VA="0x1F82F58")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1082EFC", Offset="0x1082EFC")]
		public BuyAndEquipGearRequest()
		{
		}

		[Address(RVA="0x1F82F60", Offset="0x1F82F60", VA="0x1F82F60")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1082F0C", Offset="0x1082F0C")]
		public BuyAndEquipGearRequest(BuyAndEquipGearRequest other)
		{
		}

		[Address(RVA="0x1F83304", Offset="0x1F83304", VA="0x1F83304", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1082F7C", Offset="0x1082F7C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1F82FE0", Offset="0x1F82FE0", VA="0x1F82FE0", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1082F1C", Offset="0x1082F1C")]
		public BuyAndEquipGearRequest Clone()
		{
			return null;
		}

		[Address(RVA="0x1F83060", Offset="0x1F83060", VA="0x1F83060", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1082F2C", Offset="0x1082F2C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1F830D4", Offset="0x1F830D4", VA="0x1F830D4", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1082F3C", Offset="0x1082F3C")]
		public bool Equals(BuyAndEquipGearRequest other)
		{
			return new bool();
		}

		[Address(RVA="0x1F83120", Offset="0x1F83120", VA="0x1F83120", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1082F4C", Offset="0x1082F4C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1F833D8", Offset="0x1F833D8", VA="0x1F833D8", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1082F8C", Offset="0x1082F8C")]
		public void MergeFrom(BuyAndEquipGearRequest other)
		{
		}

		[Address(RVA="0x1F83424", Offset="0x1F83424", VA="0x1F83424", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1082F9C", Offset="0x1082F9C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1F831A4", Offset="0x1F831A4", VA="0x1F831A4", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1082F5C", Offset="0x1082F5C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1F8320C", Offset="0x1F8320C", VA="0x1F8320C", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1082F6C", Offset="0x1082F6C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10502D8", Offset="0x10502D8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static BuyAndEquipGearRequest.<>c <>9;

			[Address(RVA="0x1F835A0", Offset="0x1F835A0", VA="0x1F835A0")]
			static <>c()
			{
			}

			[Address(RVA="0x1F83604", Offset="0x1F83604", VA="0x1F83604")]
			public <>c()
			{
			}

			[Address(RVA="0x1F8360C", Offset="0x1F8360C", VA="0x1F8360C")]
			internal BuyAndEquipGearRequest <.cctor>b__30_0()
			{
				return null;
			}
		}
	}
}