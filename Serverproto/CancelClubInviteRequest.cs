using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class CancelClubInviteRequest : IMessage<CancelClubInviteRequest>, IMessage, IEquatable<CancelClubInviteRequest>, IDeepCloneable<CancelClubInviteRequest>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<CancelClubInviteRequest> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int ClubIdFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private string clubId_;

		[FieldOffset(Offset="0x0")]
		public const int PlayerIdFieldNumber = 2;

		[FieldOffset(Offset="0x20")]
		private string playerId_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1094F30", Offset="0x1094F30")]
		public string ClubId
		{
			[Address(RVA="0x1F97094", Offset="0x1F97094", VA="0x1F97094")]
			get
			{
				return null;
			}
			[Address(RVA="0x1F9709C", Offset="0x1F9709C", VA="0x1F9709C")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1094F10", Offset="0x1094F10")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1F96E14", Offset="0x1F96E14", VA="0x1F96E14")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1094F00", Offset="0x1094F00")]
		public static MessageParser<CancelClubInviteRequest> Parser
		{
			[Address(RVA="0x1F96DAC", Offset="0x1F96DAC", VA="0x1F96DAC")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1094F20", Offset="0x1094F20")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1F96F04", Offset="0x1F96F04", VA="0x1F96F04", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1094F40", Offset="0x1094F40")]
		public string PlayerId
		{
			[Address(RVA="0x1F9710C", Offset="0x1F9710C", VA="0x1F9710C")]
			get
			{
				return null;
			}
			[Address(RVA="0x1F97114", Offset="0x1F97114", VA="0x1F97114")]
			set
			{
			}
		}

		[Address(RVA="0x1F97730", Offset="0x1F97730", VA="0x1F97730")]
		static CancelClubInviteRequest()
		{
		}

		[Address(RVA="0x1F96F60", Offset="0x1F96F60", VA="0x1F96F60")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107B3EC", Offset="0x107B3EC")]
		public CancelClubInviteRequest()
		{
		}

		[Address(RVA="0x1F96FB8", Offset="0x1F96FB8", VA="0x1F96FB8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107B3FC", Offset="0x107B3FC")]
		public CancelClubInviteRequest(CancelClubInviteRequest other)
		{
		}

		[Address(RVA="0x1F974D0", Offset="0x1F974D0", VA="0x1F974D0", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107B46C", Offset="0x107B46C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1F97034", Offset="0x1F97034", VA="0x1F97034", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107B40C", Offset="0x107B40C")]
		public CancelClubInviteRequest Clone()
		{
			return null;
		}

		[Address(RVA="0x1F97184", Offset="0x1F97184", VA="0x1F97184", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107B41C", Offset="0x107B41C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1F971F8", Offset="0x1F971F8", VA="0x1F971F8", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107B42C", Offset="0x107B42C")]
		public bool Equals(CancelClubInviteRequest other)
		{
			return new bool();
		}

		[Address(RVA="0x1F97270", Offset="0x1F97270", VA="0x1F97270", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107B43C", Offset="0x107B43C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1F975E4", Offset="0x1F975E4", VA="0x1F975E4", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107B47C", Offset="0x107B47C")]
		public void MergeFrom(CancelClubInviteRequest other)
		{
		}

		[Address(RVA="0x1F9767C", Offset="0x1F9767C", VA="0x1F9767C", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107B48C", Offset="0x107B48C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1F97340", Offset="0x1F97340", VA="0x1F97340", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107B44C", Offset="0x107B44C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1F973A8", Offset="0x1F973A8", VA="0x1F973A8", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107B45C", Offset="0x107B45C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104F798", Offset="0x104F798")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static CancelClubInviteRequest.<>c <>9;

			[Address(RVA="0x1F97808", Offset="0x1F97808", VA="0x1F97808")]
			static <>c()
			{
			}

			[Address(RVA="0x1F9786C", Offset="0x1F9786C", VA="0x1F9786C")]
			public <>c()
			{
			}

			[Address(RVA="0x1F97874", Offset="0x1F97874", VA="0x1F97874")]
			internal CancelClubInviteRequest <.cctor>b__30_0()
			{
				return null;
			}
		}
	}
}