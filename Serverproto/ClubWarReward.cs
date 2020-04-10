using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class ClubWarReward : IMessage<ClubWarReward>, IMessage, IEquatable<ClubWarReward>, IDeepCloneable<ClubWarReward>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<ClubWarReward> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int IdFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private string id_;

		[FieldOffset(Offset="0x0")]
		public const int ProfileFieldNumber = 2;

		[FieldOffset(Offset="0x20")]
		private PlayerProfileSimple profile_;

		[FieldOffset(Offset="0x0")]
		public const int ItemsFieldNumber = 3;

		[FieldOffset(Offset="0x8")]
		private readonly static FieldCodec<InventoryItem> _repeated_items_codec;

		[FieldOffset(Offset="0x28")]
		private readonly RepeatedField<InventoryItem> items_;

		[FieldOffset(Offset="0x0")]
		public const int ImageFieldNumber = 4;

		[FieldOffset(Offset="0x30")]
		private string image_;

		[FieldOffset(Offset="0x0")]
		public const int NameKeyFieldNumber = 5;

		[FieldOffset(Offset="0x38")]
		private string nameKey_;

		[FieldOffset(Offset="0x0")]
		public const int ChestDefIdFieldNumber = 6;

		[FieldOffset(Offset="0x40")]
		private ulong chestDefId_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1096460", Offset="0x1096460")]
		public ulong ChestDefId
		{
			[Address(RVA="0x1B2AEC0", Offset="0x1B2AEC0", VA="0x1B2AEC0")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1B2AEC8", Offset="0x1B2AEC8", VA="0x1B2AEC8")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10963F0", Offset="0x10963F0")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1B2AB10", Offset="0x1B2AB10", VA="0x1B2AB10")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1096410", Offset="0x1096410")]
		public string Id
		{
			[Address(RVA="0x1B2AD50", Offset="0x1B2AD50", VA="0x1B2AD50")]
			get
			{
				return null;
			}
			[Address(RVA="0x1B2AD58", Offset="0x1B2AD58", VA="0x1B2AD58")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1096440", Offset="0x1096440")]
		public string Image
		{
			[Address(RVA="0x1B2ADD0", Offset="0x1B2ADD0", VA="0x1B2ADD0")]
			get
			{
				return null;
			}
			[Address(RVA="0x1B2ADD8", Offset="0x1B2ADD8", VA="0x1B2ADD8")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1096430", Offset="0x1096430")]
		public RepeatedField<InventoryItem> Items
		{
			[Address(RVA="0x1B2ADC8", Offset="0x1B2ADC8", VA="0x1B2ADC8")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1096450", Offset="0x1096450")]
		public string NameKey
		{
			[Address(RVA="0x1B2AE48", Offset="0x1B2AE48", VA="0x1B2AE48")]
			get
			{
				return null;
			}
			[Address(RVA="0x1B2AE50", Offset="0x1B2AE50", VA="0x1B2AE50")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10963E0", Offset="0x10963E0")]
		public static MessageParser<ClubWarReward> Parser
		{
			[Address(RVA="0x1B2AAA8", Offset="0x1B2AAA8", VA="0x1B2AAA8")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1096400", Offset="0x1096400")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1B2AC00", Offset="0x1B2AC00", VA="0x1B2AC00", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1096420", Offset="0x1096420")]
		public PlayerProfileSimple Profile
		{
			[Address(RVA="0x1B2AD40", Offset="0x1B2AD40", VA="0x1B2AD40")]
			get
			{
				return null;
			}
			[Address(RVA="0x1B2AD48", Offset="0x1B2AD48", VA="0x1B2AD48")]
			set
			{
			}
		}

		[Address(RVA="0x1B2B93C", Offset="0x1B2B93C", VA="0x1B2B93C")]
		static ClubWarReward()
		{
		}

		[Address(RVA="0x1B271B4", Offset="0x1B271B4", VA="0x1B271B4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107E61C", Offset="0x107E61C")]
		public ClubWarReward()
		{
		}

		[Address(RVA="0x1B2AC5C", Offset="0x1B2AC5C", VA="0x1B2AC5C")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107E62C", Offset="0x107E62C")]
		public ClubWarReward(ClubWarReward other)
		{
		}

		[Address(RVA="0x1B2B4FC", Offset="0x1B2B4FC", VA="0x1B2B4FC", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107E69C", Offset="0x107E69C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1B26C60", Offset="0x1B26C60", VA="0x1B26C60", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107E63C", Offset="0x107E63C")]
		public ClubWarReward Clone()
		{
			return null;
		}

		[Address(RVA="0x1B2AED0", Offset="0x1B2AED0", VA="0x1B2AED0", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107E64C", Offset="0x107E64C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1B2AF44", Offset="0x1B2AF44", VA="0x1B2AF44", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107E65C", Offset="0x107E65C")]
		public bool Equals(ClubWarReward other)
		{
			return new bool();
		}

		[Address(RVA="0x1B2B054", Offset="0x1B2B054", VA="0x1B2B054", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107E66C", Offset="0x107E66C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1B27244", Offset="0x1B27244", VA="0x1B27244", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107E6AC", Offset="0x107E6AC")]
		public void MergeFrom(ClubWarReward other)
		{
		}

		[Address(RVA="0x1B2B73C", Offset="0x1B2B73C", VA="0x1B2B73C", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107E6BC", Offset="0x107E6BC")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1B2B1D0", Offset="0x1B2B1D0", VA="0x1B2B1D0", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107E67C", Offset="0x107E67C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1B2B238", Offset="0x1B2B238", VA="0x1B2B238", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107E68C", Offset="0x107E68C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104FC38", Offset="0x104FC38")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static ClubWarReward.<>c <>9;

			[Address(RVA="0x1EE2340", Offset="0x1EE2340", VA="0x1EE2340")]
			static <>c()
			{
			}

			[Address(RVA="0x1EE23A4", Offset="0x1EE23A4", VA="0x1EE23A4")]
			public <>c()
			{
			}

			[Address(RVA="0x1EE23AC", Offset="0x1EE23AC", VA="0x1EE23AC")]
			internal ClubWarReward <.cctor>b__50_0()
			{
				return null;
			}
		}
	}
}