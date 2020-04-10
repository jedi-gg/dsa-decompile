using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class BattleBootstrapRequestPlayer : IMessage<BattleBootstrapRequestPlayer>, IMessage, IEquatable<BattleBootstrapRequestPlayer>, IDeepCloneable<BattleBootstrapRequestPlayer>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<BattleBootstrapRequestPlayer> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int PlayerTokenFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private string playerToken_;

		[FieldOffset(Offset="0x0")]
		public const int PlayerBattleIdFieldNumber = 2;

		[FieldOffset(Offset="0x20")]
		private ulong playerBattleId_;

		[FieldOffset(Offset="0x0")]
		public const int PlayerAccountIdFieldNumber = 3;

		[FieldOffset(Offset="0x28")]
		private string playerAccountId_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1092830", Offset="0x1092830")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1E709D4", Offset="0x1E709D4", VA="0x1E709D4")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1092820", Offset="0x1092820")]
		public static MessageParser<BattleBootstrapRequestPlayer> Parser
		{
			[Address(RVA="0x1E708A8", Offset="0x1E708A8", VA="0x1E708A8")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1092840", Offset="0x1092840")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1E70AC4", Offset="0x1E70AC4", VA="0x1E70AC4", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1092870", Offset="0x1092870")]
		public string PlayerAccountId
		{
			[Address(RVA="0x1E70CFC", Offset="0x1E70CFC", VA="0x1E70CFC")]
			get
			{
				return null;
			}
			[Address(RVA="0x1E70D04", Offset="0x1E70D04", VA="0x1E70D04")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1092860", Offset="0x1092860")]
		public ulong PlayerBattleId
		{
			[Address(RVA="0x1E70CEC", Offset="0x1E70CEC", VA="0x1E70CEC")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1E70CF4", Offset="0x1E70CF4", VA="0x1E70CF4")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1092850", Offset="0x1092850")]
		public string PlayerToken
		{
			[Address(RVA="0x1E70C74", Offset="0x1E70C74", VA="0x1E70C74")]
			get
			{
				return null;
			}
			[Address(RVA="0x1E70C7C", Offset="0x1E70C7C", VA="0x1E70C7C")]
			set
			{
			}
		}

		[Address(RVA="0x1E71420", Offset="0x1E71420", VA="0x1E71420")]
		static BattleBootstrapRequestPlayer()
		{
		}

		[Address(RVA="0x1E70B20", Offset="0x1E70B20", VA="0x1E70B20")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1076ECC", Offset="0x1076ECC")]
		public BattleBootstrapRequestPlayer()
		{
		}

		[Address(RVA="0x1E70B7C", Offset="0x1E70B7C", VA="0x1E70B7C")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1076EDC", Offset="0x1076EDC")]
		public BattleBootstrapRequestPlayer(BattleBootstrapRequestPlayer other)
		{
		}

		[Address(RVA="0x1E71148", Offset="0x1E71148", VA="0x1E71148", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1076F4C", Offset="0x1076F4C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1E70C14", Offset="0x1E70C14", VA="0x1E70C14", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1076EEC", Offset="0x1076EEC")]
		public BattleBootstrapRequestPlayer Clone()
		{
			return null;
		}

		[Address(RVA="0x1E70D74", Offset="0x1E70D74", VA="0x1E70D74", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1076EFC", Offset="0x1076EFC")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1E70DE8", Offset="0x1E70DE8", VA="0x1E70DE8", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1076F0C", Offset="0x1076F0C")]
		public bool Equals(BattleBootstrapRequestPlayer other)
		{
			return new bool();
		}

		[Address(RVA="0x1E70E70", Offset="0x1E70E70", VA="0x1E70E70", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1076F1C", Offset="0x1076F1C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1E71298", Offset="0x1E71298", VA="0x1E71298", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1076F5C", Offset="0x1076F5C")]
		public void MergeFrom(BattleBootstrapRequestPlayer other)
		{
		}

		[Address(RVA="0x1E7133C", Offset="0x1E7133C", VA="0x1E7133C", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1076F6C", Offset="0x1076F6C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1E70F60", Offset="0x1E70F60", VA="0x1E70F60", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1076F2C", Offset="0x1076F2C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1E70FC8", Offset="0x1E70FC8", VA="0x1E70FC8", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1076F3C", Offset="0x1076F3C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104F118", Offset="0x104F118")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static BattleBootstrapRequestPlayer.<>c <>9;

			[Address(RVA="0x1E714F8", Offset="0x1E714F8", VA="0x1E714F8")]
			static <>c()
			{
			}

			[Address(RVA="0x1E7155C", Offset="0x1E7155C", VA="0x1E7155C")]
			public <>c()
			{
			}

			[Address(RVA="0x1E71564", Offset="0x1E71564", VA="0x1E71564")]
			internal BattleBootstrapRequestPlayer <.cctor>b__35_0()
			{
				return null;
			}
		}
	}
}