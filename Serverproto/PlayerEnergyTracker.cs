using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class PlayerEnergyTracker : IMessage<PlayerEnergyTracker>, IMessage, IEquatable<PlayerEnergyTracker>, IDeepCloneable<PlayerEnergyTracker>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<PlayerEnergyTracker> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int ItemIdFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private ulong itemId_;

		[FieldOffset(Offset="0x0")]
		public const int LastGeneratedTimestampFieldNumber = 2;

		[FieldOffset(Offset="0x20")]
		private ulong lastGeneratedTimestamp_;

		[FieldOffset(Offset="0x0")]
		public const int DailyRefreshesPurchasedFieldNumber = 3;

		[FieldOffset(Offset="0x28")]
		private ulong dailyRefreshesPurchased_;

		[FieldOffset(Offset="0x0")]
		public const int DailyGiftsFieldNumber = 4;

		[FieldOffset(Offset="0x8")]
		private readonly static FieldCodec<PlayerEnergyDailyGifts> _repeated_dailyGifts_codec;

		[FieldOffset(Offset="0x30")]
		private readonly RepeatedField<PlayerEnergyDailyGifts> dailyGifts_;

		[FieldOffset(Offset="0x0")]
		public const int DailyAdRewardCountFieldNumber = 5;

		[FieldOffset(Offset="0x38")]
		private ulong dailyAdRewardCount_;

		[FieldOffset(Offset="0x0")]
		public const int BonusGenerateEndTimestampFieldNumber = 6;

		[FieldOffset(Offset="0x40")]
		private ulong bonusGenerateEndTimestamp_;

		[FieldOffset(Offset="0x0")]
		public const int DailyBonusGenerateClaimsFieldNumber = 7;

		[FieldOffset(Offset="0x48")]
		private ulong dailyBonusGenerateClaims_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109A0B0", Offset="0x109A0B0")]
		public ulong BonusGenerateEndTimestamp
		{
			[Address(RVA="0x1AF8488", Offset="0x1AF8488", VA="0x1AF8488")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1AF8490", Offset="0x1AF8490", VA="0x1AF8490")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109A0A0", Offset="0x109A0A0")]
		public ulong DailyAdRewardCount
		{
			[Address(RVA="0x1AF8478", Offset="0x1AF8478", VA="0x1AF8478")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1AF8480", Offset="0x1AF8480", VA="0x1AF8480")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109A0C0", Offset="0x109A0C0")]
		public ulong DailyBonusGenerateClaims
		{
			[Address(RVA="0x1AF8498", Offset="0x1AF8498", VA="0x1AF8498")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1AF84A0", Offset="0x1AF84A0", VA="0x1AF84A0")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109A090", Offset="0x109A090")]
		public RepeatedField<PlayerEnergyDailyGifts> DailyGifts
		{
			[Address(RVA="0x1AF8470", Offset="0x1AF8470", VA="0x1AF8470")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109A080", Offset="0x109A080")]
		public ulong DailyRefreshesPurchased
		{
			[Address(RVA="0x1AF8460", Offset="0x1AF8460", VA="0x1AF8460")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1AF8468", Offset="0x1AF8468", VA="0x1AF8468")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109A040", Offset="0x109A040")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1AF8120", Offset="0x1AF8120", VA="0x1AF8120")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109A060", Offset="0x109A060")]
		public ulong ItemId
		{
			[Address(RVA="0x1AF8440", Offset="0x1AF8440", VA="0x1AF8440")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1AF8448", Offset="0x1AF8448", VA="0x1AF8448")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109A070", Offset="0x109A070")]
		public ulong LastGeneratedTimestamp
		{
			[Address(RVA="0x1AF8450", Offset="0x1AF8450", VA="0x1AF8450")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1AF8458", Offset="0x1AF8458", VA="0x1AF8458")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109A030", Offset="0x109A030")]
		public static MessageParser<PlayerEnergyTracker> Parser
		{
			[Address(RVA="0x1AF80B8", Offset="0x1AF80B8", VA="0x1AF80B8")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109A050", Offset="0x109A050")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1AF820C", Offset="0x1AF820C", VA="0x1AF820C", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1AF8F60", Offset="0x1AF8F60", VA="0x1AF8F60")]
		static PlayerEnergyTracker()
		{
		}

		[Address(RVA="0x1AF8268", Offset="0x1AF8268", VA="0x1AF8268")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1083C4C", Offset="0x1083C4C")]
		public PlayerEnergyTracker()
		{
		}

		[Address(RVA="0x1AF82D8", Offset="0x1AF82D8", VA="0x1AF82D8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1083C5C", Offset="0x1083C5C")]
		public PlayerEnergyTracker(PlayerEnergyTracker other)
		{
		}

		[Address(RVA="0x1AF8A80", Offset="0x1AF8A80", VA="0x1AF8A80", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1083CCC", Offset="0x1083CCC")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1AF83E0", Offset="0x1AF83E0", VA="0x1AF83E0", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1083C6C", Offset="0x1083C6C")]
		public PlayerEnergyTracker Clone()
		{
			return null;
		}

		[Address(RVA="0x1AF84A8", Offset="0x1AF84A8", VA="0x1AF84A8", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1083C7C", Offset="0x1083C7C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1AF851C", Offset="0x1AF851C", VA="0x1AF851C", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1083C8C", Offset="0x1083C8C")]
		public bool Equals(PlayerEnergyTracker other)
		{
			return new bool();
		}

		[Address(RVA="0x1AF862C", Offset="0x1AF862C", VA="0x1AF862C", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1083C9C", Offset="0x1083C9C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1AF8CA4", Offset="0x1AF8CA4", VA="0x1AF8CA4", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1083CDC", Offset="0x1083CDC")]
		public void MergeFrom(PlayerEnergyTracker other)
		{
		}

		[Address(RVA="0x1AF8D7C", Offset="0x1AF8D7C", VA="0x1AF8D7C", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1083CEC", Offset="0x1083CEC")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1AF8744", Offset="0x1AF8744", VA="0x1AF8744", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1083CAC", Offset="0x1083CAC")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1AF87AC", Offset="0x1AF87AC", VA="0x1AF87AC", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1083CBC", Offset="0x1083CBC")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1050408", Offset="0x1050408")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static PlayerEnergyTracker.<>c <>9;

			[Address(RVA="0x1AF9080", Offset="0x1AF9080", VA="0x1AF9080")]
			static <>c()
			{
			}

			[Address(RVA="0x1AF90E4", Offset="0x1AF90E4", VA="0x1AF90E4")]
			public <>c()
			{
			}

			[Address(RVA="0x1AF90EC", Offset="0x1AF90EC", VA="0x1AF90EC")]
			internal PlayerEnergyTracker <.cctor>b__55_0()
			{
				return null;
			}
		}
	}
}