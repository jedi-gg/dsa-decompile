using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class AdRewardedEnergyRequest : IMessage<AdRewardedEnergyRequest>, IMessage, IEquatable<AdRewardedEnergyRequest>, IDeepCloneable<AdRewardedEnergyRequest>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<AdRewardedEnergyRequest> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int EnergyItemIdFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private ulong energyItemId_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109B110", Offset="0x109B110")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1605B58", Offset="0x1605B58", VA="0x1605B58")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109B130", Offset="0x109B130")]
		public ulong EnergyItemId
		{
			[Address(RVA="0x1605D70", Offset="0x1605D70", VA="0x1605D70")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1605D78", Offset="0x1605D78", VA="0x1605D78")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109B100", Offset="0x109B100")]
		public static MessageParser<AdRewardedEnergyRequest> Parser
		{
			[Address(RVA="0x1605AF0", Offset="0x1605AF0", VA="0x1605AF0")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109B120", Offset="0x109B120")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1605C48", Offset="0x1605C48", VA="0x1605C48", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x16060EC", Offset="0x16060EC", VA="0x16060EC")]
		static AdRewardedEnergyRequest()
		{
		}

		[Address(RVA="0x1605CA4", Offset="0x1605CA4", VA="0x1605CA4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10864DC", Offset="0x10864DC")]
		public AdRewardedEnergyRequest()
		{
		}

		[Address(RVA="0x1605CAC", Offset="0x1605CAC", VA="0x1605CAC")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10864EC", Offset="0x10864EC")]
		public AdRewardedEnergyRequest(AdRewardedEnergyRequest other)
		{
		}

		[Address(RVA="0x1605FA0", Offset="0x1605FA0", VA="0x1605FA0", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108655C", Offset="0x108655C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1605D10", Offset="0x1605D10", VA="0x1605D10", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10864FC", Offset="0x10864FC")]
		public AdRewardedEnergyRequest Clone()
		{
			return null;
		}

		[Address(RVA="0x1605D80", Offset="0x1605D80", VA="0x1605D80", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108650C", Offset="0x108650C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1605DF4", Offset="0x1605DF4", VA="0x1605DF4", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108651C", Offset="0x108651C")]
		public bool Equals(AdRewardedEnergyRequest other)
		{
			return new bool();
		}

		[Address(RVA="0x1605E30", Offset="0x1605E30", VA="0x1605E30", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108652C", Offset="0x108652C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1606030", Offset="0x1606030", VA="0x1606030", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108656C", Offset="0x108656C")]
		public void MergeFrom(AdRewardedEnergyRequest other)
		{
		}

		[Address(RVA="0x1606070", Offset="0x1606070", VA="0x1606070", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108657C", Offset="0x108657C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1605E98", Offset="0x1605E98", VA="0x1605E98", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108653C", Offset="0x108653C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1605F00", Offset="0x1605F00", VA="0x1605F00", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108654C", Offset="0x108654C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10507B8", Offset="0x10507B8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static AdRewardedEnergyRequest.<>c <>9;

			[Address(RVA="0x16061C4", Offset="0x16061C4", VA="0x16061C4")]
			static <>c()
			{
			}

			[Address(RVA="0x1606228", Offset="0x1606228", VA="0x1606228")]
			public <>c()
			{
			}

			[Address(RVA="0x1606230", Offset="0x1606230", VA="0x1606230")]
			internal AdRewardedEnergyRequest <.cctor>b__25_0()
			{
				return null;
			}
		}
	}
}