using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class BattleLib_ActivityTracker : IMessage<BattleLib_ActivityTracker>, IMessage, IEquatable<BattleLib_ActivityTracker>, IDeepCloneable<BattleLib_ActivityTracker>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<BattleLib_ActivityTracker> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int ActivityIdFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private ulong activityId_;

		[FieldOffset(Offset="0x0")]
		public const int TrackerIdFieldNumber = 2;

		[FieldOffset(Offset="0x20")]
		private ulong trackerId_;

		[FieldOffset(Offset="0x0")]
		public const int ValueFieldNumber = 3;

		[FieldOffset(Offset="0x28")]
		private ulong value_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10936B0", Offset="0x10936B0")]
		public ulong ActivityId
		{
			[Address(RVA="0x1E822AC", Offset="0x1E822AC", VA="0x1E822AC")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1E822B4", Offset="0x1E822B4", VA="0x1E822B4")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1093690", Offset="0x1093690")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1E82060", Offset="0x1E82060", VA="0x1E82060")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1093680", Offset="0x1093680")]
		public static MessageParser<BattleLib_ActivityTracker> Parser
		{
			[Address(RVA="0x1E81C50", Offset="0x1E81C50", VA="0x1E81C50")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10936A0", Offset="0x10936A0")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1E8214C", Offset="0x1E8214C", VA="0x1E8214C", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10936C0", Offset="0x10936C0")]
		public ulong TrackerId
		{
			[Address(RVA="0x1E822BC", Offset="0x1E822BC", VA="0x1E822BC")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1E822C4", Offset="0x1E822C4", VA="0x1E822C4")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10936D0", Offset="0x10936D0")]
		public ulong Value
		{
			[Address(RVA="0x1E822CC", Offset="0x1E822CC", VA="0x1E822CC")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1E822D4", Offset="0x1E822D4", VA="0x1E822D4")]
			set
			{
			}
		}

		[Address(RVA="0x1E82844", Offset="0x1E82844", VA="0x1E82844")]
		static BattleLib_ActivityTracker()
		{
		}

		[Address(RVA="0x1E821A8", Offset="0x1E821A8", VA="0x1E821A8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1078A4C", Offset="0x1078A4C")]
		public BattleLib_ActivityTracker()
		{
		}

		[Address(RVA="0x1E821B0", Offset="0x1E821B0", VA="0x1E821B0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1078A5C", Offset="0x1078A5C")]
		public BattleLib_ActivityTracker(BattleLib_ActivityTracker other)
		{
		}

		[Address(RVA="0x1E82604", Offset="0x1E82604", VA="0x1E82604", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1078ACC", Offset="0x1078ACC")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1E8224C", Offset="0x1E8224C", VA="0x1E8224C", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1078A6C", Offset="0x1078A6C")]
		public BattleLib_ActivityTracker Clone()
		{
			return null;
		}

		[Address(RVA="0x1E822DC", Offset="0x1E822DC", VA="0x1E822DC", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1078A7C", Offset="0x1078A7C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1E82350", Offset="0x1E82350", VA="0x1E82350", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1078A8C", Offset="0x1078A8C")]
		public bool Equals(BattleLib_ActivityTracker other)
		{
			return new bool();
		}

		[Address(RVA="0x1E823AC", Offset="0x1E823AC", VA="0x1E823AC", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1078A9C", Offset="0x1078A9C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1E82714", Offset="0x1E82714", VA="0x1E82714", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1078ADC", Offset="0x1078ADC")]
		public void MergeFrom(BattleLib_ActivityTracker other)
		{
		}

		[Address(RVA="0x1E8276C", Offset="0x1E8276C", VA="0x1E8276C", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1078AEC", Offset="0x1078AEC")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1E8244C", Offset="0x1E8244C", VA="0x1E8244C", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1078AAC", Offset="0x1078AAC")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1E824B4", Offset="0x1E824B4", VA="0x1E824B4", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1078ABC", Offset="0x1078ABC")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104F398", Offset="0x104F398")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static BattleLib_ActivityTracker.<>c <>9;

			[Address(RVA="0x1E8291C", Offset="0x1E8291C", VA="0x1E8291C")]
			static <>c()
			{
			}

			[Address(RVA="0x1E82980", Offset="0x1E82980", VA="0x1E82980")]
			public <>c()
			{
			}

			[Address(RVA="0x1E82988", Offset="0x1E82988", VA="0x1E82988")]
			internal BattleLib_ActivityTracker <.cctor>b__35_0()
			{
				return null;
			}
		}
	}
}