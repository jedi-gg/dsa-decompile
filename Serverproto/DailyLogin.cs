using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class DailyLogin : IMessage<DailyLogin>, IMessage, IEquatable<DailyLogin>, IDeepCloneable<DailyLogin>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<DailyLogin> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int RewardsFieldNumber = 1;

		[FieldOffset(Offset="0x8")]
		private readonly static FieldCodec<ItemCount> _repeated_rewards_codec;

		[FieldOffset(Offset="0x18")]
		private readonly RepeatedField<ItemCount> rewards_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109AC20", Offset="0x109AC20")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1EF594C", Offset="0x1EF594C", VA="0x1EF594C")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109AC10", Offset="0x109AC10")]
		public static MessageParser<DailyLogin> Parser
		{
			[Address(RVA="0x1EF58E4", Offset="0x1EF58E4", VA="0x1EF58E4")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109AC30", Offset="0x109AC30")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1EF5A3C", Offset="0x1EF5A3C", VA="0x1EF5A3C", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109AC40", Offset="0x109AC40")]
		public RepeatedField<ItemCount> Rewards
		{
			[Address(RVA="0x1EF5C00", Offset="0x1EF5C00", VA="0x1EF5C00")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1EF60E8", Offset="0x1EF60E8", VA="0x1EF60E8")]
		static DailyLogin()
		{
		}

		[Address(RVA="0x1EF5A98", Offset="0x1EF5A98", VA="0x1EF5A98")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108571C", Offset="0x108571C")]
		public DailyLogin()
		{
		}

		[Address(RVA="0x1EF5B08", Offset="0x1EF5B08", VA="0x1EF5B08")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108572C", Offset="0x108572C")]
		public DailyLogin(DailyLogin other)
		{
		}

		[Address(RVA="0x1EF5EB8", Offset="0x1EF5EB8", VA="0x1EF5EB8", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108579C", Offset="0x108579C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1EF5BA0", Offset="0x1EF5BA0", VA="0x1EF5BA0", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108573C", Offset="0x108573C")]
		public DailyLogin Clone()
		{
			return null;
		}

		[Address(RVA="0x1EF5C08", Offset="0x1EF5C08", VA="0x1EF5C08", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108574C", Offset="0x108574C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1EF5C7C", Offset="0x1EF5C7C", VA="0x1EF5C7C", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108575C", Offset="0x108575C")]
		public bool Equals(DailyLogin other)
		{
			return new bool();
		}

		[Address(RVA="0x1EF5D2C", Offset="0x1EF5D2C", VA="0x1EF5D2C", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108576C", Offset="0x108576C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1EF5F74", Offset="0x1EF5F74", VA="0x1EF5F74", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10857AC", Offset="0x10857AC")]
		public void MergeFrom(DailyLogin other)
		{
		}

		[Address(RVA="0x1EF6004", Offset="0x1EF6004", VA="0x1EF6004", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10857BC", Offset="0x10857BC")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1EF5D8C", Offset="0x1EF5D8C", VA="0x1EF5D8C", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108577C", Offset="0x108577C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1EF5DF4", Offset="0x1EF5DF4", VA="0x1EF5DF4", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108578C", Offset="0x108578C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1050678", Offset="0x1050678")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static DailyLogin.<>c <>9;

			[Address(RVA="0x1EF620C", Offset="0x1EF620C", VA="0x1EF620C")]
			static <>c()
			{
			}

			[Address(RVA="0x1EF6270", Offset="0x1EF6270", VA="0x1EF6270")]
			public <>c()
			{
			}

			[Address(RVA="0x1EF6278", Offset="0x1EF6278", VA="0x1EF6278")]
			internal DailyLogin <.cctor>b__25_0()
			{
				return null;
			}
		}
	}
}