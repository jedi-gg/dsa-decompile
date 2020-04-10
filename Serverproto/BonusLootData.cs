using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class BonusLootData : IMessage<BonusLootData>, IMessage, IEquatable<BonusLootData>, IDeepCloneable<BonusLootData>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<BonusLootData> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int ExpireTimestampFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private ulong expireTimestamp_;

		[FieldOffset(Offset="0x0")]
		public const int TitleLocKeyFieldNumber = 2;

		[FieldOffset(Offset="0x20")]
		private string titleLocKey_;

		[FieldOffset(Offset="0x0")]
		public const int DescriptionLocKeyFieldNumber = 3;

		[FieldOffset(Offset="0x28")]
		private string descriptionLocKey_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1094490", Offset="0x1094490")]
		public string DescriptionLocKey
		{
			[Address(RVA="0x1DD9D34", Offset="0x1DD9D34", VA="0x1DD9D34")]
			get
			{
				return null;
			}
			[Address(RVA="0x1DD9D3C", Offset="0x1DD9D3C", VA="0x1DD9D3C")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1094450", Offset="0x1094450")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1DD9A10", Offset="0x1DD9A10", VA="0x1DD9A10")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1094470", Offset="0x1094470")]
		public ulong ExpireTimestamp
		{
			[Address(RVA="0x1DD9CAC", Offset="0x1DD9CAC", VA="0x1DD9CAC")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1DD9CB4", Offset="0x1DD9CB4", VA="0x1DD9CB4")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1094440", Offset="0x1094440")]
		public static MessageParser<BonusLootData> Parser
		{
			[Address(RVA="0x1DD99A8", Offset="0x1DD99A8", VA="0x1DD99A8")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1094460", Offset="0x1094460")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1DD9B00", Offset="0x1DD9B00", VA="0x1DD9B00", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1094480", Offset="0x1094480")]
		public string TitleLocKey
		{
			[Address(RVA="0x1DD9CBC", Offset="0x1DD9CBC", VA="0x1DD9CBC")]
			get
			{
				return null;
			}
			[Address(RVA="0x1DD9CC4", Offset="0x1DD9CC4", VA="0x1DD9CC4")]
			set
			{
			}
		}

		[Address(RVA="0x1DDA450", Offset="0x1DDA450", VA="0x1DDA450")]
		static BonusLootData()
		{
		}

		[Address(RVA="0x1DD9B5C", Offset="0x1DD9B5C", VA="0x1DD9B5C")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1079E9C", Offset="0x1079E9C")]
		public BonusLootData()
		{
		}

		[Address(RVA="0x1DD9BB4", Offset="0x1DD9BB4", VA="0x1DD9BB4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1079EAC", Offset="0x1079EAC")]
		public BonusLootData(BonusLootData other)
		{
		}

		[Address(RVA="0x1DDA180", Offset="0x1DDA180", VA="0x1DDA180", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1079F1C", Offset="0x1079F1C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1DD9C4C", Offset="0x1DD9C4C", VA="0x1DD9C4C", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1079EBC", Offset="0x1079EBC")]
		public BonusLootData Clone()
		{
			return null;
		}

		[Address(RVA="0x1DD9DAC", Offset="0x1DD9DAC", VA="0x1DD9DAC", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1079ECC", Offset="0x1079ECC")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1DD9E20", Offset="0x1DD9E20", VA="0x1DD9E20", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1079EDC", Offset="0x1079EDC")]
		public bool Equals(BonusLootData other)
		{
			return new bool();
		}

		[Address(RVA="0x1DD9EA8", Offset="0x1DD9EA8", VA="0x1DD9EA8", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1079EEC", Offset="0x1079EEC")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1DDA2C8", Offset="0x1DDA2C8", VA="0x1DDA2C8", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1079F2C", Offset="0x1079F2C")]
		public void MergeFrom(BonusLootData other)
		{
		}

		[Address(RVA="0x1DDA36C", Offset="0x1DDA36C", VA="0x1DDA36C", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1079F3C", Offset="0x1079F3C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1DD9F98", Offset="0x1DD9F98", VA="0x1DD9F98", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1079EFC", Offset="0x1079EFC")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1DDA000", Offset="0x1DDA000", VA="0x1DDA000", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1079F0C", Offset="0x1079F0C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104F5A8", Offset="0x104F5A8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static BonusLootData.<>c <>9;

			[Address(RVA="0x1DDA528", Offset="0x1DDA528", VA="0x1DDA528")]
			static <>c()
			{
			}

			[Address(RVA="0x1DDA58C", Offset="0x1DDA58C", VA="0x1DDA58C")]
			public <>c()
			{
			}

			[Address(RVA="0x1DDA594", Offset="0x1DDA594", VA="0x1DDA594")]
			internal BonusLootData <.cctor>b__35_0()
			{
				return null;
			}
		}
	}
}