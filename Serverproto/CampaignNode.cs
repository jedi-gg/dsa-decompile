using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class CampaignNode : IMessage<CampaignNode>, IMessage, IEquatable<CampaignNode>, IDeepCloneable<CampaignNode>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<CampaignNode> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int BattlesFieldNumber = 1;

		[FieldOffset(Offset="0x8")]
		private readonly static FieldCodec<BattleNode> _repeated_battles_codec;

		[FieldOffset(Offset="0x18")]
		private readonly RepeatedField<BattleNode> battles_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1094000", Offset="0x1094000")]
		public RepeatedField<BattleNode> Battles
		{
			[Address(RVA="0x1F915BC", Offset="0x1F915BC", VA="0x1F915BC")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1093FE0", Offset="0x1093FE0")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1F9130C", Offset="0x1F9130C", VA="0x1F9130C")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1093FD0", Offset="0x1093FD0")]
		public static MessageParser<CampaignNode> Parser
		{
			[Address(RVA="0x1F8FCC0", Offset="0x1F8FCC0", VA="0x1F8FCC0")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1093FF0", Offset="0x1093FF0")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1F913F8", Offset="0x1F913F8", VA="0x1F913F8", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1F91AA4", Offset="0x1F91AA4", VA="0x1F91AA4")]
		static CampaignNode()
		{
		}

		[Address(RVA="0x1F91454", Offset="0x1F91454", VA="0x1F91454")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107975C", Offset="0x107975C")]
		public CampaignNode()
		{
		}

		[Address(RVA="0x1F914C4", Offset="0x1F914C4", VA="0x1F914C4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107976C", Offset="0x107976C")]
		public CampaignNode(CampaignNode other)
		{
		}

		[Address(RVA="0x1F91874", Offset="0x1F91874", VA="0x1F91874", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10797DC", Offset="0x10797DC")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1F9155C", Offset="0x1F9155C", VA="0x1F9155C", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107977C", Offset="0x107977C")]
		public CampaignNode Clone()
		{
			return null;
		}

		[Address(RVA="0x1F915C4", Offset="0x1F915C4", VA="0x1F915C4", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107978C", Offset="0x107978C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1F91638", Offset="0x1F91638", VA="0x1F91638", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107979C", Offset="0x107979C")]
		public bool Equals(CampaignNode other)
		{
			return new bool();
		}

		[Address(RVA="0x1F916E8", Offset="0x1F916E8", VA="0x1F916E8", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10797AC", Offset="0x10797AC")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1F91930", Offset="0x1F91930", VA="0x1F91930", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10797EC", Offset="0x10797EC")]
		public void MergeFrom(CampaignNode other)
		{
		}

		[Address(RVA="0x1F919C0", Offset="0x1F919C0", VA="0x1F919C0", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10797FC", Offset="0x10797FC")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1F91748", Offset="0x1F91748", VA="0x1F91748", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10797BC", Offset="0x10797BC")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1F917B0", Offset="0x1F917B0", VA="0x1F917B0", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10797CC", Offset="0x10797CC")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104F508", Offset="0x104F508")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static CampaignNode.<>c <>9;

			[Address(RVA="0x1F91BC8", Offset="0x1F91BC8", VA="0x1F91BC8")]
			static <>c()
			{
			}

			[Address(RVA="0x1F91C2C", Offset="0x1F91C2C", VA="0x1F91C2C")]
			public <>c()
			{
			}

			[Address(RVA="0x1F91C34", Offset="0x1F91C34", VA="0x1F91C34")]
			internal CampaignNode <.cctor>b__25_0()
			{
				return null;
			}
		}
	}
}