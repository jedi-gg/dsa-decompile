using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class BattleNodeOverrideDescriptor : IMessage<BattleNodeOverrideDescriptor>, IMessage, IEquatable<BattleNodeOverrideDescriptor>, IDeepCloneable<BattleNodeOverrideDescriptor>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<BattleNodeOverrideDescriptor> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int TitleKeyFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private string titleKey_;

		[FieldOffset(Offset="0x0")]
		public const int DescriptionKeyFieldNumber = 2;

		[FieldOffset(Offset="0x20")]
		private string descriptionKey_;

		[FieldOffset(Offset="0x0")]
		public const int DescriptionImageFieldNumber = 3;

		[FieldOffset(Offset="0x28")]
		private string descriptionImage_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1096E50", Offset="0x1096E50")]
		public string DescriptionImage
		{
			[Address(RVA="0x1DBDE8C", Offset="0x1DBDE8C", VA="0x1DBDE8C")]
			get
			{
				return null;
			}
			[Address(RVA="0x1DBDE94", Offset="0x1DBDE94", VA="0x1DBDE94")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1096E40", Offset="0x1096E40")]
		public string DescriptionKey
		{
			[Address(RVA="0x1DBDE14", Offset="0x1DBDE14", VA="0x1DBDE14")]
			get
			{
				return null;
			}
			[Address(RVA="0x1DBDE1C", Offset="0x1DBDE1C", VA="0x1DBDE1C")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1096E10", Offset="0x1096E10")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1DBDAFC", Offset="0x1DBDAFC", VA="0x1DBDAFC")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1096E00", Offset="0x1096E00")]
		public static MessageParser<BattleNodeOverrideDescriptor> Parser
		{
			[Address(RVA="0x1DBDA94", Offset="0x1DBDA94", VA="0x1DBDA94")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1096E20", Offset="0x1096E20")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1DBDBEC", Offset="0x1DBDBEC", VA="0x1DBDBEC", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1096E30", Offset="0x1096E30")]
		public string TitleKey
		{
			[Address(RVA="0x1DBDD9C", Offset="0x1DBDD9C", VA="0x1DBDD9C")]
			get
			{
				return null;
			}
			[Address(RVA="0x1DBDDA4", Offset="0x1DBDDA4", VA="0x1DBDDA4")]
			set
			{
			}
		}

		[Address(RVA="0x1DBE634", Offset="0x1DBE634", VA="0x1DBE634")]
		static BattleNodeOverrideDescriptor()
		{
		}

		[Address(RVA="0x1DBDC48", Offset="0x1DBDC48", VA="0x1DBDC48")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107F53C", Offset="0x107F53C")]
		public BattleNodeOverrideDescriptor()
		{
		}

		[Address(RVA="0x1DBDCA4", Offset="0x1DBDCA4", VA="0x1DBDCA4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107F54C", Offset="0x107F54C")]
		public BattleNodeOverrideDescriptor(BattleNodeOverrideDescriptor other)
		{
		}

		[Address(RVA="0x1DBE318", Offset="0x1DBE318", VA="0x1DBE318", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107F5BC", Offset="0x107F5BC")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1DBDD3C", Offset="0x1DBDD3C", VA="0x1DBDD3C", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107F55C", Offset="0x107F55C")]
		public BattleNodeOverrideDescriptor Clone()
		{
			return null;
		}

		[Address(RVA="0x1DBDF04", Offset="0x1DBDF04", VA="0x1DBDF04", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107F56C", Offset="0x107F56C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1DBDF78", Offset="0x1DBDF78", VA="0x1DBDF78", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107F57C", Offset="0x107F57C")]
		public bool Equals(BattleNodeOverrideDescriptor other)
		{
			return new bool();
		}

		[Address(RVA="0x1DBE004", Offset="0x1DBE004", VA="0x1DBE004", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107F58C", Offset="0x107F58C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1DBE484", Offset="0x1DBE484", VA="0x1DBE484", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107F5CC", Offset="0x107F5CC")]
		public void MergeFrom(BattleNodeOverrideDescriptor other)
		{
		}

		[Address(RVA="0x1DBE548", Offset="0x1DBE548", VA="0x1DBE548", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107F5DC", Offset="0x107F5DC")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1DBE118", Offset="0x1DBE118", VA="0x1DBE118", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107F59C", Offset="0x107F59C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1DBE180", Offset="0x1DBE180", VA="0x1DBE180", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107F5AC", Offset="0x107F5AC")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104FD98", Offset="0x104FD98")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static BattleNodeOverrideDescriptor.<>c <>9;

			[Address(RVA="0x1DBE70C", Offset="0x1DBE70C", VA="0x1DBE70C")]
			static <>c()
			{
			}

			[Address(RVA="0x1DBE770", Offset="0x1DBE770", VA="0x1DBE770")]
			public <>c()
			{
			}

			[Address(RVA="0x1DBE778", Offset="0x1DBE778", VA="0x1DBE778")]
			internal BattleNodeOverrideDescriptor <.cctor>b__35_0()
			{
				return null;
			}
		}
	}
}