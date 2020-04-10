using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class UnitBattleState : IMessage<UnitBattleState>, IMessage, IEquatable<UnitBattleState>, IDeepCloneable<UnitBattleState>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<UnitBattleState> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int DefinitionIdFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private ulong definitionId_;

		[FieldOffset(Offset="0x0")]
		public const int IsEnemyFieldNumber = 2;

		[FieldOffset(Offset="0x20")]
		private bool isEnemy_;

		[FieldOffset(Offset="0x0")]
		public const int IsAliveFieldNumber = 3;

		[FieldOffset(Offset="0x21")]
		private bool isAlive_;

		[FieldOffset(Offset="0x0")]
		public const int HealthPercentFieldNumber = 4;

		[FieldOffset(Offset="0x24")]
		private float healthPercent_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1096C80", Offset="0x1096C80")]
		public ulong DefinitionId
		{
			[Address(RVA="0x14B4C08", Offset="0x14B4C08", VA="0x14B4C08")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x14B4C10", Offset="0x14B4C10", VA="0x14B4C10")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1096C60", Offset="0x1096C60")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x14B499C", Offset="0x14B499C", VA="0x14B499C")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1096CB0", Offset="0x1096CB0")]
		public float HealthPercent
		{
			[Address(RVA="0x14B4C40", Offset="0x14B4C40", VA="0x14B4C40")]
			get
			{
				return new float();
			}
			[Address(RVA="0x14B4C48", Offset="0x14B4C48", VA="0x14B4C48")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1096CA0", Offset="0x1096CA0")]
		public bool IsAlive
		{
			[Address(RVA="0x14B4C2C", Offset="0x14B4C2C", VA="0x14B4C2C")]
			get
			{
				return new bool();
			}
			[Address(RVA="0x14B4C34", Offset="0x14B4C34", VA="0x14B4C34")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1096C90", Offset="0x1096C90")]
		public bool IsEnemy
		{
			[Address(RVA="0x14B4C18", Offset="0x14B4C18", VA="0x14B4C18")]
			get
			{
				return new bool();
			}
			[Address(RVA="0x14B4C20", Offset="0x14B4C20", VA="0x14B4C20")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1096C50", Offset="0x1096C50")]
		public static MessageParser<UnitBattleState> Parser
		{
			[Address(RVA="0x14B4934", Offset="0x14B4934", VA="0x14B4934")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1096C70", Offset="0x1096C70")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x14B4A8C", Offset="0x14B4A8C", VA="0x14B4A8C", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x14B5390", Offset="0x14B5390", VA="0x14B5390")]
		static UnitBattleState()
		{
		}

		[Address(RVA="0x14B4AE8", Offset="0x14B4AE8", VA="0x14B4AE8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107F27C", Offset="0x107F27C")]
		public UnitBattleState()
		{
		}

		[Address(RVA="0x14B4AF0", Offset="0x14B4AF0", VA="0x14B4AF0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107F28C", Offset="0x107F28C")]
		public UnitBattleState(UnitBattleState other)
		{
		}

		[Address(RVA="0x14B515C", Offset="0x14B515C", VA="0x14B515C", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107F2FC", Offset="0x107F2FC")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x14B4BA8", Offset="0x14B4BA8", VA="0x14B4BA8", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107F29C", Offset="0x107F29C")]
		public UnitBattleState Clone()
		{
			return null;
		}

		[Address(RVA="0x14B4C50", Offset="0x14B4C50", VA="0x14B4C50", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107F2AC", Offset="0x107F2AC")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x14B4CC4", Offset="0x14B4CC4", VA="0x14B4CC4", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107F2BC", Offset="0x107F2BC")]
		public bool Equals(UnitBattleState other)
		{
			return new bool();
		}

		[Address(RVA="0x14B4DF8", Offset="0x14B4DF8", VA="0x14B4DF8", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107F2CC", Offset="0x107F2CC")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x14B5224", Offset="0x14B5224", VA="0x14B5224", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107F30C", Offset="0x107F30C")]
		public void MergeFrom(UnitBattleState other)
		{
		}

		[Address(RVA="0x14B528C", Offset="0x14B528C", VA="0x14B528C", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107F31C", Offset="0x107F31C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x14B4F34", Offset="0x14B4F34", VA="0x14B4F34", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107F2DC", Offset="0x107F2DC")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x14B4F9C", Offset="0x14B4F9C", VA="0x14B4F9C", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107F2EC", Offset="0x107F2EC")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104FD58", Offset="0x104FD58")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static UnitBattleState.<>c <>9;

			[Address(RVA="0x14B5468", Offset="0x14B5468", VA="0x14B5468")]
			static <>c()
			{
			}

			[Address(RVA="0x14B54CC", Offset="0x14B54CC", VA="0x14B54CC")]
			public <>c()
			{
			}

			[Address(RVA="0x14B54D4", Offset="0x14B54D4", VA="0x14B54D4")]
			internal UnitBattleState <.cctor>b__40_0()
			{
				return null;
			}
		}
	}
}