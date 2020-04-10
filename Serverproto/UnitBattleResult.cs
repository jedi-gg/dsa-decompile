using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class UnitBattleResult : IMessage<UnitBattleResult>, IMessage, IEquatable<UnitBattleResult>, IDeepCloneable<UnitBattleResult>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<UnitBattleResult> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int PersistentIdFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private ulong persistentId_;

		[FieldOffset(Offset="0x0")]
		public const int IsAliveFieldNumber = 2;

		[FieldOffset(Offset="0x20")]
		private bool isAlive_;

		[FieldOffset(Offset="0x0")]
		public const int HealthPercentFieldNumber = 3;

		[FieldOffset(Offset="0x24")]
		private float healthPercent_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1092F70", Offset="0x1092F70")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x14B3EB4", Offset="0x14B3EB4", VA="0x14B3EB4")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1092FB0", Offset="0x1092FB0")]
		public float HealthPercent
		{
			[Address(RVA="0x14B4128", Offset="0x14B4128", VA="0x14B4128")]
			get
			{
				return new float();
			}
			[Address(RVA="0x14B4130", Offset="0x14B4130", VA="0x14B4130")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1092FA0", Offset="0x1092FA0")]
		public bool IsAlive
		{
			[Address(RVA="0x14B4114", Offset="0x14B4114", VA="0x14B4114")]
			get
			{
				return new bool();
			}
			[Address(RVA="0x14B411C", Offset="0x14B411C", VA="0x14B411C")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1092F60", Offset="0x1092F60")]
		public static MessageParser<UnitBattleResult> Parser
		{
			[Address(RVA="0x14B3E4C", Offset="0x14B3E4C", VA="0x14B3E4C")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1092F80", Offset="0x1092F80")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x14B3FA4", Offset="0x14B3FA4", VA="0x14B3FA4", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1092F90", Offset="0x1092F90")]
		public ulong PersistentId
		{
			[Address(RVA="0x14B4104", Offset="0x14B4104", VA="0x14B4104")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x14B410C", Offset="0x14B410C", VA="0x14B410C")]
			set
			{
			}
		}

		[Address(RVA="0x14B4794", Offset="0x14B4794", VA="0x14B4794")]
		static UnitBattleResult()
		{
		}

		[Address(RVA="0x14B4000", Offset="0x14B4000", VA="0x14B4000")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1077DEC", Offset="0x1077DEC")]
		public UnitBattleResult()
		{
		}

		[Address(RVA="0x14B4008", Offset="0x14B4008", VA="0x14B4008")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1077DFC", Offset="0x1077DFC")]
		public UnitBattleResult(UnitBattleResult other)
		{
		}

		[Address(RVA="0x14B45A8", Offset="0x14B45A8", VA="0x14B45A8", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1077E6C", Offset="0x1077E6C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x14B40A4", Offset="0x14B40A4", VA="0x14B40A4", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1077E0C", Offset="0x1077E0C")]
		public UnitBattleResult Clone()
		{
			return null;
		}

		[Address(RVA="0x14B4138", Offset="0x14B4138", VA="0x14B4138", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1077E1C", Offset="0x1077E1C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x14B41AC", Offset="0x14B41AC", VA="0x14B41AC", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1077E2C", Offset="0x1077E2C")]
		public bool Equals(UnitBattleResult other)
		{
			return new bool();
		}

		[Address(RVA="0x14B42C0", Offset="0x14B42C0", VA="0x14B42C0", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1077E3C", Offset="0x1077E3C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x14B4660", Offset="0x14B4660", VA="0x14B4660", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1077E7C", Offset="0x1077E7C")]
		public void MergeFrom(UnitBattleResult other)
		{
		}

		[Address(RVA="0x14B46BC", Offset="0x14B46BC", VA="0x14B46BC", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1077E8C", Offset="0x1077E8C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x14B43DC", Offset="0x14B43DC", VA="0x14B43DC", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1077E4C", Offset="0x1077E4C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x14B4444", Offset="0x14B4444", VA="0x14B4444", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1077E5C", Offset="0x1077E5C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104F278", Offset="0x104F278")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static UnitBattleResult.<>c <>9;

			[Address(RVA="0x14B486C", Offset="0x14B486C", VA="0x14B486C")]
			static <>c()
			{
			}

			[Address(RVA="0x14B48D0", Offset="0x14B48D0", VA="0x14B48D0")]
			public <>c()
			{
			}

			[Address(RVA="0x14B48D8", Offset="0x14B48D8", VA="0x14B48D8")]
			internal UnitBattleResult <.cctor>b__35_0()
			{
				return null;
			}
		}
	}
}