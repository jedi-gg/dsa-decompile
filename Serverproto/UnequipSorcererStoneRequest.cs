using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class UnequipSorcererStoneRequest : IMessage<UnequipSorcererStoneRequest>, IMessage, IEquatable<UnequipSorcererStoneRequest>, IDeepCloneable<UnequipSorcererStoneRequest>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<UnequipSorcererStoneRequest> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int UnitIdFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private ulong unitId_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1099230", Offset="0x1099230")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x14AFC18", Offset="0x14AFC18", VA="0x14AFC18")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1099220", Offset="0x1099220")]
		public static MessageParser<UnequipSorcererStoneRequest> Parser
		{
			[Address(RVA="0x14AFBB0", Offset="0x14AFBB0", VA="0x14AFBB0")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1099240", Offset="0x1099240")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x14AFD08", Offset="0x14AFD08", VA="0x14AFD08", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1099250", Offset="0x1099250")]
		public ulong UnitId
		{
			[Address(RVA="0x14AFE30", Offset="0x14AFE30", VA="0x14AFE30")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x14AFE38", Offset="0x14AFE38", VA="0x14AFE38")]
			set
			{
			}
		}

		[Address(RVA="0x14B01AC", Offset="0x14B01AC", VA="0x14B01AC")]
		static UnequipSorcererStoneRequest()
		{
		}

		[Address(RVA="0x14AFD64", Offset="0x14AFD64", VA="0x14AFD64")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1082C3C", Offset="0x1082C3C")]
		public UnequipSorcererStoneRequest()
		{
		}

		[Address(RVA="0x14AFD6C", Offset="0x14AFD6C", VA="0x14AFD6C")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1082C4C", Offset="0x1082C4C")]
		public UnequipSorcererStoneRequest(UnequipSorcererStoneRequest other)
		{
		}

		[Address(RVA="0x14B0060", Offset="0x14B0060", VA="0x14B0060", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1082CBC", Offset="0x1082CBC")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x14AFDD0", Offset="0x14AFDD0", VA="0x14AFDD0", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1082C5C", Offset="0x1082C5C")]
		public UnequipSorcererStoneRequest Clone()
		{
			return null;
		}

		[Address(RVA="0x14AFE40", Offset="0x14AFE40", VA="0x14AFE40", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1082C6C", Offset="0x1082C6C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x14AFEB4", Offset="0x14AFEB4", VA="0x14AFEB4", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1082C7C", Offset="0x1082C7C")]
		public bool Equals(UnequipSorcererStoneRequest other)
		{
			return new bool();
		}

		[Address(RVA="0x14AFEF0", Offset="0x14AFEF0", VA="0x14AFEF0", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1082C8C", Offset="0x1082C8C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x14B00F0", Offset="0x14B00F0", VA="0x14B00F0", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1082CCC", Offset="0x1082CCC")]
		public void MergeFrom(UnequipSorcererStoneRequest other)
		{
		}

		[Address(RVA="0x14B0130", Offset="0x14B0130", VA="0x14B0130", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1082CDC", Offset="0x1082CDC")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x14AFF58", Offset="0x14AFF58", VA="0x14AFF58", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1082C9C", Offset="0x1082C9C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x14AFFC0", Offset="0x14AFFC0", VA="0x14AFFC0", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1082CAC", Offset="0x1082CAC")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1050298", Offset="0x1050298")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static UnequipSorcererStoneRequest.<>c <>9;

			[Address(RVA="0x14B0284", Offset="0x14B0284", VA="0x14B0284")]
			static <>c()
			{
			}

			[Address(RVA="0x14B02E8", Offset="0x14B02E8", VA="0x14B02E8")]
			public <>c()
			{
			}

			[Address(RVA="0x14B02F0", Offset="0x14B02F0", VA="0x14B02F0")]
			internal UnequipSorcererStoneRequest <.cctor>b__25_0()
			{
				return null;
			}
		}
	}
}