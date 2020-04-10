using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class KothLobbyResponse : IMessage<KothLobbyResponse>, IMessage, IEquatable<KothLobbyResponse>, IDeepCloneable<KothLobbyResponse>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<KothLobbyResponse> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int AttemptsRemainingFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private ulong attemptsRemaining_;

		[FieldOffset(Offset="0x0")]
		public const int CooldownEndTimeFieldNumber = 2;

		[FieldOffset(Offset="0x20")]
		private ulong cooldownEndTime_;

		[FieldOffset(Offset="0x0")]
		public const int OpponentsFieldNumber = 3;

		[FieldOffset(Offset="0x8")]
		private readonly static FieldCodec<KothLobbyOpponent> _repeated_opponents_codec;

		[FieldOffset(Offset="0x28")]
		private readonly RepeatedField<KothLobbyOpponent> opponents_;

		[FieldOffset(Offset="0x0")]
		public const int PlayerRankFieldNumber = 4;

		[FieldOffset(Offset="0x30")]
		private ulong playerRank_;

		[FieldOffset(Offset="0x0")]
		public const int ShardIdFieldNumber = 5;

		[FieldOffset(Offset="0x38")]
		private ulong shardId_;

		[FieldOffset(Offset="0x0")]
		public const int DailyPayoutFieldNumber = 6;

		[FieldOffset(Offset="0x10")]
		private readonly static FieldCodec<ItemCount> _repeated_dailyPayout_codec;

		[FieldOffset(Offset="0x40")]
		private readonly RepeatedField<ItemCount> dailyPayout_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109B310", Offset="0x109B310")]
		public ulong AttemptsRemaining
		{
			[Address(RVA="0x1AA0618", Offset="0x1AA0618", VA="0x1AA0618")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1AA0620", Offset="0x1AA0620", VA="0x1AA0620")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109B320", Offset="0x109B320")]
		public ulong CooldownEndTime
		{
			[Address(RVA="0x1AA0628", Offset="0x1AA0628", VA="0x1AA0628")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1AA0630", Offset="0x1AA0630", VA="0x1AA0630")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109B360", Offset="0x109B360")]
		public RepeatedField<ItemCount> DailyPayout
		{
			[Address(RVA="0x1AA0660", Offset="0x1AA0660", VA="0x1AA0660")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109B2F0", Offset="0x109B2F0")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1AA02C8", Offset="0x1AA02C8", VA="0x1AA02C8")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109B330", Offset="0x109B330")]
		public RepeatedField<KothLobbyOpponent> Opponents
		{
			[Address(RVA="0x1AA0638", Offset="0x1AA0638", VA="0x1AA0638")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109B2E0", Offset="0x109B2E0")]
		public static MessageParser<KothLobbyResponse> Parser
		{
			[Address(RVA="0x1AA0260", Offset="0x1AA0260", VA="0x1AA0260")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109B300", Offset="0x109B300")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1AA03B8", Offset="0x1AA03B8", VA="0x1AA03B8", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109B340", Offset="0x109B340")]
		public ulong PlayerRank
		{
			[Address(RVA="0x1AA0640", Offset="0x1AA0640", VA="0x1AA0640")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1AA0648", Offset="0x1AA0648", VA="0x1AA0648")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109B350", Offset="0x109B350")]
		public ulong ShardId
		{
			[Address(RVA="0x1AA0650", Offset="0x1AA0650", VA="0x1AA0650")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1AA0658", Offset="0x1AA0658", VA="0x1AA0658")]
			set
			{
			}
		}

		[Address(RVA="0x1AA10BC", Offset="0x1AA10BC", VA="0x1AA10BC")]
		static KothLobbyResponse()
		{
		}

		[Address(RVA="0x1AA0414", Offset="0x1AA0414", VA="0x1AA0414")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10869AC", Offset="0x10869AC")]
		public KothLobbyResponse()
		{
		}

		[Address(RVA="0x1AA04AC", Offset="0x1AA04AC", VA="0x1AA04AC")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10869BC", Offset="0x10869BC")]
		public KothLobbyResponse(KothLobbyResponse other)
		{
		}

		[Address(RVA="0x1AA0BEC", Offset="0x1AA0BEC", VA="0x1AA0BEC", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1086A2C", Offset="0x1086A2C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1AA05B8", Offset="0x1AA05B8", VA="0x1AA05B8", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10869CC", Offset="0x10869CC")]
		public KothLobbyResponse Clone()
		{
			return null;
		}

		[Address(RVA="0x1AA0668", Offset="0x1AA0668", VA="0x1AA0668", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10869DC", Offset="0x10869DC")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1AA06DC", Offset="0x1AA06DC", VA="0x1AA06DC", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10869EC", Offset="0x10869EC")]
		public bool Equals(KothLobbyResponse other)
		{
			return new bool();
		}

		[Address(RVA="0x1AA07FC", Offset="0x1AA07FC", VA="0x1AA07FC", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10869FC", Offset="0x10869FC")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1AA0DF4", Offset="0x1AA0DF4", VA="0x1AA0DF4", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1086A3C", Offset="0x1086A3C")]
		public void MergeFrom(KothLobbyResponse other)
		{
		}

		[Address(RVA="0x1AA0EE0", Offset="0x1AA0EE0", VA="0x1AA0EE0", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1086A4C", Offset="0x1086A4C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1AA0904", Offset="0x1AA0904", VA="0x1AA0904", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1086A0C", Offset="0x1086A0C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1AA096C", Offset="0x1AA096C", VA="0x1AA096C", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1086A1C", Offset="0x1086A1C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1050828", Offset="0x1050828")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static KothLobbyResponse.<>c <>9;

			[Address(RVA="0x1AA1224", Offset="0x1AA1224", VA="0x1AA1224")]
			static <>c()
			{
			}

			[Address(RVA="0x1AA1288", Offset="0x1AA1288", VA="0x1AA1288")]
			public <>c()
			{
			}

			[Address(RVA="0x1AA1290", Offset="0x1AA1290", VA="0x1AA1290")]
			internal KothLobbyResponse <.cctor>b__50_0()
			{
				return null;
			}
		}
	}
}