using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class BattleSquadSaveInfo : IMessage<BattleSquadSaveInfo>, IMessage, IEquatable<BattleSquadSaveInfo>, IDeepCloneable<BattleSquadSaveInfo>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<BattleSquadSaveInfo> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int GameModeFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private int gameMode_;

		[FieldOffset(Offset="0x0")]
		public const int SlotFieldNumber = 2;

		[FieldOffset(Offset="0x20")]
		private ulong slot_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1091C00", Offset="0x1091C00")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1DD8240", Offset="0x1DD8240", VA="0x1DD8240")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1091C20", Offset="0x1091C20")]
		public int GameMode
		{
			[Address(RVA="0x1DD8470", Offset="0x1DD8470", VA="0x1DD8470")]
			get
			{
				return new int();
			}
			[Address(RVA="0x1DD8478", Offset="0x1DD8478", VA="0x1DD8478")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1091BF0", Offset="0x1091BF0")]
		public static MessageParser<BattleSquadSaveInfo> Parser
		{
			[Address(RVA="0x1DCC060", Offset="0x1DCC060", VA="0x1DCC060")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1091C10", Offset="0x1091C10")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1DD832C", Offset="0x1DD832C", VA="0x1DD832C", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1091C30", Offset="0x1091C30")]
		public ulong Slot
		{
			[Address(RVA="0x1DD8480", Offset="0x1DD8480", VA="0x1DD8480")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1DD8488", Offset="0x1DD8488", VA="0x1DD8488")]
			set
			{
			}
		}

		[Address(RVA="0x1DD88FC", Offset="0x1DD88FC", VA="0x1DD88FC")]
		static BattleSquadSaveInfo()
		{
		}

		[Address(RVA="0x1DD8388", Offset="0x1DD8388", VA="0x1DD8388")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1075B8C", Offset="0x1075B8C")]
		public BattleSquadSaveInfo()
		{
		}

		[Address(RVA="0x1DD8390", Offset="0x1DD8390", VA="0x1DD8390")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1075B9C", Offset="0x1075B9C")]
		public BattleSquadSaveInfo(BattleSquadSaveInfo other)
		{
		}

		[Address(RVA="0x1DD8738", Offset="0x1DD8738", VA="0x1DD8738", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1075C0C", Offset="0x1075C0C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1DD8410", Offset="0x1DD8410", VA="0x1DD8410", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1075BAC", Offset="0x1075BAC")]
		public BattleSquadSaveInfo Clone()
		{
			return null;
		}

		[Address(RVA="0x1DD8490", Offset="0x1DD8490", VA="0x1DD8490", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1075BBC", Offset="0x1075BBC")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1DD8504", Offset="0x1DD8504", VA="0x1DD8504", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1075BCC", Offset="0x1075BCC")]
		public bool Equals(BattleSquadSaveInfo other)
		{
			return new bool();
		}

		[Address(RVA="0x1DD8550", Offset="0x1DD8550", VA="0x1DD8550", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1075BDC", Offset="0x1075BDC")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1DD880C", Offset="0x1DD880C", VA="0x1DD880C", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1075C1C", Offset="0x1075C1C")]
		public void MergeFrom(BattleSquadSaveInfo other)
		{
		}

		[Address(RVA="0x1DD8858", Offset="0x1DD8858", VA="0x1DD8858", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1075C2C", Offset="0x1075C2C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1DD85D8", Offset="0x1DD85D8", VA="0x1DD85D8", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1075BEC", Offset="0x1075BEC")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1DD8640", Offset="0x1DD8640", VA="0x1DD8640", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1075BFC", Offset="0x1075BFC")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104EF58", Offset="0x104EF58")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static BattleSquadSaveInfo.<>c <>9;

			[Address(RVA="0x1DD89D4", Offset="0x1DD89D4", VA="0x1DD89D4")]
			static <>c()
			{
			}

			[Address(RVA="0x1DD8A38", Offset="0x1DD8A38", VA="0x1DD8A38")]
			public <>c()
			{
			}

			[Address(RVA="0x1DD8A40", Offset="0x1DD8A40", VA="0x1DD8A40")]
			internal BattleSquadSaveInfo <.cctor>b__30_0()
			{
				return null;
			}
		}
	}
}