using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class KothBattleHistoryResponse : IMessage<KothBattleHistoryResponse>, IMessage, IEquatable<KothBattleHistoryResponse>, IDeepCloneable<KothBattleHistoryResponse>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<KothBattleHistoryResponse> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int DefenseHistoryFieldNumber = 1;

		[FieldOffset(Offset="0x8")]
		private readonly static FieldCodec<KothBattleHistory> _repeated_defenseHistory_codec;

		[FieldOffset(Offset="0x18")]
		private readonly RepeatedField<KothBattleHistory> defenseHistory_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109B710", Offset="0x109B710")]
		public RepeatedField<KothBattleHistory> DefenseHistory
		{
			[Address(RVA="0x1A99768", Offset="0x1A99768", VA="0x1A99768")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109B6F0", Offset="0x109B6F0")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1A994B4", Offset="0x1A994B4", VA="0x1A994B4")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109B6E0", Offset="0x109B6E0")]
		public static MessageParser<KothBattleHistoryResponse> Parser
		{
			[Address(RVA="0x1A9944C", Offset="0x1A9944C", VA="0x1A9944C")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109B700", Offset="0x109B700")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1A995A4", Offset="0x1A995A4", VA="0x1A995A4", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1A99C50", Offset="0x1A99C50", VA="0x1A99C50")]
		static KothBattleHistoryResponse()
		{
		}

		[Address(RVA="0x1A99600", Offset="0x1A99600", VA="0x1A99600")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10871EC", Offset="0x10871EC")]
		public KothBattleHistoryResponse()
		{
		}

		[Address(RVA="0x1A99670", Offset="0x1A99670", VA="0x1A99670")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10871FC", Offset="0x10871FC")]
		public KothBattleHistoryResponse(KothBattleHistoryResponse other)
		{
		}

		[Address(RVA="0x1A99A20", Offset="0x1A99A20", VA="0x1A99A20", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108726C", Offset="0x108726C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1A99708", Offset="0x1A99708", VA="0x1A99708", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108720C", Offset="0x108720C")]
		public KothBattleHistoryResponse Clone()
		{
			return null;
		}

		[Address(RVA="0x1A99770", Offset="0x1A99770", VA="0x1A99770", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108721C", Offset="0x108721C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1A997E4", Offset="0x1A997E4", VA="0x1A997E4", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108722C", Offset="0x108722C")]
		public bool Equals(KothBattleHistoryResponse other)
		{
			return new bool();
		}

		[Address(RVA="0x1A99894", Offset="0x1A99894", VA="0x1A99894", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108723C", Offset="0x108723C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1A99ADC", Offset="0x1A99ADC", VA="0x1A99ADC", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108727C", Offset="0x108727C")]
		public void MergeFrom(KothBattleHistoryResponse other)
		{
		}

		[Address(RVA="0x1A99B6C", Offset="0x1A99B6C", VA="0x1A99B6C", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108728C", Offset="0x108728C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1A998F4", Offset="0x1A998F4", VA="0x1A998F4", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108724C", Offset="0x108724C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1A9995C", Offset="0x1A9995C", VA="0x1A9995C", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108725C", Offset="0x108725C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10508E8", Offset="0x10508E8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static KothBattleHistoryResponse.<>c <>9;

			[Address(RVA="0x1A99D70", Offset="0x1A99D70", VA="0x1A99D70")]
			static <>c()
			{
			}

			[Address(RVA="0x1A99DD4", Offset="0x1A99DD4", VA="0x1A99DD4")]
			public <>c()
			{
			}

			[Address(RVA="0x1A99DDC", Offset="0x1A99DDC", VA="0x1A99DDC")]
			internal KothBattleHistoryResponse <.cctor>b__25_0()
			{
				return null;
			}
		}
	}
}