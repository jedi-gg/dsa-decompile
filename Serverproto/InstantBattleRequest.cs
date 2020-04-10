using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class InstantBattleRequest : IMessage<InstantBattleRequest>, IMessage, IEquatable<InstantBattleRequest>, IDeepCloneable<InstantBattleRequest>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<InstantBattleRequest> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int CampaignIdentifierFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private Serverproto.CampaignIdentifier campaignIdentifier_;

		[FieldOffset(Offset="0x0")]
		public const int NumBattlesFieldNumber = 2;

		[FieldOffset(Offset="0x20")]
		private ulong numBattles_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1092B70", Offset="0x1092B70")]
		public Serverproto.CampaignIdentifier CampaignIdentifier
		{
			[Address(RVA="0x18E6494", Offset="0x18E6494", VA="0x18E6494")]
			get
			{
				return null;
			}
			[Address(RVA="0x18E649C", Offset="0x18E649C", VA="0x18E649C")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1092B50", Offset="0x1092B50")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x18E62BC", Offset="0x18E62BC", VA="0x18E62BC")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1092B80", Offset="0x1092B80")]
		public ulong NumBattles
		{
			[Address(RVA="0x18E6504", Offset="0x18E6504", VA="0x18E6504")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x18E650C", Offset="0x18E650C", VA="0x18E650C")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1092B40", Offset="0x1092B40")]
		public static MessageParser<InstantBattleRequest> Parser
		{
			[Address(RVA="0x18E6254", Offset="0x18E6254", VA="0x18E6254")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1092B60", Offset="0x1092B60")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x18E63AC", Offset="0x18E63AC", VA="0x18E63AC", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x18E6A74", Offset="0x18E6A74", VA="0x18E6A74")]
		static InstantBattleRequest()
		{
		}

		[Address(RVA="0x18E6408", Offset="0x18E6408", VA="0x18E6408")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10775AC", Offset="0x10775AC")]
		public InstantBattleRequest()
		{
		}

		[Address(RVA="0x18E6410", Offset="0x18E6410", VA="0x18E6410")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10775BC", Offset="0x10775BC")]
		public InstantBattleRequest(InstantBattleRequest other)
		{
		}

		[Address(RVA="0x18E67DC", Offset="0x18E67DC", VA="0x18E67DC", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107762C", Offset="0x107762C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x18E64A4", Offset="0x18E64A4", VA="0x18E64A4", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10775CC", Offset="0x10775CC")]
		public InstantBattleRequest Clone()
		{
			return null;
		}

		[Address(RVA="0x18E6514", Offset="0x18E6514", VA="0x18E6514", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10775DC", Offset="0x10775DC")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x18E6588", Offset="0x18E6588", VA="0x18E6588", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10775EC", Offset="0x10775EC")]
		public bool Equals(InstantBattleRequest other)
		{
			return new bool();
		}

		[Address(RVA="0x18E65FC", Offset="0x18E65FC", VA="0x18E65FC", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10775FC", Offset="0x10775FC")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x18E68B0", Offset="0x18E68B0", VA="0x18E68B0", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107763C", Offset="0x107763C")]
		public void MergeFrom(InstantBattleRequest other)
		{
		}

		[Address(RVA="0x18E6970", Offset="0x18E6970", VA="0x18E6970", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107764C", Offset="0x107764C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x18E667C", Offset="0x18E667C", VA="0x18E667C", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107760C", Offset="0x107760C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x18E66E4", Offset="0x18E66E4", VA="0x18E66E4", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107761C", Offset="0x107761C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104F1B8", Offset="0x104F1B8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static InstantBattleRequest.<>c <>9;

			[Address(RVA="0x18E6B4C", Offset="0x18E6B4C", VA="0x18E6B4C")]
			static <>c()
			{
			}

			[Address(RVA="0x18E6BB0", Offset="0x18E6BB0", VA="0x18E6BB0")]
			public <>c()
			{
			}

			[Address(RVA="0x18E6BB8", Offset="0x18E6BB8", VA="0x18E6BB8")]
			internal InstantBattleRequest <.cctor>b__30_0()
			{
				return null;
			}
		}
	}
}