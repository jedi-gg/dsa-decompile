using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class SpellUpgradeRequest : IMessage<SpellUpgradeRequest>, IMessage, IEquatable<SpellUpgradeRequest>, IDeepCloneable<SpellUpgradeRequest>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<SpellUpgradeRequest> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int SpellIdFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private ulong spellId_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1099020", Offset="0x1099020")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1BD88E8", Offset="0x1BD88E8", VA="0x1BD88E8")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1099010", Offset="0x1099010")]
		public static MessageParser<SpellUpgradeRequest> Parser
		{
			[Address(RVA="0x1BD8880", Offset="0x1BD8880", VA="0x1BD8880")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1099030", Offset="0x1099030")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1BD89D8", Offset="0x1BD89D8", VA="0x1BD89D8", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1099040", Offset="0x1099040")]
		public ulong SpellId
		{
			[Address(RVA="0x1BD8B00", Offset="0x1BD8B00", VA="0x1BD8B00")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1BD8B08", Offset="0x1BD8B08", VA="0x1BD8B08")]
			set
			{
			}
		}

		[Address(RVA="0x1BD8E7C", Offset="0x1BD8E7C", VA="0x1BD8E7C")]
		static SpellUpgradeRequest()
		{
		}

		[Address(RVA="0x1BD8A34", Offset="0x1BD8A34", VA="0x1BD8A34")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10826BC", Offset="0x10826BC")]
		public SpellUpgradeRequest()
		{
		}

		[Address(RVA="0x1BD8A3C", Offset="0x1BD8A3C", VA="0x1BD8A3C")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10826CC", Offset="0x10826CC")]
		public SpellUpgradeRequest(SpellUpgradeRequest other)
		{
		}

		[Address(RVA="0x1BD8D30", Offset="0x1BD8D30", VA="0x1BD8D30", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108273C", Offset="0x108273C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1BD8AA0", Offset="0x1BD8AA0", VA="0x1BD8AA0", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10826DC", Offset="0x10826DC")]
		public SpellUpgradeRequest Clone()
		{
			return null;
		}

		[Address(RVA="0x1BD8B10", Offset="0x1BD8B10", VA="0x1BD8B10", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10826EC", Offset="0x10826EC")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1BD8B84", Offset="0x1BD8B84", VA="0x1BD8B84", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10826FC", Offset="0x10826FC")]
		public bool Equals(SpellUpgradeRequest other)
		{
			return new bool();
		}

		[Address(RVA="0x1BD8BC0", Offset="0x1BD8BC0", VA="0x1BD8BC0", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108270C", Offset="0x108270C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1BD8DC0", Offset="0x1BD8DC0", VA="0x1BD8DC0", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108274C", Offset="0x108274C")]
		public void MergeFrom(SpellUpgradeRequest other)
		{
		}

		[Address(RVA="0x1BD8E00", Offset="0x1BD8E00", VA="0x1BD8E00", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108275C", Offset="0x108275C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1BD8C28", Offset="0x1BD8C28", VA="0x1BD8C28", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108271C", Offset="0x108271C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1BD8C90", Offset="0x1BD8C90", VA="0x1BD8C90", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108272C", Offset="0x108272C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1050218", Offset="0x1050218")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static SpellUpgradeRequest.<>c <>9;

			[Address(RVA="0x1BD8F54", Offset="0x1BD8F54", VA="0x1BD8F54")]
			static <>c()
			{
			}

			[Address(RVA="0x1BD8FB8", Offset="0x1BD8FB8", VA="0x1BD8FB8")]
			public <>c()
			{
			}

			[Address(RVA="0x1BD8FC0", Offset="0x1BD8FC0", VA="0x1BD8FC0")]
			internal SpellUpgradeRequest <.cctor>b__25_0()
			{
				return null;
			}
		}
	}
}