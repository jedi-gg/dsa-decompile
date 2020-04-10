using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class BattleSim_BattleScript : IMessage<BattleSim_BattleScript>, IMessage, IEquatable<BattleSim_BattleScript>, IDeepCloneable<BattleSim_BattleScript>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<BattleSim_BattleScript> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int BattleScriptBytesFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private ByteString battleScriptBytes_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1093DF0", Offset="0x1093DF0")]
		public ByteString BattleScriptBytes
		{
			[Address(RVA="0x1DCF8C0", Offset="0x1DCF8C0", VA="0x1DCF8C0")]
			get
			{
				return null;
			}
			[Address(RVA="0x1DCF8C8", Offset="0x1DCF8C8", VA="0x1DCF8C8")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1093DD0", Offset="0x1093DD0")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1DCF644", Offset="0x1DCF644", VA="0x1DCF644")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1093DC0", Offset="0x1093DC0")]
		public static MessageParser<BattleSim_BattleScript> Parser
		{
			[Address(RVA="0x1DCF43C", Offset="0x1DCF43C", VA="0x1DCF43C")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1093DE0", Offset="0x1093DE0")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1DCF730", Offset="0x1DCF730", VA="0x1DCF730", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1DCFDB0", Offset="0x1DCFDB0", VA="0x1DCFDB0")]
		static BattleSim_BattleScript()
		{
		}

		[Address(RVA="0x1DCF78C", Offset="0x1DCF78C", VA="0x1DCF78C")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107933C", Offset="0x107933C")]
		public BattleSim_BattleScript()
		{
		}

		[Address(RVA="0x1DCF800", Offset="0x1DCF800", VA="0x1DCF800")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107934C", Offset="0x107934C")]
		public BattleSim_BattleScript(BattleSim_BattleScript other)
		{
		}

		[Address(RVA="0x1DCFC0C", Offset="0x1DCFC0C", VA="0x1DCFC0C", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10793BC", Offset="0x10793BC")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1DCF860", Offset="0x1DCF860", VA="0x1DCF860", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107935C", Offset="0x107935C")]
		public BattleSim_BattleScript Clone()
		{
			return null;
		}

		[Address(RVA="0x1DCF938", Offset="0x1DCF938", VA="0x1DCF938", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107936C", Offset="0x107936C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1DCF9AC", Offset="0x1DCF9AC", VA="0x1DCF9AC", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107937C", Offset="0x107937C")]
		public bool Equals(BattleSim_BattleScript other)
		{
			return new bool();
		}

		[Address(RVA="0x1DCFA68", Offset="0x1DCFA68", VA="0x1DCFA68", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107938C", Offset="0x107938C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1DCFCC0", Offset="0x1DCFCC0", VA="0x1DCFCC0", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10793CC", Offset="0x10793CC")]
		public void MergeFrom(BattleSim_BattleScript other)
		{
		}

		[Address(RVA="0x1DCFD2C", Offset="0x1DCFD2C", VA="0x1DCFD2C", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10793DC", Offset="0x10793DC")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1DCFAEC", Offset="0x1DCFAEC", VA="0x1DCFAEC", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107939C", Offset="0x107939C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1DCFB54", Offset="0x1DCFB54", VA="0x1DCFB54", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10793AC", Offset="0x10793AC")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104F4A8", Offset="0x104F4A8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static BattleSim_BattleScript.<>c <>9;

			[Address(RVA="0x1DCFE88", Offset="0x1DCFE88", VA="0x1DCFE88")]
			static <>c()
			{
			}

			[Address(RVA="0x1DCFEEC", Offset="0x1DCFEEC", VA="0x1DCFEEC")]
			public <>c()
			{
			}

			[Address(RVA="0x1DCFEF4", Offset="0x1DCFEF4", VA="0x1DCFEF4")]
			internal BattleSim_BattleScript <.cctor>b__25_0()
			{
				return null;
			}
		}
	}
}