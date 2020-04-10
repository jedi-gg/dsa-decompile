using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class CoopFindMatchResponse : IMessage<CoopFindMatchResponse>, IMessage, IEquatable<CoopFindMatchResponse>, IDeepCloneable<CoopFindMatchResponse>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<CoopFindMatchResponse> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int PlayerTokenFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private string playerToken_;

		[FieldOffset(Offset="0x0")]
		public const int AllyFieldNumber = 2;

		[FieldOffset(Offset="0x20")]
		private Player ally_;

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
		public const int PlayerBattleIdFieldNumber = 8;

		[FieldOffset(Offset="0x40")]
		private ulong playerBattleId_;

		[FieldOffset(Offset="0x0")]
		public const int ResultFieldNumber = 9;

		[FieldOffset(Offset="0x48")]
		private MatchMakerResult result_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10921F0", Offset="0x10921F0")]
		public Player Ally
		{
			[Address(RVA="0x1EF0A94", Offset="0x1EF0A94", VA="0x1EF0A94")]
			get
			{
				return null;
			}
			[Address(RVA="0x1EF0A9C", Offset="0x1EF0A9C", VA="0x1EF0A9C")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1092210", Offset="0x1092210")]
		public string BattleId
		{
			[Address(RVA="0x1EF0BF4", Offset="0x1EF0BF4", VA="0x1EF0BF4")]
			get
			{
				return null;
			}
			[Address(RVA="0x1EF0BFC", Offset="0x1EF0BFC", VA="0x1EF0BFC")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1092200", Offset="0x1092200")]
		public string BattleServer
		{
			[Address(RVA="0x1EF0B7C", Offset="0x1EF0B7C", VA="0x1EF0B7C")]
			get
			{
				return null;
			}
			[Address(RVA="0x1EF0B84", Offset="0x1EF0B84", VA="0x1EF0B84")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1092220", Offset="0x1092220")]
		public ByteString BootstrapBytes
		{
			[Address(RVA="0x1EF0C6C", Offset="0x1EF0C6C", VA="0x1EF0C6C")]
			get
			{
				return null;
			}
			[Address(RVA="0x1EF0C74", Offset="0x1EF0C74", VA="0x1EF0C74")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10921C0", Offset="0x10921C0")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1EF0824", Offset="0x1EF0824", VA="0x1EF0824")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10921B0", Offset="0x10921B0")]
		public static MessageParser<CoopFindMatchResponse> Parser
		{
			[Address(RVA="0x1EF07BC", Offset="0x1EF07BC", VA="0x1EF07BC")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10921D0", Offset="0x10921D0")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1EF0914", Offset="0x1EF0914", VA="0x1EF0914", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1092230", Offset="0x1092230")]
		public ulong PlayerBattleId
		{
			[Address(RVA="0x1EF0CE4", Offset="0x1EF0CE4", VA="0x1EF0CE4")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1EF0CEC", Offset="0x1EF0CEC", VA="0x1EF0CEC")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10921E0", Offset="0x10921E0")]
		public string PlayerToken
		{
			[Address(RVA="0x1EF0B04", Offset="0x1EF0B04", VA="0x1EF0B04")]
			get
			{
				return null;
			}
			[Address(RVA="0x1EF0B0C", Offset="0x1EF0B0C", VA="0x1EF0B0C")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1092240", Offset="0x1092240")]
		public MatchMakerResult Result
		{
			[Address(RVA="0x1EF0CF4", Offset="0x1EF0CF4", VA="0x1EF0CF4")]
			get
			{
				return new MatchMakerResult();
			}
			[Address(RVA="0x1EF0CFC", Offset="0x1EF0CFC", VA="0x1EF0CFC")]
			set
			{
			}
		}

		[Address(RVA="0x1EF19C0", Offset="0x1EF19C0", VA="0x1EF19C0")]
		static CoopFindMatchResponse()
		{
		}

		[Address(RVA="0x1EF0970", Offset="0x1EF0970", VA="0x1EF0970")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107652C", Offset="0x107652C")]
		public CoopFindMatchResponse()
		{
		}

		[Address(RVA="0x1EF09F8", Offset="0x1EF09F8", VA="0x1EF09F8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107653C", Offset="0x107653C")]
		public CoopFindMatchResponse(CoopFindMatchResponse other)
		{
		}

		[Address(RVA="0x1EF13D0", Offset="0x1EF13D0", VA="0x1EF13D0", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10765AC", Offset="0x10765AC")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1EF0AA4", Offset="0x1EF0AA4", VA="0x1EF0AA4", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107654C", Offset="0x107654C")]
		public CoopFindMatchResponse Clone()
		{
			return null;
		}

		[Address(RVA="0x1EF0D04", Offset="0x1EF0D04", VA="0x1EF0D04", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107655C", Offset="0x107655C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1EF0D78", Offset="0x1EF0D78", VA="0x1EF0D78", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107656C", Offset="0x107656C")]
		public bool Equals(CoopFindMatchResponse other)
		{
			return new bool();
		}

		[Address(RVA="0x1EF0EA4", Offset="0x1EF0EA4", VA="0x1EF0EA4", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107657C", Offset="0x107657C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1EF1648", Offset="0x1EF1648", VA="0x1EF1648", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10765BC", Offset="0x10765BC")]
		public void MergeFrom(CoopFindMatchResponse other)
		{
		}

		[Address(RVA="0x1EF17C4", Offset="0x1EF17C4", VA="0x1EF17C4", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10765CC", Offset="0x10765CC")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1EF1058", Offset="0x1EF1058", VA="0x1EF1058", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107658C", Offset="0x107658C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1EF10C0", Offset="0x1EF10C0", VA="0x1EF10C0", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107659C", Offset="0x107659C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104F038", Offset="0x104F038")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static CoopFindMatchResponse.<>c <>9;

			[Address(RVA="0x1EF1A98", Offset="0x1EF1A98", VA="0x1EF1A98")]
			static <>c()
			{
			}

			[Address(RVA="0x1EF1AFC", Offset="0x1EF1AFC", VA="0x1EF1AFC")]
			public <>c()
			{
			}

			[Address(RVA="0x1EF1B04", Offset="0x1EF1B04", VA="0x1EF1B04")]
			internal CoopFindMatchResponse <.cctor>b__55_0()
			{
				return null;
			}
		}
	}
}