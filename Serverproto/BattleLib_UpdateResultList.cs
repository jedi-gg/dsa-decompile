using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class BattleLib_UpdateResultList : IMessage<BattleLib_UpdateResultList>, IMessage, IEquatable<BattleLib_UpdateResultList>, IDeepCloneable<BattleLib_UpdateResultList>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<BattleLib_UpdateResultList> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int ResultsFieldNumber = 1;

		[FieldOffset(Offset="0x8")]
		private readonly static FieldCodec<BattleLib_UpdateResult> _repeated_results_codec;

		[FieldOffset(Offset="0x18")]
		private readonly RepeatedField<BattleLib_UpdateResult> results_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1093970", Offset="0x1093970")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x203B7C8", Offset="0x203B7C8", VA="0x203B7C8")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1093960", Offset="0x1093960")]
		public static MessageParser<BattleLib_UpdateResultList> Parser
		{
			[Address(RVA="0x203B760", Offset="0x203B760", VA="0x203B760")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1093980", Offset="0x1093980")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x203B8B8", Offset="0x203B8B8", VA="0x203B8B8", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1093990", Offset="0x1093990")]
		public RepeatedField<BattleLib_UpdateResult> Results
		{
			[Address(RVA="0x203BA7C", Offset="0x203BA7C", VA="0x203BA7C")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x203BF64", Offset="0x203BF64", VA="0x203BF64")]
		static BattleLib_UpdateResultList()
		{
		}

		[Address(RVA="0x203B914", Offset="0x203B914", VA="0x203B914")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1078BAC", Offset="0x1078BAC")]
		public BattleLib_UpdateResultList()
		{
		}

		[Address(RVA="0x203B984", Offset="0x203B984", VA="0x203B984")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1078BBC", Offset="0x1078BBC")]
		public BattleLib_UpdateResultList(BattleLib_UpdateResultList other)
		{
		}

		[Address(RVA="0x203BD34", Offset="0x203BD34", VA="0x203BD34", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1078C2C", Offset="0x1078C2C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x203BA1C", Offset="0x203BA1C", VA="0x203BA1C", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1078BCC", Offset="0x1078BCC")]
		public BattleLib_UpdateResultList Clone()
		{
			return null;
		}

		[Address(RVA="0x203BA84", Offset="0x203BA84", VA="0x203BA84", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1078BDC", Offset="0x1078BDC")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x203BAF8", Offset="0x203BAF8", VA="0x203BAF8", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1078BEC", Offset="0x1078BEC")]
		public bool Equals(BattleLib_UpdateResultList other)
		{
			return new bool();
		}

		[Address(RVA="0x203BBA8", Offset="0x203BBA8", VA="0x203BBA8", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1078BFC", Offset="0x1078BFC")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x203BDF0", Offset="0x203BDF0", VA="0x203BDF0", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1078C3C", Offset="0x1078C3C")]
		public void MergeFrom(BattleLib_UpdateResultList other)
		{
		}

		[Address(RVA="0x203BE80", Offset="0x203BE80", VA="0x203BE80", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1078C4C", Offset="0x1078C4C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x203BC08", Offset="0x203BC08", VA="0x203BC08", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1078C0C", Offset="0x1078C0C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x203BC70", Offset="0x203BC70", VA="0x203BC70", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1078C1C", Offset="0x1078C1C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104F3C8", Offset="0x104F3C8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static BattleLib_UpdateResultList.<>c <>9;

			[Address(RVA="0x203C088", Offset="0x203C088", VA="0x203C088")]
			static <>c()
			{
			}

			[Address(RVA="0x203C0EC", Offset="0x203C0EC", VA="0x203C0EC")]
			public <>c()
			{
			}

			[Address(RVA="0x203C0F4", Offset="0x203C0F4", VA="0x203C0F4")]
			internal BattleLib_UpdateResultList <.cctor>b__25_0()
			{
				return null;
			}
		}
	}
}