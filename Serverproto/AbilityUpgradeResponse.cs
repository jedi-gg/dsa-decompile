using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class AbilityUpgradeResponse : IMessage<AbilityUpgradeResponse>, IMessage, IEquatable<AbilityUpgradeResponse>, IDeepCloneable<AbilityUpgradeResponse>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<AbilityUpgradeResponse> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int InventoryDeltaFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private Serverproto.InventoryDelta inventoryDelta_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1098FE0", Offset="0x1098FE0")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x16052B8", Offset="0x16052B8", VA="0x16052B8")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1099000", Offset="0x1099000")]
		public Serverproto.InventoryDelta InventoryDelta
		{
			[Address(RVA="0x1605488", Offset="0x1605488", VA="0x1605488")]
			get
			{
				return null;
			}
			[Address(RVA="0x1605490", Offset="0x1605490", VA="0x1605490")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1098FD0", Offset="0x1098FD0")]
		public static MessageParser<AbilityUpgradeResponse> Parser
		{
			[Address(RVA="0x1605250", Offset="0x1605250", VA="0x1605250")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1098FF0", Offset="0x1098FF0")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x16053A8", Offset="0x16053A8", VA="0x16053A8", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1605950", Offset="0x1605950", VA="0x1605950")]
		static AbilityUpgradeResponse()
		{
		}

		[Address(RVA="0x1605404", Offset="0x1605404", VA="0x1605404")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108260C", Offset="0x108260C")]
		public AbilityUpgradeResponse()
		{
		}

		[Address(RVA="0x160540C", Offset="0x160540C", VA="0x160540C")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108261C", Offset="0x108261C")]
		public AbilityUpgradeResponse(AbilityUpgradeResponse other)
		{
		}

		[Address(RVA="0x1605730", Offset="0x1605730", VA="0x1605730", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108268C", Offset="0x108268C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1605498", Offset="0x1605498", VA="0x1605498", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108262C", Offset="0x108262C")]
		public AbilityUpgradeResponse Clone()
		{
			return null;
		}

		[Address(RVA="0x16054F8", Offset="0x16054F8", VA="0x16054F8", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108263C", Offset="0x108263C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x160556C", Offset="0x160556C", VA="0x160556C", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108264C", Offset="0x108264C")]
		public bool Equals(AbilityUpgradeResponse other)
		{
			return new bool();
		}

		[Address(RVA="0x16055D0", Offset="0x16055D0", VA="0x16055D0", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108265C", Offset="0x108265C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x16057C0", Offset="0x16057C0", VA="0x16057C0", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108269C", Offset="0x108269C")]
		public void MergeFrom(AbilityUpgradeResponse other)
		{
		}

		[Address(RVA="0x1605874", Offset="0x1605874", VA="0x1605874", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10826AC", Offset="0x10826AC")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1605628", Offset="0x1605628", VA="0x1605628", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108266C", Offset="0x108266C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1605690", Offset="0x1605690", VA="0x1605690", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108267C", Offset="0x108267C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1050208", Offset="0x1050208")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static AbilityUpgradeResponse.<>c <>9;

			[Address(RVA="0x1605A28", Offset="0x1605A28", VA="0x1605A28")]
			static <>c()
			{
			}

			[Address(RVA="0x1605A8C", Offset="0x1605A8C", VA="0x1605A8C")]
			public <>c()
			{
			}

			[Address(RVA="0x1605A94", Offset="0x1605A94", VA="0x1605A94")]
			internal AbilityUpgradeResponse <.cctor>b__25_0()
			{
				return null;
			}
		}
	}
}