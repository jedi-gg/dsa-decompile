using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class CampaignMapDetailRequest : IMessage<CampaignMapDetailRequest>, IMessage, IEquatable<CampaignMapDetailRequest>, IDeepCloneable<CampaignMapDetailRequest>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<CampaignMapDetailRequest> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int CampaignIdentifierFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private Serverproto.CampaignIdentifier campaignIdentifier_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1094258", Offset="0x1094258")]
		public Serverproto.CampaignIdentifier CampaignIdentifier
		{
			[Address(RVA="0x1F9001C", Offset="0x1F9001C", VA="0x1F9001C")]
			get
			{
				return null;
			}
			[Address(RVA="0x1F90024", Offset="0x1F90024", VA="0x1F90024")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1094238", Offset="0x1094238")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1F8FE54", Offset="0x1F8FE54", VA="0x1F8FE54")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1094228", Offset="0x1094228")]
		public static MessageParser<CampaignMapDetailRequest> Parser
		{
			[Address(RVA="0x1F8FDEC", Offset="0x1F8FDEC", VA="0x1F8FDEC")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1094248", Offset="0x1094248")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1F8FF40", Offset="0x1F8FF40", VA="0x1F8FF40", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1F904E0", Offset="0x1F904E0", VA="0x1F904E0")]
		static CampaignMapDetailRequest()
		{
		}

		[Address(RVA="0x1F8FF9C", Offset="0x1F8FF9C", VA="0x1F8FF9C")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1079A7C", Offset="0x1079A7C")]
		public CampaignMapDetailRequest()
		{
		}

		[Address(RVA="0x1F8FFA4", Offset="0x1F8FFA4", VA="0x1F8FFA4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1079A8C", Offset="0x1079A8C")]
		public CampaignMapDetailRequest(CampaignMapDetailRequest other)
		{
		}

		[Address(RVA="0x1F902C4", Offset="0x1F902C4", VA="0x1F902C4", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1079AFC", Offset="0x1079AFC")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1F9002C", Offset="0x1F9002C", VA="0x1F9002C", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1079A9C", Offset="0x1079A9C")]
		public CampaignMapDetailRequest Clone()
		{
			return null;
		}

		[Address(RVA="0x1F9008C", Offset="0x1F9008C", VA="0x1F9008C", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1079AAC", Offset="0x1079AAC")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1F90100", Offset="0x1F90100", VA="0x1F90100", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1079ABC", Offset="0x1079ABC")]
		public bool Equals(CampaignMapDetailRequest other)
		{
			return new bool();
		}

		[Address(RVA="0x1F90164", Offset="0x1F90164", VA="0x1F90164", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1079ACC", Offset="0x1079ACC")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1F90354", Offset="0x1F90354", VA="0x1F90354", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1079B0C", Offset="0x1079B0C")]
		public void MergeFrom(CampaignMapDetailRequest other)
		{
		}

		[Address(RVA="0x1F90404", Offset="0x1F90404", VA="0x1F90404", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1079B1C", Offset="0x1079B1C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1F901BC", Offset="0x1F901BC", VA="0x1F901BC", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1079ADC", Offset="0x1079ADC")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1F90224", Offset="0x1F90224", VA="0x1F90224", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1079AEC", Offset="0x1079AEC")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104F548", Offset="0x104F548")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static CampaignMapDetailRequest.<>c <>9;

			[Address(RVA="0x1F905B8", Offset="0x1F905B8", VA="0x1F905B8")]
			static <>c()
			{
			}

			[Address(RVA="0x1F9061C", Offset="0x1F9061C", VA="0x1F9061C")]
			public <>c()
			{
			}

			[Address(RVA="0x1F90624", Offset="0x1F90624", VA="0x1F90624")]
			internal CampaignMapDetailRequest <.cctor>b__25_0()
			{
				return null;
			}
		}
	}
}