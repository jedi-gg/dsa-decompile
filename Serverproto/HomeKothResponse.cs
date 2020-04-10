using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class HomeKothResponse : IMessage<HomeKothResponse>, IMessage, IEquatable<HomeKothResponse>, IDeepCloneable<HomeKothResponse>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<HomeKothResponse> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int CurrentRankFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private uint currentRank_;

		[FieldOffset(Offset="0x0")]
		public const int AttemptsRemainingFieldNumber = 2;

		[FieldOffset(Offset="0x1C")]
		private uint attemptsRemaining_;

		[FieldOffset(Offset="0x0")]
		public const int AttackCooldownEndTimeFieldNumber = 3;

		[FieldOffset(Offset="0x20")]
		private ulong attackCooldownEndTime_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1098080", Offset="0x1098080")]
		public ulong AttackCooldownEndTime
		{
			[Address(RVA="0x1D063D0", Offset="0x1D063D0", VA="0x1D063D0")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1D063D8", Offset="0x1D063D8", VA="0x1D063D8")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1098070", Offset="0x1098070")]
		public uint AttemptsRemaining
		{
			[Address(RVA="0x1D063C0", Offset="0x1D063C0", VA="0x1D063C0")]
			get
			{
				return new uint();
			}
			[Address(RVA="0x1D063C8", Offset="0x1D063C8", VA="0x1D063C8")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1098060", Offset="0x1098060")]
		public uint CurrentRank
		{
			[Address(RVA="0x1D063B0", Offset="0x1D063B0", VA="0x1D063B0")]
			get
			{
				return new uint();
			}
			[Address(RVA="0x1D063B8", Offset="0x1D063B8", VA="0x1D063B8")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1098040", Offset="0x1098040")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1D06164", Offset="0x1D06164", VA="0x1D06164")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1098030", Offset="0x1098030")]
		public static MessageParser<HomeKothResponse> Parser
		{
			[Address(RVA="0x1D060FC", Offset="0x1D060FC", VA="0x1D060FC")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1098050", Offset="0x1098050")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1D06250", Offset="0x1D06250", VA="0x1D06250", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1D0694C", Offset="0x1D0694C", VA="0x1D0694C")]
		static HomeKothResponse()
		{
		}

		[Address(RVA="0x1D062AC", Offset="0x1D062AC", VA="0x1D062AC")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108100C", Offset="0x108100C")]
		public HomeKothResponse()
		{
		}

		[Address(RVA="0x1D062B4", Offset="0x1D062B4", VA="0x1D062B4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108101C", Offset="0x108101C")]
		public HomeKothResponse(HomeKothResponse other)
		{
		}

		[Address(RVA="0x1D0670C", Offset="0x1D0670C", VA="0x1D0670C", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108108C", Offset="0x108108C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1D06350", Offset="0x1D06350", VA="0x1D06350", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108102C", Offset="0x108102C")]
		public HomeKothResponse Clone()
		{
			return null;
		}

		[Address(RVA="0x1D063E0", Offset="0x1D063E0", VA="0x1D063E0", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108103C", Offset="0x108103C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1D06454", Offset="0x1D06454", VA="0x1D06454", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108104C", Offset="0x108104C")]
		public bool Equals(HomeKothResponse other)
		{
			return new bool();
		}

		[Address(RVA="0x1D064B0", Offset="0x1D064B0", VA="0x1D064B0", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108105C", Offset="0x108105C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1D0681C", Offset="0x1D0681C", VA="0x1D0681C", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108109C", Offset="0x108109C")]
		public void MergeFrom(HomeKothResponse other)
		{
		}

		[Address(RVA="0x1D06874", Offset="0x1D06874", VA="0x1D06874", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10810AC", Offset="0x10810AC")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1D06554", Offset="0x1D06554", VA="0x1D06554", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108106C", Offset="0x108106C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1D065BC", Offset="0x1D065BC", VA="0x1D065BC", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108107C", Offset="0x108107C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1050008", Offset="0x1050008")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static HomeKothResponse.<>c <>9;

			[Address(RVA="0x1D06A24", Offset="0x1D06A24", VA="0x1D06A24")]
			static <>c()
			{
			}

			[Address(RVA="0x1D06A88", Offset="0x1D06A88", VA="0x1D06A88")]
			public <>c()
			{
			}

			[Address(RVA="0x1D06A90", Offset="0x1D06A90", VA="0x1D06A90")]
			internal HomeKothResponse <.cctor>b__35_0()
			{
				return null;
			}
		}
	}
}