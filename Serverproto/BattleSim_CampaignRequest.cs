using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class BattleSim_CampaignRequest : IMessage<BattleSim_CampaignRequest>, IMessage, IEquatable<BattleSim_CampaignRequest>, IDeepCloneable<BattleSim_CampaignRequest>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<BattleSim_CampaignRequest> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int CampaignIdFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private ulong campaignId_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1093B20", Offset="0x1093B20")]
		public ulong CampaignId
		{
			[Address(RVA="0x1DD0160", Offset="0x1DD0160", VA="0x1DD0160")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1DD0168", Offset="0x1DD0168", VA="0x1DD0168")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1093B00", Offset="0x1093B00")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1DCFF4C", Offset="0x1DCFF4C", VA="0x1DCFF4C")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1093AF0", Offset="0x1093AF0")]
		public static MessageParser<BattleSim_CampaignRequest> Parser
		{
			[Address(RVA="0x1DCF0FC", Offset="0x1DCF0FC", VA="0x1DCF0FC")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1093B10", Offset="0x1093B10")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1DD0038", Offset="0x1DD0038", VA="0x1DD0038", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1DD04DC", Offset="0x1DD04DC", VA="0x1DD04DC")]
		static BattleSim_CampaignRequest()
		{
		}

		[Address(RVA="0x1DD0094", Offset="0x1DD0094", VA="0x1DD0094")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1078E6C", Offset="0x1078E6C")]
		public BattleSim_CampaignRequest()
		{
		}

		[Address(RVA="0x1DD009C", Offset="0x1DD009C", VA="0x1DD009C")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1078E7C", Offset="0x1078E7C")]
		public BattleSim_CampaignRequest(BattleSim_CampaignRequest other)
		{
		}

		[Address(RVA="0x1DD0390", Offset="0x1DD0390", VA="0x1DD0390", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1078EEC", Offset="0x1078EEC")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1DD0100", Offset="0x1DD0100", VA="0x1DD0100", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1078E8C", Offset="0x1078E8C")]
		public BattleSim_CampaignRequest Clone()
		{
			return null;
		}

		[Address(RVA="0x1DD0170", Offset="0x1DD0170", VA="0x1DD0170", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1078E9C", Offset="0x1078E9C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1DD01E4", Offset="0x1DD01E4", VA="0x1DD01E4", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1078EAC", Offset="0x1078EAC")]
		public bool Equals(BattleSim_CampaignRequest other)
		{
			return new bool();
		}

		[Address(RVA="0x1DD0220", Offset="0x1DD0220", VA="0x1DD0220", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1078EBC", Offset="0x1078EBC")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1DD0420", Offset="0x1DD0420", VA="0x1DD0420", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1078EFC", Offset="0x1078EFC")]
		public void MergeFrom(BattleSim_CampaignRequest other)
		{
		}

		[Address(RVA="0x1DD0460", Offset="0x1DD0460", VA="0x1DD0460", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1078F0C", Offset="0x1078F0C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1DD0288", Offset="0x1DD0288", VA="0x1DD0288", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1078ECC", Offset="0x1078ECC")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1DD02F0", Offset="0x1DD02F0", VA="0x1DD02F0", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1078EDC", Offset="0x1078EDC")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104F428", Offset="0x104F428")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static BattleSim_CampaignRequest.<>c <>9;

			[Address(RVA="0x1DD05B4", Offset="0x1DD05B4", VA="0x1DD05B4")]
			static <>c()
			{
			}

			[Address(RVA="0x1DD0618", Offset="0x1DD0618", VA="0x1DD0618")]
			public <>c()
			{
			}

			[Address(RVA="0x1DD0620", Offset="0x1DD0620", VA="0x1DD0620")]
			internal BattleSim_CampaignRequest <.cctor>b__25_0()
			{
				return null;
			}
		}
	}
}