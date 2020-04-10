using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class HomeBattleSelectResponse : IMessage<HomeBattleSelectResponse>, IMessage, IEquatable<HomeBattleSelectResponse>, IDeepCloneable<HomeBattleSelectResponse>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<HomeBattleSelectResponse> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int BonusLootExpireTimestampFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private ulong bonusLootExpireTimestamp_;

		[FieldOffset(Offset="0x0")]
		public const int BonusLootGameModeIdsFieldNumber = 2;

		[FieldOffset(Offset="0x8")]
		private readonly static FieldCodec<ulong> _repeated_bonusLootGameModeIds_codec;

		[FieldOffset(Offset="0x20")]
		private readonly RepeatedField<ulong> bonusLootGameModeIds_;

		[FieldOffset(Offset="0x0")]
		public const int PvpHasBonusLootFieldNumber = 3;

		[FieldOffset(Offset="0x28")]
		private bool pvpHasBonusLoot_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10982A0", Offset="0x10982A0")]
		public ulong BonusLootExpireTimestamp
		{
			[Address(RVA="0x1BAEA44", Offset="0x1BAEA44", VA="0x1BAEA44")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1BAEA4C", Offset="0x1BAEA4C", VA="0x1BAEA4C")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10982B0", Offset="0x10982B0")]
		public RepeatedField<ulong> BonusLootGameModeIds
		{
			[Address(RVA="0x1BAEA54", Offset="0x1BAEA54", VA="0x1BAEA54")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1098280", Offset="0x1098280")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1BAE768", Offset="0x1BAE768", VA="0x1BAE768")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1098270", Offset="0x1098270")]
		public static MessageParser<HomeBattleSelectResponse> Parser
		{
			[Address(RVA="0x1BAE700", Offset="0x1BAE700", VA="0x1BAE700")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1098290", Offset="0x1098290")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1BAE858", Offset="0x1BAE858", VA="0x1BAE858", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10982C0", Offset="0x10982C0")]
		public bool PvpHasBonusLoot
		{
			[Address(RVA="0x1BAEA5C", Offset="0x1BAEA5C", VA="0x1BAEA5C")]
			get
			{
				return new bool();
			}
			[Address(RVA="0x1BAEA64", Offset="0x1BAEA64", VA="0x1BAEA64")]
			set
			{
			}
		}

		[Address(RVA="0x1BAF158", Offset="0x1BAF158", VA="0x1BAF158")]
		static HomeBattleSelectResponse()
		{
		}

		[Address(RVA="0x1BAE8B4", Offset="0x1BAE8B4", VA="0x1BAE8B4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108158C", Offset="0x108158C")]
		public HomeBattleSelectResponse()
		{
		}

		[Address(RVA="0x1BAE924", Offset="0x1BAE924", VA="0x1BAE924")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108159C", Offset="0x108159C")]
		public HomeBattleSelectResponse(HomeBattleSelectResponse other)
		{
		}

		[Address(RVA="0x1BAEE58", Offset="0x1BAEE58", VA="0x1BAEE58", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108160C", Offset="0x108160C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1BAE9E4", Offset="0x1BAE9E4", VA="0x1BAE9E4", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10815AC", Offset="0x10815AC")]
		public HomeBattleSelectResponse Clone()
		{
			return null;
		}

		[Address(RVA="0x1BAEA70", Offset="0x1BAEA70", VA="0x1BAEA70", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10815BC", Offset="0x10815BC")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1BAEAE4", Offset="0x1BAEAE4", VA="0x1BAEAE4", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10815CC", Offset="0x10815CC")]
		public bool Equals(HomeBattleSelectResponse other)
		{
			return new bool();
		}

		[Address(RVA="0x1BAEBC4", Offset="0x1BAEBC4", VA="0x1BAEBC4", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10815DC", Offset="0x10815DC")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1BAEF64", Offset="0x1BAEF64", VA="0x1BAEF64", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108161C", Offset="0x108161C")]
		public void MergeFrom(HomeBattleSelectResponse other)
		{
		}

		[Address(RVA="0x1BAF00C", Offset="0x1BAF00C", VA="0x1BAF00C", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108162C", Offset="0x108162C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1BAEC78", Offset="0x1BAEC78", VA="0x1BAEC78", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10815EC", Offset="0x10815EC")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1BAECE0", Offset="0x1BAECE0", VA="0x1BAECE0", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10815FC", Offset="0x10815FC")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1050088", Offset="0x1050088")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static HomeBattleSelectResponse.<>c <>9;

			[Address(RVA="0x1CFDDBC", Offset="0x1CFDDBC", VA="0x1CFDDBC")]
			static <>c()
			{
			}

			[Address(RVA="0x1CFDE20", Offset="0x1CFDE20", VA="0x1CFDE20")]
			public <>c()
			{
			}

			[Address(RVA="0x1CFDE28", Offset="0x1CFDE28", VA="0x1CFDE28")]
			internal HomeBattleSelectResponse <.cctor>b__35_0()
			{
				return null;
			}
		}
	}
}