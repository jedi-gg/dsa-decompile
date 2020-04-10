using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class PlayerEnergyDailyGifts : IMessage<PlayerEnergyDailyGifts>, IMessage, IEquatable<PlayerEnergyDailyGifts>, IDeepCloneable<PlayerEnergyDailyGifts>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<PlayerEnergyDailyGifts> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int StartTimestampFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private ulong startTimestamp_;

		[FieldOffset(Offset="0x0")]
		public const int ClaimedFieldNumber = 2;

		[FieldOffset(Offset="0x20")]
		private bool claimed_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109A110", Offset="0x109A110")]
		public bool Claimed
		{
			[Address(RVA="0x1AF7AA8", Offset="0x1AF7AA8", VA="0x1AF7AA8")]
			get
			{
				return new bool();
			}
			[Address(RVA="0x1AF7AB0", Offset="0x1AF7AB0", VA="0x1AF7AB0")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109A0E0", Offset="0x109A0E0")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1AF7868", Offset="0x1AF7868", VA="0x1AF7868")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109A0D0", Offset="0x109A0D0")]
		public static MessageParser<PlayerEnergyDailyGifts> Parser
		{
			[Address(RVA="0x1AF7800", Offset="0x1AF7800", VA="0x1AF7800")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109A0F0", Offset="0x109A0F0")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1AF7954", Offset="0x1AF7954", VA="0x1AF7954", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109A100", Offset="0x109A100")]
		public ulong StartTimestamp
		{
			[Address(RVA="0x1AF7A98", Offset="0x1AF7A98", VA="0x1AF7A98")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1AF7AA0", Offset="0x1AF7AA0", VA="0x1AF7AA0")]
			set
			{
			}
		}

		[Address(RVA="0x1AF7F18", Offset="0x1AF7F18", VA="0x1AF7F18")]
		static PlayerEnergyDailyGifts()
		{
		}

		[Address(RVA="0x1AF79B0", Offset="0x1AF79B0", VA="0x1AF79B0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1083CFC", Offset="0x1083CFC")]
		public PlayerEnergyDailyGifts()
		{
		}

		[Address(RVA="0x1AF79B8", Offset="0x1AF79B8", VA="0x1AF79B8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1083D0C", Offset="0x1083D0C")]
		public PlayerEnergyDailyGifts(PlayerEnergyDailyGifts other)
		{
		}

		[Address(RVA="0x1AF7D7C", Offset="0x1AF7D7C", VA="0x1AF7D7C", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1083D7C", Offset="0x1083D7C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1AF7A38", Offset="0x1AF7A38", VA="0x1AF7A38", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1083D1C", Offset="0x1083D1C")]
		public PlayerEnergyDailyGifts Clone()
		{
			return null;
		}

		[Address(RVA="0x1AF7ABC", Offset="0x1AF7ABC", VA="0x1AF7ABC", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1083D2C", Offset="0x1083D2C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1AF7B30", Offset="0x1AF7B30", VA="0x1AF7B30", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1083D3C", Offset="0x1083D3C")]
		public bool Equals(PlayerEnergyDailyGifts other)
		{
			return new bool();
		}

		[Address(RVA="0x1AF7B8C", Offset="0x1AF7B8C", VA="0x1AF7B8C", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1083D4C", Offset="0x1083D4C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1AF7E24", Offset="0x1AF7E24", VA="0x1AF7E24", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1083D8C", Offset="0x1083D8C")]
		public void MergeFrom(PlayerEnergyDailyGifts other)
		{
		}

		[Address(RVA="0x1AF7E70", Offset="0x1AF7E70", VA="0x1AF7E70", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1083D9C", Offset="0x1083D9C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1AF7C18", Offset="0x1AF7C18", VA="0x1AF7C18", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1083D5C", Offset="0x1083D5C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1AF7C80", Offset="0x1AF7C80", VA="0x1AF7C80", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1083D6C", Offset="0x1083D6C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1050418", Offset="0x1050418")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static PlayerEnergyDailyGifts.<>c <>9;

			[Address(RVA="0x1AF7FF0", Offset="0x1AF7FF0", VA="0x1AF7FF0")]
			static <>c()
			{
			}

			[Address(RVA="0x1AF8054", Offset="0x1AF8054", VA="0x1AF8054")]
			public <>c()
			{
			}

			[Address(RVA="0x1AF805C", Offset="0x1AF805C", VA="0x1AF805C")]
			internal PlayerEnergyDailyGifts <.cctor>b__30_0()
			{
				return null;
			}
		}
	}
}