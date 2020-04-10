using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class UnitStatOverride : IMessage<UnitStatOverride>, IMessage, IEquatable<UnitStatOverride>, IDeepCloneable<UnitStatOverride>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<UnitStatOverride> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int LevelFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private ulong level_;

		[FieldOffset(Offset="0x0")]
		public const int RarityFieldNumber = 2;

		[FieldOffset(Offset="0x20")]
		private ulong rarity_;

		[FieldOffset(Offset="0x0")]
		public const int GearTierFieldNumber = 3;

		[FieldOffset(Offset="0x28")]
		private ulong gearTier_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1096C00", Offset="0x1096C00")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x14B6258", Offset="0x14B6258", VA="0x14B6258")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1096C40", Offset="0x1096C40")]
		public ulong GearTier
		{
			[Address(RVA="0x14B64C8", Offset="0x14B64C8", VA="0x14B64C8")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x14B64D0", Offset="0x14B64D0", VA="0x14B64D0")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1096C20", Offset="0x1096C20")]
		public ulong Level
		{
			[Address(RVA="0x14B64A8", Offset="0x14B64A8", VA="0x14B64A8")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x14B64B0", Offset="0x14B64B0", VA="0x14B64B0")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1096BF0", Offset="0x1096BF0")]
		public static MessageParser<UnitStatOverride> Parser
		{
			[Address(RVA="0x14B61F0", Offset="0x14B61F0", VA="0x14B61F0")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1096C10", Offset="0x1096C10")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x14B6348", Offset="0x14B6348", VA="0x14B6348", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1096C30", Offset="0x1096C30")]
		public ulong Rarity
		{
			[Address(RVA="0x14B64B8", Offset="0x14B64B8", VA="0x14B64B8")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x14B64C0", Offset="0x14B64C0", VA="0x14B64C0")]
			set
			{
			}
		}

		[Address(RVA="0x14B6A40", Offset="0x14B6A40", VA="0x14B6A40")]
		static UnitStatOverride()
		{
		}

		[Address(RVA="0x14B63A4", Offset="0x14B63A4", VA="0x14B63A4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107F1CC", Offset="0x107F1CC")]
		public UnitStatOverride()
		{
		}

		[Address(RVA="0x14B63AC", Offset="0x14B63AC", VA="0x14B63AC")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107F1DC", Offset="0x107F1DC")]
		public UnitStatOverride(UnitStatOverride other)
		{
		}

		[Address(RVA="0x14B6800", Offset="0x14B6800", VA="0x14B6800", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107F24C", Offset="0x107F24C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x14B6448", Offset="0x14B6448", VA="0x14B6448", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107F1EC", Offset="0x107F1EC")]
		public UnitStatOverride Clone()
		{
			return null;
		}

		[Address(RVA="0x14B64D8", Offset="0x14B64D8", VA="0x14B64D8", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107F1FC", Offset="0x107F1FC")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x14B654C", Offset="0x14B654C", VA="0x14B654C", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107F20C", Offset="0x107F20C")]
		public bool Equals(UnitStatOverride other)
		{
			return new bool();
		}

		[Address(RVA="0x14B65A8", Offset="0x14B65A8", VA="0x14B65A8", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107F21C", Offset="0x107F21C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x14B6910", Offset="0x14B6910", VA="0x14B6910", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107F25C", Offset="0x107F25C")]
		public void MergeFrom(UnitStatOverride other)
		{
		}

		[Address(RVA="0x14B6968", Offset="0x14B6968", VA="0x14B6968", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107F26C", Offset="0x107F26C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x14B6648", Offset="0x14B6648", VA="0x14B6648", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107F22C", Offset="0x107F22C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x14B66B0", Offset="0x14B66B0", VA="0x14B66B0", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107F23C", Offset="0x107F23C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104FD48", Offset="0x104FD48")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static UnitStatOverride.<>c <>9;

			[Address(RVA="0x14B6B18", Offset="0x14B6B18", VA="0x14B6B18")]
			static <>c()
			{
			}

			[Address(RVA="0x14B6B7C", Offset="0x14B6B7C", VA="0x14B6B7C")]
			public <>c()
			{
			}

			[Address(RVA="0x14B6B84", Offset="0x14B6B84", VA="0x14B6B84")]
			internal UnitStatOverride <.cctor>b__35_0()
			{
				return null;
			}
		}
	}
}