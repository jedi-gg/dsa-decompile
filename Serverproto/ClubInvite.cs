using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class ClubInvite : IMessage<ClubInvite>, IMessage, IEquatable<ClubInvite>, IDeepCloneable<ClubInvite>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<ClubInvite> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int ClubIdFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private string clubId_;

		[FieldOffset(Offset="0x0")]
		public const int ClubNameFieldNumber = 2;

		[FieldOffset(Offset="0x20")]
		private string clubName_;

		[FieldOffset(Offset="0x0")]
		public const int ClubAvatarIdFieldNumber = 3;

		[FieldOffset(Offset="0x28")]
		private ulong clubAvatarId_;

		[FieldOffset(Offset="0x0")]
		public const int PlayerIdFieldNumber = 4;

		[FieldOffset(Offset="0x30")]
		private string playerId_;

		[FieldOffset(Offset="0x0")]
		public const int PlayerAvatarIdFieldNumber = 5;

		[FieldOffset(Offset="0x38")]
		private ulong playerAvatarId_;

		[FieldOffset(Offset="0x0")]
		public const int PlayerUsernameFieldNumber = 6;

		[FieldOffset(Offset="0x40")]
		private string playerUsername_;

		[FieldOffset(Offset="0x0")]
		public const int PlayerLevelFieldNumber = 7;

		[FieldOffset(Offset="0x48")]
		private ulong playerLevel_;

		[FieldOffset(Offset="0x0")]
		public const int SenderIdFieldNumber = 8;

		[FieldOffset(Offset="0x50")]
		private string senderId_;

		[FieldOffset(Offset="0x0")]
		public const int SenderAvatarIdFieldNumber = 9;

		[FieldOffset(Offset="0x58")]
		private ulong senderAvatarId_;

		[FieldOffset(Offset="0x0")]
		public const int SenderUsernameFieldNumber = 10;

		[FieldOffset(Offset="0x60")]
		private string senderUsername_;

		[FieldOffset(Offset="0x0")]
		public const int SenderLevelFieldNumber = 11;

		[FieldOffset(Offset="0x68")]
		private ulong senderLevel_;

		[FieldOffset(Offset="0x0")]
		public const int TimestampFieldNumber = 12;

		[FieldOffset(Offset="0x70")]
		private ulong timestamp_;

		[FieldOffset(Offset="0x0")]
		public const int ShowPlayerVipProfileBgFieldNumber = 13;

		[FieldOffset(Offset="0x78")]
		private bool showPlayerVipProfileBg_;

		[FieldOffset(Offset="0x0")]
		public const int TelemetryRefIdFieldNumber = 14;

		[FieldOffset(Offset="0x80")]
		private long telemetryRefId_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10968D0", Offset="0x10968D0")]
		public ulong ClubAvatarId
		{
			[Address(RVA="0x1FF73D4", Offset="0x1FF73D4", VA="0x1FF73D4")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1FF73DC", Offset="0x1FF73DC", VA="0x1FF73DC")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10968B0", Offset="0x10968B0")]
		public string ClubId
		{
			[Address(RVA="0x1FF72E4", Offset="0x1FF72E4", VA="0x1FF72E4")]
			get
			{
				return null;
			}
			[Address(RVA="0x1FF72EC", Offset="0x1FF72EC", VA="0x1FF72EC")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10968C0", Offset="0x10968C0")]
		public string ClubName
		{
			[Address(RVA="0x1FF735C", Offset="0x1FF735C", VA="0x1FF735C")]
			get
			{
				return null;
			}
			[Address(RVA="0x1FF7364", Offset="0x1FF7364", VA="0x1FF7364")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1096890", Offset="0x1096890")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1FF6F04", Offset="0x1FF6F04", VA="0x1FF6F04")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1096880", Offset="0x1096880")]
		public static MessageParser<ClubInvite> Parser
		{
			[Address(RVA="0x1FF6E9C", Offset="0x1FF6E9C", VA="0x1FF6E9C")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10968A0", Offset="0x10968A0")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1FF6FF4", Offset="0x1FF6FF4", VA="0x1FF6FF4", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10968F0", Offset="0x10968F0")]
		public ulong PlayerAvatarId
		{
			[Address(RVA="0x1FF745C", Offset="0x1FF745C", VA="0x1FF745C")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1FF7464", Offset="0x1FF7464", VA="0x1FF7464")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10968E0", Offset="0x10968E0")]
		public string PlayerId
		{
			[Address(RVA="0x1FF73E4", Offset="0x1FF73E4", VA="0x1FF73E4")]
			get
			{
				return null;
			}
			[Address(RVA="0x1FF73EC", Offset="0x1FF73EC", VA="0x1FF73EC")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1096910", Offset="0x1096910")]
		public ulong PlayerLevel
		{
			[Address(RVA="0x1FF74E4", Offset="0x1FF74E4", VA="0x1FF74E4")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1FF74EC", Offset="0x1FF74EC", VA="0x1FF74EC")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1096900", Offset="0x1096900")]
		public string PlayerUsername
		{
			[Address(RVA="0x1FF746C", Offset="0x1FF746C", VA="0x1FF746C")]
			get
			{
				return null;
			}
			[Address(RVA="0x1FF7474", Offset="0x1FF7474", VA="0x1FF7474")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1096930", Offset="0x1096930")]
		public ulong SenderAvatarId
		{
			[Address(RVA="0x1FF756C", Offset="0x1FF756C", VA="0x1FF756C")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1FF7574", Offset="0x1FF7574", VA="0x1FF7574")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1096920", Offset="0x1096920")]
		public string SenderId
		{
			[Address(RVA="0x1FF74F4", Offset="0x1FF74F4", VA="0x1FF74F4")]
			get
			{
				return null;
			}
			[Address(RVA="0x1FF74FC", Offset="0x1FF74FC", VA="0x1FF74FC")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1096950", Offset="0x1096950")]
		public ulong SenderLevel
		{
			[Address(RVA="0x1FF75F4", Offset="0x1FF75F4", VA="0x1FF75F4")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1FF75FC", Offset="0x1FF75FC", VA="0x1FF75FC")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1096940", Offset="0x1096940")]
		public string SenderUsername
		{
			[Address(RVA="0x1FF757C", Offset="0x1FF757C", VA="0x1FF757C")]
			get
			{
				return null;
			}
			[Address(RVA="0x1FF7584", Offset="0x1FF7584", VA="0x1FF7584")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1096970", Offset="0x1096970")]
		public bool ShowPlayerVipProfileBg
		{
			[Address(RVA="0x1FF7614", Offset="0x1FF7614", VA="0x1FF7614")]
			get
			{
				return new bool();
			}
			[Address(RVA="0x1FF761C", Offset="0x1FF761C", VA="0x1FF761C")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1096980", Offset="0x1096980")]
		public long TelemetryRefId
		{
			[Address(RVA="0x1FF7628", Offset="0x1FF7628", VA="0x1FF7628")]
			get
			{
				return new long();
			}
			[Address(RVA="0x1FF7630", Offset="0x1FF7630", VA="0x1FF7630")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1096960", Offset="0x1096960")]
		public ulong Timestamp
		{
			[Address(RVA="0x1FF7604", Offset="0x1FF7604", VA="0x1FF7604")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1FF760C", Offset="0x1FF760C", VA="0x1FF760C")]
			set
			{
			}
		}

		[Address(RVA="0x1FF899C", Offset="0x1FF899C", VA="0x1FF899C")]
		static ClubInvite()
		{
		}

		[Address(RVA="0x1FF7050", Offset="0x1FF7050", VA="0x1FF7050")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107EDAC", Offset="0x107EDAC")]
		public ClubInvite()
		{
		}

		[Address(RVA="0x1FF70B8", Offset="0x1FF70B8", VA="0x1FF70B8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107EDBC", Offset="0x107EDBC")]
		public ClubInvite(ClubInvite other)
		{
		}

		[Address(RVA="0x1FF80EC", Offset="0x1FF80EC", VA="0x1FF80EC", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107EE2C", Offset="0x107EE2C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1FF7284", Offset="0x1FF7284", VA="0x1FF7284", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107EDCC", Offset="0x107EDCC")]
		public ClubInvite Clone()
		{
			return null;
		}

		[Address(RVA="0x1FF7638", Offset="0x1FF7638", VA="0x1FF7638", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107EDDC", Offset="0x107EDDC")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1FF76AC", Offset="0x1FF76AC", VA="0x1FF76AC", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107EDEC", Offset="0x107EDEC")]
		public bool Equals(ClubInvite other)
		{
			return new bool();
		}

		[Address(RVA="0x1FF7804", Offset="0x1FF7804", VA="0x1FF7804", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107EDFC", Offset="0x107EDFC")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1FF8514", Offset="0x1FF8514", VA="0x1FF8514", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107EE3C", Offset="0x107EE3C")]
		public void MergeFrom(ClubInvite other)
		{
		}

		[Address(RVA="0x1FF86BC", Offset="0x1FF86BC", VA="0x1FF86BC", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107EE4C", Offset="0x107EE4C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1FF7AD8", Offset="0x1FF7AD8", VA="0x1FF7AD8", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107EE0C", Offset="0x107EE0C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1FF7B40", Offset="0x1FF7B40", VA="0x1FF7B40", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107EE1C", Offset="0x107EE1C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104FCE8", Offset="0x104FCE8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static ClubInvite.<>c <>9;

			[Address(RVA="0x1FF8A74", Offset="0x1FF8A74", VA="0x1FF8A74")]
			static <>c()
			{
			}

			[Address(RVA="0x1FF8AD8", Offset="0x1FF8AD8", VA="0x1FF8AD8")]
			public <>c()
			{
			}

			[Address(RVA="0x1FF8AE0", Offset="0x1FF8AE0", VA="0x1FF8AE0")]
			internal ClubInvite <.cctor>b__90_0()
			{
				return null;
			}
		}
	}
}