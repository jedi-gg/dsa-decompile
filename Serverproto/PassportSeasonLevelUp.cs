using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class PassportSeasonLevelUp : IMessage<PassportSeasonLevelUp>, IMessage, IEquatable<PassportSeasonLevelUp>, IDeepCloneable<PassportSeasonLevelUp>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<PassportSeasonLevelUp> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int InventoryDeltaFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private Serverproto.InventoryDelta inventoryDelta_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1098A40", Offset="0x1098A40")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1A25B04", Offset="0x1A25B04", VA="0x1A25B04")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1098A60", Offset="0x1098A60")]
		public Serverproto.InventoryDelta InventoryDelta
		{
			[Address(RVA="0x1A25CD4", Offset="0x1A25CD4", VA="0x1A25CD4")]
			get
			{
				return null;
			}
			[Address(RVA="0x1A25CDC", Offset="0x1A25CDC", VA="0x1A25CDC")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1098A30", Offset="0x1098A30")]
		public static MessageParser<PassportSeasonLevelUp> Parser
		{
			[Address(RVA="0x1A25A9C", Offset="0x1A25A9C", VA="0x1A25A9C")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1098A50", Offset="0x1098A50")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1A25BF4", Offset="0x1A25BF4", VA="0x1A25BF4", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1A2619C", Offset="0x1A2619C", VA="0x1A2619C")]
		static PassportSeasonLevelUp()
		{
		}

		[Address(RVA="0x1A25C50", Offset="0x1A25C50", VA="0x1A25C50")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1081C6C", Offset="0x1081C6C")]
		public PassportSeasonLevelUp()
		{
		}

		[Address(RVA="0x1A25C58", Offset="0x1A25C58", VA="0x1A25C58")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1081C7C", Offset="0x1081C7C")]
		public PassportSeasonLevelUp(PassportSeasonLevelUp other)
		{
		}

		[Address(RVA="0x1A25F7C", Offset="0x1A25F7C", VA="0x1A25F7C", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1081CEC", Offset="0x1081CEC")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1A25CE4", Offset="0x1A25CE4", VA="0x1A25CE4", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1081C8C", Offset="0x1081C8C")]
		public PassportSeasonLevelUp Clone()
		{
			return null;
		}

		[Address(RVA="0x1A25D44", Offset="0x1A25D44", VA="0x1A25D44", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1081C9C", Offset="0x1081C9C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1A25DB8", Offset="0x1A25DB8", VA="0x1A25DB8", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1081CAC", Offset="0x1081CAC")]
		public bool Equals(PassportSeasonLevelUp other)
		{
			return new bool();
		}

		[Address(RVA="0x1A25E1C", Offset="0x1A25E1C", VA="0x1A25E1C", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1081CBC", Offset="0x1081CBC")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1A2600C", Offset="0x1A2600C", VA="0x1A2600C", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1081CFC", Offset="0x1081CFC")]
		public void MergeFrom(PassportSeasonLevelUp other)
		{
		}

		[Address(RVA="0x1A260C0", Offset="0x1A260C0", VA="0x1A260C0", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1081D0C", Offset="0x1081D0C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1A25E74", Offset="0x1A25E74", VA="0x1A25E74", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1081CCC", Offset="0x1081CCC")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1A25EDC", Offset="0x1A25EDC", VA="0x1A25EDC", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1081CDC", Offset="0x1081CDC")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1050128", Offset="0x1050128")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static PassportSeasonLevelUp.<>c <>9;

			[Address(RVA="0x1A26274", Offset="0x1A26274", VA="0x1A26274")]
			static <>c()
			{
			}

			[Address(RVA="0x1A262D8", Offset="0x1A262D8", VA="0x1A262D8")]
			public <>c()
			{
			}

			[Address(RVA="0x1A262E0", Offset="0x1A262E0", VA="0x1A262E0")]
			internal PassportSeasonLevelUp <.cctor>b__25_0()
			{
				return null;
			}
		}
	}
}