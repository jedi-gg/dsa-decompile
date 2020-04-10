using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class AbilityUpgradeRequest : IMessage<AbilityUpgradeRequest>, IMessage, IEquatable<AbilityUpgradeRequest>, IDeepCloneable<AbilityUpgradeRequest>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<AbilityUpgradeRequest> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int UnitIdFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private ulong unitId_;

		[FieldOffset(Offset="0x0")]
		public const int AbilityFieldNumber = 2;

		[FieldOffset(Offset="0x20")]
		private ulong ability_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1098FC0", Offset="0x1098FC0")]
		public ulong Ability
		{
			[Address(RVA="0x1604C38", Offset="0x1604C38", VA="0x1604C38")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1604C40", Offset="0x1604C40", VA="0x1604C40")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1098F90", Offset="0x1098F90")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x16049F4", Offset="0x16049F4", VA="0x16049F4")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1098F80", Offset="0x1098F80")]
		public static MessageParser<AbilityUpgradeRequest> Parser
		{
			[Address(RVA="0x160498C", Offset="0x160498C", VA="0x160498C")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1098FA0", Offset="0x1098FA0")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1604AE4", Offset="0x1604AE4", VA="0x1604AE4", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1098FB0", Offset="0x1098FB0")]
		public ulong UnitId
		{
			[Address(RVA="0x1604C28", Offset="0x1604C28", VA="0x1604C28")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1604C30", Offset="0x1604C30", VA="0x1604C30")]
			set
			{
			}
		}

		[Address(RVA="0x16050B0", Offset="0x16050B0", VA="0x16050B0")]
		static AbilityUpgradeRequest()
		{
		}

		[Address(RVA="0x1604B40", Offset="0x1604B40", VA="0x1604B40")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108255C", Offset="0x108255C")]
		public AbilityUpgradeRequest()
		{
		}

		[Address(RVA="0x1604B48", Offset="0x1604B48", VA="0x1604B48")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108256C", Offset="0x108256C")]
		public AbilityUpgradeRequest(AbilityUpgradeRequest other)
		{
		}

		[Address(RVA="0x1604EEC", Offset="0x1604EEC", VA="0x1604EEC", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10825DC", Offset="0x10825DC")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1604BC8", Offset="0x1604BC8", VA="0x1604BC8", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108257C", Offset="0x108257C")]
		public AbilityUpgradeRequest Clone()
		{
			return null;
		}

		[Address(RVA="0x1604C48", Offset="0x1604C48", VA="0x1604C48", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108258C", Offset="0x108258C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1604CBC", Offset="0x1604CBC", VA="0x1604CBC", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108259C", Offset="0x108259C")]
		public bool Equals(AbilityUpgradeRequest other)
		{
			return new bool();
		}

		[Address(RVA="0x1604D08", Offset="0x1604D08", VA="0x1604D08", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10825AC", Offset="0x10825AC")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1604FC0", Offset="0x1604FC0", VA="0x1604FC0", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10825EC", Offset="0x10825EC")]
		public void MergeFrom(AbilityUpgradeRequest other)
		{
		}

		[Address(RVA="0x160500C", Offset="0x160500C", VA="0x160500C", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10825FC", Offset="0x10825FC")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1604D8C", Offset="0x1604D8C", VA="0x1604D8C", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10825BC", Offset="0x10825BC")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1604DF4", Offset="0x1604DF4", VA="0x1604DF4", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10825CC", Offset="0x10825CC")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10501F8", Offset="0x10501F8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static AbilityUpgradeRequest.<>c <>9;

			[Address(RVA="0x1605188", Offset="0x1605188", VA="0x1605188")]
			static <>c()
			{
			}

			[Address(RVA="0x16051EC", Offset="0x16051EC", VA="0x16051EC")]
			public <>c()
			{
			}

			[Address(RVA="0x16051F4", Offset="0x16051F4", VA="0x16051F4")]
			internal AbilityUpgradeRequest <.cctor>b__30_0()
			{
				return null;
			}
		}
	}
}