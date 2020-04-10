using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class BattleSim_PveRequest : IMessage<BattleSim_PveRequest>, IMessage, IEquatable<BattleSim_PveRequest>, IDeepCloneable<BattleSim_PveRequest>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<BattleSim_PveRequest> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int PlayerFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private BattleSim_Player player_;

		[FieldOffset(Offset="0x0")]
		public const int CampaignIdFieldNumber = 2;

		[FieldOffset(Offset="0x20")]
		private CampaignIdentifier campaignId_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1093EF0", Offset="0x1093EF0")]
		public CampaignIdentifier CampaignId
		{
			[Address(RVA="0x1DD30C0", Offset="0x1DD30C0", VA="0x1DD30C0")]
			get
			{
				return null;
			}
			[Address(RVA="0x1DD30C8", Offset="0x1DD30C8", VA="0x1DD30C8")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1093EC0", Offset="0x1093EC0")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1DD2ED4", Offset="0x1DD2ED4", VA="0x1DD2ED4")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1093EB0", Offset="0x1093EB0")]
		public static MessageParser<BattleSim_PveRequest> Parser
		{
			[Address(RVA="0x1DCF574", Offset="0x1DCF574", VA="0x1DCF574")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1093ED0", Offset="0x1093ED0")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1DD2FC0", Offset="0x1DD2FC0", VA="0x1DD2FC0", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1093EE0", Offset="0x1093EE0")]
		public BattleSim_Player Player
		{
			[Address(RVA="0x1DD30B0", Offset="0x1DD30B0", VA="0x1DD30B0")]
			get
			{
				return null;
			}
			[Address(RVA="0x1DD30B8", Offset="0x1DD30B8", VA="0x1DD30B8")]
			set
			{
			}
		}

		[Address(RVA="0x1DD36CC", Offset="0x1DD36CC", VA="0x1DD36CC")]
		static BattleSim_PveRequest()
		{
		}

		[Address(RVA="0x1DD301C", Offset="0x1DD301C", VA="0x1DD301C")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107954C", Offset="0x107954C")]
		public BattleSim_PveRequest()
		{
		}

		[Address(RVA="0x1DD3024", Offset="0x1DD3024", VA="0x1DD3024")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107955C", Offset="0x107955C")]
		public BattleSim_PveRequest(BattleSim_PveRequest other)
		{
		}

		[Address(RVA="0x1DD33EC", Offset="0x1DD33EC", VA="0x1DD33EC", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10795CC", Offset="0x10795CC")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1DD30D0", Offset="0x1DD30D0", VA="0x1DD30D0", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107956C", Offset="0x107956C")]
		public BattleSim_PveRequest Clone()
		{
			return null;
		}

		[Address(RVA="0x1DD3130", Offset="0x1DD3130", VA="0x1DD3130", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107957C", Offset="0x107957C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1DD31A4", Offset="0x1DD31A4", VA="0x1DD31A4", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107958C", Offset="0x107958C")]
		public bool Equals(BattleSim_PveRequest other)
		{
			return new bool();
		}

		[Address(RVA="0x1DD321C", Offset="0x1DD321C", VA="0x1DD321C", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107959C", Offset="0x107959C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1DD34C0", Offset="0x1DD34C0", VA="0x1DD34C0", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10795DC", Offset="0x10795DC")]
		public void MergeFrom(BattleSim_PveRequest other)
		{
		}

		[Address(RVA="0x1DD35BC", Offset="0x1DD35BC", VA="0x1DD35BC", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10795EC", Offset="0x10795EC")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1DD328C", Offset="0x1DD328C", VA="0x1DD328C", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10795AC", Offset="0x10795AC")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1DD32F4", Offset="0x1DD32F4", VA="0x1DD32F4", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10795BC", Offset="0x10795BC")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104F4D8", Offset="0x104F4D8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static BattleSim_PveRequest.<>c <>9;

			[Address(RVA="0x1DD37A4", Offset="0x1DD37A4", VA="0x1DD37A4")]
			static <>c()
			{
			}

			[Address(RVA="0x1DD3808", Offset="0x1DD3808", VA="0x1DD3808")]
			public <>c()
			{
			}

			[Address(RVA="0x1DD3810", Offset="0x1DD3810", VA="0x1DD3810")]
			internal BattleSim_PveRequest <.cctor>b__30_0()
			{
				return null;
			}
		}
	}
}