using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class BuyPveRefreshRequest : IMessage<BuyPveRefreshRequest>, IMessage, IEquatable<BuyPveRefreshRequest>, IDeepCloneable<BuyPveRefreshRequest>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<BuyPveRefreshRequest> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int CampaignIdentifierFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private Serverproto.CampaignIdentifier campaignIdentifier_;

		[FieldOffset(Offset="0x0")]
		public const int UseFreeClubSupportFieldNumber = 2;

		[FieldOffset(Offset="0x20")]
		private bool useFreeClubSupport_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10943D0", Offset="0x10943D0")]
		public Serverproto.CampaignIdentifier CampaignIdentifier
		{
			[Address(RVA="0x1F85F00", Offset="0x1F85F00", VA="0x1F85F00")]
			get
			{
				return null;
			}
			[Address(RVA="0x1F85F68", Offset="0x1F85F68", VA="0x1F85F68")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10943B0", Offset="0x10943B0")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1F85CC8", Offset="0x1F85CC8", VA="0x1F85CC8")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10943A0", Offset="0x10943A0")]
		public static MessageParser<BuyPveRefreshRequest> Parser
		{
			[Address(RVA="0x1F85C60", Offset="0x1F85C60", VA="0x1F85C60")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10943C0", Offset="0x10943C0")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1F85E1C", Offset="0x1F85E1C", VA="0x1F85E1C", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10943E0", Offset="0x10943E0")]
		public bool UseFreeClubSupport
		{
			[Address(RVA="0x1F85FD0", Offset="0x1F85FD0", VA="0x1F85FD0")]
			get
			{
				return new bool();
			}
			[Address(RVA="0x1F85FD8", Offset="0x1F85FD8", VA="0x1F85FD8")]
			set
			{
			}
		}

		[Address(RVA="0x1F8659C", Offset="0x1F8659C", VA="0x1F8659C")]
		static BuyPveRefreshRequest()
		{
		}

		[Address(RVA="0x1F85E78", Offset="0x1F85E78", VA="0x1F85E78")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1079D3C", Offset="0x1079D3C")]
		public BuyPveRefreshRequest()
		{
		}

		[Address(RVA="0x1F85E80", Offset="0x1F85E80", VA="0x1F85E80")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1079D4C", Offset="0x1079D4C")]
		public BuyPveRefreshRequest(BuyPveRefreshRequest other)
		{
		}

		[Address(RVA="0x1F862C4", Offset="0x1F862C4", VA="0x1F862C4", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1079DBC", Offset="0x1079DBC")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1F85F70", Offset="0x1F85F70", VA="0x1F85F70", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1079D5C", Offset="0x1079D5C")]
		public BuyPveRefreshRequest Clone()
		{
			return null;
		}

		[Address(RVA="0x1F85FE4", Offset="0x1F85FE4", VA="0x1F85FE4", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1079D6C", Offset="0x1079D6C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1F86058", Offset="0x1F86058", VA="0x1F86058", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1079D7C", Offset="0x1079D7C")]
		public bool Equals(BuyPveRefreshRequest other)
		{
			return new bool();
		}

		[Address(RVA="0x1F860DC", Offset="0x1F860DC", VA="0x1F860DC", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1079D8C", Offset="0x1079D8C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1F8636C", Offset="0x1F8636C", VA="0x1F8636C", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1079DCC", Offset="0x1079DCC")]
		public void MergeFrom(BuyPveRefreshRequest other)
		{
		}

		[Address(RVA="0x1F86494", Offset="0x1F86494", VA="0x1F86494", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1079DDC", Offset="0x1079DDC")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1F86160", Offset="0x1F86160", VA="0x1F86160", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1079D9C", Offset="0x1079D9C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1F861C8", Offset="0x1F861C8", VA="0x1F861C8", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1079DAC", Offset="0x1079DAC")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104F588", Offset="0x104F588")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static BuyPveRefreshRequest.<>c <>9;

			[Address(RVA="0x1F86674", Offset="0x1F86674", VA="0x1F86674")]
			static <>c()
			{
			}

			[Address(RVA="0x1F866D8", Offset="0x1F866D8", VA="0x1F866D8")]
			public <>c()
			{
			}

			[Address(RVA="0x1F866E0", Offset="0x1F866E0", VA="0x1F866E0")]
			internal BuyPveRefreshRequest <.cctor>b__30_0()
			{
				return null;
			}
		}
	}
}