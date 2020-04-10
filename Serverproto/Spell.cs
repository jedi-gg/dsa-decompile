using Gamedata;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;

namespace Serverproto
{
	public sealed class Spell : IMessage<Serverproto.Spell>, IMessage, IEquatable<Serverproto.Spell>, IDeepCloneable<Serverproto.Spell>
	{
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10628B4", Offset="0x10628B4")]
		[FieldOffset(Offset="0x10")]
		private Gamedata.Spell <Definition>k__BackingField;

		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<Serverproto.Spell> _parser;

		[FieldOffset(Offset="0x20")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int DefinitionIdFieldNumber = 1;

		[FieldOffset(Offset="0x28")]
		private ulong definitionId_;

		[FieldOffset(Offset="0x0")]
		public const int LevelFieldNumber = 2;

		[FieldOffset(Offset="0x30")]
		private ulong level_;

		[FieldOffset(Offset="0x0")]
		public const int PowerRatingFieldNumber = 3;

		[FieldOffset(Offset="0x38")]
		private ulong powerRating_;

		public Gamedata.Spell Definition
		{
			[Address(RVA="0x1BD7710", Offset="0x1BD7710", VA="0x1BD7710")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10837EC", Offset="0x10837EC")]
			get
			{
				return new Gamedata.Spell();
			}
			[Address(RVA="0x1BD771C", Offset="0x1BD771C", VA="0x1BD771C")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10837FC", Offset="0x10837FC")]
			private set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1099828", Offset="0x1099828")]
		public ulong DefinitionId
		{
			[Address(RVA="0x1BD7C10", Offset="0x1BD7C10", VA="0x1BD7C10")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1BD7C18", Offset="0x1BD7C18", VA="0x1BD7C18")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1099808", Offset="0x1099808")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1BD795C", Offset="0x1BD795C", VA="0x1BD795C")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1099838", Offset="0x1099838")]
		public ulong Level
		{
			[Address(RVA="0x1BD78EC", Offset="0x1BD78EC", VA="0x1BD78EC")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1BD7C20", Offset="0x1BD7C20", VA="0x1BD7C20")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10997F8", Offset="0x10997F8")]
		public static MessageParser<Serverproto.Spell> Parser
		{
			[Address(RVA="0x1BD78F4", Offset="0x1BD78F4", VA="0x1BD78F4")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1099818", Offset="0x1099818")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1BD7AB0", Offset="0x1BD7AB0", VA="0x1BD7AB0", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1099848", Offset="0x1099848")]
		public ulong PowerRating
		{
			[Address(RVA="0x1BD78E4", Offset="0x1BD78E4", VA="0x1BD78E4")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1BD7C28", Offset="0x1BD7C28", VA="0x1BD7C28")]
			set
			{
			}
		}

		[Address(RVA="0x1BD8198", Offset="0x1BD8198", VA="0x1BD8198")]
		static Spell()
		{
		}

		[Address(RVA="0x1BD7B0C", Offset="0x1BD7B0C", VA="0x1BD7B0C")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108380C", Offset="0x108380C")]
		public Spell()
		{
		}

		[Address(RVA="0x1BD7B14", Offset="0x1BD7B14", VA="0x1BD7B14")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108381C", Offset="0x108381C")]
		public Spell(Serverproto.Spell other)
		{
		}

		[Address(RVA="0x1BD7F58", Offset="0x1BD7F58", VA="0x1BD7F58", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108388C", Offset="0x108388C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1BD7BB0", Offset="0x1BD7BB0", VA="0x1BD7BB0", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108382C", Offset="0x108382C")]
		public Serverproto.Spell Clone()
		{
			return null;
		}

		[Address(RVA="0x1BD7C30", Offset="0x1BD7C30", VA="0x1BD7C30", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108383C", Offset="0x108383C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1BD7CA4", Offset="0x1BD7CA4", VA="0x1BD7CA4", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108384C", Offset="0x108384C")]
		public bool Equals(Serverproto.Spell other)
		{
			return new bool();
		}

		[Address(RVA="0x1BD7D00", Offset="0x1BD7D00", VA="0x1BD7D00", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108385C", Offset="0x108385C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1BD8068", Offset="0x1BD8068", VA="0x1BD8068", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108389C", Offset="0x108389C")]
		public void MergeFrom(Serverproto.Spell other)
		{
		}

		[Address(RVA="0x1BD80C0", Offset="0x1BD80C0", VA="0x1BD80C0", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10838AC", Offset="0x10838AC")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1BD7DA0", Offset="0x1BD7DA0", VA="0x1BD7DA0", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108386C", Offset="0x108386C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1BD7724", Offset="0x1BD7724", VA="0x1BD7724")]
		public Dictionary<string, object> ToTelemetryData()
		{
			return null;
		}

		[Address(RVA="0x1BD7E08", Offset="0x1BD7E08", VA="0x1BD7E08", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108387C", Offset="0x108387C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10503A8", Offset="0x10503A8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static Serverproto.Spell.<>c <>9;

			[Address(RVA="0x1BD8270", Offset="0x1BD8270", VA="0x1BD8270")]
			static <>c()
			{
			}

			[Address(RVA="0x1BD82D4", Offset="0x1BD82D4", VA="0x1BD82D4")]
			public <>c()
			{
			}

			[Address(RVA="0x1BD82DC", Offset="0x1BD82DC", VA="0x1BD82DC")]
			internal Serverproto.Spell <.cctor>b__41_0()
			{
				return null;
			}
		}

		public class Factory
		{
			[Attribute(Name="InjectAttribute", RVA="0x106C9C4", Offset="0x106C9C4")]
			[FieldOffset(Offset="0x10")]
			private GamedataDomainController _gamedataDC;

			[Address(RVA="0x1BD8530", Offset="0x1BD8530", VA="0x1BD8530")]
			public Factory()
			{
			}

			[Address(RVA="0x1BD8338", Offset="0x1BD8338", VA="0x1BD8338")]
			public void BindPartialFields(ref Serverproto.Spell spell)
			{
			}

			[Address(RVA="0x1BD8424", Offset="0x1BD8424", VA="0x1BD8424")]
			public Serverproto.Spell FromBattleSpell(BattleLib_Bootstrap.Types.Spell spell)
			{
				return null;
			}
		}
	}
}