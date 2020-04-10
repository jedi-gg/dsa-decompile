using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class BattleInvite : IMessage<BattleInvite>, IMessage, IEquatable<BattleInvite>, IDeepCloneable<BattleInvite>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<BattleInvite> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int SenderPublicIdFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private string senderPublicId_;

		[FieldOffset(Offset="0x0")]
		public const int FriendPublicIdFieldNumber = 2;

		[FieldOffset(Offset="0x20")]
		private string friendPublicId_;

		[FieldOffset(Offset="0x0")]
		public const int MatchTypeFieldNumber = 3;

		[FieldOffset(Offset="0x28")]
		private Serverproto.MatchType matchType_;

		[FieldOffset(Offset="0x0")]
		public const int CampaignIdentifierFieldNumber = 4;

		[FieldOffset(Offset="0x30")]
		private Serverproto.CampaignIdentifier campaignIdentifier_;

		[FieldOffset(Offset="0x0")]
		public const int ExpireTimestampFieldNumber = 5;

		[FieldOffset(Offset="0x38")]
		private ulong expireTimestamp_;

		[FieldOffset(Offset="0x0")]
		public const int EventIdFieldNumber = 6;

		[FieldOffset(Offset="0x40")]
		private EventIdentifier eventId_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1091D30", Offset="0x1091D30")]
		[Attribute(Name="ObsoleteAttribute", RVA="0x1091D30", Offset="0x1091D30")]
		public Serverproto.CampaignIdentifier CampaignIdentifier
		{
			[Address(RVA="0x1E71E9C", Offset="0x1E71E9C", VA="0x1E71E9C")]
			get
			{
				return null;
			}
			[Address(RVA="0x1E71EA4", Offset="0x1E71EA4", VA="0x1E71EA4")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1091CE0", Offset="0x1091CE0")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1E71C30", Offset="0x1E71C30", VA="0x1E71C30")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1091D78", Offset="0x1091D78")]
		public EventIdentifier EventId
		{
			[Address(RVA="0x1E71EAC", Offset="0x1E71EAC", VA="0x1E71EAC")]
			get
			{
				return null;
			}
			[Address(RVA="0x1E71EB4", Offset="0x1E71EB4", VA="0x1E71EB4")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1091D68", Offset="0x1091D68")]
		public ulong ExpireTimestamp
		{
			[Address(RVA="0x1E7201C", Offset="0x1E7201C", VA="0x1E7201C")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1E72024", Offset="0x1E72024", VA="0x1E72024")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1091D10", Offset="0x1091D10")]
		public string FriendPublicId
		{
			[Address(RVA="0x1E71F94", Offset="0x1E71F94", VA="0x1E71F94")]
			get
			{
				return null;
			}
			[Address(RVA="0x1E71F9C", Offset="0x1E71F9C", VA="0x1E71F9C")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1091D20", Offset="0x1091D20")]
		public Serverproto.MatchType MatchType
		{
			[Address(RVA="0x1E7200C", Offset="0x1E7200C", VA="0x1E7200C")]
			get
			{
				return new Serverproto.MatchType();
			}
			[Address(RVA="0x1E72014", Offset="0x1E72014", VA="0x1E72014")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1091CD0", Offset="0x1091CD0")]
		public static MessageParser<BattleInvite> Parser
		{
			[Address(RVA="0x1E71BC8", Offset="0x1E71BC8", VA="0x1E71BC8")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1091CF0", Offset="0x1091CF0")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1E71D20", Offset="0x1E71D20", VA="0x1E71D20", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1091D00", Offset="0x1091D00")]
		public string SenderPublicId
		{
			[Address(RVA="0x1E71F1C", Offset="0x1E71F1C", VA="0x1E71F1C")]
			get
			{
				return null;
			}
			[Address(RVA="0x1E71F24", Offset="0x1E71F24", VA="0x1E71F24")]
			set
			{
			}
		}

		[Address(RVA="0x1E72AD8", Offset="0x1E72AD8", VA="0x1E72AD8")]
		static BattleInvite()
		{
		}

		[Address(RVA="0x1E71D7C", Offset="0x1E71D7C", VA="0x1E71D7C")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1075D9C", Offset="0x1075D9C")]
		public BattleInvite()
		{
		}

		[Address(RVA="0x1E71DD4", Offset="0x1E71DD4", VA="0x1E71DD4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1075DAC", Offset="0x1075DAC")]
		public BattleInvite(BattleInvite other)
		{
		}

		[Address(RVA="0x1E72594", Offset="0x1E72594", VA="0x1E72594", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1075E1C", Offset="0x1075E1C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1E71EBC", Offset="0x1E71EBC", VA="0x1E71EBC", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1075DBC", Offset="0x1075DBC")]
		public BattleInvite Clone()
		{
			return null;
		}

		[Address(RVA="0x1E7202C", Offset="0x1E7202C", VA="0x1E7202C", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1075DCC", Offset="0x1075DCC")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1E720A0", Offset="0x1E720A0", VA="0x1E720A0", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1075DDC", Offset="0x1075DDC")]
		public bool Equals(BattleInvite other)
		{
			return new bool();
		}

		[Address(RVA="0x1E72160", Offset="0x1E72160", VA="0x1E72160", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1075DEC", Offset="0x1075DEC")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1E72798", Offset="0x1E72798", VA="0x1E72798", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1075E2C", Offset="0x1075E2C")]
		public void MergeFrom(BattleInvite other)
		{
		}

		[Address(RVA="0x1E7290C", Offset="0x1E7290C", VA="0x1E7290C", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1075E3C", Offset="0x1075E3C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1E722A4", Offset="0x1E722A4", VA="0x1E722A4", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1075DFC", Offset="0x1075DFC")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1E7230C", Offset="0x1E7230C", VA="0x1E7230C", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1075E0C", Offset="0x1075E0C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104EF88", Offset="0x104EF88")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static BattleInvite.<>c <>9;

			[Address(RVA="0x1E72BB0", Offset="0x1E72BB0", VA="0x1E72BB0")]
			static <>c()
			{
			}

			[Address(RVA="0x1E72C14", Offset="0x1E72C14", VA="0x1E72C14")]
			public <>c()
			{
			}

			[Address(RVA="0x1E72C1C", Offset="0x1E72C1C", VA="0x1E72C1C")]
			internal BattleInvite <.cctor>b__50_0()
			{
				return null;
			}
		}
	}
}