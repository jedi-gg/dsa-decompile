using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class BattleSim_Spell : IMessage<BattleSim_Spell>, IMessage, IEquatable<BattleSim_Spell>, IDeepCloneable<BattleSim_Spell>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<BattleSim_Spell> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int DefIdFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private ulong defId_;

		[FieldOffset(Offset="0x0")]
		public const int LevelFieldNumber = 2;

		[FieldOffset(Offset="0x20")]
		private ulong level_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1093DA0", Offset="0x1093DA0")]
		public ulong DefId
		{
			[Address(RVA="0x1DD6C3C", Offset="0x1DD6C3C", VA="0x1DD6C3C")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1DD6C44", Offset="0x1DD6C44", VA="0x1DD6C44")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1093D80", Offset="0x1093D80")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1DD6A0C", Offset="0x1DD6A0C", VA="0x1DD6A0C")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1093DB0", Offset="0x1093DB0")]
		public ulong Level
		{
			[Address(RVA="0x1DD6C4C", Offset="0x1DD6C4C", VA="0x1DD6C4C")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1DD6C54", Offset="0x1DD6C54", VA="0x1DD6C54")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1093D70", Offset="0x1093D70")]
		public static MessageParser<BattleSim_Spell> Parser
		{
			[Address(RVA="0x1DCF3D4", Offset="0x1DCF3D4", VA="0x1DCF3D4")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1093D90", Offset="0x1093D90")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1DD6AF8", Offset="0x1DD6AF8", VA="0x1DD6AF8", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1DD70C4", Offset="0x1DD70C4", VA="0x1DD70C4")]
		static BattleSim_Spell()
		{
		}

		[Address(RVA="0x1DD6B54", Offset="0x1DD6B54", VA="0x1DD6B54")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107928C", Offset="0x107928C")]
		public BattleSim_Spell()
		{
		}

		[Address(RVA="0x1DD6B5C", Offset="0x1DD6B5C", VA="0x1DD6B5C")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107929C", Offset="0x107929C")]
		public BattleSim_Spell(BattleSim_Spell other)
		{
		}

		[Address(RVA="0x1DD6F00", Offset="0x1DD6F00", VA="0x1DD6F00", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107930C", Offset="0x107930C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1DD6BDC", Offset="0x1DD6BDC", VA="0x1DD6BDC", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10792AC", Offset="0x10792AC")]
		public BattleSim_Spell Clone()
		{
			return null;
		}

		[Address(RVA="0x1DD6C5C", Offset="0x1DD6C5C", VA="0x1DD6C5C", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10792BC", Offset="0x10792BC")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1DD6CD0", Offset="0x1DD6CD0", VA="0x1DD6CD0", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10792CC", Offset="0x10792CC")]
		public bool Equals(BattleSim_Spell other)
		{
			return new bool();
		}

		[Address(RVA="0x1DD6D1C", Offset="0x1DD6D1C", VA="0x1DD6D1C", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10792DC", Offset="0x10792DC")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1DD6FD4", Offset="0x1DD6FD4", VA="0x1DD6FD4", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107931C", Offset="0x107931C")]
		public void MergeFrom(BattleSim_Spell other)
		{
		}

		[Address(RVA="0x1DD7020", Offset="0x1DD7020", VA="0x1DD7020", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107932C", Offset="0x107932C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1DD6DA0", Offset="0x1DD6DA0", VA="0x1DD6DA0", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10792EC", Offset="0x10792EC")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1DD6E08", Offset="0x1DD6E08", VA="0x1DD6E08", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10792FC", Offset="0x10792FC")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104F498", Offset="0x104F498")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static BattleSim_Spell.<>c <>9;

			[Address(RVA="0x1DD719C", Offset="0x1DD719C", VA="0x1DD719C")]
			static <>c()
			{
			}

			[Address(RVA="0x1DD7200", Offset="0x1DD7200", VA="0x1DD7200")]
			public <>c()
			{
			}

			[Address(RVA="0x1DD7208", Offset="0x1DD7208", VA="0x1DD7208")]
			internal BattleSim_Spell <.cctor>b__30_0()
			{
				return null;
			}
		}
	}
}