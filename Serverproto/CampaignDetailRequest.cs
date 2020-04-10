using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class CampaignDetailRequest : IMessage<CampaignDetailRequest>, IMessage, IEquatable<CampaignDetailRequest>, IDeepCloneable<CampaignDetailRequest>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<CampaignDetailRequest> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int CampaignIdFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private ulong campaignId_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10942F8", Offset="0x10942F8")]
		public ulong CampaignId
		{
			[Address(RVA="0x1F8D2E4", Offset="0x1F8D2E4", VA="0x1F8D2E4")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1F8D2EC", Offset="0x1F8D2EC", VA="0x1F8D2EC")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10942D8", Offset="0x10942D8")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1F8D0D0", Offset="0x1F8D0D0", VA="0x1F8D0D0")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10942C8", Offset="0x10942C8")]
		public static MessageParser<CampaignDetailRequest> Parser
		{
			[Address(RVA="0x1F8D068", Offset="0x1F8D068", VA="0x1F8D068")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10942E8", Offset="0x10942E8")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1F8D1BC", Offset="0x1F8D1BC", VA="0x1F8D1BC", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1F8D660", Offset="0x1F8D660", VA="0x1F8D660")]
		static CampaignDetailRequest()
		{
		}

		[Address(RVA="0x1F8D218", Offset="0x1F8D218", VA="0x1F8D218")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1079BDC", Offset="0x1079BDC")]
		public CampaignDetailRequest()
		{
		}

		[Address(RVA="0x1F8D220", Offset="0x1F8D220", VA="0x1F8D220")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1079BEC", Offset="0x1079BEC")]
		public CampaignDetailRequest(CampaignDetailRequest other)
		{
		}

		[Address(RVA="0x1F8D514", Offset="0x1F8D514", VA="0x1F8D514", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1079C5C", Offset="0x1079C5C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1F8D284", Offset="0x1F8D284", VA="0x1F8D284", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1079BFC", Offset="0x1079BFC")]
		public CampaignDetailRequest Clone()
		{
			return null;
		}

		[Address(RVA="0x1F8D2F4", Offset="0x1F8D2F4", VA="0x1F8D2F4", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1079C0C", Offset="0x1079C0C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1F8D368", Offset="0x1F8D368", VA="0x1F8D368", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1079C1C", Offset="0x1079C1C")]
		public bool Equals(CampaignDetailRequest other)
		{
			return new bool();
		}

		[Address(RVA="0x1F8D3A4", Offset="0x1F8D3A4", VA="0x1F8D3A4", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1079C2C", Offset="0x1079C2C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1F8D5A4", Offset="0x1F8D5A4", VA="0x1F8D5A4", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1079C6C", Offset="0x1079C6C")]
		public void MergeFrom(CampaignDetailRequest other)
		{
		}

		[Address(RVA="0x1F8D5E4", Offset="0x1F8D5E4", VA="0x1F8D5E4", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1079C7C", Offset="0x1079C7C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1F8D40C", Offset="0x1F8D40C", VA="0x1F8D40C", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1079C3C", Offset="0x1079C3C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1F8D474", Offset="0x1F8D474", VA="0x1F8D474", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1079C4C", Offset="0x1079C4C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104F568", Offset="0x104F568")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static CampaignDetailRequest.<>c <>9;

			[Address(RVA="0x1F8D738", Offset="0x1F8D738", VA="0x1F8D738")]
			static <>c()
			{
			}

			[Address(RVA="0x1F8D79C", Offset="0x1F8D79C", VA="0x1F8D79C")]
			public <>c()
			{
			}

			[Address(RVA="0x1F8D7A4", Offset="0x1F8D7A4", VA="0x1F8D7A4")]
			internal CampaignDetailRequest <.cctor>b__25_0()
			{
				return null;
			}
		}
	}
}