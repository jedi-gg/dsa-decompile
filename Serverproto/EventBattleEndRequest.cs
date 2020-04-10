using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class EventBattleEndRequest : IMessage<EventBattleEndRequest>, IMessage, IEquatable<EventBattleEndRequest>, IDeepCloneable<EventBattleEndRequest>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<EventBattleEndRequest> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int WinFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private bool win_;

		[FieldOffset(Offset="0x0")]
		public const int StarLevelFieldNumber = 2;

		[FieldOffset(Offset="0x20")]
		private ulong starLevel_;

		[FieldOffset(Offset="0x0")]
		public const int ActivityResultsFieldNumber = 3;

		[FieldOffset(Offset="0x8")]
		private readonly static FieldCodec<BattleActivityResult> _repeated_activityResults_codec;

		[FieldOffset(Offset="0x28")]
		private readonly RepeatedField<BattleActivityResult> activityResults_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1092D10", Offset="0x1092D10")]
		public RepeatedField<BattleActivityResult> ActivityResults
		{
			[Address(RVA="0x1FCA618", Offset="0x1FCA618", VA="0x1FCA618")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1092CD0", Offset="0x1092CD0")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1FCA304", Offset="0x1FCA304", VA="0x1FCA304")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1092CC0", Offset="0x1092CC0")]
		public static MessageParser<EventBattleEndRequest> Parser
		{
			[Address(RVA="0x1FCA29C", Offset="0x1FCA29C", VA="0x1FCA29C")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1092CE0", Offset="0x1092CE0")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1FCA3F4", Offset="0x1FCA3F4", VA="0x1FCA3F4", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1092D00", Offset="0x1092D00")]
		public ulong StarLevel
		{
			[Address(RVA="0x1FCA608", Offset="0x1FCA608", VA="0x1FCA608")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1FCA610", Offset="0x1FCA610", VA="0x1FCA610")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1092CF0", Offset="0x1092CF0")]
		public bool Win
		{
			[Address(RVA="0x1FCA5F4", Offset="0x1FCA5F4", VA="0x1FCA5F4")]
			get
			{
				return new bool();
			}
			[Address(RVA="0x1FCA5FC", Offset="0x1FCA5FC", VA="0x1FCA5FC")]
			set
			{
			}
		}

		[Address(RVA="0x1FCACEC", Offset="0x1FCACEC", VA="0x1FCACEC")]
		static EventBattleEndRequest()
		{
		}

		[Address(RVA="0x1FCA450", Offset="0x1FCA450", VA="0x1FCA450")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107786C", Offset="0x107786C")]
		public EventBattleEndRequest()
		{
		}

		[Address(RVA="0x1FCA4C0", Offset="0x1FCA4C0", VA="0x1FCA4C0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107787C", Offset="0x107787C")]
		public EventBattleEndRequest(EventBattleEndRequest other)
		{
		}

		[Address(RVA="0x1FCAA04", Offset="0x1FCAA04", VA="0x1FCAA04", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10778EC", Offset="0x10778EC")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1FCA594", Offset="0x1FCA594", VA="0x1FCA594", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107788C", Offset="0x107788C")]
		public EventBattleEndRequest Clone()
		{
			return null;
		}

		[Address(RVA="0x1FCA620", Offset="0x1FCA620", VA="0x1FCA620", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107789C", Offset="0x107789C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1FCA694", Offset="0x1FCA694", VA="0x1FCA694", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10778AC", Offset="0x10778AC")]
		public bool Equals(EventBattleEndRequest other)
		{
			return new bool();
		}

		[Address(RVA="0x1FCA774", Offset="0x1FCA774", VA="0x1FCA774", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10778BC", Offset="0x10778BC")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1FCAB04", Offset="0x1FCAB04", VA="0x1FCAB04", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10778FC", Offset="0x10778FC")]
		public void MergeFrom(EventBattleEndRequest other)
		{
		}

		[Address(RVA="0x1FCABAC", Offset="0x1FCABAC", VA="0x1FCABAC", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107790C", Offset="0x107790C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1FCA824", Offset="0x1FCA824", VA="0x1FCA824", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10778CC", Offset="0x10778CC")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1FCA88C", Offset="0x1FCA88C", VA="0x1FCA88C", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10778DC", Offset="0x10778DC")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104F1F8", Offset="0x104F1F8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static EventBattleEndRequest.<>c <>9;

			[Address(RVA="0x1FCAE10", Offset="0x1FCAE10", VA="0x1FCAE10")]
			static <>c()
			{
			}

			[Address(RVA="0x1FCAE74", Offset="0x1FCAE74", VA="0x1FCAE74")]
			public <>c()
			{
			}

			[Address(RVA="0x1FCAE7C", Offset="0x1FCAE7C", VA="0x1FCAE7C")]
			internal EventBattleEndRequest <.cctor>b__35_0()
			{
				return null;
			}
		}
	}
}