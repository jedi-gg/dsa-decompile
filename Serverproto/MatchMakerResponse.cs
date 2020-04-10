using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class MatchMakerResponse : IMessage<MatchMakerResponse>, IMessage, IEquatable<MatchMakerResponse>, IDeepCloneable<MatchMakerResponse>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<MatchMakerResponse> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int PlayerTokenFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private string playerToken_;

		[FieldOffset(Offset="0x0")]
		public const int OtherPlayerIdsFieldNumber = 2;

		[FieldOffset(Offset="0x8")]
		private readonly static FieldCodec<string> _repeated_otherPlayerIds_codec;

		[FieldOffset(Offset="0x20")]
		private readonly RepeatedField<string> otherPlayerIds_;

		[FieldOffset(Offset="0x0")]
		public const int BattleServerFieldNumber = 3;

		[FieldOffset(Offset="0x28")]
		private string battleServer_;

		[FieldOffset(Offset="0x0")]
		public const int BattleIdFieldNumber = 4;

		[FieldOffset(Offset="0x30")]
		private string battleId_;

		[FieldOffset(Offset="0x0")]
		public const int BootstrapBytesFieldNumber = 5;

		[FieldOffset(Offset="0x38")]
		private ByteString bootstrapBytes_;

		[FieldOffset(Offset="0x0")]
		public const int GamedataVersionFieldNumber = 6;

		[FieldOffset(Offset="0x40")]
		private string gamedataVersion_;

		[FieldOffset(Offset="0x0")]
		public const int EndBattleAuthTokenFieldNumber = 7;

		[FieldOffset(Offset="0x48")]
		private string endBattleAuthToken_;

		[FieldOffset(Offset="0x0")]
		public const int ErrorMessageFieldNumber = 8;

		[FieldOffset(Offset="0x50")]
		private string errorMessage_;

		[FieldOffset(Offset="0x0")]
		public const int PlayerBattleIdFieldNumber = 9;

		[FieldOffset(Offset="0x58")]
		private ulong playerBattleId_;

		[FieldOffset(Offset="0x0")]
		public const int ResultFieldNumber = 10;

		[FieldOffset(Offset="0x60")]
		private MatchMakerResult result_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10927B0", Offset="0x10927B0")]
		public string BattleId
		{
			[Address(RVA="0x1A1E5B8", Offset="0x1A1E5B8", VA="0x1A1E5B8")]
			get
			{
				return null;
			}
			[Address(RVA="0x1A1E5C0", Offset="0x1A1E5C0", VA="0x1A1E5C0")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10927A0", Offset="0x10927A0")]
		public string BattleServer
		{
			[Address(RVA="0x1A1E540", Offset="0x1A1E540", VA="0x1A1E540")]
			get
			{
				return null;
			}
			[Address(RVA="0x1A1E548", Offset="0x1A1E548", VA="0x1A1E548")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10927C0", Offset="0x10927C0")]
		public ByteString BootstrapBytes
		{
			[Address(RVA="0x1A1E630", Offset="0x1A1E630", VA="0x1A1E630")]
			get
			{
				return null;
			}
			[Address(RVA="0x1A1E638", Offset="0x1A1E638", VA="0x1A1E638")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1092760", Offset="0x1092760")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1A1E158", Offset="0x1A1E158", VA="0x1A1E158")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10927E0", Offset="0x10927E0")]
		public string EndBattleAuthToken
		{
			[Address(RVA="0x1A1E720", Offset="0x1A1E720", VA="0x1A1E720")]
			get
			{
				return null;
			}
			[Address(RVA="0x1A1E728", Offset="0x1A1E728", VA="0x1A1E728")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10927F0", Offset="0x10927F0")]
		public string ErrorMessage
		{
			[Address(RVA="0x1A1E798", Offset="0x1A1E798", VA="0x1A1E798")]
			get
			{
				return null;
			}
			[Address(RVA="0x1A1E7A0", Offset="0x1A1E7A0", VA="0x1A1E7A0")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10927D0", Offset="0x10927D0")]
		public string GamedataVersion
		{
			[Address(RVA="0x1A1E6A8", Offset="0x1A1E6A8", VA="0x1A1E6A8")]
			get
			{
				return null;
			}
			[Address(RVA="0x1A1E6B0", Offset="0x1A1E6B0", VA="0x1A1E6B0")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1092790", Offset="0x1092790")]
		public RepeatedField<string> OtherPlayerIds
		{
			[Address(RVA="0x1A1E538", Offset="0x1A1E538", VA="0x1A1E538")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1092750", Offset="0x1092750")]
		public static MessageParser<MatchMakerResponse> Parser
		{
			[Address(RVA="0x1A1E0F0", Offset="0x1A1E0F0", VA="0x1A1E0F0")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1092770", Offset="0x1092770")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1A1E248", Offset="0x1A1E248", VA="0x1A1E248", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1092800", Offset="0x1092800")]
		public ulong PlayerBattleId
		{
			[Address(RVA="0x1A1E810", Offset="0x1A1E810", VA="0x1A1E810")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1A1E818", Offset="0x1A1E818", VA="0x1A1E818")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1092780", Offset="0x1092780")]
		public string PlayerToken
		{
			[Address(RVA="0x1A1E4C0", Offset="0x1A1E4C0", VA="0x1A1E4C0")]
			get
			{
				return null;
			}
			[Address(RVA="0x1A1E4C8", Offset="0x1A1E4C8", VA="0x1A1E4C8")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1092810", Offset="0x1092810")]
		public MatchMakerResult Result
		{
			[Address(RVA="0x1A1E820", Offset="0x1A1E820", VA="0x1A1E820")]
			get
			{
				return new MatchMakerResult();
			}
			[Address(RVA="0x1A1E828", Offset="0x1A1E828", VA="0x1A1E828")]
			set
			{
			}
		}

		[Address(RVA="0x1A1F9C0", Offset="0x1A1F9C0", VA="0x1A1F9C0")]
		static MatchMakerResponse()
		{
		}

		[Address(RVA="0x1A1E2A4", Offset="0x1A1E2A4", VA="0x1A1E2A4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1076E1C", Offset="0x1076E1C")]
		public MatchMakerResponse()
		{
		}

		[Address(RVA="0x1A1E368", Offset="0x1A1E368", VA="0x1A1E368")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1076E2C", Offset="0x1076E2C")]
		public MatchMakerResponse(MatchMakerResponse other)
		{
		}

		[Address(RVA="0x1A1F1A8", Offset="0x1A1F1A8", VA="0x1A1F1A8", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1076E9C", Offset="0x1076E9C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1A1E460", Offset="0x1A1E460", VA="0x1A1E460", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1076E3C", Offset="0x1076E3C")]
		public MatchMakerResponse Clone()
		{
			return null;
		}

		[Address(RVA="0x1A1E830", Offset="0x1A1E830", VA="0x1A1E830", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1076E4C", Offset="0x1076E4C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1A1E8A4", Offset="0x1A1E8A4", VA="0x1A1E8A4", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1076E5C", Offset="0x1076E5C")]
		public bool Equals(MatchMakerResponse other)
		{
			return new bool();
		}

		[Address(RVA="0x1A1EA28", Offset="0x1A1EA28", VA="0x1A1EA28", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1076E6C", Offset="0x1076E6C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1A1F548", Offset="0x1A1F548", VA="0x1A1F548", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1076EAC", Offset="0x1076EAC")]
		public void MergeFrom(MatchMakerResponse other)
		{
		}

		[Address(RVA="0x1A1F724", Offset="0x1A1F724", VA="0x1A1F724", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1076EBC", Offset="0x1076EBC")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1A1ECBC", Offset="0x1A1ECBC", VA="0x1A1ECBC", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1076E7C", Offset="0x1076E7C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1A1ED24", Offset="0x1A1ED24", VA="0x1A1ED24", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1076E8C", Offset="0x1076E8C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104F108", Offset="0x104F108")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static MatchMakerResponse.<>c <>9;

			[Address(RVA="0x1A1FAB0", Offset="0x1A1FAB0", VA="0x1A1FAB0")]
			static <>c()
			{
			}

			[Address(RVA="0x1A1FB14", Offset="0x1A1FB14", VA="0x1A1FB14")]
			public <>c()
			{
			}

			[Address(RVA="0x1A1FB1C", Offset="0x1A1FB1C", VA="0x1A1FB1C")]
			internal MatchMakerResponse <.cctor>b__70_0()
			{
				return null;
			}
		}
	}
}