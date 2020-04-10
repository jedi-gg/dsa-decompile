using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class MultiplayerBattleTeamResult : IMessage<MultiplayerBattleTeamResult>, IMessage, IEquatable<MultiplayerBattleTeamResult>, IDeepCloneable<MultiplayerBattleTeamResult>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<MultiplayerBattleTeamResult> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int TeamIdFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private int teamId_;

		[FieldOffset(Offset="0x0")]
		public const int StarCountFieldNumber = 2;

		[FieldOffset(Offset="0x20")]
		private ulong starCount_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1092478", Offset="0x1092478")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1A2523C", Offset="0x1A2523C", VA="0x1A2523C")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1092468", Offset="0x1092468")]
		public static MessageParser<MultiplayerBattleTeamResult> Parser
		{
			[Address(RVA="0x1A2367C", Offset="0x1A2367C", VA="0x1A2367C")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1092488", Offset="0x1092488")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1A2532C", Offset="0x1A2532C", VA="0x1A2532C", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10924A8", Offset="0x10924A8")]
		public ulong StarCount
		{
			[Address(RVA="0x1A25480", Offset="0x1A25480", VA="0x1A25480")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1A25488", Offset="0x1A25488", VA="0x1A25488")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1092498", Offset="0x1092498")]
		public int TeamId
		{
			[Address(RVA="0x1A25470", Offset="0x1A25470", VA="0x1A25470")]
			get
			{
				return new int();
			}
			[Address(RVA="0x1A25478", Offset="0x1A25478", VA="0x1A25478")]
			set
			{
			}
		}

		[Address(RVA="0x1A258FC", Offset="0x1A258FC", VA="0x1A258FC")]
		static MultiplayerBattleTeamResult()
		{
		}

		[Address(RVA="0x1A25388", Offset="0x1A25388", VA="0x1A25388")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107694C", Offset="0x107694C")]
		public MultiplayerBattleTeamResult()
		{
		}

		[Address(RVA="0x1A25390", Offset="0x1A25390", VA="0x1A25390")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107695C", Offset="0x107695C")]
		public MultiplayerBattleTeamResult(MultiplayerBattleTeamResult other)
		{
		}

		[Address(RVA="0x1A25738", Offset="0x1A25738", VA="0x1A25738", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10769CC", Offset="0x10769CC")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1A25410", Offset="0x1A25410", VA="0x1A25410", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107696C", Offset="0x107696C")]
		public MultiplayerBattleTeamResult Clone()
		{
			return null;
		}

		[Address(RVA="0x1A25490", Offset="0x1A25490", VA="0x1A25490", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107697C", Offset="0x107697C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1A25504", Offset="0x1A25504", VA="0x1A25504", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107698C", Offset="0x107698C")]
		public bool Equals(MultiplayerBattleTeamResult other)
		{
			return new bool();
		}

		[Address(RVA="0x1A25550", Offset="0x1A25550", VA="0x1A25550", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107699C", Offset="0x107699C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1A2580C", Offset="0x1A2580C", VA="0x1A2580C", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10769DC", Offset="0x10769DC")]
		public void MergeFrom(MultiplayerBattleTeamResult other)
		{
		}

		[Address(RVA="0x1A25858", Offset="0x1A25858", VA="0x1A25858", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10769EC", Offset="0x10769EC")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1A255D8", Offset="0x1A255D8", VA="0x1A255D8", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10769AC", Offset="0x10769AC")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1A25640", Offset="0x1A25640", VA="0x1A25640", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10769BC", Offset="0x10769BC")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104F098", Offset="0x104F098")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static MultiplayerBattleTeamResult.<>c <>9;

			[Address(RVA="0x1A259D4", Offset="0x1A259D4", VA="0x1A259D4")]
			static <>c()
			{
			}

			[Address(RVA="0x1A25A38", Offset="0x1A25A38", VA="0x1A25A38")]
			public <>c()
			{
			}

			[Address(RVA="0x1A25A40", Offset="0x1A25A40", VA="0x1A25A40")]
			internal MultiplayerBattleTeamResult <.cctor>b__30_0()
			{
				return null;
			}
		}
	}
}