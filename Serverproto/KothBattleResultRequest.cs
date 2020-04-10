using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class KothBattleResultRequest : IMessage<KothBattleResultRequest>, IMessage, IEquatable<KothBattleResultRequest>, IDeepCloneable<KothBattleResultRequest>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<KothBattleResultRequest> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int BattleIdFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private string battleId_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10933C0", Offset="0x10933C0")]
		public string BattleId
		{
			[Address(RVA="0x1A9A100", Offset="0x1A9A100", VA="0x1A9A100")]
			get
			{
				return null;
			}
			[Address(RVA="0x1A9A108", Offset="0x1A9A108", VA="0x1A9A108")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10933A0", Offset="0x10933A0")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1A99E9C", Offset="0x1A99E9C", VA="0x1A99E9C")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1093390", Offset="0x1093390")]
		public static MessageParser<KothBattleResultRequest> Parser
		{
			[Address(RVA="0x1A99E34", Offset="0x1A99E34", VA="0x1A99E34")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10933B0", Offset="0x10933B0")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1A99F8C", Offset="0x1A99F8C", VA="0x1A99F8C", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1A9A598", Offset="0x1A9A598", VA="0x1A9A598")]
		static KothBattleResultRequest()
		{
		}

		[Address(RVA="0x1A99FE8", Offset="0x1A99FE8", VA="0x1A99FE8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107857C", Offset="0x107857C")]
		public KothBattleResultRequest()
		{
		}

		[Address(RVA="0x1A9A040", Offset="0x1A9A040", VA="0x1A9A040")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107858C", Offset="0x107858C")]
		public KothBattleResultRequest(KothBattleResultRequest other)
		{
		}

		[Address(RVA="0x1A9A3F4", Offset="0x1A9A3F4", VA="0x1A9A3F4", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10785FC", Offset="0x10785FC")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1A9A0A0", Offset="0x1A9A0A0", VA="0x1A9A0A0", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107859C", Offset="0x107859C")]
		public KothBattleResultRequest Clone()
		{
			return null;
		}

		[Address(RVA="0x1A9A178", Offset="0x1A9A178", VA="0x1A9A178", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10785AC", Offset="0x10785AC")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1A9A1EC", Offset="0x1A9A1EC", VA="0x1A9A1EC", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10785BC", Offset="0x10785BC")]
		public bool Equals(KothBattleResultRequest other)
		{
			return new bool();
		}

		[Address(RVA="0x1A9A250", Offset="0x1A9A250", VA="0x1A9A250", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10785CC", Offset="0x10785CC")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1A9A4A8", Offset="0x1A9A4A8", VA="0x1A9A4A8", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107860C", Offset="0x107860C")]
		public void MergeFrom(KothBattleResultRequest other)
		{
		}

		[Address(RVA="0x1A9A514", Offset="0x1A9A514", VA="0x1A9A514", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107861C", Offset="0x107861C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1A9A2D4", Offset="0x1A9A2D4", VA="0x1A9A2D4", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10785DC", Offset="0x10785DC")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1A9A33C", Offset="0x1A9A33C", VA="0x1A9A33C", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10785EC", Offset="0x10785EC")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104F328", Offset="0x104F328")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static KothBattleResultRequest.<>c <>9;

			[Address(RVA="0x1A9A670", Offset="0x1A9A670", VA="0x1A9A670")]
			static <>c()
			{
			}

			[Address(RVA="0x1A9A6D4", Offset="0x1A9A6D4", VA="0x1A9A6D4")]
			public <>c()
			{
			}

			[Address(RVA="0x1A9A6DC", Offset="0x1A9A6DC", VA="0x1A9A6DC")]
			internal KothBattleResultRequest <.cctor>b__25_0()
			{
				return null;
			}
		}
	}
}