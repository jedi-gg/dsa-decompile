using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class CampaignProgress : IMessage<CampaignProgress>, IMessage, IEquatable<CampaignProgress>, IDeepCloneable<CampaignProgress>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<CampaignProgress> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int CampaignIdentifierFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private Serverproto.CampaignIdentifier campaignIdentifier_;

		[FieldOffset(Offset="0x0")]
		public const int StarLevelFieldNumber = 2;

		[FieldOffset(Offset="0x20")]
		private ulong starLevel_;

		[FieldOffset(Offset="0x0")]
		public const int LimitedAttemptResetTimeFieldNumber = 3;

		[FieldOffset(Offset="0x28")]
		private ulong limitedAttemptResetTime_;

		[FieldOffset(Offset="0x0")]
		public const int LimitedAttemptCountFieldNumber = 4;

		[FieldOffset(Offset="0x30")]
		private ulong limitedAttemptCount_;

		[FieldOffset(Offset="0x0")]
		public const int LimitedAttemptRefreshCountFieldNumber = 5;

		[FieldOffset(Offset="0x38")]
		private ulong limitedAttemptRefreshCount_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1093F80", Offset="0x1093F80")]
		public Serverproto.CampaignIdentifier CampaignIdentifier
		{
			[Address(RVA="0x1F91ED4", Offset="0x1F91ED4", VA="0x1F91ED4")]
			get
			{
				return null;
			}
			[Address(RVA="0x1F91EDC", Offset="0x1F91EDC", VA="0x1F91EDC")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1093F60", Offset="0x1093F60")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1F91CF4", Offset="0x1F91CF4", VA="0x1F91CF4")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1093FB0", Offset="0x1093FB0")]
		public ulong LimitedAttemptCount
		{
			[Address(RVA="0x1F91F04", Offset="0x1F91F04", VA="0x1F91F04")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1F91F0C", Offset="0x1F91F0C", VA="0x1F91F0C")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1093FC0", Offset="0x1093FC0")]
		public ulong LimitedAttemptRefreshCount
		{
			[Address(RVA="0x1F91F14", Offset="0x1F91F14", VA="0x1F91F14")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1F91F1C", Offset="0x1F91F1C", VA="0x1F91F1C")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1093FA0", Offset="0x1093FA0")]
		public ulong LimitedAttemptResetTime
		{
			[Address(RVA="0x1F91EF4", Offset="0x1F91EF4", VA="0x1F91EF4")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1F91EFC", Offset="0x1F91EFC", VA="0x1F91EFC")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1093F50", Offset="0x1093F50")]
		public static MessageParser<CampaignProgress> Parser
		{
			[Address(RVA="0x1F91C8C", Offset="0x1F91C8C", VA="0x1F91C8C")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1093F70", Offset="0x1093F70")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1F91DE0", Offset="0x1F91DE0", VA="0x1F91DE0", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1093F90", Offset="0x1093F90")]
		public ulong StarLevel
		{
			[Address(RVA="0x1F91EE4", Offset="0x1F91EE4", VA="0x1F91EE4")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1F91EEC", Offset="0x1F91EEC", VA="0x1F91EEC")]
			set
			{
			}
		}

		[Address(RVA="0x1F92684", Offset="0x1F92684", VA="0x1F92684")]
		static CampaignProgress()
		{
		}

		[Address(RVA="0x1F86EF0", Offset="0x1F86EF0", VA="0x1F86EF0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10796AC", Offset="0x10796AC")]
		public CampaignProgress()
		{
		}

		[Address(RVA="0x1F91E3C", Offset="0x1F91E3C", VA="0x1F91E3C")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10796BC", Offset="0x10796BC")]
		public CampaignProgress(CampaignProgress other)
		{
		}

		[Address(RVA="0x1F92378", Offset="0x1F92378", VA="0x1F92378", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107972C", Offset="0x107972C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1F86998", Offset="0x1F86998", VA="0x1F86998", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10796CC", Offset="0x10796CC")]
		public CampaignProgress Clone()
		{
			return null;
		}

		[Address(RVA="0x1F91F24", Offset="0x1F91F24", VA="0x1F91F24", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10796DC", Offset="0x10796DC")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1F91F98", Offset="0x1F91F98", VA="0x1F91F98", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10796EC", Offset="0x10796EC")]
		public bool Equals(CampaignProgress other)
		{
			return new bool();
		}

		[Address(RVA="0x1F9203C", Offset="0x1F9203C", VA="0x1F9203C", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10796FC", Offset="0x10796FC")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1F86EF8", Offset="0x1F86EF8", VA="0x1F86EF8", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107973C", Offset="0x107973C")]
		public void MergeFrom(CampaignProgress other)
		{
		}

		[Address(RVA="0x1F92500", Offset="0x1F92500", VA="0x1F92500", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107974C", Offset="0x107974C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1F92110", Offset="0x1F92110", VA="0x1F92110", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107970C", Offset="0x107970C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1F92178", Offset="0x1F92178", VA="0x1F92178", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107971C", Offset="0x107971C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104F4F8", Offset="0x104F4F8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static CampaignProgress.<>c <>9;

			[Address(RVA="0x1F9275C", Offset="0x1F9275C", VA="0x1F9275C")]
			static <>c()
			{
			}

			[Address(RVA="0x1F927C0", Offset="0x1F927C0", VA="0x1F927C0")]
			public <>c()
			{
			}

			[Address(RVA="0x1F927C8", Offset="0x1F927C8", VA="0x1F927C8")]
			internal CampaignProgress <.cctor>b__45_0()
			{
				return null;
			}
		}
	}
}