using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class EquipSorcererStoneRequest : IMessage<EquipSorcererStoneRequest>, IMessage, IEquatable<EquipSorcererStoneRequest>, IDeepCloneable<EquipSorcererStoneRequest>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<EquipSorcererStoneRequest> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int UnitIdFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private ulong unitId_;

		[FieldOffset(Offset="0x0")]
		public const int SorcererStoneIdFieldNumber = 2;

		[FieldOffset(Offset="0x20")]
		private ulong sorcererStoneId_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10991A0", Offset="0x10991A0")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1FC51B8", Offset="0x1FC51B8", VA="0x1FC51B8")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1099190", Offset="0x1099190")]
		public static MessageParser<EquipSorcererStoneRequest> Parser
		{
			[Address(RVA="0x1FC5150", Offset="0x1FC5150", VA="0x1FC5150")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10991B0", Offset="0x10991B0")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1FC52A8", Offset="0x1FC52A8", VA="0x1FC52A8", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10991D0", Offset="0x10991D0")]
		public ulong SorcererStoneId
		{
			[Address(RVA="0x1FC53FC", Offset="0x1FC53FC", VA="0x1FC53FC")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1FC5404", Offset="0x1FC5404", VA="0x1FC5404")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10991C0", Offset="0x10991C0")]
		public ulong UnitId
		{
			[Address(RVA="0x1FC53EC", Offset="0x1FC53EC", VA="0x1FC53EC")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1FC53F4", Offset="0x1FC53F4", VA="0x1FC53F4")]
			set
			{
			}
		}

		[Address(RVA="0x1FC5874", Offset="0x1FC5874", VA="0x1FC5874")]
		static EquipSorcererStoneRequest()
		{
		}

		[Address(RVA="0x1FC5304", Offset="0x1FC5304", VA="0x1FC5304")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1082ADC", Offset="0x1082ADC")]
		public EquipSorcererStoneRequest()
		{
		}

		[Address(RVA="0x1FC530C", Offset="0x1FC530C", VA="0x1FC530C")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1082AEC", Offset="0x1082AEC")]
		public EquipSorcererStoneRequest(EquipSorcererStoneRequest other)
		{
		}

		[Address(RVA="0x1FC56B0", Offset="0x1FC56B0", VA="0x1FC56B0", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1082B5C", Offset="0x1082B5C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1FC538C", Offset="0x1FC538C", VA="0x1FC538C", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1082AFC", Offset="0x1082AFC")]
		public EquipSorcererStoneRequest Clone()
		{
			return null;
		}

		[Address(RVA="0x1FC540C", Offset="0x1FC540C", VA="0x1FC540C", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1082B0C", Offset="0x1082B0C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1FC5480", Offset="0x1FC5480", VA="0x1FC5480", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1082B1C", Offset="0x1082B1C")]
		public bool Equals(EquipSorcererStoneRequest other)
		{
			return new bool();
		}

		[Address(RVA="0x1FC54CC", Offset="0x1FC54CC", VA="0x1FC54CC", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1082B2C", Offset="0x1082B2C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1FC5784", Offset="0x1FC5784", VA="0x1FC5784", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1082B6C", Offset="0x1082B6C")]
		public void MergeFrom(EquipSorcererStoneRequest other)
		{
		}

		[Address(RVA="0x1FC57D0", Offset="0x1FC57D0", VA="0x1FC57D0", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1082B7C", Offset="0x1082B7C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1FC5550", Offset="0x1FC5550", VA="0x1FC5550", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1082B3C", Offset="0x1082B3C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1FC55B8", Offset="0x1FC55B8", VA="0x1FC55B8", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1082B4C", Offset="0x1082B4C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1050278", Offset="0x1050278")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static EquipSorcererStoneRequest.<>c <>9;

			[Address(RVA="0x1FC594C", Offset="0x1FC594C", VA="0x1FC594C")]
			static <>c()
			{
			}

			[Address(RVA="0x1FC59B0", Offset="0x1FC59B0", VA="0x1FC59B0")]
			public <>c()
			{
			}

			[Address(RVA="0x1FC59B8", Offset="0x1FC59B8", VA="0x1FC59B8")]
			internal EquipSorcererStoneRequest <.cctor>b__30_0()
			{
				return null;
			}
		}
	}
}