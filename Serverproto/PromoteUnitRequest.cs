using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class PromoteUnitRequest : IMessage<PromoteUnitRequest>, IMessage, IEquatable<PromoteUnitRequest>, IDeepCloneable<PromoteUnitRequest>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<PromoteUnitRequest> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int UnitIdFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private ulong unitId_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10988E0", Offset="0x10988E0")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x2010994", Offset="0x2010994", VA="0x2010994")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10988D0", Offset="0x10988D0")]
		public static MessageParser<PromoteUnitRequest> Parser
		{
			[Address(RVA="0x201092C", Offset="0x201092C", VA="0x201092C")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10988F0", Offset="0x10988F0")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x2010A84", Offset="0x2010A84", VA="0x2010A84", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1098900", Offset="0x1098900")]
		public ulong UnitId
		{
			[Address(RVA="0x2010BAC", Offset="0x2010BAC", VA="0x2010BAC")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x2010BB4", Offset="0x2010BB4", VA="0x2010BB4")]
			set
			{
			}
		}

		[Address(RVA="0x2010F28", Offset="0x2010F28", VA="0x2010F28")]
		static PromoteUnitRequest()
		{
		}

		[Address(RVA="0x2010AE0", Offset="0x2010AE0", VA="0x2010AE0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10818FC", Offset="0x10818FC")]
		public PromoteUnitRequest()
		{
		}

		[Address(RVA="0x2010AE8", Offset="0x2010AE8", VA="0x2010AE8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108190C", Offset="0x108190C")]
		public PromoteUnitRequest(PromoteUnitRequest other)
		{
		}

		[Address(RVA="0x2010DDC", Offset="0x2010DDC", VA="0x2010DDC", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108197C", Offset="0x108197C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x2010B4C", Offset="0x2010B4C", VA="0x2010B4C", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108191C", Offset="0x108191C")]
		public PromoteUnitRequest Clone()
		{
			return null;
		}

		[Address(RVA="0x2010BBC", Offset="0x2010BBC", VA="0x2010BBC", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108192C", Offset="0x108192C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x2010C30", Offset="0x2010C30", VA="0x2010C30", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108193C", Offset="0x108193C")]
		public bool Equals(PromoteUnitRequest other)
		{
			return new bool();
		}

		[Address(RVA="0x2010C6C", Offset="0x2010C6C", VA="0x2010C6C", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108194C", Offset="0x108194C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x2010E6C", Offset="0x2010E6C", VA="0x2010E6C", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108198C", Offset="0x108198C")]
		public void MergeFrom(PromoteUnitRequest other)
		{
		}

		[Address(RVA="0x2010EAC", Offset="0x2010EAC", VA="0x2010EAC", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108199C", Offset="0x108199C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x2010CD4", Offset="0x2010CD4", VA="0x2010CD4", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108195C", Offset="0x108195C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x2010D3C", Offset="0x2010D3C", VA="0x2010D3C", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108196C", Offset="0x108196C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10500D8", Offset="0x10500D8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static PromoteUnitRequest.<>c <>9;

			[Address(RVA="0x2011000", Offset="0x2011000", VA="0x2011000")]
			static <>c()
			{
			}

			[Address(RVA="0x2011064", Offset="0x2011064", VA="0x2011064")]
			public <>c()
			{
			}

			[Address(RVA="0x201106C", Offset="0x201106C", VA="0x201106C")]
			internal PromoteUnitRequest <.cctor>b__25_0()
			{
				return null;
			}
		}
	}
}