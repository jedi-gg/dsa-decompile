using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class GenerateBonusEnergyRequest : IMessage<GenerateBonusEnergyRequest>, IMessage, IEquatable<GenerateBonusEnergyRequest>, IDeepCloneable<GenerateBonusEnergyRequest>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<GenerateBonusEnergyRequest> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int EnergyItemIdFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private ulong energyItemId_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109B230", Offset="0x109B230")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1BA4BE4", Offset="0x1BA4BE4", VA="0x1BA4BE4")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109B250", Offset="0x109B250")]
		public ulong EnergyItemId
		{
			[Address(RVA="0x1BA4DFC", Offset="0x1BA4DFC", VA="0x1BA4DFC")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1BA4E04", Offset="0x1BA4E04", VA="0x1BA4E04")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109B220", Offset="0x109B220")]
		public static MessageParser<GenerateBonusEnergyRequest> Parser
		{
			[Address(RVA="0x1BA4B7C", Offset="0x1BA4B7C", VA="0x1BA4B7C")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109B240", Offset="0x109B240")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1BA4CD4", Offset="0x1BA4CD4", VA="0x1BA4CD4", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1BA5178", Offset="0x1BA5178", VA="0x1BA5178")]
		static GenerateBonusEnergyRequest()
		{
		}

		[Address(RVA="0x1BA4D30", Offset="0x1BA4D30", VA="0x1BA4D30")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108679C", Offset="0x108679C")]
		public GenerateBonusEnergyRequest()
		{
		}

		[Address(RVA="0x1BA4D38", Offset="0x1BA4D38", VA="0x1BA4D38")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10867AC", Offset="0x10867AC")]
		public GenerateBonusEnergyRequest(GenerateBonusEnergyRequest other)
		{
		}

		[Address(RVA="0x1BA502C", Offset="0x1BA502C", VA="0x1BA502C", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108681C", Offset="0x108681C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1BA4D9C", Offset="0x1BA4D9C", VA="0x1BA4D9C", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10867BC", Offset="0x10867BC")]
		public GenerateBonusEnergyRequest Clone()
		{
			return null;
		}

		[Address(RVA="0x1BA4E0C", Offset="0x1BA4E0C", VA="0x1BA4E0C", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10867CC", Offset="0x10867CC")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1BA4E80", Offset="0x1BA4E80", VA="0x1BA4E80", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10867DC", Offset="0x10867DC")]
		public bool Equals(GenerateBonusEnergyRequest other)
		{
			return new bool();
		}

		[Address(RVA="0x1BA4EBC", Offset="0x1BA4EBC", VA="0x1BA4EBC", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10867EC", Offset="0x10867EC")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1BA50BC", Offset="0x1BA50BC", VA="0x1BA50BC", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108682C", Offset="0x108682C")]
		public void MergeFrom(GenerateBonusEnergyRequest other)
		{
		}

		[Address(RVA="0x1BA50FC", Offset="0x1BA50FC", VA="0x1BA50FC", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108683C", Offset="0x108683C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1BA4F24", Offset="0x1BA4F24", VA="0x1BA4F24", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10867FC", Offset="0x10867FC")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1BA4F8C", Offset="0x1BA4F8C", VA="0x1BA4F8C", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108680C", Offset="0x108680C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10507F8", Offset="0x10507F8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static GenerateBonusEnergyRequest.<>c <>9;

			[Address(RVA="0x1BA5250", Offset="0x1BA5250", VA="0x1BA5250")]
			static <>c()
			{
			}

			[Address(RVA="0x1BA52B4", Offset="0x1BA52B4", VA="0x1BA52B4")]
			public <>c()
			{
			}

			[Address(RVA="0x1BA52BC", Offset="0x1BA52BC", VA="0x1BA52BC")]
			internal GenerateBonusEnergyRequest <.cctor>b__25_0()
			{
				return null;
			}
		}
	}
}