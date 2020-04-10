using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class DailyRewardClaimRequest : IMessage<DailyRewardClaimRequest>, IMessage, IEquatable<DailyRewardClaimRequest>, IDeepCloneable<DailyRewardClaimRequest>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<DailyRewardClaimRequest> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int RewardIdFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private ulong rewardId_;

		[FieldOffset(Offset="0x0")]
		public const int TierIndexFieldNumber = 2;

		[FieldOffset(Offset="0x20")]
		private ulong tierIndex_;

		[FieldOffset(Offset="0x0")]
		public const int RewardIndexFieldNumber = 3;

		[FieldOffset(Offset="0x28")]
		private ulong rewardIndex_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109B820", Offset="0x109B820")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1EF7B84", Offset="0x1EF7B84", VA="0x1EF7B84")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109B810", Offset="0x109B810")]
		public static MessageParser<DailyRewardClaimRequest> Parser
		{
			[Address(RVA="0x1EF7B1C", Offset="0x1EF7B1C", VA="0x1EF7B1C")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109B830", Offset="0x109B830")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1EF7C74", Offset="0x1EF7C74", VA="0x1EF7C74", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109B840", Offset="0x109B840")]
		public ulong RewardId
		{
			[Address(RVA="0x1EF7DD4", Offset="0x1EF7DD4", VA="0x1EF7DD4")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1EF7DDC", Offset="0x1EF7DDC", VA="0x1EF7DDC")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109B860", Offset="0x109B860")]
		public ulong RewardIndex
		{
			[Address(RVA="0x1EF7DF4", Offset="0x1EF7DF4", VA="0x1EF7DF4")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1EF7DFC", Offset="0x1EF7DFC", VA="0x1EF7DFC")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109B850", Offset="0x109B850")]
		public ulong TierIndex
		{
			[Address(RVA="0x1EF7DE4", Offset="0x1EF7DE4", VA="0x1EF7DE4")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1EF7DEC", Offset="0x1EF7DEC", VA="0x1EF7DEC")]
			set
			{
			}
		}

		[Address(RVA="0x1EF836C", Offset="0x1EF836C", VA="0x1EF836C")]
		static DailyRewardClaimRequest()
		{
		}

		[Address(RVA="0x1EF7CD0", Offset="0x1EF7CD0", VA="0x1EF7CD0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10873FC", Offset="0x10873FC")]
		public DailyRewardClaimRequest()
		{
		}

		[Address(RVA="0x1EF7CD8", Offset="0x1EF7CD8", VA="0x1EF7CD8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108740C", Offset="0x108740C")]
		public DailyRewardClaimRequest(DailyRewardClaimRequest other)
		{
		}

		[Address(RVA="0x1EF812C", Offset="0x1EF812C", VA="0x1EF812C", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108747C", Offset="0x108747C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1EF7D74", Offset="0x1EF7D74", VA="0x1EF7D74", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108741C", Offset="0x108741C")]
		public DailyRewardClaimRequest Clone()
		{
			return null;
		}

		[Address(RVA="0x1EF7E04", Offset="0x1EF7E04", VA="0x1EF7E04", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108742C", Offset="0x108742C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1EF7E78", Offset="0x1EF7E78", VA="0x1EF7E78", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108743C", Offset="0x108743C")]
		public bool Equals(DailyRewardClaimRequest other)
		{
			return new bool();
		}

		[Address(RVA="0x1EF7ED4", Offset="0x1EF7ED4", VA="0x1EF7ED4", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108744C", Offset="0x108744C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1EF823C", Offset="0x1EF823C", VA="0x1EF823C", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108748C", Offset="0x108748C")]
		public void MergeFrom(DailyRewardClaimRequest other)
		{
		}

		[Address(RVA="0x1EF8294", Offset="0x1EF8294", VA="0x1EF8294", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108749C", Offset="0x108749C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1EF7F74", Offset="0x1EF7F74", VA="0x1EF7F74", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108745C", Offset="0x108745C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1EF7FDC", Offset="0x1EF7FDC", VA="0x1EF7FDC", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108746C", Offset="0x108746C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1050918", Offset="0x1050918")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static DailyRewardClaimRequest.<>c <>9;

			[Address(RVA="0x1EF8444", Offset="0x1EF8444", VA="0x1EF8444")]
			static <>c()
			{
			}

			[Address(RVA="0x1EF84A8", Offset="0x1EF84A8", VA="0x1EF84A8")]
			public <>c()
			{
			}

			[Address(RVA="0x1EF84B0", Offset="0x1EF84B0", VA="0x1EF84B0")]
			internal DailyRewardClaimRequest <.cctor>b__35_0()
			{
				return null;
			}
		}
	}
}